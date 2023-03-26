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
    public partial class RecreationPage : Form
    {
        public RecreationPage()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activity footBallActivity = new Activity("Football");
            richTextBox1.Text = "Monday to friday - " +
                "Football:" + footBallActivity.ScheduledTime;
           
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activity CricketActivity = new Activity("Cricket");
            richTextBox1.Text = "Monday to friday - " +
                "Cricket:" + CricketActivity.ScheduledTime;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activity BaseballActivity = new Activity("Baseball");
            richTextBox1.Text = "Monday to friday - " +
                "Baseball:" + BaseballActivity.ScheduledTime;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Activity BasketballActivity = new Activity("BasketBall");
            richTextBox1.Text = "Monday to friday - " +
                "BasketBall:" + BasketballActivity.ScheduledTime;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Activity TennisActivity = new Activity("Tennis");
            richTextBox1.Text = "Monday to friday - " +
                "Tennis:" + TennisActivity.ScheduledTime;

        }
    }
}
