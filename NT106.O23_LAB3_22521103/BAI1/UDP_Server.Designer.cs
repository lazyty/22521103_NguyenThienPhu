namespace NT106.O23_LAB3_22521103
{
    partial class UDP_Server
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
            exitbutton = new Button();
            listenbutton = new Button();
            label3 = new Label();
            label2 = new Label();
            porttext = new TextBox();
            messagelist = new ListView();
            SuspendLayout();
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(674, 439);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(112, 53);
            exitbutton.TabIndex = 15;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // listenbutton
            // 
            listenbutton.Location = new Point(535, 439);
            listenbutton.Name = "listenbutton";
            listenbutton.Size = new Size(112, 53);
            listenbutton.TabIndex = 14;
            listenbutton.Text = "Listen";
            listenbutton.UseVisualStyleBackColor = true;
            listenbutton.Click += listenbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 13;
            label3.Text = "Received Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 453);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 12;
            label2.Text = "Port";
            // 
            // porttext
            // 
            porttext.Location = new Point(62, 450);
            porttext.Name = "porttext";
            porttext.ReadOnly = true;
            porttext.Size = new Size(114, 31);
            porttext.TabIndex = 9;
            porttext.Text = "8080";
            // 
            // messagelist
            // 
            messagelist.Location = new Point(12, 37);
            messagelist.Name = "messagelist";
            messagelist.Size = new Size(774, 396);
            messagelist.TabIndex = 16;
            messagelist.UseCompatibleStateImageBehavior = false;
            messagelist.View = View.List;
            messagelist.SelectedIndexChanged += messagelist_SelectedIndexChanged;
            // 
            // UDP_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(messagelist);
            Controls.Add(exitbutton);
            Controls.Add(listenbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(porttext);
            Name = "UDP_Server";
            Text = "UDP_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitbutton;
        private Button listenbutton;
        private Label label3;
        private Label label2;
        private TextBox porttext;
        private ListView messagelist;
    }
}