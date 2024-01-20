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
                values: new object[] { "abad086c-115a-4c1c-8996-8802054fac9e", "AQAAAAIAAYagAAAAEILtpdcWdqdcvEpkoM6NXq7RfsUF0VFjA/q08v0PC3otJrbOCalUwb/2auDkpaU0QQ==", "e401db1a-13f7-4a8c-b6b3-aa33fbb72d04" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9034), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 1, 20, 15, 53, 46, 555, DateTimeKind.Local).AddTicks(9438) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91ca725-afba-4b84-8772-79c8d722d2a5", "AQAAAAIAAYagAAAAEJpnxExjfUoG0gIky004nxbw1jE5BToVg72TPBvuaew7Zbw9YXg1kw24Ch/vtOv7/A==", "f8be9403-2373-4edb-be3b-4626deaa84bb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2947), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3080), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2581), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 1, 20, 15, 53, 35, 756, DateTimeKind.Local).AddTicks(3463) });
        }
    }
}
