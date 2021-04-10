using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace BadProcessHunter.Classes
{
    public class BadProcessHunterWorker
    {
        //public bool TerminateNotRespondingProcess(string processName)
        //{
        //    string processPath;
        //    return TerminateNotRespondingProcess(processName, out processPath);
        //}

        /// <summary>
        /// Запустить процесс.
        /// </summary>
        public  void StartProcess(string filePath, string arguments)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = filePath;
                process.StartInfo.Arguments = arguments;
                process.Start();
            }
        }

        /// <summary>
        /// Запустить процесс.
        /// </summary>
        public void StartProcess(string filePath)
        {
            StartProcess(filePath, String.Empty);
        }

        public bool TerminateNotRespondingProcess(string processName)
        {

            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if (processName.Length == 0)
                    return false;
                Process process = processes[0];
                
                if (!IsResponding(process))
                {
   
                        process.Kill();
                    return true;
                }
                else
                    return false;

                return true;

            }
            catch (Exception)
            {

                return false;
            }
         

        }

        public bool CheckIfProcessExits(String processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if (processName.Length == 0)
                    return false;
                Process process = processes[0];
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessageTimeout(
            HandleRef hWnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam,
            int flags,
            int timeout,
            out IntPtr pdwResult);

        const int SMTO_ABORTIFHUNG = 2;

        bool IsResponding(Process process)
        {
            HandleRef handleRef = new HandleRef(process, process.MainWindowHandle);

            int timeout = 2000;
            IntPtr lpdwResult;

            IntPtr lResult = SendMessageTimeout(
                handleRef,
                0,
                IntPtr.Zero,
                IntPtr.Zero,
                SMTO_ABORTIFHUNG,
                timeout,
                out lpdwResult);

            return lResult != IntPtr.Zero;
        }
    }

}
