namespace NT106.O23_LAB3_22521103.bai3
{
    partial class TCP_server
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
            listenbutton = new Button();
            exitbutton = new Button();
            serverview = new RichTextBox();
            SuspendLayout();
            // 
            // listenbutton
            // 
            listenbutton.Location = new Point(540, 445);
            listenbutton.Name = "listenbutton";
            listenbutton.Size = new Size(112, 34);
            listenbutton.TabIndex = 0;
            listenbutton.Text = "Listen";
            listenbutton.UseVisualStyleBackColor = true;
            listenbutton.Click += listenbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(676, 445);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(112, 34);
            exitbutton.TabIndex = 1;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // serverview
            // 
            serverview.Location = new Point(12, 12);
            serverview.Name = "serverview";
            serverview.Size = new Size(776, 419);
            serverview.TabIndex = 2;
            serverview.Text = "";
            serverview.TextChanged += serverview_TextChanged;
            // 
            // TCP_server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(serverview);
            Controls.Add(exitbutton);
            Controls.Add(listenbutton);
            Name = "TCP_server";
            Text = "TCP_server";
            ResumeLayout(false);
        }

        #endregion

        private Button listenbutton;
        private Button exitbutton;
        private RichTextBox serverview;
    }
}