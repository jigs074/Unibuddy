using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Registrar:Student,Faculty,Courses 
    {
        Student S;
        Faculty F; 
        double tutionFees; 
        public double calculateFees(string category , string department)
        {
            category = S.Category;
            department = S.DepartmentName;

           


        }
    }
}
