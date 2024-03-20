using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB1_22521103
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            string datanum1 = textBox1.Text;
            string datanum2 = textBox2.Text;
            string datanum3 = textBox3.Text;
            try
            {
                if (datanum1.Length == 0 || datanum2.Length == 0 || datanum3.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đủ ba số vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                num3 = Int32.Parse(textBox3.Text.Trim());
                int max = num1;
                if (max<=num2)
                {
                    max = num2;
                    if (max<=num3)
                    {
                        max = num3;
                    }
                    else
                    {
                        max = num2;
                    }
                }
                else
                {
                    if(max<num3) 
                    {
                        max = num3;
                    }
                }
                int min = num1;
                if (min >= num2)
                {
                    min = num2;
                    if (min>=num3)
                    {
                        min = num3;
                    }
                }
                else
                {
                    if (min >= num3)
                    {
                        min = num3;
                    }
                }
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Vui lòng nhập số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
