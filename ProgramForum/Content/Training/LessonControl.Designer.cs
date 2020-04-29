namespace ProgramForum.Content.Training
{
    partial class LessonControl
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
            this.LessonPicture = new System.Windows.Forms.PictureBox();
            this.LessonName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LessonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LessonPicture
            // 
            this.LessonPicture.Location = new System.Drawing.Point(22, 47);
            this.LessonPicture.Margin = new System.Windows.Forms.Padding(5);
            this.LessonPicture.Name = "LessonPicture";
            this.LessonPicture.Size = new System.Drawing.Size(100, 100);
            this.LessonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LessonPicture.TabIndex = 0;
            this.LessonPicture.TabStop = false;
            // 
            // LessonName
            // 
            this.LessonName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonName.Location = new System.Drawing.Point(0, 0);
            this.LessonName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LessonName.Name = "LessonName";
            this.LessonName.Size = new System.Drawing.Size(147, 46);
            this.LessonName.TabIndex = 1;
            this.LessonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LessonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LessonName);
            this.Controls.Add(this.LessonPicture);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "LessonControl";
            this.Size = new System.Drawing.Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)(this.LessonPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LessonPicture;
        private System.Windows.Forms.Label LessonName;
    }
}
