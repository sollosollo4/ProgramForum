using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class QuestionTypeSet
    {
        public QuestionTypeSet()
        {
            QuestionSet = new HashSet<QuestionSet>();
        }

        public int QuestionTypeId { get; set; }
        public string QuestionTypeText { get; set; }

        public virtual ICollection<QuestionSet> QuestionSet { get; set; }
    }
}
