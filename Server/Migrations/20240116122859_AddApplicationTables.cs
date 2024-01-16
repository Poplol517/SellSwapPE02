using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a290f542-6418-4f35-8960-e1a6cb3fdbb9", "AQAAAAIAAYagAAAAEMFlnfbqHD8h1uxiiC3adgAdeA5R5hjcSesE8+Y8wNUOQnchRPDvzoptEX88hq+YnQ==", "a55d991c-7bcf-4cea-9189-58b8982de9e0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5681), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6059), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6061), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5319), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6599), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6602), new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6603) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2e257e3-ab9d-43f6-8f7f-05bd94c6338b", "AQAAAAIAAYagAAAAEOp+Q5ju2/yNWKVul2ISGsSN9Sm+zoXaK/MntiwEicNLkqRhQwGixRi6vjvlnbdUYg==", "929f1cf4-48b4-4765-89eb-f030352d56a4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3217), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3745), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3619), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3621), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3477), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(2976), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3862), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3864), new DateTime(2024, 1, 16, 20, 27, 39, 556, DateTimeKind.Local).AddTicks(3864) });
        }
    }
}
