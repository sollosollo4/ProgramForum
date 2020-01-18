using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class LanguageSet
    {
        public LanguageSet()
        {
            QuestionSet = new HashSet<QuestionSet>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageDescription { get; set; }

        public virtual ICollection<QuestionSet> QuestionSet { get; set; }
    }
}
