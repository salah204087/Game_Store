using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddGameCompanyTableToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCompanies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 7, 23, 16, 8, 39, 510, DateTimeKind.Local).AddTicks(2701) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameCompanies");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 7, 22, 18, 26, 5, 20, DateTimeKind.Local).AddTicks(1557) });
        }
    }
}
