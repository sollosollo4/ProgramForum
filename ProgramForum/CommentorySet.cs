//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramForum
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommentorySet
    {
        public int CommentoryId { get; set; }
        public int AuthorId { get; set; }
        public string CommentoryText { get; set; }
        public int ThemeId { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual AccountSet AccountSet { get; set; }
        public virtual ThemeSet ThemeSet { get; set; }
    }
}
