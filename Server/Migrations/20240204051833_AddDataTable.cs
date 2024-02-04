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
                values: new object[] { "a27c82b9-5302-4f14-b52d-dad7810cdae9", "AQAAAAIAAYagAAAAEHS3D863mCz5gfLs7W5Wt4zeGO1O9L59Y+LOE36HlFs8OCf5fj0ch+UISJPbJ6sRQA==", "a24ceb19-2982-4a3b-91bf-41d1c5e0f7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20196c43-3e97-47bb-b473-82f156e22c3d", "AQAAAAIAAYagAAAAEPc8A6epQNFnIfiSMDKL2A8N6rl/X4ZGSItTMiDAwqe2X5Ib2URYVsNPSJjtGt4qkw==", "c43abbbd-4d69-44f9-b332-a3bfc1615f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc49823a-6630-4f5a-a0f1-94271358dc52", "AQAAAAIAAYagAAAAEMojVlMeiSX+Cj5VNxIkF012Y4rGMzNR5ppPLElxly2PWp80h/jeq4cWZvHY4zZLsQ==", "5651fa80-7ed9-45b4-891c-b731866f3166" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(125), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(313), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9518), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 2, 4, 13, 18, 33, 5, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 2, 4, 13, 18, 33, 6, DateTimeKind.Local).AddTicks(870) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47d1606-154b-4b8d-a663-20e196f642da", "AQAAAAIAAYagAAAAELi7kQg4I8gdnoB71Ad0XuslrvlvR7JYuZZUepF/GIsJ1kf9Q+xf4+QTVwfiLKsDXw==", "0b6df8eb-3114-4a0a-bfd9-6908b73410a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87fd6832-0275-4bd9-8c69-88d871450d37", "AQAAAAIAAYagAAAAEGPcz8uIzY4XzFqCaKCGGStXQL2D+Qlyyu+DAf9+3yHDGsiLnipROMmGG27OAdyZcw==", "f5cc7bf6-4e2b-4610-9672-54b80a3a2ede" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab893a7-6604-4124-ab24-04b3bd38f941", "AQAAAAIAAYagAAAAEBDB71WhywrLb3QqqHT1dNfJRo0pJqbvDkMlAC/2OK6ep2odL1/sac1ZSuFE1awO+Q==", "230431a6-81dc-4566-a505-1885297c879d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3112), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2632), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2642), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3749) });
        }
    }
}
