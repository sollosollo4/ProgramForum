namespace ProgramForum
{
    partial class AddNewQuestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuestion));
            this.button1 = new System.Windows.Forms.Button();
            this.QuestText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionTypeCollection = new System.Windows.Forms.ComboBox();
            this.questionTypeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forumDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forumDataSet = new ProgramForum.DataSets.ForumDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.languageSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTypeSetTableAdapter = new ProgramForum.DataSets.ForumDataSetTableAdapters.QuestionTypeSetTableAdapter();
            this.languageSetTableAdapter = new ProgramForum.DataSets.ForumDataSetTableAdapters.LanguageSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить вопрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestText
            // 
            this.QuestText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestText.Location = new System.Drawing.Point(12, 33);
            this.QuestText.Multiline = true;
            this.QuestText.Name = "QuestText";
            this.QuestText.Size = new System.Drawing.Size(324, 177);
            this.QuestText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вопрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вопроса";
            // 
            // QuestionTypeCollection
            // 
            this.QuestionTypeCollection.DataSource = this.questionTypeSetBindingSource;
            this.QuestionTypeCollection.DisplayMember = "QuestionTypeText";
            this.QuestionTypeCollection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTypeCollection.FormattingEnabled = true;
            this.QuestionTypeCollection.Location = new System.Drawing.Point(371, 33);
            this.QuestionTypeCollection.Name = "QuestionTypeCollection";
            this.QuestionTypeCollection.Size = new System.Drawing.Size(244, 29);
            this.QuestionTypeCollection.TabIndex = 4;
            this.QuestionTypeCollection.SelectedIndexChanged += new System.EventHandler(this.QuestionTypeCollection_SelectedIndexChanged);
            // 
            // questionTypeSetBindingSource
            // 
            this.questionTypeSetBindingSource.DataMember = "QuestionTypeSet";
            this.questionTypeSetBindingSource.DataSource = this.forumDataSetBindingSource;
            // 
            // forumDataSetBindingSource
            // 
            this.forumDataSetBindingSource.DataSource = this.forumDataSet;
            this.forumDataSetBindingSource.Position = 0;
            // 
            // forumDataSet
            // 
            this.forumDataSet.DataSetName = "ForumDataSet";
            this.forumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(639, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Язык";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DataSource = this.languageSetBindingSource;
            this.LanguageComboBox.DisplayMember = "LanguageName";
            this.LanguageComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(643, 33);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(234, 29);
            this.LanguageComboBox.TabIndex = 5;
            // 
            // languageSetBindingSource
            // 
            this.languageSetBindingSource.DataMember = "LanguageSet";
            this.languageSetBindingSource.DataSource = this.forumDataSetBindingSource;
            // 
            // questionTypeSetTableAdapter
            // 
            this.questionTypeSetTableAdapter.ClearBeforeFill = true;
            // 
            // languageSetTableAdapter
            // 
            this.languageSetTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(888, 325);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.QuestionTypeCollection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestText);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(904, 364);
            this.MinimumSize = new System.Drawing.Size(904, 364);
            this.Name = "AddNewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового вопроса";
            this.Load += new System.EventHandler(this.AddNeQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QuestText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QuestionTypeCollection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.BindingSource forumDataSetBindingSource;
        private DataSets.ForumDataSet forumDataSet;
        private System.Windows.Forms.BindingSource questionTypeSetBindingSource;
        private DataSets.ForumDataSetTableAdapters.QuestionTypeSetTableAdapter questionTypeSetTableAdapter;
        private System.Windows.Forms.BindingSource languageSetBindingSource;
        private DataSets.ForumDataSetTableAdapters.LanguageSetTableAdapter languageSetTableAdapter;
    }
}