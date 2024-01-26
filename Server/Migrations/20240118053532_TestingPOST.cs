using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class TestingPOST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7428f2-b089-45e1-87b2-80542021e7d0", "AQAAAAIAAYagAAAAEGsMypJBZXi9/806OPaz30mmj5PkculbZPN2sF6+y61twByfqpvCrI98K9ruLt7mlQ==", "ee3feabc-288b-4fd2-b7f6-c47f8084c37f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6304), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6723), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6726), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7351), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7354), new DateTime(2024, 1, 18, 13, 35, 31, 851, DateTimeKind.Local).AddTicks(7355) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b4b5239-781e-4318-a581-119e5e2d71bb", "AQAAAAIAAYagAAAAECyrqlpDBOb5dwfgxm9wBjbxKlrPY8urQDYD3xM84GrTGVjw1uwC/s7DVlsyddxg+w==", "a75dd777-2ab4-4a2a-bd03-6fc1e23b3f5d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5226), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5409), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5915), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5752), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(4895), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 1, 18, 13, 2, 16, 691, DateTimeKind.Local).AddTicks(6091) });
        }
    }
}
