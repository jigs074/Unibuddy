using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public interface ICourse
    {

        void addCourse(Courses course);

        void removeCourse(Courses course);
    }
}
