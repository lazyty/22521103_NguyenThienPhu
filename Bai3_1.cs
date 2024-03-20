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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }
        private string docso(long so)
        {
            string[] donVi = { "", "mươi", "trăm", "ngàn","mươi","trăm" ,"triệu","mươi","trăm", "tỷ","mươi","trăm"};
            string[] chuso = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string ketqua = "";
            if (so < 0)
            {
                so = Math.Abs(so);
            }
            int donViHienTai = 0;
            while (so > 0)
            {
                long ChuSoHienTai = so % 10;
                so /= 10;

                if (ChuSoHienTai > 0)
                {
                    ketqua = chuso[ChuSoHienTai] + " " + donVi[donViHienTai] + " " + ketqua;

                }
                donViHienTai++;
            }
            if (ketqua.Length == 0)
            {
                ketqua = "không";
            }

            return ketqua.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num1;
            string datanum1 = textBox1.Text;
            try
            {
                if (datanum1.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền số vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num1 = long.Parse(textBox1.Text.Trim());

                int count = 0;
                for (int i = 0; i < datanum1.Length; i++)
                {
                    if (char.IsDigit(datanum1[i]))
                    {
                        count++;
                    }
                }
                if (count > 12)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên có tối đa 12 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (num1 < 0)
                    {
                        textBox2.Text = "Âm " + docso(num1);
                    }
                    else
                    {
                        textBox2.Text = docso(num1);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
