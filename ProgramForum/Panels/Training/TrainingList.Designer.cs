﻿namespace ProgramForum.Panels.Training
{
    partial class TrainingList
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
            this.TrainingListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TrainingListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainingListPanel
            // 
            this.TrainingListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainingListPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TrainingListPanel.Controls.Add(this.TrainingLayoutPanel);
            this.TrainingListPanel.Controls.Add(this.label1);
            this.TrainingListPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingListPanel.Location = new System.Drawing.Point(0, 0);
            this.TrainingListPanel.Name = "TrainingListPanel";
            this.TrainingListPanel.Size = new System.Drawing.Size(450, 348);
            this.TrainingListPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список всех обучений:";
            // 
            // TrainingLayoutPanel
            // 
            this.TrainingLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainingLayoutPanel.AutoScroll = true;
            this.TrainingLayoutPanel.ColumnCount = 1;
            this.TrainingLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrainingLayoutPanel.Location = new System.Drawing.Point(13, 42);
            this.TrainingLayoutPanel.Name = "TrainingLayoutPanel";
            this.TrainingLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TrainingLayoutPanel.RowCount = 1;
            this.TrainingLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrainingLayoutPanel.Size = new System.Drawing.Size(434, 304);
            this.TrainingLayoutPanel.TabIndex = 2;
            // 
            // TrainingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TrainingListPanel);
            this.MinimumSize = new System.Drawing.Size(450, 348);
            this.Name = "TrainingList";
            this.Size = new System.Drawing.Size(450, 348);
            this.TrainingListPanel.ResumeLayout(false);
            this.TrainingListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TrainingListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TrainingLayoutPanel;
    }
}
