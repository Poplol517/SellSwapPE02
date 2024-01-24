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
                values: new object[] { "e15f1744-bf98-420d-8237-ce386fbeb386", "AQAAAAIAAYagAAAAENd0aCbhWkMkTSzBAZ6I6P4uiu1vbLydnJo0JXrVuw6dkpgT6nKpls6KmI/vlqvjhg==", "77369210-e3a2-4e8b-8b29-fbf61d183f58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78b231d5-f2e7-4c80-a17f-51346eba5c92", "AQAAAAIAAYagAAAAEKa2Nf0ICUWnWs11AE18Kwi+SkMnGBnhoJxlJEYEmS5oIFDtLiZAl5A98PZIvUKr4A==", "77d4933e-8b1f-4eed-80a9-0985ac3a0f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e05c8424-8e1e-4166-b94a-98adf38dfdd0", "AQAAAAIAAYagAAAAEDCSnuIn1s4Fanl06CxGjSl8hx8ri7KD/DWNdnVHYZANsUVMbuf/oid5JYCK1fO9iQ==", "8649d90a-1e8c-4fc2-9c06-6472d02f1118" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8218), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(7986), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 1, 24, 21, 6, 2, 859, DateTimeKind.Local).AddTicks(8852) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed7eb13d-be4b-4328-98c0-39119ab2607e", "AQAAAAIAAYagAAAAEC+UUzrR0m3bn0P8E2EDlJVE2VLwEYMns/RAIGHD1CqsjuxMUmQpEFFiUsxeFZWrMg==", "572b0e2d-eacf-431f-8348-ce674c5ea7e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5437928-4902-4482-b2af-f0ec33f0d0f3", "AQAAAAIAAYagAAAAEGKEGirFxSx3tYFc1NXMgR3HF97B68kiF/NZ8LUcfAxiCIJjSw+6i4bCYycjG+JjDQ==", "2bb5f55c-b88d-40a6-9e7b-a3055943e5a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "241ebc47-54fc-40a0-b8b1-69ff3ff17b1b", "AQAAAAIAAYagAAAAEPlq196qrkeJVprXLzwXb9DwIyk+nM9T6y+9L1d5UZikxXbTCMp29c2kfPscUfs9kw==", "603f15f4-63f5-4078-9853-7821f08d282b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2484), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3054), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2656), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2659), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3218), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3224), new DateTime(2024, 1, 24, 21, 5, 56, 389, DateTimeKind.Local).AddTicks(3225) });
        }
    }
}
