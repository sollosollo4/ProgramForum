namespace ProgramForum.Panels.Training
{
    partial class AccountStartedTrainingsList
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
            this.TrainingLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список обучений которые вы начали:\r\n";
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
            this.TrainingLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TrainingLayoutPanel.Name = "TrainingLayoutPanel";
            this.TrainingLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.TrainingLayoutPanel.RowCount = 1;
            this.TrainingLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrainingLayoutPanel.Size = new System.Drawing.Size(434, 304);
            this.TrainingLayoutPanel.TabIndex = 5;
            // 
            // AccountStartedTrainingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainingLayoutPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(450, 348);
            this.Name = "AccountStartedTrainingsList";
            this.Size = new System.Drawing.Size(450, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TrainingLayoutPanel;
    }
}
