using AsyncTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TcpClient
{

	public partial class ClientForm : Form
	{
		AsyncTcpClient client;

		 void client_ServerExceptionOccurred(object sender, TcpServerExceptionOccurredEventArgs e)
		{
			this.tbMsg.Invoke(new Action(() => {
					this.tbMsg.AppendText(string.Format(CultureInfo.InvariantCulture,"TCP server {0} exception occurred, {1}." + System.Environment.NewLine, e.ToString(), e.Exception.Message));
				}));
		}

		void client_ServerConnected(object sender, TcpServerConnectedEventArgs e)
		{
			this.tbMsg.Invoke(new Action(() => {
				this.tbMsg.AppendText(string.Format(CultureInfo.InvariantCulture, "TCP server {0} has connected." + System.Environment.NewLine, e.ToString()));
			}));
		}

		void client_ServerDisconnected( object sender, TcpServerDisconnectedEventArgs e)
		{
			this.tbMsg.Invoke(new Action(() => {
				this.tbMsg.AppendText(string.Format(CultureInfo.InvariantCulture, "TCP server {0} has disconnected." + System.Environment.NewLine, e.ToString()));
			}));
		}

		void client_DatagramReceived(object sender, TcpDatagramReceivedEventArgs<byte[]> e)
		{
			string receiveMsg = NetworkHelp.ConvertToStrData(e.Datagram);
			this.tbMsg.Invoke(new Action(() =>
			{
				this.tbMsg.AppendText(
					string.Format("Server : {0}" + 
					System.Environment.NewLine,  receiveMsg
					)
					); ;
			}));
		}

		public ClientForm()
		{
			InitializeComponent();
			this.tbIP.Text = NetworkHelp.GetLocalIpAddress()[0];
			int port = Convert.ToInt32(this.tbPort.Text);
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(this.tbIP.Text), port);
			client = new AsyncTcpClient(remoteEP);
			client.Encoding = Encoding.UTF8;
			client.ServerExceptionOccurred +=
			  new EventHandler<TcpServerExceptionOccurredEventArgs>(client_ServerExceptionOccurred);
			client.ServerConnected +=
			  new EventHandler<TcpServerConnectedEventArgs>(client_ServerConnected);
			client.ServerDisconnected +=
			  new EventHandler<TcpServerDisconnectedEventArgs>(client_ServerDisconnected);
			client.DatagramReceived +=
			  new EventHandler<TcpDatagramReceivedEventArgs<byte[]>>(client_DatagramReceived);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			client.Connect();
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			client.Close();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			byte[] sendData=NetworkHelp.ConvertToByteData(this.tbSend.Text);
			client.Send(sendData);
		}
	}
}
