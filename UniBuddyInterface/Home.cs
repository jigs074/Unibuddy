using System;
using System.IO;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentLogincs studentlogin = new studentLogincs();
            studentlogin.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            facultyLogin flogin = new facultyLogin();
            flogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            departmentLog dlog = new departmentLog();
            dlog.Show();
        }
    }
}
