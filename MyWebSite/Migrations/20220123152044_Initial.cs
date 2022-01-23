using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "Description", "IsActive", "Path" },
                values: new object[] { 1, "My CV", true, "/CV/CV.pdf" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Description", "DownloadLink", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Online School For Data Sience.", null, 0m, "CBProject" },
                    { 2, "Salesforce App To Manipulate Your Wallet.", null, 0m, "Economy" },
                    { 3, "WordPress WebSite For KungFou School.", null, 0m, "Eelementum" },
                    { 4, "A B&B App For Elevator Maintence Company.", null, 0m, "Elevators Dashboard" },
                    { 5, "A B&B App For Elevator Maintence Company.", null, 0m, "Elevators Managment" },
                    { 6, "IPCameras Security Software.", null, 0m, "IPCameras Dashboard" },
                    { 7, "Update Your Old Vichecle To Full Software Update.", null, 0m, "Remote Auto Moto" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[,]
                {
                    { 1, "~/ProjectImages/CBProject/img_1.png", 1 },
                    { 61, "~/ProjectImages/ElevatorDash/img_12.png", 4 },
                    { 60, "~/ProjectImages/ElevatorDash/img_11.png", 4 },
                    { 59, "~/ProjectImages/ElevatorDash/img_10.png", 4 },
                    { 58, "~/ProjectImages/ElevatorDash/img_9.png", 4 },
                    { 57, "~/ProjectImages/ElevatorDash/img_8.png", 4 },
                    { 56, "~/ProjectImages/ElevatorDash/img_7.png", 4 },
                    { 55, "~/ProjectImages/ElevatorDash/img_6.png", 4 },
                    { 54, "~/ProjectImages/ElevatorDash/img_5.png", 4 },
                    { 53, "~/ProjectImages/ElevatorDash/img_4.png", 4 },
                    { 52, "~/ProjectImages/ElevatorDash/img_3.png", 4 },
                    { 51, "~/ProjectImages/ElevatorDash/img_2.png", 4 },
                    { 50, "~/ProjectImages/ElevatorDash/img_1.png", 4 },
                    { 49, "~/ProjectImages/Elementum/img_12.png", 3 },
                    { 48, "~/ProjectImages/Elementum/img_11.png", 3 },
                    { 47, "~/ProjectImages/Elementum/img_10.png", 3 },
                    { 46, "~/ProjectImages/Elementum/img_9.png", 3 },
                    { 45, "~/ProjectImages/Elementum/img_8.png", 3 },
                    { 62, "~/ProjectImages/ElevatorDash/img_13.png", 4 },
                    { 63, "~/ProjectImages/ElevatorDash/img_14.png", 4 },
                    { 64, "~/ProjectImages/ElevatorsManagmentSystem/img_1.png", 5 },
                    { 65, "~/ProjectImages/ElevatorsManagmentSystem/img_2.png", 5 },
                    { 83, "~/ProjectImages/RemoteAutoMoto/img_3.png", 7 },
                    { 82, "~/ProjectImages/RemoteAutoMoto/img_2.png", 7 },
                    { 81, "~/ProjectImages/RemoteAutoMoto/img_1.png", 7 },
                    { 80, "~/ProjectImages/IPCamerasDashboard/img_15.png", 6 },
                    { 79, "~/ProjectImages/IPCamerasDashboard/img_14.png", 6 },
                    { 78, "~/ProjectImages/IPCamerasDashboard/img_13.png", 6 },
                    { 77, "~/ProjectImages/IPCamerasDashboard/img_12.png", 6 },
                    { 76, "~/ProjectImages/IPCamerasDashboard/img_11.png", 6 },
                    { 44, "~/ProjectImages/Elementum/img_7.png", 3 },
                    { 75, "~/ProjectImages/IPCamerasDashboard/img_10.png", 6 },
                    { 73, "~/ProjectImages/IPCamerasDashboard/img_8.png", 6 },
                    { 72, "~/ProjectImages/IPCamerasDashboard/img_7.png", 6 },
                    { 71, "~/ProjectImages/IPCamerasDashboard/img_6.png", 6 },
                    { 70, "~/ProjectImages/IPCamerasDashboard/img_5.png", 6 },
                    { 69, "~/ProjectImages/IPCamerasDashboard/img_4.png", 6 },
                    { 68, "~/ProjectImages/IPCamerasDashboard/img_3.png", 6 },
                    { 67, "~/ProjectImages/IPCamerasDashboard/img_2.png", 6 },
                    { 66, "~/ProjectImages/IPCamerasDashboard/img_1.png", 6 },
                    { 74, "~/ProjectImages/IPCamerasDashboard/img_9.png", 6 },
                    { 84, "~/ProjectImages/RemoteAutoMoto/img_4.png", 7 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[,]
                {
                    { 43, "~/ProjectImages/Elementum/img_6.png", 3 },
                    { 41, "~/ProjectImages/Elementum/img_4.png", 3 },
                    { 18, "~/ProjectImages/CBProject/img_18.png", 1 },
                    { 17, "~/ProjectImages/CBProject/img_17.png", 1 },
                    { 16, "~/ProjectImages/CBProject/img_16.png", 1 },
                    { 15, "~/ProjectImages/CBProject/img_15.png", 1 },
                    { 14, "~/ProjectImages/CBProject/img_14.png", 1 },
                    { 13, "~/ProjectImages/CBProject/img_13.png", 1 },
                    { 12, "~/ProjectImages/CBProject/img_12.png", 1 },
                    { 11, "~/ProjectImages/CBProject/img_11.png", 1 },
                    { 10, "~/ProjectImages/CBProject/img_10.png", 1 },
                    { 9, "~/ProjectImages/CBProject/img_9.png", 1 },
                    { 8, "~/ProjectImages/CBProject/img_8.png", 1 },
                    { 7, "~/ProjectImages/CBProject/img_7.png", 1 },
                    { 6, "~/ProjectImages/CBProject/img_6.png", 1 },
                    { 5, "~/ProjectImages/CBProject/img_5.png", 1 },
                    { 4, "~/ProjectImages/CBProject/img_4.png", 1 },
                    { 3, "~/ProjectImages/CBProject/img_3.png", 1 },
                    { 2, "~/ProjectImages/CBProject/img_2.png", 1 },
                    { 19, "~/ProjectImages/CBProject/img_19.png", 1 },
                    { 20, "~/ProjectImages/CBProject/img_20.png", 1 },
                    { 21, "~/ProjectImages/CBProject/img_21.png", 1 },
                    { 22, "~/ProjectImages/CBProject/img_22.png", 1 },
                    { 40, "~/ProjectImages/Elementum/img_3.png", 3 },
                    { 39, "~/ProjectImages/Elementum/img_2.png", 3 },
                    { 38, "~/ProjectImages/Elementum/img_1.png", 3 },
                    { 37, "~/ProjectImages/Economy/img_7.png", 2 },
                    { 36, "~/ProjectImages/Economy/img_6.png", 2 },
                    { 35, "~/ProjectImages/Economy/img_5.png", 2 },
                    { 34, "~/ProjectImages/Economy/img_4.png", 2 },
                    { 33, "~/ProjectImages/Economy/img_3.png", 2 },
                    { 42, "~/ProjectImages/Elementum/img_5.png", 3 },
                    { 32, "~/ProjectImages/Economy/img_2.png", 2 },
                    { 30, "~/ProjectImages/CBProject/img_30.png", 1 },
                    { 29, "~/ProjectImages/CBProject/img_29.png", 1 },
                    { 28, "~/ProjectImages/CBProject/img_28.png", 1 },
                    { 27, "~/ProjectImages/CBProject/img_27.png", 1 },
                    { 26, "~/ProjectImages/CBProject/img_26.png", 1 },
                    { 25, "~/ProjectImages/CBProject/img_25.png", 1 },
                    { 24, "~/ProjectImages/CBProject/img_24.png", 1 },
                    { 23, "~/ProjectImages/CBProject/img_23.png", 1 },
                    { 31, "~/ProjectImages/Economy/img_1.png", 2 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImagePath", "ProjectId" },
                values: new object[] { 85, "~/ProjectImages/RemoteAutoMoto/img_5.png", 7 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProjectId",
                table: "Images",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
