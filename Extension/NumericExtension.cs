using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyUtil
{
    public static class NumericExtension
    {
        /// <summary>
        ///辅助数组-数字转中文大写-阿拉伯数字的中文大写
        /// </summary>
        internal static Dictionary<Char, String> NumberChineseWrittenDic = new Dictionary<Char, String>{
            {'0',"零" },
            {'1',"壹" },
            {'2',"贰" },
            {'3',"叁" },
            {'4',"肆" },
            {'5',"伍" },
            {'6',"陆" },
            {'7',"柒" },
            {'8',"捌" },
            {'9',"玖" }
        };
        /// <summary>
        /// 辅助数组-数字转中文大写
        /// </summary>
        internal static String[] NumberScaleChineseWritten = new String[]
            {
                "兆","千亿", "百亿" ,"拾亿" ,"亿","千万","百万","拾万" ,"万" ,"千" ,"百" ,"拾" ,"元", "分","厘","毫","兰","忽" ,"微"
            };
        /// <summary>
        /// HandyUtil-Extension:将金额值转换为中文大写金额字符串
        /// </summary>
        /// <param name="num">需要转换的数字</param>
        /// <returns>中文大写金额字符串</returns>
        public static String ToCapitalizationString(this Decimal num)
        {
            String convertResult = null;
            String numStr = num.ToString();
            return convertResult;
        }
        internal static String ToCapitalizationString(String numStr)
        {
            String convertResult = null;
            var splitResult = numStr.Split('.');
            String integerPartStr = splitResult[0];
            String decimalsPartStr = splitResult.Length > 1 ? splitResult[1] : null;
            if (!integerPartStr.IsNullOrEmpty())
            {
                convertResult = String.Empty;
                Char numChar = Char.MinValue;
                for (Int32 i= integerPartStr.Length;i>0;--i)
                {
                     numChar = integerPartStr[i];
                }
                if (!decimalsPartStr.IsNullOrEmpty())
                {
                     
                }
            }
            return convertResult;
        }
    }
}
