namespace ProgramForum.Forms.AdministrationForms
{
    partial class AddNewTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTraining));
            this.ChooseLanguageStrip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TestTrainingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LessonName = new System.Windows.Forms.TextBox();
            this.SelectedElementPanel = new System.Windows.Forms.Panel();
            this.LessonConentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Element3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddElementPicture = new System.Windows.Forms.Button();
            this.ChangeElementColor = new System.Windows.Forms.Button();
            this.ChangeElement = new System.Windows.Forms.Button();
            this.Element2 = new System.Windows.Forms.Button();
            this.Element1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItemDeleteElement = new System.Windows.Forms.ToolStripMenuItem();
            this.BlackLine4 = new System.Windows.Forms.PictureBox();
            this.BlackLine3 = new System.Windows.Forms.PictureBox();
            this.BlackLine2 = new System.Windows.Forms.PictureBox();
            this.BlackLine5 = new System.Windows.Forms.PictureBox();
            this.BlackLine1 = new System.Windows.Forms.PictureBox();
            this.AddTrainingToDb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseLanguageStrip
            // 
            this.ChooseLanguageStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseLanguageStrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseLanguageStrip.FormattingEnabled = true;
            this.ChooseLanguageStrip.Location = new System.Drawing.Point(1077, 10);
            this.ChooseLanguageStrip.Name = "ChooseLanguageStrip";
            this.ChooseLanguageStrip.Size = new System.Drawing.Size(175, 29);
            this.ChooseLanguageStrip.TabIndex = 0;
            this.ChooseLanguageStrip.SelectedIndexChanged += new System.EventHandler(this.ChooseLanguageStrip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите или введите новый язык программирования для составления нового обучения";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AddTrainingToDb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChooseLanguageStrip);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 52);
            this.panel1.TabIndex = 13;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TestTrainingPanel);
            this.MainPanel.Controls.Add(this.BlackLine4);
            this.MainPanel.Controls.Add(this.BlackLine3);
            this.MainPanel.Controls.Add(this.BlackLine2);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.BlackLine1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Location = new System.Drawing.Point(0, 47);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1264, 875);
            this.MainPanel.TabIndex = 14;
            // 
            // TestTrainingPanel
            // 
            this.TestTrainingPanel.Location = new System.Drawing.Point(7, 32);
            this.TestTrainingPanel.Name = "TestTrainingPanel";
            this.TestTrainingPanel.Size = new System.Drawing.Size(412, 837);
            this.TestTrainingPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.SaveChanges);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BlackLine5);
            this.panel2.Controls.Add(this.LessonName);
            this.panel2.Controls.Add(this.SelectedElementPanel);
            this.panel2.Controls.Add(this.LessonConentLayoutPanel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Element3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AddElementPicture);
            this.panel2.Controls.Add(this.ChangeElementColor);
            this.panel2.Controls.Add(this.ChangeElement);
            this.panel2.Controls.Add(this.Element2);
            this.panel2.Controls.Add(this.Element1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(432, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 839);
            this.panel2.TabIndex = 19;
            // 
            // SaveChanges
            // 
            this.SaveChanges.AutoSize = true;
            this.SaveChanges.BackColor = System.Drawing.Color.Khaki;
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(535, 210);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(176, 31);
            this.SaveChanges.TabIndex = 30;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Имя урока:";
            // 
            // LessonName
            // 
            this.LessonName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LessonName.Location = new System.Drawing.Point(535, 121);
            this.LessonName.Name = "LessonName";
            this.LessonName.Size = new System.Drawing.Size(176, 29);
            this.LessonName.TabIndex = 28;
            this.LessonName.TextChanged += new System.EventHandler(this.LessonName_TextChanged);
            // 
            // SelectedElementPanel
            // 
            this.SelectedElementPanel.Location = new System.Drawing.Point(379, 91);
            this.SelectedElementPanel.Name = "SelectedElementPanel";
            this.SelectedElementPanel.Size = new System.Drawing.Size(150, 150);
            this.SelectedElementPanel.TabIndex = 27;
            // 
            // LessonConentLayoutPanel
            // 
            this.LessonConentLayoutPanel.AutoScroll = true;
            this.LessonConentLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LessonConentLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LessonConentLayoutPanel.Location = new System.Drawing.Point(7, 279);
            this.LessonConentLayoutPanel.Name = "LessonConentLayoutPanel";
            this.LessonConentLayoutPanel.Size = new System.Drawing.Size(819, 557);
            this.LessonConentLayoutPanel.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Содержимое элемента:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(817, 88);
            this.label5.TabIndex = 16;
            this.label5.Text = "После добавления элемента, выберите его щёлкнув по нему левой кнопкой мыши. К тем" +
    "ам можно добавлять вопросы.\r\nТак же вы можете изменять форму и цвет элементов, а" +
    " так же добавить картинку.";
            // 
            // Element3
            // 
            this.Element3.AutoSize = true;
            this.Element3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Element3.FlatAppearance.BorderSize = 0;
            this.Element3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Element3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Element3.Location = new System.Drawing.Point(7, 193);
            this.Element3.Name = "Element3";
            this.Element3.Size = new System.Drawing.Size(175, 31);
            this.Element3.TabIndex = 18;
            this.Element3.Text = "Добавить вопрос";
            this.Element3.UseVisualStyleBackColor = false;
            this.Element3.Click += new System.EventHandler(this.Element3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Панель элементов:";
            // 
            // AddElementPicture
            // 
            this.AddElementPicture.AutoSize = true;
            this.AddElementPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddElementPicture.FlatAppearance.BorderSize = 0;
            this.AddElementPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElementPicture.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementPicture.Location = new System.Drawing.Point(198, 193);
            this.AddElementPicture.Name = "AddElementPicture";
            this.AddElementPicture.Size = new System.Drawing.Size(176, 31);
            this.AddElementPicture.TabIndex = 18;
            this.AddElementPicture.Text = "Добавить картинку";
            this.AddElementPicture.UseVisualStyleBackColor = false;
            this.AddElementPicture.Click += new System.EventHandler(this.AddElementPicture_Click);
            // 
            // ChangeElementColor
            // 
            this.ChangeElementColor.AutoSize = true;
            this.ChangeElementColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChangeElementColor.FlatAppearance.BorderSize = 0;
            this.ChangeElementColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeElementColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeElementColor.Location = new System.Drawing.Point(198, 156);
            this.ChangeElementColor.Name = "ChangeElementColor";
            this.ChangeElementColor.Size = new System.Drawing.Size(176, 31);
            this.ChangeElementColor.TabIndex = 18;
            this.ChangeElementColor.Text = "Изменить цвет";
            this.ChangeElementColor.UseVisualStyleBackColor = false;
            this.ChangeElementColor.Click += new System.EventHandler(this.ChangeElementColor_Click);
            // 
            // ChangeElement
            // 
            this.ChangeElement.AutoSize = true;
            this.ChangeElement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChangeElement.FlatAppearance.BorderSize = 0;
            this.ChangeElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeElement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeElement.Location = new System.Drawing.Point(198, 118);
            this.ChangeElement.Name = "ChangeElement";
            this.ChangeElement.Size = new System.Drawing.Size(176, 31);
            this.ChangeElement.TabIndex = 18;
            this.ChangeElement.Text = "Изменить форму";
            this.ChangeElement.UseVisualStyleBackColor = false;
            this.ChangeElement.Click += new System.EventHandler(this.ChangeElement_Click);
            // 
            // Element2
            // 
            this.Element2.AutoSize = true;
            this.Element2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Element2.FlatAppearance.BorderSize = 0;
            this.Element2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Element2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Element2.Location = new System.Drawing.Point(7, 156);
            this.Element2.Name = "Element2";
            this.Element2.Size = new System.Drawing.Size(175, 31);
            this.Element2.TabIndex = 18;
            this.Element2.Text = "Добавить теорию";
            this.Element2.UseVisualStyleBackColor = false;
            this.Element2.Click += new System.EventHandler(this.Element2_Click);
            // 
            // Element1
            // 
            this.Element1.AutoSize = true;
            this.Element1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Element1.FlatAppearance.BorderSize = 0;
            this.Element1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Element1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Element1.Location = new System.Drawing.Point(7, 119);
            this.Element1.Name = "Element1";
            this.Element1.Size = new System.Drawing.Size(175, 31);
            this.Element1.TabIndex = 18;
            this.Element1.Text = "Добавить урок";
            this.Element1.UseVisualStyleBackColor = false;
            this.Element1.Click += new System.EventHandler(this.Element1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Выбранный элемент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Так будет выглядеть обучение для пользователей:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.MediumSpringGreen;
            this.colorDialog.ShowHelp = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemDeleteElement});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // StripMenuItemDeleteElement
            // 
            this.StripMenuItemDeleteElement.Name = "StripMenuItemDeleteElement";
            this.StripMenuItemDeleteElement.Size = new System.Drawing.Size(118, 22);
            this.StripMenuItemDeleteElement.Text = "Удалить";
            this.StripMenuItemDeleteElement.Click += new System.EventHandler(this.StripMenuItemDeleteElement_Click);
            // 
            // BlackLine4
            // 
            this.BlackLine4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine4.Location = new System.Drawing.Point(424, 285);
            this.BlackLine4.Name = "BlackLine4";
            this.BlackLine4.Size = new System.Drawing.Size(1000, 2);
            this.BlackLine4.TabIndex = 23;
            this.BlackLine4.TabStop = false;
            // 
            // BlackLine3
            // 
            this.BlackLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine3.Location = new System.Drawing.Point(424, 105);
            this.BlackLine3.Name = "BlackLine3";
            this.BlackLine3.Size = new System.Drawing.Size(1000, 2);
            this.BlackLine3.TabIndex = 21;
            this.BlackLine3.TabStop = false;
            // 
            // BlackLine2
            // 
            this.BlackLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine2.Location = new System.Drawing.Point(424, 5);
            this.BlackLine2.Name = "BlackLine2";
            this.BlackLine2.Size = new System.Drawing.Size(2, 1280);
            this.BlackLine2.TabIndex = 20;
            this.BlackLine2.TabStop = false;
            // 
            // BlackLine5
            // 
            this.BlackLine5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine5.Location = new System.Drawing.Point(188, 72);
            this.BlackLine5.Name = "BlackLine5";
            this.BlackLine5.Size = new System.Drawing.Size(2, 180);
            this.BlackLine5.TabIndex = 22;
            this.BlackLine5.TabStop = false;
            // 
            // BlackLine1
            // 
            this.BlackLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine1.Location = new System.Drawing.Point(-1, 3);
            this.BlackLine1.Name = "BlackLine1";
            this.BlackLine1.Size = new System.Drawing.Size(1271, 2);
            this.BlackLine1.TabIndex = 14;
            this.BlackLine1.TabStop = false;
            // 
            // AddTrainingToDb
            // 
            this.AddTrainingToDb.AutoSize = true;
            this.AddTrainingToDb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddTrainingToDb.FlatAppearance.BorderSize = 0;
            this.AddTrainingToDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrainingToDb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTrainingToDb.Location = new System.Drawing.Point(957, 10);
            this.AddTrainingToDb.Name = "AddTrainingToDb";
            this.AddTrainingToDb.Size = new System.Drawing.Size(295, 31);
            this.AddTrainingToDb.TabIndex = 30;
            this.AddTrainingToDb.Text = "Добавить обучение в базу данных";
            this.AddTrainingToDb.UseVisualStyleBackColor = false;
            this.AddTrainingToDb.Visible = false;
            this.AddTrainingToDb.Click += new System.EventHandler(this.AddTrainingToDb_Click);
            // 
            // AddNewTraining
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 960);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 90);
            this.Name = "AddNewTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового обучения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewTraining_FormClosing);
            this.Load += new System.EventHandler(this.AddNewTraining_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseLanguageStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BlackLine1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BlackLine2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Element3;
        private System.Windows.Forms.Button Element1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BlackLine3;
        private System.Windows.Forms.Button AddElementPicture;
        private System.Windows.Forms.Button ChangeElementColor;
        private System.Windows.Forms.Button ChangeElement;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Element2;
        private System.Windows.Forms.PictureBox BlackLine4;
        private System.Windows.Forms.PictureBox BlackLine5;
        private System.Windows.Forms.FlowLayoutPanel LessonConentLayoutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel SelectedElementPanel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LessonName;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemDeleteElement;
        private System.Windows.Forms.FlowLayoutPanel TestTrainingPanel;
        private System.Windows.Forms.Button AddTrainingToDb;
    }
}