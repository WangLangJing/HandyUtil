using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace PowerOnRegister
{
    public class RegisterManager
    {

        public static RegistryKey FetchPowerOnKey()
        {
            RegistryKey registerKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            return registerKey;
        }

        public static Boolean AddOrUpdatePowerOnItemValue(String name, String value, String parameter)
        {
       
            Boolean isAlterd = false;
            RegistryKey registerKey = FetchPowerOnKey();
            if (registerKey != null)
            {
                try
                {
                    registerKey.SetValue(name, value + "  " + parameter);
                    isAlterd = true;
                }
                catch
                {
                }
                finally
                {
                    registerKey.Close();
                }
            }
            return isAlterd;
        }
    }
}
