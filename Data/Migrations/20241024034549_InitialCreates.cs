using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChallengePetFriends.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Species = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    PhysicalDescription = table.Column<string>(type: "TEXT", nullable: true),
                    PersonalityDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    JoinedDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "JoinedDate", "Name", "PersonalityDescription", "PhysicalDescription", "Price", "Species" },
                values: new object[,]
                {
                    { 1, 3, new DateOnly(2024, 1, 15), "Buddy", "Friendly and energetic", "Small, brown with white spots", 250.00m, "Dog" },
                    { 2, 2, new DateOnly(2024, 2, 20), "Mittens", "Playful and curious", "Black with green eyes", 150.00m, "Cat" },
                    { 3, 5, new DateOnly(2024, 3, 13), "Charlie", "Talkative and social", "Green feathers with red tail", 300.55m, "Parrot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
