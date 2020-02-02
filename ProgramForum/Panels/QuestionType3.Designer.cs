namespace ProgramForum.Panels
{
    partial class QuestionType3
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectableCode = new System.Windows.Forms.TextBox();
            this.SelectWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите целый код без пропущенных ключевых слов, после чего выберите несколько к" +
    "лючевых слов для выбора";
            // 
            // SelectableCode
            // 
            this.SelectableCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectableCode.Location = new System.Drawing.Point(8, 77);
            this.SelectableCode.Multiline = true;
            this.SelectableCode.Name = "SelectableCode";
            this.SelectableCode.Size = new System.Drawing.Size(348, 95);
            this.SelectableCode.TabIndex = 1;
            // 
            // SelectWords
            // 
            this.SelectWords.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectWords.Location = new System.Drawing.Point(362, 77);
            this.SelectWords.Name = "SelectWords";
            this.SelectWords.Size = new System.Drawing.Size(95, 94);
            this.SelectWords.TabIndex = 2;
            this.SelectWords.Text = "Выбрать ключ. слова";
            this.SelectWords.UseVisualStyleBackColor = true;
            this.SelectWords.Click += new System.EventHandler(this.SelectWords_Click);
            // 
            // QuestionType3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectWords);
            this.Controls.Add(this.SelectableCode);
            this.Controls.Add(this.label1);
            this.Name = "QuestionType3";
            this.Size = new System.Drawing.Size(465, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectableCode;
        private System.Windows.Forms.Button SelectWords;
    }
}
