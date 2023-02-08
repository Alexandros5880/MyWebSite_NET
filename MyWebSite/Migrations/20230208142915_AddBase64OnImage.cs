using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class AddBase64OnImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Base64",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9d3f217d-3a11-4bd9-b4b4-64929ed3b91d", new DateTime(2023, 2, 8, 16, 29, 14, 627, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "9f8b3a2b-9a9c-41c0-be5e-6a97fc442803", new DateTime(2023, 2, 8, 16, 29, 14, 627, DateTimeKind.Local).AddTicks(6595), "AQAAAAEAACcQAAAAEEF2UvnPMwkoIjdawFPKZXwx7A2eS/isLEXEu3tKhHcBMaGwuhShoPY8w9fGjItm9w==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 2, 8, 4, 29, 14, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 4, 29, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 8, 16, 29, 14, 627, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "SubTitle" },
                values: new object[] { new DateTime(2023, 2, 8, 16, 29, 14, 626, DateTimeKind.Local).AddTicks(8458), "About me" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "A B&B App writen in Java For Elevator Maintence Company.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 7,
                column: "Description",
                value: "A B&B App on Salesforce For Elevator Maintence Company.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64",
                table: "Images");

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
                columns: new[] { "CreatedDate", "SubTitle" },
                values: new object[] { new DateTime(2022, 9, 4, 23, 13, 17, 651, DateTimeKind.Local).AddTicks(6903), "A bot about me" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "A B&B App on Salesforce For Elevator Maintence Company.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 7,
                column: "Description",
                value: "A B&B App writen in Java For Elevator Maintence Company.");
        }
    }
}
