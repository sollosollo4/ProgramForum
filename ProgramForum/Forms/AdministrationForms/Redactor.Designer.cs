namespace ProgramForum.Forms
{
    partial class Redactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redactor));
            this.ThemeText = new System.Windows.Forms.TextBox();
            this.ThemeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveTheme = new System.Windows.Forms.Button();
            this.AddToForum = new System.Windows.Forms.Button();
            this.CloseTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThemeText
            // 
            this.ThemeText.Location = new System.Drawing.Point(12, 93);
            this.ThemeText.Multiline = true;
            this.ThemeText.Name = "ThemeText";
            this.ThemeText.Size = new System.Drawing.Size(780, 396);
            this.ThemeText.TabIndex = 0;
            // 
            // ThemeName
            // 
            this.ThemeName.Location = new System.Drawing.Point(13, 37);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(781, 29);
            this.ThemeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название темы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст темы";
            // 
            // SaveTheme
            // 
            this.SaveTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTheme.AutoSize = true;
            this.SaveTheme.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SaveTheme.FlatAppearance.BorderSize = 0;
            this.SaveTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SaveTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveTheme.Location = new System.Drawing.Point(673, 498);
            this.SaveTheme.Name = "SaveTheme";
            this.SaveTheme.Size = new System.Drawing.Size(119, 29);
            this.SaveTheme.TabIndex = 14;
            this.SaveTheme.Text = "Сохранить";
            this.SaveTheme.UseVisualStyleBackColor = false;
            this.SaveTheme.Click += new System.EventHandler(this.SaveTheme_Click);
            // 
            // AddToForum
            // 
            this.AddToForum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToForum.AutoSize = true;
            this.AddToForum.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddToForum.FlatAppearance.BorderSize = 0;
            this.AddToForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToForum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.AddToForum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddToForum.Location = new System.Drawing.Point(12, 498);
            this.AddToForum.Name = "AddToForum";
            this.AddToForum.Size = new System.Drawing.Size(187, 29);
            this.AddToForum.TabIndex = 14;
            this.AddToForum.Text = "Добавить на форум";
            this.AddToForum.UseVisualStyleBackColor = false;
            this.AddToForum.Click += new System.EventHandler(this.AddToForum_Click);
            // 
            // CloseTheme
            // 
            this.CloseTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTheme.AutoSize = true;
            this.CloseTheme.BackColor = System.Drawing.Color.LightCoral;
            this.CloseTheme.FlatAppearance.BorderSize = 0;
            this.CloseTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CloseTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseTheme.Location = new System.Drawing.Point(205, 498);
            this.CloseTheme.Name = "CloseTheme";
            this.CloseTheme.Size = new System.Drawing.Size(187, 29);
            this.CloseTheme.TabIndex = 14;
            this.CloseTheme.Text = "Закрыть тему";
            this.CloseTheme.UseVisualStyleBackColor = false;
            this.CloseTheme.Click += new System.EventHandler(this.CloseTheme_Click);
            // 
            // Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 534);
            this.Controls.Add(this.CloseTheme);
            this.Controls.Add(this.AddToForum);
            this.Controls.Add(this.SaveTheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeName);
            this.Controls.Add(this.ThemeText);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Redactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThemeText;
        private System.Windows.Forms.TextBox ThemeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveTheme;
        private System.Windows.Forms.Button AddToForum;
        private System.Windows.Forms.Button CloseTheme;
    }
}