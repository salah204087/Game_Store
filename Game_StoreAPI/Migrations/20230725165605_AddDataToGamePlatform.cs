using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToGamePlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamePlatform",
                columns: new[] { "GameId", "PlatformId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 }
                });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1290), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1294), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 7, 25, 19, 56, 4, 983, DateTimeKind.Local).AddTicks(1517) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatform",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 3 });

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

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9497), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9501), new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9503) });
        }
    }
}
