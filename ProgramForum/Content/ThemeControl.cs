using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content
{
    public partial class ThemeControl : UserControl
    {
        private ThemeSet Theme;
        public ThemeControl(ThemeSet theme)
        {
            Theme = theme;
            InitializeComponent();

            ThemeName.Text = theme.ThemeName;
            ThemeText.Text = theme.ThemeText;
        }
    }
}
