namespace TcpClient
{
	partial class ClientForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbIp = new System.Windows.Forms.Label();
			this.tbIP = new System.Windows.Forms.TextBox();
			this.lbPort = new System.Windows.Forms.Label();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.tbSend = new System.Windows.Forms.TextBox();
			this.lbSend = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.lbMsg = new System.Windows.Forms.Label();
			this.tbMsg = new System.Windows.Forms.TextBox();
			// 
			// lbIp
			// 
			this.lbIp.AutoSize = true;
			this.lbIp.Location = new System.Drawing.Point(11, 16);
			this.lbIp.Name = "lbIp";
			this.lbIp.Size = new System.Drawing.Size(26, 20);
			this.lbIp.TabIndex = 0;
			this.lbIp.Text = "IP:";
			// 
			// tbIP
			// 
			this.tbIP.Location = new System.Drawing.Point(66, 13);
			this.tbIP.Name = "tbIP";
			this.tbIP.Size = new System.Drawing.Size(142, 27);
			this.tbIP.TabIndex = 1;
			this.tbIP.Text = "127.0.0.1";
			// 
			// lbPort
			// 
			this.lbPort.AutoSize = true;
			this.lbPort.Location = new System.Drawing.Point(214, 16);
			this.lbPort.Name = "lbPort";
			this.lbPort.Size = new System.Drawing.Size(44, 20);
			this.lbPort.TabIndex = 0;
			this.lbPort.Text = "Port:";
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(264, 13);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(94, 27);
			this.tbPort.TabIndex = 2;
			this.tbPort.Text = "8088";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(375, 5);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(105, 35);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect...";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(486, 5);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(106, 35);
			this.btnDisconnect.TabIndex = 3;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// tbSend
			// 
			this.tbSend.Location = new System.Drawing.Point(67, 46);
			this.tbSend.Multiline = true;
			this.tbSend.Name = "tbSend";
			this.tbSend.Size = new System.Drawing.Size(738, 121);
			this.tbSend.TabIndex = 4;
			this.tbSend.Text = "Hello Server.....";
			// 
			// lbSend
			// 
			this.lbSend.AutoSize = true;
			this.lbSend.Location = new System.Drawing.Point(11, 49);
			this.lbSend.Name = "lbSend";
			this.lbSend.Size = new System.Drawing.Size(50, 20);
			this.lbSend.TabIndex = 5;
			this.lbSend.Text = "Send:";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(598, 5);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(207, 35);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "SendMsg";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// lbMsg
			// 
			this.lbMsg.AutoSize = true;
			this.lbMsg.Location = new System.Drawing.Point(11, 178);
			this.lbMsg.Name = "lbMsg";
			this.lbMsg.Size = new System.Drawing.Size(45, 20);
			this.lbMsg.TabIndex = 5;
			this.lbMsg.Text = "Msg:";
			// 
			// tbMsg
			// 
			this.tbMsg.Location = new System.Drawing.Point(67, 178);
			this.tbMsg.Multiline = true;
			this.tbMsg.Name = "tbMsg";
			this.tbMsg.Size = new System.Drawing.Size(738, 265);
			this.tbMsg.TabIndex = 4;
			this.tbMsg.Text = "Ready....";
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 450);
			this.Controls.Add(this.lbSend);
			this.Controls.Add(this.tbSend);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.tbPort);
			this.Controls.Add(this.tbIP);
			this.Controls.Add(this.lbIp);
			this.Controls.Add(this.lbPort);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.lbMsg);
			this.Controls.Add(this.tbMsg);
			this.Name = "ClientForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TcpClient";

		}

		#endregion

		private System.Windows.Forms.Label lbIp;
		private System.Windows.Forms.TextBox tbIP;
		private System.Windows.Forms.Label lbPort;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.TextBox tbSend;
		private System.Windows.Forms.Label lbSend;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lbMsg;
		private System.Windows.Forms.TextBox tbMsg;
	}
}