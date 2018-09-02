using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    public class NotifierButton : Button, ISubject
    {
        private List<IObserver> m_Observer = new List<IObserver>();

        public void attach(IObserver i_NewObserver)
        {
            m_Observer.Add(i_NewObserver);
        }

        public void detach(IObserver i_RemoveObserver)
        {
            m_Observer.Remove(i_RemoveObserver);
        }

        public void notify()
        {
            foreach (IObserver observer in m_Observer)
            {
                observer.update(this.Text);
            }
        }
    }
}
