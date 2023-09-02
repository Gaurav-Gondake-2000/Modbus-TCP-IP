namespace Modbus_TCP_IP
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.gBoxConnection = new System.Windows.Forms.GroupBox();
            this.comBoxConnection = new System.Windows.Forms.ComboBox();
            this.gBoxRemoteModbusServer = new System.Windows.Forms.GroupBox();
            this.MaskedtxtIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.RBipv6 = new System.Windows.Forms.RadioButton();
            this.RBipv4 = new System.Windows.Forms.RadioButton();
            this.gBoxDelayBetweenPolls = new System.Windows.Forms.GroupBox();
            this.lblDelayBetweenPolls_ms = new System.Windows.Forms.Label();
            this.txtDelayBetPolls = new System.Windows.Forms.TextBox();
            this.gBoxResponseTimeOut = new System.Windows.Forms.GroupBox();
            this.lblReqTime_ms = new System.Windows.Forms.Label();
            this.txtResponseTimeout = new System.Windows.Forms.TextBox();
            this.lblConnectTimeout_MS = new System.Windows.Forms.Label();
            this.txtConnectTimeout = new System.Windows.Forms.TextBox();
            this.lblConnectTimeout = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gBoxMain = new System.Windows.Forms.GroupBox();
            this.timer_ConnectTimeout = new System.Windows.Forms.Timer(this.components);
            this.timer_ResponseTimeout = new System.Windows.Forms.Timer(this.components);
            this.timer_PollsDelay = new System.Windows.Forms.Timer(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.gBoxConnection.SuspendLayout();
            this.gBoxRemoteModbusServer.SuspendLayout();
            this.gBoxDelayBetweenPolls.SuspendLayout();
            this.gBoxResponseTimeOut.SuspendLayout();
            this.gBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxConnection
            // 
            this.gBoxConnection.Controls.Add(this.comBoxConnection);
            this.gBoxConnection.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxConnection.Location = new System.Drawing.Point(27, 18);
            this.gBoxConnection.Name = "gBoxConnection";
            this.gBoxConnection.Size = new System.Drawing.Size(470, 83);
            this.gBoxConnection.TabIndex = 0;
            this.gBoxConnection.TabStop = false;
            this.gBoxConnection.Text = "Connection";
            // 
            // comBoxConnection
            // 
            this.comBoxConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxConnection.FormattingEnabled = true;
            this.comBoxConnection.Items.AddRange(new object[] {
            "",
            "Modbus TCP/IP"});
            this.comBoxConnection.Location = new System.Drawing.Point(62, 28);
            this.comBoxConnection.Name = "comBoxConnection";
            this.comBoxConnection.Size = new System.Drawing.Size(319, 29);
            this.comBoxConnection.TabIndex = 0;
            this.comBoxConnection.SelectedIndexChanged += new System.EventHandler(this.comBoxConnection_SelectedIndexChanged);
            // 
            // gBoxRemoteModbusServer
            // 
            this.gBoxRemoteModbusServer.Controls.Add(this.MaskedtxtIPAddress);
            this.gBoxRemoteModbusServer.Controls.Add(this.txtServerPort);
            this.gBoxRemoteModbusServer.Controls.Add(this.RBipv6);
            this.gBoxRemoteModbusServer.Controls.Add(this.RBipv4);
            this.gBoxRemoteModbusServer.Controls.Add(this.gBoxDelayBetweenPolls);
            this.gBoxRemoteModbusServer.Controls.Add(this.gBoxResponseTimeOut);
            this.gBoxRemoteModbusServer.Controls.Add(this.lblConnectTimeout_MS);
            this.gBoxRemoteModbusServer.Controls.Add(this.txtConnectTimeout);
            this.gBoxRemoteModbusServer.Controls.Add(this.lblConnectTimeout);
            this.gBoxRemoteModbusServer.Controls.Add(this.lblServerPort);
            this.gBoxRemoteModbusServer.Controls.Add(this.lblAddress);
            this.gBoxRemoteModbusServer.Enabled = false;
            this.gBoxRemoteModbusServer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxRemoteModbusServer.Location = new System.Drawing.Point(27, 108);
            this.gBoxRemoteModbusServer.Name = "gBoxRemoteModbusServer";
            this.gBoxRemoteModbusServer.Size = new System.Drawing.Size(718, 246);
            this.gBoxRemoteModbusServer.TabIndex = 1;
            this.gBoxRemoteModbusServer.TabStop = false;
            this.gBoxRemoteModbusServer.Text = "Remote Modbus Server";
            // 
            // MaskedtxtIPAddress
            // 
            this.MaskedtxtIPAddress.Location = new System.Drawing.Point(107, 71);
            this.MaskedtxtIPAddress.Name = "MaskedtxtIPAddress";
            this.MaskedtxtIPAddress.Size = new System.Drawing.Size(247, 28);
            this.MaskedtxtIPAddress.TabIndex = 11;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(102, 170);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(91, 28);
            this.txtServerPort.TabIndex = 10;
            this.txtServerPort.Text = "502";
            // 
            // RBipv6
            // 
            this.RBipv6.AutoSize = true;
            this.RBipv6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBipv6.Location = new System.Drawing.Point(6, 81);
            this.RBipv6.Name = "RBipv6";
            this.RBipv6.Size = new System.Drawing.Size(63, 26);
            this.RBipv6.TabIndex = 8;
            this.RBipv6.TabStop = true;
            this.RBipv6.Text = "IPv6";
            this.RBipv6.UseVisualStyleBackColor = true;
            this.RBipv6.CheckedChanged += new System.EventHandler(this.RBipv6_CheckedChanged_1);
            // 
            // RBipv4
            // 
            this.RBipv4.AutoSize = true;
            this.RBipv4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBipv4.Location = new System.Drawing.Point(6, 40);
            this.RBipv4.Name = "RBipv4";
            this.RBipv4.Size = new System.Drawing.Size(63, 26);
            this.RBipv4.TabIndex = 7;
            this.RBipv4.TabStop = true;
            this.RBipv4.Text = "IPv4";
            this.RBipv4.UseVisualStyleBackColor = true;
            this.RBipv4.CheckedChanged += new System.EventHandler(this.RBipv4_CheckedChanged_1);
            // 
            // gBoxDelayBetweenPolls
            // 
            this.gBoxDelayBetweenPolls.Controls.Add(this.lblDelayBetweenPolls_ms);
            this.gBoxDelayBetweenPolls.Controls.Add(this.txtDelayBetPolls);
            this.gBoxDelayBetweenPolls.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDelayBetweenPolls.Location = new System.Drawing.Point(439, 143);
            this.gBoxDelayBetweenPolls.Name = "gBoxDelayBetweenPolls";
            this.gBoxDelayBetweenPolls.Size = new System.Drawing.Size(228, 74);
            this.gBoxDelayBetweenPolls.TabIndex = 9;
            this.gBoxDelayBetweenPolls.TabStop = false;
            this.gBoxDelayBetweenPolls.Text = "Delay Between Polls";
            // 
            // lblDelayBetweenPolls_ms
            // 
            this.lblDelayBetweenPolls_ms.AutoSize = true;
            this.lblDelayBetweenPolls_ms.Location = new System.Drawing.Point(120, 34);
            this.lblDelayBetweenPolls_ms.Name = "lblDelayBetweenPolls_ms";
            this.lblDelayBetweenPolls_ms.Size = new System.Drawing.Size(42, 21);
            this.lblDelayBetweenPolls_ms.TabIndex = 8;
            this.lblDelayBetweenPolls_ms.Text = "(ms)";
            // 
            // txtDelayBetPolls
            // 
            this.txtDelayBetPolls.Location = new System.Drawing.Point(34, 30);
            this.txtDelayBetPolls.Name = "txtDelayBetPolls";
            this.txtDelayBetPolls.Size = new System.Drawing.Size(73, 28);
            this.txtDelayBetPolls.TabIndex = 7;
            this.txtDelayBetPolls.Text = "500";
            // 
            // gBoxResponseTimeOut
            // 
            this.gBoxResponseTimeOut.Controls.Add(this.lblReqTime_ms);
            this.gBoxResponseTimeOut.Controls.Add(this.txtResponseTimeout);
            this.gBoxResponseTimeOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxResponseTimeOut.Location = new System.Drawing.Point(439, 32);
            this.gBoxResponseTimeOut.Name = "gBoxResponseTimeOut";
            this.gBoxResponseTimeOut.Size = new System.Drawing.Size(228, 74);
            this.gBoxResponseTimeOut.TabIndex = 1;
            this.gBoxResponseTimeOut.TabStop = false;
            this.gBoxResponseTimeOut.Text = "Response Timeout";
            // 
            // lblReqTime_ms
            // 
            this.lblReqTime_ms.AutoSize = true;
            this.lblReqTime_ms.Location = new System.Drawing.Point(120, 32);
            this.lblReqTime_ms.Name = "lblReqTime_ms";
            this.lblReqTime_ms.Size = new System.Drawing.Size(42, 21);
            this.lblReqTime_ms.TabIndex = 8;
            this.lblReqTime_ms.Text = "(ms)";
            // 
            // txtResponseTimeout
            // 
            this.txtResponseTimeout.Location = new System.Drawing.Point(34, 31);
            this.txtResponseTimeout.Name = "txtResponseTimeout";
            this.txtResponseTimeout.Size = new System.Drawing.Size(73, 28);
            this.txtResponseTimeout.TabIndex = 7;
            this.txtResponseTimeout.Text = "1000";
            // 
            // lblConnectTimeout_MS
            // 
            this.lblConnectTimeout_MS.AutoSize = true;
            this.lblConnectTimeout_MS.Location = new System.Drawing.Point(290, 173);
            this.lblConnectTimeout_MS.Name = "lblConnectTimeout_MS";
            this.lblConnectTimeout_MS.Size = new System.Drawing.Size(42, 21);
            this.lblConnectTimeout_MS.TabIndex = 6;
            this.lblConnectTimeout_MS.Text = "(ms)";
            // 
            // txtConnectTimeout
            // 
            this.txtConnectTimeout.Location = new System.Drawing.Point(214, 169);
            this.txtConnectTimeout.Name = "txtConnectTimeout";
            this.txtConnectTimeout.Size = new System.Drawing.Size(73, 28);
            this.txtConnectTimeout.TabIndex = 5;
            this.txtConnectTimeout.Text = "3000";
            // 
            // lblConnectTimeout
            // 
            this.lblConnectTimeout.AutoSize = true;
            this.lblConnectTimeout.Location = new System.Drawing.Point(217, 142);
            this.lblConnectTimeout.Name = "lblConnectTimeout";
            this.lblConnectTimeout.Size = new System.Drawing.Size(142, 21);
            this.lblConnectTimeout.TabIndex = 4;
            this.lblConnectTimeout.Text = "Connect Timeout";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(102, 142);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(94, 21);
            this.lblServerPort.TabIndex = 2;
            this.lblServerPort.Text = "Server Port";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(107, 41);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(213, 21);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "IP Address or Node Name:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FloralWhite;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(538, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 37);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(538, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gBoxMain
            // 
            this.gBoxMain.Controls.Add(this.gBoxConnection);
            this.gBoxMain.Controls.Add(this.btnClose);
            this.gBoxMain.Controls.Add(this.gBoxRemoteModbusServer);
            this.gBoxMain.Controls.Add(this.btnOK);
            this.gBoxMain.Location = new System.Drawing.Point(27, 11);
            this.gBoxMain.Name = "gBoxMain";
            this.gBoxMain.Size = new System.Drawing.Size(773, 375);
            this.gBoxMain.TabIndex = 12;
            this.gBoxMain.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(28, 402);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(783, 315);
            this.txtData.TabIndex = 13;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 500;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 728);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.gBoxMain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gBoxConnection.ResumeLayout(false);
            this.gBoxRemoteModbusServer.ResumeLayout(false);
            this.gBoxRemoteModbusServer.PerformLayout();
            this.gBoxDelayBetweenPolls.ResumeLayout(false);
            this.gBoxDelayBetweenPolls.PerformLayout();
            this.gBoxResponseTimeOut.ResumeLayout(false);
            this.gBoxResponseTimeOut.PerformLayout();
            this.gBoxMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxConnection;
        private System.Windows.Forms.ComboBox comBoxConnection;
        private System.Windows.Forms.GroupBox gBoxRemoteModbusServer;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton RBipv6;
        private System.Windows.Forms.RadioButton RBipv4;
        private System.Windows.Forms.Label lblConnectTimeout_MS;
        private System.Windows.Forms.TextBox txtConnectTimeout;
        private System.Windows.Forms.Label lblConnectTimeout;
        private System.Windows.Forms.GroupBox gBoxResponseTimeOut;
        private System.Windows.Forms.Label lblReqTime_ms;
        private System.Windows.Forms.TextBox txtResponseTimeout;
        private System.Windows.Forms.GroupBox gBoxDelayBetweenPolls;
        private System.Windows.Forms.Label lblDelayBetweenPolls_ms;
        private System.Windows.Forms.TextBox txtDelayBetPolls;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gBoxMain;
        private System.Windows.Forms.Timer timer_ConnectTimeout;
        private System.Windows.Forms.Timer timer_ResponseTimeout;
        private System.Windows.Forms.Timer timer_PollsDelay;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.MaskedTextBox MaskedtxtIPAddress;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}

