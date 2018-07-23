using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class subForm : Form
    {
        public subForm()
        {
            InitializeComponent();
        }

        public void InitializeSubForm(string i_Photo)
        {
            pictureBoxPostPhoto.ImageLocation = i_Photo;
            pictureBoxPostPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
