
namespace NT106.O23_LAB4
{
    partial class Bai1
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
            URLBox = new TextBox();
            GetButton = new Button();
            ContentBox = new RichTextBox();
            SuspendLayout();
            // 
            // URLBox
            // 
            URLBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            URLBox.BorderStyle = BorderStyle.FixedSingle;
            URLBox.Location = new Point(20, 23);
            URLBox.Margin = new Padding(5, 6, 5, 6);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(1157, 31);
            URLBox.TabIndex = 0;
            // 
            // GetButton
            // 
            GetButton.Location = new Point(1188, 17);
            GetButton.Margin = new Padding(5, 6, 5, 6);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(125, 44);
            GetButton.TabIndex = 1;
            GetButton.Text = "GET";
            GetButton.UseVisualStyleBackColor = true;
            GetButton.Click += GetButton_Click;
            // 
            // ContentBox
            // 
            ContentBox.Dock = DockStyle.Bottom;
            ContentBox.Location = new Point(0, 99);
            ContentBox.Margin = new Padding(5, 6, 5, 6);
            ContentBox.Name = "ContentBox";
            ContentBox.ReadOnly = true;
            ContentBox.Size = new Size(1333, 766);
            ContentBox.TabIndex = 2;
            ContentBox.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(ContentBox);
            Controls.Add(GetButton);
            Controls.Add(URLBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.RichTextBox ContentBox;
    }
}

