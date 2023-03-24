using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{

    public class Faculty
    {
        string Name { get; set; }

        public List<Course> Courses { get; set; }

        public Faculty(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
    }
    public class FacultyList:IEnumerable<Faculty>
    {

        private List<Faculty> faculty = new List<Faculty>();

       public void Add(Faculty fac)
        {
            faculty.Add(fac);
        }

        public void Remove(Faculty fac)
        {
            faculty.Remove(fac);
        }

        

        public IEnumerator<Faculty> GetEnumerator()
        {
            return faculty.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

public class Course
{
    public string Name { get; set; }
   

    public Course(string name)
    {
        Name = name;
    }
}
