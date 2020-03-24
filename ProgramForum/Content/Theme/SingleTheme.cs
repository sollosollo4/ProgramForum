using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.Theme
{
    public partial class SingleTheme : UserControl
    {
        public ThemeSet Theme;
        public SingleTheme(ThemeSet theme)
        {
            InitializeComponent();
            Theme = theme;

            using (ForumContainer container = new ForumContainer())
            {
                var account = container.AccountSet.SingleOrDefault(x => x.AccountId == Theme.AuthorId);
                ThemeAuthor.Text = "Автор: " + account.Name.TrimEnd();
                ThemeAuthor.Text += "\n" + Theme.CreateDate;
                CommentoryCount.Text += "  " + container.CommentorySet.Where(x => x.ThemeId == Theme.ThemeId).ToList().Count;
            }
            ThemeName.Text = Theme.ThemeName;
            ThemeStartText.Text = Theme.ThemeText;
        }

        public void SetClick_ReadTheme(EventHandler click)
        {
            ReadTheme.Click += click;
        }
    }
}
