namespace NT106.O23_LAB3_22521103
{
    partial class Chat_Server
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
            txtUserNumber = new TextBox();
            lblUserNumber = new Label();
            btnListen = new Button();
            txtServerPort = new TextBox();
            lblPort = new Label();
            btnShutServer = new Button();
            btnSend = new Button();
            txtMessage = new TextBox();
            gbInfo = new GroupBox();
            btnSendFlie = new Button();
            gbMessage = new GroupBox();
            rtbChatBox = new RichTextBox();
            exitbutton = new Button();
            gbInfo.SuspendLayout();
            gbMessage.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserNumber
            // 
            txtUserNumber.BorderStyle = BorderStyle.FixedSingle;
            txtUserNumber.Location = new Point(196, 78);
            txtUserNumber.Margin = new Padding(4, 3, 4, 3);
            txtUserNumber.Name = "txtUserNumber";
            txtUserNumber.Size = new Size(126, 31);
            txtUserNumber.TabIndex = 11;
            // 
            // lblUserNumber
            // 
            lblUserNumber.AutoSize = true;
            lblUserNumber.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserNumber.Location = new Point(6, 83);
            lblUserNumber.Margin = new Padding(4, 0, 4, 0);
            lblUserNumber.Name = "lblUserNumber";
            lblUserNumber.Size = new Size(126, 25);
            lblUserNumber.TabIndex = 10;
            lblUserNumber.Text = "Default users";
            // 
            // btnListen
            // 
            btnListen.Location = new Point(15, 158);
            btnListen.Margin = new Padding(4, 3, 4, 3);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(125, 47);
            btnListen.TabIndex = 9;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click_1;
            // 
            // txtServerPort
            // 
            txtServerPort.BorderStyle = BorderStyle.FixedSingle;
            txtServerPort.Location = new Point(196, 33);
            txtServerPort.Margin = new Padding(4, 3, 4, 3);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.ReadOnly = true;
            txtServerPort.Size = new Size(126, 31);
            txtServerPort.TabIndex = 7;
            txtServerPort.Text = "8888";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPort.Location = new Point(6, 36);
            lblPort.Margin = new Padding(4, 0, 4, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(110, 25);
            lblPort.TabIndex = 6;
            lblPort.Text = "Server Port";
            // 
            // btnShutServer
            // 
            btnShutServer.Location = new Point(211, 158);
            btnShutServer.Margin = new Padding(4, 3, 4, 3);
            btnShutServer.Name = "btnShutServer";
            btnShutServer.Size = new Size(125, 47);
            btnShutServer.TabIndex = 12;
            btnShutServer.Text = "Close";
            btnShutServer.UseVisualStyleBackColor = true;
            btnShutServer.Click += btnShutServer_Click_1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(634, 36);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(125, 50);
            btnSend.TabIndex = 14;
            btnSend.Text = "send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Location = new Point(6, 36);
            txtMessage.Margin = new Padding(4, 3, 4, 3);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(566, 49);
            txtMessage.TabIndex = 15;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblPort);
            gbInfo.Controls.Add(lblUserNumber);
            gbInfo.Controls.Add(txtServerPort);
            gbInfo.Controls.Add(txtUserNumber);
            gbInfo.Location = new Point(15, 19);
            gbInfo.Margin = new Padding(4, 3, 4, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(4, 3, 4, 3);
            gbInfo.Size = new Size(329, 133);
            gbInfo.TabIndex = 16;
            gbInfo.TabStop = false;
            gbInfo.Text = "Info";
            // 
            // btnSendFlie
            // 
            btnSendFlie.Location = new Point(580, 36);
            btnSendFlie.Margin = new Padding(4, 3, 4, 3);
            btnSendFlie.Name = "btnSendFlie";
            btnSendFlie.Size = new Size(45, 50);
            btnSendFlie.TabIndex = 17;
            btnSendFlie.Text = "I";
            btnSendFlie.UseVisualStyleBackColor = true;
            btnSendFlie.Click += btnSendFlie_Click_1;
            // 
            // gbMessage
            // 
            gbMessage.Controls.Add(txtMessage);
            gbMessage.Controls.Add(btnSendFlie);
            gbMessage.Controls.Add(btnSend);
            gbMessage.Location = new Point(356, 658);
            gbMessage.Margin = new Padding(4, 3, 4, 3);
            gbMessage.Name = "gbMessage";
            gbMessage.Padding = new Padding(4, 3, 4, 3);
            gbMessage.Size = new Size(765, 111);
            gbMessage.TabIndex = 18;
            gbMessage.TabStop = false;
            gbMessage.Text = "Message";
            // 
            // rtbChatBox
            // 
            rtbChatBox.BorderStyle = BorderStyle.FixedSingle;
            rtbChatBox.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbChatBox.Location = new Point(362, 19);
            rtbChatBox.Margin = new Padding(5, 6, 5, 6);
            rtbChatBox.Name = "rtbChatBox";
            rtbChatBox.ReadOnly = true;
            rtbChatBox.Size = new Size(757, 626);
            rtbChatBox.TabIndex = 19;
            rtbChatBox.Text = "";
            rtbChatBox.TextChanged += rtbChatBox_TextChanged;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(121, 224);
            exitbutton.Margin = new Padding(4, 3, 4, 3);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(125, 47);
            exitbutton.TabIndex = 20;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Chat_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 791);
            Controls.Add(exitbutton);
            Controls.Add(rtbChatBox);
            Controls.Add(gbMessage);
            Controls.Add(gbInfo);
            Controls.Add(btnShutServer);
            Controls.Add(btnListen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Chat_Server";
            Text = "Chat Server";
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbMessage.ResumeLayout(false);
            gbMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnShutServer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnSendFlie;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox rtbChatBox;
        private Button exitbutton;
    }
}