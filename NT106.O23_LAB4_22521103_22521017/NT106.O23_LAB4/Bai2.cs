using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        
        string url = "";

        private string getHTML(string szURL)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response.
                using (WebResponse response = request.GetResponse())
                {
                    // Get the stream containing content returned by the server.
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Read the content.
                            string responseFromServer = reader.ReadToEnd();
                            return responseFromServer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching HTML: {ex.Message}");
                return null;
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string url = URLBox.Text;
            DownloadFile(url);
        }
        private void DownloadFile(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("URL is empty. Please provide a valid URL.");
                return;
            }

            string location = DownloadBox.Text;
            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Download location is empty. Please provide a valid location.");
                return;
            }

            try
            {
                using (WebClient myClient = new WebClient())
                {
                    myClient.DownloadFile(url, location);
                    MessageBox.Show("File downloaded successfully.");
                }
            }
            catch (WebException webEx)
            {
                string errorMessage;
                if (webEx.Status == WebExceptionStatus.ProtocolError && webEx.Response != null)
                {
                    var resp = (HttpWebResponse)webEx.Response;
                    errorMessage = $"HTTP Error: {(int)resp.StatusCode} - {resp.StatusDescription}";
                }
                else if (webEx.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    errorMessage = "Error: Unable to resolve the remote name. Check the URL and your internet connection.";
                }
                else
                {
                    errorMessage = $"WebException: {webEx.Message}";
                }
                MessageBox.Show(errorMessage);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: You do not have permission to write to the specified location.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading file: {ex.Message}");
            }
        }

        private void GetButton_Click_1(object sender, EventArgs e)
        {
            url = URLBox.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            try
            {
                string content = getHTML(url);
                if (content != null)
                {
                    ContentBox.Text = content;
                }
                DownloadButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't read the URL: {ex}");
            }
        }
    }
}
