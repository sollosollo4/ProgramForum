namespace ProgramForum.Panels
{
    partial class SimpleTheme
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
            this.OpenForRedaction = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemeName
            // 
            this.ThemeName.AutoSize = true;
            this.ThemeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeName.Location = new System.Drawing.Point(4, 4);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(0, 21);
            this.ThemeName.TabIndex = 0;
            // 
            // OpenForRedaction
            // 
            this.OpenForRedaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenForRedaction.AutoSize = true;
            this.OpenForRedaction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OpenForRedaction.FlatAppearance.BorderSize = 0;
            this.OpenForRedaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenForRedaction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.OpenForRedaction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OpenForRedaction.Location = new System.Drawing.Point(295, 48);
            this.OpenForRedaction.Name = "OpenForRedaction";
            this.OpenForRedaction.Size = new System.Drawing.Size(187, 29);
            this.OpenForRedaction.TabIndex = 13;
            this.OpenForRedaction.Text = "Открыть для редакции";
            this.OpenForRedaction.UseVisualStyleBackColor = false;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(5, 56);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(47, 15);
            this.Author.TabIndex = 14;
            this.Author.Text = "Автор: ";
            // 
            // SimpleTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Author);
            this.Controls.Add(this.OpenForRedaction);
            this.Controls.Add(this.ThemeName);
            this.Name = "SimpleTheme";
            this.Size = new System.Drawing.Size(485, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeName;
        private System.Windows.Forms.Button OpenForRedaction;
        private System.Windows.Forms.Label Author;
    }
}
