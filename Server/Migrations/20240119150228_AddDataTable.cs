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
                values: new object[] { "be5d860f-a669-4281-b394-fb849a4d3f9b", "AQAAAAIAAYagAAAAEDU+SKrrwgmoPcGJf//xmxeeW3mS69dremQCcIc7YtMitxoHjnWm13FkqlocSPrPcQ==", "21e1c8cc-2212-40ab-bbf2-adbda1af20c6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4356), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4360), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4613), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4875), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 1, 19, 23, 2, 28, 633, DateTimeKind.Local).AddTicks(4877) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e8e63d3-61ed-49b3-94d3-3f711a035722", "AQAAAAIAAYagAAAAEHTXJsM4IJ6+R2yugxRlz0YBB5SLXBI9LnoZw5ZBhtMokt4bxojM+L1Kwuc+FqBzYA==", "f0ec684a-0bf1-4660-8b27-5d125b1df3bb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2695), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(3094), new DateTime(2024, 1, 19, 23, 2, 19, 258, DateTimeKind.Local).AddTicks(3095) });
        }
    }
}
