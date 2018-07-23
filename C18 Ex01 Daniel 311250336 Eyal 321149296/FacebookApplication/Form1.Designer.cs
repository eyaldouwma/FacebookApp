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
            this.buttonLoginLogout.Location = new System.Drawing.Point(10, 17);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(77, 36);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(96, 94);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Location = new System.Drawing.Point(109, 2);
            this.labelUserDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(0, 13);
            this.labelUserDetails.TabIndex = 2;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(10, 58);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 125);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLoginLogout);
            this.panel2.Controls.Add(this.checkBoxRememberMe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(576, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 125);
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
            this.tabControlInfo.Location = new System.Drawing.Point(0, 125);
            this.tabControlInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(681, 343);
            this.tabControlInfo.TabIndex = 3;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Controls.Add(this.buttonFetchFriends);
            this.tabPageFriends.Controls.Add(this.buttonFetchFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 22);
            this.tabPageFriends.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageFriends.Size = new System.Drawing.Size(673, 317);
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
            this.buttonFetchFriends.Location = new System.Drawing.Point(146, 40);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchFriends.MaximumSize = new System.Drawing.Size(98, 45);
            this.buttonFetchFriends.MinimumSize = new System.Drawing.Size(98, 45);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(98, 45);
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
            this.buttonFetchFriendPosts.Location = new System.Drawing.Point(140, 200);
            this.buttonFetchFriendPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchFriendPosts.MaximumSize = new System.Drawing.Size(112, 45);
            this.buttonFetchFriendPosts.MinimumSize = new System.Drawing.Size(112, 45);
            this.buttonFetchFriendPosts.Name = "buttonFetchFriendPosts";
            this.buttonFetchFriendPosts.Size = new System.Drawing.Size(112, 45);
            this.buttonFetchFriendPosts.TabIndex = 2;
            this.buttonFetchFriendPosts.Text = "Fetch Friends Posts";
            this.buttonFetchFriendPosts.UseVisualStyleBackColor = true;
            this.buttonFetchFriendPosts.Click += new System.EventHandler(this.buttonFetchFriendPosts_Click);
            // 
            // listBoxFriendPosts
            // 
            this.listBoxFriendPosts.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxFriendPosts.FormattingEnabled = true;
            this.listBoxFriendPosts.Location = new System.Drawing.Point(275, 2);
            this.listBoxFriendPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriendPosts.Name = "listBoxFriendPosts";
            this.listBoxFriendPosts.Size = new System.Drawing.Size(396, 313);
            this.listBoxFriendPosts.TabIndex = 1;
            this.listBoxFriendPosts.SelectedValueChanged += new System.EventHandler(this.listBoxFriendPosts_SelectedValueChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(2, 2);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(128, 313);
            this.listBoxFriends.TabIndex = 0;
            // 
            // tabPageMyPosts
            // 
            this.tabPageMyPosts.Controls.Add(this.buttonShareMyPost);
            this.tabPageMyPosts.Controls.Add(this.textBoxPost);
            this.tabPageMyPosts.Controls.Add(this.buttonFetchPosts);
            this.tabPageMyPosts.Controls.Add(this.listBoxMyPosts);
            this.tabPageMyPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyPosts.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMyPosts.Name = "tabPageMyPosts";
            this.tabPageMyPosts.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageMyPosts.Size = new System.Drawing.Size(673, 317);
            this.tabPageMyPosts.TabIndex = 1;
            this.tabPageMyPosts.Text = "My Posts";
            this.tabPageMyPosts.UseVisualStyleBackColor = true;
            // 
            // buttonShareMyPost
            // 
            this.buttonShareMyPost.Enabled = false;
            this.buttonShareMyPost.Location = new System.Drawing.Point(356, 202);
            this.buttonShareMyPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShareMyPost.Name = "buttonShareMyPost";
            this.buttonShareMyPost.Size = new System.Drawing.Size(98, 28);
            this.buttonShareMyPost.TabIndex = 3;
            this.buttonShareMyPost.Text = "Share My Post";
            this.buttonShareMyPost.UseVisualStyleBackColor = true;
            this.buttonShareMyPost.Click += new System.EventHandler(this.buttonShareMyPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(2, 202);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(342, 101);
            this.textBoxPost.TabIndex = 2;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Enabled = false;
            this.buttonFetchPosts.Location = new System.Drawing.Point(6, 160);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(100, 31);
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
            this.listBoxMyPosts.Location = new System.Drawing.Point(2, 2);
            this.listBoxMyPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMyPosts.Name = "listBoxMyPosts";
            this.listBoxMyPosts.Size = new System.Drawing.Size(669, 147);
            this.listBoxMyPosts.TabIndex = 0;
            // 
            // tabPageLikes
            // 
            this.tabPageLikes.Controls.Add(this.buttonFetchLikedPages);
            this.tabPageLikes.Controls.Add(this.listBoxLikedPages);
            this.tabPageLikes.Location = new System.Drawing.Point(4, 22);
            this.tabPageLikes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLikes.Name = "tabPageLikes";
            this.tabPageLikes.Size = new System.Drawing.Size(673, 317);
            this.tabPageLikes.TabIndex = 3;
            this.tabPageLikes.Text = "Likes";
            this.tabPageLikes.UseVisualStyleBackColor = true;
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.Enabled = false;
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(270, 33);
            this.buttonFetchLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(109, 34);
            this.buttonFetchLikedPages.TabIndex = 1;
            this.buttonFetchLikedPages.Text = "Fetch Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = true;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(254, 317);
            this.listBoxLikedPages.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.buttonFetchAllEvents);
            this.tabPageEvents.Controls.Add(this.listBoxMyEvents);
            this.tabPageEvents.Controls.Add(this.dateTimePickerEventsPicker);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Size = new System.Drawing.Size(673, 317);
            this.tabPageEvents.TabIndex = 4;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // buttonFetchAllEvents
            // 
            this.buttonFetchAllEvents.Enabled = false;
            this.buttonFetchAllEvents.Location = new System.Drawing.Point(26, 218);
            this.buttonFetchAllEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchAllEvents.Name = "buttonFetchAllEvents";
            this.buttonFetchAllEvents.Size = new System.Drawing.Size(107, 30);
            this.buttonFetchAllEvents.TabIndex = 2;
            this.buttonFetchAllEvents.Text = "Fetch All Events";
            this.buttonFetchAllEvents.UseVisualStyleBackColor = true;
            this.buttonFetchAllEvents.Click += new System.EventHandler(this.buttonFetchAllEvents_Click);
            // 
            // listBoxMyEvents
            // 
            this.listBoxMyEvents.FormattingEnabled = true;
            this.listBoxMyEvents.Location = new System.Drawing.Point(20, 33);
            this.listBoxMyEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMyEvents.Name = "listBoxMyEvents";
            this.listBoxMyEvents.Size = new System.Drawing.Size(256, 160);
            this.listBoxMyEvents.TabIndex = 1;
            // 
            // dateTimePickerEventsPicker
            // 
            this.dateTimePickerEventsPicker.Enabled = false;
            this.dateTimePickerEventsPicker.Location = new System.Drawing.Point(20, 11);
            this.dateTimePickerEventsPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEventsPicker.Name = "dateTimePickerEventsPicker";
            this.dateTimePickerEventsPicker.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerEventsPicker.TabIndex = 0;
            this.dateTimePickerEventsPicker.ValueChanged += new System.EventHandler(this.dateTimePickerEventsPicker_ValueChanged);
            // 
            // tabPhotos
            // 
            this.tabPhotos.Controls.Add(this.pictureBoxMagnifer);
            this.tabPhotos.Controls.Add(this.labelPhotoDescription);
            this.tabPhotos.Controls.Add(this.pictureBoxPhoto);
            this.tabPhotos.Controls.Add(this.labelPhoto);
            this.tabPhotos.Controls.Add(this.listBoxPhoto);
            this.tabPhotos.Controls.Add(this.buttonRefreshAlbums);
            this.tabPhotos.Controls.Add(this.labelAlbum);
            this.tabPhotos.Controls.Add(this.listBoxAlbums);
            this.tabPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Size = new System.Drawing.Size(673, 317);
            this.tabPhotos.TabIndex = 5;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMagnifer
            // 
            this.pictureBoxMagnifer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagnifer.Image = global::FacebookApplication.Properties.Resources.Magnify;
            this.pictureBoxMagnifer.Location = new System.Drawing.Point(505, 225);
            this.pictureBoxMagnifer.Name = "pictureBoxMagnifer";
            this.pictureBoxMagnifer.Size = new System.Drawing.Size(50, 49);
            this.pictureBoxMagnifer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMagnifer.TabIndex = 7;
            this.pictureBoxMagnifer.TabStop = false;
            this.pictureBoxMagnifer.Click += new System.EventHandler(this.pictureBoxMagnifer_Click);
            // 
            // labelPhotoDescription
            // 
            this.labelPhotoDescription.AutoSize = true;
            this.labelPhotoDescription.Location = new System.Drawing.Point(445, 225);
            this.labelPhotoDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhotoDescription.Name = "labelPhotoDescription";
            this.labelPhotoDescription.Size = new System.Drawing.Size(55, 13);
            this.labelPhotoDescription.TabIndex = 6;
            this.labelPhotoDescription.Text = "                ";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(447, 33);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(201, 176);
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(286, 13);
            this.labelPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(40, 13);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "Photos";
            // 
            // listBoxPhoto
            // 
            this.listBoxPhoto.FormattingEnabled = true;
            this.listBoxPhoto.Location = new System.Drawing.Point(285, 33);
            this.listBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPhoto.Name = "listBoxPhoto";
            this.listBoxPhoto.Size = new System.Drawing.Size(142, 264);
            this.listBoxPhoto.TabIndex = 3;
            this.listBoxPhoto.SelectedIndexChanged += new System.EventHandler(this.listBoxPhoto_SelectedIndexChanged);
            // 
            // buttonRefreshAlbums
            // 
            this.buttonRefreshAlbums.Enabled = false;
            this.buttonRefreshAlbums.Location = new System.Drawing.Point(163, 33);
            this.buttonRefreshAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshAlbums.Name = "buttonRefreshAlbums";
            this.buttonRefreshAlbums.Size = new System.Drawing.Size(100, 32);
            this.buttonRefreshAlbums.TabIndex = 2;
            this.buttonRefreshAlbums.Text = "Refresh Albums";
            this.buttonRefreshAlbums.UseVisualStyleBackColor = true;
            this.buttonRefreshAlbums.Click += new System.EventHandler(this.buttonRefreshAlbums_Click);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(10, 11);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(41, 13);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(7, 33);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(138, 264);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 468);
            this.Controls.Add(this.tabControlInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

