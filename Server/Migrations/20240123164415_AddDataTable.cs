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
                values: new object[] { "7c6a14d0-1d78-4d85-aba7-8f0bc84b9efe", "AQAAAAIAAYagAAAAEK+6k10C2atgA9bENOLdUDgEmKwIHBHz7dqRwsfR6gLOa09QDasw63o5RdrJmgnH2g==", "e6b903fe-00e6-4a62-9c10-7733f80699df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "813c256d-01a9-4298-bc27-70496f5516b6", "AQAAAAIAAYagAAAAEHt41gzd/RPpzIqM6TU8wUw9pVhmkKT/WNpScRIe2tUm8F+B49CfG0mph4PUVZr2cA==", "9c895c19-3ca9-4f89-8ba1-2c41e23db8e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03e86385-6867-4779-93b2-a945cafdc621", "AQAAAAIAAYagAAAAEJl83QSZQC3U3a/fUC1UT2CTRUSD44jIRPxjFEP9a3XnF/taNOKj+hpOm1I+BQafvg==", "d21bd5b3-2067-4158-9d2b-f1142a352d3f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2672), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2679), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2867), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2143), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3383), new DateTime(2024, 1, 24, 0, 44, 14, 751, DateTimeKind.Local).AddTicks(3383) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5c010d-5c87-4513-bd46-de16cc2c685f", "AQAAAAIAAYagAAAAEOb+HWw5xHqNsuNWomnM0NXAkPMLn8FBYdwkhF22bu2NQ+hbZrCZDLPRE/Ui1SVgng==", "f70dc6cd-fc64-4fab-81d6-c1420783c21b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c46c411-e71f-452f-8a33-71668f517519", "AQAAAAIAAYagAAAAEHXt2od57/WQ48Yrrd9zT8MLUThRPKsQ4xykh1mwvSJsNp2g7zmj9WtyxA7Kdjq6Cg==", "4431b24c-f183-4143-aff9-91597ee69d4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9bb0ab6-5213-4985-ba0f-61d9e863a0ba", "AQAAAAIAAYagAAAAEBncn6BMvx5H5ZsCieGaQXOdNqaqqqDEItWSV1DdbwsKclrMwhrZi+SXJucalBPH9w==", "3c4eb17a-ec7d-48b7-84b9-a86d35e7563a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2315), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2317), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2676), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2554), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2557), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2799), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 1, 24, 0, 44, 6, 822, DateTimeKind.Local).AddTicks(2801) });
        }
    }
}
