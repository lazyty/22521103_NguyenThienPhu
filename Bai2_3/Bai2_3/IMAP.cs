using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using MailKit;

namespace Bai2_3
{
    public partial class IMAP : Form
    {
        public IMAP()
        {
            InitializeComponent();
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(textBox1.Text, textBox2.Text);
                dataGridView1.Columns.Add("Subject", "Subject");
                dataGridView1.Columns.Add("From", "From");
                dataGridView1.Columns.Add("Date", "Date");
                int max = 0;
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = inbox.Count - 1; i > 0; i--)
                {
                    max++;
                    var message = inbox.GetMessage(i);
                    string subject = message.Subject;
                    string from = message.From.ToString();
                    DateTime date = message.Date.DateTime;
                    dataGridView1.Rows.Add(subject, from, date);
                    if (max == 5)
                    {
                        break;
                    }
                }
                MessageBox.Show("Đăng nhập Email thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập Email không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void IMAP_Load(object sender, EventArgs e)
        {

        }
    }
}
