﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Admin
    {
        private int i = 0;
        public string ID = "Admin";
        public string password = "123456";

        public void giveAccess()
        {
            for(i = 0;i<3;i++)
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                string pass = Console.ReadLine();

                if(ID==id && password == pass)
                {
                    Console.WriteLine("Admin Access Granted!");
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

    
