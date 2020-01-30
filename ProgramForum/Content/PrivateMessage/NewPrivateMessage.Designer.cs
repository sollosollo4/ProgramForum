namespace ProgramForum.Content.PrivateMessage
{
    partial class NewPrivateMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPrivateMessage));
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.InitialSenderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageButton.Location = new System.Drawing.Point(16, 221);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(296, 28);
            this.SendMessageButton.TabIndex = 7;
            this.SendMessageButton.Text = "Отправить";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // InitialSenderComboBox
            // 
            this.InitialSenderComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialSenderComboBox.FormattingEnabled = true;
            this.InitialSenderComboBox.Location = new System.Drawing.Point(12, 33);
            this.InitialSenderComboBox.Name = "InitialSenderComboBox";
            this.InitialSenderComboBox.Size = new System.Drawing.Size(300, 29);
            this.InitialSenderComboBox.TabIndex = 8;
            this.InitialSenderComboBox.SelectedIndexChanged += new System.EventHandler(this.InitialSenderComboBox_SelectedIndexChanged);
            this.InitialSenderComboBox.TextChanged += new System.EventHandler(this.InitialSenderComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите логин получателя";
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(12, 69);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(300, 146);
            this.Message.TabIndex = 12;
            // 
            // NewPrivateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitialSenderComboBox);
            this.Controls.Add(this.SendMessageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPrivateMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое сообщение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.ComboBox InitialSenderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message;
    }
}