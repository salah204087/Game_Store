using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeDataGameTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "Id", "About", "AddedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "An adventure game (rarely called quest game) is a video game genre in which the player assumes the role of a protagonist in an interactive story, driven by exploration and/or puzzle-solving.", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1494), "Adventure game", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1543) },
                    { 2, "Action games emphasize physical challenges that require hand-eye coordination and motor skill to overcome. They center around the player, who is in control of most of the action. Most of the earliest video games were considered action games; today, it is still a vast genre covering all games that involve physical challenges.", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1546), "Action", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1547) },
                    { 3, "Simulation video games are a diverse super-category of video games, generally designed to closely simulate real world activities", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1549), "Simulation video game", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1550) },
                    { 4, "A sports video game is a video game that simulates the practice of sports. Most sports have been recreated with a video games, including team sports, track and field, extreme sports, and combat sports.", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1552), "Sports", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1554) },
                    { 5, "Platform games (or platformers) have gameplay primarily centered around jumping and climbing to navigate the player's environment. They may have enemies or obstacles to avoid and fight or may just be pure jumping puzzles.", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1555), "Platform game", new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1557) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
