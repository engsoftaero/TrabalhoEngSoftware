using Microsoft.EntityFrameworkCore.Migrations;

namespace EngSoftwareForum.Data.Migrations
{
    public partial class addUsersThatVotedOnReplies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersDownVoteR",
                table: "Replies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersUpVoteR",
                table: "Replies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersDownVoteR",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "UsersUpVoteR",
                table: "Replies");
        }
    }
}
