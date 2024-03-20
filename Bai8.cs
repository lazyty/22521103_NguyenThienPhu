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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
            HienThi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<string> DanhSachMonAn = new List<string> { "Phở", "Bún", "Cơm " };
        private void HienThi()
        {
            textBox1.Text = string.Join("\t", DanhSachMonAn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string food = textBox3.Text.Trim();
            if (!string.IsNullOrEmpty(food))
            {
                DanhSachMonAn.Add(food);
                HienThi();
                textBox3.ResetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DanhSachMonAn.Count()==0)
            {
                MessageBox.Show("Vui lòng nhập thêm món ăn.", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Random r= new Random();
            int a=r.Next(0,DanhSachMonAn.Count());
            textBox2.Text = DanhSachMonAn[a].ToString();
        }
    }
}
