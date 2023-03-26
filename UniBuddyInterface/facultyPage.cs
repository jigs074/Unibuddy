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
    public partial class facultyPage : Form
    {
        List<Faculty> faculty = new List<Faculty>();
        public facultyPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faculty f = new Faculty();
            f.Name = textBox1.Text;
            f.facultyId = textBox2.Text;
            f.departmentName = textBox3.Text;
            f.courseTaught = textBox4.Text;
            faculty.Add(f);
            MessageBox.Show("Faculty Added Successfully!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Faculty f = faculty.FirstOrDefault(x => x.Name == textBox5.Text && x.facultyId == textBox6.Text && x.departmentName == textBox7.Text && x.courseTaught == textBox8.Text);
            if (f != null)
            {
                faculty.Remove(f);
                MessageBox.Show("Faculty Removed Successfully!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Faculty not found!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IIterator iterator = new FacultyIterator(faculty);
            richTextBox1.Text = ""; // Clear the text before displaying the courses
            while (iterator.HasNext())
            {
                Faculty faculty = (Faculty)iterator.Next();
                richTextBox1.Text += "Faculty Name: " + faculty.Name + "\n" + "Faculty Id: " + faculty.facultyId + "\n" + "Department Name: " + faculty.departmentName + "\n" + "Course Assigned: " + faculty.courseTaught + "\n\n"; // Concatenate the name of each course with a newline character
            }
        }
    }
}
