namespace NT106.O23_LAB3_22521103
{
    partial class BAI6
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
            clientbutton = new Button();
            serverbutton = new Button();
            SuspendLayout();
            // 
            // clientbutton
            // 
            clientbutton.Enabled = false;
            clientbutton.Location = new Point(12, 12);
            clientbutton.Name = "clientbutton";
            clientbutton.Size = new Size(319, 64);
            clientbutton.TabIndex = 3;
            clientbutton.Text = "New Client";
            clientbutton.UseVisualStyleBackColor = true;
            clientbutton.Click += clientbutton_Click;
            // 
            // serverbutton
            // 
            serverbutton.Location = new Point(12, 96);
            serverbutton.Name = "serverbutton";
            serverbutton.Size = new Size(319, 64);
            serverbutton.TabIndex = 2;
            serverbutton.Text = "Chat Server";
            serverbutton.UseVisualStyleBackColor = true;
            serverbutton.Click += serverbutton_Click;
            // 
            // BAI6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 172);
            Controls.Add(clientbutton);
            Controls.Add(serverbutton);
            Name = "BAI6";
            Text = "BAI6";
            ResumeLayout(false);
        }

        #endregion

        private Button clientbutton;
        private Button serverbutton;
    }
}