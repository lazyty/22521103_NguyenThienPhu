namespace Bai2_3
{
    partial class Bai2_3
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
            this.IMAP = new System.Windows.Forms.Button();
            this.POP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IMAP
            // 
            this.IMAP.Location = new System.Drawing.Point(80, 70);
            this.IMAP.Name = "IMAP";
            this.IMAP.Size = new System.Drawing.Size(75, 23);
            this.IMAP.TabIndex = 0;
            this.IMAP.Text = "IMAP";
            this.IMAP.UseVisualStyleBackColor = true;
            this.IMAP.Click += new System.EventHandler(this.IMAP_Click);
            // 
            // POP
            // 
            this.POP.Location = new System.Drawing.Point(219, 70);
            this.POP.Name = "POP";
            this.POP.Size = new System.Drawing.Size(75, 23);
            this.POP.TabIndex = 1;
            this.POP.Text = "POP";
            this.POP.UseVisualStyleBackColor = true;
            this.POP.Click += new System.EventHandler(this.POP_Click);
            // 
            // Bai2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 150);
            this.Controls.Add(this.POP);
            this.Controls.Add(this.IMAP);
            this.Name = "Bai2_3";
            this.Text = "Bai2_3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IMAP;
        private System.Windows.Forms.Button POP;
    }
}