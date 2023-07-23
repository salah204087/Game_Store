using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataToGameCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameCompanies",
                columns: new[] { "Id", "Details", "EstablishmentDate", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Nintendo Co., Ltd.[b] is a Japanese multinational video game company headquartered in Kyoto. It develops, publishes and releases both video games and video game consoles.", "23 September 1889", "https://persiadigest.com/wp-content/uploads/2022/05/3-new-SNES-and-NES-games-are-now-available.jpg", "Nintendo" },
                    { 2, "Ubisoft Entertainment SA (/ˈjuːbisɒft/; French: [ybisɔft];[5] formerly Ubi Soft Entertainment SA) is a French video game publisher headquartered in Saint-Mandé with development studios across the world. Its video game franchises include Assassin's Creed, Far Cry, For Honor, Just Dance, Prince of Persia, Rabbids, Rayman, Tom Clancy's, and Watch Dogs.", "28 March 1986", "https://cloudfront-us-east-2.images.arcpublishing.com/reuters/YSIZCJEAI5PDDLYHNZZCI5F2FI.jpg", "Ubisoft" },
                    { 3, "Electronic Arts Inc. (EA) is an American video game company headquartered in Redwood City, California.", "27 May 1982", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Electronic-Arts-Logo.svg/1200px-Electronic-Arts-Logo.svg.png", "Electronic Arts" },
                    { 4, "Activision Blizzard, Inc.is an American video game holding company based in Santa Monica, California.", "10 July 2008", "https://www.videogameschronicle.com/files/2022/01/activision-blizzard-logo.jpg", "Activision Blizzard" },
                    { 5, "Epic Games, Inc. is an American video game and software developer and publisher based in Cary, North Carolina. The company was founded by Tim Sweeney as Potomac Computer Systems in 1991, originally located in his parents' house in Potomac, Maryland.", "1991", "https://cdn2.unrealengine.com/epic-newsroom-share-1200x630-8c559c81a614.jpg", "Epic Games" }
                });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9421), new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9425), new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9428), new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 7, 23, 16, 39, 2, 636, DateTimeKind.Local).AddTicks(9433) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameCompanies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameCompanies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2595) });
        }
    }
}
