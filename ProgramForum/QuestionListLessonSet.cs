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
    
    public partial class QuestionListLessonSet
    {
        public int LessonQuestionId { get; set; }
        public int QuestionId { get; set; }
        public int Position { get; set; }
        public int LessonId { get; set; }
    
        public virtual LessonSet LessonSet { get; set; }
        public virtual QuestionSet QuestionSet { get; set; }
    }
}