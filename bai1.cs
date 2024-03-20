using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NT106.O23_LAB1_22521103
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            string datanum1 = textBox1.Text;
            string datanum2 = textBox2.Text;
            try
            {
                if (datanum1.Length == 0 || datanum2.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đủ hai số vào ô trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();

            }
            catch(Exception a)
            {
                MessageBox.Show("Vui lòng nhập số nguyên.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }
    }
}
