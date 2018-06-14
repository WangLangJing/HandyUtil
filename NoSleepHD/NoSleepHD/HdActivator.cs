using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace NoSleepHD
{
    public class HdActivator
    {
        private static String _Path = AppDomain.CurrentDomain.BaseDirectory+"Activate.dat";
        public static void Initlize()
        {
            if (!File.Exists(_Path))
            {
                File.Create(_Path).Close();
                File.SetAttributes(_Path, FileAttributes.Hidden);
            }
        }
        public static void ActivateHd()
        {
            Initlize();
            using (FileStream stream = new FileStream(_Path, FileMode.Truncate,FileAccess.Write, FileShare.ReadWrite, 8192, FileOptions.WriteThrough))
            {
                Byte[] buffer = new Byte[] { 1, 1, 1, 1 };
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }
    }
}
