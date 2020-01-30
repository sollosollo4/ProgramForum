using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.Adminnistration
{
    public partial class AdministrationPanel : UserControl
    {
        public AdministrationPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового вопроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            AddNeQuestion addNeQuestion = new AddNeQuestion();
            addNeQuestion.ShowDialog();
        }

        /// <summary>
        /// Редактор вопросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorQuestion_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Редактор пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorUsers_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Редактор тем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorTheme_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить новый тест
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
        /// Выбрать ежедневный тест
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEveryDayTest_Click(object sender, EventArgs e)
        {

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
