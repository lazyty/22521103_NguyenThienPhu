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
    public partial class BAI6 : Form
    {
        public BAI6()
        {
            InitializeComponent();
        }

        private void clientbutton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void serverbutton_Click(object sender, EventArgs e)
        {
            clientbutton.Enabled = true;
            Chat_Server server = new Chat_Server();
            server.Show();
        }
    }
}
