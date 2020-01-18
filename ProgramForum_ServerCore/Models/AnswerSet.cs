using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class AnswerSet
    {
        public int AnswerId { get; set; }
        public string AnswerVarible { get; set; }
        public int QuestionQuestionId { get; set; }

        public virtual QuestionSet QuestionQuestion { get; set; }
    }
}
