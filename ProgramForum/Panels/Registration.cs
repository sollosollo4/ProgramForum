using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProgramForum.Panels
{
    public partial class Registration : UserControl
    {
        private Action<object, EventArgs> clickReturn;
        
        public Registration(Action<object, EventArgs> clickReturn)
        {
            InitializeComponent();
            this.clickReturn = clickReturn;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (Login.Text == string.Empty)
            {
                MessageBox.Show("Вы оставили поле Логин пустым");
                return;
            }

            if (EmailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Вы оставили поле Почта пустым");
                return;
            }

            if (TelephoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Вы оставили поле Телефон пустым");
                return;
            }

            if (Password.Text == string.Empty)
            {
                MessageBox.Show("Вы оставили поле Пароль пустым");
                return;
            }

            if (UserName.Text ==  string.Empty)
            {
                MessageBox.Show("Вы оставили поле Имя пустым");
                return;
            }

            using (ForumContainer container = new ForumContainer())
            {
                if(container.AccountSet.SingleOrDefault(x => x.Login == Login.Text) != null) {
                    MessageBox.Show("Данный логин уже занят. Выберите другой логин для входа на форум.");
                    return;
                }

                if(container.AccountSet.SingleOrDefault(x => x.Email == EmailTextBox.Text) != null) {
                    MessageBox.Show("Данный емайл уже занят. Выберите другой емайл.");
                    return;
                }

                if (container.AccountSet.SingleOrDefault(x => x.PhoneNumber == TelephoneNumber.Text) != null) {
                    MessageBox.Show("Данный телефонный номер уже занят. Выберите другой телефонный номер.");
                    return;
                }

                if(Password.Text.Equals(RePassword.Text)) 
                {
                    AccountSet newAccount = new AccountSet() {
                        Login = Login.Text,
                        PhoneNumber = TelephoneNumber.Text,
                        Email = EmailTextBox.Text,
                        Password = HashPassword(Password.Text),
                        Name = UserName.Text,
                        UserName = UserName.Text,
                        AccountType = 0,
                        CreateDate = DateTime.Now,
                        Points = 0,
                        Reputation = 0
                    };

                    container.AccountSet.Add(newAccount);
                    container.SaveChanges();
                    MessageBox.Show("Аккаунт был успешно создан!");
                }
                else {
                    MessageBox.Show("Повторите попытку. Вы ввели не одинаковый пароль.");
                    return;
                }
            }
        }

        static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        private void MyAccount_Click(object sender, EventArgs e)
        {
            clickReturn(sender, e);
            Visible = false;
        }
    }
}
