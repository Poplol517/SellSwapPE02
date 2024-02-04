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
                values: new object[] { "756a70fb-af81-486a-accf-30b87f1d618e", "AQAAAAIAAYagAAAAEN5xue/FU0sHRfnHV+5vtPZwJsgLCN49/bTV1rgvcFAJzad7Hyufw5fEa4M+wmPaDg==", "1acca3d5-015c-43ae-aae5-b97441f1c504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f437245a-c9ea-4dd5-918f-32fc5bdeb941", "AQAAAAIAAYagAAAAEIA/aTeF4n1NHTcd1uB7KLOZtP+0GM0yzg1UG0yLatlFeXhYbn/HWfYrOSd41tLfRA==", "44b4ce40-3871-4806-b832-54a0a0e0e434" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "555d1a54-2b0e-474a-b3ad-e7aebd288636", "AQAAAAIAAYagAAAAEKuTyuGEsAmmC9j6TGjQfhGSt01PY1Gc5UY90stOm2wkfD2rV9f3O/00lGHzLwgfAQ==", "83399cec-6b90-4952-80d3-00f33ad09ba4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(249), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(562), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(409), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9635), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 2, 4, 12, 10, 25, 999, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(718), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 2, 4, 12, 10, 26, 0, DateTimeKind.Local).AddTicks(722) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "904cad40-2068-4ef3-99bd-c8471d6b102a", "AQAAAAIAAYagAAAAEMxkkbH+gOCuxZhCQIdmv2b/Gtaq8r6Oe7Yjypq5DPraS2bO9Mh4PAc1h/VnhMPQGw==", "2c823c81-c12f-4e0a-a9f2-4df69a1d4c22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bc26e2-7d25-4705-b479-3697ee50f96c", "AQAAAAIAAYagAAAAEOiYvd4JKo6XfVDwRNEvIL7ZpE3EyE8F/qmacwE9VO+gKrSfH0fSvE4izt0w/WWfxg==", "1b16e81f-19c4-4b89-9f09-c9daab71fa98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b736054-fcd4-4d36-a26d-5c1fd78f57b3", "AQAAAAIAAYagAAAAECRi9IEsb4STQL1hrIqM3B+8oR5xm4PU455meWNm+SJnY7xc7HbYfVN5BL/uTZCNAQ==", "56f31665-36de-4fb0-a1d2-76b89c76881b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3044), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4561), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2044), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2050), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2056), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2061), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2067), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2078), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5045), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 2, 4, 12, 10, 0, 841, DateTimeKind.Local).AddTicks(5056) });
        }
    }
}
