using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace HandyUtil.NetWork
{
    public sealed class NetWork
    {
        /// <summary>
        /// 获取本机的 IPv4 地址的字符串
        /// </summary>
        /// <returns></returns>
        public static String GetHostString()
        {
            String localIP = "127.0.0.1";
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }
            }
            catch
            {
            }

            return localIP;
        }
    }
}
