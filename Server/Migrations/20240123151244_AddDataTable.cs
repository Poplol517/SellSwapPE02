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
                values: new object[] { "d275420b-a0d7-4eed-a985-9adc2e02a26d", "AQAAAAIAAYagAAAAEItf+tGOsLaivlOdIySPRuMmRlP6jSQHwVImc9pBWrXCCwtn3FhQlMJyO+ZxFaQqRQ==", "414a1c95-d4ca-4cde-8edb-104d4bba0c6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da1469d-d11e-4986-aa2f-93ceb0e38885", "AQAAAAIAAYagAAAAECpuc0ClYnnsaCWln0DJokaGmDDMx9JOTEFXwbI4HJ797+CfS9e0zL43DySgB4HlUA==", "0bef86ce-1525-494f-861b-473dbf6a6f76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1684ce9-48b3-4d9a-b5f7-3bbed253e3d1", "AQAAAAIAAYagAAAAEBZIICSj5IqFu0nzmhGfTR60Uy/T1c5UYcpVBq+AqAIT/+qdF2HETuA7Ol4bN3UoLQ==", "cd2a90f2-6204-4e94-80fd-e2d18951fd15" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8309), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8311), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8439), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8977), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 1, 23, 23, 12, 43, 738, DateTimeKind.Local).AddTicks(8979) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abc6ec1-168e-468c-ab4b-2883ef5cb893", "AQAAAAIAAYagAAAAEM8jO4nWEh6lufDllUuBiOZBUEnUbBUY8W/JmPoya8Bq9xtBKJH1tbFS8qYO/uo2Wg==", "d9d2a04e-3d93-482e-80e3-dda0ef7a994b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e7d26c-c550-4b25-9419-2e2248b8eb97", "AQAAAAIAAYagAAAAEN/wqdOiolvbMZedoA9dLXKvV9KlSWxLNxb2jksPKscGsGKDPriodR0OeYgTj5rsHw==", "89797929-6954-4bd5-bc2a-a38161189a56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe942ec-de83-4c39-9fcf-22b41d2768e7", "AQAAAAIAAYagAAAAEB7QZkZHLPcjALCZZHrm/AlPZGgeGEokC6KoNwWKlBL8aUdvLlWcV41O2f5r75puJw==", "5e61d91d-1b83-4213-bee1-ee9d5b454281" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6314), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6316), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6586), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6588), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 1, 23, 23, 12, 36, 626, DateTimeKind.Local).AddTicks(6851) });
        }
    }
}
