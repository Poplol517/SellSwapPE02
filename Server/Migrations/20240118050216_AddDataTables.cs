using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddDataTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff003e6-7f5f-4f23-8355-a73ae90dee77", "AQAAAAIAAYagAAAAEKSwXL7dwLeFdFT1XiN9ivvTmsdjCGujcxhtdHxcQPb92/pqYGlQGRTbW+XmlKNlwA==", "3fbd2c97-0be0-4844-b78d-165820e13da3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(321), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(506), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(679), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(681), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 955, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 1, 18, 13, 2, 2, 955, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 955, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 1, 18, 13, 2, 2, 955, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 1, 18, 13, 2, 2, 956, DateTimeKind.Local).AddTicks(1253) });
        }
    }
}
