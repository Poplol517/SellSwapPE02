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
                values: new object[] { "013b3b45-ad8c-41f3-95e9-5b2c0d60b1fd", "AQAAAAIAAYagAAAAEGyfuVOW0WZptUMOKdjxaiViDu4yuEeqke+ZbzAAtXv6pk8lB35W+nYTbebNVFR0zQ==", "47f14f04-6528-4894-8c48-32bbdc663c7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b0d5604-d4c5-4f7d-bf97-95522e681233", "AQAAAAIAAYagAAAAEEUHoIM/tCjUorwX6dBFUCMUO9mQ56CSnoLNb5FN1GmCTYDnVHGE0z0PNXLU5/LCWQ==", "78e10dfe-528b-496e-891b-e72267e92c9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afd4cdfe-fd1c-4949-94fc-ae47d0e417a8", "AQAAAAIAAYagAAAAED9ka3uv/upB6EROsNQ684E4PeN4h3uU1MwxwZQ1f3wrHOuNNZHNuTRUA6po0YYZMQ==", "c9d735b4-f460-4921-a11c-72a79226c1ff" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7902), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7911), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7918), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7345), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7348), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7351), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 2, 3, 22, 15, 56, 929, DateTimeKind.Local).AddTicks(8793) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9c6c3f-452f-4699-80d9-798f846fa8b9", "AQAAAAIAAYagAAAAEEQDCSDryAtpAohOfmJUVaEmwfKyoibpUv5RjCWPOSRAKgev5HgWCJ5rVlE0jkp90A==", "62d7a31d-8a85-436e-8eb0-a2fce6fb812a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc332e03-36c4-4fc3-a37d-ca9fc64ec012", "AQAAAAIAAYagAAAAEMA2988ziCAjyrkrj1bYHWk37Jjxx0ihwu9AsxT8sHtlShbhDkfVeel1YqVMgElF5Q==", "f6e5ba57-9aa3-4574-a523-b9bef3d4fef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "075dca7c-a019-46cb-8aa0-d3d00b4754fb", "AQAAAAIAAYagAAAAEP5Zq2FziUMIGX8Uab3XUmFjhQnxnu04Xa9oDSfmOVgO6CRl8nu3BTn1QvO5kRZsgg==", "100c0bc3-8e72-4ef6-98c5-073b69b99eea" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8091), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8135), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7497), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7533), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 2, 3, 22, 15, 48, 870, DateTimeKind.Local).AddTicks(9100) });
        }
    }
}
