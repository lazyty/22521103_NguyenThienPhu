﻿namespace NT106.O23_LAB3_22521103
{
    partial class BAI3
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 11);
            button1.Name = "button1";
            button1.Size = new Size(319, 64);
            button1.TabIndex = 0;
            button1.Text = "TCP Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 98);
            button2.Name = "button2";
            button2.Size = new Size(319, 64);
            button2.TabIndex = 1;
            button2.Text = "New TCP Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BAI3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 174);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BAI3";
            Text = "BAI3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}