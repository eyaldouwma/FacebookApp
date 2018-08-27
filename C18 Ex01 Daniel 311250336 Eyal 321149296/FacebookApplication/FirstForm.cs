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
        private const bool v_Enable = true;
        private AppSettings m_Settings;
        private subFormEasyMode m_EasyModeForm; 
        private Form1 m_RegularModeForm = Form1.getInstance();
        private Thread m_RegularModeThread = null;
        private Thread m_EasyModeThread = null;
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
            m_EasyModeForm = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.EasyMode) as subFormEasyMode;
            m_EasyModeForm.Closing += subFormClosed;
            m_EasyModeThread = new Thread(() => m_EasyModeForm.ShowDialog());
            m_EasyModeThread.SetApartmentState(ApartmentState.STA);
            m_EasyModeThread.Start();

            enableDisableAllModes(!v_Enable);
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

        private void enableDisableAllModes(bool i_EnableDisable)
        {
            buttonEasyMode.Enabled = i_EnableDisable;
            buttonRegularMode.Enabled = i_EnableDisable;
        }

        private void buttonRegularMode_Click(object sender, EventArgs e)
        {
            m_RegularModeForm.Closing += subFormClosed;
            m_RegularModeThread = new Thread(() => m_RegularModeForm.ShowDialog());
            m_RegularModeThread.SetApartmentState(ApartmentState.STA);
            m_RegularModeThread.Start();

            enableDisableAllModes(!v_Enable);
        }

        private void subFormClosed(object i_Sender, EventArgs i_E)
        {
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
