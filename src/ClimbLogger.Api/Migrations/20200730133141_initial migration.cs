using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClimbLogger.Api.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClimbEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClimbDate = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimbEntries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClimbEntries");
        }
    }
}
