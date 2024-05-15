using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB3_22521103
{
    public partial class BAI1 : Form
    {
        public BAI1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDP_Client uDP_Client = new UDP_Client();
            uDP_Client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UDP_Server uDP_Server = new UDP_Server();   
            uDP_Server.Show();
        }
    }
}
