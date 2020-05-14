namespace ProgramForum.Content.Theme
{
    partial class SingleTheme
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
            this.ThemeName = new System.Windows.Forms.Label();
            this.ReadTheme = new System.Windows.Forms.Button();
            this.ThemeStartText = new System.Windows.Forms.Label();
            this.ThemeAuthor = new System.Windows.Forms.Label();
            this.CommentoryCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemeName
            // 
            this.ThemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeName.Location = new System.Drawing.Point(3, 0);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(264, 30);
            this.ThemeName.TabIndex = 0;
            // 
            // ReadTheme
            // 
            this.ReadTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadTheme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ReadTheme.FlatAppearance.BorderSize = 0;
            this.ReadTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTheme.ForeColor = System.Drawing.Color.White;
            this.ReadTheme.Location = new System.Drawing.Point(291, 73);
            this.ReadTheme.Name = "ReadTheme";
            this.ReadTheme.Size = new System.Drawing.Size(123, 29);
            this.ReadTheme.TabIndex = 1;
            this.ReadTheme.Text = "Читать далее";
            this.ReadTheme.UseVisualStyleBackColor = false;
            // 
            // ThemeStartText
            // 
            this.ThemeStartText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeStartText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeStartText.Location = new System.Drawing.Point(3, 30);
            this.ThemeStartText.Name = "ThemeStartText";
            this.ThemeStartText.Size = new System.Drawing.Size(284, 60);
            this.ThemeStartText.TabIndex = 2;
            // 
            // ThemeAuthor
            // 
            this.ThemeAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeAuthor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeAuthor.Location = new System.Drawing.Point(321, 0);
            this.ThemeAuthor.Name = "ThemeAuthor";
            this.ThemeAuthor.Size = new System.Drawing.Size(93, 68);
            this.ThemeAuthor.TabIndex = 3;
            // 
            // CommentoryCount
            // 
            this.CommentoryCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentoryCount.AutoSize = true;
            this.CommentoryCount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentoryCount.Location = new System.Drawing.Point(110, 90);
            this.CommentoryCount.Name = "CommentoryCount";
            this.CommentoryCount.Size = new System.Drawing.Size(157, 15);
            this.CommentoryCount.TabIndex = 4;
            this.CommentoryCount.Text = "Количество комментариев:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ThemeName);
            this.panel1.Controls.Add(this.ThemeAuthor);
            this.panel1.Controls.Add(this.CommentoryCount);
            this.panel1.Controls.Add(this.ReadTheme);
            this.panel1.Controls.Add(this.ThemeStartText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(417, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 105);
            this.panel1.TabIndex = 5;
            // 
            // SingleTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "SingleTheme";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(417, 105);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ThemeName;
        private System.Windows.Forms.Button ReadTheme;
        private System.Windows.Forms.Label ThemeStartText;
        private System.Windows.Forms.Label ThemeAuthor;
        private System.Windows.Forms.Label CommentoryCount;
        private System.Windows.Forms.Panel panel1;
    }
}
