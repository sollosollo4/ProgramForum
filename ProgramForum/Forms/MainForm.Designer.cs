namespace ProgramForum
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseLanguageStrip = new System.Windows.Forms.ToolStripComboBox();
            this.RandomQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAccount = new System.Windows.Forms.Button();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.newQuestionLink = new System.Windows.Forms.LinkLabel();
            this.MainForumMenu = new System.Windows.Forms.Panel();
            this.AccountsGrid = new System.Windows.Forms.LinkLabel();
            this.ForumNews = new System.Windows.Forms.LinkLabel();
            this.NewAccountsRegistred = new System.Windows.Forms.LinkLabel();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.MainForumMenu.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackColor = System.Drawing.Color.White;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormToolStripMenuItem,
            this.ChooseLanguageStrip,
            this.RandomQuestionToolStripMenuItem,
            this.GetTrainingToolStripMenuItem,
            this.MessagesToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            // 
            // MainFormToolStripMenuItem
            // 
            resources.ApplyResources(this.MainFormToolStripMenuItem, "MainFormToolStripMenuItem");
            this.MainFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainFormToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.MainFormToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.MainFormToolStripMenuItem.MergeIndex = 0;
            this.MainFormToolStripMenuItem.Name = "MainFormToolStripMenuItem";
            this.MainFormToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.MainFormToolStripMenuItem.Click += new System.EventHandler(this.MainFormToolStripMenuItem_Click);
            // 
            // ChooseLanguageStrip
            // 
            resources.ApplyResources(this.ChooseLanguageStrip, "ChooseLanguageStrip");
            this.ChooseLanguageStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChooseLanguageStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLanguageStrip.ForeColor = System.Drawing.SystemColors.Window;
            this.ChooseLanguageStrip.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ChooseLanguageStrip.MergeIndex = 0;
            this.ChooseLanguageStrip.Name = "ChooseLanguageStrip";
            this.ChooseLanguageStrip.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ChooseLanguageStrip.SelectedIndexChanged += new System.EventHandler(this.ChooseLanguageStrip_SelectedIndexChanged);
            // 
            // RandomQuestionToolStripMenuItem
            // 
            resources.ApplyResources(this.RandomQuestionToolStripMenuItem, "RandomQuestionToolStripMenuItem");
            this.RandomQuestionToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RandomQuestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.RandomQuestionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.RandomQuestionToolStripMenuItem.MergeIndex = 0;
            this.RandomQuestionToolStripMenuItem.Name = "RandomQuestionToolStripMenuItem";
            this.RandomQuestionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.RandomQuestionToolStripMenuItem.Click += new System.EventHandler(this.RandomQuestionToolStripMenuItem_Click);
            // 
            // GetTrainingToolStripMenuItem
            // 
            resources.ApplyResources(this.GetTrainingToolStripMenuItem, "GetTrainingToolStripMenuItem");
            this.GetTrainingToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GetTrainingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.GetTrainingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GetTrainingToolStripMenuItem.MergeIndex = 0;
            this.GetTrainingToolStripMenuItem.Name = "GetTrainingToolStripMenuItem";
            this.GetTrainingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.GetTrainingToolStripMenuItem.Click += new System.EventHandler(this.GetTrainingToolStripMenuItem_Click);
            // 
            // MessagesToolStripMenuItem
            // 
            resources.ApplyResources(this.MessagesToolStripMenuItem, "MessagesToolStripMenuItem");
            this.MessagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MessagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.MessagesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.MessagesToolStripMenuItem.MergeIndex = 0;
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.MessagesToolStripMenuItem.Click += new System.EventHandler(this.MessagesToolStripMenuItem_Click);
            // 
            // MyAccount
            // 
            this.MyAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MyAccount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.MyAccount, "MyAccount");
            this.MyAccount.ForeColor = System.Drawing.Color.White;
            this.MyAccount.Name = "MyAccount";
            this.MyAccount.UseVisualStyleBackColor = false;
            this.MyAccount.Click += new System.EventHandler(this.MyAccount_Click);
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
            this.LanguageLabel.Name = "LanguageLabel";
            // 
            // newQuestionLink
            // 
            resources.ApplyResources(this.newQuestionLink, "newQuestionLink");
            this.newQuestionLink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newQuestionLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.newQuestionLink.LinkColor = System.Drawing.Color.White;
            this.newQuestionLink.Name = "newQuestionLink";
            this.newQuestionLink.TabStop = true;
            this.newQuestionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newQuestionLink_LinkClicked);
            // 
            // MainForumMenu
            // 
            resources.ApplyResources(this.MainForumMenu, "MainForumMenu");
            this.MainForumMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainForumMenu.Controls.Add(this.AccountsGrid);
            this.MainForumMenu.Controls.Add(this.ForumNews);
            this.MainForumMenu.Controls.Add(this.NewAccountsRegistred);
            this.MainForumMenu.Controls.Add(this.newQuestionLink);
            this.MainForumMenu.Name = "MainForumMenu";
            // 
            // AccountsGrid
            // 
            resources.ApplyResources(this.AccountsGrid, "AccountsGrid");
            this.AccountsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountsGrid.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AccountsGrid.LinkColor = System.Drawing.Color.White;
            this.AccountsGrid.Name = "AccountsGrid";
            this.AccountsGrid.TabStop = true;
            this.AccountsGrid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountsGrid_LinkClicked);
            // 
            // ForumNews
            // 
            resources.ApplyResources(this.ForumNews, "ForumNews");
            this.ForumNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForumNews.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ForumNews.LinkColor = System.Drawing.Color.White;
            this.ForumNews.Name = "ForumNews";
            this.ForumNews.TabStop = true;
            this.ForumNews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForumNews_LinkClicked);
            // 
            // NewAccountsRegistred
            // 
            resources.ApplyResources(this.NewAccountsRegistred, "NewAccountsRegistred");
            this.NewAccountsRegistred.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewAccountsRegistred.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NewAccountsRegistred.LinkColor = System.Drawing.Color.White;
            this.NewAccountsRegistred.Name = "NewAccountsRegistred";
            this.NewAccountsRegistred.TabStop = true;
            this.NewAccountsRegistred.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccountsRegistred_LinkClicked);
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AdminPanelButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AdminPanelButton, "AdminPanelButton");
            this.AdminPanelButton.ForeColor = System.Drawing.Color.White;
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.UseVisualStyleBackColor = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // MainMenuPanel
            // 
            resources.ApplyResources(this.MainMenuPanel, "MainMenuPanel");
            this.MainMenuPanel.Controls.Add(this.MainMenu);
            this.MainMenuPanel.Name = "MainMenuPanel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.MainForumMenu);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.AdminPanelButton);
            this.Controls.Add(this.MyAccount);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainForumMenu.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetTrainingToolStripMenuItem;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ToolStripComboBox ChooseLanguageStrip;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        private System.Windows.Forms.Panel MainForumMenu;
        private System.Windows.Forms.LinkLabel newQuestionLink;
        private System.Windows.Forms.LinkLabel ForumNews;
        private System.Windows.Forms.LinkLabel NewAccountsRegistred;
        private System.Windows.Forms.Button MyAccount;
        private System.Windows.Forms.LinkLabel AccountsGrid;
        private System.Windows.Forms.Button AdminPanelButton;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}