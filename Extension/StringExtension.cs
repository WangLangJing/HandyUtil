using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyUtil
{
    public static class StringExtension
    {
        /// <summary>
        /// 判断字符串是空引用或者是空字符串
        /// </summary>
        public static Boolean IsNullOrEmpty(this String str)
        {
            return String.IsNullOrEmpty(str);
        }
        /// <summary>
        /// 判断字符串是空引用，或者完全是由空白字符组成的
        /// </summary>
        public static Boolean IsNullOrWhiteSpace(this String str)
        {
            return String.IsNullOrWhiteSpace(str);
        }
    }
}
