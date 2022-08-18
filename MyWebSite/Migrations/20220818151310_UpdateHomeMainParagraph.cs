using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class UpdateHomeMainParagraph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c15fb5c0-7182-4c51-a649-a9668308a0e2", new DateTime(2022, 8, 18, 18, 13, 9, 23, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "8def480a-a87c-40ce-9e0f-28fbacd451ee", new DateTime(2022, 8, 18, 18, 13, 9, 24, DateTimeKind.Local).AddTicks(579), "AQAAAAEAACcQAAAAEFapGB26xZk0tTLzep1ZCdZFDyfp2sUvpJy/xayTTx3EE8CKAtiLmQyGYPMbtIKgBQ==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 14, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 8, 18, 18, 13, 9, 19, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 23, DateTimeKind.Local).AddTicks(6779), new DateTime(2022, 8, 18, 18, 13, 9, 23, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "Paragraph" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 23, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(6813), "\r\n                        The first book I started with was C++ at the age of 15 influenced by my brother \r\n                        'Anthony Platanios', but only as a hobby. When I was 18 I started working at a \r\n                        local gym as an instructor and I stayed in that field for 7 years. \r\n                        Right after that a friend of mine that is a programmer saw a code I made for my \r\n                        motorcycle and encouraged me to pursue programming.\r\n                    " });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9695), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(167), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(228), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(291), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(352), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(472), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(532), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(593), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(749), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(813), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(878), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(999), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1060), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1119), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1178), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1356), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1416), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1475), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1592), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1711), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1829), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1945), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2067), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2247), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2365), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2424), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2544), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2603), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2663), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2723), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2894), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3075), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3135), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3367), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3426), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3485), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3602), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3661), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3719), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3829), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3892), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3955), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4131), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4489), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4548), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4606), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4718), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4779), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4897), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4956), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5254), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5314), new DateTime(2022, 8, 18, 18, 13, 9, 22, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5732), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5781), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6325), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6383), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6433), new DateTime(2022, 8, 18, 18, 13, 9, 21, DateTimeKind.Local).AddTicks(6442) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "32f22f4c-4ae8-4c92-9723-fde902b65687", new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "27dce381-6e7b-4d46-9530-a12936976aff", new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(5934), "AQAAAAEAACcQAAAAEHcL6d2C5GXce5mwRHKFqcuuvtSrUr2DnXhcVyrsppx+TJpBpLBWA7As/X6zaa/9JA==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 962, DateTimeKind.Local).AddTicks(9629), new DateTime(2022, 8, 18, 18, 3, 4, 966, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "Paragraph" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(439), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming." });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3754), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3812), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3871), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3932), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4055), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4122), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4181), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4239), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4299), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4417), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4479), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4537), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4595), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4709), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4769), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4827), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4987), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5051), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5167), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5281), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5341), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5398), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5459), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5518), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5575), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5691), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5749), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6084), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6174), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6256), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6548), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6755), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6875), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7041), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7105), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7162), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7275), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7332), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7389), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7446), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7503), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7679), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7736), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7794), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7900), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7965), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8025), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8084), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8201), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8259), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8317), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8375), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8434), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8491), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8549), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8664), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8825), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8948), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(9007), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9375), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9897), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6), new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(15) });
        }
    }
}
