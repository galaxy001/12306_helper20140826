using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PingMock
{
    public class GetIPList
    {
        /// <summary>
        /// 通过URL地址获取IP 内容必须为 0.0.0.0|1.1.1.1 这种形式
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static List<Object_IP> GetSourceList(string url)
        {
            List<Object_IP> list = new List<Object_IP>();
            WebClient wc = new WebClient();
            string strip = wc.DownloadString(url);
            strip = strip.Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("\r\n", "");
            string[] tmpstr = strip.Split(new string[]{"|",","},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tmpstr.Length; i++)
            {
                var ip = new Object_IP();
                ip.Ip = tmpstr[i].ToString();
                list.Add(ip);
            }
            return list;
        }
    }
}
