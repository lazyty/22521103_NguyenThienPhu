namespace NT106.O23_LAB3_22521103.bai3
{
    partial class TCP_client
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
            clientbox = new RichTextBox();
            connectbutton = new Button();
            disconnectbutton = new Button();
            exitbutton = new Button();
            statusbox = new TextBox();
            sendbutton = new Button();
            SuspendLayout();
            // 
            // clientbox
            // 
            clientbox.Location = new Point(12, 63);
            clientbox.Name = "clientbox";
            clientbox.Size = new Size(606, 410);
            clientbox.TabIndex = 0;
            clientbox.Text = "";
            // 
            // connectbutton
            // 
            connectbutton.Location = new Point(640, 133);
            connectbutton.Name = "connectbutton";
            connectbutton.Size = new Size(148, 61);
            connectbutton.TabIndex = 1;
            connectbutton.Text = "Connect";
            connectbutton.UseVisualStyleBackColor = true;
            connectbutton.Click += connectbutton_Click;
            // 
            // disconnectbutton
            // 
            disconnectbutton.Enabled = false;
            disconnectbutton.Location = new Point(640, 267);
            disconnectbutton.Name = "disconnectbutton";
            disconnectbutton.Size = new Size(148, 61);
            disconnectbutton.TabIndex = 3;
            disconnectbutton.Text = "Disconnect";
            disconnectbutton.UseVisualStyleBackColor = true;
            disconnectbutton.Click += disconnectbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(640, 334);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(148, 61);
            exitbutton.TabIndex = 4;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // statusbox
            // 
            statusbox.Location = new Point(12, 12);
            statusbox.Name = "statusbox";
            statusbox.Size = new Size(776, 31);
            statusbox.TabIndex = 5;
            // 
            // sendbutton
            // 
            sendbutton.Location = new Point(640, 200);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(148, 61);
            sendbutton.TabIndex = 6;
            sendbutton.Text = "Send";
            sendbutton.UseVisualStyleBackColor = true;
            sendbutton.Click += sendbutton_Click;
            // 
            // TCP_client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(sendbutton);
            Controls.Add(statusbox);
            Controls.Add(exitbutton);
            Controls.Add(disconnectbutton);
            Controls.Add(connectbutton);
            Controls.Add(clientbox);
            Name = "TCP_client";
            Text = "TCP_client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox clientbox;
        private Button connectbutton;
        private Button disconnectbutton;
        private Button exitbutton;
        private TextBox statusbox;
        private Button sendbutton;
    }
}