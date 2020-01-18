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
    public partial class RandomQuestion : UserControl
    {
        public RandomQuestion(QuestionSet questionSet)
        {
            InitializeComponent();
            Panels.SimpleQuestion simpleQuestion = new Panels.SimpleQuestion(questionSet)
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(simpleQuestion);
        }
    }
}
