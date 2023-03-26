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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            string idInput = textBox1.Text;
            string passwordInput = textBox2.Text;
            string actualId = admin.verifyId();
            string actualPassword = admin.verifyPassword();

            if(idInput == actualId && passwordInput == actualPassword)
            {
                MessageBox.Show("Logged In!");

            }
            else
            {
                MessageBox.Show("Invalid Credentials!");

            }
            Home home = new Home();
            home.Show();


        }
    }
}
