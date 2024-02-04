using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3375e7e4-97d8-435f-aad1-f4af37508386", "AQAAAAIAAYagAAAAEC5rVDP06dod7jiNWG+ez2csODGP+HG5c5Rp5ywE94w1ck0cx2Uq93qiYSDCa7Js+Q==", "5b49a4a5-b978-406e-a33c-61356b1e7e32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87f6f5d1-0113-4c04-b73d-898c2aa475e3", "AQAAAAIAAYagAAAAELS8AhP8zqYYzCBGdhW0i4PrzhVOcNAt8uf0A0213ITT3Q3lm7rm5aCIgaCe5AVO1A==", "5defb8b6-9b2a-43ac-a5c1-c14e51890154" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18ba8528-25f5-47ca-9e9d-57667be98a17", "AQAAAAIAAYagAAAAEOPjpZqHQwgYqogVSsugy6JTv3JE4fzjK+soaXdRB0MZp8qZBcPbxIZ+0tDj5Ol1vw==", "249073c4-b3de-45c5-9d50-38d3e2d56248" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3224), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3225), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3227), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3229), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3231), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3632), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2771), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2777), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2792), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3985), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(4019), new DateTime(2024, 2, 4, 12, 58, 23, 345, DateTimeKind.Local).AddTicks(4020) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb01ff8c-6ffc-434b-9fa1-53463860bfa2", "AQAAAAIAAYagAAAAEEeJ+sGsxp8kO4u7yRHkko6DMProN/nzYMnZB4qNSRg0qkcjw+k8Pbw7k+OIhPJDuw==", "157dad0e-4ce4-40fa-8f2c-03216b519324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab06107b-7335-427c-abff-cb4dc092e209", "AQAAAAIAAYagAAAAEB1TKvVr9s5BmJmTelaH7jGB3DSagO6VyQRly/ygNrlqckOSDePavBjx7V0FZIi+eA==", "f2d83143-95b0-4548-a239-0a864e190dc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f6df670-3b24-49be-af6f-058bf545a91b", "AQAAAAIAAYagAAAAEEQCmS+jQT5Ry4YatOueYZDeBSPluXSldX5L1w3IFY+7QvmY9sHx9MPG9b4Z0zbWvw==", "57b4362f-d3d9-4920-a41e-b2dc13c50166" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8849), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9079), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9289), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8291), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8299), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8302), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 2, 4, 12, 54, 56, 834, DateTimeKind.Local).AddTicks(9727) });
        }
    }
}
