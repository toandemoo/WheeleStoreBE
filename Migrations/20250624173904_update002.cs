using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class update002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "orders",
                type: "NVARCHAR(100)",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 39, 2, 798, DateTimeKind.Local).AddTicks(1309));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "orders",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 30, 44, 204, DateTimeKind.Local).AddTicks(326));
        }
    }
}
