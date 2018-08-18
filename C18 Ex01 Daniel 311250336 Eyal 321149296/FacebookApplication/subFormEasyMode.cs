using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookApplication
{
    class subFormEasyMode : Form
    {

        private Form1 m_TheForm = Form1.getInstance();
        private subFormPicture m_PostPicture = SubFormFactory.CreateForm(SubFormFactory.SubFormTypes.Picture) as subFormPicture;
        private ListBox listBoxGeneral;
        private Button buttonFetchPages;
        private Button buttonFetchFriend;
        private Button buttonFetchMyPosts;
        private Thread m_SubPicutreThread = null;
        private BindingSource userBindingSource;
        private System.ComponentModel.IContainer components;
        private PictureBox imageSquarePictureBox;
        private Label nameLabel1;
        private bool k_FetchMyPostIsClicked = false;

        public subFormEasyMode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormEasyMode));
            this.listBoxGeneral = new System.Windows.Forms.ListBox();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.buttonFetchFriend = new System.Windows.Forms.Button();
            this.buttonFetchMyPosts = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.Location = new System.Drawing.Point(12, 188);
            this.listBoxGeneral.Name = "listBoxGeneral";
            this.listBoxGeneral.Size = new System.Drawing.Size(301, 264);
            this.listBoxGeneral.TabIndex = 0;
            this.listBoxGeneral.SelectedIndexChanged += new System.EventHandler(this.listBoxGeneral_SelectedIndexChanged);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchPages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFetchPages.Location = new System.Drawing.Point(337, 188);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(139, 53);
            this.buttonFetchPages.TabIndex = 1;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // buttonFetchFriend
            // 
            this.buttonFetchFriend.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchFriend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFetchFriend.Location = new System.Drawing.Point(338, 308);
            this.buttonFetchFriend.Name = "buttonFetchFriend";
            this.buttonFetchFriend.Size = new System.Drawing.Size(137, 52);
            this.buttonFetchFriend.TabIndex = 2;
            this.buttonFetchFriend.Text = "Fetch Friends";
            this.buttonFetchFriend.UseVisualStyleBackColor = true;
            this.buttonFetchFriend.Click += new System.EventHandler(this.buttonFetchFriend_Click);
            // 
            // buttonFetchMyPosts
            // 
            this.buttonFetchMyPosts.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonFetchMyPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFetchMyPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFetchMyPosts.Location = new System.Drawing.Point(338, 429);
            this.buttonFetchMyPosts.Name = "buttonFetchMyPosts";
            this.buttonFetchMyPosts.Size = new System.Drawing.Size(136, 51);
            this.buttonFetchMyPosts.TabIndex = 3;
            this.buttonFetchMyPosts.Text = "Fetch My Posts";
            this.buttonFetchMyPosts.UseVisualStyleBackColor = true;
            this.buttonFetchMyPosts.Click += new System.EventHandler(this.buttonFetchMyPosts_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(12, 6);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(113, 114);
            this.imageSquarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSquarePictureBox.TabIndex = 6;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(131, 6);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(155, 42);
            this.nameLabel1.TabIndex = 8;
            // 
            // subFormEasyMode
            // 
            this.ClientSize = new System.Drawing.Size(496, 500);
            this.Controls.Add(this.imageSquarePictureBox);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.buttonFetchMyPosts);
            this.Controls.Add(this.buttonFetchFriend);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.listBoxGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormEasyMode";
            this.Text = "Facebook Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormEasyMode_FormClosing);
            this.Shown += new System.EventHandler(this.subFormEasyMode_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void showPictureForm(object i_PictureLink)
        {
            string picture = i_PictureLink as string;

            m_PostPicture.InitializeSubForm(picture);
            m_PostPicture.ShowDialog();
        }


        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            k_FetchMyPostIsClicked = false;
            listBoxGeneral.Items.Clear();
            m_TheForm.FetchLikedPages(listBoxGeneral);

            killPictureThread();
        }

        private void killPictureThread()
        {
            if (m_SubPicutreThread != null)
            {
                if (m_SubPicutreThread.IsAlive)
                {
                    m_SubPicutreThread.Abort();
                }
            }
        }

        private void buttonFetchFriend_Click(object sender, EventArgs e)
        {
            k_FetchMyPostIsClicked = false;
            listBoxGeneral.Items.Clear();
            m_TheForm.FetchFriends(listBoxGeneral);

            killPictureThread();
        }

        private void buttonFetchMyPosts_Click(object sender, EventArgs e)
        {
            k_FetchMyPostIsClicked = true;
            listBoxGeneral.Items.Clear();
            m_TheForm.FetchMyPosts(listBoxGeneral);
        }

        private void listBoxGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k_FetchMyPostIsClicked)
            {
                if (listBoxGeneral.SelectedIndex < m_TheForm.m_FacebookUser.Posts.Count && listBoxGeneral.SelectedIndex > -1)
                {
                    Post myPost = m_TheForm.m_FacebookUser.Posts[listBoxGeneral.SelectedIndex];
           
                    if (!string.IsNullOrEmpty(myPost.PictureURL))
                    {
                        if (m_SubPicutreThread == null || !m_SubPicutreThread.IsAlive)
                        {
                            m_SubPicutreThread = new Thread(new ParameterizedThreadStart(showPictureForm));
                            m_SubPicutreThread.Start(myPost.PictureURL);
                        }
                        else
                        {
                            m_PostPicture.InitializeSubForm(myPost.PictureURL);
                        }

                    }
                }
            }
        }

        private void subFormEasyMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_SubPicutreThread != null && m_SubPicutreThread.IsAlive)
            {
                m_SubPicutreThread.Abort();
                m_SubPicutreThread = null;
            }

            listBoxGeneral.Items.Clear();
        }

        private void subFormEasyMode_Shown(object sender, EventArgs e)
        {
            userBindingSource.DataSource = m_TheForm.m_FacebookUser;
        }
    }
}
