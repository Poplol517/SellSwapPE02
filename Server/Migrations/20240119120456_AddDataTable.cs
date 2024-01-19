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
                values: new object[] { "05a03dc1-908c-4a60-91c2-8c4b2dde4367", "AQAAAAIAAYagAAAAEG9gK7lP4GTG6ev2xfv5NenQefJ28diXJ51uvjEWDTKu52dZaDUMpt7zVvFSsdPVWQ==", "32d07a0b-940b-48c2-97a0-7b6afb1a680e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2039), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2802), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2805), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 1, 19, 20, 4, 55, 841, DateTimeKind.Local).AddTicks(3022) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a120cb3-c3f9-49ca-aca0-1120b6f4b520", "AQAAAAIAAYagAAAAEFBb5lqJwbfQOaaHELC5VXqJqC/qzYWkXA3UOlP1i8lxbsfqws8HT3dZgcDUNm+UIQ==", "83fee580-a254-4c7d-8457-ea90b66c41f1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9718), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(285), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 1, 19, 20, 4, 46, 48, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(910), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 1, 19, 20, 4, 46, 49, DateTimeKind.Local).AddTicks(917) });
        }
    }
}
