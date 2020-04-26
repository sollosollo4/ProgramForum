namespace ProgramForum.Content
{
    partial class AddNewTheme
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
            this.NewThemePanel = new System.Windows.Forms.Panel();
            this.SendOnDatebase = new System.Windows.Forms.Button();
            this.ThemeText = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ThemeName = new System.Windows.Forms.TextBox();
            this.NewThemePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewThemePanel
            // 
            this.NewThemePanel.BackColor = System.Drawing.SystemColors.Window;
            this.NewThemePanel.Controls.Add(this.SendOnDatebase);
            this.NewThemePanel.Controls.Add(this.ThemeText);
            this.NewThemePanel.Controls.Add(this.Label1);
            this.NewThemePanel.Controls.Add(this.ThemeName);
            this.NewThemePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewThemePanel.Location = new System.Drawing.Point(0, 0);
            this.NewThemePanel.MinimumSize = new System.Drawing.Size(450, 348);
            this.NewThemePanel.Name = "NewThemePanel";
            this.NewThemePanel.Size = new System.Drawing.Size(450, 348);
            this.NewThemePanel.TabIndex = 15;
            // 
            // SendOnDatebase
            // 
            this.SendOnDatebase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendOnDatebase.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SendOnDatebase.FlatAppearance.BorderSize = 0;
            this.SendOnDatebase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendOnDatebase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendOnDatebase.Location = new System.Drawing.Point(3, 320);
            this.SendOnDatebase.Name = "SendOnDatebase";
            this.SendOnDatebase.Size = new System.Drawing.Size(444, 25);
            this.SendOnDatebase.TabIndex = 19;
            this.SendOnDatebase.Text = "Отправить на редакцию";
            this.SendOnDatebase.UseVisualStyleBackColor = false;
            this.SendOnDatebase.Click += new System.EventHandler(this.SendOnDatebaseButton_Click);
            // 
            // ThemeText
            // 
            this.ThemeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeText.Location = new System.Drawing.Point(3, 82);
            this.ThemeText.Multiline = true;
            this.ThemeText.Name = "ThemeText";
            this.ThemeText.Size = new System.Drawing.Size(444, 232);
            this.ThemeText.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 21);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Имя темы";
            // 
            // ThemeName
            // 
            this.ThemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeName.BackColor = System.Drawing.Color.Cornsilk;
            this.ThemeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeName.Location = new System.Drawing.Point(3, 24);
            this.ThemeName.MaxLength = 55;
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(444, 29);
            this.ThemeName.TabIndex = 15;
            // 
            // AddNewTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewThemePanel);
            this.MinimumSize = new System.Drawing.Size(450, 348);
            this.Name = "AddNewTheme";
            this.Size = new System.Drawing.Size(450, 348);
            this.NewThemePanel.ResumeLayout(false);
            this.NewThemePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NewThemePanel;
        private System.Windows.Forms.Button SendOnDatebase;
        private System.Windows.Forms.TextBox ThemeText;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox ThemeName;
    }
}
