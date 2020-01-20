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
    public partial class MainForm : Form
    {
        public AccountSet Client;
        public static LanguageSet Language;

        public List<LanguageSet> languageList;

        public MainForm(AccountSet Client)
        {
            InitializeComponent();
            this.Client = Client;
        }

        private void AllContentLoad()
        {

        }

        private void AllContentHidden()
        {
            foreach (UserControl smplPanel in Controls.OfType<UserControl>())
                smplPanel.Visible = false;
            // Скрываем все панели из Content

            MainContent.Visible = false; // Скрываем Панель Content'а

            if(Controls.OfType<UserControl>().Count() > 10)
            {
                foreach (UserControl smplPanel in Controls.OfType<UserControl>())
                {
                    Controls.Remove(smplPanel);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LanguageLabel.Text = "Язык не выбран.";

            using(ForumContainer container = new ForumContainer())
            {
                var LanguageList = container.LanguageSet.Select(x => x.LanguageName);
                languageList = new List<LanguageSet>();
                languageList = container.LanguageSet.ToList();
                ChooseLanguageStrip.Items.AddRange(LanguageList.ToArray());

                // ThemeLoading
                if(container.ThemeSet.Count() > 0)
                {
                    foreach (ThemeSet theme in container.ThemeSet.OrderByDescending(t => t.CreateDate)) 
                    {
                        Content.Theme.SingleTheme singleTheme = new Content.Theme.SingleTheme(theme)
                        {
                            Location = new Point(0, 0)
                        };
                        singleTheme.SetClick_ReadTheme(SetClick_ForSingleTheme);
                        LastThemePanel.Controls.Add(singleTheme);
                    }
                }
            }
        }

        private void SetClick_ForSingleTheme(object sender, EventArgs eventArgs)
        {
            var childButton = (Button)sender;
            AllContentHidden();
            var theme = (Content.Theme.SingleTheme)childButton.Parent;
            Content.ThemeControl newTheme = new Content.ThemeControl(theme.Theme) { Location = new Point(220, 91), MinimumSize = new Size(450, 348), MaximumSize = new Size(0,0), Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
            Controls.Add(newTheme);
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
            MainContent.Visible = true;
        }

        private void RandomQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Language == null)
            {
                MessageBox.Show("Вы не выбрали язык! Пожалуйста, выберите язык на синей вкладки левой панели");
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
                    Location = new Point(220, 91),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right
                };

                randQuest.ReturnToMain += MainFormToolStripMenuItem_Click;

                Controls.Add(randQuest);
            }
        }

        private void MyAccount_Click(object sender, EventArgs e)
        {
            AllContentHidden();

            Content.MyAccount myAccount = new Content.MyAccount(Client)
            {
                Location = new Point(220, 91),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            myAccount.UpdateLabels();
            Controls.Add(myAccount);
        }

        private void EveryDayTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllContentHidden();

            Content.PrivateMessageControl cpMessages = new Content.PrivateMessageControl()
            {
                Location = new Point(220, 91),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(cpMessages);
            cpMessages.LoadMessages(Client);
        }
    }
}
