using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8468cf3-a767-4009-a568-0ea065674222", "AQAAAAIAAYagAAAAEOJ51wskwjrjzLDpLKotv/XuPiqmHbsKZ1d3GHPchdzYeuQai2WePXdB/xoTWy2EQQ==", "3f658e1f-4390-4a7b-a859-14ac0caa3b87" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3646), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3274), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3278), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2565), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2579), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 1, 16, 16, 17, 7, 755, DateTimeKind.Local).AddTicks(3805) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd919b2a-c3f2-441b-8b58-686871c8df8f", "AQAAAAIAAYagAAAAEKbJpD7QIBWDrccaxrclrjkpEdkezOF/NoKSfFmHS28Tt75ohf4sHoyTDKtXW2TWWA==", "59ceb726-7a8d-4de5-87fd-2468813b44f0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2033), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2651), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2655), new DateTime(2024, 1, 16, 16, 15, 45, 360, DateTimeKind.Local).AddTicks(2656) });
        }
    }
}
