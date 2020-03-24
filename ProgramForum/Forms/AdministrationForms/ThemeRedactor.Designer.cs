namespace ProgramForum.Forms
{
    partial class ThemeRedactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeRedactor));
            this.ThemeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ThemeComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OnRedactorThemeLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OnRedactionThemeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemeLayoutPanel
            // 
            this.ThemeLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeLayoutPanel.AutoScroll = true;
            this.ThemeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ThemeLayoutPanel.Location = new System.Drawing.Point(3, 68);
            this.ThemeLayoutPanel.MinimumSize = new System.Drawing.Size(240, 488);
            this.ThemeLayoutPanel.Name = "ThemeLayoutPanel";
            this.ThemeLayoutPanel.Size = new System.Drawing.Size(245, 488);
            this.ThemeLayoutPanel.TabIndex = 13;
            // 
            // ThemeComboBoxSearch
            // 
            this.ThemeComboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeComboBoxSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeComboBoxSearch.FormattingEnabled = true;
            this.ThemeComboBoxSearch.Location = new System.Drawing.Point(3, 33);
            this.ThemeComboBoxSearch.MinimumSize = new System.Drawing.Size(240, 0);
            this.ThemeComboBoxSearch.Name = "ThemeComboBoxSearch";
            this.ThemeComboBoxSearch.Size = new System.Drawing.Size(245, 29);
            this.ThemeComboBoxSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск по названию темы:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(251, -18);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(3, 590);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(3, 590);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 590);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ThemeComboBoxSearch);
            this.panel1.Controls.Add(this.ThemeLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(226, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 559);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Список тем на редакции:";
            // 
            // OnRedactorThemeLayoutPanel2
            // 
            this.OnRedactorThemeLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnRedactorThemeLayoutPanel2.AutoScroll = true;
            this.OnRedactorThemeLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OnRedactorThemeLayoutPanel2.Location = new System.Drawing.Point(0, 67);
            this.OnRedactorThemeLayoutPanel2.Name = "OnRedactorThemeLayoutPanel2";
            this.OnRedactorThemeLayoutPanel2.Size = new System.Drawing.Size(497, 492);
            this.OnRedactorThemeLayoutPanel2.TabIndex = 16;
            // 
            // OnRedactionThemeComboBox
            // 
            this.OnRedactionThemeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnRedactionThemeComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnRedactionThemeComboBox.FormattingEnabled = true;
            this.OnRedactionThemeComboBox.Location = new System.Drawing.Point(7, 32);
            this.OnRedactionThemeComboBox.MinimumSize = new System.Drawing.Size(240, 0);
            this.OnRedactionThemeComboBox.Name = "OnRedactionThemeComboBox";
            this.OnRedactionThemeComboBox.Size = new System.Drawing.Size(241, 29);
            this.OnRedactionThemeComboBox.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.OnRedactorThemeLayoutPanel2);
            this.panel2.Controls.Add(this.OnRedactionThemeComboBox);
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(500, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 560);
            this.panel2.TabIndex = 17;
            // 
            // ThemeRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 598);
            this.MinimumSize = new System.Drawing.Size(770, 598);
            this.Name = "ThemeRedactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор тем";
            this.Load += new System.EventHandler(this.ThemeRedactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ThemeLayoutPanel;
        private System.Windows.Forms.ComboBox ThemeComboBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel OnRedactorThemeLayoutPanel2;
        private System.Windows.Forms.ComboBox OnRedactionThemeComboBox;
        private System.Windows.Forms.Panel panel2;
    }
}