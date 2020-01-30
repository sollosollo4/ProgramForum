namespace ProgramForum.Content.PrivateMessage
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
            this.NewMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pmFlowLoyoutPanel
            // 
            this.pmFlowLoyoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pmFlowLoyoutPanel.Location = new System.Drawing.Point(0, 40);
            this.pmFlowLoyoutPanel.Name = "pmFlowLoyoutPanel";
            this.pmFlowLoyoutPanel.Size = new System.Drawing.Size(452, 307);
            this.pmFlowLoyoutPanel.TabIndex = 0;
            // 
            // NewMessage
            // 
            this.NewMessage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NewMessage.FlatAppearance.BorderSize = 0;
            this.NewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.NewMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewMessage.Location = new System.Drawing.Point(3, 3);
            this.NewMessage.Name = "NewMessage";
            this.NewMessage.Size = new System.Drawing.Size(143, 31);
            this.NewMessage.TabIndex = 2;
            this.NewMessage.Text = "Новое сообщение";
            this.NewMessage.UseVisualStyleBackColor = false;
            this.NewMessage.Click += new System.EventHandler(this.NewMessage_Click);
            // 
            // PrivateMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewMessage);
            this.Controls.Add(this.pmFlowLoyoutPanel);
            this.MinimumSize = new System.Drawing.Size(452, 347);
            this.Name = "PrivateMessageControl";
            this.Size = new System.Drawing.Size(452, 347);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pmFlowLoyoutPanel;
        private System.Windows.Forms.Button NewMessage;
    }
}
