using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Courses:ICourse
    {
        public string Name { get; set; }
       public List<Courses> courses { get; set; }

        public Courses()
        {

        }
        public Courses(string Name)
        {
            courses = new List<Courses>();
            this.Name = Name;
        }

        public IIterator CreateIterator()
        {
            return new CoursesIterator(courses);
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
    public class CoursesIterator : IIterator
    {
        private List<Courses> courses;

        private int position = -1;

        public CoursesIterator(List<Courses> courses)
        {
            this.courses = courses;

        }

        public bool HasNext()
        {
            return position < courses.Count - 1;
        }

        public object Next()
        {
            position++;
            return courses[position];
        }
    }
}
