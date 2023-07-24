using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToPlatformTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(922), new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1002), new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 7, 24, 23, 27, 24, 473, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PS4" },
                    { 2, "PS5" },
                    { 3, "PC" },
                    { 4, "Nintendo" },
                    { 5, "Xbox One S" },
                    { 6, "Xbox One X" },
                    { 7, "Xbox Series X" },
                    { 8, "Xbox Series S" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1504), new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 7, 24, 23, 20, 19, 454, DateTimeKind.Local).AddTicks(1515) });
        }
    }
}
