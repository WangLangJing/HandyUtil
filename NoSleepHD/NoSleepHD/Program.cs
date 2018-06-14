using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading;

namespace NoSleepHD
{
    static class Program
    {
        public static Mutex _Mutex;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            _Mutex = new Mutex(true, "NoSleepHDOnly");
            if (!_Mutex.WaitOne(0, false))
            {
                MessageBox.Show("NoSleepHD has started!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NoSleepHDForm());
        }
    }
}
