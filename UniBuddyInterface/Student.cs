using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace UniBuddyInterface
{
    public class Student:IStudent,IAggregate
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Category { get; set; }
        public string Program { get; set; }
       public string StudentNo { get; set; }

        public string departmentName { get; set; }

        public List<Student> student { get; set; }

        public Student()
        {

        }
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

        public IIterator CreateIterator()
        {
            return new StudentIterator(student);
        }

    }
    public class StudentIterator : IIterator
    {
        private List<Student> student;
        private int position = -1;

        public StudentIterator(List<Student> student)
        {
            this.student = student;
        }

        public bool HasNext()
        {
            return position < student.Count - 1;
        }

        public object Next()
        {
            position++;
            return student[position];
        }
    }



}



