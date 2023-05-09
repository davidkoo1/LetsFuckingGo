using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace appTutorial.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Testname = table.Column<string>(type: "TEXT", nullable: true),
                    TestDiscription = table.Column<string>(type: "TEXT", nullable: true),
                    TestTime = table.Column<int>(type: "INTEGER", nullable: false),
                    AutorID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
