namespace NT106.O23_LAB3_22521103
{
    partial class Client
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
            btnConnect = new Button();
            grbMessage = new GroupBox();
            btnSendFile = new Button();
            btnSend = new Button();
            txtMessage = new TextBox();
            btnExit = new Button();
            lblClientIP = new Label();
            lblServerPort = new Label();
            txtServerIP = new TextBox();
            txtServerPort = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            rtbChatBox = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            grbMessage.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(38, 246);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(93, 37);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // grbMessage
            // 
            grbMessage.Controls.Add(btnSendFile);
            grbMessage.Controls.Add(btnSend);
            grbMessage.Controls.Add(txtMessage);
            grbMessage.Location = new Point(18, 665);
            grbMessage.Margin = new Padding(3, 4, 3, 4);
            grbMessage.Name = "grbMessage";
            grbMessage.Padding = new Padding(3, 4, 3, 4);
            grbMessage.Size = new Size(1103, 104);
            grbMessage.TabIndex = 6;
            grbMessage.TabStop = false;
            grbMessage.Text = "Message";
            // 
            // btnSendFile
            // 
            btnSendFile.Location = new Point(952, 33);
            btnSendFile.Margin = new Padding(3, 4, 3, 4);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(45, 50);
            btnSendFile.TabIndex = 2;
            btnSendFile.Text = "I";
            btnSendFile.UseVisualStyleBackColor = true;
            btnSendFile.Click += btnSendFile_Click_1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(1003, 33);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(93, 50);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Location = new Point(7, 33);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(937, 48);
            txtMessage.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(188, 246);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "End";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblClientIP
            // 
            lblClientIP.AutoSize = true;
            lblClientIP.Location = new Point(20, 48);
            lblClientIP.Name = "lblClientIP";
            lblClientIP.Size = new Size(76, 25);
            lblClientIP.TabIndex = 8;
            lblClientIP.Text = "Client IP";
            // 
            // lblServerPort
            // 
            lblServerPort.AutoSize = true;
            lblServerPort.Location = new Point(20, 108);
            lblServerPort.Name = "lblServerPort";
            lblServerPort.Size = new Size(98, 25);
            lblServerPort.TabIndex = 9;
            lblServerPort.Text = "Server Port";
            // 
            // txtServerIP
            // 
            txtServerIP.BorderStyle = BorderStyle.FixedSingle;
            txtServerIP.Location = new Point(138, 46);
            txtServerIP.Margin = new Padding(3, 4, 3, 4);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(125, 31);
            txtServerIP.TabIndex = 10;
            txtServerIP.Text = "127.0.0.1";
            txtServerIP.TextChanged += txtServerIP_TextChanged;
            // 
            // txtServerPort
            // 
            txtServerPort.BorderStyle = BorderStyle.FixedSingle;
            txtServerPort.Location = new Point(138, 104);
            txtServerPort.Margin = new Padding(3, 4, 3, 4);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.ReadOnly = true;
            txtServerPort.Size = new Size(125, 31);
            txtServerPort.TabIndex = 11;
            txtServerPort.Text = "8888";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 167);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(138, 163);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 31);
            txtUsername.TabIndex = 13;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtServerPort);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblClientIP);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblServerPort);
            groupBox1.Controls.Add(txtServerIP);
            groupBox1.Location = new Point(18, 19);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(287, 219);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // rtbChatBox
            // 
            rtbChatBox.BorderStyle = BorderStyle.FixedSingle;
            rtbChatBox.Font = new Font("Yu Gothic UI", 11F);
            rtbChatBox.Location = new Point(315, 25);
            rtbChatBox.Margin = new Padding(5, 6, 5, 6);
            rtbChatBox.Name = "rtbChatBox";
            rtbChatBox.ReadOnly = true;
            rtbChatBox.Size = new Size(804, 627);
            rtbChatBox.TabIndex = 16;
            rtbChatBox.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(1132, 25);
            flowLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 742);
            flowLayoutPanel1.TabIndex = 17;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 815);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rtbChatBox);
            Controls.Add(groupBox1);
            Controls.Add(grbMessage);
            Controls.Add(btnExit);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Client";
            Text = "Client";
            grbMessage.ResumeLayout(false);
            grbMessage.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblClientIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.RichTextBox rtbChatBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}