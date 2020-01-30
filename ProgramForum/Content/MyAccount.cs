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
            EmailTextBox.Text = Account.Email;
            CreateDatelabel.Text = "Дата создания аккаунта: \n" + Account.CreateDate.ToString();
            AccountPoints.Text = "Накопленные очки: " + Account.Points;
            AccountReputation.Text = "Репутация: " + Account.Reputation;
            var Status = Account.AccountType == -1 ? "Админ" : "Пользователь";
            AccountStatus.Text = "Статус аккаунта: " + Status;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if(OldPassword.Text == Account.Password)
            {
                using(ForumContainer container = new ForumContainer())
                {
                    container.AccountSet.SingleOrDefault(x => x.AccountId == Account.AccountId).Password = NewPasswordTextBox.Text;
                    container.SaveChanges();
                    OldPassword.Text = NewPasswordTextBox.Text;
                }

                MessageBox.Show("Пароль был изменён.");
                return;
            }
            else
            {
                MessageBox.Show("Пароль не был изменён. Повторите попытку.");
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
