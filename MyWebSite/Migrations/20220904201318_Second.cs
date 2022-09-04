using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "34102340-217a-4f9b-8cdb-19ba5a650c84", new DateTime(2022, 9, 4, 23, 13, 17, 651, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "83035b90-9138-4b3f-ab01-ff8dd45e934b", new DateTime(2022, 9, 4, 23, 13, 17, 651, DateTimeKind.Local).AddTicks(8916), "AQAAAAEAACcQAAAAEH6iK1C+ECE+OnY4HlZpvZflv6BbJJIeUXPU+dfPeYBRcRFay23CHt2B1EidEu9dsg==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 9, 4, 11, 13, 17, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 4, 11, 13, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 23, 13, 17, 651, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 23, 13, 17, 651, DateTimeKind.Local).AddTicks(6903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5cb81bb4-301f-4a81-b0cf-9553c55a7de8", new DateTime(2022, 9, 4, 19, 17, 47, 117, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "ebf31ab4-ccd1-447a-adac-08b5f1b6b1fa", new DateTime(2022, 9, 4, 19, 17, 47, 117, DateTimeKind.Local).AddTicks(4742), "AQAAAAEAACcQAAAAEN+Iv3LrEMEpiqg/CNn5GMuYCSKXJKkeaXfxqILlH9U1QbbmzqjYb0eBudP1WYrYLA==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2022, 9, 4, 7, 17, 47, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 4, 7, 17, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 19, 17, 47, 117, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 19, 17, 47, 117, DateTimeKind.Local).AddTicks(195));
        }
    }
}
