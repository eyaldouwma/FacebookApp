﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApplication.Properties;

namespace FacebookApplication
{
    public sealed partial class Form1 : Form
    {
        private static Form1 m_TheInstance = null;
        public User m_FacebookUser { get; set; }
        private AppSettings m_Settings = new AppSettings();
        private subFormEasyMode m_EasyMode;
        private subFormPicture m_PreviewForm = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.Picture) as subFormPicture;
        private Thread m_SubPictureThread;
       
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 getInstance()
        {
            if (m_TheInstance == null)
            {
                m_TheInstance = new Form1();
            }

            return m_TheInstance;
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

            m_Settings.AccessToken = result.AccessToken;
            m_FacebookUser = result.LoggedInUser;
            populateUI();
        }

        private void populateUI()
        {
            userBindingSource.DataSource = m_FacebookUser;
            this.Text = string.Format("Logged In as {0}", m_FacebookUser.Name);
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
            buttonFriendsCloseCircle.Enabled = i_EnableOrDisable;
            enableOrDisableRightClick(contextMenuStripRightClickFriend, i_EnableOrDisable);
        }

        private void enableOrDisableRightClick(ContextMenuStrip i_ContextMenuStripRightClickFriend, bool i_EnableOrDisable)
        {
            i_ContextMenuStripRightClickFriend.Enabled = i_EnableOrDisable;
            foreach (ToolStripMenuItem item in i_ContextMenuStripRightClickFriend.Items)
            {
                item.Enabled = i_EnableOrDisable;
            }
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

        public void FetchFriends(ListBox i_FriendList)
        {
            i_FriendList.Items.Clear();
            i_FriendList.DisplayMember = "Name";

            foreach (User user in m_FacebookUser.Friends)
            {
                i_FriendList.Items.Add(user);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            saveFriendList();
            FacebookService.Logout(Logout_Success);
        }

        private void Logout_Success()
        {
            imageSquarePictureBox.Image = null;
            nameLabel1.Text = string.Empty;
            emailLabel1.Text = string.Empty;
            birthdayLabel1.Text = string.Empty;
            this.Text = "Logged Out";
            listBoxAlbums.Items.Clear();
            listBoxPhoto.Items.Clear();
            listBoxFriendPosts.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
            listBoxMyEvents.Items.Clear();
            listBoxMyPosts.Items.Clear();
            listBoxCloseFriendsCircle.Items.Clear();
            listBoxWhoDeletedMe.Items.Clear();
            labelCloseCircleOfFriendsCount.Text = string.Empty;
            pictureBoxPhoto.ImageLocation = null;
            textBoxPost.Text = string.Empty;
            changeButtonsEnabled(false);

            // the below has an irregular behavior compared to other buttons so it's not included in the enable/disable method.
            buttonFetchFriendPosts.Enabled = false; 
            pictureBoxLike.Enabled = false;
        }

        private void saveFriendList()
        {
            List<string> NameToSave = new List<string>();
            NameToSave = extractNameFromAllFriends();
            saveToFile(
                NameToSave.GetType(),
                string.Format(@"C:\temp\LastFriendList{0}.xml", m_FacebookUser.Id),
                    FileMode.Truncate,
                    NameToSave);
        }

        private void saveToFile(Type i_TypeToSave, string i_Location, FileMode i_FileModeIfExists, object i_Instance)
        {
            if (File.Exists(i_Location))
            {
                createXML(i_TypeToSave, i_Location, i_FileModeIfExists, i_Instance);
            }
            else
            {
                createXML(i_TypeToSave, i_Location, FileMode.Create, i_Instance);
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

        //private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        //{
        //    m_Settings.RememberMe = checkBoxRememberMe.Checked;
        //    m_Settings.WindowSize = this.Size;
        //    m_Settings.WindowLocation = this.Location;
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_FacebookUser != null)
            {
                saveFriendList();
                m_Settings.SaveToFile();
            }

            if (m_SubPictureThread != null && m_SubPictureThread.IsAlive)
            {
                m_SubPictureThread.Abort();
            }

            Logout_Success();
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
                populateUI();
            }
        }

        private void buttonFetchFriendPosts_Click(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;

            if (friend != null)
            {
                Refresh();
                listBoxFriendPosts.Items.Clear();
                foreach (Post posts in friend.Posts)
                {
                    listBoxFriendPosts.Items.Add(string.Format(
                        "From: {0}        Post: {1}",
                        posts.From == null ? friend.Name : posts.From.Name,
                        posts.Message));
                }
            }

            pictureBoxLike.Enabled = false;
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            Refresh();
            FetchMyPosts(listBoxMyPosts);
        }

        public void FetchMyPosts(ListBox i_listBoxMyPosts)
        {
            i_listBoxMyPosts.Items.Clear();

            foreach (Post posts in m_FacebookUser.Posts)
            {
                if (posts.Message != null)
                {
                    i_listBoxMyPosts.Items.Add(string.Format(
                        "From: {0}        Post: {1}",
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
            FetchFriends(listBoxFriends);
            buttonFetchFriendPosts.Enabled = true;
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            Refresh();
            FetchLikedPages(listBoxLikedPages);
        }

        public void FetchLikedPages(ListBox i_listBoxLikedPages)
        {
            i_listBoxLikedPages.Items.Clear();
            i_listBoxLikedPages.DisplayMember = "Name";
            try
            {
                if (m_FacebookUser.LikedPages.Count == 0)
                {
                    i_listBoxLikedPages.Items.Add("none");
                }
                else
                {
                    foreach (Page page in m_FacebookUser.LikedPages)
                    {
                        i_listBoxLikedPages.Items.Add(page);
                    }
                }
            }
            catch (FacebookOAuthException ex)
            {
                i_listBoxLikedPages.DisplayMember = ToString();
                i_listBoxLikedPages.Items.Add("Facebook doesn't allow fetching liked pages.");
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
            if (m_SubPictureThread == null || !m_SubPictureThread.IsAlive)
            {
                m_SubPictureThread = new Thread(new ParameterizedThreadStart(showPreviewForm));
                m_SubPictureThread.Start(i_PhotoURL);
            }
            else
            {
                m_PreviewForm.InitializeSubForm(i_PhotoURL);
            }
        }

        private void pictureBoxMagnifier_Click(object sender, EventArgs e)
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
                using (Stream stream = new FileStream(string.Format(@"C:\temp\LastFriendList{0}.xml", m_FacebookUser.Id), FileMode.Open))
                {
                    XmlSerializer serlizer = new XmlSerializer(typeof(List<string>));

                    names = serlizer.Deserialize(stream) as List<string>;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot preform this action.{0}File missing or corrupted.", Environment.NewLine));
                return;
            }

            foreach (string nameFromXML in names)
            {
                if (!friendId.Contains(nameFromXML))
                {
                    deletedMe.Add(nameFromXML);
                }
            }

            populateWhoDeletedMeListBox(deletedMe);
        }

        private void populateWhoDeletedMeListBox(List<string> i_DeletedMe)
        {
            if (i_DeletedMe.Count != 0)
            {
                foreach (string name in i_DeletedMe)
                {
                    listBoxWhoDeletedMe.Items.Add(name);
                }
            }
            else
            {
                listBoxWhoDeletedMe.Items.Add("none");
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
            Post friendPost = friend.Posts[listBoxFriendPosts.SelectedIndex];

            if (!string.IsNullOrEmpty(friendPost.PictureURL))
            {
                startPreviewFormThread(friendPost.PictureURL);
            }

            if (friendPost.LikedBy.Contains(m_FacebookUser))
            {
                pictureBoxLike.Image = Resources.unlike;
            }
            else
            {
                pictureBoxLike.Image = Resources.like;
            }

            pictureBoxLike.Enabled = true;
        }

        private void pictureBoxLike_Click(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;
            Post postToLikeUnlike = friend.Posts[listBoxFriendPosts.SelectedIndex];

            try
            {
                if (postToLikeUnlike.LikedBy.Contains(m_FacebookUser))
                {
                    postToLikeUnlike.Unlike();
                }
                else
                {
                    postToLikeUnlike.Like();
                }
            }
            catch (FacebookOAuthException ex)
            {
                MessageBox.Show("Facebook doesn't allow liking from the app.");
            }
        }

        private void buttonFriendsCloseCircle_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> myFriendsCount = new Dictionary<string, int>(m_FacebookUser.Friends.Count);
            Dictionary<string, string> myFriendsByID = new Dictionary<string, string>();
            int maxMutualFriends = 0;
            LinkedList<string> closeCircleOfFriends;

            foreach (User friend in m_FacebookUser.Friends)
            {
                myFriendsCount.Add(friend.Id, maxMutualFriends);
                myFriendsByID.Add(friend.Id, friend.Name);
            }

            foreach (User friend in m_FacebookUser.Friends)
            {
                foreach (User friendOfFriend in friend.Friends)
                {
                    if (myFriendsCount.ContainsKey(friendOfFriend.Id))
                    {
                        myFriendsCount[friendOfFriend.Id]++;
                        maxMutualFriends = maxMutualFriends < myFriendsCount[friendOfFriend.Id]
                            ? myFriendsCount[friendOfFriend.Id]
                            : maxMutualFriends;
                    }
                }
            }

            closeCircleOfFriends = getCloseCircleOfFriend(myFriendsCount, myFriendsByID, maxMutualFriends);
            populateCloseCircleOfFriendListBox(closeCircleOfFriends);
            labelCloseCircleOfFriendsCount.Text = maxMutualFriends.ToString();
        }

        private void populateCloseCircleOfFriendListBox(LinkedList<string> i_CloseCircleOfFriends)
        {
            foreach (string name in i_CloseCircleOfFriends)
            {
                listBoxCloseFriendsCircle.Items.Add(name);
            }
        }

        private LinkedList<string> getCloseCircleOfFriend(
            Dictionary<string, int> i_FriendsCount,
            Dictionary<string, string> i_FriendsByID,
            int i_MaxMutualFriends)
        {
            LinkedList<string> closeCircleOfFriends = new LinkedList<string>();

            foreach (string id in i_FriendsCount.Keys)
            {
                if (i_FriendsCount[id] == i_MaxMutualFriends)
                {
                    closeCircleOfFriends.AddFirst(i_FriendsByID[id]);
                }
            }

            return closeCircleOfFriends;
        }

        private void profilePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                startPreviewFormThread((listBoxFriends.SelectedItem as User).PictureNormalURL);
            }
        }

        private void fetchPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonFetchFriendPosts_Click(null, null);
        }

        private void fetchFriendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FetchFriends(listBoxFriends);
        }

        private void listBoxFriends_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxFriends.SelectedIndex = listBoxFriends.IndexFromPoint(e.X, e.Y);
        }

        private void buttonEasyMode_Click(object sender, EventArgs e)
        {
            m_EasyMode = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.EasyMode) as subFormEasyMode;
            m_EasyMode.ShowDialog();
        }

        public void Refresh()
        {
            m_FacebookUser.ReFetch();
        }
    }
}
