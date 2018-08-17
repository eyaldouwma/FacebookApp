using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FacebookApplication
{
    public partial class FirstForm : Form
    {

        private User m_FacebookUser;

        public FirstForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login(
                "250350445570281",
                "email",
                "user_posts",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_events",
                "user_birthday",
                "user_hometown",
                "user_tagged_places",
                "publish_to_groups",
                "publish_pages",
                "manage_pages",
                "groups_access_member_info",
                "pages_show_list");

            Form1.getInstance().m_FacebookUser = result.LoggedInUser;
            buttonEasyMode.Enabled = true;
            buttonRegularMode.Enabled = true;
        }

        private void buttonEasyMode_Click(object sender, EventArgs e)
        {
            subFormEasyMode easyMode = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.EasyMode) as subFormEasyMode;
            var t = new Thread(() => easyMode.ShowDialog());
            t.Start();
            this.Close();
        }

        private void buttonRegularMode_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Form1.getInstance().ShowDialog());
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Close();
        }
    }
}
