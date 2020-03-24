using ProgramForum.Panels;
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
    public partial class ThemeRedactor : Form
    {
        public ThemeRedactor()
        {
            InitializeComponent();
            Redactor.ThemeRedactorSessionForm = this;
        }

        private void ThemeRedactor_Load(object sender, EventArgs e)
        {
            // Все темы
            Cycle(ThemeLayoutPanel, true);
            // Неотредактированные темы
            Cycle(OnRedactorThemeLayoutPanel2, false);
        }

        private void Cycle(FlowLayoutPanel panel, bool visible)
        {
            using (ForumContainer container = new ForumContainer()) {
                foreach (var thm in container.ThemeSet.Where(x => x.Visible == visible)) {
                    var author = container.AccountSet.FirstOrDefault(x => x.AccountId == thm.AuthorId);
                    SimpleTheme smpPan = new SimpleTheme(thm, author.Name.TrimEnd());
                    smpPan.SetClick(OnRedactionClick);
                    panel.Controls.Add(smpPan);
                }
            }
        }

        private void OnRedactionClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var theme = (SimpleTheme)button.Parent;
            Redactor redactor = new Redactor(theme.Theme);
            redactor.ShowDialog();
        }

        public void UpdateForm()
        {
            ThemeLayoutPanel.Controls.Clear();
            Cycle(ThemeLayoutPanel, true);

            OnRedactorThemeLayoutPanel2.Controls.Clear();
            Cycle(OnRedactorThemeLayoutPanel2, false);
        }
    }
}
