namespace FacebookApp
{
    partial class FacebookForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 37);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(164, 12);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(112, 88);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 488);
            this.Controls.Add(this.pictureBoxProfilePic);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FacebookForm";
            this.Text = "FacebookForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
    }
}