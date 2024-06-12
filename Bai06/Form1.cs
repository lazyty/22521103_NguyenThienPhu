using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = ofd.FileName;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string mailfrom = textBox1.Text.Trim();
            string mailto = textBox2.Text.Trim();
            string password = textBox4.Text.Trim();
            string subject = textBox3.Text.Trim();
            string body = richTextBox1.Text.Trim();

            SendMail(subject, body, mailto, mailfrom, password);
        }


        private void CleanUp()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
        }

        private void SendMail(string subject, string body, string mailto, string mailfrom, string password)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailfrom, password);

                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    message.From = fromAddress;
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.To.Add(mailto);
                    message.Body = body;

                    if (textBox5.Text != "")
                    {
                        Attachment attachment = new Attachment(textBox5.Text);
                        message.Attachments.Add(attachment);
                    }

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Send successfully!");
                        CleanUp();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        CleanUp();
                    }
                }
            }

        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

