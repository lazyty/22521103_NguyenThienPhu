namespace NT106.O23_LAB2_22521103
{
    partial class BAI7
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
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(11, 9);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(203, 543);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(220, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(533, 515);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(759, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(533, 515);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "File van ban";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1006, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 4;
            label2.Text = "File Ảnh";
            // 
            // BAI7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 564);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(treeView1);
            Name = "BAI7";
            Text = "BAI7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}