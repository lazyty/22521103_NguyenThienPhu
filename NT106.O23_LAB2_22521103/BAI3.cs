using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NT106.O23_LAB2_22521103
{
    public partial class BAI3 : Form
    {
        string[] lines;
        public BAI3()
        {
            InitializeComponent();
        }

        private void BAI3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = "Input3.txt";
                StreamReader sr = new StreamReader(inputFile);
                rtb1.Text = sr.ReadToEnd();
                textBox1.Text = inputFile;
                button2.Enabled=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Read File", ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lines=rtb1.Lines;
            FileStream fs = new FileStream("Output3.txt",FileMode.Create,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string line in lines)
            {
                double result = Compute(line);
                sw.WriteLine($"{line} = {result}");
            }
            sw.Flush();
            fs.Close();
            string inputFile = "Output3.txt";
            StreamReader sr = new StreamReader(inputFile);
            rtb2.Text = sr.ReadToEnd();
            textBox2.Text = inputFile;
        }
        static double Compute(string line)
        {
            string[] part = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double result = double.Parse(part[0]);
            for (int i = 1; i < part.Length; i++)
            {
                switch (part[i])
                {
                    case "+":
                        result += double.Parse(part[i + 1]);
                        break;
                    case "-":
                        result -= double.Parse(part[i + 1]);
                        break;
                    case "*":
                        result *= double.Parse(part[i + 1]);
                        break;
                    case "/":
                        result /= double.Parse(part[i + 1]);
                        break;
                }
            }
            return result;
        }
    }
}

