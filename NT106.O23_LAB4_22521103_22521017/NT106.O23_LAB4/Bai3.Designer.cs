namespace NT106.O23_LAB4
{
    partial class Bai3
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            Reloadbutton = new Button();
            Loadbutton = new Button();
            DownResbutton = new Button();
            DownFilebutton = new Button();
            addressBar = new TextBox();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Bottom;
            webView.Location = new Point(0, 135);
            webView.Margin = new Padding(5, 6, 5, 6);
            webView.Name = "webView";
            webView.Size = new Size(1327, 915);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // Reloadbutton
            // 
            Reloadbutton.Location = new Point(20, 79);
            Reloadbutton.Margin = new Padding(5, 6, 5, 6);
            Reloadbutton.Name = "Reloadbutton";
            Reloadbutton.Size = new Size(125, 44);
            Reloadbutton.TabIndex = 1;
            Reloadbutton.Text = "Reload";
            Reloadbutton.UseVisualStyleBackColor = true;
            Reloadbutton.Click += Reloadbutton_Click;
            // 
            // Loadbutton
            // 
            Loadbutton.Location = new Point(20, 23);
            Loadbutton.Margin = new Padding(5, 6, 5, 6);
            Loadbutton.Name = "Loadbutton";
            Loadbutton.Size = new Size(125, 44);
            Loadbutton.TabIndex = 2;
            Loadbutton.Text = "Load";
            Loadbutton.UseVisualStyleBackColor = true;
            Loadbutton.Click += Loadbutton_Click;
            // 
            // DownResbutton
            // 
            DownResbutton.Location = new Point(1127, 79);
            DownResbutton.Margin = new Padding(5, 6, 5, 6);
            DownResbutton.Name = "DownResbutton";
            DownResbutton.Size = new Size(187, 44);
            DownResbutton.TabIndex = 3;
            DownResbutton.Text = "Down Resources";
            DownResbutton.UseVisualStyleBackColor = true;
            DownResbutton.Click += DownResbutton_Click;
            // 
            // DownFilebutton
            // 
            DownFilebutton.Location = new Point(1188, 23);
            DownFilebutton.Margin = new Padding(5, 6, 5, 6);
            DownFilebutton.Name = "DownFilebutton";
            DownFilebutton.Size = new Size(125, 44);
            DownFilebutton.TabIndex = 4;
            DownFilebutton.Text = "Down Files";
            DownFilebutton.UseVisualStyleBackColor = true;
            DownFilebutton.Click += DownFilebutton_Click;
            // 
            // addressBar
            // 
            addressBar.BorderStyle = BorderStyle.FixedSingle;
            addressBar.Location = new Point(155, 23);
            addressBar.Margin = new Padding(5, 6, 5, 6);
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(1022, 31);
            addressBar.TabIndex = 5;
            addressBar.Text = "https://uit.edu.vn/";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(155, 79);
            progressBar.Margin = new Padding(5, 6, 5, 6);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(827, 44);
            progressBar.TabIndex = 6;
            progressBar.Value = 50;
            progressBar.Visible = false;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 1050);
            Controls.Add(progressBar);
            Controls.Add(addressBar);
            Controls.Add(DownFilebutton);
            Controls.Add(DownResbutton);
            Controls.Add(Loadbutton);
            Controls.Add(Reloadbutton);
            Controls.Add(webView);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Bai3";
            Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button Reloadbutton;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Button DownResbutton;
        private System.Windows.Forms.Button DownFilebutton;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}