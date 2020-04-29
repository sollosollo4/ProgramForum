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
    public partial class MyAccount : UserControl
    {
        private AccountSet Account;
        public MyAccount(AccountSet client)
        {
            Account = client;
            InitializeComponent();
        }

        public void UpdateLabels()
        {
            LoginTextBox.Text = Account.Login.TrimEnd();
            if (Account.Email != null) EmailTextBox.Text = Account.Email.TrimEnd();
            if (Account.CreateDate != null) CreateDatelabel.Text = "Дата создания аккаунта: \n" + Account.CreateDate.ToString();
            if (Account.Points != null) AccountPoints.Text = "Накопленные очки: " + Convert.ToInt32(Account.Points); else AccountPoints.Text = "Накопленные очки: 0";
            if (Account.Reputation != null) AccountReputation.Text = "Репутация: " + Convert.ToInt32(Account.Reputation); else AccountReputation.Text = "Репутация: 0";
            var Status = Account.AccountType == -1 ? "Админ" : "Пользователь";
            AccountStatus.Text = "Статус аккаунта: " + Status;

            using(ForumContainer container = new ForumContainer()) {

                foreach (var myQuest in container.QuestionSet.Where(x => x.AccountAccountId == Account.AccountId).ToList()) {
                    MyQuestionflowLayoutPanel.Controls.Add(new Question.SingleQuestion(myQuest));
                }

                foreach (var myTheme in container.ThemeSet.Where(x => x.AuthorId == Account.AccountId).ToList()) {
                    Theme.SingleTheme snglTheme = new Theme.SingleTheme(myTheme);
                    //snglTheme.SetClick_ReadTheme(SetClick_ForSingleTheme);
                    MyThemesflowLayoutPanel.Controls.Add(snglTheme);

                }
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if(OldPasswordTextBox.Text.TrimEnd() == Account.Password.TrimEnd())
            {
                using(ForumContainer container = new ForumContainer())
                {
                    container.AccountSet.SingleOrDefault(x => x.AccountId == Account.AccountId).Password = NewPasswordTextBox.Text.TrimEnd();
                    container.SaveChanges();
                }

                MessageBox.Show("Пароль был изменён.");
                return;
            }
            else
            {
                MessageBox.Show("Пароль не был изменён, потому что вы ввели неверный старый пароль. Повторите попытку.");
                return;
            }
        }

        private void SaveAllChanges_Click(object sender, EventArgs e)
        {
            using(ForumContainer container = new ForumContainer())
            {
                container.AccountSet.SingleOrDefault(x => x.AccountId == Account.AccountId).Email = EmailTextBox.Text.TrimEnd();
                container.SaveChanges();
            }
        }

        private bool isSizeIncreasing;
        private Size OldSize = new Size(232, 105);

        private void MyAccountPanel_Resize(object sender, EventArgs e)
        {
            if(panel1.Size.Height >= OldSize.Height) { // Если размер увеличивается
                isSizeIncreasing = true;
            } else { // Если уменьшается
                isSizeIncreasing = false;
            }
            OldSize = panel1.Size;

            if (isSizeIncreasing && panel1.Size.Height == panel1.MaximumSize.Height) { // Если мы увеличиваем форму, то держимся за низ формы
                panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (!isSizeIncreasing) { // Если уменьшаем, то держимся за верхнюю панель
                panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
        }
    }
}
