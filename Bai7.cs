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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = textBox1.Text.Split(',');
            if (a.Length<3)
            {
                MessageBox.Show("Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ten= a[0].Trim();
            string[] diemt = a.Skip(1).ToArray();
            int[] diemarr;
            try
            {
                diemarr = diemt.Select(int.Parse).ToArray();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string messi = $"Họ và tên: { ten }\n";
            for (int i = 0; i < diemarr.Length; i++)
            {
                messi += $"Môn {i+1} : {diemarr[i]}\t";
            }
            MessageBox.Show(messi);
            double diemTrungBinh;
            if (diemarr.Length > 0)
            {
                diemTrungBinh = diemarr.Average();
            }
            else
            {
                diemTrungBinh = 0;
            }
            textBox2.Text = diemTrungBinh.ToString("0.00");

            double diemmax;
            double diemmin;
            int sono=0, sodu=0;
            if (diemarr.Length > 0)
            {
                diemmax = diemarr.Max();
            }
            else
            {
                diemmax = 0;
            }
            textBox3.Text = diemmax.ToString("0.00");

            if (diemarr.Length > 0)
            {
                diemmin= diemarr.Min();
            }
            else
            {
                diemmin = 0;
            }
            textBox4.Text = diemmin.ToString("0.00");

            for (int i = 0;i < diemarr.Length;i++)
            {
                if (diemarr[i] >= 3)
                {
                    sodu++;
                }
                else
                {
                    sono++;
                }
            }
            textBox7.Text = sodu.ToString();
            textBox6.Text = sono.ToString();
            
            if (diemTrungBinh>=8 && dkdb(diemarr,8)==true)
            {
                textBox5.Text = "Giỏi";
            }
            else if (diemTrungBinh >= 6.5 && dkdb(diemarr,6.5) == true)
            {
                textBox5.Text = "Khá";
            }
            else if(diemTrungBinh >= 5 && dkdb(diemarr, 5) == true)
            {
                textBox5.Text = "Trung Bình";
            }
            else if (diemTrungBinh >= 3.5 && dkdb(diemarr, 3.5) == true)
            {
                textBox5.Text = "Yếu";
            }
            else
            {
                textBox5.Text = "Kém";
            }
        }
        bool dkdb(int []a,double x)
        {
            if (x==8)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < 6.5)
                    {
                        return false;
                        
                    }
                }
            }
            if (x == 6.5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < 5)
                    {
                        return false;

                    }
                }
            }
            if (x == 5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < 3.5)
                    {
                        return false;

                    }
                }
            }
            if (x == 3.5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < 2)
                    {
                        return false;

                    }
                }
            }
            return true;
        }
    }
}
