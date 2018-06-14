using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
namespace WMI_CLASS_Monitor
{
    public class WMIFetcher
    {
        public static IList<String> FetchWMINamespace()
        {
            IList<String> mgtObjNameList = new List<String>();
            ManagementClass mgtClass =
                 new ManagementClass(
                 new ManagementScope("root"),
                 new ManagementPath("__namespace"),
                 null);
            foreach (ManagementObject single in mgtClass.GetInstances())
            {
                mgtObjNameList.Add(single["Name"].ToString());
            }
            return mgtObjNameList;
        }
        public static IList<ManagementClass> FetchWMIClass(String namesapceStr)
        {
            IList<ManagementClass> mgtClassList = new List<ManagementClass>();
            ManagementObjectSearcher searcher =
             new ManagementObjectSearcher(
             new ManagementScope(
               "root/"+namesapceStr),
             new WqlObjectQuery(
             "select * from meta_class"),
             null);
            foreach (ManagementClass wmiClass in
                searcher.Get())
            {
                mgtClassList.Add(wmiClass);
            }
            return mgtClassList;
        }
        public static ManagementObjectCollection FetchWMIClassInstance(String nameSpaceStr,String className)
        {
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("root/"+nameSpaceStr, String.Format("SELECT * FROM {0}", className));
            return objectSearcher.Get();
        }
    }
}
