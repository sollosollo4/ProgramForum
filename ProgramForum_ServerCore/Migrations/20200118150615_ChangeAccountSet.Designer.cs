﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramForum_ServerCore.Models;

namespace ProgramForum_ServerCore.Migrations
{
    [DbContext(typeof(ForumContext))]
    [Migration("20200118150615_ChangeAccountSet")]
    partial class ChangeAccountSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.AccountSet", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("nchar(55)")
                        .IsFixedLength(true)
                        .HasMaxLength(55);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nchar(100)")
                        .HasDefaultValueSql("('NoName')")
                        .IsFixedLength(true)
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("Points")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("Reputation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("AccountSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.AnswerSet", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerVarible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionQuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionQuestionId")
                        .HasName("IX_FK_AnswerQuestion");

                    b.ToTable("AnswerSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.CommentorySet", b =>
                {
                    b.Property<int>("CommentoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("CommentoryText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ThemeId")
                        .HasColumnType("int");

                    b.HasKey("CommentoryId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ThemeId");

                    b.ToTable("CommentorySet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.ConversationSet", b =>
                {
                    b.Property<int>("ConversationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecipientId")
                        .HasColumnType("int")
                        .HasComment("Recipient");

                    b.Property<int>("SenderId")
                        .HasColumnType("int")
                        .HasComment("Sender");

                    b.HasKey("ConversationId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("ConversationSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.LanguageSet", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("LanguageSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.MessageSet", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("ConversationId");

                    b.ToTable("MessageSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.QuestionSet", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountAccountId")
                        .HasColumnType("int");

                    b.Property<int>("CorrectOption")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("LanguageLanguageId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionTypeQuestionTypeId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("AccountAccountId")
                        .HasName("IX_FK_AccountQuestion");

                    b.HasIndex("LanguageLanguageId")
                        .HasName("IX_FK_LanguageQuestion");

                    b.HasIndex("QuestionTypeQuestionTypeId")
                        .HasName("IX_FK_QuestionTypeQuestion");

                    b.ToTable("QuestionSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.QuestionTypeSet", b =>
                {
                    b.Property<int>("QuestionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionTypeText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionTypeId");

                    b.ToTable("QuestionTypeSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.ThemeSet", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThemePoints")
                        .HasColumnType("int");

                    b.Property<string>("ThemeText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThemeId");

                    b.HasIndex("AuthorId");

                    b.ToTable("ThemeSet");
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.AnswerSet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.QuestionSet", "QuestionQuestion")
                        .WithMany("AnswerSet")
                        .HasForeignKey("QuestionQuestionId")
                        .HasConstraintName("FK_AnswerQuestion")
                        .IsRequired();
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.CommentorySet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "Author")
                        .WithMany("CommentorySet")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_CommentorySet_AccountSet")
                        .IsRequired();

                    b.HasOne("ProgramForum_ServerCore.Models.ThemeSet", "Theme")
                        .WithMany("CommentorySet")
                        .HasForeignKey("ThemeId")
                        .HasConstraintName("FK_CommentorySet_ThemeSet")
                        .IsRequired();
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.ConversationSet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "Recipient")
                        .WithMany("ConversationSetRecipient")
                        .HasForeignKey("RecipientId")
                        .HasConstraintName("FK_ConversationSet_AccountSet")
                        .IsRequired();

                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "Sender")
                        .WithMany("ConversationSetSender")
                        .HasForeignKey("SenderId")
                        .HasConstraintName("FK_ConversationSet_AccountSet1")
                        .IsRequired();
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.MessageSet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "Conversation")
                        .WithMany("MessageSet")
                        .HasForeignKey("ConversationId")
                        .HasConstraintName("FK_MessageSet_ConversationSet_Sender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgramForum_ServerCore.Models.ConversationSet", "ConversationNavigation")
                        .WithMany("MessageSet")
                        .HasForeignKey("ConversationId")
                        .HasConstraintName("FK_MessageSet_ConversationSet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.QuestionSet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "AccountAccount")
                        .WithMany("QuestionSet")
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("FK_AccountQuestion")
                        .IsRequired();

                    b.HasOne("ProgramForum_ServerCore.Models.LanguageSet", "LanguageLanguage")
                        .WithMany("QuestionSet")
                        .HasForeignKey("LanguageLanguageId")
                        .HasConstraintName("FK_LanguageQuestion")
                        .IsRequired();

                    b.HasOne("ProgramForum_ServerCore.Models.QuestionTypeSet", "QuestionTypeQuestionType")
                        .WithMany("QuestionSet")
                        .HasForeignKey("QuestionTypeQuestionTypeId")
                        .HasConstraintName("FK_QuestionTypeQuestion")
                        .IsRequired();
                });

            modelBuilder.Entity("ProgramForum_ServerCore.Models.ThemeSet", b =>
                {
                    b.HasOne("ProgramForum_ServerCore.Models.AccountSet", "Author")
                        .WithMany("ThemeSet")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_ThemeSet_AccountSet")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
