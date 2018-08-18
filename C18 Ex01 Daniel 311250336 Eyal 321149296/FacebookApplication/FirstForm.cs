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

        private subFormEasyMode m_EasyModeForm;
        private Form1 m_RegularModeForm = Form1.getInstance();
        private Thread m_RegularModeThread = null;
        private Thread m_EasyModeThread = null;


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
            m_EasyModeForm = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.EasyMode) as subFormEasyMode;
            m_EasyModeThread = new Thread(() => m_EasyModeForm.ShowDialog());
            m_EasyModeThread.SetApartmentState(ApartmentState.STA);
            m_EasyModeThread.Start();


            disableAllModes();
            changeLoginToLogout();
        }

        private void changeLoginToLogout()
        {
            buttonLogin.Text = "Logout";
            buttonLogin.Click += logOutMethod;
        }

        private void logOutMethod(object sender, EventArgs e)
        {
            if (m_RegularModeThread != null && m_RegularModeThread.IsAlive)
            {
                m_RegularModeForm.Invoke(new Action(() =>m_RegularModeForm.Close()));
                m_RegularModeThread.Abort();
                m_RegularModeThread = null;
            }
            if (m_EasyModeThread != null && m_EasyModeThread.IsAlive)
            {
                m_EasyModeForm.Invoke(new Action(() => m_EasyModeForm.Close()));
                m_EasyModeThread.Abort();
                m_EasyModeThread = null;
            }

            FacebookService.Logout(logOutSuccess);
        }

        private void logOutSuccess()
        {
            buttonLogin.Text = "Login";
            disableAllModes();
            buttonLogin.Click -= logOutMethod;
            buttonLogin.Click += buttonLogin_Click;
        }

        private void disableAllModes()
        {
            buttonEasyMode.Enabled = false;
            buttonRegularMode.Enabled = false;
        }

        private void buttonRegularMode_Click(object sender, EventArgs e)
        {
            m_RegularModeThread = new Thread(() => m_RegularModeForm.ShowDialog());
            m_RegularModeThread.SetApartmentState(ApartmentState.STA);
            m_RegularModeThread.Start();

            disableAllModes();
            changeLoginToLogout();
        }
    }
}
