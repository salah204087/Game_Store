using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddGamePlatformTableTomakeManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Games_GamesId",
                table: "GamePlatform");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "GamePlatform",
                newName: "GameId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GameId",
                table: "GamePlatform",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Games_GameId",
                table: "GamePlatform");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "GamePlatform",
                newName: "GamesId");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 7, 25, 17, 48, 40, 508, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GamesId",
                table: "GamePlatform",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
