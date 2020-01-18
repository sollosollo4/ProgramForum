using System;
using System.Collections.Generic;

namespace ProgramForum_ServerCore.Models
{
    public partial class CommentorySet
    {
        public int CommentoryId { get; set; }
        public int AuthorId { get; set; }
        public string CommentoryText { get; set; }
        public int ThemeId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual AccountSet Author { get; set; }
        public virtual ThemeSet Theme { get; set; }
    }
}
