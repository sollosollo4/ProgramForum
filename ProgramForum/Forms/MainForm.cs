﻿using System;
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
    public partial class MainForm : Form
    {
        public static AccountSet Client;
        public static LanguageSet Language;

        public List<LanguageSet> languageList;

        public MainForm(AccountSet Client)
        {
            InitializeComponent();
            MainForm.Client = Client;

            if(Client.AccountType == 0)
            {
                AdminPanelButton.Visible = false;
                AdminPanelButton.Enabled = false;
            }
        }

        private void AllContentLoad()
        {

        }

        private void AllContentHidden()
        {
            /*
            foreach (UserControl smplPanel in Controls.OfType<UserControl>())
                smplPanel.Visible = false;
            // Скрываем все панели из Content

            if(Controls.OfType<UserControl>().Count() > 10) {
                foreach (UserControl smplPanel in Controls.OfType<UserControl>()) {
                    Controls.Remove(smplPanel);
                }
            }*/

            // удаление всех панелей из Controls 
            foreach (UserControl smplPanel in Controls.OfType<UserControl>())
                Controls.Remove(smplPanel);

            Size = MinimumSize;
            var screen = Screen.FromControl(this);
            Top = screen.Bounds.Height / 2 - Height / 2;
            Left = screen.Bounds.Width / 2 - Width / 2;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Panels.MainContent MainContent = new Panels.MainContent(AddNewTheme_Click) { 
                Location = new Point(238, 91), 
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
                };
            Controls.Add(MainContent);

            LanguageLabel.Text = "Язык не выбран.";

            using(ForumContainer container = new ForumContainer()) {
                var LanguageList = container.LanguageSet.Select(x => x.LanguageName);
                languageList = new List<LanguageSet>();
                languageList = container.LanguageSet.ToList();
                ChooseLanguageStrip.Items.AddRange(LanguageList.ToArray());
            }
        }

        private void ChooseLanguageStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageLabel.Text = string.Empty;
            LanguageLabel.Text += "Выбран язык: " + ChooseLanguageStrip.SelectedItem;
            Language = languageList.Single(x => x.LanguageName == ChooseLanguageStrip.SelectedItem.ToString());
            SendKeys.Send("{TAB}");
        }

        private void MainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllContentHidden();
            Panels.MainContent MainContent = new Panels.MainContent(AddNewTheme_Click) { 
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(MainContent);
        }

        private void AddNewTheme_Click(object sender, EventArgs e)
        {
            AllContentHidden();

            Content.AddNewTheme addNewTheme = new Content.AddNewTheme(Client, MainFormToolStripMenuItem_Click) {
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(addNewTheme);
        }

        private void RandomQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Language == null)
            {
                MessageBox.Show("Вы не выбрали язык! Пожалуйста, выберите язык на синей вкладке левой панели меню");
                return;
            }

            using (ForumContainer container = new ForumContainer())
            {
                List<QuestionSet> questionSets = new List<QuestionSet>();
                questionSets = container.QuestionSet.Where(x => x.LanguageSet.LanguageId == Language.LanguageId).ToList();
                Random xRandom = new Random();

                if(questionSets.Count == 0)
                {
                    MessageBox.Show("В базе данных нет вопросов по теме выбранного вами языка");
                    return;
                }

                AllContentHidden();

                Content.RandomQuestion randQuest = new Content.RandomQuestion(questionSets[xRandom.Next(0, questionSets.Count)])
                {
                    Location = new Point(238, 92),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right
                };

                randQuest.ReturnToMain += MainFormToolStripMenuItem_Click;

                Controls.Add(randQuest);
            }
        }

        private void GetTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Language == null)
            {
                MessageBox.Show("Вы не выбрали язык! Пожалуйста, выберите язык на синей вкладке левой панели меню");
                return;
            }
            
            AllContentHidden();

            Panels.Training.TrainingList trainingList = new Panels.Training.TrainingList(){
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };;
            Controls.Add(trainingList);
        }

        private void MyAccount_Click(object sender, EventArgs e)
        {
           AllContentHidden();

            Content.MyAccount myAccount = new Content.MyAccount(Client) {
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            myAccount.UpdateLabels();
            Controls.Add(myAccount);
        }

        private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllContentHidden();

            Content.PrivateMessage.PrivateMessageControl cpMessages = new Content.PrivateMessage.PrivateMessageControl()
            {
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            Controls.Add(cpMessages);
            cpMessages.LoadMessages(Client);
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AllContentHidden();
            Content.Adminnistration.AdministrationPanel administrationPanel = new Content.Adminnistration.AdministrationPanel()
            {
                Location = new Point(238, 92),
                Anchor = AnchorStyles.Left | AnchorStyles.Top
            };
            Controls.Add(administrationPanel);
        }

        /// <summary>
        /// Просмотреть новые вопросы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newQuestionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// Узнать о новых пользователях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAccountsRegistred_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// Новости форума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForumNews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// Список пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountsGrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
