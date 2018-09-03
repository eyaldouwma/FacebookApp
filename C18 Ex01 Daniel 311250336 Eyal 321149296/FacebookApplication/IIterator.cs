using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public interface IIterator
    {
        object First();
        object Next();
        bool isDone();
        object getCurrent();
    }
}
