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
                values: new object[] { "f9c6e0ab-fe2c-4fbd-8d13-fb6fbcc9eee6", "AQAAAAIAAYagAAAAEEJDuHdmNC2FpYxPspZPCbt5H3bzv2R3IlS+S4VAvvy2XEvCLma1CyCYAH/dTlSvQg==", "7945f7c5-f0e9-4ae4-add4-15ecccbb4c9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aedb81d1-810f-443a-ad8b-1bcd3629dbda", "AQAAAAIAAYagAAAAEDMdKRbn+crWAPjYByviQbixP1ty59y+3fXY6cYIiE2+3PiFqniHJ0vW+JxWOLqCzg==", "865a6127-f225-4647-b8e3-d07a5d562cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd2b829c-0e4d-40f8-bcef-7ef24218974f", "AQAAAAIAAYagAAAAEDRlDlBJoNgqKoS0UpwaimtjArMQInQ0QEJpUM3CcC243lz/t2ClBaOaUM+Gogng2w==", "7e0ef8c2-ee8c-4be4-afe6-6dd2b3d31a80" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5169), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4355), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 1, 27, 2, 37, 18, 679, DateTimeKind.Local).AddTicks(5698) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81f7a506-1bdf-4a52-b5eb-6fd92d940b97", "AQAAAAIAAYagAAAAEHjGMKGeKu1POPCK2xuElJqdaEJH1evdFrugc91qPbAcYr2pmUC8hpf9jLTuwdCflg==", "1e2fa78b-f23e-479c-862b-015f5cb4ad28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0904d029-f1d8-469a-b753-b3e494d49c03", "AQAAAAIAAYagAAAAEE7EvKXZ81Kgc9DROfb4aqebPb9JbvjhHWhd7WytUiBqTIhU99Nnu7w+Z56i3vXJLg==", "cd5f64e5-6bef-48a4-87d0-d4532ed5e630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e99d208-63e6-49a4-9a0b-84de21e0409e", "AQAAAAIAAYagAAAAEPXsxOhPC+Z7t1i/YXKWPcVzrlS8F0Io71kSwcR3cOr0ywHtT/EtLkl4yq0tvQJgMA==", "d4bb5a31-694d-43f4-82c8-a5d33e23b7bd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1092), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1849), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(683), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1988), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1990), new DateTime(2024, 1, 27, 2, 37, 11, 328, DateTimeKind.Local).AddTicks(1990) });
        }
    }
}
