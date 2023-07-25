using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDateToGameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AddedDate", "Description", "GameCompanyId", "GameTypeId", "ImageUrl", "Name", "Price", "Quantity", "Rate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9486), "The game is played from either a third-person or first-person perspective, and its world is navigated on foot and by vehicle. Players control the three lead protagonists throughout single-player and switch among them, both during and outside missions.", 4, 1, "https://c4.wallpaperflare.com/wallpaper/642/482/458/gun-skull-monkey-mask-rockstar-hd-wallpaper-preview.jpg", "Grand Theft Auto V", 70f, 6, 4.5f, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9489) },
                    { 2, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9493), "Call of Duty: Modern Warfare is a 2019 first-person shooter video game developed by Infinity Ward and published by Activision.", 4, 2, "https://c4.wallpaperflare.com/wallpaper/790/727/718/face-mask-mask-military-armor-call-of-duty-hd-wallpaper-preview.jpg", "Call of Duty Modern Warfare", 60f, 10, 4f, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9495) },
                    { 3, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9497), "Assassin's Creed Origins is a 2017 action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", 2, 1, "https://c4.wallpaperflare.com/wallpaper/643/1018/529/4k-hieroglyphs-bayek-assassins-creed-origins-wallpaper-preview.jpg", "Assassin's Creed Origins", 50f, 6, 5f, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9499) },
                    { 4, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9501), "God of War is an action-adventure game franchise created by David Jaffe at Sony's Santa Monica Studio.", 5, 1, "https://c4.wallpaperflare.com/wallpaper/280/925/183/kratos-god-of-war-4-god-of-war-2018-games-wallpaper-preview.jpg", "God of War", 90f, 5, 4.5f, new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9503) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 7, 25, 18, 10, 48, 324, DateTimeKind.Local).AddTicks(7981) });
        }
    }
}
