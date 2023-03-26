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
    public partial class ClubsPage : Form
    {
         public List<Clubs> clubList = new List<Clubs>();
        public ClubsPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clubName = textBox1.Text;
            string clubType = textBox3.Text; 

            Clubs clubs = new Clubs(clubName,clubType);
            

            clubList.Add(clubs);
            clubs.addClub(clubs); 
            MessageBox.Show("Club Added Successfully!");
            textBox1.Text = "";
            textBox3.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Clubs c = clubList.FirstOrDefault(x => x.ClubName == textBox2.Text && x.ClubType == textBox4.Text);
            if (c != null)
            {
                clubList.Remove(c);
                MessageBox.Show("Club Removed Successfully!");
                textBox1.Text = "";
                textBox3.Text = "";

            }
            else
            {
                MessageBox.Show("Club not found!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IIterator iterator = new ClubIterator(clubList); 

            richTextBox1.Text = "";
            while (iterator.HasNext())
            {
                Clubs clubs = (Clubs)iterator.Next();
                richTextBox1.Text += "Club Name: " + clubs.ClubName +  "\n" +   "Club Type: " + clubs.ClubType + "\n\n";



            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
