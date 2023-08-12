using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddBuyingTablesToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_GameId",
                table: "OrderItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_GameId",
                table: "ShoppingCartItems",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(6964), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7022), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7025), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7033), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7308), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7312), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 8, 4, 14, 56, 50, 859, DateTimeKind.Local).AddTicks(7318) });
        }
    }
}
