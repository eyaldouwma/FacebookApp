﻿using System;
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
    public partial class subFormPicture : Form
    {
        public subFormPicture()
        {
            InitializeComponent();
        }

        public void InitializeSubForm(string i_Photo)
        {
            pictureBoxPostPhoto.ImageLocation = i_Photo;
            pictureBoxPostPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() => this.WindowState = FormWindowState.Minimized));
                this.Invoke(new Action(() => this.Show()));
                this.Invoke(new Action(() => this.WindowState = FormWindowState.Normal));
            }
        }

        private void subForm_Activated(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
