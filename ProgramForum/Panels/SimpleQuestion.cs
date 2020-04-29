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
    public partial class SimpleQuestion : UserControl
    {
        private QuestionSet QuestionSet;    // Объект вопроса
        private IQuestionType QuestType;

        public SimpleQuestion(QuestionSet questionSet)
        {
            InitializeComponent();
            QuestionSet = questionSet;
            QuestionLabel.Text = QuestionSet.QuestionText;

            QuestionTypes.QuestionPanel = QuestionPanel;
            QuestType = QuestionTypes.GetQuestionType(QuestionSet);
            var question = QuestType.getUserControl();
            QuestionTypes.SetQuest(question, QuestionSet);

            QuestionPanel.Controls.Add(question);
        }

        public SimpleQuestion(Size size, QuestionSet questionSet)
        {
            InitializeComponent();

            this.Size = size;

            QuestionSet = questionSet;
            QuestionLabel.Text = QuestionSet.QuestionText;

            QuestionTypes.QuestionPanel = QuestionPanel;
            QuestType = QuestionTypes.GetQuestionType(QuestionSet);
            var question = QuestType.getUserControl();
            QuestionTypes.SetQuest(question, QuestionSet);

            QuestionPanel.Controls.Add(question);
        }
    }
}
