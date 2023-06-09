﻿using System;
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
    public partial class studentLogincs : Form
    {
        public studentLogincs()
        {
            InitializeComponent();
        }

        private void studentLogincs_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the path to the file
            string filePath = "studentCredentials.txt";

            // Ask the user for their ID and password
            
            string userId = textBox1.Text;
            
            string password = textBox2.Text;

            // Read the file line by line and check for a matching ID and password
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    string storedId = fields[0];
                    string storedPassword = fields[1];
                    if (userId == storedId && password == storedPassword)
                    {
                        MessageBox.Show("Login Successful!");
                        studentPage studentPage = new studentPage();
                        studentPage.Show();
                        return;
                    }
                }
            }

            // If a matching ID and password were not found, display an error message
            MessageBox.Show("Invalid user ID or password.");
            



        }
    }
}
