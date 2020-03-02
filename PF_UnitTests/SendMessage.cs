using ProgramForum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_UnitTests
{
    public class SendMessage
    {
        public static string errorMessage;

        private ConversationSet FormConversation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="AccountId1">Отправитель</param>
        /// <param name="AccountId2">Получатель</param>
        /// <returns></returns>
        public bool Send(string message, int AccountId1, int AccountId2)
        {
            using (ForumContainer container = new ForumContainer())
            {
                ConversationSet conversation = container.ConversationSet.SingleOrDefault(x =>
                (x.AccountSet_Recipient.AccountId == AccountId1 && x.AccountSet_Sender.AccountId == AccountId2) ||
                (x.AccountSet_Recipient.AccountId == AccountId2 && x.AccountSet_Sender.AccountId == AccountId1)
                );


                if (conversation == null)
                {
                    ConversationSet newConversation = new ConversationSet()
                    {
                        RecipientId = AccountId2,
                        SenderId = AccountId1
                    };
                    container.ConversationSet.Add(newConversation);
                    container.SaveChanges();

                    FormConversation = newConversation;
                }
                else
                {
                    FormConversation = conversation;
                    // next code
                }
            }


            if (message != string.Empty || message.Length < 5)
            {
                using (ForumContainer container = new ForumContainer())
                {
                    MessageSet messageSet = new MessageSet()
                    {
                        Date = DateTime.Now,
                        MessageText = message,
                        ConversationId = FormConversation.ConversationId,
                        SenderId = AccountId2
                    };
                    container.MessageSet.Add(messageSet);
                    container.SaveChanges();
                }
                // this code post query in server and get await
                
                return true;
            }
            else
            {
                errorMessage = "Вы не ввели сообщение, либо оно слишком короткое!";
                return false;
            }

            
        }
    }
}
