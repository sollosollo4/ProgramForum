using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramForum_ServerCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountSet",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    AccountType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "('NoName')"),
                    Email = table.Column<string>(maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Points = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    Reputation = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSet", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageSet",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(nullable: false),
                    LanguageDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSet", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypeSet",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypeSet", x => x.QuestionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ConversationSet",
                columns: table => new
                {
                    ConversationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientId = table.Column<int>(nullable: false, comment: "Recipient"),
                    SenderId = table.Column<int>(nullable: false, comment: "Sender")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationSet", x => x.ConversationId);
                    table.ForeignKey(
                        name: "FK_ConversationSet_AccountSet",
                        column: x => x.RecipientId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversationSet_AccountSet1",
                        column: x => x.SenderId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThemeSet",
                columns: table => new
                {
                    ThemeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: false),
                    ThemeName = table.Column<string>(nullable: false),
                    ThemeText = table.Column<string>(nullable: true),
                    ThemePoints = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeSet", x => x.ThemeId);
                    table.ForeignKey(
                        name: "FK_ThemeSet_AccountSet",
                        column: x => x.AuthorId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionSet",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: false),
                    LanguageLanguageId = table.Column<int>(nullable: false),
                    QuestionTypeQuestionTypeId = table.Column<int>(nullable: false),
                    CorrectOption = table.Column<int>(nullable: false),
                    AccountAccountId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSet", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_AccountQuestion",
                        column: x => x.AccountAccountId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguageQuestion",
                        column: x => x.LanguageLanguageId,
                        principalTable: "LanguageSet",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionTypeQuestion",
                        column: x => x.QuestionTypeQuestionTypeId,
                        principalTable: "QuestionTypeSet",
                        principalColumn: "QuestionTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MessageSet",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageText = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConversationId = table.Column<int>(nullable: false),
                    SenderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageSet", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_MessageSet_ConversationSet_Sender",
                        column: x => x.ConversationId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageSet_ConversationSet",
                        column: x => x.ConversationId,
                        principalTable: "ConversationSet",
                        principalColumn: "ConversationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentorySet",
                columns: table => new
                {
                    CommentoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: false),
                    CommentoryText = table.Column<string>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentorySet", x => x.CommentoryId);
                    table.ForeignKey(
                        name: "FK_CommentorySet_AccountSet",
                        column: x => x.AuthorId,
                        principalTable: "AccountSet",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentorySet_ThemeSet",
                        column: x => x.ThemeId,
                        principalTable: "ThemeSet",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerSet",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerVarible = table.Column<string>(nullable: false),
                    QuestionQuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerSet", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_AnswerQuestion",
                        column: x => x.QuestionQuestionId,
                        principalTable: "QuestionSet",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FK_AnswerQuestion",
                table: "AnswerSet",
                column: "QuestionQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentorySet_AuthorId",
                table: "CommentorySet",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentorySet_ThemeId",
                table: "CommentorySet",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationSet_RecipientId",
                table: "ConversationSet",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationSet_SenderId",
                table: "ConversationSet",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageSet_ConversationId",
                table: "MessageSet",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_AccountQuestion",
                table: "QuestionSet",
                column: "AccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_LanguageQuestion",
                table: "QuestionSet",
                column: "LanguageLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_QuestionTypeQuestion",
                table: "QuestionSet",
                column: "QuestionTypeQuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeSet_AuthorId",
                table: "ThemeSet",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerSet");

            migrationBuilder.DropTable(
                name: "CommentorySet");

            migrationBuilder.DropTable(
                name: "MessageSet");

            migrationBuilder.DropTable(
                name: "QuestionSet");

            migrationBuilder.DropTable(
                name: "ThemeSet");

            migrationBuilder.DropTable(
                name: "ConversationSet");

            migrationBuilder.DropTable(
                name: "LanguageSet");

            migrationBuilder.DropTable(
                name: "QuestionTypeSet");

            migrationBuilder.DropTable(
                name: "AccountSet");
        }
    }
}
