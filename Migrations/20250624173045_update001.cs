using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class update001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "orders",
                type: "NVARCHAR(100)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "orders");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9190));
        }
    }
}
