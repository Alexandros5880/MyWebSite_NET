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
                    AddressMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "12156593-9531-4ea4-96e0-c5d5b0c349cb", new DateTime(2022, 2, 22, 17, 53, 38, 746, DateTimeKind.Local).AddTicks(676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "440c8f45-7940-4aa8-8031-4d1526f2cb1e", "-Platanios719791", new DateTime(2022, 2, 22, 17, 53, 38, 746, DateTimeKind.Local).AddTicks(5464), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEOWCPep1faRGvbUhI6ycCeW4k9dskCOiVEwr3XWb9W14PWcnosYjFRkDEWSBFRdjNQ==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 2, 22, 17, 53, 38, 737, DateTimeKind.Local).AddTicks(7922), "My CV", true, new DateTime(2022, 2, 22, 17, 53, 38, 741, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "AddressMap", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", "https://maps.google.com/maps?q=Greece%20Voula%20Fleming%2014%2016673&t=&z=17&ie=UTF8&iwloc=&output=embed", new DateTime(2022, 2, 22, 17, 53, 38, 745, DateTimeKind.Local).AddTicks(2809), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 2, 22, 17, 53, 38, 744, DateTimeKind.Local).AddTicks(6779), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly. I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 2, 22, 17, 53, 38, 744, DateTimeKind.Local).AddTicks(3856), "", "/img/home/me.jpg", true, new DateTime(2022, 2, 22, 17, 53, 38, 744, DateTimeKind.Local).AddTicks(939), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 22, 17, 53, 38, 742, DateTimeKind.Local).AddTicks(7440), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 17, 53, 38, 742, DateTimeKind.Local).AddTicks(7898), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(828), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(842), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(887), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(895), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(934), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(942), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(979), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(987), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1454), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1466), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1505), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1513), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1620), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(1629), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8099), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8107), 5 },
                    { 62, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8047), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8056), 5 },
                    { 61, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7994), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8003), 5 },
                    { 60, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7895), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7904), 5 },
                    { 59, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7844), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7852), 5 },
                    { 58, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7792), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7800), 4 },
                    { 57, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7740), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7748), 4 },
                    { 56, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7688), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7696), 4 },
                    { 64, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8150), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8158), 5 },
                    { 55, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7636), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7645), 4 },
                    { 53, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7534), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7542), 4 },
                    { 52, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7481), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7490), 4 },
                    { 51, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7428), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7437), 3 },
                    { 50, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7377), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7385), 3 },
                    { 49, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7325), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7334), 3 },
                    { 48, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7273), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7281), 3 },
                    { 47, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7220), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7228), 3 },
                    { 46, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7168), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7176), 3 },
                    { 54, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7585), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7594), 4 },
                    { 65, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8200), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8209), 5 },
                    { 66, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8255), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8264), 5 },
                    { 67, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8307), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8315), 5 },
                    { 86, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9389), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9397), 7 },
                    { 85, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9337), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9345), 7 },
                    { 84, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9283), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9292), 6 },
                    { 83, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9230), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9239), 6 },
                    { 82, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9178), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9186), 6 },
                    { 81, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9126), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9134), 6 },
                    { 80, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9074), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9083), 6 },
                    { 79, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9023), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9031), 6 },
                    { 78, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8971), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8980), 6 },
                    { 77, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8918), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8927), 6 },
                    { 76, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8866), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8875), 6 },
                    { 75, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8813), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8822), 6 },
                    { 74, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8753), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8763), 6 },
                    { 73, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8618), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8627), 6 },
                    { 72, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8566), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8575), 6 },
                    { 71, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8513), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8521), 6 },
                    { 70, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8461), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8470), 5 },
                    { 69, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8410), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8419), 5 },
                    { 68, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8358), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(8367), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7110), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7120), 2 },
                    { 87, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9442), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9451), 8 },
                    { 44, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7007), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(7016), 2 },
                    { 42, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6903), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6912), 2 },
                    { 18, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5608), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5616), 1 },
                    { 17, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5552), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5561), 1 },
                    { 16, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5500), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5509), 1 },
                    { 15, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5379), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5387), 1 },
                    { 14, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5328), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5336), 1 },
                    { 13, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5276), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5285), 1 },
                    { 12, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5225), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5233), 1 },
                    { 11, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5172), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5181), 1 },
                    { 19, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5660), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5668), 1 },
                    { 10, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5121), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5129), 1 },
                    { 8, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4824), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5011), 1 },
                    { 7, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4761), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4770), 1 },
                    { 6, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4709), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4717), 1 },
                    { 5, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4652), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4661), 1 },
                    { 4, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4598), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4607), 1 },
                    { 3, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4544), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4553), 1 },
                    { 2, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4477), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(4491), 1 },
                    { 1, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(2378), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(2800), 1 },
                    { 9, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5064), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5073), 1 },
                    { 20, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5711), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5719), 1 },
                    { 21, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5762), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5770), 1 },
                    { 22, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5814), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5822), 1 },
                    { 41, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6852), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6860), 2 },
                    { 40, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6800), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6809), 2 },
                    { 39, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6749), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6757), 2 },
                    { 38, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6697), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6706), 2 },
                    { 37, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6646), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6654), 2 },
                    { 36, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6594), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6603), 2 },
                    { 35, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6543), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6551), 2 },
                    { 34, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6490), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6499), 2 },
                    { 33, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6436), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6444), 2 },
                    { 32, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6384), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6392), 2 },
                    { 31, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6328), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6337), 2 },
                    { 30, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6229), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6238), 1 },
                    { 29, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6178), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6186), 1 },
                    { 28, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6126), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6134), 1 },
                    { 27, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6074), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6082), 1 },
                    { 26, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6022), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6030), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5970), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5978), 1 },
                    { 24, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5918), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5926), 1 },
                    { 23, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5866), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(5875), 1 },
                    { 43, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6955), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(6963), 2 },
                    { 88, new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9495), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 2, 22, 17, 53, 38, 743, DateTimeKind.Local).AddTicks(9504), 8 }
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
