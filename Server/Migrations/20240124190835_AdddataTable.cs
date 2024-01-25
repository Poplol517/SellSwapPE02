using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class AdddataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eceb769-c030-4a18-87b2-b7c6df2099ac", "AQAAAAIAAYagAAAAEDtnfFJVcbdD2wgrR7/k3ZK7gfSW0IS33Bg1KIGBNYHkitMFHT2HzsAKFXJ54qYOUQ==", "171e472f-81a0-4dc6-9178-bb4035ffb4b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc11e088-1175-4329-a8c5-cb04c26dba8d", "AQAAAAIAAYagAAAAEIy0D6ZW0EafBiMe6PZ+vyFACe7OIPE7/+v/uVWI5DL+Z5GPIvg9ApaNLDFQxzSNFg==", "5e4be4b5-173e-4822-a2a7-33ca869c5c56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f5869b8-3157-4bce-aa47-5ce3e8fa2946", "AQAAAAIAAYagAAAAEBhJZo3Nj0VTBBU+wBC56enBpcQ3WkK/9hea3NGeJmvxpoLSOV9vT/GvT2BW3AzLhA==", "507918b9-3438-4e77-a958-00512d9150c9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9005), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9307), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9743), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 1, 25, 3, 8, 35, 630, DateTimeKind.Local).AddTicks(9748) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3197e49b-4bea-46b9-9dfc-b89555d27b20", "AQAAAAIAAYagAAAAEM89vuFOKbqhrpZT+EqHNs54SmlcOauflJIwiqD9OKaaJMUhvGy4THidPp8wma/FUQ==", "625f546a-d5e4-44b6-a9ff-b1a6d3d770c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3217f684-5f55-4071-bd5d-db892969a47f", "AQAAAAIAAYagAAAAEGKJ5RVajguyIUXpZkPzhgZJFhqHBR4qpM0Eb268MSScEZHC1MndLbh0pZZJU/u4eg==", "63f84518-e238-47b2-b6fc-58926be9b580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87bae50-1918-4a0e-9c02-dccf881c979d", "AQAAAAIAAYagAAAAEIfIamtgv0S3tc2fNahej5LE9h2nihoSviw3N0abJIxz3yo3IBw5gX1yqdXtPwZ2RA==", "55d310ec-f2e3-49b7-902f-5f2e878fa43d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9732), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 1, 25, 3, 8, 29, 114, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(732), new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 1, 25, 3, 8, 29, 115, DateTimeKind.Local).AddTicks(738) });
        }
    }
}
