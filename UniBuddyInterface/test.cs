using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public class test
    {
        private int i = 0;
        public string ID = "Admin";
        public string password = "Admin";

        public void giveAccess()
        {
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                string pass = Console.ReadLine();

                if (ID == id && password == pass)
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
