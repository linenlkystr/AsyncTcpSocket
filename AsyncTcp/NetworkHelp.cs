using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace AsyncTcp
{
	public class NetworkHelp
	{

		/// <summary>
		/// 待发送字符串加长度头后转字节数组
		/// </summary>
		/// <param name="sendMsg">待转换字符串</param>
		/// <returns></returns>
		public static byte[] ConvertToByteData(string sendMsg)
		{
			byte[] data = Encoding.UTF8.GetBytes(sendMsg);
			byte[] sendData = new byte[sizeof(int)+ data.Length];
			byte[] dataLen = BitConverter.GetBytes(data.Length);
			sendData = dataLen.Concat(data).ToArray();
			return sendData;
		}

		/// <summary>
		/// 收到的字节数组还原成消息字符串
		/// </summary>
		/// <param name="receiveData">待转换消息字节数组</param>
		/// <returns></returns>
		public static string ConvertToStrData(byte[] receiveData)
		{
			string receiveStr = string.Empty;
			byte[] dataLen = receiveData.Take(sizeof(int)).ToArray();
			int msgLen = BitConverter.ToInt32(dataLen);
			byte[] receiveMsg = receiveData.Skip(sizeof(int)).Take(msgLen).ToArray();
			receiveStr = Encoding.UTF8.GetString(receiveMsg);
			return receiveStr;
		}

		/// <summary>
		/// 获取本机所有ip地址
		/// </summary>
		/// <param name="netType">"InterNetwork":ipv4地址，"InterNetworkV6":ipv6地址</param>
		/// <returns>ip地址集合</returns>
		public static List<string> GetLocalIpAddress(string netType= "InterNetwork")
		{
			string hostName = Dns.GetHostName();                    //获取主机名称  
			IPAddress[] addresses = Dns.GetHostAddresses(hostName); //解析主机IP地址  

			List<string> IPList = new List<string>();
			if (netType == string.Empty)
			{
				for (int i = 0; i < addresses.Length; i++)
				{
					IPList.Add(addresses[i].ToString());
				}
			}
			else
			{
				//AddressFamily.InterNetwork表示此IP为IPv4,
				//AddressFamily.InterNetworkV6表示此地址为IPv6类型
				for (int i = 0; i < addresses.Length; i++)
				{
					if (addresses[i].AddressFamily.ToString() == netType)
					{
						IPList.Add(addresses[i].ToString());
					}
				}
			}
			return IPList;
		}

		/*
		public  List<string> ips = GetLocalIpAddress("");//获取本地所有ip

		public  List<string> ipv4_ips = GetLocalIpAddress("InterNetwork");//获取ipv4类型的ip

		public List<string> ipv6_ips = GetLocalIpAddress("InterNetworkV6");//获取ipv6类型的ip

		*/

		/// <summary>
		/// 获取页面html
		/// </summary>
		/// <param name="url">请求的地址</param>
		/// <param name="encoding">编码方式</param>
		/// <returns></returns>
		public static string HttpGetPageHtml(string url, string encoding)
		{
			string pageHtml = string.Empty;
			try
			{
				using (WebClient MyWebClient = new WebClient())
				{
					Encoding encode = Encoding.GetEncoding(encoding);
					MyWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36");
					MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
					Byte[] pageData = MyWebClient.DownloadData(url); //从指定网站下载数据
					pageHtml = encode.GetString(pageData);
				}
			}
			catch (Exception e)
			{

			}
			return pageHtml;
		}

		/// <summary>
		/// 从html中通过正则找到ip信息(只支持ipv4地址)
		/// </summary>
		/// <param name="pageHtml"></param>
		/// <returns></returns>
		public static string GetIPFromHtml(String pageHtml)
		{
			//验证ipv4地址
			string reg = @"(?:(?:(25[0-5])|(2[0-4]\d)|((1\d{2})|([1-9]?\d)))\.){3}(?:(25[0-5])|(2[0-4]\d)|((1\d{2})|([1-9]?\d)))";
			string ip = "";
			Match m = Regex.Match(pageHtml, reg);
			if (m.Success)
			{
				ip = m.Value;
			}
			return ip;
		}
/*
var t0_html = HttpGetPageHtml("https://www.ip.cn", "utf-8");
var t1_html = HttpGetPageHtml("http://www.ip138.com/ips138.asp", "gbk");
var t2_html = HttpGetPageHtml("http://www.net.cn/static/customercare/yourip.asp", "gbk");
var t0_ip = GetIPFromHtml(t0_html);// 111.198.29.123
var t1_ip = GetIPFromHtml(t1_html);// 111.198.29.123
var t2_ip = GetIPFromHtml(t2_html);// 111.198.29.123
*/
	}
}
