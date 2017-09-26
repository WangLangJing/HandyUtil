using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using HandyUtil;
using System.Text.RegularExpressions;

namespace HandyUtilConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 2;
            Object b = a;
            Object c = b;
            c = 3;
            Console.WriteLine(c.ToString());
            Console.WriteLine(b.ToString());
            //String idCardNum = "642223199410200038";
            //String idCardNum1 = "64222319941020003x";
            //String phoneNum = "0954-3015535";
            //Console.WriteLine(phoneNum.IsPhoneNumber());
            //Console.WriteLine(idCardNum1.IsIdCardNumber());
            //String test = "115230.01";
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //for (Int32 i = 0; i < 10000000; ++i)
            //{
            //    Boolean flag = test.IsNumeric();
            //}
            //stopwatch.Stop();
            //Console.WriteLine("profiler time:" + stopwatch.ElapsedMilliseconds.ToString());
        }
    }
}
