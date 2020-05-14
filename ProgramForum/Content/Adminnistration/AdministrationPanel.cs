using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramForum.Forms;

namespace ProgramForum.Content.Adminnistration
{
    public partial class AdministrationPanel : UserControl
    {
        public AdministrationPanel()
        {
            InitializeComponent();

            using (ForumContainer container = new ForumContainer())
            {
                var redactThermes = container.ThemeSet.Where(x => x.Visible == false).ToList();
                if (redactThermes.Count != 0)
                {
                    RedactorTheme.BackColor = Color.DarkOrange;
                    RedactorTheme.Text = "Редактор тем(на редакции) " + redactThermes.Count;
                }
                else 
                { 
                    RedactorTheme.BackColor = SystemColors.AppWorkspace;
                    RedactorTheme.Text = "Редактор тем";
                }
            }
        }

        /// <summary>
        /// Добавление нового вопроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            AddNewQuestion addNeQuestion = new AddNewQuestion();
            addNeQuestion.ShowDialog();
        }

        /// <summary>
        /// Редактор вопросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorQuestion_Click(object sender, EventArgs e)
        {
            QuestionRedactor questionRedactor = new QuestionRedactor();
            questionRedactor.ShowDialog();
        }

        /// <summary>
        /// Редактор пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorUsers_Click(object sender, EventArgs e)
        {
            AccountRedactor accountRedactor = new AccountRedactor();
            accountRedactor.ShowDialog();
        }

        /// <summary>
        /// Редактор тем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorTheme_Click(object sender, EventArgs e)
        {
            ThemeRedactor themeRedactor = new ThemeRedactor();
            themeRedactor.ShowDialog();
        }

        /// <summary>
        /// Добавить новый тест обучения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewTest_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Показать существующие темы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowThemeList_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить новое обучение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewTraining_Click(object sender, EventArgs e)
        {
            Forms.AdministrationForms.AddNewTraining newTraining = new Forms.AdministrationForms.AddNewTraining();
            newTraining.ShowDialog();
        }

        /// <summary>
        /// Добавить новостную тему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewNews_Click(object sender, EventArgs e)
        {

        }
    }
}
