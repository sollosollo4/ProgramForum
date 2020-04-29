using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels
{
    public class RadioButtonQuestionType : IQuestionType
    {
        public QuestionSet Question;
        public bool[] RadioButtons = new bool[4];
        public string[] TextBoxes = new string[4];

        public UserControl getUserControl()
        {
            return new QuestionType0() { Location = new System.Drawing.Point(0, 0) };
        }

        public void setRadioButton(int radId)
        {
            for (int i = 0; i < 4; i++)
                RadioButtons[i] = false;

            RadioButtons[radId] = true;
        }
    }

    public class CheckBoxQuestionType : IQuestionType
    {
        public QuestionSet Question;
        public bool[] CheckBox = new bool[4];
        public string[] TextBoxes = new string[4];

        public UserControl getUserControl()
        {
            return new QuestionType1() { Location = new System.Drawing.Point(0, 0) };
        }
    }

    public interface IQuestionType
    {
        UserControl getUserControl();
    }

    public static  class QuestionTypes
    {
        public static Panel QuestionPanel { get; internal set; }

        public static IQuestionType GetQuestionType(QuestionSet question)
        {
            switch(question.QuestionTypeSet.QuestionTypeId)
            {
                case 1:
                    return new RadioButtonQuestionType();
                case 2:
                    return new CheckBoxQuestionType();
                case 3:
                    return null;
                default:
                    return null;
            }
        }

        public static void SetQuest(UserControl control, QuestionSet quest)
        {
            switch (quest.QuestionTypeSet.QuestionTypeId)
            {
                case 1: {
                    var needControlQuestType0 = (QuestionType0)control;
                    needControlQuestType0.questionType.Question = quest;
                    needControlQuestType0.SetTextBox(quest);
                    needControlQuestType0.SetTextBoxReadOnly(true);
                    needControlQuestType0.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                }
                case 2: {
                    var needControlQuestType1 = (QuestionType1)control;
                    needControlQuestType1.questionType.Question = quest;
                    needControlQuestType1.SetTextBox(quest);
                    needControlQuestType1.SetTextBoxReadOnly(true);
                    needControlQuestType1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                }
            }
        }

        public static void SetQuest(UserControl control, QuestionSet quest, bool readOnly)
        {
            switch (quest.QuestionTypeSet.QuestionTypeId)
            {
                case 1:
                {
                    var needControlQuestType0 = (QuestionType0)control;
                    needControlQuestType0.questionType.Question = quest;
                    needControlQuestType0.SetTextBox(quest);
                    needControlQuestType0.SetTextBoxReadOnly(readOnly);
                    needControlQuestType0.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                }
                case 2:
                {
                    var needControlQuestType1 = (QuestionType1)control;
                    needControlQuestType1.questionType.Question = quest;
                    needControlQuestType1.SetTextBox(quest);
                    needControlQuestType1.SetTextBoxReadOnly(readOnly);
                    needControlQuestType1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                }
            }
        }

        public static bool TryToAnswer(SimpleQuestion currentPanel, QuestionSet currentQuestion)
        {
            switch (currentQuestion.QuestionTypeSet.QuestionTypeId)
            {
                case 1:
                {
                    var needControlQuestType0 = QuestionPanel.Controls.OfType<QuestionType0>().FirstOrDefault();
                    if (needControlQuestType0.questionType.RadioButtons[currentQuestion.CorrectOption])
                        return true;
                    else
                        return false;
                }
                case 2:
                {
                    var needControlQuestType1 = QuestionPanel.Controls.OfType<QuestionType1>().FirstOrDefault();
                    int sum = 0;
                    for(int i=0; i<needControlQuestType1.questionType.CheckBox.Length; i++)
                    {
                        sum += i;
                    }

                    if (sum == currentQuestion.CorrectOption)
                        return true;
                    else
                        return false;
                }
                default:
                    return false;
            }
        }
    }
}
