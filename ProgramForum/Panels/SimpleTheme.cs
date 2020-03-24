using System;
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
    public partial class SimpleTheme : UserControl
    {
        public ThemeSet Theme;
        public void SetClick(EventHandler RedactionButtonClick) { OpenForRedaction.Click += RedactionButtonClick; }
        public SimpleTheme(ThemeSet theme, string AuthorName)
        {
            InitializeComponent();
            Theme = theme;

            ThemeName.Text = Theme.ThemeName;
            Author.Text += " " + AuthorName;
        }
    }
}
