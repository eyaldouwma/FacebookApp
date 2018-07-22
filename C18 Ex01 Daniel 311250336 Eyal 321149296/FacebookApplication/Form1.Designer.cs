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
            this.buttonFetchFriendPosts = new System.Windows.Forms.Button();
            this.listBoxFriendPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPageMyPosts = new System.Windows.Forms.TabPage();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxMyPosts = new System.Windows.Forms.ListBox();
            this.tabPageLikes = new System.Windows.Forms.TabPage();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonShareMyPost = new System.Windows.Forms.Button();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.tabPageMyPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(14, 21);
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
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(127, 115);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Location = new System.Drawing.Point(145, 3);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(0, 17);
            this.labelUserDetails.TabIndex = 2;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(14, 71);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 154);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLoginLogout);
            this.panel2.Controls.Add(this.checkBoxRememberMe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(750, 0);
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
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInfo.Location = new System.Drawing.Point(0, 154);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(890, 409);
            this.tabControlInfo.TabIndex = 3;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Controls.Add(this.buttonFetchFriends);
            this.tabPageFriends.Controls.Add(this.buttonFetchFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriendPosts);
            this.tabPageFriends.Controls.Add(this.listBoxFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriends.Size = new System.Drawing.Size(882, 380);
            this.tabPageFriends.TabIndex = 0;
            this.tabPageFriends.Text = "Friends";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // buttonFetchFriendPosts
            // 
            this.buttonFetchFriendPosts.Enabled = false;
            this.buttonFetchFriendPosts.Location = new System.Drawing.Point(187, 246);
            this.buttonFetchFriendPosts.Name = "buttonFetchFriendPosts";
            this.buttonFetchFriendPosts.Size = new System.Drawing.Size(150, 55);
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
            this.listBoxFriendPosts.Location = new System.Drawing.Point(353, 3);
            this.listBoxFriendPosts.Name = "listBoxFriendPosts";
            this.listBoxFriendPosts.Size = new System.Drawing.Size(526, 374);
            this.listBoxFriendPosts.TabIndex = 1;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(169, 374);
            this.listBoxFriends.TabIndex = 0;
            // 
            // tabPageMyPosts
            // 
            this.tabPageMyPosts.Controls.Add(this.buttonShareMyPost);
            this.tabPageMyPosts.Controls.Add(this.textBoxPost);
            this.tabPageMyPosts.Controls.Add(this.buttonFetchPosts);
            this.tabPageMyPosts.Controls.Add(this.listBoxMyPosts);
            this.tabPageMyPosts.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyPosts.Name = "tabPageMyPosts";
            this.tabPageMyPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyPosts.Size = new System.Drawing.Size(882, 380);
            this.tabPageMyPosts.TabIndex = 1;
            this.tabPageMyPosts.Text = "My Posts";
            this.tabPageMyPosts.UseVisualStyleBackColor = true;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(8, 197);
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
            this.listBoxMyPosts.Location = new System.Drawing.Point(3, 3);
            this.listBoxMyPosts.Name = "listBoxMyPosts";
            this.listBoxMyPosts.Size = new System.Drawing.Size(876, 180);
            this.listBoxMyPosts.TabIndex = 0;
            // 
            // tabPageLikes
            // 
            this.tabPageLikes.Location = new System.Drawing.Point(4, 25);
            this.tabPageLikes.Name = "tabPageLikes";
            this.tabPageLikes.Size = new System.Drawing.Size(882, 380);
            this.tabPageLikes.TabIndex = 3;
            this.tabPageLikes.Text = "Likes";
            this.tabPageLikes.UseVisualStyleBackColor = true;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Size = new System.Drawing.Size(882, 380);
            this.tabPageEvents.TabIndex = 4;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(3, 249);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(455, 123);
            this.textBoxPost.TabIndex = 2;
            // 
            // buttonShareMyPost
            // 
            this.buttonShareMyPost.Location = new System.Drawing.Point(474, 249);
            this.buttonShareMyPost.Name = "buttonShareMyPost";
            this.buttonShareMyPost.Size = new System.Drawing.Size(131, 34);
            this.buttonShareMyPost.TabIndex = 3;
            this.buttonShareMyPost.Text = "Share My Post";
            this.buttonShareMyPost.UseVisualStyleBackColor = true;
            this.buttonShareMyPost.Click += new System.EventHandler(this.buttonShareMyPost_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(194, 49);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(131, 55);
            this.buttonFetchFriends.TabIndex = 3;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 563);
            this.Controls.Add(this.tabControlInfo);
            this.Controls.Add(this.panel1);
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
    }
}

