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
    public partial class Question : UserControl
    {
        public LanguageSet language;
        public QuestionSet QuestionSet;
        public int Position { get; set; }

        public Question(LanguageSet language)
        {
            this.language = language;
            InitializeComponent();

            toolStripQuestionListBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripQuestionListBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            

            using (ForumContainer container = new ForumContainer())
            {
                toolStripQuestionListBox.Items.AddRange(
                    QuestIdentification.questIdentifications(container.QuestionSet
                        .Where(y => y.LanguageLanguageId == this.language.LanguageId))
                    .Select(x => x.text).ToArray());
            }
        }
        
        private void AddNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewQuestion form = new AddNewQuestion();
            form.ShowDialog();

            using (ForumContainer container = new ForumContainer())
            {
                toolStripQuestionListBox.Items.AddRange(
                    QuestIdentification.questIdentifications(container.QuestionSet
                        .Where(y => y.LanguageLanguageId == this.language.LanguageId))
                    .Select(x => x.text).ToArray());
            }
        }

        private void toolStripQuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectitem = (string)toolStripQuestionListBox.SelectedItem;
            var item = QuestIdentification.Get(selectitem);
            using (ForumContainer container = new ForumContainer())
            {
                QuestionSet = container.QuestionSet.FirstOrDefault(x => x.QuestionId == item.id);
            }
            QuestionLabel.Text = item.text;
            contextMenuStrip.Close();
        }
    }

    public class QuestIdentification
    {
        public int id;
        public string text;

        private static List<QuestIdentification> questList = new List<QuestIdentification>();

        public static List<QuestIdentification> questIdentifications(IQueryable<QuestionSet> queryable)
        {
            List <QuestIdentification> questIdnetiList = new List<QuestIdentification>(queryable.Count());

            foreach (var quer in queryable) {
                questIdnetiList.Add(new QuestIdentification() {
                     id = quer.QuestionId,
                     text = quer.QuestionText
                    }
                );
            }
            questList = questIdnetiList;

            return questIdnetiList;
        }

        internal static QuestIdentification Get(string selectitem)
        {
            return questList.FirstOrDefault(x => x.text.StartsWith(selectitem));
        }
    }
}
