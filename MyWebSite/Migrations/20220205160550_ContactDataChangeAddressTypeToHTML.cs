using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class ContactDataChangeAddressTypeToHTML : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "c1ec0b8e-0d1d-4f47-9008-f98759cab534");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23cc3722-b94c-4c67-afa1-d7ab2d222c5c", "AQAAAAEAACcQAAAAEN0cuE56zZDi1NFX/NOKJWyREjy1l80bzanh1iiAwLrpMMP0aTm602097m5rTpV3bw==" });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "IsActive", "LastUpdateDate", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3151.5067962388116!2d23.77378301561652!3d37.825019817039625!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a1954d6fc743a1%3A0x5fb660bb4c6d4864!2sFlemingk%2014%2C%20Voula%20166%2073!5e0!3m2!1sen!2sgr!4v1644077031803!5m2!1sen!2sgr' width='600' height='450' style='border:0;' allowfullscreen='' loading='lazy'></iframe>", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "alexandrosplatanios28@gmail.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+30-6949277783", "Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "Email", "FacebookLink", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Paragraph", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "I'm a paragraph. Click here to add your own text and edit me. I’m a great place for you to tell a story and let your users know a little more about you.", "+30-6949277783", "A bot about me", "Hello" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactData",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HomeData",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "40b1f240-fa7b-4679-8518-0a3ded818003");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b8aa77a-3dd9-46fd-b2d4-b71804809984", "AQAAAAEAACcQAAAAEGDlZPD/YME33TAL8meXGCXAWZ3VQNQgulm9s6X2MwJZflRJoUV4MhP6cGhPMxO4MQ==" });
        }
    }
}
