using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB3_22521103.bai3
{
    public partial class TCP_client : Form
    {
        public TCP_client()
        {
            InitializeComponent();
        }
        private ClientConnection client;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                client.Disconnect();
                sendbutton.Enabled = false;
                connectbutton.Enabled = true;
                disconnectbutton.Enabled = false;
                exitbutton.Enabled = true;
            }));
            statusbox.Text = "Đề nghị kết nối với server";
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    client = new ClientConnection();
                    client.Connect();
                }
                catch
                {
                    statusbox.Text = "Không thể kết nối tới server";
                    return;
                }

                if (!client.isConnected)
                {
                    return;
                }
                BeginInvoke((Action)(() =>
                {
                    statusbox.Text = "Đã kết nối đến server thành công";
                    sendbutton.Enabled = true;
                    connectbutton.Enabled = false;
                    disconnectbutton.Enabled = true;
                    exitbutton.Enabled = false;
                }));
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Notice");
            }
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (clientbox.Text == "")
            {
                return;
            }
            string message = clientbox.Text.Trim();
            client.Send(message);
            clientbox.Focus();
        }
    }
    class ClientConnection
    {
        public bool isConnected = false;
        IPAddress ipAdd = IPAddress.Parse("127.0.0.1");
        IPEndPoint ipEP;
        TcpClient client;
        NetworkStream stream;
        int port = 8888;

        public void Connect()
        {
            try
            {
                client = new TcpClient();
                ipEP = new IPEndPoint(ipAdd, port);
                client.Connect(ipEP);
                stream = client.GetStream();
                isConnected = true;
            }
            catch (SocketException ex) when (ex.SocketErrorCode == SocketError.ConnectionRefused)
            {
                MessageBox.Show("Không thể kết nối server: Server không hoạt động ", "Lỗi");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Lỗi");
                return;
            }
        }

        public void Send(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (isConnected)
                {
                    client.Close();
                    stream.Close();
                    isConnected = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing client socket: " + ex.Message);
            }
            finally
            {
                stream?.Dispose();
                client?.Dispose();
            }
        }
    }
}
