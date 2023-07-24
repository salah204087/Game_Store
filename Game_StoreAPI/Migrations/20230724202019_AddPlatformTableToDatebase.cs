using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPlatformTableToDatebase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platforms");

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
    }
}
