using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramForum_ServerCore.Migrations
{
    public partial class ChangeAccountSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AccountSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AccountSet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AccountSet",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AccountSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AccountSet",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AccountSet");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AccountSet");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AccountSet");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AccountSet");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AccountSet");
        }
    }
}
