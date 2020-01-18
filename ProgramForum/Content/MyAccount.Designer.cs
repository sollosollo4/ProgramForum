﻿namespace ProgramForum.Content
{
    partial class MyAccount
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ChangePassword = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SaveAllChanges = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.CreateDatelabel = new System.Windows.Forms.Label();
            this.AccountPoints = new System.Windows.Forms.Label();
            this.AccountStatus = new System.Windows.Forms.Label();
            this.AccountReputation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(3, 22);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.ReadOnly = true;
            this.LoginTextBox.Size = new System.Drawing.Size(192, 29);
            this.LoginTextBox.TabIndex = 0;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassword.Location = new System.Drawing.Point(3, 187);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(134, 19);
            this.ChangePassword.TabIndex = 1;
            this.ChangePassword.Text = "Изменить пароль";
            // 
            // OldPassword
            // 
            this.OldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OldPassword.AutoSize = true;
            this.OldPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPassword.Location = new System.Drawing.Point(12, 206);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(114, 18);
            this.OldPassword.TabIndex = 1;
            this.OldPassword.Text = "Старый пароль";
            // 
            // NewPassword
            // 
            this.NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassword.Location = new System.Drawing.Point(12, 260);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(102, 18);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "Новый пароль";
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OldPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordTextBox.Location = new System.Drawing.Point(16, 228);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.PasswordChar = '*';
            this.OldPasswordTextBox.Size = new System.Drawing.Size(192, 29);
            this.OldPasswordTextBox.TabIndex = 0;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(16, 281);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(192, 29);
            this.NewPasswordTextBox.TabIndex = 0;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(97, 316);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(111, 28);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // SaveAllChanges
            // 
            this.SaveAllChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAllChanges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAllChanges.Location = new System.Drawing.Point(270, 315);
            this.SaveAllChanges.Name = "SaveAllChanges";
            this.SaveAllChanges.Size = new System.Drawing.Size(179, 29);
            this.SaveAllChanges.TabIndex = 2;
            this.SaveAllChanges.Text = "Сохранить изменения";
            this.SaveAllChanges.UseVisualStyleBackColor = true;
            this.SaveAllChanges.Click += new System.EventHandler(this.SaveAllChanges_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(3, 76);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(192, 29);
            this.EmailTextBox.TabIndex = 0;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(-1, 54);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(151, 19);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Привязанная почта";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(54, 19);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // CreateDatelabel
            // 
            this.CreateDatelabel.AutoSize = true;
            this.CreateDatelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDatelabel.Location = new System.Drawing.Point(3, 117);
            this.CreateDatelabel.Name = "CreateDatelabel";
            this.CreateDatelabel.Size = new System.Drawing.Size(187, 19);
            this.CreateDatelabel.TabIndex = 1;
            this.CreateDatelabel.Text = "Дата создания аккаунта:";
            // 
            // AccountPoints
            // 
            this.AccountPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountPoints.AutoSize = true;
            this.AccountPoints.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountPoints.Location = new System.Drawing.Point(200, 0);
            this.AccountPoints.Name = "AccountPoints";
            this.AccountPoints.Size = new System.Drawing.Size(155, 19);
            this.AccountPoints.TabIndex = 1;
            this.AccountPoints.Text = "Накопленные очки:";
            // 
            // AccountStatus
            // 
            this.AccountStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountStatus.AutoSize = true;
            this.AccountStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountStatus.Location = new System.Drawing.Point(200, 54);
            this.AccountStatus.Name = "AccountStatus";
            this.AccountStatus.Size = new System.Drawing.Size(134, 19);
            this.AccountStatus.TabIndex = 1;
            this.AccountStatus.Text = "Статус аккаунта:";
            // 
            // AccountReputation
            // 
            this.AccountReputation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountReputation.AutoSize = true;
            this.AccountReputation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountReputation.Location = new System.Drawing.Point(200, 151);
            this.AccountReputation.Name = "AccountReputation";
            this.AccountReputation.Size = new System.Drawing.Size(91, 19);
            this.AccountReputation.TabIndex = 1;
            this.AccountReputation.Text = "Репутация:";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveAllChanges);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.AccountReputation);
            this.Controls.Add(this.AccountStatus);
            this.Controls.Add(this.AccountPoints);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.CreateDatelabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "MyAccount";
            this.Size = new System.Drawing.Size(452, 347);
            this.VisibleChanged += new System.EventHandler(this.MyAccount_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label ChangePassword;
        private System.Windows.Forms.Label OldPassword;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button SaveAllChanges;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label CreateDatelabel;
        private System.Windows.Forms.Label AccountPoints;
        private System.Windows.Forms.Label AccountStatus;
        private System.Windows.Forms.Label AccountReputation;
    }
}
