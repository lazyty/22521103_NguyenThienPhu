using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O23_LAB1_22521103
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private long giaithua(int n)
        {
            long gt=1;
            if (n<0)
            {
                return -1;
            }
            else
            {
                if (n==0)
                {
                    return 1;
                }
                else
                {
                    for (int i=1;i<n+1;i++)
                    {
                        gt=gt*i;
                    }
                }
            }
            return gt;
        }
        private double tinhtong(int x,int y)
        {
            double kq=0;
            for (int i = 1; i < y+1; i++)
            {
                kq=kq + Math.Pow(x,i);
            }
            return kq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            string datanum1 = textBox1.Text;
            string datanum2 = textBox2.Text;
            try
            {
                if (datanum1.Length == 0 || datanum2.Length == 0 )
                {
                    MessageBox.Show("Vui lòng điền đủ hai số vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                string choice;
                choice = comboBox1.SelectedItem.ToString();
                switch (choice) 
                {
                    case "Bang cuu chuong (B-A)":
                        {
                            int z = num2 - num1;
                            listBox1.Items.Clear();
                            for (int i = 1; i <= 10; i++)
                            {
                                listBox1.Items.Add(string.Format("{0} x {1} = {2}", z, i, z * i));
                            }
                            break;
                        }
                    case "(A-B)!":
                        {
                            int z = num1 - num2;
                            textBox3.Text= giaithua(z).ToString();
                            break;
                        }
                    case "S=A^1 + A^2 + A^3 + ... + A^B":
                        { 
                            textBox3.Text= tinhtong(num1,num2).ToString();
                            break;
                        }
                     default:
                        {

                            break;
                        }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Vui lòng nhập số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
