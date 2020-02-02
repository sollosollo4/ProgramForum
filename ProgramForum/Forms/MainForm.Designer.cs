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
            this.EveryDayTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.newQuestionLink = new System.Windows.Forms.LinkLabel();
            this.MainForumMenu = new System.Windows.Forms.Panel();
            this.AccountsGrid = new System.Windows.Forms.LinkLabel();
            this.ForumNews = new System.Windows.Forms.LinkLabel();
            this.NewAccountsRegistred = new System.Windows.Forms.LinkLabel();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainForumMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackColor = System.Drawing.Color.White;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormToolStripMenuItem,
            this.ChooseLanguageStrip,
            this.RandomQuestionToolStripMenuItem,
            this.EveryDayTestToolStripMenuItem,
            this.MessagesToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            // 
            // MainFormToolStripMenuItem
            // 
            resources.ApplyResources(this.MainFormToolStripMenuItem, "MainFormToolStripMenuItem");
            this.MainFormToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.MainFormToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.MainFormToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.MainFormToolStripMenuItem.Name = "MainFormToolStripMenuItem";
            this.MainFormToolStripMenuItem.Click += new System.EventHandler(this.MainFormToolStripMenuItem_Click);
            // 
            // ChooseLanguageStrip
            // 
            resources.ApplyResources(this.ChooseLanguageStrip, "ChooseLanguageStrip");
            this.ChooseLanguageStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(188)))));
            this.ChooseLanguageStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLanguageStrip.ForeColor = System.Drawing.SystemColors.Window;
            this.ChooseLanguageStrip.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.ChooseLanguageStrip.Name = "ChooseLanguageStrip";
            this.ChooseLanguageStrip.SelectedIndexChanged += new System.EventHandler(this.ChooseLanguageStrip_SelectedIndexChanged);
            // 
            // RandomQuestionToolStripMenuItem
            // 
            resources.ApplyResources(this.RandomQuestionToolStripMenuItem, "RandomQuestionToolStripMenuItem");
            this.RandomQuestionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(64)))));
            this.RandomQuestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.RandomQuestionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.RandomQuestionToolStripMenuItem.Name = "RandomQuestionToolStripMenuItem";
            this.RandomQuestionToolStripMenuItem.Click += new System.EventHandler(this.RandomQuestionToolStripMenuItem_Click);
            // 
            // EveryDayTestToolStripMenuItem
            // 
            resources.ApplyResources(this.EveryDayTestToolStripMenuItem, "EveryDayTestToolStripMenuItem");
            this.EveryDayTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.EveryDayTestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.EveryDayTestToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.EveryDayTestToolStripMenuItem.Name = "EveryDayTestToolStripMenuItem";
            this.EveryDayTestToolStripMenuItem.Click += new System.EventHandler(this.EveryDayTestToolStripMenuItem_Click);
            // 
            // MessagesToolStripMenuItem
            // 
            resources.ApplyResources(this.MessagesToolStripMenuItem, "MessagesToolStripMenuItem");
            this.MessagesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.MessagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.MessagesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.Click += new System.EventHandler(this.MessagesToolStripMenuItem_Click);
            // 
            // MyAccount
            // 
            this.MyAccount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MyAccount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.MyAccount, "MyAccount");
            this.MyAccount.Name = "MyAccount";
            this.MyAccount.UseVisualStyleBackColor = false;
            this.MyAccount.Click += new System.EventHandler(this.MyAccount_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
            this.LanguageLabel.Name = "LanguageLabel";
            // 
            // newQuestionLink
            // 
            resources.ApplyResources(this.newQuestionLink, "newQuestionLink");
            this.newQuestionLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newQuestionLink.Name = "newQuestionLink";
            this.newQuestionLink.TabStop = true;
            // 
            // MainForumMenu
            // 
            resources.ApplyResources(this.MainForumMenu, "MainForumMenu");
            this.MainForumMenu.BackColor = System.Drawing.Color.LightYellow;
            this.MainForumMenu.Controls.Add(this.AccountsGrid);
            this.MainForumMenu.Controls.Add(this.ForumNews);
            this.MainForumMenu.Controls.Add(this.NewAccountsRegistred);
            this.MainForumMenu.Controls.Add(this.newQuestionLink);
            this.MainForumMenu.Name = "MainForumMenu";
            // 
            // AccountsGrid
            // 
            resources.ApplyResources(this.AccountsGrid, "AccountsGrid");
            this.AccountsGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountsGrid.Name = "AccountsGrid";
            this.AccountsGrid.TabStop = true;
            // 
            // ForumNews
            // 
            resources.ApplyResources(this.ForumNews, "ForumNews");
            this.ForumNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForumNews.Name = "ForumNews";
            this.ForumNews.TabStop = true;
            // 
            // NewAccountsRegistred
            // 
            resources.ApplyResources(this.NewAccountsRegistred, "NewAccountsRegistred");
            this.NewAccountsRegistred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewAccountsRegistred.Name = "NewAccountsRegistred";
            this.NewAccountsRegistred.TabStop = true;
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AdminPanelButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AdminPanelButton, "AdminPanelButton");
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.UseVisualStyleBackColor = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainForumMenu);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.AdminPanelButton);
            this.Controls.Add(this.MyAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainForumMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EveryDayTestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}