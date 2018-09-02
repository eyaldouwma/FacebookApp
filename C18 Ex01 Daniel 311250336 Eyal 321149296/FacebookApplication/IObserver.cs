using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public interface IObserver
    {
        void update(string i_Interaction);
    }
}
