using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace NT106.O23_LAB3_22521103
{
    public partial class UDP_Client : Form
    {
        UdpClient udpClient = new UdpClient();
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendbutton_Click_1(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(messagebox.Text);
            udpClient.Send(data, data.Length, iptext.Text, int.Parse(porttext.Text));
            
        }
    }
}
