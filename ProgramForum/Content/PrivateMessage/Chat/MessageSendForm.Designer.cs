namespace ProgramForum.Content.PrivateMessage.Chat
{
    partial class MessageSendForm
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
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.ContainerPMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageBox.Location = new System.Drawing.Point(0, 402);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(414, 59);
            this.MessageBox.TabIndex = 0;
            this.MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
            // 
            // ContainerPMessage
            // 
            this.ContainerPMessage.AutoScroll = true;
            this.ContainerPMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPMessage.Location = new System.Drawing.Point(0, 0);
            this.ContainerPMessage.Name = "ContainerPMessage";
            this.ContainerPMessage.Size = new System.Drawing.Size(414, 402);
            this.ContainerPMessage.TabIndex = 1;
            // 
            // MessageSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 461);
            this.Controls.Add(this.ContainerPMessage);
            this.Controls.Add(this.MessageBox);
            this.MaximumSize = new System.Drawing.Size(430, 500);
            this.Name = "MessageSendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личные сообщения";
            this.Load += new System.EventHandler(this.MessageSendForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.FlowLayoutPanel ContainerPMessage;
    }
}