using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakeImageAndDetailsAndEstablishRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentDate",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8326), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8401), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8409), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "GameTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9077), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 8, 2, 19, 8, 6, 269, DateTimeKind.Local).AddTicks(9089) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentDate",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "GameCompanies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
