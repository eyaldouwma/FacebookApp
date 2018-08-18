namespace FacebookApplication
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonEasyMode = new System.Windows.Forms.Button();
            this.buttonRegularMode = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(90, 60);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(103, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonEasyMode
            // 
            this.buttonEasyMode.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonEasyMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEasyMode.Enabled = false;
            this.buttonEasyMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEasyMode.Location = new System.Drawing.Point(9, 193);
            this.buttonEasyMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEasyMode.Name = "buttonEasyMode";
            this.buttonEasyMode.Size = new System.Drawing.Size(103, 48);
            this.buttonEasyMode.TabIndex = 1;
            this.buttonEasyMode.Text = "Easy Mode";
            this.buttonEasyMode.UseVisualStyleBackColor = true;
            this.buttonEasyMode.Click += new System.EventHandler(this.buttonEasyMode_Click);
            // 
            // buttonRegularMode
            // 
            this.buttonRegularMode.BackgroundImage = global::FacebookApplication.Properties.Resources.Untitled_2;
            this.buttonRegularMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegularMode.Enabled = false;
            this.buttonRegularMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegularMode.Location = new System.Drawing.Point(165, 193);
            this.buttonRegularMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegularMode.Name = "buttonRegularMode";
            this.buttonRegularMode.Size = new System.Drawing.Size(103, 48);
            this.buttonRegularMode.TabIndex = 2;
            this.buttonRegularMode.Text = "Regular Mode";
            this.buttonRegularMode.UseVisualStyleBackColor = true;
            this.buttonRegularMode.Click += new System.EventHandler(this.buttonRegularMode_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(90, 114);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonRegularMode);
            this.Controls.Add(this.buttonEasyMode);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FirstForm";
            this.Text = "Facebook Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstForm_FormClosing);
            this.Shown += new System.EventHandler(this.FirstForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonEasyMode;
        private System.Windows.Forms.Button buttonRegularMode;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}