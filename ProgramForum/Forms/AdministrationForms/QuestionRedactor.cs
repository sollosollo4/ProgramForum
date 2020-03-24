using ProgramForum.Panels;
using System;
using System.Collections;
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
    public partial class QuestionRedactor : Form
    {
        private QuestionSet QuestionSet;    // Объект вопроса
        private IQuestionType QuestType;

        private class QSTyps
        {
            public string QuestionText { get; set; }
            public int QuestionId { get; set; }
        }

        public QuestionRedactor()
        {
            InitializeComponent();
        }

        private void QuestionRedactor_Load(object sender, EventArgs e)
        {
            using(ForumContainer container = new ForumContainer()) {
                ArrayList USStates = new ArrayList();
                USStates.AddRange(container.QuestionSet.Select(x => new QSTyps(){ QuestionId = x.QuestionId, QuestionText = x.QuestionText }).ToArray());
                QuestionListBox.DisplayMember = "QuestionText";
                QuestionListBox.ValueMember = "QuestionId";
                QuestionListBox.DataSource = USStates;

                QuestionListBox.SelectedValueChanged +=
                new EventHandler(QuestionListBox_SelectedValueChanged);

                QuestionListBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                QuestionListBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                QuestionListBox.Text = "";
            }
        }

        private void QuestionListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls.OfType<UserControl>().ToList())
                Controls.Remove(ctrl);

            if (QuestionListBox.SelectedIndex != -1)
            {
                using (ForumContainer container = new ForumContainer())
                {
                    var selectedValue = Convert.ToInt32(QuestionListBox.SelectedValue.ToString());
                    QuestionSet = container.QuestionSet.FirstOrDefault(x => x.QuestionId == selectedValue);
                    
                    QuestionLabel.Text = QuestionSet.QuestionText;

                    QuestType = QuestionTypes.GetQuestionType(QuestionSet);
                    var question = QuestType.getUserControl();
                    QuestionTypes.SetQuest(question, QuestionSet, false);

                    Controls.Add(question);
                }
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<QuestionType0>().FirstOrDefault() == null)
                return;

            //if(QuestionSet.QuestionTypeQuestionTypeId == 0)
            var answerVariable0 = Controls.OfType<QuestionType0>().First().
                Controls.OfType<TextBox>().ToList()
                .FirstOrDefault(x => x.Name == "textBox1");

            var answerVariable1 = Controls.OfType<QuestionType0>().First().
                Controls.OfType<TextBox>().ToList()
                .FirstOrDefault(x => x.Name == "textBox2");

            var answerVariable2 = Controls.OfType<QuestionType0>().First().
                Controls.OfType<TextBox>().ToList()
                .FirstOrDefault(x => x.Name == "textBox3");

            var answerVariable3 = Controls.OfType<QuestionType0>().First().
                Controls.OfType<TextBox>().ToList()
                .FirstOrDefault(x => x.Name == "textBox4");

            using(ForumContainer container = new ForumContainer())
            {
                var quest = container.QuestionSet.FirstOrDefault(x => x.QuestionId == QuestionSet.QuestionId);
                var answers = container.AnswerSet.Where(x => x.QuestionQuestionId == quest.QuestionId).ToList();

                answers[0].AnswerVarible = answerVariable0.Text;
                answers[1].AnswerVarible = answerVariable1.Text;
                answers[2].AnswerVarible = answerVariable2.Text;
                answers[3].AnswerVarible = answerVariable3.Text;

                container.SaveChanges();
            }
        }
    }
}
