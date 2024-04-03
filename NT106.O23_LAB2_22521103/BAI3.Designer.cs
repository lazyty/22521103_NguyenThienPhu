namespace NT106.O23_LAB2_22521103
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
            button3 = new Button();
            rtb1 = new RichTextBox();
            rtb2 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(126, 452);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(262, 452);
            button2.Name = "button2";
            button2.Size = new Size(288, 34);
            button2.TabIndex = 1;
            button2.Text = "Write File and Compute";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(578, 452);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // rtb1
            // 
            rtb1.Location = new Point(12, 80);
            rtb1.Name = "rtb1";
            rtb1.ReadOnly = true;
            rtb1.Size = new Size(369, 355);
            rtb1.TabIndex = 3;
            rtb1.Text = "";
            // 
            // rtb2
            // 
            rtb2.Location = new Point(404, 80);
            rtb2.Name = "rtb2";
            rtb2.ReadOnly = true;
            rtb2.Size = new Size(369, 355);
            rtb2.TabIndex = 4;
            rtb2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(369, 31);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 27);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(369, 31);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BAI3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(rtb2);
            Controls.Add(rtb1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BAI3";
            Text = "BAI3";
            Load += BAI3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox rtb1;
        private RichTextBox rtb2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}