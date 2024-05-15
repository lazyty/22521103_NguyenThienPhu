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
    public partial class TCP_server : Form
    {
        public TCP_server()
        {
            InitializeComponent();
        }
        List<TcpClient> clientList = new List<TcpClient>();
        TcpListener server;
        IPEndPoint ipEP;
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listenbutton_Click(object sender, EventArgs e)
        {
            int port = 8888;
            ipEP = new IPEndPoint(IPAddress.Any, port);
            server = new TcpListener(ipEP);
            server.Start();

            Thread listenThread = new Thread(Listen);
            listenThread.Start();

            serverview.Text += "Server started!\r\n";
            listenbutton.Enabled = false;
        }
        private void Listen()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    clientList.Add(client);
                    serverview.BeginInvoke((Action)(() => serverview.Text += "Connected from " + client.Client.RemoteEndPoint+ "\r\n"));

                    Thread receiveThread = new Thread(() => Receive(client));
                    receiveThread.Start();
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Socket exception: " + ex.Message);
                }
            }
        }

        void Receive(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        serverview.BeginInvoke((Action)(() => serverview.Text += "Client đã out" + "\r\n"));

                        stream.Close();
                        client.Close();
                        clientList.Remove(client);
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    serverview.BeginInvoke((Action)(() => serverview.Text += "From client: " + message + "\r\n"));
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error receiving data: " + ex.Message);
                    break;
                }
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.Stop();
            }
            catch
            {
                return;
            }
        }

        private void serverview_TextChanged(object sender, EventArgs e)
        {
            serverview.SelectionStart = serverview.Text.Length;
            serverview.ScrollToCaret();
        }
    }

}
