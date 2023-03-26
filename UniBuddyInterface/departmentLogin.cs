using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public class departmentLogin
    {
        private int i = 0;
        public string ID = "Department";
        public string password = "123456";

        public string verifyId()
        {
            return ID;
        }

        public string verifyPassword()
        {
            return password;
        }
    }
}
