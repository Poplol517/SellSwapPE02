

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class Listing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListingID",
                table: "Listings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b4a3a6a-57b6-47d9-ae78-febce7006021", "AQAAAAIAAYagAAAAELMVuwNk0ydwH6ns8ukl6RZmmPVvwQbLT4xDBaNUoCPed21p2wGsGzHsJTmtB4UkkQ==", "e10090d7-3b50-4c4d-8421-56987d04ed8e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4145), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ListingID" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3444), 0 });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ListingID" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(3449), 0 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(5167), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 1, 16, 15, 10, 6, 81, DateTimeKind.Local).AddTicks(5170) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListingID",
                table: "Listings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "894bafd0-4617-4a0c-a6d4-028f4320c99f", "AQAAAAIAAYagAAAAEOZyeEp9Nf1/qJ7oiod5FwDaJBv+fKp0nCo+GJRg9El6Vky9Cv1IL+XLb0CczEb4RA==", "9cb7ab66-2958-4531-a8f5-66c384896714" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(316), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 257, DateTimeKind.Local).AddTicks(9993), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(945), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 1, 15, 23, 23, 45, 258, DateTimeKind.Local).AddTicks(948) });
        }
    }
}
