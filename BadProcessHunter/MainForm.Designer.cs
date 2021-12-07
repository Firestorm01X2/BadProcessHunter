namespace BadProcessHunter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.nudCheclInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.chbStartFile = new System.Windows.Forms.CheckBox();
            this.tbStartFilePath = new System.Windows.Forms.TextBox();
            this.btSelectFileToRun = new System.Windows.Forms.Button();
            this.chbCloseAfterRun = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheclInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(305, 7);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(90, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Запуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Location = new System.Drawing.Point(305, 37);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(90, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // tbProcessName
            // 
            this.tbProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcessName.Location = new System.Drawing.Point(4, 28);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(295, 20);
            this.tbProcessName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название процесса";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbInfo.Location = new System.Drawing.Point(4, 165);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(391, 160);
            this.tbInfo.TabIndex = 4;
            // 
            // nudCheclInterval
            // 
            this.nudCheclInterval.Location = new System.Drawing.Point(4, 67);
            this.nudCheclInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCheclInterval.Name = "nudCheclInterval";
            this.nudCheclInterval.Size = new System.Drawing.Size(134, 20);
            this.nudCheclInterval.TabIndex = 1;
            this.nudCheclInterval.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Интервал проверки (сек.)";
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Location = new System.Drawing.Point(222, 67);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(173, 20);
            this.tbStatus.TabIndex = 7;
            // 
            // chbStartFile
            // 
            this.chbStartFile.AutoSize = true;
            this.chbStartFile.Location = new System.Drawing.Point(4, 93);
            this.chbStartFile.Name = "chbStartFile";
            this.chbStartFile.Size = new System.Drawing.Size(230, 17);
            this.chbStartFile.TabIndex = 8;
            this.chbStartFile.Text = "Запустить после ичезновения процесса";
            this.chbStartFile.UseVisualStyleBackColor = true;
            this.chbStartFile.CheckedChanged += new System.EventHandler(this.chbRunFile_CheckedChanged);
            // 
            // tbStartFilePath
            // 
            this.tbStartFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStartFilePath.Location = new System.Drawing.Point(4, 116);
            this.tbStartFilePath.Name = "tbStartFilePath";
            this.tbStartFilePath.Size = new System.Drawing.Size(349, 20);
            this.tbStartFilePath.TabIndex = 2;
            // 
            // btSelectFileToRun
            // 
            this.btSelectFileToRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectFileToRun.Location = new System.Drawing.Point(359, 116);
            this.btSelectFileToRun.Name = "btSelectFileToRun";
            this.btSelectFileToRun.Size = new System.Drawing.Size(36, 23);
            this.btSelectFileToRun.TabIndex = 3;
            this.btSelectFileToRun.Text = "...";
            this.btSelectFileToRun.UseVisualStyleBackColor = true;
            this.btSelectFileToRun.Click += new System.EventHandler(this.btSelectFileToRun_Click);
            // 
            // chbCloseAfterRun
            // 
            this.chbCloseAfterRun.AutoSize = true;
            this.chbCloseAfterRun.Location = new System.Drawing.Point(4, 142);
            this.chbCloseAfterRun.Name = "chbCloseAfterRun";
            this.chbCloseAfterRun.Size = new System.Drawing.Size(188, 17);
            this.chbCloseAfterRun.TabIndex = 9;
            this.chbCloseAfterRun.Text = "Закрыть утилиту после запуска";
            this.chbCloseAfterRun.UseVisualStyleBackColor = true;
            this.chbCloseAfterRun.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 337);
            this.Controls.Add(this.chbCloseAfterRun);
            this.Controls.Add(this.btSelectFileToRun);
            this.Controls.Add(this.tbStartFilePath);
            this.Controls.Add(this.chbStartFile);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCheclInterval);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProcessName);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "BadProcessHunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudCheclInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.NumericUpDown nudCheclInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.CheckBox chbStartFile;
        private System.Windows.Forms.TextBox tbStartFilePath;
        private System.Windows.Forms.Button btSelectFileToRun;
        private System.Windows.Forms.CheckBox chbCloseAfterRun;
    }
}

