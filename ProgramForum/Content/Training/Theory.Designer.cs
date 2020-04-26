namespace ProgramForum.Content.Training
{
    partial class Theory
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
            this.TheoryLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TheoryLabel
            // 
            this.TheoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TheoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheoryLabel.Location = new System.Drawing.Point(3, 3);
            this.TheoryLabel.Name = "TheoryLabel";
            this.TheoryLabel.Size = new System.Drawing.Size(134, 19);
            this.TheoryLabel.TabIndex = 1;
            this.TheoryLabel.Text = "Заголовок теории";
            this.TheoryLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TheoryLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Theory";
            this.Size = new System.Drawing.Size(138, 63);
            this.Click += new System.EventHandler(this.Theory_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TheoryLabel;
    }
}
