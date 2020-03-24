using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum
{
    public partial class AddNewQuestion : Form
    {
        public AddNewQuestion()
        {
            InitializeComponent();
        }

        private void AddNeQuestion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forumDataSet.LanguageSet". При необходимости она может быть перемещена или удалена.
            this.languageSetTableAdapter.Fill(this.forumDataSet.LanguageSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forumDataSet.QuestionTypeSet". При необходимости она может быть перемещена или удалена.
            this.questionTypeSetTableAdapter.Fill(this.forumDataSet.QuestionTypeSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forumDataSet.LanguageSet". При необходимости она может быть перемещена или удалена.
            this.languageSetTableAdapter.Fill(this.forumDataSet.LanguageSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forumDataSet.QuestionTypeSet". При необходимости она может быть перемещена или удалена.
            this.questionTypeSetTableAdapter.Fill(this.forumDataSet.QuestionTypeSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forumDataSet.QuestionTypeSet". При необходимости она может быть перемещена или удалена.
            this.questionTypeSetTableAdapter.Fill(this.forumDataSet.QuestionTypeSet);
        }

        private void QuestionTypeCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control obj in Controls)
            {
                if(
                    obj.GetType() == new Panels.QuestionType0().GetType()
                    ||
                    obj.GetType() == new Panels.QuestionType1().GetType()
                    ||
                    obj.GetType() == new Panels.QuestionType3().GetType()
                    )
                Controls.Remove(obj);
            }
            switch(QuestionTypeCollection.SelectedIndex)
            {
                case 0:
                    Panels.QuestionType0 newPanel = new Panels.QuestionType0()
                    {
                        Location = new Point(370, 72)
                    };
                    Controls.Add(newPanel);
                break;
                case 1:
                    Panels.QuestionType1 newPanel1 = new Panels.QuestionType1()
                    {
                        Location = new Point(370, 72)
                    };
                    Controls.Add(newPanel1);
                    break;
                case 2:
                    Panels.QuestionType3 newPanel3 = new Panels.QuestionType3()
                    {
                        Location = new Point(370, 72)
                    };
                    Controls.Add(newPanel3);
                    break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(QuestionTypeCollection.SelectedIndex)
            {
                case 0:
                {
                    Panels.QuestionType0 QuestionPanel = Controls.OfType<Panels.QuestionType0>().Single();
                    int otvetId = 0; // id правильного ответа
                    for (int i = 0; i < 4; i++)
                    {
                        if (QuestionPanel.questionType.RadioButtons[i])
                        {
                            otvetId = i;
                            break;
                        }
                    }
                    using (ForumContainer container = new ForumContainer())
                    {
                        int langId = LanguageComboBox.SelectedIndex + 1;
                        int questTypeId = QuestionTypeCollection.SelectedIndex + 1;

                        QuestionSet setQuest = new QuestionSet()
                        {
                            QuestionText = QuestText.Text,
                            CorrectOption = otvetId,
                            LanguageLanguageId = langId,
                            QuestionTypeQuestionTypeId = questTypeId,
                            AccountAccountId = 0,
                            AccountSet = container.AccountSet.Single(x => x.Login == "admin"),
                            QuestionTypeSet = container.QuestionTypeSet.Single(x => x.QuestionTypeId == questTypeId),
                            LanguageSet = container.LanguageSet.Single(x => x.LanguageId == langId),
                        };

                        container.QuestionSet.Add(setQuest);

                        for (int i = 0; i < 4; i++)
                        {
                            AnswerSet secAnswer = new AnswerSet()
                            {
                                AnswerVarible = QuestionPanel.questionType.TextBoxes[i],
                                QuestionSet = setQuest
                            };
                            container.AnswerSet.Add(secAnswer);
                            container.SaveChanges();
                        }
                        container.SaveChanges();
                    }
                }
                break;
                case 1:
                {
                    Panels.QuestionType1 QuestionPanel = Controls.OfType<Panels.QuestionType1>().Single();
                    string otvetId = ""; // id правильного ответа
                    for (int i = 0; i < 4; i++)
                    {
                        if (QuestionPanel.questionType.CheckBox[i])
                        {
                            otvetId += i;
                        }
                    }
                    using (ForumContainer container = new ForumContainer())
                    {
                        int langId = LanguageComboBox.SelectedIndex + 1;
                        int questTypeId = QuestionTypeCollection.SelectedIndex + 1;

                        QuestionSet setQuest = new QuestionSet()
                        {
                            QuestionText = QuestText.Text,
                            CorrectOption = Convert.ToInt32(otvetId),
                            LanguageLanguageId = langId,
                            QuestionTypeQuestionTypeId = questTypeId,
                            AccountAccountId = 0,
                            AccountSet = container.AccountSet.Single(x => x.Login == "admin"),
                            QuestionTypeSet = container.QuestionTypeSet.Single(x => x.QuestionTypeId == questTypeId),
                            LanguageSet = container.LanguageSet.Single(x => x.LanguageId == langId),
                        };

                        container.QuestionSet.Add(setQuest);

                        for (int i = 0; i < 4; i++)
                        {
                            AnswerSet secAnswer = new AnswerSet()
                            {
                                AnswerVarible = QuestionPanel.questionType.TextBoxes[i],
                                QuestionSet = setQuest
                            };
                            container.AnswerSet.Add(secAnswer);
                            container.SaveChanges();
                        }
                        container.SaveChanges();
                    }
                }
                break;
                case 2:

                break;
                case 3:

                break;
                case 4:

                break;
            }

        }
    }
}
