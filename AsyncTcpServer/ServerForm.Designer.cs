namespace TcpServer
{
	partial class ServerForm
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
			this.lbIP = new System.Windows.Forms.Label();
			this.tbIP = new System.Windows.Forms.TextBox();
			this.lbPort = new System.Windows.Forms.Label();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lbSend = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.tbSend = new System.Windows.Forms.TextBox();
			this.lbMsg = new System.Windows.Forms.Label();
			this.tbMsg = new System.Windows.Forms.TextBox();
			// 
			// lbIP
			// 
			this.lbIP.AutoSize = true;
			this.lbIP.Location = new System.Drawing.Point(10, 10);
			this.lbIP.Name = "lbIP";
			this.lbIP.Size = new System.Drawing.Size(26, 20);
			this.lbIP.TabIndex = 0;
			this.lbIP.Text = "IP:";
			// 
			// tbIP
			// 
			this.tbIP.Location = new System.Drawing.Point(62, 7);
			this.tbIP.Name = "tbIP";
			this.tbIP.Size = new System.Drawing.Size(123, 27);
			this.tbIP.TabIndex = 1;
			this.tbIP.Text = "127.0.0.1";
			// 
			// lbPort
			// 
			this.lbPort.AutoSize = true;
			this.lbPort.Location = new System.Drawing.Point(191, 10);
			this.lbPort.Name = "lbPort";
			this.lbPort.Size = new System.Drawing.Size(44, 20);
			this.lbPort.TabIndex = 2;
			this.lbPort.Text = "Port:";
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(241, 9);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(68, 27);
			this.tbPort.TabIndex = 3;
			this.tbPort.Text = "8088";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(315, 5);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(117, 31);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start...";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(438, 5);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(113, 31);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop...";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lbSend
			// 
			this.lbSend.AutoSize = true;
			this.lbSend.Location = new System.Drawing.Point(10, 47);
			this.lbSend.Name = "lbSend";
			this.lbSend.Size = new System.Drawing.Size(50, 20);
			this.lbSend.TabIndex = 6;
			this.lbSend.Text = "Send:";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(557, 5);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(234, 31);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "Send...";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// tbSend
			// 
			this.tbSend.Location = new System.Drawing.Point(62, 42);
			this.tbSend.Multiline = true;
			this.tbSend.Name = "tbSend";
			this.tbSend.Size = new System.Drawing.Size(729, 110);
			this.tbSend.TabIndex = 8;
			this.tbSend.Text = "Hello Client....";
			// 
			// lbMsg
			// 
			this.lbMsg.AutoSize = true;
			this.lbMsg.Location = new System.Drawing.Point(10, 161);
			this.lbMsg.Name = "lbMsg";
			this.lbMsg.Size = new System.Drawing.Size(45, 20);
			this.lbMsg.TabIndex = 9;
			this.lbMsg.Text = "Msg:";
			// 
			// tbMsg
			// 
			this.tbMsg.Location = new System.Drawing.Point(62, 161);
			this.tbMsg.Multiline = true;
			this.tbMsg.Name = "tbMsg";
			this.tbMsg.Size = new System.Drawing.Size(729, 281);
			this.tbMsg.TabIndex = 10;
			this.tbMsg.Text = "Ready....";
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbMsg);
			this.Controls.Add(this.lbMsg);
			this.Controls.Add(this.tbSend);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.lbSend);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.tbPort);
			this.Controls.Add(this.lbPort);
			this.Controls.Add(this.tbIP);
			this.Controls.Add(this.lbIP);
			this.Name = "ServerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ServerForm";

		}

		#endregion

		private System.Windows.Forms.Label lbIP;
		private System.Windows.Forms.TextBox tbIP;
		private System.Windows.Forms.Label lbPort;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lbSend;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox tbSend;
		private System.Windows.Forms.Label lbMsg;
		private System.Windows.Forms.TextBox tbMsg;
	}
}