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
                values: new object[] { "17047b88-eda5-4ebc-8c97-906ba21a01b7", "AQAAAAIAAYagAAAAEMXBjhzSSfUktwsUGS6LDNkd8gUDXnCJzxaiBMzw9sbWjLAkicAUNe1vp3/k7JxIIg==", "9fd21625-67f3-4536-9565-0f0e42cfc4ef" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7893), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8020), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 1, 21, 21, 8, 39, 587, DateTimeKind.Local).AddTicks(8407) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43b38e1d-b20f-40b2-a86a-69ab3a3a8d25", "AQAAAAIAAYagAAAAEIxe40w22rDt/Komx1jfD8hNAJJZJMbBdLmMF7zkZN1qsTwaY7v4N4wVI0067zammw==", "5fc87338-36fb-4d0b-afad-f037111186c1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 1, 21, 21, 8, 28, 103, DateTimeKind.Local).AddTicks(7227) });
        }
    }
}
