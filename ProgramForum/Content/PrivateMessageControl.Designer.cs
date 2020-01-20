namespace ProgramForum.Content
{
    partial class PrivateMessageControl
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
            this.pmFlowLoyoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pmFlowLoyoutPanel
            // 
            this.pmFlowLoyoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmFlowLoyoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pmFlowLoyoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pmFlowLoyoutPanel.Name = "pmFlowLoyoutPanel";
            this.pmFlowLoyoutPanel.Size = new System.Drawing.Size(452, 347);
            this.pmFlowLoyoutPanel.TabIndex = 0;
            // 
            // PrivateMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pmFlowLoyoutPanel);
            this.MinimumSize = new System.Drawing.Size(452, 347);
            this.Name = "PrivateMessageControl";
            this.Size = new System.Drawing.Size(452, 347);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pmFlowLoyoutPanel;
    }
}
