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
using Newtonsoft.Json.Linq;
namespace NT106.O23_LAB4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            string url = textBox_URL.Text;
            string username = textBox_Name.Text;
            string password = textBox_Pass.Text;

            using (HttpClient client = new HttpClient())
            {
                // Tạo nội dung form-data cho body của yêu cầu POST
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();
                    var jsonResponse = JObject.Parse(responseString);
                    if (response.IsSuccessStatusCode)
                    {
                        string? accessToken = jsonResponse["access_token"]?.ToString();
                        string? tokenType = jsonResponse["token_type"]?.ToString();

                        if (accessToken != null && tokenType != null)
                        {
                            richTextBox_response.Text = $"{tokenType} {accessToken}\nĐăng nhập thành công";
                        }
                        else
                        {
                            richTextBox_response.Text = "Đăng nhập thất bại. Không tìm thấy token.";
                        }
                    }
                    else
                    {
                        string? detail = jsonResponse["detail"]?.ToString();
                        richTextBox_response.Text = $"Đăng nhập thất bại: {detail}";
                    }
                }
                catch (Exception ex)
                {
                    richTextBox_response.Text = $"Lỗi khi thực hiện kết nối: {ex.Message}";
                }
            }
        }
    }
}
    

