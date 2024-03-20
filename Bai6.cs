using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O23_LAB1_22521103
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            string datanum1 = textBox1.Text;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng điền ngày tháng năm vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParse(textBox1.Text, out DateTime dt))
            {
                MessageBox.Show("Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            num1 = dt.Day; num2 = dt.Month; num3 = dt.Year;
            switch (num2)
            {
                case 1:
                    {
                        if (num1 > 20)
                        {
                            textBox2.Text = " Cung Bảo Bình";
                        }
                        else
                        {
                            textBox2.Text = "Cung Ma Kết";
                        }
                        break;
                    }
                case 2:
                    {
                        if (num1 < 20)
                        {
                            textBox2.Text = "Cung Bảo Bình";
                        }
                        else
                        {
                            textBox2.Text = "Cung Song Ngư";
                        }
                        break;
                    }
                case 3:
                    {
                        if (num1 > 20)
                        {
                            textBox2.Text = " Cung Bạch Dương";
                        }
                        else
                        {
                            textBox2.Text = "Cung Song Ngư";
                        }
                        break;
                    }
                case 4:
                    {
                        if (num1 > 20)
                        {
                            textBox2.Text = " Cung Kim Ngưu";
                        }
                        else
                        {
                            textBox2.Text = "Cung Bạch Dương";
                        }
                        break;
                    }
                case 5:
                    {
                        if (num1 > 21)
                        {
                            textBox2.Text = " Cung Song Tử";
                        }
                        else
                        {
                            textBox2.Text = "Cung Kim Ngưu";
                        }
                        break;
                    }
                case 6:
                    {
                        if (num1 > 21)
                        {
                            textBox2.Text = " Cung Cự Giải";
                        }
                        else
                        {
                            textBox2.Text = "Cung Song Tử";
                        }
                        break;
                    }
                case 7:
                    {
                        if (num1 > 22)
                        {
                            textBox2.Text = " Cung Sư Tử";
                        }
                        else
                        {
                            textBox2.Text = "Cung Cự Giải";
                        }
                        break;
                    }
                case 8:
                    {
                        if (num1 > 22)
                        {
                            textBox2.Text = " Cung Xử Nữ";
                        }
                        else
                        {
                            textBox2.Text = "Cung Sư Tử";
                        }
                        break;
                    }
                case 9:
                    {
                        if (num1 > 23)
                        {
                            textBox2.Text = " Cung Thiên Bình";
                        }
                        else
                        {
                            textBox2.Text = "Cung Xử Nữ";
                        }
                        break;
                    }
                case 10:
                    {
                        if (num1 > 23)
                        {
                            textBox2.Text = " Cung Thần Nông";
                        }
                        else
                        {
                            textBox2.Text = "Cung Thiên Bình";
                        }
                        break;
                    }
                case 11:
                    {
                        if (num1 > 22)
                        {
                            textBox2.Text = " Cung Nhân Mã";
                        }
                        else
                        {
                            textBox2.Text = "Cung Thần Nông";
                        }
                        break;
                    }
                case 12:
                    {
                        if (num1 > 21)
                        {
                            textBox2.Text = " Cung Ma Kết";
                        }
                        else
                        {
                            textBox2.Text = "Cung Nhân Mã";
                        }
                        break;
                    }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
