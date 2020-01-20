namespace ProgramForum.Content
{
    partial class ThemeControl
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
            this.ThemeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemeName
            // 
            this.ThemeName.AutoSize = true;
            this.ThemeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeName.Location = new System.Drawing.Point(3, 0);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(0, 22);
            this.ThemeName.TabIndex = 0;
            // 
            // ThemeText
            // 
            this.ThemeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemeText.Location = new System.Drawing.Point(0, 36);
            this.ThemeText.Name = "ThemeText";
            this.ThemeText.Size = new System.Drawing.Size(452, 311);
            this.ThemeText.TabIndex = 1;
            // 
            // ThemeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ThemeText);
            this.Controls.Add(this.ThemeName);
            this.Name = "ThemeControl";
            this.Size = new System.Drawing.Size(452, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeName;
        private System.Windows.Forms.Label ThemeText;
    }
}
