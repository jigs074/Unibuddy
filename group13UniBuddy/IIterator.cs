using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
