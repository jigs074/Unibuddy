using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public interface IStudent
    {
        void addStudent(Student student);

        void removeStudent(Student student);
    }
}

