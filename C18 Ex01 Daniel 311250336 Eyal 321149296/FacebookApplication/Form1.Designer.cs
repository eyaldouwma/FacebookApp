namespace FacebookApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.labelUserDetails = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonFetchFriendPosts = new System.Windows.Forms.Button();
            this.listBoxFriendPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPageMyPosts = new System.Windows.Forms.TabPage();
            this.buttonShareMyPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxMyPosts = new System.Windows.Forms.ListBox();
            this.tabPageLikes = new System.Windows.Forms.TabPage();
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.buttonFetchAllEvents = new System.Windows.Forms.Button();
            this.listBoxMyEvents = new System.Windows.Forms.ListBox();
            this.dateTimePickerEventsPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.pictureBoxMagnifer = new System.Windows.Forms.PictureBox();
            this.labelPhotoDescription = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.listBoxPhoto = new System.Windows.Forms.ListBox();
            this.buttonRefreshAlbums = new System.Windows.Forms.Button();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.tabPageMyPosts.SuspendLayout();
            this.tabPageLikes.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(13, 21);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(103, 44);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(8, 5);
            this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(127, 115);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Location = new System.Drawing.Point(145, 2);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(0, 17);
            this.labelUserDetails.TabIndex = 2;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(13, 71);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxProfilePic);
            this.panel1.Controls.Add(this.labelUserDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 154);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLoginLogout);
            this.panel2.Controls.Add(this.checkBoxRememberMe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(768, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 154);
            this.panel2.TabIndex = 4;
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageFriends);
            this.tabControlInfo.Controls.Add(this.tabPageMyPosts);
            this.tabControlInfo.Controls.Add(this.tabPageLikes);
            this.tabControlInfo.Controls.Add(this.tabPageEvents);
            this.tabControlInfo.Controls.Add(this.tabPhotos);
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInfo.Location = new System.Drawing.Point(0, 154);
            this.tabControlInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(908, 422);
            this.tabControlInfo.TabIndex = 3;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Controls.Add(this.buttonFetchFriends);
            this.tabPageFriends.Controls.Add(this.buttonFetchFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFriends.Size = new System.Drawing.Size(900, 393);
            this.tabPageFriends.TabIndex = 0;
            this.tabPageFriends.Text = "Friends";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFetchFriends.Enabled = false;
            this.buttonFetchFriends.Location = new System.Drawing.Point(195, 49);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.MaximumSize = new System.Drawing.Size(131, 55);
            this.buttonFetchFriends.MinimumSize = new System.Drawing.Size(131, 55);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(131, 55);
            this.buttonFetchFriends.TabIndex = 3;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonFetchFriendPosts
            // 
            this.buttonFetchFriendPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchFriendPosts.Enabled = false;
            this.buttonFetchFriendPosts.Location = new System.Drawing.Point(187, 246);
            this.buttonFetchFriendPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriendPosts.MaximumSize = new System.Drawing.Size(149, 55);
            this.buttonFetchFriendPosts.MinimumSize = new System.Drawing.Size(149, 55);
            this.buttonFetchFriendPosts.Name = "buttonFetchFriendPosts";
            this.buttonFetchFriendPosts.Size = new System.Drawing.Size(149, 55);
            this.buttonFetchFriendPosts.TabIndex = 2;
            this.buttonFetchFriendPosts.Text = "Fetch Friends Posts";
            this.buttonFetchFriendPosts.UseVisualStyleBackColor = true;
            this.buttonFetchFriendPosts.Click += new System.EventHandler(this.buttonFetchFriendPosts_Click);
            // 
            // listBoxFriendPosts
            // 
            this.listBoxFriendPosts.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxFriendPosts.FormattingEnabled = true;
            this.listBoxFriendPosts.ItemHeight = 16;
            this.listBoxFriendPosts.Location = new System.Drawing.Point(370, 2);
            this.listBoxFriendPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriendPosts.Name = "listBoxFriendPosts";
            this.listBoxFriendPosts.Size = new System.Drawing.Size(527, 389);
            this.listBoxFriendPosts.TabIndex = 1;
            this.listBoxFriendPosts.SelectedValueChanged += new System.EventHandler(this.listBoxFriendPosts_SelectedValueChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 2);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(169, 389);
            this.listBoxFriends.TabIndex = 0;
            // 
            // tabPageMyPosts
            // 
            this.tabPageMyPosts.Controls.Add(this.buttonShareMyPost);
            this.tabPageMyPosts.Controls.Add(this.textBoxPost);
            this.tabPageMyPosts.Controls.Add(this.buttonFetchPosts);
            this.tabPageMyPosts.Controls.Add(this.listBoxMyPosts);
            this.tabPageMyPosts.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMyPosts.Name = "tabPageMyPosts";
            this.tabPageMyPosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMyPosts.Size = new System.Drawing.Size(900, 393);
            this.tabPageMyPosts.TabIndex = 1;
            this.tabPageMyPosts.Text = "My Posts";
            this.tabPageMyPosts.UseVisualStyleBackColor = true;
            // 
            // buttonShareMyPost
            // 
            this.buttonShareMyPost.Enabled = false;
            this.buttonShareMyPost.Location = new System.Drawing.Point(475, 249);
            this.buttonShareMyPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShareMyPost.Name = "buttonShareMyPost";
            this.buttonShareMyPost.Size = new System.Drawing.Size(131, 34);
            this.buttonShareMyPost.TabIndex = 3;
            this.buttonShareMyPost.Text = "Share My Post";
            this.buttonShareMyPost.UseVisualStyleBackColor = true;
            this.buttonShareMyPost.Click += new System.EventHandler(this.buttonShareMyPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(3, 249);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(455, 123);
            this.textBoxPost.TabIndex = 2;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Enabled = false;
            this.buttonFetchPosts.Location = new System.Drawing.Point(8, 197);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(133, 38);
            this.buttonFetchPosts.TabIndex = 1;
            this.buttonFetchPosts.Text = "Fetch My Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxMyPosts
            // 
            this.listBoxMyPosts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxMyPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxMyPosts.FormattingEnabled = true;
            this.listBoxMyPosts.ItemHeight = 16;
            this.listBoxMyPosts.Location = new System.Drawing.Point(3, 2);
            this.listBoxMyPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMyPosts.Name = "listBoxMyPosts";
            this.listBoxMyPosts.Size = new System.Drawing.Size(894, 180);
            this.listBoxMyPosts.TabIndex = 0;
            // 
            // tabPageLikes
            // 
            this.tabPageLikes.Controls.Add(this.buttonFetchLikedPages);
            this.tabPageLikes.Controls.Add(this.listBoxLikedPages);
            this.tabPageLikes.Location = new System.Drawing.Point(4, 25);
            this.tabPageLikes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLikes.Name = "tabPageLikes";
            this.tabPageLikes.Size = new System.Drawing.Size(900, 393);
            this.tabPageLikes.TabIndex = 3;
            this.tabPageLikes.Text = "Likes";
            this.tabPageLikes.UseVisualStyleBackColor = true;
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.Enabled = false;
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(360, 41);
            this.buttonFetchLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(145, 42);
            this.buttonFetchLikedPages.TabIndex = 1;
            this.buttonFetchLikedPages.Text = "Fetch Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = true;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(337, 393);
            this.listBoxLikedPages.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.buttonFetchAllEvents);
            this.tabPageEvents.Controls.Add(this.listBoxMyEvents);
            this.tabPageEvents.Controls.Add(this.dateTimePickerEventsPicker);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Size = new System.Drawing.Size(900, 393);
            this.tabPageEvents.TabIndex = 4;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // buttonFetchAllEvents
            // 
            this.buttonFetchAllEvents.Enabled = false;
            this.buttonFetchAllEvents.Location = new System.Drawing.Point(35, 268);
            this.buttonFetchAllEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchAllEvents.Name = "buttonFetchAllEvents";
            this.buttonFetchAllEvents.Size = new System.Drawing.Size(143, 37);
            this.buttonFetchAllEvents.TabIndex = 2;
            this.buttonFetchAllEvents.Text = "Fetch All Events";
            this.buttonFetchAllEvents.UseVisualStyleBackColor = true;
            this.buttonFetchAllEvents.Click += new System.EventHandler(this.buttonFetchAllEvents_Click);
            // 
            // listBoxMyEvents
            // 
            this.listBoxMyEvents.FormattingEnabled = true;
            this.listBoxMyEvents.ItemHeight = 16;
            this.listBoxMyEvents.Location = new System.Drawing.Point(27, 41);
            this.listBoxMyEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMyEvents.Name = "listBoxMyEvents";
            this.listBoxMyEvents.Size = new System.Drawing.Size(340, 196);
            this.listBoxMyEvents.TabIndex = 1;
            // 
            // dateTimePickerEventsPicker
            // 
            this.dateTimePickerEventsPicker.Enabled = false;
            this.dateTimePickerEventsPicker.Location = new System.Drawing.Point(27, 14);
            this.dateTimePickerEventsPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEventsPicker.Name = "dateTimePickerEventsPicker";
            this.dateTimePickerEventsPicker.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerEventsPicker.TabIndex = 0;
            this.dateTimePickerEventsPicker.ValueChanged += new System.EventHandler(this.dateTimePickerEventsPicker_ValueChanged);
            // 
            // tabPhotos
            // 
            this.tabPhotos.Controls.Add(this.buttonUploadPhoto);
            this.tabPhotos.Controls.Add(this.buttonCreateAlbum);
            this.tabPhotos.Controls.Add(this.pictureBoxMagnifer);
            this.tabPhotos.Controls.Add(this.labelPhotoDescription);
            this.tabPhotos.Controls.Add(this.pictureBoxPhoto);
            this.tabPhotos.Controls.Add(this.labelPhoto);
            this.tabPhotos.Controls.Add(this.listBoxPhoto);
            this.tabPhotos.Controls.Add(this.buttonRefreshAlbums);
            this.tabPhotos.Controls.Add(this.labelAlbum);
            this.tabPhotos.Controls.Add(this.listBoxAlbums);
            this.tabPhotos.Location = new System.Drawing.Point(4, 25);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Size = new System.Drawing.Size(900, 393);
            this.tabPhotos.TabIndex = 5;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMagnifer
            // 
            this.pictureBoxMagnifer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagnifer.Image = global::FacebookApplication.Properties.Resources.Magnify;
            this.pictureBoxMagnifer.Location = new System.Drawing.Point(673, 277);
            this.pictureBoxMagnifer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMagnifer.Name = "pictureBoxMagnifer";
            this.pictureBoxMagnifer.Size = new System.Drawing.Size(67, 60);
            this.pictureBoxMagnifer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMagnifer.TabIndex = 7;
            this.pictureBoxMagnifer.TabStop = false;
            this.pictureBoxMagnifer.Click += new System.EventHandler(this.pictureBoxMagnifer_Click);
            // 
            // labelPhotoDescription
            // 
            this.labelPhotoDescription.AutoSize = true;
            this.labelPhotoDescription.Location = new System.Drawing.Point(593, 277);
            this.labelPhotoDescription.Name = "labelPhotoDescription";
            this.labelPhotoDescription.Size = new System.Drawing.Size(72, 17);
            this.labelPhotoDescription.TabIndex = 6;
            this.labelPhotoDescription.Text = "                ";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(596, 41);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(267, 216);
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(381, 16);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(52, 17);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "Photos";
            // 
            // listBoxPhoto
            // 
            this.listBoxPhoto.FormattingEnabled = true;
            this.listBoxPhoto.ItemHeight = 16;
            this.listBoxPhoto.Location = new System.Drawing.Point(380, 41);
            this.listBoxPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPhoto.Name = "listBoxPhoto";
            this.listBoxPhoto.Size = new System.Drawing.Size(188, 324);
            this.listBoxPhoto.TabIndex = 3;
            this.listBoxPhoto.SelectedIndexChanged += new System.EventHandler(this.listBoxPhoto_SelectedIndexChanged);
            // 
            // buttonRefreshAlbums
            // 
            this.buttonRefreshAlbums.Enabled = false;
            this.buttonRefreshAlbums.Location = new System.Drawing.Point(217, 41);
            this.buttonRefreshAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefreshAlbums.Name = "buttonRefreshAlbums";
            this.buttonRefreshAlbums.Size = new System.Drawing.Size(133, 39);
            this.buttonRefreshAlbums.TabIndex = 2;
            this.buttonRefreshAlbums.Text = "Refresh Albums";
            this.buttonRefreshAlbums.UseVisualStyleBackColor = true;
            this.buttonRefreshAlbums.Click += new System.EventHandler(this.buttonRefreshAlbums_Click);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(13, 14);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(54, 17);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(9, 41);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(183, 324);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.Location = new System.Drawing.Point(217, 99);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(132, 40);
            this.buttonCreateAlbum.TabIndex = 8;
            this.buttonCreateAlbum.Text = "Create Album";
            this.buttonCreateAlbum.UseVisualStyleBackColor = true;
            this.buttonCreateAlbum.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.Location = new System.Drawing.Point(217, 160);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(131, 52);
            this.buttonUploadPhoto.TabIndex = 9;
            this.buttonUploadPhoto.Text = "Upload Photo To Selected Album";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 576);
            this.Controls.Add(this.tabControlInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageFriends.ResumeLayout(false);
            this.tabPageMyPosts.ResumeLayout(false);
            this.tabPageMyPosts.PerformLayout();
            this.tabPageLikes.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.tabPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Label labelUserDetails;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPageMyPosts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPageLikes;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonFetchFriendPosts;
        private System.Windows.Forms.ListBox listBoxFriendPosts;
        private System.Windows.Forms.ListBox listBoxMyPosts;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonShareMyPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.ListBox listBoxMyEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventsPicker;
        private System.Windows.Forms.Button buttonFetchAllEvents;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonRefreshAlbums;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.ListBox listBoxPhoto;
        private System.Windows.Forms.Label labelPhotoDescription;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMagnifer;
        private System.Windows.Forms.Button buttonCreateAlbum;
        private System.Windows.Forms.Button buttonUploadPhoto;
    }
}

