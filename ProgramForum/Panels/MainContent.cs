﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels
{
    public partial class MainContent : UserControl
    {        
        public MainContent(EventHandler addNewTheme_Click)
        {
            InitializeComponent();
            AddNewTheme.Click += addNewTheme_Click;
        }

        private void MainContent_Load(object sender, EventArgs e)
        {
            using (ForumContainer container = new ForumContainer())
            {
                // ThemeLoading
                if (container.ThemeSet.Count() > 0)
                {
                    int i = 0;
                    var TryThemeList = container.ThemeSet.Where(x => x.Visible == true).ToList();
                     
                    foreach (ThemeSet theme in TryThemeList.OrderByDescending(t => t.CreateDate))
                    {
                        Content.Theme.SingleTheme singleTheme = new Content.Theme.SingleTheme(theme)
                        {
                            Location = new Point(3, 3),
                            Anchor = AnchorStyles.Left | AnchorStyles.Right
                        };
                        singleTheme.SetClick_ReadTheme(SetClick_ForSingleTheme);

                        LastThemePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, singleTheme.Height));
                        LastThemePanel.RowCount++;

                        LastThemePanel.Controls.Add(singleTheme, 0, i);
                        i++;
                    }
                }
            }
        }

        private void SetClick_ForSingleTheme(object sender, EventArgs eventArgs)
        {
            var childButton = (Button)sender;
            var panel = (Panel)childButton.Parent;
            var theme = (Content.Theme.SingleTheme)panel.Parent;
            Content.ThemeControl newTheme = new Content.ThemeControl(theme.Theme) 
            { 
                Name = "VisibleTheme",
                Dock = DockStyle.Fill 
            };
            MainPanel.Visible = false;
            TrainingPanel.Visible = false;
            ThemePanel.Controls.Add(newTheme);
        }

        public void CloseMainPanel(object sender, EventArgs eventArgs)
        {
            var visibleTheme = MainPanel.Controls.Find("VisibleTheme", false).First();
            MainPanel.Controls.Remove(visibleTheme);
        }

        private void ContinueTraining_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            ThemePanel.Visible = false;
            TrainingPanel.Controls.Add(new Training.AccountStartedTrainingsList() { Name = "VisibleTraining", Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right });
        }
    }
}
