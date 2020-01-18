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
    public partial class QuestionType3 : UserControl
    {
        public QuestionType3()
        {
            InitializeComponent();
        }

        private void SelectWords_Click(object sender, EventArgs e)
        {
            QuestionType3Form form = new QuestionType3Form(SelectableCode.Text);
            form.Show();
        }
    }
}
