using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    static class SubFormFactory
    {
        public enum SubFormTypes
        {
            EasyMode,
            Picture,
            Login
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
                createdForm = new subFormPicture();
            }
            else if (i_SubFormType == SubFormTypes.Login)
            {
                createdForm = new FirstForm();
            }

            return createdForm;
        }
    }
}
