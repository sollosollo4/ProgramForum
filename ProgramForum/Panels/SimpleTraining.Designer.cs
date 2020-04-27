namespace ProgramForum.Panels
{
    partial class SimpleTraining
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
            this.TrainingName = new System.Windows.Forms.Label();
            this.TrainingDescription = new System.Windows.Forms.Label();
            this.StartTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainingName
            // 
            this.TrainingName.AutoSize = true;
            this.TrainingName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingName.Location = new System.Drawing.Point(4, 4);
            this.TrainingName.Name = "TrainingName";
            this.TrainingName.Size = new System.Drawing.Size(128, 22);
            this.TrainingName.TabIndex = 0;
            this.TrainingName.Text = "TrainingName";
            // 
            // TrainingDescription
            // 
            this.TrainingDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingDescription.Location = new System.Drawing.Point(4, 46);
            this.TrainingDescription.Name = "TrainingDescription";
            this.TrainingDescription.Size = new System.Drawing.Size(388, 54);
            this.TrainingDescription.TabIndex = 1;
            this.TrainingDescription.Text = "Description";
            // 
            // StartTraining
            // 
            this.StartTraining.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartTraining.FlatAppearance.BorderSize = 0;
            this.StartTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTraining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.StartTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartTraining.Location = new System.Drawing.Point(251, 3);
            this.StartTraining.Name = "StartTraining";
            this.StartTraining.Size = new System.Drawing.Size(141, 31);
            this.StartTraining.TabIndex = 2;
            this.StartTraining.Text = "Начать обучение";
            this.StartTraining.UseVisualStyleBackColor = false;
            this.StartTraining.Click += new System.EventHandler(this.StartTraining_Click);
            // 
            // SimpleTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.StartTraining);
            this.Controls.Add(this.TrainingDescription);
            this.Controls.Add(this.TrainingName);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SimpleTraining";
            this.Size = new System.Drawing.Size(395, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainingName;
        private System.Windows.Forms.Label TrainingDescription;
        private System.Windows.Forms.Button StartTraining;
    }
}
