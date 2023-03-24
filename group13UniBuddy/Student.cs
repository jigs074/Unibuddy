using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace group13UniBuddy
{
   
       
    
        public interface Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Category { get; set; }
            public string Program { get; set; }
            public string StudentNo { get; set; }
            public string DepartmentName { get; set; }
        }

        //public class StudentList : IEnumerable<Student>
        //{
        //    private List<Student> _students = new List<Student>();

        //    public void Add(Student student)
        //    {
        //        _students.Add(student);
        //    }

        //    public IEnumerator<Student> GetEnumerator()
        //    {
        //        return _students.GetEnumerator();
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator();
        //    }
        //}
    }



