using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace FacebookApplication
{
    public partial class Form1 : Form
    {
        private User m_FacebookUser;
        private AppSettings m_Settings = new AppSettings();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login("250350445570281",
                "email",
                "user_posts",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_events",
                "user_birthday",
                "user_hometown",
                "user_tagged_places");

            m_Settings.AccessToken = result.AccessToken;
            m_FacebookUser = result.LoggedInUser;
            populateUI();
        }

        private void populateUI()
        {
            pictureBoxProfilePic.ImageLocation = m_FacebookUser.PictureNormalURL;
            pictureBoxProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = string.Format("Logged In as {0}", m_FacebookUser.Name);
            labelUserDetails.Text = string.Format(@"{0}
{1}
{2}", m_FacebookUser.Name, m_FacebookUser.Birthday, m_FacebookUser.Email);
            buttonLoginLogout.Click -= buttonLogin_Click;
            buttonLoginLogout.Text = "Logout";
            buttonLoginLogout.Click += buttonLogout_Click;
            changeButtonsEnabled(true);
            fetchAlbums();
        }

        private void changeButtonsEnabled(bool i_EnableOrDisable)
        {
            buttonRefreshAlbums.Enabled = i_EnableOrDisable;
            buttonShareMyPost.Enabled = i_EnableOrDisable;
            buttonFetchPosts.Enabled = i_EnableOrDisable;
            buttonFetchAllEvents.Enabled = i_EnableOrDisable;
            buttonFetchFriends.Enabled = i_EnableOrDisable;
            buttonFetchLikedPages.Enabled = i_EnableOrDisable;
            dateTimePickerEventsPicker.Enabled = i_EnableOrDisable;
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (Album albums in m_FacebookUser.Albums)
            {
                listBoxAlbums.Items.Add(albums);
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User user in m_FacebookUser.Friends)
            {
                listBoxFriends.Items.Add(user);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(Logout_Success);
        }

        private void Logout_Success()
        {
            this.Text = "Logged Out";
            pictureBoxProfilePic.ImageLocation = null;
            labelUserDetails.Text = string.Empty;
            buttonLoginLogout.Click += buttonLogin_Click;
            buttonLoginLogout.Text = "Login";
            buttonLoginLogout.Click -= buttonLogout_Click;
            listBoxAlbums.Items.Clear();
            listBoxPhoto.Items.Clear();
            listBoxFriendPosts.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
            listBoxMyEvents.Items.Clear();
            listBoxMyPosts.Items.Clear();
            pictureBoxPhoto.ImageLocation = null;
            textBoxPost.Text = string.Empty;
            changeButtonsEnabled(false);
            buttonFetchFriendPosts.Enabled = false; //has an irregular behavior compared to other buttons so it's not included in the enable/disable method.
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_Settings.RememberMe = checkBoxRememberMe.Checked;
            m_Settings.WindowSize = this.Size;
            m_Settings.WindowLocation = this.Location;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Settings.SaveToFile();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            m_Settings = AppSettings.LoadFromFile();

            if(m_Settings.RememberMe && !string.IsNullOrEmpty(m_Settings.AccessToken))
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Size = m_Settings.WindowSize;
                this.Location = m_Settings.WindowLocation;
                LoginResult result = FacebookService.Connect(m_Settings.AccessToken);
                m_FacebookUser = result.LoggedInUser;
                checkBoxRememberMe.Checked = true;
                populateUI();
            }
        }

        private void buttonFetchFriendPosts_Click(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;

            if (friend != null)
            {
                listBoxFriendPosts.Items.Clear();
                listBoxFriendPosts.DisplayMember = "Message";

                foreach (Post posts in friend.Posts)
                {
                    listBoxFriendPosts.Items.Add(posts);
                }
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            listBoxMyPosts.Items.Clear();

            foreach(Post posts in m_FacebookUser.Posts)
            {
                if (posts.Message != null)
                {
                    listBoxMyPosts.Items.Add(posts.Message);
                }
            }
        }

        private void buttonShareMyPost_Click(object sender, EventArgs e)
        {
            m_FacebookUser.PostStatus(textBoxPost.Text);
            textBoxPost.Text = string.Empty;
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
            buttonFetchFriendPosts.Enabled = true;
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";
            try
            {
                foreach (Page page in m_FacebookUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (FacebookOAuthException ex)
            {
                listBoxLikedPages.DisplayMember = ToString();
                listBoxLikedPages.Items.Add("Facebook doesn't allow fetching liked pages.");
            }
        }

        private void dateTimePickerEventsPicker_ValueChanged(object sender, EventArgs e)
        {
            fetchEvents(dateTimePickerEventsPicker.Value);
        }

        private void buttonFetchAllEvents_Click(object sender, EventArgs e)
        {
            fetchEvents(DateTime.MinValue);
        }

        private void fetchEvents(DateTime i_DateForEvents)
        {
            listBoxMyEvents.Items.Clear();
            listBoxMyEvents.DisplayMember = "Name";

            try
            {
                foreach (Event userEvent in m_FacebookUser.Events)
                {
                    if (i_DateForEvents != DateTime.MinValue)
                    {
                        if (userEvent.StartTime == i_DateForEvents)
                        {
                            listBoxMyEvents.Items.Add(userEvent);
                        }
                    }
                    else
                    {
                        listBoxMyEvents.Items.Add(userEvent);
                    }
                }
            }
            catch (FacebookOAuthException ex)
            {
                listBoxMyEvents.DisplayMember = ToString();
                listBoxMyEvents.Items.Add("Facebook doesn't allow fetching events.");
            }
        }

        private void buttonRefreshAlbums_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void listBoxPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPhoto.ImageLocation = (listBoxPhoto.SelectedItem as Photo).PictureNormalURL;
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            labelPhotoDescription.Text = (listBoxPhoto.SelectedItem as Photo).Message;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPhoto.Items.Clear();
            listBoxPhoto.DisplayMember = "Name";

            foreach (Photo photo in (listBoxAlbums.SelectedItem as Album).Photos)
            {
                listBoxPhoto.Items.Add(photo);
            }
        }
    }
}
