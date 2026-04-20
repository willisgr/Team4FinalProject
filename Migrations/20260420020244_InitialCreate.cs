using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Team4FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsPracticed = table.Column<int>(type: "int", nullable: false),
                    IsExpensive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStronglyTyped = table.Column<bool>(type: "bit", nullable: false),
                    IsCompiled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Developer", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Teyon", "First Person Shooter", 1.0, "RoboCop: Rogue City" },
                    { 2, "System Era Softworks", "Open World Survival Craft", 29.989999999999998, "Astroneer" },
                    { 3, "AdHoc Studio", "Point & Click", 29.989999999999998, "Dispatch" },
                    { 4, "CD PROJEKT RED", "Open World RPG", 59.990000000000002, "Cyberpunk 2077" },
                    { 5, "Relic Entertainment", "WAAAAGH Real Time Strategy", 29.989999999999998, "Warhammer 40,000: Dawn of War - Definitive Edition" },
                    { 6, "Youthcat Studio", "Base Building", 15.99, "Dyson Sphere Program" },
                    { 7, "Blizzard Entertainment, Inc.", "Action RPG", 39.990000000000002, "Diablo II: Resurrected - Infernal Edition" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "HobbyName", "HobbyType", "IsExpensive", "YearsPracticed" },
                values: new object[,]
                {
                    { 1, "3D Printing", "Digital", true, 1 },
                    { 2, "Video Games", "Digital", true, 30 },
                    { 3, "Reading", "Intellectual", false, 35 },
                    { 4, "Concerts", "Physical", true, 20 },
                    { 5, "Traveling", "Physical", true, 5 },
                    { 6, "Hiking", "Physical", false, 1 },
                    { 7, "Volunteering", "Social", false, 0 }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BSIT", "Grant Willis", "Junior" },
                    { 2, new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSIT", "Robert Mays", "Second" },
                    { 3, new DateTime(1000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "William Boulle", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
