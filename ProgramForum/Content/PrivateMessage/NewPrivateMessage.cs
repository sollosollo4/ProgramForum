using ProgramForum.Content.PrivateMessage.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.PrivateMessage
{
    public partial class NewPrivateMessage : Form
    {
        AccountSet Client;
        FlowLayoutPanel pmFlowLoyoutPanel;
        UserNameLogin selectedUser;
        public NewPrivateMessage(AccountSet Client, Control fromControl)
        {
            this.Client = Client;
            pmFlowLoyoutPanel = fromControl.Controls.OfType<FlowLayoutPanel>().First();
            InitializeComponent();
        }

        private void InitialSenderComboBox_TextChanged(object sender, EventArgs e)
        {
            var getText = InitialSenderComboBox.Text;

            if (getText.Length < 3)
                return;

            using(ForumContainer container = new ForumContainer())
            {
                InitialSenderComboBox.Items.Clear();

                var userNameLogins = container.AccountSet
                    .Where(n => n.Login.StartsWith(getText) || n.Name.StartsWith(getText))
                    .Select(x => new UserNameLogin() { Name = x.Name.TrimEnd(), Login = x.Login.TrimEnd(), AccountId = x.AccountId }).ToList();

                UserNameLogin.SetFindest(userNameLogins);
                foreach (var user in userNameLogins) {
                    InitialSenderComboBox.Items.Add(user.getName());
                }
            }
        }

        private void InitialSenderComboBox_SelectedIndexChanged(object sender, EventArgs e) => selectedUser = UserNameLogin.Find(InitialSenderComboBox.Text);

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Вы не выбрали получателя");
                return;
            }

            ForumContainer Scontainer = new ForumContainer();

            var converstation = new ConversationSet()
            {
                SenderId = Client.AccountId,
                RecipientId = selectedUser.AccountId,
                AccountSet_Recipient = Scontainer.AccountSet.SingleOrDefault(x => x.AccountId == selectedUser.AccountId),
                AccountSet_Sender = Scontainer.AccountSet.SingleOrDefault(x => x.AccountId == Client.AccountId)
            };
            
            void handlerClickerChat(object SenderK, EventArgs args)
            {
                MessageSendForm messageForm = new MessageSendForm(Client, converstation.AccountSet_Recipient);
                messageForm.Show();
            };

            Scontainer.ConversationSet.Add(converstation);
            Scontainer.SaveChanges();

            Chat.Chat newChat = new Chat.Chat(converstation.AccountSet_Recipient.Login, handlerClickerChat); // с кем беседа
            pmFlowLoyoutPanel.Controls.Add(newChat);

            if (Message.Text != string.Empty || Message.Text.Length < 5)
            {
                MessageSet message = new MessageSet()
                {
                    Date = DateTime.Now,
                    MessageText = Message.Text,
                    ConversationId = converstation.ConversationId,
                    SenderId = Client.AccountId
                };
                Scontainer.MessageSet.Add(message);
                Scontainer.SaveChanges();
                
                Message.Text = "";
                // this code post query in server and get await
            }
            else
            {
                MessageBox.Show("Вы не ввели сообщение, либо оно слишком короткое!");
                return;
            }
            Close();
        }

        
        private class UserNameLogin
        {
            public int AccountId;
            public string Name;
            public string Login;

            public static List<UserNameLogin> findest = new List<UserNameLogin>();

            public string getName() => Name + " : " + Login;
            

            public static UserNameLogin Find(string name)
            {
                var trueString = name.Replace(" ", "").Split(':');
                var needusernamelogin = findest.FirstOrDefault(x => x.Name == trueString[0] && x.Login == trueString[1]);
                return needusernamelogin;
            }

            public static void SetFindest(List<UserNameLogin> userNameLogins) => findest.AddRange(userNameLogins);
        }
    }
}
