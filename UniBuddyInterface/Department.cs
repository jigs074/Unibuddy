using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public class Department:IDepartment
    {
         public string departmentName { get; set; }

        public List<Department> dept { get; set; }

        public Department() { }
        public Department(string deptName)
        {
            dept = new List<Department>();
            this.departmentName =deptName;
        }

        public IIterator CreateIterator()
        {
            return new DepartmentIterator(dept);
        }

        public void addDepartment(Department department)
        {
            dept.Add(department);
        }

        public void removeDepartment(Department department)
        {
            dept.Remove(department);
        }

        public void studentInTheDepartment(string departmentName, List<Student> student)
        {
            foreach(Student std in student)
            {
                if(std.departmentName == departmentName)
                {
                    Console.WriteLine("Student:" + std.Name + "\nDepartment: " + std.departmentName);
                }
            }
        }

        public void facultyInTheDepartment(string departmentName, List<Faculty> faculty)
        {
            foreach (Faculty fac in faculty)
            {
                if (fac.departmentName == departmentName)
                {
                    Console.WriteLine("Faculty:" + fac.Name + "\nDepartment: " + fac.departmentName);
                }
            }
        }
    }

    public class DepartmentIterator : IIterator
    {
        private List<Department> dept;

        private int position = -1;

        public DepartmentIterator(List<Department> dept)
        {
            this.dept = dept;

        }

        public bool HasNext()
        {
            return position < dept.Count - 1;
        }

        public object Next()
        {
            position++;
            return dept[position];
        }
    }
}
