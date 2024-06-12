using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_3
{
    public partial class Bai2_3 : Form
    {
        public Bai2_3()
        {
            InitializeComponent();
        }

        private void IMAP_Click(object sender, EventArgs e)
        {
            IMAP imap = new IMAP();
            imap.Show();
        }

        private void POP_Click(object sender, EventArgs e)
        {
            POP pop = new POP();
            pop.Show();
        }
    }
}
