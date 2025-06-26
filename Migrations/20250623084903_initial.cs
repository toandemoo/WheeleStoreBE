using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "refreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refreshTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Password = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    LicensePlate = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    PricePerDay = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CarTypeId = table.Column<int>(type: "INT", nullable: false),
                    BrandId = table.Column<int>(type: "INT", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cars_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cars_carTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "carTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wishLists",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "INT", nullable: false),
                    Carid = table.Column<int>(type: "INT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    WishListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wishLists", x => new { x.Userid, x.Carid });
                    table.ForeignKey(
                        name: "FK_wishLists_cars_Carid",
                        column: x => x.Carid,
                        principalTable: "cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wishLists_users_Userid",
                        column: x => x.Userid,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderCars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INT", nullable: false),
                    OrderId = table.Column<int>(type: "INT", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderCars", x => new { x.OrderId, x.CarId });
                    table.ForeignKey(
                        name: "FK_orderCars_cars_CarId",
                        column: x => x.CarId,
                        principalTable: "cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderCars_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yamaha" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suzuki" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYM" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VinFast" },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piaggio" }
                });

            migrationBuilder.InsertData(
                table: "carTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manual" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scooter" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clutch Bike" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric Bike" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Motorbike" }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "BrandId", "CarTypeId", "CreatedAt", "ImageUrl", "LicensePlate", "Name", "PricePerDay", "Status" },
                values: new object[,]
                {
                    { 1, 11, 11, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9164), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "33E-33333", "Honda Wave Alpha", 18000000m, "Available" },
                    { 2, 11, 12, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9178), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "35G-55555", "Honda Vision", 31000000m, "Available" },
                    { 3, 12, 11, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9180), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "34F-44444", "Yamaha Sirius", 19000000m, "Available" },
                    { 4, 12, 13, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9182), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "33E-33333", "Yamaha Exciter 155", 47000000m, "Available" },
                    { 5, 13, 13, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9184), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "32D-22222", "Suzuki Raider R150", 50000000m, "Available" },
                    { 6, 14, 11, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9186), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "31C-11111", "SYM Elegant 50", 17000000m, "Available" },
                    { 7, 15, 14, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9188), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "30B-67890", "VinFast Klara", 39000000m, "Available" },
                    { 8, 16, 12, new DateTime(2025, 6, 23, 15, 49, 2, 554, DateTimeKind.Local).AddTicks(9190), "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg", "29A-12345", "Piaggio Liberty", 56000000m, "Available" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_BrandId",
                table: "cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_CarTypeId",
                table: "cars",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orderCars_CarId",
                table: "orderCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_wishLists_Carid",
                table: "wishLists",
                column: "Carid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderCars");

            migrationBuilder.DropTable(
                name: "refreshTokens");

            migrationBuilder.DropTable(
                name: "wishLists");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "carTypes");
        }
    }
}
