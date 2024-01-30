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
                values: new object[] { "e247f6e3-70d5-4479-853e-8c12ae771a4d", "AQAAAAIAAYagAAAAECPAfSAHtL6wmOc60ZB4Cjlx0fQbl16nPmuxNba+dZ054yBvubFK6wOcgzkYFmwp4Q==", "6cc7afb1-b601-4542-8a1e-22a71ace3155" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "186dcb7c-553a-4a67-afd8-057bc6dbcc5c", "AQAAAAIAAYagAAAAEAb3J1pY+24OReZuZcq4LP3yBh1RJlqX28Xk0GQdmc/UjfcT2n3J7TC85UF9hoHQhg==", "85884e47-0a85-4292-a8de-9f718a6ee2d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c27497e-131c-4775-ba80-7891f40a1952", "AQAAAAIAAYagAAAAEFqRZV8cB8iBKSB1fANS/QKHWYDXtwKz/SwChwiFmEpMIbrkjpWrXDmWD3CBsdzLGQ==", "57bad482-468c-44f2-867c-f9e5ea1fb973" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5063), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5069), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5073), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5381), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 1, 30, 1, 29, 46, 986, DateTimeKind.Local).AddTicks(5972) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f9fa3ee-172c-4e65-aa6a-fa51bf3d45df", "AQAAAAIAAYagAAAAEEZ+DyeGIUSirxtZ84Q+ROytwcSIPPdZMKFItZdZH5RJwnjAqylYDR1vaGXXlSIWTQ==", "348e5133-a02c-470a-a782-0c910b996b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeb9cc6e-741e-45d9-bb4a-5f0620b027f7", "AQAAAAIAAYagAAAAEN3eZrqVyqDIi2ZwtM2AMHRJXtnH00t22H7s2GNNAXnBbuIJuMfkqmB6+qmnPQ12AA==", "e8c9fc98-adce-4c6a-a279-8eba53db9789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc4a9f3-e343-46d2-b77f-99296683ed84", "AQAAAAIAAYagAAAAEOK5/AyighFMkNkbGYwSg9782TQ0RA+PIn+gzx/D2Cg6yL7iVQ6VgFKQD2GBnvkpOA==", "e0d04d6b-c881-4bc1-a431-92750feec126" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7339), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7481), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7484), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6832), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7748), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7753) });
        }
    }
}
