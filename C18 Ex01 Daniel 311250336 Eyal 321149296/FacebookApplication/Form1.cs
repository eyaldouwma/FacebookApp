using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Facebook;
using System.Xml.Serialization;

namespace FacebookApplication
{
    public partial class Form1 : Form
    {
        private User m_FacebookUser;
        private AppSettings m_Settings = new AppSettings();
        private subForm m_PreviewForm = new subForm();
        private Thread m_SubThread;

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
            buttonCreateAlbum.Enabled = i_EnableOrDisable;
            buttonDeletePost.Enabled = i_EnableOrDisable;
            buttonWhoDeletedMe.Enabled = i_EnableOrDisable;
            buttonUploadPhoto.Enabled = i_EnableOrDisable;
            pictureBoxMagnifer.Enabled = i_EnableOrDisable;
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
            List<string> NameToSave = new List<string>();
            NameToSave = extractNameFromAllFriends();
            saveToFile(NameToSave.GetType(), @"C:\temp\LastFriendList.xml", FileMode.Truncate, NameToSave);
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

        private void saveToFile(Type i_TypeToSave, string i_Location, FileMode i_FileModeIfExists, object i_Instance)
        {
            if (File.Exists(i_Location))
            {
                createXML(i_TypeToSave, i_Location, i_FileModeIfExists, i_Instance);
            }
            else
            {
                createXML(i_TypeToSave, i_Location,FileMode.Create, i_Instance);
            }
        }

        private void createXML(Type i_TypeToSave, string i_Location, FileMode i_Mode, object i_Instance)
        {
            using (Stream stream = new FileStream(i_Location, i_Mode))
            {
                XmlSerializer serializer = new XmlSerializer(i_TypeToSave);
                serializer.Serialize(stream, i_Instance);
            }
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

            friend.ReFetch();
            if (friend != null)
            {
                listBoxFriendPosts.Items.Clear();
                foreach (Post posts in friend.Posts)
                {
                    listBoxFriendPosts.Items.Add(string.Format("From: {0}        Post: {1}",
                        posts.From == null ? friend.Name : posts.From.Name,
                        posts.Message));
                }
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_FacebookUser.ReFetch();
            listBoxMyPosts.Items.Clear();

            foreach(Post posts in m_FacebookUser.Posts)
            {
                if (posts.Message != null)
                {
                    listBoxMyPosts.Items.Add(string.Format("From: {0}        Post: {1}",
                        posts.From == null ? m_FacebookUser.Name : posts.From.Name,
                        posts.Message));
                }
            }
        }

        private void buttonShareMyPost_Click(object sender, EventArgs e)
        {
            try
            {
                m_FacebookUser.PostStatus(textBoxPost.Text);
            }
            catch (FacebookOAuthException ex)
            {
                MessageBox.Show("Facebook doesn't allow posting from the app.");
            }
            finally
            {
                textBoxPost.Text = string.Empty;
            }
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
            if (listBoxPhoto.SelectedItem != null)
            {
                pictureBoxPhoto.ImageLocation = (listBoxPhoto.SelectedItem as Photo).PictureNormalURL;
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                labelPhotoDescription.Text = (listBoxPhoto.SelectedItem as Photo).Message;
            }
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

        private void showPreviewForm(object i_PictureURL)
        {
            m_PreviewForm.InitializeSubForm(i_PictureURL as string);
            try
            {
                m_PreviewForm.StartPosition = FormStartPosition.Manual;
                m_PreviewForm.Location = new Point(this.Right + 10, this.Location.Y);
                m_PreviewForm.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                m_PreviewForm.InitializeSubForm(i_PictureURL as string);
            }
        }

        private void startPreviewFormThread(string i_PhotoURL)
        {
            if (m_SubThread == null || !m_SubThread.IsAlive)
            {
                m_SubThread = new Thread(new ParameterizedThreadStart(showPreviewForm));
                m_SubThread.Start(i_PhotoURL);
            }
            else
            {
                m_PreviewForm.InitializeSubForm(i_PhotoURL);
            }
        }

        private void pictureBoxMagnifer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pictureBoxPhoto.ImageLocation))
            {
                startPreviewFormThread(pictureBoxPhoto.ImageLocation);
            }
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            string inputAlbumName = Microsoft.VisualBasic.Interaction.InputBox("Please enter a name for the album: ");
            try
            {
                m_FacebookUser.CreateAlbum(inputAlbumName);
            }
            catch (FacebookOAuthException ex)
            {
                MessageBox.Show("Facebook doesn't allow creating albums from the app.");
            }
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAlbums.SelectedItem != null)
                {
                    var FD = new OpenFileDialog();
                    FD.Filter = "Image Files(*.JPG)| *.JPG";
                    if (FD.ShowDialog() == DialogResult.OK)
                    {
                        (listBoxAlbums.SelectedItem as Album).UploadPhoto(FD.FileName);
                    }
                }
            }
            catch (FacebookOAuthException ex)
            {
                MessageBox.Show("Facebook prevents uploading photos from the app.");
            }
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            if (listBoxMyPosts.SelectedItem != null)
            {
                m_FacebookUser.Posts[listBoxMyPosts.SelectedIndex].Delete();
            }
            else
            {
                MessageBox.Show("Please select a post to delete.");
            }

            buttonFetchPosts_Click(null, null);
        }

        private void buttonWhoDeletedMe_Click(object sender, EventArgs e)
        {
            List<string> names = null;
            List<string> deletedMe = new List<string>();
            List<string> friendId = extractNameFromAllFriends();

            try
            {
                using (Stream stream = new FileStream(@"C:\temp\LastFriendList.xml", FileMode.Open))
                {
                    XmlSerializer serlizer = new XmlSerializer(typeof(List<string>));

                    names = serlizer.Deserialize(stream) as List<string>;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot preform this action.{0}File maybe be corrupted.", Environment.NewLine));
                return;
            }

            foreach (string nameFromXML in names)
            {
                if (!friendId.Contains(nameFromXML))
                {
                    deletedMe.Add(nameFromXML);
                }
               
            }

            if (deletedMe.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                foreach(string name in deletedMe)
                {
                    builder.AppendLine(name);
                }
                MessageBox.Show(string.Format("The Friends Who Deleted Me: {0}{1}", System.Environment.NewLine, builder.ToString()));
            }
            else
            {
                MessageBox.Show("None");
            }

        }

        private List<string> extractNameFromAllFriends()
        {
            List<string> extractedNames = new List<string>();

            foreach(User user in m_FacebookUser.Friends)
            {
                extractedNames.Add(user.Name);
            }

            return extractedNames;
        }

        private void listBoxFriends_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxFriendPosts.Items.Clear();
        }

        private void listBoxFriendPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;

            if (!string.IsNullOrEmpty(friend.Posts[listBoxFriendPosts.SelectedIndex].PictureURL))
            {
                startPreviewFormThread(friend.Posts[listBoxFriendPosts.SelectedIndex].PictureURL);
            }
        }
    }
}
