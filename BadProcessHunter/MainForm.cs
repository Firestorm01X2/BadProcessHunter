using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using BadProcessHunter.Classes;
using System.Threading;

namespace BadProcessHunter
{
    public partial class MainForm : Form
    {
        private string processName;
        private bool startFile;
        private string startFilePath;
        private int interval;
        private BadProcessHunterWorker hunter = new BadProcessHunterWorker();
        private static string SettingsFileName = "Settings.xml";
        private string SetitngsFilePath = Application.StartupPath + "//" + SettingsFileName;

        public MainForm()
        {
            InitializeComponent();
            btStart.Enabled = true;
            btStop.Enabled = false;
            chbStartFile.Checked = false;
            nudCheclInterval.Enabled = true;
            chbStartFile.Checked = false;
            tbStartFilePath.Enabled = false;
            LoadSettings();
            tbStatus.Text = "Готов к работе";
            Start();

        }

        private void UpdateControls()
        {
            tbProcessName.Text = processName;
            nudCheclInterval.Value = Convert.ToInt32(interval / 1000);
            chbStartFile.Checked = startFile;
            tbStartFilePath.Text = startFilePath;
        }

        private void LoadSettings()
        {
            if (File.Exists(SetitngsFilePath))
            {
                FileStream readFileStream = null;
                try
                {
                    XmlSerializer SerializerObj = new XmlSerializer(typeof(Settings));
                    readFileStream = new FileStream(SetitngsFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    Settings settings = (Settings)SerializerObj.Deserialize(readFileStream);
                    processName = settings.ProcessName;
                    interval = settings.Interval * 1000;
                    startFile = settings.StartFile;
                    startFilePath = settings.StartFilePath;
                    UpdateControls();
                }
                catch (Exception)
                {
                }

                finally
                {
                    if (readFileStream != null)
                        readFileStream.Close();
                }

            }
        }

        private void SaveSettings()
        {
            TextWriter writeFileStream = null;
            try
            {
                XmlSerializer SerializerObj = new XmlSerializer(typeof(Settings));
                writeFileStream = new StreamWriter(SetitngsFilePath);
                Settings settings = new Settings(tbProcessName.Text, Convert.ToInt32(nudCheclInterval.Value), chbStartFile.Checked, tbStartFilePath.Text);
                SerializerObj.Serialize(writeFileStream, settings);
            }
            catch (Exception)
            {

            }
            finally
            {
                if (writeFileStream != null)
                    writeFileStream.Close();
            }
        }

        private void AddMessage(string message)
        {
            if (tbInfo.Lines.Length > 9000) tbInfo.Text = "";

            tbInfo.Text += DateTime.Now.ToString() + " : " + message + Environment.NewLine;
        }

        private void Start()
        {
            processName = tbProcessName.Text.Trim();
            if (processName == String.Empty)
            {
                ErrorPopup.SetError(tbProcessName, "Введите имя процесса.");
                ErrorPopup.ShowPopup();
                return;
            }

            try
            {
                interval = Convert.ToInt32(nudCheclInterval.Value) * 1000;
                if (interval <= 0)
                {
                    throw new Exception();
                }
                timer.Interval = interval;
            }
            catch
            {
                ErrorPopup.SetError(nudCheclInterval, "Укажите корректный интервал.");
                ErrorPopup.ShowPopup();
                return;
            }
            startFilePath = tbStartFilePath.Text;
            if (startFilePath.Trim() == String.Empty || !File.Exists(startFilePath))
            {
                ErrorPopup.SetError(tbStartFilePath, "Укажите существующий файл.");
                ErrorPopup.ShowPopup();
            }

            startFile = chbStartFile.Checked;


            timer.Start();
            btStart.Enabled = false;
            btStop.Enabled = true;
            tbProcessName.Enabled = false;
            nudCheclInterval.Enabled = false;
            chbStartFile.Enabled = false;
            tbStartFilePath.Enabled = false;
            tbStatus.Text = "Работает";
            AddMessage("Запуск призведён");
        }

        private void Stop()
        {
            timer.Stop();
            btStart.Enabled = true;
            btStop.Enabled = false;
            tbProcessName.Enabled = true;
            nudCheclInterval.Enabled = true;
            chbStartFile.Enabled = true;
            tbStartFilePath.Enabled = true;
            tbStatus.Text = "Остановлено";
            AddMessage("Работа остановлена");
        }

        private void CheckKillRun()
        {
            if (hunter.TerminateNotRespondingProcess(processName))
            {
                AddMessage("Процесс: " + processName + " был признан зависшим и жестоко убит");
                if (startFile)
                {
                    AddMessage("Запускаем: " + startFilePath);
                    hunter.StartProcess(startFilePath);
                }
            }
        }

        private void CheckMissingRun()
        {
            if (hunter.CheckIfProcessExits(processName))
                return;

            AddMessage("Процесс: " + processName + " отсутвует!");
            if (startFile)
            {
                AddMessage("Запускаем: " + startFilePath);
                hunter.StartProcess(startFilePath);
                
                if (chbCloseAfterRun.Checked)
                {
                    AddMessage("Закрываем утилиту");
                    Thread.Sleep(2000);
                    this.Close();
                }
            }

            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //CheckKillRun();
            CheckMissingRun();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void chbRunFile_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            if (chb.Checked)
            {
                tbStartFilePath.Enabled = true;
            }
            else
            {
                tbStartFilePath.Enabled = false;
            }
        }

        private void SetStartFilePath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Укжаите файл";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbStartFilePath.Text = dialog.FileName;
            }

        }

        private void btSelectFileToRun_Click(object sender, EventArgs e)
        {
            SetStartFilePath();
        }
    }
}
