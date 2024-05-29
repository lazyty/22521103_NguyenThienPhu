namespace NT106.O23_LAB4
{
    partial class Bai2
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
            ContentBox = new RichTextBox();
            GetButton = new Button();
            URLBox = new TextBox();
            DownloadBox = new TextBox();
            DownloadButton = new Button();
            SuspendLayout();
            // 
            // ContentBox
            // 
            ContentBox.BorderStyle = BorderStyle.FixedSingle;
            ContentBox.Dock = DockStyle.Bottom;
            ContentBox.Location = new Point(0, 119);
            ContentBox.Margin = new Padding(5, 6, 5, 6);
            ContentBox.Name = "ContentBox";
            ContentBox.ReadOnly = true;
            ContentBox.Size = new Size(1333, 746);
            ContentBox.TabIndex = 5;
            ContentBox.Text = "";
            // 
            // GetButton
            // 
            GetButton.Location = new Point(1188, 10);
            GetButton.Margin = new Padding(5, 6, 5, 6);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(125, 44);
            GetButton.TabIndex = 4;
            GetButton.Text = "GET";
            GetButton.UseVisualStyleBackColor = true;
            GetButton.Click += GetButton_Click_1;
            // 
            // URLBox
            // 
            URLBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            URLBox.BorderStyle = BorderStyle.FixedSingle;
            URLBox.Location = new Point(20, 15);
            URLBox.Margin = new Padding(5, 6, 5, 6);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(1157, 31);
            URLBox.TabIndex = 3;
            // 
            // DownloadBox
            // 
            DownloadBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DownloadBox.BorderStyle = BorderStyle.FixedSingle;
            DownloadBox.Location = new Point(20, 65);
            DownloadBox.Margin = new Padding(5, 6, 5, 6);
            DownloadBox.Name = "DownloadBox";
            DownloadBox.Size = new Size(1157, 31);
            DownloadBox.TabIndex = 3;
            // 
            // DownloadButton
            // 
            DownloadButton.Enabled = false;
            DownloadButton.Location = new Point(1188, 65);
            DownloadButton.Margin = new Padding(5, 6, 5, 6);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(125, 44);
            DownloadButton.TabIndex = 4;
            DownloadButton.Text = "DOWNLOAD";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(ContentBox);
            Controls.Add(DownloadButton);
            Controls.Add(GetButton);
            Controls.Add(DownloadBox);
            Controls.Add(URLBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.TextBox DownloadBox;
        private System.Windows.Forms.Button DownloadButton;
    }
}