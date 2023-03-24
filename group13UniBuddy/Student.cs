using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace group13UniBuddy
{
    public class Student:IStudent
    {
        string Name { get; set; }
        int Age { get; set; }
        string Category { get; set; }
        string Program { get; set; }
        string StudentNo { get; set; }

        string departmentName { get; set; }

        public List<Student> student { get; set; }

        public Student(string Name,int Age,string Category,string Program,string StudentNo,string departmentName)
        {
            this.Name= Name;
            this.Age= Age;
            this.Category= Category;
            this.Program= Program;
            this.StudentNo= StudentNo;
            this.departmentName= departmentName;
            this.student = new List<Student>();
        }

        public void addStudent(Student std)
        {
            student.Add(std);
        }

        public void removeStudent(Student std)
        {
            student.Remove(std);
        }
    }
   
       
    
}



