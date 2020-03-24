using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Forms
{
    public partial class Redactor : Form
    {
        public static ThemeRedactor ThemeRedactorSessionForm;

        private ThemeSet Theme;
        public Redactor(ThemeSet theme)
        {
            Theme = theme;
            InitializeComponent();

            ThemeName.Text = Theme.ThemeName;
            ThemeText.Text = Theme.ThemeText;
        }

        private void AddToForum_Click(object sender, EventArgs e)
        {
            using(ForumContainer container = new ForumContainer())
            {
                container.ThemeSet.FirstOrDefault(x => x.ThemeId == Theme.ThemeId).Visible = true;
                container.SaveChanges();
                MessageBox.Show("Тема была успешно добавлена на форум");
                ThemeRedactorSessionForm.UpdateForm();
                Close();
            }
        }

        private void CloseTheme_Click(object sender, EventArgs e)
        {
            using (ForumContainer container = new ForumContainer())
            {
                container.ThemeSet.FirstOrDefault(x => x.ThemeId == Theme.ThemeId).Visible = false;
                container.SaveChanges();
                MessageBox.Show("Тема была успешно скрыта");
                ThemeRedactorSessionForm.UpdateForm();
                Close();
            }
        }

        private void SaveTheme_Click(object sender, EventArgs e)
        {
            using (ForumContainer container = new ForumContainer())
            {
                var ourtheme = container.ThemeSet.FirstOrDefault(x => x.ThemeId == Theme.ThemeId);
                ourtheme.ThemeName = ThemeName.Text;
                ourtheme.ThemeText = ThemeText.Text;
                container.SaveChanges();
                MessageBox.Show("Тема была успешно сохранена");
                ThemeRedactorSessionForm.UpdateForm();
                Close();
            }
        }
    }
}
