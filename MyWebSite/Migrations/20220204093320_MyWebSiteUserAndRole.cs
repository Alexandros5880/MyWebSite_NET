using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class MyWebSiteUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 85);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[] { 83, "~/ProjectImages/RemoteAutoMoto/img_3.png", 7 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[] { 84, "~/ProjectImages/RemoteAutoMoto/img_4.png", 7 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[] { 85, "~/ProjectImages/RemoteAutoMoto/img_5.png", 7 });
        }
    }
}
