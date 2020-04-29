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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainingName
            // 
            this.TrainingName.AutoSize = true;
            this.TrainingName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingName.Location = new System.Drawing.Point(3, 7);
            this.TrainingName.Name = "TrainingName";
            this.TrainingName.Size = new System.Drawing.Size(128, 22);
            this.TrainingName.TabIndex = 0;
            this.TrainingName.Text = "TrainingName";
            // 
            // TrainingDescription
            // 
            this.TrainingDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainingDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingDescription.Location = new System.Drawing.Point(3, 42);
            this.TrainingDescription.Name = "TrainingDescription";
            this.TrainingDescription.Size = new System.Drawing.Size(387, 58);
            this.TrainingDescription.TabIndex = 1;
            this.TrainingDescription.Text = "Description";
            // 
            // StartTraining
            // 
            this.StartTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTraining.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartTraining.FlatAppearance.BorderSize = 0;
            this.StartTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTraining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.StartTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartTraining.Location = new System.Drawing.Point(249, 3);
            this.StartTraining.Name = "StartTraining";
            this.StartTraining.Size = new System.Drawing.Size(141, 31);
            this.StartTraining.TabIndex = 2;
            this.StartTraining.Text = "Начать обучение";
            this.StartTraining.UseVisualStyleBackColor = false;
            this.StartTraining.Click += new System.EventHandler(this.StartTraining_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TrainingName);
            this.panel1.Controls.Add(this.StartTraining);
            this.panel1.Controls.Add(this.TrainingDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(393, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 100);
            this.panel1.TabIndex = 3;
            // 
            // SimpleTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MinimumSize = new System.Drawing.Size(393, 100);
            this.Name = "SimpleTraining";
            this.Size = new System.Drawing.Size(391, 98);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TrainingName;
        private System.Windows.Forms.Label TrainingDescription;
        private System.Windows.Forms.Button StartTraining;
        private System.Windows.Forms.Panel panel1;
    }
}
