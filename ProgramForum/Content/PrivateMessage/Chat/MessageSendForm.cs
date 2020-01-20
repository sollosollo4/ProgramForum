using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.PrivateMessage.Chat
{
    public partial class MessageSendForm : Form
    {
        public ConversationSet FormConversation;

        public AccountSet Recipient;
        public AccountSet Sender;
        
        public List<MessageContainer> MessageContainers;

        /// <summary>
        /// initial = Получатель, sender = Отправитель
        /// </summary>
        /// <param name="initial">Получатель</param>
        /// <param name="sender">Отправитель</param>
        public MessageSendForm(AccountSet initial, AccountSet sender)
        {
            InitializeComponent();
            Recipient = initial;
            Sender = sender;
        }

        /// <summary>
        /// init = Получатель, send = Отправитель
        /// </summary>
        /// <param name="init">Получатель</param>
        /// <param name="send">Отправитель</param>
        private void GetMessages(AccountSet init, AccountSet send)
        {
            using(ForumContainer container = new ForumContainer())
            {
                ConversationSet conversation = container.ConversationSet.SingleOrDefault(x => 
                (x.AccountSet.AccountId == init.AccountId && x.AccountSet1.AccountId == send.AccountId) ||
                (x.AccountSet.AccountId == send.AccountId && x.AccountSet1.AccountId == init.AccountId)
                );


                if(conversation == null)
                {
                    ConversationSet newConversation = new ConversationSet()
                    {
                        RecipientId = init.AccountId,
                        SenderId = send.AccountId
                    };

                    FormConversation = newConversation;

                    container.ConversationSet.Add(newConversation);
                    container.SaveChanges();

                    return;
                }
                else
                {
                    FormConversation = conversation;

                    var MessageList = container.MessageSet.Where(x => x.ConversationSet.ConversationId == FormConversation.ConversationId).ToList();
                    if (MessageList.Count > 0)
                    {
                        foreach (MessageSet message in MessageList)
                        {
                            AddNewMessageContainer(message);
                        }
                    }

                    return;
                }
            }
        }

        public void AddNewMessageContainer(MessageSet Message)
        {
            MessageContainer messageContainer = new MessageContainer();
            if (Message.SenderId == Recipient.AccountId) // Left - сообщения отправителя
            {
                messageContainer.SetMessage(Recipient, Message);
                ContainerPMessage.Controls.Add(messageContainer);
            }
            else if(Message.SenderId == Sender.AccountId) // rigth - сообщения получателя
            {
                messageContainer.SetMessage(Sender, Message);
                ContainerPMessage.Controls.Add(messageContainer);
            }
        }

        private void MessageSendForm_Load(object sender, EventArgs e)
        {
            GetMessages(Recipient, Sender);

            var change = ContainerPMessage.VerticalScroll.Value + ContainerPMessage.VerticalScroll.SmallChange * 100;
            ContainerPMessage.AutoScrollPosition = new Point(0, change);
        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Text != string.Empty)
                {
                    using (ForumContainer container = new ForumContainer())
                    {
                        MessageSet message = new MessageSet()
                        {
                            Date = DateTime.Now,
                            MessageText = MessageBox.Text,
                            ConversationId = FormConversation.ConversationId,
                            SenderId = Recipient.AccountId
                        };
                        container.MessageSet.Add(message);
                        container.SaveChanges();
                        AddNewMessageContainer(message);
                    }
                    MessageBox.Text = "";

                    var change = ContainerPMessage.VerticalScroll.Value + ContainerPMessage.VerticalScroll.SmallChange * 100;
                    ContainerPMessage.AutoScrollPosition = new Point(0, change);

                    // this code post query in server and get await
                }
            }
        }
    }
}
