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
    
    public partial class MessageSet
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int ConversationId { get; set; }
        public int SenderId { get; set; }
    
        public virtual AccountSet AccountSet { get; set; }
        public virtual ConversationSet ConversationSet { get; set; }
    }
}
