﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EngSoftwareForum.Data.Migrations
{
    public partial class addTagsOnCreateQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Questions");
        }
    }
}
