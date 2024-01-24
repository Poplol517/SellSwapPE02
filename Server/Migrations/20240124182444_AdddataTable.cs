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
                values: new object[] { "04c6244c-a3b6-4626-be2d-9dbe539734ac", "AQAAAAIAAYagAAAAEDPp+I7Q5iTUZa7Gv+GEbvVWXlZPgBOCT8f/Ppcq119WFwBv8mO7hX2RZ+gYeieCqQ==", "5a52c902-7864-44b7-9f18-878f4db635ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3663e7-1b36-40e3-a79d-9691a5d2c80d", "AQAAAAIAAYagAAAAEKwhUeOG8qOEJS89+pGeU9Vw/p1hIEwDqingzyZQW/mctF07pC5QHhgoluo0aeDbfQ==", "8dfde2d1-158a-46c4-96f6-c8f9b8871849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c0c2d21-0008-4b9f-bbbb-ccdc2d7d2fac", "AQAAAAIAAYagAAAAEFJdYQVWdW9rFhxE1PaIP2euR3ZbRQurtUpXRmv5cNbIwE6Q7ENlaOi81RIRUnepMw==", "1752e630-7f5f-4040-8998-c72478674543" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9673), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9824), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(142), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 1, 25, 2, 24, 44, 412, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(442), new DateTime(2024, 1, 25, 2, 24, 44, 413, DateTimeKind.Local).AddTicks(442) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a56f04-8899-4262-82cf-0d669efc9180", "AQAAAAIAAYagAAAAEPfHAbGVEs+ri8OJLJ56oNmOfs5MqZ1PN+WTsyTkyCuZNXBSjMeKDIhy/e7+jx8OUg==", "f5b39840-e32a-4a6e-9bb0-269e81f41f20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "474570e8-5db7-4244-8517-63f51929ef80", "AQAAAAIAAYagAAAAEF3dOX0fvm+zcPR0BKLa/h9SK01o9Ifrdro26JzkNpjLdAw0RZtU+j8H2Sgwb/HT9g==", "2e953f77-b9c7-4a4c-831f-49f496c06955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c415f96f-e15e-44ce-a9db-9d45a424e5b4", "AQAAAAIAAYagAAAAEAzKcj637Kh3bg8M3hMY6vNl8mBrt8zp5gFDyN9hkRInp2ZpqTZfJk4QjIJ5aS/wKw==", "c249eefa-ca80-4d9c-9d05-291a5f0085fe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3240), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3650), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3528), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(2857), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 1, 25, 2, 24, 38, 706, DateTimeKind.Local).AddTicks(3784) });
        }
    }
}
