namespace NT106.O23_LAB2_22521103
{
    partial class BAI1
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
            Hienthi = new RichTextBox();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(635, 141);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Đọc File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(635, 181);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Ghi File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Hienthi
            // 
            Hienthi.Location = new Point(38, 35);
            Hienthi.Name = "Hienthi";
            Hienthi.ReadOnly = true;
            Hienthi.Size = new Size(531, 355);
            Hienthi.TabIndex = 2;
            Hienthi.Text = "";
            Hienthi.TextChanged += Hienthi_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(635, 221);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BAI1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(Hienthi);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BAI1";
            Text = "BAI1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox Hienthi;
        private Button button4;
        private OpenFileDialog openFileDialog1;
    }
}