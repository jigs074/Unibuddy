using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Courses:ICourse
    {
        string Name { get; set; }
       public List<Courses> courses { get; set; }

        public Courses(string Name)
        {
            courses = new List<Courses>();
            this.Name = Name;
        }

        public void addCourse(Courses course)
        {
            courses.Add(course);
        }

        public void removeCourse(Courses course)
        {
            courses.Remove(course);
        }
    }
}
