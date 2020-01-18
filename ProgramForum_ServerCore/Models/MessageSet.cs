using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class MessageSet
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime? Date { get; set; }
        public int ConversationId { get; set; }
        public int SenderId { get; set; }

        public virtual AccountSet Conversation { get; set; }
        public virtual ConversationSet ConversationNavigation { get; set; }
    }
}
