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
                        MessageBox.Show("Вы ввели неверный пароль.\nБудте осторожны, после трёх неверных попыток входа вход будет заблокирован.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные для входа. Повторите авторизоваться используя другие данные");
                    Password.Text = "";
                    return;
                }
            }

            if (RememberMeCheckBox.Enabled)
            {
                Properties.Settings.Default.Login = login;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }

            Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            void clickReturn(object send, EventArgs ea)
            {
                AuthPanel.Visible = true;
                Text = "Авторизация";
            }
            Text = "Регистрация";
            Panels.Registration registrPanel = new Panels.Registration(clickReturn) { Location = new Point(0, 0) };
            AuthPanel.Visible = false;
            Controls.Add(registrPanel);
        }

        private void RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = RememberMeCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AuthorizationButton_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
