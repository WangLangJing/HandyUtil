using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyUtil
{
    public static class  DateTimeExtension
    {
        /// <summary>
        /// 表示当前日期是否是周六或者周日
        /// </summary>
        public static Boolean IsHoliday(this DateTime dateTime)
        {
            Int32 weekDay = (Int32)dateTime.DayOfWeek;
            return (weekDay == 6 || weekDay == 0);
        }
    }
}
