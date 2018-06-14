using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Newtonsoft.Json;
namespace VSTranslator
{
    public sealed class TranslateApi
    {
        public const String BaseAddress = "http://api.fanyi.baidu.com/api/trans/vip/translate";
        public static readonly String AppId = "20180212000122459";
        public static readonly String Key = "h16eNiK25ZX996xcWiyd";
        public static String Translate(String source, String sourceType, String destType, String appId = null, String key = null)
        {
            String dest = source;
            WebClient client = new WebClient();

            String usedAppId = appId ?? TranslateApi.AppId;
            String usedKey = key ?? TranslateApi.Key;
            String random = TranslateApi.GetRandomStr();
            String checkout = usedAppId + source + random + usedKey;
            checkout = MD5(checkout);

            String uri =
                String.Format(
                TranslateApi.BaseAddress + "? q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}",
                source, sourceType, destType, usedAppId, random, checkout
                );
            var response = client.DownloadString(uri);
            var packet = ResponsePacket.From(response);
            if (packet.Successed)
            {
                dest = packet.Results[0].Dest;
            }
            return dest;
        }
        public static String GetRandomStr()
        {
            return DateTime.Now.Millisecond.ToString();
        }

        public static String MD5(String input)
        {
            if (input == null)
            {
                return null;
            }
            MD5 md = System.Security.Cryptography.MD5.Create();
            Byte[] buffer = Encoding.UTF8.GetBytes(input);
            Byte[] data = md.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            for (Int32 i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            //返回16进制字符串
            return sb.ToString();
        }
        public static String TranslateEn_Zh(String source)
        {
            return TranslateApi.Translate(source, Language.En, Language.Zh);
        }
        public static String TranslateZh_En(String source)
        {
            return TranslateApi.Translate(source, Language.Zh, Language.En);
        }
    }
    public sealed class Utils
    {


    }
    public class RequestPacket
    {
        public String Source { get; set; }
        public String SourceType { get; set; }
        public String DestType { get; set; }
        public String AppId { get; set; }
        public String Key { get; set; }
    }

    public class ResponsePacket
    {
        [JsonProperty("error_code")]
        public String ErrorCode { get; set; }
        [JsonProperty("error_msg")]
        public String ErrorMsg { get; set; }
        [JsonProperty("from")]
        public String SourceType { get; set; }
        [JsonProperty("to")]
        public String DestType { get; set; }
        [JsonProperty("trans_result")]
        public TranslateResult[] Results { get; set; }

        public Boolean Successed
        {
            get
            {
                return this.Results != null && this.Results.Length > 0;
            }
        }

        public static ResponsePacket From(String respStr)
        {
            var packet = JsonConvert.DeserializeObject<ResponsePacket>(respStr);
            return packet;
        }
    }

    public class TranslateResult
    {
        [JsonProperty("src")]
        public String Source { get; set; }
        [JsonProperty("dst")]
        public String Dest { get; set; }
    }
    /// <summary>
    /// 翻译语言列表
    /// </summary>
    public sealed class Language
    {
        /// <summary>
        /// 自动检测
        /// </summary>
        public static readonly String Auto = "auto";
        /// <summary>
        /// 英语
        /// </summary>
        public static readonly String En = "en";
        /// <summary>
        /// 中文
        /// </summary>
        public static readonly String Zh = "zh";
        //public const String auto 自动检测
        //public const String zh 中文
        //public const String en 英语
        //public const String yue 粤语
        //public const String wyw 文言文
        //public const String jp 日语
        //public const String kor 韩语
        //public const String fra 法语
        //public const String spa 西班牙语
        //public const String th 泰语
        //public const String ara 阿拉伯语
        //public const String ru 俄语
        //public const String pt 葡萄牙语
        //public const String de 德语
        //public const String it 意大利语
        //public const String el 希腊语
        //public const String nl 荷兰语
        //public const String pl 波兰语
        //public const String bul 保加利亚语
        //public const String est 爱沙尼亚语
        //public const String dan 丹麦语
        //public const String fin 芬兰语
        //public const String cs 捷克语
        //public const String rom 罗马尼亚语
        //public const String slo 斯洛文尼亚语
        //public const String swe 瑞典语
        //public const String hu 匈牙利语
        //public const String cht 繁体中文
        //public const String vie 越南语
    }
}
