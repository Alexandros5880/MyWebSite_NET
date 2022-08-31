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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfingPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "ContactData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedLin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CVPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVFullPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paragraph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFullPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DownloadLinkZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadLinkTar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ImageFullPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "LastUpdateDate", "Name", "NormalizedName" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "09f6bcf0-a2c0-4612-8ad9-a46fb423282b", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(7549), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "7b429535-80f9-42bd-822c-6000f34b9969", "-Platanios719791", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(8407), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEHXk6FshHprM5qhM6ba04GHzgFo2KtD6Jbb/7WCPLDkf1jCgYMk8aam4NJbdpUd71w==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 8, 31, 18, 59, 8, 648, DateTimeKind.Local).AddTicks(714), "My CV", true, new DateTime(2022, 8, 31, 18, 59, 8, 649, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(6399), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(4505), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(3745), "", "/img/home/me.jpg", true, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(2503), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(6573), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(6869), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8330), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8338), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8357), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8359), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8373), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8375), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8388), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8390), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8636), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8641), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8694), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8697), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8712), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(8714), null, 0m, "Remote Auto Moto", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 63, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1296), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1298), 5 },
                    { 62, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1280), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1282), 5 },
                    { 61, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1264), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1266), 5 },
                    { 60, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1247), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1249), 5 },
                    { 59, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1228), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1231), 5 },
                    { 58, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1188), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1190), 4 },
                    { 57, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1172), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1174), 4 },
                    { 56, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1155), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1157), 4 },
                    { 64, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1312), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1314), 5 },
                    { 55, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1139), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1141), 4 },
                    { 53, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1107), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1109), 4 },
                    { 52, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1090), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1092), 4 },
                    { 51, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1072), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1074), 3 },
                    { 50, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1055), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1057), 3 },
                    { 49, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1039), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1041), 3 },
                    { 48, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1022), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1024), 3 },
                    { 47, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1006), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1008), 3 },
                    { 46, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(988), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(991), 3 },
                    { 54, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1123), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1125), 4 },
                    { 65, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1329), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1331), 5 },
                    { 66, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1346), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1349), 5 },
                    { 67, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1363), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1365), 5 },
                    { 86, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1705), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1707), 7 },
                    { 85, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1688), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1690), 7 },
                    { 84, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1671), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1673), 6 },
                    { 83, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1655), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1657), 6 },
                    { 82, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1638), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1640), 6 },
                    { 81, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1622), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1624), 6 },
                    { 80, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1606), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1608), 6 },
                    { 79, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1589), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1592), 6 },
                    { 78, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1573), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1575), 6 },
                    { 77, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1556), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1558), 6 },
                    { 76, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1539), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1541), 6 },
                    { 75, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1522), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1525), 6 },
                    { 74, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1506), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1508), 6 },
                    { 73, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1488), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1490), 6 },
                    { 72, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1447), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1449), 6 },
                    { 71, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1430), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1433), 6 },
                    { 70, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1412), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1414), 5 },
                    { 69, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1396), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1398), 5 },
                    { 68, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1379), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1382), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(971), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(973), 2 },
                    { 87, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1722), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1724), 8 },
                    { 44, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(952), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(954), 2 },
                    { 42, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(894), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(896), 2 },
                    { 18, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(471), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(473), 1 },
                    { 17, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(454), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(456), 1 },
                    { 16, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(438), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(440), 1 },
                    { 15, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(420), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(422), 1 },
                    { 14, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(403), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(405), 1 },
                    { 13, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(358), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(360), 1 },
                    { 12, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(342), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(344), 1 },
                    { 11, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(325), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(327), 1 },
                    { 19, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(487), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(490), 1 },
                    { 10, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(308), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(310), 1 },
                    { 8, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(273), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(275), 1 },
                    { 7, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(256), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(258), 1 },
                    { 6, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(239), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(241), 1 },
                    { 5, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(220), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(222), 1 },
                    { 4, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(202), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(205), 1 },
                    { 3, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(184), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(187), 1 },
                    { 2, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(155), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(162), 1 },
                    { 1, new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(9134), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 650, DateTimeKind.Local).AddTicks(9364), 1 },
                    { 9, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(290), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(293), 1 },
                    { 20, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(504), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(506), 1 },
                    { 21, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(520), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(523), 1 },
                    { 22, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(536), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(539), 1 },
                    { 41, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(877), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(880), 2 },
                    { 40, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(861), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(863), 2 },
                    { 39, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(844), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(846), 2 },
                    { 38, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(828), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(830), 2 },
                    { 37, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(811), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(813), 2 },
                    { 36, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(794), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(796), 2 },
                    { 35, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(778), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(780), 2 },
                    { 34, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(762), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(764), 2 },
                    { 33, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(745), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(747), 2 },
                    { 32, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(728), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(730), 2 },
                    { 31, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(709), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(711), 2 },
                    { 30, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(692), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(694), 1 },
                    { 29, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(674), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(676), 1 },
                    { 28, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(633), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(636), 1 },
                    { 27, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(618), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(620), 1 },
                    { 26, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(602), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(604), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(585), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(588), 1 },
                    { 24, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(568), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(570), 1 },
                    { 23, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(552), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(554), 1 },
                    { 43, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(910), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(912), 2 },
                    { 88, new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1808), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 8, 31, 18, 59, 8, 651, DateTimeKind.Local).AddTicks(1811), 8 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProjectId",
                table: "Orders",
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
                name: "ContactData");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "HomeData");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
