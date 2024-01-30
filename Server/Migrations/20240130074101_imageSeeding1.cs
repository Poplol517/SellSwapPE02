using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class imageSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a3f4c77-96a9-4b5b-8541-f97d17cb69f0", "AQAAAAIAAYagAAAAENExR+TGanWo8gRKHjUriyxTQG5obl0A1We1B1HnfURW/6d6izDzcSoFpgaQRRYS9w==", "71c0dbc5-c875-4ab6-aeb9-7279e517ba9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f04064-b320-424b-b5a2-1e3328f27163", "AQAAAAIAAYagAAAAEFkSrgoM9wGrGpgMRHKyJHnMMGsvaQdnTWLBbJ+Klgc0ktOFJMoa2cxEocx5yccKVA==", "31fdc43b-dcb6-49ca-9d82-a7ed69e3e99b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354ade4f-cbea-451a-a13f-ba4f814b5adc", "AQAAAAIAAYagAAAAEHF1mx03Fna0Rn9rlxTny94ictYWAHRJQINwprihFz40fpT4jqWe4X81WMGs1RODUQ==", "48e2f3eb-c617-492e-b7cb-dde7ce3380a7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6569), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5958), "/images/iphone-15-finish-select-202309-6-1inch-black.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5961), "/images/vn-11134207-7r98o-ll5dstlhxsjad9_880302e6f6444e4189236838fbb1c647.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5964), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5965), "/images/Hisense-A4-32-HD-Smart-TV.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5968), "/images/_mg_9210_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5971), "/images/download.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5974), "/images/img_0509-edit.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(5976), "/images/718X1SWIsjL._AC_UF1000,1000_QL80_.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6037), "/images/download (1).jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6040), "/images/81IWsqrVMTL._AC_UF894,1000_QL80_.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6043), "/images/81kmuPJ9IOL.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6045), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(6046), "/images/amazon_echo_dot_3__echo_dot_3r_1610044909_d1b25298_progressive.jpg" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 1, 30, 15, 41, 0, 935, DateTimeKind.Local).AddTicks(7421) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7f98b6-18a9-4dc2-b942-aa135c9a3424", "AQAAAAIAAYagAAAAEDsmu7bd6L958YhDOQjbIIODev/Oun8L2gIYIDL8ecNnaG6JRYat6PpqAJMeuEMNxA==", "d5d2749c-1fd9-4ad7-9fbc-8e9703a04725" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43e33fef-2e40-44d1-9441-1041d022dc3b", "AQAAAAIAAYagAAAAENjtYckSYOiv0rp26agkpQnA/VEqyCujAbMP5KxBNw8cCIzFt6QSE4t/8IQ8ORyTxw==", "a1adb415-9a0d-428e-9c86-28254551c0ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3c8604-870a-4549-b1ec-f306dbfa851f", "AQAAAAIAAYagAAAAEGRHPz0Kp3G1kmm9S9ouM0ZEuxyPqQFSw8HXRu8UWEMXSKVoIs2IlJzwc+ppgjSD+A==", "1320f548-b5dc-48a3-a100-325ee22ae7d8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(88), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(95), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(99), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(322), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9582), "wwwroot/images/iphone-15-finish-select-202309-6-1inch-black.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9586), "wwwroot/images/vn-11134207-7r98o-ll5dstlhxsjad9_880302e6f6444e4189236838fbb1c647.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9589), "wwwroot\\images\\Hisense-A4-32-HD-Smart-TV.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9591), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9592), "wwwroot\\images\\_mg_9210_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9595), "wwwroot\\images\\download.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9598), "wwwroot\\images\\img_0509-edit.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9600), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9601), "wwwroot\\images\\718X1SWIsjL._AC_UF1000,1000_QL80_.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9603), "wwwroot\\images\\download (1).jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9606), "wwwroot\\images\\81IWsqrVMTL._AC_UF894,1000_QL80_.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9609), "wwwroot\\images\\81kmuPJ9IOL.jpg" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 1, 30, 15, 34, 12, 577, DateTimeKind.Local).AddTicks(9612), "wwwroot\\images\\amazon_echo_dot_3__echo_dot_3r_1610044909_d1b25298_progressive.jpg" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(940), new DateTime(2024, 1, 30, 15, 34, 12, 578, DateTimeKind.Local).AddTicks(940) });
        }
    }
}
