using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    class subFormEasyMode : Form
    {
        private ListBox listBoxFriends;
        private LinkLabel linkLabelFetchFriends;
        private ListBox listBoxPages;
        private LinkLabel linkLabelFetchPages;
        private ListBox listBoxFetchMyPosts;
        private LinkLabel linkLabelFetchMyPosts;
        private Button buttonRefresh;
        private Form1 m_TheForm = Form1.getInstance();


        public subFormEasyMode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormEasyMode));
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.linkLabelFetchFriends = new System.Windows.Forms.LinkLabel();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.linkLabelFetchPages = new System.Windows.Forms.LinkLabel();
            this.listBoxFetchMyPosts = new System.Windows.Forms.ListBox();
            this.linkLabelFetchMyPosts = new System.Windows.Forms.LinkLabel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(23, 226);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxFriends.Size = new System.Drawing.Size(122, 228);
            this.listBoxFriends.TabIndex = 0;
            // 
            // linkLabelFetchFriends
            // 
            this.linkLabelFetchFriends.AutoSize = true;
            this.linkLabelFetchFriends.Location = new System.Drawing.Point(20, 197);
            this.linkLabelFetchFriends.Name = "linkLabelFetchFriends";
            this.linkLabelFetchFriends.Size = new System.Drawing.Size(94, 17);
            this.linkLabelFetchFriends.TabIndex = 1;
            this.linkLabelFetchFriends.TabStop = true;
            this.linkLabelFetchFriends.Text = "Fetch Friends";
            this.linkLabelFetchFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchFriends_LinkClicked);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(212, 226);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(175, 228);
            this.listBoxPages.TabIndex = 2;
            // 
            // linkLabelFetchPages
            // 
            this.linkLabelFetchPages.AutoSize = true;
            this.linkLabelFetchPages.Location = new System.Drawing.Point(209, 197);
            this.linkLabelFetchPages.Name = "linkLabelFetchPages";
            this.linkLabelFetchPages.Size = new System.Drawing.Size(87, 17);
            this.linkLabelFetchPages.TabIndex = 3;
            this.linkLabelFetchPages.TabStop = true;
            this.linkLabelFetchPages.Text = "Fetch Pages";
            this.linkLabelFetchPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPages_LinkClicked);
            // 
            // listBoxFetchMyPosts
            // 
            this.listBoxFetchMyPosts.FormattingEnabled = true;
            this.listBoxFetchMyPosts.ItemHeight = 16;
            this.listBoxFetchMyPosts.Location = new System.Drawing.Point(457, 226);
            this.listBoxFetchMyPosts.Name = "listBoxFetchMyPosts";
            this.listBoxFetchMyPosts.Size = new System.Drawing.Size(269, 228);
            this.listBoxFetchMyPosts.TabIndex = 4;
            // 
            // linkLabelFetchMyPosts
            // 
            this.linkLabelFetchMyPosts.AutoSize = true;
            this.linkLabelFetchMyPosts.Location = new System.Drawing.Point(454, 197);
            this.linkLabelFetchMyPosts.Name = "linkLabelFetchMyPosts";
            this.linkLabelFetchMyPosts.Size = new System.Drawing.Size(104, 17);
            this.linkLabelFetchMyPosts.TabIndex = 5;
            this.linkLabelFetchMyPosts.TabStop = true;
            this.linkLabelFetchMyPosts.Text = "Fetch My Posts";
            this.linkLabelFetchMyPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchMyPosts_LinkClicked);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(611, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(114, 42);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // subFormEasyMode
            // 
            this.ClientSize = new System.Drawing.Size(738, 471);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.linkLabelFetchMyPosts);
            this.Controls.Add(this.listBoxFetchMyPosts);
            this.Controls.Add(this.linkLabelFetchPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.linkLabelFetchFriends);
            this.Controls.Add(this.listBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormEasyMode";
            this.Text = "Facebook Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabelFetchFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_TheForm.FetchFriends(listBoxFriends);
        }

        private void linkLabelFetchPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_TheForm.FetchLikedPages(listBoxPages);
        }

        private void linkLabelFetchMyPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_TheForm.FetchMyPosts(listBoxFetchMyPosts);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            m_TheForm.Refresh();

            m_TheForm.FetchMyPosts(listBoxFetchMyPosts);
            m_TheForm.FetchLikedPages(listBoxPages);
            m_TheForm.FetchFriends(listBoxFriends);

        }
    }
}
