namespace ProgramForum.Panels
{
    partial class MainContent
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddNewTheme = new System.Windows.Forms.Button();
            this.LastThemePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LastThemesLabel = new System.Windows.Forms.Label();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.ContinueTraining = new System.Windows.Forms.Button();
            this.TrainingPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.ContinueTraining);
            this.MainPanel.Controls.Add(this.AddNewTheme);
            this.MainPanel.Controls.Add(this.LastThemePanel);
            this.MainPanel.Controls.Add(this.LastThemesLabel);
            this.MainPanel.Controls.Add(this.HelloLabel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.MinimumSize = new System.Drawing.Size(450, 348);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(450, 348);
            this.MainPanel.TabIndex = 0;
            // 
            // AddNewTheme
            // 
            this.AddNewTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewTheme.AutoSize = true;
            this.AddNewTheme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddNewTheme.FlatAppearance.BorderSize = 0;
            this.AddNewTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.AddNewTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddNewTheme.Location = new System.Drawing.Point(343, 59);
            this.AddNewTheme.Name = "AddNewTheme";
            this.AddNewTheme.Size = new System.Drawing.Size(104, 31);
            this.AddNewTheme.TabIndex = 9;
            this.AddNewTheme.Text = "Новая тема";
            this.AddNewTheme.UseVisualStyleBackColor = false;
            // 
            // LastThemePanel
            // 
            this.LastThemePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastThemePanel.AutoScroll = true;
            this.LastThemePanel.BackColor = System.Drawing.SystemColors.Window;
            this.LastThemePanel.Location = new System.Drawing.Point(0, 133);
            this.LastThemePanel.MinimumSize = new System.Drawing.Size(450, 213);
            this.LastThemePanel.Name = "LastThemePanel";
            this.LastThemePanel.Size = new System.Drawing.Size(450, 213);
            this.LastThemePanel.TabIndex = 8;
            // 
            // LastThemesLabel
            // 
            this.LastThemesLabel.AutoSize = true;
            this.LastThemesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.LastThemesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LastThemesLabel.Location = new System.Drawing.Point(3, 111);
            this.LastThemesLabel.Name = "LastThemesLabel";
            this.LastThemesLabel.Size = new System.Drawing.Size(237, 19);
            this.LastThemesLabel.TabIndex = 7;
            this.LastThemesLabel.Text = "Последние добавленные темы:";
            // 
            // HelloLabel
            // 
            this.HelloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelloLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.HelloLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HelloLabel.Location = new System.Drawing.Point(0, 2);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(440, 50);
            this.HelloLabel.TabIndex = 6;
            this.HelloLabel.Text = "Добро пожаловать на главную страницу программного форума.\r\n";
            // 
            // ThemePanel
            // 
            this.ThemePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemePanel.Location = new System.Drawing.Point(0, 0);
            this.ThemePanel.MinimumSize = new System.Drawing.Size(450, 348);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(450, 348);
            this.ThemePanel.TabIndex = 10;
            // 
            // ContinueTraining
            // 
            this.ContinueTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueTraining.AutoSize = true;
            this.ContinueTraining.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ContinueTraining.FlatAppearance.BorderSize = 0;
            this.ContinueTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueTraining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ContinueTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContinueTraining.Location = new System.Drawing.Point(268, 96);
            this.ContinueTraining.Name = "ContinueTraining";
            this.ContinueTraining.Size = new System.Drawing.Size(179, 31);
            this.ContinueTraining.TabIndex = 9;
            this.ContinueTraining.Text = "Продолжить обучение";
            this.ContinueTraining.UseVisualStyleBackColor = false;
            this.ContinueTraining.Click += new System.EventHandler(this.ContinueTraining_Click);
            // 
            // TrainingPanel
            // 
            this.TrainingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainingPanel.Location = new System.Drawing.Point(0, 0);
            this.TrainingPanel.MinimumSize = new System.Drawing.Size(450, 348);
            this.TrainingPanel.Name = "TrainingPanel";
            this.TrainingPanel.Size = new System.Drawing.Size(450, 348);
            this.TrainingPanel.TabIndex = 10;
            // 
            // MainContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.TrainingPanel);
            this.MinimumSize = new System.Drawing.Size(450, 348);
            this.Name = "MainContent";
            this.Size = new System.Drawing.Size(450, 348);
            this.Load += new System.EventHandler(this.MainContent_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AddNewTheme;
        private System.Windows.Forms.FlowLayoutPanel LastThemePanel;
        private System.Windows.Forms.Label LastThemesLabel;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.Button ContinueTraining;
        private System.Windows.Forms.Panel TrainingPanel;
    }
}
