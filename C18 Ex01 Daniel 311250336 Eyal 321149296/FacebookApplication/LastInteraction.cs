using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    public class LastInteraction : Label, IObserver
    {
        
        public void update(string i_Interaction)
        { 
            this.Text = i_Interaction;
        }
    }
}
