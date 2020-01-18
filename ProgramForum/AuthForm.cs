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
    public partial class AuthForm : Form
    {
        public static AccountSet Client;
        public AuthForm()
        {
            InitializeComponent();

            if(Properties.Settings.Default.Remember)
            {
                Login.Text = Properties.Settings.Default.Login;
                Password.Text = Properties.Settings.Default.Password;
                RememberMeCheckBox.Checked = Properties.Settings.Default.Remember;
            }
        }

        /*
        using (ForumContainer container = new ForumContainer())
        {
            var init = container.AccountSet.Single(x => x.AccountId == 1);
            var send = container.AccountSet.Single(x => x.AccountId == 13);
            Chat.MessageSendForm form = new Chat.MessageSendForm(init, send);
            form.Show();
        }
        */

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = Login.Text;
            var password = Password.Text;

            using(ForumContainer container = new ForumContainer())
            {
                var tryLogin = container.AccountSet.SingleOrDefault(x => x.Login == login);

                if(tryLogin != null)
                {
                    if(tryLogin.Password == password)
                    {
                        Client = tryLogin;
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неверный пароль.\n Будте осторожны, попыток не так много ;)");
                    }
                }
                else
                {
                    MessageBox.Show("Вы явно чем то ошиблись..");
                    Password.Text = "";
                }
            }

            Properties.Settings.Default.Login = login;
            Properties.Settings.Default.Password = password;

            Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {

        }

        private void RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = RememberMeCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
