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
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void BAI2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartListen);
            thread.Start();
            listenbutton.Enabled = false;
        }
        private void StartListen()
        {
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(iPEndPoint);
            listenerSocket.Listen(5);

            while (true)
            {
                var clientSocket = listenerSocket.Accept();
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();
            }
        }
        private void ReceiveData(Socket clientSocket)
        {
            byte[] receive = new byte[100];
            UTF8Encoding utf8 = new UTF8Encoding(false, true);
            telnetview.Invoke((MethodInvoker)delegate
            {
                telnetview.Items.Add("Client is connected");
            });
            while (true)
            {
                string text = "";
                int bytesReceive;
                do
                {
                    bytesReceive = clientSocket.Receive(receive);
                    try
                    {
                        char[] chars = utf8.GetChars(receive, 0, bytesReceive);
                        text += new string(chars);
                    }
                    catch (DecoderFallbackException)
                    {
                      
                        text += "[Invalid UTF-8 data received]";
                    }
                } while (!text.EndsWith("\n"));
                telnetview.Invoke((MethodInvoker)delegate
                {
                    telnetview.Items.Add(text);
                    telnetview.EnsureVisible(telnetview.Items.Count - 1);
                });
            }
        }

    }
}
