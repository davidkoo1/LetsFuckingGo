using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace appTutorial.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    UserSurname = table.Column<string>(type: "TEXT", nullable: true),
                    UserLogin = table.Column<string>(type: "TEXT", nullable: true),
                    UserPassword = table.Column<string>(type: "TEXT", nullable: true),
                    UserStanding = table.Column<string>(type: "TEXT", nullable: true),
                    UserStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDto", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Testname = table.Column<string>(type: "TEXT", nullable: true),
                    TestDiscription = table.Column<string>(type: "TEXT", nullable: true),
                    TestTime = table.Column<int>(type: "INTEGER", nullable: false),
                    AutorID = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Tests_Users_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_AutorID",
                table: "Tests",
                column: "AutorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
