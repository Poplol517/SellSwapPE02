using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e391890-fa09-498e-8495-371eb4d27cff", "AQAAAAIAAYagAAAAEEo7FkYJg66VLfQe4NTGes1/8hYtLDHwTVmlGZTQedCux2HDcd6QizgtCCbOol/5Rw==", "2438d833-30e8-417b-be2f-632ed9ba0bb8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8251), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(7809), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 1, 15, 23, 23, 35, 890, DateTimeKind.Local).AddTicks(8628) });
        }
    }
}
