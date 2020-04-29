namespace ProgramForum.Panels.Training
{
    partial class TheoryControl
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
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.CodePanel = new System.Windows.Forms.Panel();
            this.GoNext = new System.Windows.Forms.Button();
            this.TryAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPanel.Location = new System.Drawing.Point(4, 4);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(443, 291);
            this.QuestionPanel.TabIndex = 0;
            // 
            // LabelPanel
            // 
            this.LabelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPanel.Location = new System.Drawing.Point(4, 4);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(443, 99);
            this.LabelPanel.TabIndex = 0;
            // 
            // CodePanel
            // 
            this.CodePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodePanel.Location = new System.Drawing.Point(4, 109);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(443, 100);
            this.CodePanel.TabIndex = 0;
            // 
            // GoNext
            // 
            this.GoNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoNext.AutoSize = true;
            this.GoNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GoNext.FlatAppearance.BorderSize = 0;
            this.GoNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GoNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoNext.Location = new System.Drawing.Point(341, 301);
            this.GoNext.Name = "GoNext";
            this.GoNext.Size = new System.Drawing.Size(109, 31);
            this.GoNext.TabIndex = 10;
            this.GoNext.Text = "Продолжить";
            this.GoNext.UseVisualStyleBackColor = false;
            this.GoNext.Click += new System.EventHandler(this.GoNext_Click);
            // 
            // TryAnswer
            // 
            this.TryAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TryAnswer.AutoSize = true;
            this.TryAnswer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TryAnswer.FlatAppearance.BorderSize = 0;
            this.TryAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TryAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TryAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TryAnswer.Location = new System.Drawing.Point(358, 301);
            this.TryAnswer.Name = "TryAnswer";
            this.TryAnswer.Size = new System.Drawing.Size(89, 31);
            this.TryAnswer.TabIndex = 10;
            this.TryAnswer.Text = "Ответить";
            this.TryAnswer.UseVisualStyleBackColor = false;
            this.TryAnswer.Visible = false;
            this.TryAnswer.Click += new System.EventHandler(this.TryAnswer_Click);
            // 
            // TheoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TryAnswer);
            this.Controls.Add(this.GoNext);
            this.Controls.Add(this.CodePanel);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.QuestionPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(450, 348);
            this.Name = "TheoryControl";
            this.Size = new System.Drawing.Size(450, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Button GoNext;
        private System.Windows.Forms.Button TryAnswer;
    }
}
