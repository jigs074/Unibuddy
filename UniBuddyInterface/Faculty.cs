using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{

    public class Faculty:IFaculty
    {
        public string Name { get; set; }
        
        public string facultyId { get; set; }

        public string departmentName { get; set; }

        public List<Faculty> faculty { get; set; }

        public string courseTaught { get; set; }
        public Faculty()
        {

        }
        public IIterator CreateIterator()
        {
            return new FacultyIterator(faculty);
        }
        public Faculty(string name,string facId,string departmentName,string courseTaught)
        {
            this.Name = name;
            this.facultyId = facId;
            this.courseTaught = courseTaught;
            this.departmentName = departmentName;
            this.faculty = new List<Faculty>();
            

        }

        public void addFaculty(Faculty fac)
        {
            faculty.Add(fac);
        }

        public void removeFaculty(Faculty fac)
        {
            faculty.Remove(fac);
        }


    }

    public class FacultyIterator : IIterator
    {
        private List<Faculty> faculty;

        private int position = -1;

        public FacultyIterator(List<Faculty> faculty)
        {
            this.faculty = faculty; 

        }

        public bool HasNext()
        {
            return position < faculty.Count - 1;
        }

        public object Next()
        {
            position++;
            return faculty[position];
        }
    }
}


