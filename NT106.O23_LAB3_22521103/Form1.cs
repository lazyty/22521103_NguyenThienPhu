namespace NT106.O23_LAB3_22521103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI1 bai1 = new BAI1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI2 bai2 = new BAI2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAI3 bai3 = new BAI3();
            bai3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BAI6 bai6 = new BAI6();
            bai6.Show();
        }
    }
}
