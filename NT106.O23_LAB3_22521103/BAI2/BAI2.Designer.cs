namespace NT106.O23_LAB3_22521103
{
    partial class BAI2
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
            telnetview = new ListView();
            listenbutton = new Button();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // telnetview
            // 
            telnetview.Location = new Point(12, 12);
            telnetview.Name = "telnetview";
            telnetview.Size = new Size(776, 426);
            telnetview.TabIndex = 0;
            telnetview.UseCompatibleStateImageBehavior = false;
            telnetview.View = View.List;
            // 
            // listenbutton
            // 
            listenbutton.Location = new Point(506, 454);
            listenbutton.Name = "listenbutton";
            listenbutton.Size = new Size(130, 48);
            listenbutton.TabIndex = 1;
            listenbutton.Text = "Listen";
            listenbutton.UseVisualStyleBackColor = true;
            listenbutton.Click += button1_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(658, 454);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(130, 48);
            exitbutton.TabIndex = 2;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += button2_Click;
            // 
            // BAI2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(exitbutton);
            Controls.Add(listenbutton);
            Controls.Add(telnetview);
            Name = "BAI2";
            Text = "BAI2";
            Load += BAI2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView telnetview;
        private Button listenbutton;
        private Button exitbutton;
    }
}