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
                values: new object[] { "14afd4a1-6801-4e02-95a3-29eb16cb93ca", "AQAAAAIAAYagAAAAEFjpytaQBk0giMxyd7N4aPTQZvrkS4EopraIobFX66XQeMy/eseF6A1ARD4+atd1qA==", "da72a918-ed15-4423-9d65-f22e13515d2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5acd2c18-0560-4f8e-8835-3eeb882171a5", "AQAAAAIAAYagAAAAEF+DGUI8v3mpyr3UJS5heUTGMCNmytYWMVOHcItyPpGDyWOILkfWxoqOrU8uxR7EfA==", "99780ad9-f368-40fb-b5b5-7f7c2a433b30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a416770a-a090-4c21-995d-082adbe1c970", "AQAAAAIAAYagAAAAEJzhxU9Q9v54DJ+NgR9V6Jxik2eX+jVc8QZKjE5Sd+gOOYavfExigX9vLgRFcHSwrg==", "1203dbf7-5572-43ad-9697-f676e0e883ec" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9743), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 1, 29, 0, 25, 29, 40, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(900), new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(906), new DateTime(2024, 1, 29, 0, 25, 29, 41, DateTimeKind.Local).AddTicks(907) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46ea9434-4d6e-4293-83a0-e1778d572702", "AQAAAAIAAYagAAAAEBTAXcs+hYyC6SqnmNiwamuQWqpxPqK4ggpCH+ET4d5SMBrZM5tTZsBcUdswYcK3Ug==", "5844d7f8-35c4-4001-924e-1ae63824ec9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673b6b78-250e-422e-9e4c-bae4bb50db41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3571bf83-40e3-486f-aaf3-3769f0275434", "AQAAAAIAAYagAAAAENo30htQhQl8iuRmpoCYF1Z233PSQTesGSTL7toNR0ZesEuAhMdSTZorYSSYeuTreA==", "74d6c83d-fedf-4a20-a2f4-3de2822a3caf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b019620-ed46-4a4e-b746-72bcef43096e", "AQAAAAIAAYagAAAAEG2AJXK166/PnbNTCsUHmrx0GFS1YkCB0EWzxTqjwLf9BQhm8xwPgNhQwc9qovAY0w==", "4d78d967-e739-4d25-a81e-031338115ee9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2764), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3089), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "ConditionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4695), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "ListingStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "ListingType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2161), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5024), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 1, 29, 0, 25, 21, 109, DateTimeKind.Local).AddTicks(5066) });
        }
    }
}
