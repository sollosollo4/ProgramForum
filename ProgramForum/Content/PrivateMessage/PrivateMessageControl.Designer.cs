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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pmFlowLoyoutPanel
            // 
            this.pmFlowLoyoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pmFlowLoyoutPanel.AutoScroll = true;
            this.pmFlowLoyoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pmFlowLoyoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pmFlowLoyoutPanel.Location = new System.Drawing.Point(3, 40);
            this.pmFlowLoyoutPanel.Name = "pmFlowLoyoutPanel";
            this.pmFlowLoyoutPanel.Size = new System.Drawing.Size(446, 304);
            this.pmFlowLoyoutPanel.TabIndex = 0;
            // 
            // NewMessage
            // 
            this.NewMessage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewMessage.FlatAppearance.BorderSize = 0;
            this.NewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.NewMessage.ForeColor = System.Drawing.Color.White;
            this.NewMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewMessage.Location = new System.Drawing.Point(3, 3);
            this.NewMessage.Name = "NewMessage";
            this.NewMessage.Size = new System.Drawing.Size(143, 31);
            this.NewMessage.TabIndex = 2;
            this.NewMessage.Text = "Новое сообщение";
            this.NewMessage.UseVisualStyleBackColor = false;
            this.NewMessage.Click += new System.EventHandler(this.NewMessage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.NewMessage);
            this.panel1.Controls.Add(this.pmFlowLoyoutPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 347);
            this.panel1.TabIndex = 3;
            // 
            // PrivateMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(452, 347);
            this.Name = "PrivateMessageControl";
            this.Size = new System.Drawing.Size(452, 347);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pmFlowLoyoutPanel;
        private System.Windows.Forms.Button NewMessage;
        private System.Windows.Forms.Panel panel1;
    }
}
