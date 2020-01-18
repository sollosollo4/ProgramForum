using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class ConversationSet
    {
        public ConversationSet()
        {
            MessageSet = new HashSet<MessageSet>();
        }

        public int ConversationId { get; set; }
        public int RecipientId { get; set; }
        public int SenderId { get; set; }

        public virtual AccountSet Recipient { get; set; }
        public virtual AccountSet Sender { get; set; }
        public virtual ICollection<MessageSet> MessageSet { get; set; }
    }
}
