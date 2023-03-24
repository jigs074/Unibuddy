using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{

    public class Faculty:IFaculty
    {
        string Name { get; set; }
        
        int facultyId { get; set; }

        string departmentName { get; set; }

        public List<Faculty> faculty { get; set; }

        public List<Courses> coursesTaught { get; set; }

        public Faculty(string name,int facId,string departmentName)
        {
            this.Name = name;
            this.facultyId = facId;
            this.departmentName = departmentName;
            this.faculty = new List<Faculty>();
            this.coursesTaught = new List<Courses>();
        }

        public void addFaculty(Faculty fac)
        {
            faculty.Add(fac);
        }

        public void removeFaculty(Faculty fac)
        {
            faculty.Remove(fac);
        }

        public void addCourse(Courses course)
        {
            coursesTaught.Add(course);
        }

        public void removeCourse(Courses course)
        {
            coursesTaught.Remove(course);
        }

    }

}


