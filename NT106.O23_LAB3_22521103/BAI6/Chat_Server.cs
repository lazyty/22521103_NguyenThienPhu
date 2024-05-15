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

namespace NT106.O23_LAB3_22521103
{
    public partial class Chat_Server : Form
    {
        public Chat_Server()
        {
            InitializeComponent();
        }

        private void rtbChatBox_TextChanged(object sender, EventArgs e)
        {

        }
        const int maxWidth = 200;
        const int maxHeight = 150;

        private bool serverRunning = false;
        private TcpListener tcpServer;
        private Thread listenThread;
        private Dictionary<string, TcpClient> dic_clients = new Dictionary<string, TcpClient>();
        private bool listening = true;
        private delegate void SafeCallDelegate(string username, string message);
        private IPAddress ipServer = IPAddress.Any;


        private void AddMessage(string username, string data)
        {
            if (rtbChatBox.InvokeRequired)
            {
                var method = new SafeCallDelegate(AddMessage);
                rtbChatBox.Invoke(method, new object[] { username, data });
            }
            else
            {
                if (username == null)
                {
                    rtbChatBox.AppendText(data + Environment.NewLine);
                }
                else
                {
                    rtbChatBox.AppendText($"{username}: {data}" + Environment.NewLine);
                }
                ScrollToBottom();
            }
        }

        private void Listen()
        {
            tcpServer = new TcpListener(ipServer, int.Parse(txtServerPort.Text));
            tcpServer.Start();
            serverRunning = true;

            try
            {
                while (listening)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    IPEndPoint remoteIpEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                    string clientIp = remoteIpEndPoint.Address.ToString();
                    int clientPort = remoteIpEndPoint.Port;

                    // Lấy tên
                    NetworkStream net_stream = client.GetStream();
                    byte[] data = new byte[1024 * 5000];
                    int byte_count = net_stream.Read(data, 0, data.Length);
                    string username = Encoding.UTF8.GetString(data, 0, byte_count);

                    if (username == "Admin" || username == "Administrator")
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username is reserved!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else if (dic_clients.ContainsKey(username))
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username has already existed!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else
                    {
                        AddMessage("Message", $"User {username} from ({clientIp}:{clientPort}) has connected succesfully");
                        dic_clients.Add(username, client);
                        Thread receiveThread = new Thread(Receive)
                        {
                            IsBackground = true
                        };
                        receiveThread.Start(username);
                    }
                }
            }
            catch
            {
                tcpServer = new TcpListener(ipServer, int.Parse(txtServerPort.Text));
            }
        }


        private void Broadcast(string username, string message, TcpClient except_this_client = null)
        {
            byte[] flooding_message = Encoding.UTF8.GetBytes($"{username}: {message}");
            foreach (TcpClient client in dic_clients.Values)
            {
                if (client != except_this_client)
                {
                    NetworkStream net_stream = client.GetStream();
                    net_stream.Write(flooding_message, 0, flooding_message.Length);
                    net_stream.Flush();
                }
            }
        }

        bool IsImageData(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    Image.FromStream(ms);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Receive(object obj)
        {
            string username = obj.ToString();
            TcpClient client = dic_clients[username];
            NetworkStream net_stream = client.GetStream();
            byte[] data = new byte[1024 * 10000];
            try
            {
                while (listening)
                {
                    int byte_count = net_stream.Read(data, 0, data.Length);


                    if (byte_count == 0)
                    {
                        dic_clients.Remove(username);
                        client.Close();
                        AddMessage("Server", $"Client {username} disconnected.");
                        break;
                    }

                    if (IsImageData(data))
                    {
                        using (MemoryStream ms = new MemoryStream(data, 0, byte_count))
                        {
                            Image image = Image.FromStream(ms);

                            Invoke((MethodInvoker)delegate
                            {
                                AddImageToChat(username, image);
                            });
                            SendImageBroadCast(image, client);
                        }
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(data, 0, byte_count);
                        AddMessage(username, message);
                        Broadcast(username, message, client);
                    }

                    Array.Clear(data, 0, data.Length);
                }
            }
            catch (IOException ex)
            {
                dic_clients.Remove(username);
                client.Close();
                AddMessage("Server", $"Warning: Client {username} connection lost. {ex.Message}");
            }
        }

        

        private void ChangeTextStage()
        {
            txtServerPort.ReadOnly = txtUserNumber.ReadOnly = false;
            btnListen.Enabled = !btnListen.Enabled;
        }
        private bool IsImageFile(string filePath)
        {
            try
            {
                using (var image = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private Image ResizeImage(System.Drawing.Image image, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;
            double aspectRatio = (double)image.Width / image.Height;

            if (image.Width > maxWidth)
            {
                newWidth = maxWidth;
                newHeight = (int)(newWidth / aspectRatio);
            }
            else if (image.Height > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)(newHeight * aspectRatio);
            }
            else
            {
                newWidth = image.Width;
                newHeight = image.Height;
            }

            return new Bitmap(image, newWidth, newHeight);
        }

        private void SendImageBroadCast(Image image, TcpClient except_this_client = null)
        {
            image = ResizeImage(image, maxWidth, maxHeight);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageData = ms.ToArray();

                foreach (TcpClient client in dic_clients.Values)
                {
                    if (client != except_this_client)
                    {
                        NetworkStream netStream = client.GetStream();
                        netStream.Write(imageData, 0, imageData.Length);
                        netStream.Flush();
                    }
                }
            }
        }
        private void SendFile(string filePath)
        {
            byte[] fileNameBytes = Encoding.UTF8.GetBytes(Path.GetFileName(filePath));
            byte[] fileData = File.ReadAllBytes(filePath);
            int totalBytes = fileNameBytes.Length + fileData.Length;

            foreach (TcpClient client in dic_clients.Values)
            {
                using (NetworkStream netStream = client.GetStream())
                {
                    int bytesSent = 0;
                    netStream.Write(fileNameBytes, 0, fileNameBytes.Length);
                    netStream.Flush();
                    netStream.Write(fileData, 0, fileData.Length);
                    netStream.Flush();
                }
            }
            AddMessage(null, "Chuyển file thành công!!");
        }
        private void AddImageToChat(string username, Image image)
        {
            rtbChatBox.AppendText(Environment.NewLine);
            rtbChatBox.Select(rtbChatBox.Text.Length, 0);
            rtbChatBox.SelectionColor = rtbChatBox.ForeColor;
            rtbChatBox.AppendText($"{username}: ");
            rtbChatBox.Select(rtbChatBox.Text.Length, 0);
            rtbChatBox.ReadOnly = false;
            image = ResizeImage(image, maxWidth, maxHeight);

            if (rtbChatBox.InvokeRequired)
            {
                rtbChatBox.BeginInvoke((MethodInvoker)delegate
                {
                    Clipboard.SetImage(image);
                    rtbChatBox.Paste();
                });
            }
            else
            {
                Clipboard.SetImage(image);
                rtbChatBox.Paste();
            }
            rtbChatBox.ScrollToCaret();
            rtbChatBox.ReadOnly = true;
            rtbChatBox.AppendText(Environment.NewLine);
        }
        
        private void ScrollToBottom()
        {
            rtbChatBox.SelectionStart = rtbChatBox.Text.Length;
            rtbChatBox.ScrollToCaret();
        }

        private void btnListen_Click_1(object sender, EventArgs e)
        {
            int users_num = int.Parse(txtUserNumber.Text);
            while (users_num > 0)
            {
                Client client = new Client();
                client.Show();
                users_num--;
            }

            AddMessage("Admin", $"{ipServer} - Waiting for connections...");
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start();
            this.btnListen.Enabled = false;
            txtServerPort.ReadOnly = txtUserNumber.ReadOnly = true;
        }

        private void btnShutServer_Click_1(object sender, EventArgs e)
        {
            if (!serverRunning)
            {
                return;
            }

            listening = false;

            if (dic_clients.Count > 0)
            {
                foreach (TcpClient client in dic_clients.Values)
                {
                    client.Close();
                }
                dic_clients.Clear();
            }

            tcpServer.Stop();
            ChangeTextStage();
            serverRunning = false;
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (message == "//connections")
            {
                int count = dic_clients.Count;
                AddMessage("Connection", $"{count}");
                txtMessage.Clear();
                return;
            }

            AddMessage("Admin", message);
            Broadcast("Admin", message);
            txtMessage.Clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendFlie_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (IsImageFile(filePath))
                {

                    Image image = Image.FromFile(filePath);
                    SendImageBroadCast(image);
                    AddImageToChat("Admin", image);
                }
                else
                {
                    SendFile(filePath);
                }
            }
        }
    }
}
