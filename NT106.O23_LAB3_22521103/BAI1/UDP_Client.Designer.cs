namespace NT106.O23_LAB3_22521103
{
    partial class UDP_Client
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
            iptext = new TextBox();
            porttext = new TextBox();
            messagebox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            exitbutton = new Button();
            sendbutton = new Button();
            SuspendLayout();
            // 
            // iptext
            // 
            iptext.Location = new Point(154, 27);
            iptext.Name = "iptext";
            iptext.Size = new Size(356, 31);
            iptext.TabIndex = 0;
            // 
            // porttext
            // 
            porttext.Location = new Point(674, 27);
            porttext.Name = "porttext";
            porttext.ReadOnly = true;
            porttext.Size = new Size(114, 31);
            porttext.TabIndex = 1;
            porttext.Text = "8080";
            // 
            // messagebox
            // 
            messagebox.Location = new Point(12, 126);
            messagebox.Name = "messagebox";
            messagebox.Size = new Size(776, 315);
            messagebox.TabIndex = 2;
            messagebox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 3;
            label1.Text = "IP Remote Host";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 27);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "Message";
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(674, 455);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(112, 53);
            exitbutton.TabIndex = 7;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // sendbutton
            // 
            sendbutton.Location = new Point(524, 455);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(112, 53);
            sendbutton.TabIndex = 8;
            sendbutton.Text = "Send";
            sendbutton.UseVisualStyleBackColor = true;
            sendbutton.Click += sendbutton_Click_1;
            // 
            // UDP_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(sendbutton);
            Controls.Add(exitbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(messagebox);
            Controls.Add(porttext);
            Controls.Add(iptext);
            Name = "UDP_Client";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox iptext;
        private TextBox porttext;
        private RichTextBox messagebox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button exitbutton;
        private Button sendbutton;
    }
}