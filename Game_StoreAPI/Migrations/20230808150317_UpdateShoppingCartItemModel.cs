using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShoppingCartItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Games_GameId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3760), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 8, 8, 18, 3, 17, 575, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Games_GameId",
                table: "ShoppingCartItems",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Games_GameId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8301), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 8, 6, 17, 20, 40, 270, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Games_GameId",
                table: "ShoppingCartItems",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
