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
                values: new object[] { "ad44059b-16b2-4edd-9b14-025ad6cf72d0", "AQAAAAIAAYagAAAAEDm0Jt4z28jnYOtVilp68qCaZTTFc/0wxSsbOMvGSi/KilkTJb6icQUiDy+NvFMuug==", "8925104c-981c-4fcb-b58c-0b5e0168688f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ecd3990-32fe-42fe-9fcb-ea9a5c8fc7a5", "AQAAAAIAAYagAAAAEMJ6ampis+xz7rLIrlQo9OSLFQItjWLxQmDVsBf9FBEoUWhfNpkg4tRn0bJhR85aGQ==", "8f1c1b9d-6fe8-4dea-afda-3f7f2719ffcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9cad295-d69e-48a2-8f1b-510fbfd50540", "AQAAAAIAAYagAAAAEBguSeZfD3sz8u1v2LVlT37XYvH9YaWY0Q3Z9ke0LIaY1KAQwx/GNB4Vn18LRHkrZA==", "4132c4be-432d-43e2-8fb1-1b0405565b1d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4514), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4585), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 2, 3, 11, 9, 26, 918, DateTimeKind.Local).AddTicks(5827) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de8c1bfa-ca06-49da-883a-f8c7cd3fe5b3", "AQAAAAIAAYagAAAAENbEYy09TJKVEuqyZmVOzXZdjaqj/PghFRoQicJtMYBm23BPbiY/QdlUajZZ6etC8A==", "97146d66-af25-4791-8801-5f7da3a055d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d667cee5-2eeb-4e24-b334-73233e8d4a2b", "AQAAAAIAAYagAAAAEHouvoBtCiB7oxwLN8ADb8+t25vLsk/EGS4MpCcaD2F3qc0+OGBAKEA/yWpTaBaRfw==", "9d03416d-c12e-42f5-af19-6c7f59f45183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e715cf7-3934-4dbb-8ffe-61eb0fc92159", "AQAAAAIAAYagAAAAEPfrO5a28hRos7eBdFbmft0XRRzRZkXHMK0rPUvyqY+zmrb8eF74IjsnDfXOvoDzAg==", "6ea5f65b-28ce-4c61-bde5-23d4d3cb4abc" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9875), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9355), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9368), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9372), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 2, 3, 11, 9, 16, 536, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 2, 3, 11, 9, 16, 537, DateTimeKind.Local).AddTicks(671) });
        }
    }
}
