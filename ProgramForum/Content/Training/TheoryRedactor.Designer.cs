namespace ProgramForum.Content.Training
{
    partial class TheoryRedactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryRedactor));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Element1 = new System.Windows.Forms.Button();
            this.Element2 = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.BlackLine2 = new System.Windows.Forms.PictureBox();
            this.BlackLine4 = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.VisibleTheory = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Так будет выглядеть обучение для пользователей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Панель элементов:";
            // 
            // Element1
            // 
            this.Element1.AutoSize = true;
            this.Element1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Element1.FlatAppearance.BorderSize = 0;
            this.Element1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Element1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Element1.ForeColor = System.Drawing.Color.White;
            this.Element1.Location = new System.Drawing.Point(441, 36);
            this.Element1.Name = "Element1";
            this.Element1.Size = new System.Drawing.Size(175, 32);
            this.Element1.TabIndex = 25;
            this.Element1.Text = "Добавить текст";
            this.Element1.UseVisualStyleBackColor = false;
            this.Element1.Click += new System.EventHandler(this.Element1_Click);
            // 
            // Element2
            // 
            this.Element2.AutoSize = true;
            this.Element2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Element2.FlatAppearance.BorderSize = 0;
            this.Element2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Element2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Element2.ForeColor = System.Drawing.Color.White;
            this.Element2.Location = new System.Drawing.Point(441, 73);
            this.Element2.Name = "Element2";
            this.Element2.Size = new System.Drawing.Size(175, 32);
            this.Element2.TabIndex = 25;
            this.Element2.Text = "Добавить код";
            this.Element2.UseVisualStyleBackColor = false;
            this.Element2.Click += new System.EventHandler(this.Element2_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.AutoSize = true;
            this.SaveChanges.BackColor = System.Drawing.Color.Khaki;
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(748, 598);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(249, 31);
            this.SaveChanges.TabIndex = 31;
            this.SaveChanges.Text = "Завершить работу с теорией";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // BlackLine2
            // 
            this.BlackLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine2.Location = new System.Drawing.Point(429, -317);
            this.BlackLine2.Name = "BlackLine2";
            this.BlackLine2.Size = new System.Drawing.Size(2, 1280);
            this.BlackLine2.TabIndex = 32;
            this.BlackLine2.TabStop = false;
            // 
            // BlackLine4
            // 
            this.BlackLine4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackLine4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLine4.Location = new System.Drawing.Point(-3, 28);
            this.BlackLine4.Name = "BlackLine4";
            this.BlackLine4.Size = new System.Drawing.Size(1100, 2);
            this.BlackLine4.TabIndex = 33;
            this.BlackLine4.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // VisibleTheory
            // 
            this.VisibleTheory.AutoScroll = true;
            this.VisibleTheory.Location = new System.Drawing.Point(6, 37);
            this.VisibleTheory.Name = "VisibleTheory";
            this.VisibleTheory.Size = new System.Drawing.Size(414, 592);
            this.VisibleTheory.TabIndex = 34;
            // 
            // TheoryRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1009, 641);
            this.Controls.Add(this.VisibleTheory);
            this.Controls.Add(this.BlackLine4);
            this.Controls.Add(this.BlackLine2);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Element2);
            this.Controls.Add(this.Element1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1025, 680);
            this.MinimumSize = new System.Drawing.Size(1025, 680);
            this.Name = "TheoryRedactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор теории";
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLine4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Element1;
        private System.Windows.Forms.Button Element2;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.PictureBox BlackLine2;
        private System.Windows.Forms.PictureBox BlackLine4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FlowLayoutPanel VisibleTheory;
    }
}