using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_LAB2_22521103
{
    public partial class BAI4 : Form
    {
        private List<Student> students = new List<Student>();
        private int currentStudentIndex;
        public BAI4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.");
                return;
            }

            // Kiểm tra ràng buộc về MSSV
            int studentID;
            if (!int.TryParse(textBox2.Text, out studentID) || !IsValidStudentID(studentID))
            {
                MessageBox.Show("Mã số sinh viên phải là một số nguyên có 8 chữ số.");
                return;
            }


            if (string.IsNullOrWhiteSpace(textBox3.Text) || !IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bởi số 0.");
                return;
            }


            float mark1, mark2, mark3;
            if (!float.TryParse(textBox4.Text, out mark1) || mark1 < 0 || mark1 > 10 ||
                !float.TryParse(textBox5.Text, out mark2) || mark2 < 0 || mark2 > 10 ||
                !float.TryParse(textBox6.Text, out mark3) || mark3 < 0 || mark3 > 10)
            {
                MessageBox.Show("Điểm môn học phải là một số từ 0 đến 10.");
                return;
            }


            Student student = new Student
            {
                Name = textBox1.Text,
                StudentID = int.Parse(textBox2.Text),
                Phone = textBox3.Text,
                Marks = new float[]
                {
                    float.Parse(textBox4.Text),
                    float.Parse(textBox5.Text),
                    float.Parse(textBox6.Text)
                }
            };
            students.Add(student);
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText("input4.txt", json);

            MessageBox.Show("Đã lưu thông tin sinh viên thành công!");
        }
        private void DisplayCurrentStudentInfo()
        {
            if (currentStudentIndex >= 0 && currentStudentIndex < students.Count)
            {
                var student = students[currentStudentIndex];
                textBox8.Text = student.Name;
                textBox9.Text = student.StudentID.ToString();
                textBox10.Text = student.Phone;
                textBox11.Text = student.Marks[0].ToString();
                textBox12.Text = student.Marks[1].ToString();
                textBox13.Text = student.Marks[2].ToString();
                textBox14.Text = student.AverageMark.ToString("F2");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentStudentIndex > 0)
            {
                currentStudentIndex--;
                DisplayCurrentStudentInfo();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentStudentIndex < students.Count - 1)
            {
                currentStudentIndex++;
                DisplayCurrentStudentInfo();
            }
        }



        private bool IsValidPhoneNumber(string phone)
        {
            return phone.Length == 10 && phone.StartsWith("0");
        }

        private bool IsValidStudentID(int studentID)
        {
            return studentID.ToString().Length == 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ShowInputFileContent();
                string json = File.ReadAllText("input4.txt");
                students = JsonSerializer.Deserialize<List<Student>>(json);

                foreach (var student in students)
                {
                    student.AverageMark = student.Marks.Average();
                }

                using (StreamWriter writer = new StreamWriter("output4.txt"))
                {
                    foreach (var student in students)
                    {
                        string studentInfo = $"{student.Name}\r\n" +
                                                $"{student.StudentID}\r\n" +
                                                $"{student.Phone}\r\n" +
                                                $"{student.AverageMark:F2}\r\n";

                        writer.WriteLine(studentInfo);
                        writer.WriteLine();
                    }
                }
                currentStudentIndex = 0; 
                DisplayCurrentStudentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }

        }
        private void ShowInputFileContent()
        {
            try
            {
                string inputContent = File.ReadAllText("input4.txt");
                richTextBox1.Clear();
                foreach (var student in JsonSerializer.Deserialize<List<Student>>(inputContent))
                {
                    if (IsValidPhoneNumber(student.Phone) && IsValidStudentID(student.StudentID))
                    {
                        StringBuilder studentInfo = new StringBuilder();
                        studentInfo.AppendLine(student.Name);
                        studentInfo.AppendLine($"{student.StudentID}");
                        studentInfo.AppendLine(student.Phone);
                        for (int i = 0; i < student.Marks.Length; i++)
                        {
                            if (i == student.Marks.Length - 1)
                                studentInfo.AppendLine($"{student.Marks[i]}0");
                            else studentInfo.AppendLine($"{student.Marks[i]}");
                        }
                        richTextBox1.AppendText(studentInfo.ToString() + "\n\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public string Phone { get; set; }
        public float[] Marks { get; set; }
        public float AverageMark { get; set; }
    }
}
