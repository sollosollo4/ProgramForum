using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.Training
{
    public partial class Theory : UserControl
    {
        public TheoryLessonSet TheoryLessonSet;
        public int Position;
        public int LessonSetId;
        public Theory()
        {
            InitializeComponent();
        }

        private void Theory_Click(object sender, EventArgs e)
        {
            TheoryRedactor redactor = new TheoryRedactor(this);
            redactor.ShowDialog();
        }
    }
}
