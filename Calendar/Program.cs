using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Calendar
{
    [CacheType("Hellp")]
    public class Student
    {
        public Int32 Age { get; set; }
        public Int32 Name { get; set; }
    }
    public class student
    {
        public Int32 Age { get; set; }
        public Int32 Name { get; set; }
    }
  
   
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Student student = new Student();
            Assembly assembly = Assembly.GetExecutingAssembly();

       
            Type type = assembly.GetType("Calendar.student",false,true);
            Type[] types = assembly.GetExportedTypes();
            Attribute[] objs = Attribute.GetCustomAttributes(typeof(Student), typeof(CacheTypeAttribute));
            var attrs = assembly.GetCustomAttributes(typeof(CacheTypeAttribute), false);
            Int32 length = attrs.Length;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
