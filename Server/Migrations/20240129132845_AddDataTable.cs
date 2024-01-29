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
                values: new object[] { "941958ae-3c86-4ce5-92e8-f0e6ca1d3856", "AQAAAAIAAYagAAAAEI6NTY4dMNfYRdz8RZ0pGQC/ylwpd4kF6waLlo5bF2SWLddwflVwROGmQgD1KiKADQ==", "8f59f758-63ab-4dad-b5ea-d1a30eabb838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef23da1b-8ae7-4dc3-9407-f4f070985c5e", "AQAAAAIAAYagAAAAEKUJ29lpu4eCH+X44w9fRLZqoFKWnV5lIbw0x8US/6Ato1eo2vnuwNcxyafOAwm8pA==", "ce9a32f2-01a4-4dfc-b720-db0143c1f175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa19296-63b9-4f1c-a31c-c4e87c638d30", "AQAAAAIAAYagAAAAEPJs/Vg67FZe7rrPW57Qhl1cnBs7wTAdQSn8HbF9Qwt24jnyd8gud1qIj9bOhtAhyw==", "cdba0fe9-6e49-40ba-9c71-d6574b050d1f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8709), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8713), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8439), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8450), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 1, 29, 21, 28, 45, 19, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(150), new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 1, 29, 21, 28, 45, 20, DateTimeKind.Local).AddTicks(177) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3176a505-b0d2-42b7-a759-a4bdd66560da", "AQAAAAIAAYagAAAAEPNoUU7PRZnyZlkENQcrdByy1KmdUNcHnrzp8U99ed4ySqZ3yaa4EpKWfCCpyT7Uaw==", "fa0edae7-452c-47d8-ac88-61cf6dde9238" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebdcc168-0c11-4631-9a1a-21b80e55857d", "AQAAAAIAAYagAAAAEHuv/BIR8RnCVpNtYd9SRPYyUetMlEEq4CbH2Zuy0+L8mWBsc9WyzADz3sTEZHXjLQ==", "4204748e-31c5-41f4-a1d4-d0d83c48778d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d716fc6-bb4b-4638-b527-0de0bc1f3b5d", "AQAAAAIAAYagAAAAEHs/ABPdP3L5jEJXMygfXDPC0udRaZlAYHNFtf+N/SHLmFJJnB9dcIrLz3XuHID9xA==", "e8189999-e58f-4b52-9d8e-a0987f6ea8a3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3784), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4520), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3332), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 1, 29, 21, 28, 31, 343, DateTimeKind.Local).AddTicks(4675) });
        }
    }
}
