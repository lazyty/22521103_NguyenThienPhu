using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB4
{
    public partial class Bai6 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Bai6()
        {
            InitializeComponent();
        }

        private void textBox_URL_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_get_Click(object sender, EventArgs e)
        {
            string url = textBox_URL.Text;
            string username = textBox_Name.Text;
            string password = textBox_Pass.Text;
            var token = await GetTokenAsync(username, password);
            if (token != null)
            {
                var userInfo = await GetUserInfoAsync(token);
                richTextBox_response.Text = userInfo;
            }
        }


        private async Task<string?> GetTokenAsync(string username, string password)
        {
            var values = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var json = JObject.Parse(responseString);
                    string accessToken = json["access_token"]?.ToString();
                    string tokenType = json["token_type"]?.ToString();

                    if (!string.IsNullOrEmpty(accessToken) && !string.IsNullOrEmpty(tokenType))
                    {
                        return $"{accessToken}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid token response!");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error parsing token response: {ex.Message}");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Login failed! Please check your username and password.");
                return null;
            }
        }

        private async Task<string?> GetUserInfoAsync(string token)
        {
            try
            {
                // Set the Authorization header with the token
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

                // Send GET request to fetch user information
                var response = await client.GetAsync("https://nt106.uitiot.vn/api/v1/user/me");
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return responseString;
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve user info! Status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user info: {ex.Message}");
                return null;
            }
        }
    }
}
