namespace ProgramForum.Content.Training
{
    partial class Question
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.QuestionLabel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripQuestionListBox = new System.Windows.Forms.ToolStripComboBox();
            this.AddNewQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(1, 3);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(134, 19);
            this.QuestionLabel.TabIndex = 2;
            this.QuestionLabel.Text = "Заголовок вопроса";
            this.QuestionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.AutoSize = false;
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripQuestionListBox,
            this.AddNewQuestionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(309, 80);
            // 
            // toolStripQuestionListBox
            // 
            this.toolStripQuestionListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripQuestionListBox.Name = "toolStripQuestionListBox";
            this.toolStripQuestionListBox.Size = new System.Drawing.Size(261, 25);
            this.toolStripQuestionListBox.SelectedIndexChanged += new System.EventHandler(this.toolStripQuestionListBox_SelectedIndexChanged);
            // 
            // AddNewQuestionToolStripMenuItem
            // 
            this.AddNewQuestionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewQuestionToolStripMenuItem.Name = "AddNewQuestionToolStripMenuItem";
            this.AddNewQuestionToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.AddNewQuestionToolStripMenuItem.Text = "Добавить новый вопрос";
            this.AddNewQuestionToolStripMenuItem.Click += new System.EventHandler(this.AddNewQuestionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuestionLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Question";
            this.Size = new System.Drawing.Size(136, 61);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripQuestionListBox;
        private System.Windows.Forms.ToolStripMenuItem AddNewQuestionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
