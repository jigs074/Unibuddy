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
    public partial class departmentLog : Form
    {
        public departmentLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departmentLogin departmentMember = new departmentLogin();
            string idInput = textBox1.Text;
            string passwordInput = textBox2.Text;
            string actualId = departmentMember.verifyId();
            string actualPassword = departmentMember.verifyPassword();

            if (idInput == actualId && passwordInput == actualPassword)
            {
                MessageBox.Show("Logged In!");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            departmentPage dpage = new departmentPage();
            dpage.Show();


        }
    }
}
