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
            this.SuspendLayout();
            // 
            // ThemeName
            // 
            this.ThemeName.AutoSize = true;
            this.ThemeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeName.Location = new System.Drawing.Point(4, 4);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(0, 22);
            this.ThemeName.TabIndex = 0;
            // 
            // ReadTheme
            // 
            this.ReadTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTheme.Location = new System.Drawing.Point(280, 75);
            this.ReadTheme.Name = "ReadTheme";
            this.ReadTheme.Size = new System.Drawing.Size(123, 29);
            this.ReadTheme.TabIndex = 1;
            this.ReadTheme.Text = "Читать далее";
            this.ReadTheme.UseVisualStyleBackColor = true;
            // 
            // ThemeStartText
            // 
            this.ThemeStartText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeStartText.Location = new System.Drawing.Point(3, 26);
            this.ThemeStartText.Name = "ThemeStartText";
            this.ThemeStartText.Size = new System.Drawing.Size(271, 78);
            this.ThemeStartText.TabIndex = 2;
            // 
            // SingleTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThemeStartText);
            this.Controls.Add(this.ReadTheme);
            this.Controls.Add(this.ThemeName);
            this.Name = "SingleTheme";
            this.Size = new System.Drawing.Size(406, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeName;
        private System.Windows.Forms.Button ReadTheme;
        private System.Windows.Forms.Label ThemeStartText;
    }
}
