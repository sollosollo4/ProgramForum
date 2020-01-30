using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content
{
    public partial class AddNewTheme : UserControl
    {
        private AccountSet Author;
        EventHandler ReturnToMain;
        public AddNewTheme(AccountSet Client, EventHandler eventHandler)
        {
            Author = Client;
            ReturnToMain = eventHandler;
            InitializeComponent();
        }

        private void SendOnDatebaseButton_Click(object sender, EventArgs e)
        {
            if(ThemeName.Text == string.Empty) {
                MessageBox.Show("Имя темы не может быть пустым.");
                return;
            }

            if(ThemeText.Text.Length < 25) {
                MessageBox.Show("Текст темы не может быть менее, чем 25 символов.");
                return;
            }

            if (Author.AccountType == 0)
            {
                if (Author.Reputation < 25 || Author.Reputation == 0)
                {
                    MessageBox.Show("Вы не можете отправлять заявки на темы. Вам не хватает репутации.");
                    return;
                }
            }

            using(ForumContainer container = new ForumContainer()) {
                ThemeSet newTheme = new ThemeSet() {
                    AuthorId = Author.AccountId,
                    ThemeName = ThemeName.Text,
                    ThemeText = ThemeText.Text,
                    ThemePoints = 0, 
                    CreateDate = DateTime.Now,
                    Visible = false
                };

                container.ThemeSet.Add(newTheme);
                container.SaveChanges();

                MessageBox.Show("Тема была успешно отправлена на редакцию");
            }
        }
    }
}
