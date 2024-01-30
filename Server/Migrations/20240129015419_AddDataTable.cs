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
                values: new object[] { "dbbbd9de-565a-4073-a5a6-76974840ae58", "AQAAAAIAAYagAAAAEAoOvO6jbJ68aqPWqTw6Nb5zqL/fT0uv02gE2w7qNMk2VnsO3gtWT8QOz/Uv4daZkA==", "dc533055-5742-41e2-be0b-18c9d5d916db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f77d7ff0-2026-4d57-a3ed-ca3b99a03f5d", "AQAAAAIAAYagAAAAEIPeM7XFfLLFi4iN6YuCcRYL/mJhqpmb4r/YvlckVv/QGVgk6SE181VkWoe5EqCHSg==", "628dd28a-e3ec-4588-a8a5-bacc3c5e79ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81397df5-7595-47f1-8378-a3b0cb3fd0c5", "AQAAAAIAAYagAAAAENRAIQE7Hp1DXwmSwOusxaMVYFk2DYWIDpFpQt4EPgHeeOepFm+Y9zA9IYK7mW7SGA==", "2ba2c749-e7db-4952-9aa4-eaaee737d693" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9518), new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 1, 29, 9, 54, 19, 405, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1496), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 1, 29, 9, 54, 19, 406, DateTimeKind.Local).AddTicks(1503) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eebdbd4-d827-4b23-8a3c-436f99419bb1", "AQAAAAIAAYagAAAAEMQAdjzTChuYf533sheHPQ64LoMkvMlA6Bm9/8LY8EAy1oOAFTOpiuV8JAuUPFMPyg==", "3f100d66-7a20-4df5-9b8e-e5f7e101dcf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebfa43f6-b823-46ad-8634-dcca97a409bf", "AQAAAAIAAYagAAAAEBRjGJQLfhe+ghq6LEXS6STcla9iqsBnv7vHB/vYHQQk0q9nZ0Tmhko+H47w3NWUOQ==", "8f2cc0c6-c5ba-441c-ad67-af2812e995d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2b9b08a-5b6c-4bcb-b2ac-97089a9a41b1", "AQAAAAIAAYagAAAAEF+qL3tuuT/ugHqyuk3GL9mpQXr2C96574fQLli2+KBdiRAi17HsdyXo6jdQ0nqv+g==", "5c259c35-011c-4099-bc0a-9fa9e4bcadff" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(181), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1215), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1707), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1710) });
        }
    }
}
