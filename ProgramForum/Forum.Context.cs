﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForumContainer : DbContext
    {
        public ForumContainer()
            : base("name=ForumContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountSet> AccountSet { get; set; }
        public virtual DbSet<AnswerSet> AnswerSet { get; set; }
        public virtual DbSet<CommentorySet> CommentorySet { get; set; }
        public virtual DbSet<ConversationSet> ConversationSet { get; set; }
        public virtual DbSet<LanguageSet> LanguageSet { get; set; }
        public virtual DbSet<MessageSet> MessageSet { get; set; }
        public virtual DbSet<QuestionSet> QuestionSet { get; set; }
        public virtual DbSet<QuestionTypeSet> QuestionTypeSet { get; set; }
        public virtual DbSet<ThemeSet> ThemeSet { get; set; }
    }
}