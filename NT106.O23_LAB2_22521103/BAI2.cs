using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB2_22521103
{
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "File txt|*txt";
            if (o.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = o.SafeFileName;
                StreamReader sr = new StreamReader(o.SafeFileName);
                string hien = sr.ReadToEnd();
                Hienthi.Text = hien;
                long siz = new FileInfo(o.SafeFileName).Length;
                string URL = ":// " + o.FileName;
                int lcount=0,wcount=0,ccount=0;
                using StreamReader rs= new StreamReader(o.FileName);
                {
                    string line;
                    while ((line = rs.ReadLine()) != null)
                    {
                        lcount++;
                        ccount += line.Length;
                        string[] word = line.Split(' ');
                        wcount += word.Length;
                    }
                }
                textBox2.Text = siz.ToString() + " byte";
                textBox3.Text = URL;
                textBox4.Text = lcount.ToString();
                textBox5.Text = wcount.ToString();  
                textBox6.Text = ccount.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
