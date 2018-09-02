using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public interface ISubject
    {
        void attach(IObserver i_NewObserver);
        void detach(IObserver i_RemoveObserver);
        void notify();
    }
}
