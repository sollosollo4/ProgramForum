using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class QuestionSet
    {
        public QuestionSet()
        {
            AnswerSet = new HashSet<AnswerSet>();
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int LanguageLanguageId { get; set; }
        public int QuestionTypeQuestionTypeId { get; set; }
        public int CorrectOption { get; set; }
        public int AccountAccountId { get; set; }
        public DateTime? Date { get; set; }

        public virtual AccountSet AccountAccount { get; set; }
        public virtual LanguageSet LanguageLanguage { get; set; }
        public virtual QuestionTypeSet QuestionTypeQuestionType { get; set; }
        public virtual ICollection<AnswerSet> AnswerSet { get; set; }
    }
}
