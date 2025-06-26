using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class update010 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "users",
                type: "NVARCHAR(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birth",
                table: "users",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 15, 43, 18, 454, DateTimeKind.Local).AddTicks(4660));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Birth",
                table: "users");

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
    }
}
