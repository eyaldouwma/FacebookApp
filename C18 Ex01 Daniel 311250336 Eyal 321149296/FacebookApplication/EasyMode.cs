using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FacebookApplication
{
    class EasyMode : FirstForm, IMode
    {
        public void showForm()
        {
            m_EasyModeForm = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.EasyMode) as subFormEasyMode;
            m_EasyModeForm.Closing += subFormClosed;
            m_EasyModeThread = new Thread(() => m_EasyModeForm.ShowDialog());
            m_EasyModeThread.SetApartmentState(ApartmentState.STA);
            m_EasyModeThread.Start();

            enableDisableAllModes(!v_Enable);
        }
    }
}
