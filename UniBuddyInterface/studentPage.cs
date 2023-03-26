using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniBuddyInterface
{
    public partial class studentPage : Form
    {
        List<Student> students = new List<Student>();
        public studentPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = textBox1.Text;
            students.Add(student);
            MessageBox.Show("Student Added Successfully!");
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentName = textBox2.Text;
            Student studentToRemove = students.FirstOrDefault(student => student.Name == studentName);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                MessageBox.Show("Student Removed Successfully!");
            }
            else
            {
                MessageBox.Show("Student not Found!!");
            }
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IIterator iterator = new StudentIterator(students);
            richTextBox1.Text = "";
            while (iterator.HasNext())
            {
                Student student = (Student)iterator.Next();


                richTextBox1.Text += student.Name + "\n"; 

            }
        }

        private void studentPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

