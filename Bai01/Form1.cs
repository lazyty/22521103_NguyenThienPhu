using MimeKit;
using MailKit.Net.Smtp;


namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl. 
                client.Authenticate("22520672@gm.uit.edu.vn", "alye jxdi auqm goua"); // gmail account, app password 

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Khoa", textBox1.Text));
                message.To.Add(new MailboxAddress("", textBox2.Text));
                message.Subject = textBox3.Text;
                message.Body = new TextPart("plain") // gửi ở dạng plain text, hoặc có thể thay 
                                                     //bằng “html” nếu muốn gửi email dạng html
                {
                    Text = richTextBox1.Text
                };
                client.Send(message);
                MessageBox.Show("Gửi Email thành công.", "Thanh công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gửi Email không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
