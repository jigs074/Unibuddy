using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Department:Student
    {
        Student s; 

        string getDepartment(string studentNo)
        {
            s.StudentNo = studentNo;
            return s.DepartmentName; 
            

        }

    }
}
