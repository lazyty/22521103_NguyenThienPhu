namespace NT106.O23_LAB4
{
    partial class Bai6
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
            textBox_Name = new TextBox();
            richTextBox_response = new RichTextBox();
            textBox_Pass = new TextBox();
            textBox_URL = new TextBox();
            button_get = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.BorderStyle = BorderStyle.FixedSingle;
            textBox_Name.Location = new Point(140, 73);
            textBox_Name.Margin = new Padding(4, 3, 4, 3);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(342, 31);
            textBox_Name.TabIndex = 0;
            // 
            // richTextBox_response
            // 
            richTextBox_response.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_response.Location = new Point(39, 193);
            richTextBox_response.Margin = new Padding(4, 3, 4, 3);
            richTextBox_response.Name = "richTextBox_response";
            richTextBox_response.Size = new Size(578, 226);
            richTextBox_response.TabIndex = 1;
            richTextBox_response.Text = "";
            // 
            // textBox_Pass
            // 
            textBox_Pass.BorderStyle = BorderStyle.FixedSingle;
            textBox_Pass.Location = new Point(140, 127);
            textBox_Pass.Margin = new Padding(4, 3, 4, 3);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.PasswordChar = '*';
            textBox_Pass.Size = new Size(342, 31);
            textBox_Pass.TabIndex = 2;
            // 
            // textBox_URL
            // 
            textBox_URL.BorderStyle = BorderStyle.FixedSingle;
            textBox_URL.Location = new Point(140, 18);
            textBox_URL.Margin = new Padding(4, 3, 4, 3);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(476, 31);
            textBox_URL.TabIndex = 3;
            textBox_URL.Text = "https://nt106.uitiot.vn/api/v1/user/me";
            textBox_URL.TextChanged += textBox_URL_TextChanged;
            // 
            // button_get
            // 
            button_get.Location = new Point(499, 73);
            button_get.Margin = new Padding(4, 3, 4, 3);
            button_get.Name = "button_get";
            button_get.Size = new Size(117, 90);
            button_get.TabIndex = 4;
            button_get.Text = "Get";
            button_get.UseVisualStyleBackColor = true;
            button_get.Click += button_get_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 5;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 453);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_get);
            Controls.Add(textBox_URL);
            Controls.Add(textBox_Pass);
            Controls.Add(richTextBox_response);
            Controls.Add(textBox_Name);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Name;
        private RichTextBox richTextBox_response;
        private TextBox textBox_Pass;
        private TextBox textBox_URL;
        private Button button_get;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}