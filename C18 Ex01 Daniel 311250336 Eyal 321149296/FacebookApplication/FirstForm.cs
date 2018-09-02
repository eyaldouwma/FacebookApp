using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class FirstForm : Form
    {
        protected const bool v_Enable = true;
        private AppSettings m_Settings;
        protected subFormEasyMode m_EasyModeForm; 
        protected Form1 m_RegularModeForm = Form1.getInstance();
        protected Thread m_RegularModeThread = null;
        protected Thread m_EasyModeThread = null;
        private IMode m_Mode = null;
        private bool m_LoggedIn = false;

        private bool LoggedIn
        {
            get { return m_LoggedIn; }
            set
            {
                m_LoggedIn = value;
                enableDisableAllModes(value);
            }
        }

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
            LoggedIn = true;
            changeLoginToLogout();
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_Settings.RememberMe = checkBoxRememberMe.Checked;
        }

        private void buttonEasyMode_Click(object sender, EventArgs e)
        {
            m_Mode = new EasyMode();

            m_Mode.showForm();
        }

        private void changeLoginToLogout()
        {
            buttonLogin.Click -= buttonLogin_Click;
            buttonLogin.Text = "Logout";
            buttonLogin.Click += logOutMethod;
        }

        private void logOutMethod(object sender, EventArgs e)
        {
            if (m_RegularModeThread != null && m_RegularModeThread.IsAlive)
            {
                m_RegularModeForm.Invoke(new Action(() => m_RegularModeForm.Close()));
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
            LoggedIn = false;
            buttonLogin.Click -= logOutMethod;
            buttonLogin.Click += buttonLogin_Click;
        }

        protected void enableDisableAllModes(bool i_EnableDisable)
        {
            buttonEasyMode.Enabled = i_EnableDisable;
            buttonRegularMode.Enabled = i_EnableDisable;
        }

        private void buttonRegularMode_Click(object sender, EventArgs e)
        {
            m_Mode = new RegularMode();

            m_Mode.showForm();
        }

        protected void subFormClosed(object i_Sender, EventArgs i_E)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            this.Invoke(new Action(() => enableDisableAllModes(v_Enable)));
            (i_Sender as Form).Closing -= subFormClosed;
        }

        private void FirstForm_Shown(object sender, EventArgs e)
        {
            m_Settings = AppSettings.LoadFromFile();
            m_RegularModeForm.Settings = m_Settings;
            if (m_Settings.RememberMe && !string.IsNullOrEmpty(m_Settings.AccessToken))
            {
                LoginResult result = FacebookService.Connect(m_Settings.AccessToken);
                Form1.getInstance().m_FacebookUser = result.LoggedInUser;
                checkBoxRememberMe.Checked = m_Settings.RememberMe;
                LoggedIn = true;
                changeLoginToLogout();
            }
        }

        private void FirstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Settings.SaveToFile();
        }
    }
}
