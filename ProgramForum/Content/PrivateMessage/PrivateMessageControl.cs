using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramForum.Content.PrivateMessage.Chat;

namespace ProgramForum.Content.PrivateMessage
{
    public partial class PrivateMessageControl : UserControl
    {
        private AccountSet Client;

        public PrivateMessageControl()
        {
            InitializeComponent();
        }

        public void LoadMessages(AccountSet Client)
        {
            this.Client = Client;
            ForumContainer container = new ForumContainer();
            
            // Где мы получатели
            foreach(var converstation in container.ConversationSet.Where(x => x.RecipientId == Client.AccountId).ToList())
            {
                void handlerClickerChat(object sender, EventArgs args)
                {
                    MessageSendForm messageForm = new MessageSendForm(Client, converstation.AccountSet_Sender);
                    messageForm.Show();
                };
                Chat.Chat newChat = new Chat.Chat(converstation.AccountSet_Sender.Login, handlerClickerChat);
                pmFlowLoyoutPanel.Controls.Add(newChat);
            }

            // Где мы отправители
            foreach (var converstation in container.ConversationSet.Where(x => x.SenderId == Client.AccountId).ToList())
            {
                void handlerClickerChat(object sender, EventArgs args)
                {
                    MessageSendForm messageForm = new MessageSendForm(Client, converstation.AccountSet_Recipient);
                    messageForm.Show();
                };


                Chat.Chat newChat = new Chat.Chat(converstation.AccountSet_Recipient.Login, handlerClickerChat); 
                pmFlowLoyoutPanel.Controls.Add(newChat);
            }
        }

        private void NewMessage_Click(object sender, EventArgs e)
        {
            NewPrivateMessage newPrivateMessage = new NewPrivateMessage(Client, this);
            newPrivateMessage.ShowDialog();
        }
    }
}
