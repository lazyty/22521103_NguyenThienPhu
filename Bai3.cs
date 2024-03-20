using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O23_LAB1_22521103
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            string datanum1 = textBox1.Text;
            try
            {
                if (datanum1.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền số vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num1 = Int32.Parse(textBox1.Text.Trim());
                if (num1>10 || num1 <0)
                {
                    return;
                }
                switch (num1)
                {
                    case 1:
                        {
                            textBox2.Text = "Một";
                            break;
                        }
                    case 2:
                        {
                            textBox2.Text = "Hai";
                            break;
                        }
                    case 3:
                        {
                            textBox2.Text = "Ba";
                            break;
                        }
                    case 4:
                        {
                            textBox2.Text = "Bốn";
                            break;
                        }
                    case 5:
                        {
                            textBox2.Text = "Năm";
                            break;
                        }
                    case 6:
                        {
                            textBox2.Text = "Sáu";
                            break;
                        }
                    case 7:
                        {
                            textBox2.Text = "Bảy";
                            break;
                        }
                    case 8:
                        {
                            textBox2.Text = "Tám";
                            break;
                        }
                    case 9:
                        {
                            textBox2.Text = "Chín";
                            break;
                        }
                    default:
                        {
                            textBox2.Text = "Không";
                            break;
                        }
                }
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
