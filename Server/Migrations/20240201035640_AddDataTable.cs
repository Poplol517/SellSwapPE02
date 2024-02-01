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
                values: new object[] { "a97e907c-ff6b-4285-9268-bf208951d44e", "AQAAAAIAAYagAAAAEIf8X04cYud6VowCckjJcnBe/nwg0MFwwCLCOO0YI/wK7NFE942GIavBVObt3psR1A==", "affbde74-3e89-49c7-b353-44c741413c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba2fa18a-2b83-4e02-92b7-afe07e97c50e", "AQAAAAIAAYagAAAAEHrA9cE8+X12xEJ1KZym9x15nmfBUZzpmN0itbeZYNvXy+4dPXYh1ujThGxEhx1Tjw==", "2433bafb-a1cb-4712-97de-593954c355d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71c44e4e-5293-44ba-86b1-2ed7053ad744", "AQAAAAIAAYagAAAAEP6tGWMstEg01Iut3cLpYoDxhJivME0YmQWQlD7mwNHvr0gvkfldOhW+05M0DzZihA==", "c3f08e72-2b9f-41da-bfb1-7c08e79225a5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1976), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1983), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1989), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2412), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 2, 1, 11, 56, 39, 845, DateTimeKind.Local).AddTicks(3556) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69787528-2dce-427c-9d06-d8d3f1d1e657", "AQAAAAIAAYagAAAAEJlO1regKJEIYTcd5Am3oEZGmG9WnoEBmp9jupOJ3xrobX2ZdOLGXSJ82IzrgysXpg==", "18a67404-ec5c-4b20-97ba-7ed9afe732c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb3b15bf-6089-42b7-8dd4-5701d7011de1", "AQAAAAIAAYagAAAAEK3r0yf6TSO3WPYgxH6sS+AV9UTMhN6t/ou2W/UQfBeLXeu6ThbjQPA1kKSh7t5e7Q==", "348c8b06-cb82-4b3d-92ad-29afc0b34366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eee2dba-20e0-4948-886d-5a3bbdda4d50", "AQAAAAIAAYagAAAAEJoq1P7PFfMS8sSFbR1qXC1fOdzG36dNpyuCMczsRKgnqC0RY4XexJpRbCBPv7XVgQ==", "8dc7077d-6e75-449c-9f8d-d79571e18a41" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9575), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9844), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9846), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8891), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8916), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8924), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8928), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8946), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8950), new DateTime(2024, 2, 1, 11, 56, 31, 967, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 2, 1, 11, 56, 31, 968, DateTimeKind.Local).AddTicks(637) });
        }
    }
}
