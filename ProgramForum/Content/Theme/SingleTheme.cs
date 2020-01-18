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

            ThemeName.Text = Theme.ThemeName;
            ThemeStartText.Text = Theme.ThemeText;
        }

        public void SetClick_ReadTheme(EventHandler click)
        {
            ReadTheme.Click += click;
        }
    }
}
