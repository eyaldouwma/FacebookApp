namespace FacebookApplication
{
    public partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.pictureBoxLike = new System.Windows.Forms.PictureBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonFetchFriendPosts = new System.Windows.Forms.Button();
            this.listBoxFriendPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.contextMenuStripRightClickFriend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fetchFriendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageMyPosts = new System.Windows.Forms.TabPage();
            this.buttonDeletePost = new System.Windows.Forms.Button();
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
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.labelPhotoDescription = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.pictureBoxMagnifer = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxPhoto = new System.Windows.Forms.ListBox();
            this.buttonRefreshAlbums = new System.Windows.Forms.Button();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.tabPageExtras = new System.Windows.Forms.TabPage();
            this.labelCloseCircleOfFriendsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCloseFriendsCircle = new System.Windows.Forms.ListBox();
            this.listBoxWhoDeletedMe = new System.Windows.Forms.ListBox();
            this.buttonFriendsCloseCircle = new System.Windows.Forms.Button();
            this.buttonWhoDeletedMe = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
            this.tabControlInfo.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).BeginInit();
            this.contextMenuStripRightClickFriend.SuspendLayout();
            this.tabPageMyPosts.SuspendLayout();
            this.tabPageLikes.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabPageExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(201, 101);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(201, 129);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLabel1);
            this.panel1.Controls.Add(this.imageSquarePictureBox);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 209);
            this.panel1.TabIndex = 4;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(311, 101);
            this.birthdayLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(133, 28);
            this.birthdayLabel1.TabIndex = 5;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(311, 129);
            this.emailLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(252, 28);
            this.emailLabel1.TabIndex = 7;
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(16, 15);
            this.imageSquarePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(177, 159);
            this.imageSquarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSquarePictureBox.TabIndex = 9;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(201, 21);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(243, 55);
            this.nameLabel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(768, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 209);
            this.panel2.TabIndex = 4;
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageFriends);
            this.tabControlInfo.Controls.Add(this.tabPageMyPosts);
            this.tabControlInfo.Controls.Add(this.tabPageLikes);
            this.tabControlInfo.Controls.Add(this.tabPageEvents);
            this.tabControlInfo.Controls.Add(this.tabPhotos);
            this.tabControlInfo.Controls.Add(this.tabPageExtras);
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInfo.Location = new System.Drawing.Point(0, 209);
            this.tabControlInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(908, 367);
            this.tabControlInfo.TabIndex = 3;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.BackColor = System.Drawing.Color.Transparent;
            this.tabPageFriends.Controls.Add(this.pictureBoxLike);
            this.tabPageFriends.Controls.Add(this.buttonFetchFriends);
            this.tabPageFriends.Controls.Add(this.buttonFetchFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFriends.Size = new System.Drawing.Size(900, 338);
            this.tabPageFriends.TabIndex = 0;
            this.tabPageFriends.Text = "Friends";
            // 
            // pictureBoxLike
            // 
            this.pictureBoxLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLike.Enabled = false;
            this.pictureBoxLike.Image = global::FacebookApplication.Properties.Resources.like;
            this.pictureBoxLike.Location = new System.Drawing.Point(233, 217);
            this.pictureBoxLike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLike.Name = "pictureBoxLike";
            this.pictureBoxLike.Size = new System.Drawing.Size(64, 59);
            this.pictureBoxLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLike.TabIndex = 5;
            this.pictureBoxLike.TabStop = false;
            this.pictureBoxLike.Click += new System.EventHandler(this.pictureBoxLike_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFetchFriends.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchFriends.Enabled = false;
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchFriends.Location = new System.Drawing.Point(193, 32);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.MaximumSize = new System.Drawing.Size(149, 55);
            this.buttonFetchFriends.MinimumSize = new System.Drawing.Size(149, 55);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(149, 55);
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
            this.buttonFetchFriendPosts.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchFriendPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchFriendPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchFriendPosts.Enabled = false;
            this.buttonFetchFriendPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchFriendPosts.Location = new System.Drawing.Point(193, 110);
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
            this.listBoxFriendPosts.Size = new System.Drawing.Size(527, 334);
            this.listBoxFriendPosts.TabIndex = 1;
            this.listBoxFriendPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendPosts_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.ContextMenuStrip = this.contextMenuStripRightClickFriend;
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 2);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(169, 334);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedValueChanged += new System.EventHandler(this.listBoxFriends_SelectedValueChanged);
            this.listBoxFriends.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFriends_MouseDown);
            // 
            // contextMenuStripRightClickFriend
            // 
            this.contextMenuStripRightClickFriend.Enabled = false;
            this.contextMenuStripRightClickFriend.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRightClickFriend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchFriendsToolStripMenuItem,
            this.profilePictureToolStripMenuItem,
            this.fetchPostsToolStripMenuItem});
            this.contextMenuStripRightClickFriend.Name = "contextMenuStripRightClickFriend";
            this.contextMenuStripRightClickFriend.Size = new System.Drawing.Size(211, 76);
            // 
            // fetchFriendsToolStripMenuItem
            // 
            this.fetchFriendsToolStripMenuItem.Enabled = false;
            this.fetchFriendsToolStripMenuItem.Name = "fetchFriendsToolStripMenuItem";
            this.fetchFriendsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fetchFriendsToolStripMenuItem.Text = "Fetch Friends";
            this.fetchFriendsToolStripMenuItem.Click += new System.EventHandler(this.fetchFriendsToolStripMenuItem_Click);
            // 
            // profilePictureToolStripMenuItem
            // 
            this.profilePictureToolStripMenuItem.Enabled = false;
            this.profilePictureToolStripMenuItem.Name = "profilePictureToolStripMenuItem";
            this.profilePictureToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.profilePictureToolStripMenuItem.Text = "Show Profile Picture";
            this.profilePictureToolStripMenuItem.Click += new System.EventHandler(this.profilePictureToolStripMenuItem_Click);
            // 
            // fetchPostsToolStripMenuItem
            // 
            this.fetchPostsToolStripMenuItem.Enabled = false;
            this.fetchPostsToolStripMenuItem.Name = "fetchPostsToolStripMenuItem";
            this.fetchPostsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fetchPostsToolStripMenuItem.Text = "Fetch Posts";
            this.fetchPostsToolStripMenuItem.Click += new System.EventHandler(this.fetchPostsToolStripMenuItem_Click);
            // 
            // tabPageMyPosts
            // 
            this.tabPageMyPosts.Controls.Add(this.buttonDeletePost);
            this.tabPageMyPosts.Controls.Add(this.buttonShareMyPost);
            this.tabPageMyPosts.Controls.Add(this.textBoxPost);
            this.tabPageMyPosts.Controls.Add(this.buttonFetchPosts);
            this.tabPageMyPosts.Controls.Add(this.listBoxMyPosts);
            this.tabPageMyPosts.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMyPosts.Name = "tabPageMyPosts";
            this.tabPageMyPosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMyPosts.Size = new System.Drawing.Size(900, 338);
            this.tabPageMyPosts.TabIndex = 1;
            this.tabPageMyPosts.Text = "My Posts";
            this.tabPageMyPosts.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonDeletePost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeletePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletePost.Enabled = false;
            this.buttonDeletePost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeletePost.Location = new System.Drawing.Point(179, 197);
            this.buttonDeletePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(157, 37);
            this.buttonDeletePost.TabIndex = 4;
            this.buttonDeletePost.Text = "Delete Selected Post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // buttonShareMyPost
            // 
            this.buttonShareMyPost.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonShareMyPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShareMyPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShareMyPost.Enabled = false;
            this.buttonShareMyPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShareMyPost.Location = new System.Drawing.Point(475, 249);
            this.buttonShareMyPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShareMyPost.Name = "buttonShareMyPost";
            this.buttonShareMyPost.Size = new System.Drawing.Size(131, 46);
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
            this.buttonFetchPosts.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchPosts.Enabled = false;
            this.buttonFetchPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.tabPageLikes.Size = new System.Drawing.Size(900, 338);
            this.tabPageLikes.TabIndex = 3;
            this.tabPageLikes.Text = "Likes";
            this.tabPageLikes.UseVisualStyleBackColor = true;
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchLikedPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchLikedPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchLikedPages.Enabled = false;
            this.buttonFetchLikedPages.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.listBoxLikedPages.Size = new System.Drawing.Size(337, 338);
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
            this.tabPageEvents.Size = new System.Drawing.Size(900, 338);
            this.tabPageEvents.TabIndex = 4;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // buttonFetchAllEvents
            // 
            this.buttonFetchAllEvents.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchAllEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchAllEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAllEvents.Enabled = false;
            this.buttonFetchAllEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.tabPhotos.Controls.Add(this.labelPhotoDescription);
            this.tabPhotos.Controls.Add(this.labelPhoto);
            this.tabPhotos.Controls.Add(this.pictureBoxMagnifer);
            this.tabPhotos.Controls.Add(this.pictureBoxPhoto);
            this.tabPhotos.Controls.Add(this.listBoxPhoto);
            this.tabPhotos.Controls.Add(this.buttonRefreshAlbums);
            this.tabPhotos.Controls.Add(this.labelAlbum);
            this.tabPhotos.Controls.Add(this.listBoxAlbums);
            this.tabPhotos.Location = new System.Drawing.Point(4, 25);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Size = new System.Drawing.Size(900, 338);
            this.tabPhotos.TabIndex = 5;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonUploadPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUploadPhoto.Enabled = false;
            this.buttonUploadPhoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUploadPhoto.Location = new System.Drawing.Point(217, 160);
            this.buttonUploadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(131, 52);
            this.buttonUploadPhoto.TabIndex = 9;
            this.buttonUploadPhoto.Text = "Upload Photo To Selected Album";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonCreateAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAlbum.Enabled = false;
            this.buttonCreateAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateAlbum.Location = new System.Drawing.Point(217, 98);
            this.buttonCreateAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(132, 39);
            this.buttonCreateAlbum.TabIndex = 8;
            this.buttonCreateAlbum.Text = "Create Album";
            this.buttonCreateAlbum.UseVisualStyleBackColor = true;
            this.buttonCreateAlbum.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
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
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(381, 16);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(52, 17);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "Photos";
            // 
            // pictureBoxMagnifer
            // 
            this.pictureBoxMagnifer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagnifer.Enabled = false;
            this.pictureBoxMagnifer.Image = global::FacebookApplication.Properties.Resources.Magnify;
            this.pictureBoxMagnifer.Location = new System.Drawing.Point(673, 277);
            this.pictureBoxMagnifer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMagnifer.Name = "pictureBoxMagnifer";
            this.pictureBoxMagnifer.Size = new System.Drawing.Size(67, 60);
            this.pictureBoxMagnifer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMagnifer.TabIndex = 7;
            this.pictureBoxMagnifer.TabStop = false;
            this.pictureBoxMagnifer.Click += new System.EventHandler(this.pictureBoxMagnifier_Click);
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
            this.buttonRefreshAlbums.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonRefreshAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshAlbums.Enabled = false;
            this.buttonRefreshAlbums.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            // tabPageExtras
            // 
            this.tabPageExtras.Controls.Add(this.labelCloseCircleOfFriendsCount);
            this.tabPageExtras.Controls.Add(this.label1);
            this.tabPageExtras.Controls.Add(this.listBoxCloseFriendsCircle);
            this.tabPageExtras.Controls.Add(this.listBoxWhoDeletedMe);
            this.tabPageExtras.Controls.Add(this.buttonFriendsCloseCircle);
            this.tabPageExtras.Controls.Add(this.buttonWhoDeletedMe);
            this.tabPageExtras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageExtras.Location = new System.Drawing.Point(4, 25);
            this.tabPageExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageExtras.Name = "tabPageExtras";
            this.tabPageExtras.Size = new System.Drawing.Size(900, 338);
            this.tabPageExtras.TabIndex = 6;
            this.tabPageExtras.Text = "Extras";
            this.tabPageExtras.UseVisualStyleBackColor = true;
            // 
            // labelCloseCircleOfFriendsCount
            // 
            this.labelCloseCircleOfFriendsCount.AutoSize = true;
            this.labelCloseCircleOfFriendsCount.Location = new System.Drawing.Point(680, 42);
            this.labelCloseCircleOfFriendsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCloseCircleOfFriendsCount.Name = "labelCloseCircleOfFriendsCount";
            this.labelCloseCircleOfFriendsCount.Size = new System.Drawing.Size(13, 17);
            this.labelCloseCircleOfFriendsCount.TabIndex = 12;
            this.labelCloseCircleOfFriendsCount.Text = "-";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(559, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number Of Mutual Friends With Close Circle:";
            // 
            // listBoxCloseFriendsCircle
            // 
            this.listBoxCloseFriendsCircle.FormattingEnabled = true;
            this.listBoxCloseFriendsCircle.ItemHeight = 16;
            this.listBoxCloseFriendsCircle.Location = new System.Drawing.Point(403, 94);
            this.listBoxCloseFriendsCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCloseFriendsCircle.Name = "listBoxCloseFriendsCircle";
            this.listBoxCloseFriendsCircle.Size = new System.Drawing.Size(457, 276);
            this.listBoxCloseFriendsCircle.TabIndex = 10;
            // 
            // listBoxWhoDeletedMe
            // 
            this.listBoxWhoDeletedMe.FormattingEnabled = true;
            this.listBoxWhoDeletedMe.ItemHeight = 16;
            this.listBoxWhoDeletedMe.Location = new System.Drawing.Point(16, 94);
            this.listBoxWhoDeletedMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxWhoDeletedMe.Name = "listBoxWhoDeletedMe";
            this.listBoxWhoDeletedMe.Size = new System.Drawing.Size(355, 276);
            this.listBoxWhoDeletedMe.TabIndex = 9;
            // 
            // buttonFriendsCloseCircle
            // 
            this.buttonFriendsCloseCircle.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFriendsCloseCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFriendsCloseCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriendsCloseCircle.Enabled = false;
            this.buttonFriendsCloseCircle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFriendsCloseCircle.Location = new System.Drawing.Point(403, 26);
            this.buttonFriendsCloseCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFriendsCloseCircle.Name = "buttonFriendsCloseCircle";
            this.buttonFriendsCloseCircle.Size = new System.Drawing.Size(148, 55);
            this.buttonFriendsCloseCircle.TabIndex = 8;
            this.buttonFriendsCloseCircle.Text = "Find Close Circle Of Friends";
            this.buttonFriendsCloseCircle.UseVisualStyleBackColor = true;
            this.buttonFriendsCloseCircle.Click += new System.EventHandler(this.buttonFriendsCloseCircle_Click);
            // 
            // buttonWhoDeletedMe
            // 
            this.buttonWhoDeletedMe.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonWhoDeletedMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWhoDeletedMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWhoDeletedMe.Enabled = false;
            this.buttonWhoDeletedMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWhoDeletedMe.Location = new System.Drawing.Point(16, 26);
            this.buttonWhoDeletedMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWhoDeletedMe.Name = "buttonWhoDeletedMe";
            this.buttonWhoDeletedMe.Size = new System.Drawing.Size(149, 55);
            this.buttonWhoDeletedMe.TabIndex = 7;
            this.buttonWhoDeletedMe.Text = "Who deleted me?";
            this.buttonWhoDeletedMe.UseVisualStyleBackColor = true;
            this.buttonWhoDeletedMe.Click += new System.EventHandler(this.buttonWhoDeletedMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 576);
            this.Controls.Add(this.tabControlInfo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).EndInit();
            this.contextMenuStripRightClickFriend.ResumeLayout(false);
            this.tabPageMyPosts.ResumeLayout(false);
            this.tabPageMyPosts.PerformLayout();
            this.tabPageLikes.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.tabPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabPageExtras.ResumeLayout(false);
            this.tabPageExtras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.PictureBox pictureBoxLike;
        private System.Windows.Forms.TabPage tabPageExtras;
        private System.Windows.Forms.Button buttonFriendsCloseCircle;
        private System.Windows.Forms.Button buttonWhoDeletedMe;
        private System.Windows.Forms.ListBox listBoxCloseFriendsCircle;
        private System.Windows.Forms.ListBox listBoxWhoDeletedMe;
        private System.Windows.Forms.Label labelCloseCircleOfFriendsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightClickFriend;
        private System.Windows.Forms.ToolStripMenuItem profilePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchFriendsToolStripMenuItem;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageSquarePictureBox;
        private System.Windows.Forms.Label nameLabel1;
    }
}
