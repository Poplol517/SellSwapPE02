using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9052), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(7438), new DateTime(2024, 1, 14, 21, 35, 11, 141, DateTimeKind.Local).AddTicks(7439) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 1, 14, 21, 34, 58, 126, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 125, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 1, 14, 21, 34, 58, 125, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 34, 58, 125, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 1, 14, 21, 34, 58, 125, DateTimeKind.Local).AddTicks(9491) });
        }
    }
}
