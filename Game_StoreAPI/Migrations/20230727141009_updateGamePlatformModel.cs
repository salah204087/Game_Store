using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateGamePlatformModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 7, 27, 17, 10, 9, 514, DateTimeKind.Local).AddTicks(3000) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
