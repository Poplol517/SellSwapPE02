using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a23c6b6a-b40e-4e33-a007-fa88700d2757", "AQAAAAIAAYagAAAAEHEI69dYWzXnghWkbgGdXNmjrjJbhne1MyM41Yf3/j+UftzSD+VhDHAqQBB7GNY53g==", "966d3ddb-96c6-400b-82cb-d1ae659e48d6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 238, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 1, 22, 21, 10, 38, 238, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 238, DateTimeKind.Local).AddTicks(9817), new DateTime(2024, 1, 22, 21, 10, 38, 238, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 1, 22, 21, 10, 38, 239, DateTimeKind.Local).AddTicks(937) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26c70dc6-af2f-4a8b-889b-31a62e811890", "AQAAAAIAAYagAAAAEBmODaOF2KCEAkB23c6Vjdv5wMsie+oChlkUER4QFHYZoCDAoZ8DnH19/DOYuGqXYQ==", "6be2c4cf-1719-47af-841a-29e4738e662d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8077), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8304), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9266), new DateTime(2024, 1, 22, 21, 10, 25, 139, DateTimeKind.Local).AddTicks(9266) });
        }
    }
}
