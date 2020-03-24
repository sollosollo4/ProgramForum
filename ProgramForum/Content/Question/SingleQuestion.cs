using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.Question
{
    public partial class SingleQuestion : UserControl
    {
        QuestionSet Question;
        public SingleQuestion(QuestionSet quest)
        {
            Question = quest;
            InitializeComponent();
            QuestionText.Text = Question.QuestionText;
        }
    }
}
