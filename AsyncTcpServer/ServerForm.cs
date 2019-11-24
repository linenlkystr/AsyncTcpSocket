using AsyncTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpServer
{
	public partial class ServerForm : Form
	{
		AsyncTcpServer server;
		TcpClient client;
		void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
		{
			this.tbMsg.Invoke(new Action(() =>
					{
						this.tbMsg.AppendText(
							string.Format(CultureInfo.InvariantCulture, "TCP client {0} has connected."+System.Environment.NewLine, e.TcpClient.Client.RemoteEndPoint.ToString())
							);
					})
			);
			client = e.TcpClient;
		}

		void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
		{
			this.tbMsg.Invoke(new Action(() =>
			{
				this.tbMsg.AppendText(
					string.Format(CultureInfo.InvariantCulture, "TCP client {0} has disconnected."+ System.Environment.NewLine, e.TcpClient.Client.RemoteEndPoint.ToString())
					);
			})
			);
		}

		void server_DatagramReceived(object sender, TcpDatagramReceivedEventArgs<byte[]> e)
		{
			string receiveMsg = NetworkHelp.ConvertToStrData(e.Datagram);
			this.tbMsg.Invoke(new Action(() =>
			{
					this.tbMsg.AppendText(
						string.Format(CultureInfo.InvariantCulture, "Client : {0} -->{1}" + 
						System.Environment.NewLine, e.TcpClient.Client.RemoteEndPoint.ToString(), receiveMsg
						)
						);
				})
			);
			server.Send(e.TcpClient, 
				NetworkHelp.ConvertToByteData("Server has received you text : "+ 
				System.Environment.NewLine + 
				receiveMsg));
		}




		public ServerForm()
		{
			InitializeComponent();
			this.tbIP.Text = NetworkHelp.GetLocalIpAddress()[0];
			int ServerPort = Convert.ToInt32(this.tbPort.Text);
			server = new AsyncTcpServer(ServerPort);
			server.Encoding = Encoding.UTF8;
			server.ClientConnected +=
			  new EventHandler<TcpClientConnectedEventArgs>(server_ClientConnected);
			server.ClientDisconnected +=
			  new EventHandler<TcpClientDisconnectedEventArgs>(server_ClientDisconnected);
			server.DatagramReceived +=
			  new EventHandler<TcpDatagramReceivedEventArgs<byte[]>>(server_DatagramReceived);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			server.Start();
			this.tbMsg.AppendText("Tcp Server has Started!"+ System.Environment.NewLine);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			server.Stop();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			byte[] sendData = NetworkHelp.ConvertToByteData(this.tbSend.Text);
			server.Send(client,sendData);
		}



	}
}
