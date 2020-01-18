using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class AccountSet
    {
        public AccountSet()
        {
            CommentorySet = new HashSet<CommentorySet>();
            ConversationSetRecipient = new HashSet<ConversationSet>();
            ConversationSetSender = new HashSet<ConversationSet>();
            MessageSet = new HashSet<MessageSet>();
            QuestionSet = new HashSet<QuestionSet>();
            ThemeSet = new HashSet<ThemeSet>();
        }

        public int AccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccountType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Points { get; set; }
        public int? Reputation { get; set; }

        public virtual ICollection<CommentorySet> CommentorySet { get; set; }
        public virtual ICollection<ConversationSet> ConversationSetRecipient { get; set; }
        public virtual ICollection<ConversationSet> ConversationSetSender { get; set; }
        public virtual ICollection<MessageSet> MessageSet { get; set; }
        public virtual ICollection<QuestionSet> QuestionSet { get; set; }
        public virtual ICollection<ThemeSet> ThemeSet { get; set; }
    }
}
