using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public interface IDepartment
    {
        public void addDepartment(Department department);

        public void removeDepartment(Department department);

        public void studentInTheDepartment(string departmentName, List<Student> student);

        public void facultyInTheDepartment(string departmentName, List<Faculty> faculty);
    }
}
