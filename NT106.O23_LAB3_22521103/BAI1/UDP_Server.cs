using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O23_LAB3_22521103
{
    public partial class UDP_Server : Form
    {
        private UdpClient udpClient;
        private Thread receiver;
        public UDP_Server()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listenbutton_Click(object sender, EventArgs e)
        {
            listenbutton.Enabled = false;
            receiver = new Thread(new ThreadStart(Receive));
            receiver.Start();
        }
        private void Receive()
        {
            int port = int.Parse(porttext.Text);
            udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref remoteEP);
                string text = Encoding.UTF8.GetString(data);

                messagelist.Invoke((MethodInvoker)delegate
                {
                    messagelist.Items.Add($" {remoteEP}: {text}");
                });
            }
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiver != null && receiver.IsAlive)
            {
                receiver.Abort();
            }
            Environment.Exit(0);
        }

        private void messagelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
