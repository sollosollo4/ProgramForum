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
            EmailTextBox.Text = Account.Email.TrimEnd();
            CreateDatelabel.Text = "Дата создания аккаунта: \n" + Account.CreateDate.ToString();
            AccountPoints.Text = "Накопленные очки: " + Convert.ToInt32(Account.Points);
            AccountReputation.Text = "Репутация: " + Convert.ToInt32(Account.Reputation);
            var Status = Account.AccountType == -1 ? "Админ" : "Пользователь";
            AccountStatus.Text = "Статус аккаунта: " + Status;
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
    }
}
