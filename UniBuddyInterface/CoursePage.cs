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
    public partial class CoursePage : Form
    {
        List<Courses> courses = new List<Courses>();
        public CoursePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Courses c = new Courses();
            c.Name = textBox1.Text;
            courses.Add(c);
            MessageBox.Show("Course Added Successfully!");
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string courseName = textBox2.Text;
            Courses courseToRemove = courses.FirstOrDefault(c => c.Name == courseName);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
                MessageBox.Show("Course Removed Successfully!");
            }
            else
            {
                MessageBox.Show("Course not found!");
            }
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            IIterator iterator = new CoursesIterator(courses);
            richTextBox1.Text = ""; // Clear the text before displaying the courses
            while (iterator.HasNext())
            {
                Courses course = (Courses)iterator.Next();
                richTextBox1.Text += course.Name + "\n"; // Concatenate the name of each course with a newline character
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
