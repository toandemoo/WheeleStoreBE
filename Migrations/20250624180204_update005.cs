using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class update005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Code",
                table: "orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 1, 2, 2, 968, DateTimeKind.Local).AddTicks(1275));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "orders",
                type: "NVARCHAR(100)",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

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
    }
}
