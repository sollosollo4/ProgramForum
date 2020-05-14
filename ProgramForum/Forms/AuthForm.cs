using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = Login.Text;
            var password = Password.Text;

            if(string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }

            using (ForumContainer container = new ForumContainer())
            {
                var tryLogin = container.AccountSet.SingleOrDefault(x => x.Login == login);

                if(tryLogin != null)
                {
                    if(VerifyHashedPassword(tryLogin.Password, password))
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

        static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        private static bool ByteArraysEqual(byte[] b0, byte[] b1)
        {
            if (b0 == b1)
            {
                return true;
            }

            if (b0 == null || b1 == null)
            {
                return false;
            }

            if (b0.Length != b1.Length)
            {
                return false;
            }

            for (int i = 0; i < b0.Length; i++)
            {
                if (b0[i] != b1[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
