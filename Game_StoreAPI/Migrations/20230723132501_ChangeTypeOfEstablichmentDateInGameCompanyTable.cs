using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeOfEstablichmentDateInGameCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentDate",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 7, 23, 16, 25, 1, 47, DateTimeKind.Local).AddTicks(2595) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstablishmentDate",
                table: "GameCompanies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
