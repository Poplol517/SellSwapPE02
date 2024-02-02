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
                values: new object[] { "aced6a2f-d223-41d0-bf89-488995372e3a", "AQAAAAIAAYagAAAAENTVXWBcmSe5nGkuGDVjkfdN+UPznOukd+HaWoaWhB0EIRtvt0ofpKAkMfz9ZKgGiw==", "f5f15b05-8d5e-4111-b408-e2fc1192c638" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7052bdcf-d95d-4008-8f4c-2432c0098ba9", "AQAAAAIAAYagAAAAEPcTG34zN7kuAyZyzfG7FfRG57DGtXLZTJtEQYUTDiMlY+NacnG9qgEl17og38MU0w==", "a6a2c579-eb17-4804-bbba-b497dc21531b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2aa0a9a-76cb-4d28-954a-dde097119435", "AQAAAAIAAYagAAAAELZvLNrmarLjnK9+tLZE0KJyJdxApyEUEuFS4ddp93slK1aI9RSdZi7mk/CS9uShXg==", "181fe77f-f8ac-4e24-b431-8e32e4bf195d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2501), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2945), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3332), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(433), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(448), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(480), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 2, 2, 17, 57, 10, 406, DateTimeKind.Local).AddTicks(3991) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81774c8d-6a74-40f2-ab7b-1ae39d3125fd", "AQAAAAIAAYagAAAAEERyoHnRUHT/Bbu2k+wiJ9HVx14++tAONVdsqrv1KAKR9sEHkWkkHFuBho+AwHGcnA==", "39dbeae5-aa8d-46cd-9950-642c8a964835" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3661b529-2c81-4f90-a4c1-db3ffbde22bf", "AQAAAAIAAYagAAAAEJnatTGqizzHCsXTvLpyV/y/7K2ZkZQqtpoNH2SjnEmSiixjLMlRPY5vOQklp2291g==", "ed59f75d-10d1-4be7-a8d1-14e42534a1b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0036aabc-1687-43ce-89dc-83984b394256", "AQAAAAIAAYagAAAAEJBhI3Y9P9xVDS33kN6sYWEVe6giCb94PeEsgDBiL4Bnn8FQY7cumlBLLfj99Hy6gQ==", "7db8b3a7-bdb1-48c8-af91-9e3943b51554" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1280), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1316), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1323), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2022), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2030), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(472), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 2, 17, 56, 18, 20, DateTimeKind.Local).AddTicks(3115) });
        }
    }
}
