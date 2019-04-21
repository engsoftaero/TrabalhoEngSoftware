using Microsoft.EntityFrameworkCore.Migrations;

namespace EngSoftwareForum.Data.Migrations
{
    public partial class addRepliesUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Replies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Replies");
        }
    }
}
