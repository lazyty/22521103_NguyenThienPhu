using NT106.O23_LAB3_22521103.bai3;
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
    public partial class BAI3 : Form
    {
        public BAI3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCP_server tCP_Server = new TCP_server();
            tCP_Server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCP_client tCP_Client = new TCP_client();
            tCP_Client.Show();
        }
    }
}
