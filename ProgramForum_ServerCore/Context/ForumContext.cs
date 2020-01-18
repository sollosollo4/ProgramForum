using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProgramForum_ServerCore.Models
{
    public partial class ForumContext : IdentityDbContext<AccountSet>
    {
        public ForumContext()
        {
        }

        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        {
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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountSet>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(55)
                    .IsFixedLength();

                entity.Property(e => e.Login).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength()
                    .HasDefaultValueSql("('NoName')");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Points).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reputation).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AnswerSet>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.HasIndex(e => e.QuestionQuestionId)
                    .HasName("IX_FK_AnswerQuestion");

                entity.Property(e => e.AnswerVarible).IsRequired();

                entity.HasOne(d => d.QuestionQuestion)
                    .WithMany(p => p.AnswerSet)
                    .HasForeignKey(d => d.QuestionQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerQuestion");
            });

            modelBuilder.Entity<CommentorySet>(entity =>
            {
                entity.HasKey(e => e.CommentoryId);

                entity.Property(e => e.CommentoryText).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.CommentorySet)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentorySet_AccountSet");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.CommentorySet)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentorySet_ThemeSet");
            });

            modelBuilder.Entity<ConversationSet>(entity =>
            {
                entity.HasKey(e => e.ConversationId);

                entity.Property(e => e.RecipientId).HasComment("Recipient");

                entity.Property(e => e.SenderId).HasComment("Sender");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.ConversationSetRecipient)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConversationSet_AccountSet");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.ConversationSetSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConversationSet_AccountSet1");
            });

            modelBuilder.Entity<LanguageSet>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.Property(e => e.LanguageName).IsRequired();
            });

            modelBuilder.Entity<MessageSet>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MessageText).IsRequired();

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.MessageSet)
                    .HasForeignKey(d => d.ConversationId)
                    .HasConstraintName("FK_MessageSet_ConversationSet_Sender");

                entity.HasOne(d => d.ConversationNavigation)
                    .WithMany(p => p.MessageSet)
                    .HasForeignKey(d => d.ConversationId)
                    .HasConstraintName("FK_MessageSet_ConversationSet");
            });

            modelBuilder.Entity<QuestionSet>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.HasIndex(e => e.AccountAccountId)
                    .HasName("IX_FK_AccountQuestion");

                entity.HasIndex(e => e.LanguageLanguageId)
                    .HasName("IX_FK_LanguageQuestion");

                entity.HasIndex(e => e.QuestionTypeQuestionTypeId)
                    .HasName("IX_FK_QuestionTypeQuestion");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.QuestionText).IsRequired();

                entity.HasOne(d => d.AccountAccount)
                    .WithMany(p => p.QuestionSet)
                    .HasForeignKey(d => d.AccountAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountQuestion");

                entity.HasOne(d => d.LanguageLanguage)
                    .WithMany(p => p.QuestionSet)
                    .HasForeignKey(d => d.LanguageLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageQuestion");

                entity.HasOne(d => d.QuestionTypeQuestionType)
                    .WithMany(p => p.QuestionSet)
                    .HasForeignKey(d => d.QuestionTypeQuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionTypeQuestion");
            });

            modelBuilder.Entity<QuestionTypeSet>(entity =>
            {
                entity.HasKey(e => e.QuestionTypeId);

                entity.Property(e => e.QuestionTypeText).IsRequired();
            });

            modelBuilder.Entity<ThemeSet>(entity =>
            {
                entity.HasKey(e => e.ThemeId);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeName).IsRequired();

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.ThemeSet)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThemeSet_AccountSet");
            });

            modelBuilder.Entity<AccountSet>().Ignore(c => c.Id)
                .Ignore(c => c.AccessFailedCount)
                .Ignore(c => c.LockoutEnabled)
                .Ignore(c => c.TwoFactorEnabled)
                .Ignore(c => c.LockoutEnabled)
                .Ignore(c => c.LockoutEnd)
                .Ignore(c => c.SecurityStamp)
                .Ignore(c => c.NormalizedEmail)
                .Ignore(c => c.NormalizedUserName)
                .Ignore(c => c.ConcurrencyStamp);

            modelBuilder.Ignore<IdentityRole<string>>();
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
