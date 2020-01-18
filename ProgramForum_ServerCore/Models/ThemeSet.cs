using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class ThemeSet
    {
        public ThemeSet()
        {
            CommentorySet = new HashSet<CommentorySet>();
        }

        public int ThemeId { get; set; }
        public int AuthorId { get; set; }
        public string ThemeName { get; set; }
        public string ThemeText { get; set; }
        public int ThemePoints { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual AccountSet Author { get; set; }
        public virtual ICollection<CommentorySet> CommentorySet { get; set; }
    }
}
