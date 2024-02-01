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
                values: new object[] { "3b7e0b63-c8c0-4bf3-8e55-75d3df2834fb", "AQAAAAIAAYagAAAAEKtIz3HALIaGfegdR8MnJmyNrESvnjL91851zDc48L9E4EOTmwEK5dOF4FQd0k71yQ==", "b10532b0-5ddd-4369-9b6c-5ff5f6c274e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb4eb88-5523-41e9-b92b-5e80a1d698b7", "AQAAAAIAAYagAAAAEGj6bT3sy1iFgtQvijwsX6f9zSmRDaBbcWtrOfGwhkUcs9zwgv4M9gIgT4ayXmAR/A==", "59328672-f84f-44bf-8bc9-5a71bdb0d688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab195132-e67a-45f5-b939-ce5b260c8646", "AQAAAAIAAYagAAAAEAq+/3oEMiU6YK2bexbFsCteWyUHVmMB1WUx6+2IIyoBU5lLV/f7ghHQ8O6LWw5pQg==", "769c2208-1693-46e2-8e4a-ef45dc404ed8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(398), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(555), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(814), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(688), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(940), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 2, 1, 23, 40, 56, 218, DateTimeKind.Local).AddTicks(942) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "019a8a8b-584d-492b-a918-1628ebc87966", "AQAAAAIAAYagAAAAEFAw+VtVXVRct5R2H7NaYFX0SYLI6Ce5fC0WIdr3G5KBanS8GiXFN+CXHZLHeHEjww==", "0d529a20-ebb1-4cf8-b110-e4be0c71190d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bc9d33-2cb3-4002-abaf-621519326150", "AQAAAAIAAYagAAAAELMVEvbUnhhrB2e7zTqEU9izzjMGkF/pZifFX820c2UNRYDLTrj+dIYKf31j2hwCGQ==", "25832355-c1c2-4277-a64c-f77f0f7a084d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98cfc966-7e88-43f3-adac-642a803b75a4", "AQAAAAIAAYagAAAAECv0jIE4eYYzrmbHGjZHL0GkVumdXoxKGGdKZkz9jTRQLIacPcogLhu9sMyeN5kP/g==", "1ff7d209-0076-4162-8d0f-114b3b9c3e76" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6124), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5998), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5367), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5375), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6273), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 2, 1, 23, 40, 44, 177, DateTimeKind.Local).AddTicks(6277) });
        }
    }
}
