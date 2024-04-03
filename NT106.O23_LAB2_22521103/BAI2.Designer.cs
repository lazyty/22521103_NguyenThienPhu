namespace NT106.O23_LAB2_22521103
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
            Hienthi = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Hienthi
            // 
            Hienthi.Location = new Point(609, 12);
            Hienthi.Name = "Hienthi";
            Hienthi.ReadOnly = true;
            Hienthi.Size = new Size(614, 423);
            Hienthi.TabIndex = 3;
            Hienthi.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(157, 401);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 4;
            button1.Text = "Read from File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(316, 401);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(391, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 83);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 137);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(391, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 204);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(195, 266);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(195, 334);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 12;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 83);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 13;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 143);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 14;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 210);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 15;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 272);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 16;
            label5.Text = "Word Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 334);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 17;
            label6.Text = "Character Count";
            // 
            // BAI2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 454);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Hienthi);
            Name = "BAI2";
            Text = "BAI2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Hienthi;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}