using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public interface IDepartment
    {
        void addDepartment(Department department);

        void removeDepartment(Department department);

        void studentInTheDepartment(string departmentName, List<Student> student);

        void facultyInTheDepartment(string departmentName, List<Faculty> faculty);
    }
}
