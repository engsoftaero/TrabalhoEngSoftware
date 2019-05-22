using Microsoft.EntityFrameworkCore.Migrations;

namespace EngSoftwareForum.Data.Migrations
{
    public partial class AddUsersThatVotedOnQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersDownVoteQ",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersUpVoteQ",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersDownVoteQ",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UsersUpVoteQ",
                table: "Questions");
        }
    }
}
