using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class HomeDataUppendBase64Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Base64",
                table: "HomeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "84e11639-94af-4843-887f-42892c689e8d", new DateTime(2023, 2, 9, 15, 22, 47, 575, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "32db8172-d20c-41cf-bc18-578ce5ff1b07", new DateTime(2023, 2, 9, 15, 22, 47, 575, DateTimeKind.Local).AddTicks(7027), "AQAAAAEAACcQAAAAENrnHQ7fM9B7ATYLll5zOhj9S2u86y+sjjfR/BSPS0h3uErzSld2gHFKUR1UHJkBow==" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 2, 9, 3, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 3, 22, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 15, 22, 47, 575, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 15, 22, 47, 575, DateTimeKind.Local).AddTicks(2736));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64",
                table: "HomeData");

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
                column: "CreatedDate",
                value: new DateTime(2023, 2, 8, 16, 29, 14, 626, DateTimeKind.Local).AddTicks(8458));
        }
    }
}
