using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    class SubFormFactory
    {
        public enum SubFormTypes
        {
            EasyMode,
            Picture
        }

        public static Form CreateForm(SubFormTypes i_SubFormType)
        {
            Form createdForm = null;

            if (i_SubFormType == SubFormTypes.EasyMode)
            {
                createdForm = new subFormEasyMode();
            }
            else if (i_SubFormType == SubFormTypes.Picture)
            {

            }

        return createdForm;
        }
    }
}
