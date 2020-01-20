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

namespace ProgramForum.Content
{
    public partial class PrivateMessageControl : UserControl
    {
        public PrivateMessageControl()
        {
            InitializeComponent();
        }

        public void LoadMessages(AccountSet Client)
        {
            ForumContainer container = new ForumContainer();
            
            // Где мы получатели
            foreach(var converstation in container.ConversationSet.Where(x => x.RecipientId == Client.AccountId).ToList())
            {
                void handlerClickerChat(object sender, EventArgs args)
                {
                    MessageSendForm messageForm = new MessageSendForm(Client, converstation.AccountSet1);
                    messageForm.Show();
                };

                Chat newChat = new Chat(converstation.AccountSet1.Login, handlerClickerChat); // с кем беседа
                pmFlowLoyoutPanel.Controls.Add(newChat);
            }

            // Где мы отправители
            foreach (var converstation in container.ConversationSet.Where(x => x.SenderId == Client.AccountId).ToList())
            {
                void handlerClickerChat(object sender, EventArgs args)
                {
                    MessageSendForm messageForm = new MessageSendForm(Client, converstation.AccountSet);
                    messageForm.Show();
                };

                Chat newChat = new Chat(converstation.AccountSet.Login, handlerClickerChat); // с кем беседа
                pmFlowLoyoutPanel.Controls.Add(newChat);
            }
        }
    }
}
