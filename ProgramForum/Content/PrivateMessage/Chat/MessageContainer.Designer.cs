namespace ProgramForum.Content.PrivateMessage.Chat
{
    partial class MessageContainer
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
            this.NickName = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(4, 4);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(57, 57);
            this.NickName.TabIndex = 0;
            this.NickName.Text = "NickName";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.Location = new System.Drawing.Point(348, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(52, 64);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.Info;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Location = new System.Drawing.Point(67, 4);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(275, 64);
            this.Message.TabIndex = 1;
            // 
            // MessageContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.NickName);
            this.Name = "MessageContainer";
            this.Size = new System.Drawing.Size(403, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Message;
    }
}
