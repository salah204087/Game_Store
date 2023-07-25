using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToGameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1114), new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 7, 25, 18, 4, 52, 475, DateTimeKind.Local).AddTicks(1131) });
        }
    }
}
