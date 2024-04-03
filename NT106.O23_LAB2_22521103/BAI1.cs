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
    public partial class BAI1 : Form
    {
        public BAI1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Input1.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Nguyen Hong Anh Khoa \n");
            sw.Write("Student ID: 11005568\n");
            sw.Write("Class: DD001\n");
            sw.Flush();
            fs.Close();
            try
            {
                string inputFile = "Input1.txt";
                StreamReader sr = new StreamReader(inputFile);
                string hien = sr.ReadToEnd();
                Hienthi.Text = hien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Read File", ex.Message);
            }
        }

        private void Hienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Output1.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            string data=Hienthi.Text.ToUpper();
            sw.Write(data);
            sw.Flush();
            fs.Close();
            StreamReader sr = new StreamReader("Output1.txt");
            string hien = sr.ReadToEnd();
            Hienthi.Text = hien;

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
