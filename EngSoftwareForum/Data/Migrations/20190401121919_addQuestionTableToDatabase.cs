﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EngSoftwareForum.Data.Migrations
{
    public partial class addQuestionTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question",
                table: "Questions");
        }
    }
}
