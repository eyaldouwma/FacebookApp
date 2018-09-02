using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FacebookApplication
{
    class RegularMode : FirstForm, IMode
    {
        public void showForm()
        {
            m_RegularModeForm.Closing += subFormClosed;
            m_RegularModeThread = new Thread(() => m_RegularModeForm.ShowDialog());
            m_RegularModeThread.SetApartmentState(ApartmentState.STA);
            m_RegularModeThread.Start();

            enableDisableAllModes(!v_Enable);
        }
    }
}
