using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ConfingPassword = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    SubTitle = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    FacebookLink = table.Column<string>(type: "text", nullable: true),
                    InstagramLink = table.Column<string>(type: "text", nullable: true),
                    LinkedLin = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CVPath = table.Column<string>(type: "text", nullable: true),
                    CVFullPath = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    SubTitle = table.Column<string>(type: "text", nullable: true),
                    Paragraph = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ImageFullPath = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    MyMessage = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DownloadLinkZip = table.Column<string>(type: "text", nullable: true),
                    DownloadLinkTar = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    WebPage = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    ImageFullPath = table.Column<string>(type: "text", nullable: true),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderID = table.Column<string>(type: "text", nullable: true),
                    PayerID = table.Column<string>(type: "text", nullable: true),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "5b081ec5-bcc6-4c8d-8388-a6f4b9cd1dfc", new DateTime(2022, 3, 2, 19, 21, 50, 392, DateTimeKind.Local).AddTicks(3692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "c1991527-a0df-4dae-8ef9-e6e6c9321069", "-Platanios719791", new DateTime(2022, 3, 2, 19, 21, 50, 392, DateTimeKind.Local).AddTicks(8240), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEATGHf6DUyyXPU4ddcF3npjmxAZwixndK0ObwAUgZJd/YlTOpOohQiSaeGTIcHfs7Q==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 3, 2, 19, 21, 50, 382, DateTimeKind.Local).AddTicks(3881), "My CV", true, new DateTime(2022, 3, 2, 19, 21, 50, 386, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 3, 2, 19, 21, 50, 391, DateTimeKind.Local).AddTicks(6152), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 3, 2, 19, 21, 50, 391, DateTimeKind.Local).AddTicks(20), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(8061), "", "/img/home/me.jpg", true, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(4195), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 2, 19, 21, 50, 388, DateTimeKind.Local).AddTicks(5708), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 2, 19, 21, 50, 388, DateTimeKind.Local).AddTicks(6282), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(471), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(493), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(553), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(564), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(611), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(621), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(665), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(674), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1392), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1417), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1497), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1511), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1585), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(1602), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(340), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(350), 5 },
                    { 62, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(278), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(288), 5 },
                    { 61, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(217), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(227), 5 },
                    { 60, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(155), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(165), 5 },
                    { 59, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(92), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(101), 5 },
                    { 58, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(30), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(40), 4 },
                    { 57, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9968), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9978), 4 },
                    { 56, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9906), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9916), 4 },
                    { 64, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(401), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(411), 5 },
                    { 55, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9844), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9854), 4 },
                    { 53, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9720), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9729), 4 },
                    { 52, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9649), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9661), 4 },
                    { 51, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9534), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9549), 3 },
                    { 50, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9353), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9366), 3 },
                    { 49, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9269), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9283), 3 },
                    { 48, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9186), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9199), 3 },
                    { 47, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9100), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9114), 3 },
                    { 46, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9016), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9030), 3 },
                    { 54, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9781), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(9791), 4 },
                    { 65, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(462), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(472), 5 },
                    { 66, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(590), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(601), 5 },
                    { 67, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(654), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(664), 5 },
                    { 86, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2118), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2128), 7 },
                    { 85, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2055), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2066), 7 },
                    { 84, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1993), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2003), 6 },
                    { 83, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1932), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1942), 6 },
                    { 82, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1871), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1881), 6 },
                    { 81, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1807), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1819), 6 },
                    { 80, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1674), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1684), 6 },
                    { 79, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1613), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1623), 6 },
                    { 78, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1547), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1559), 6 },
                    { 77, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1442), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1454), 6 },
                    { 76, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1332), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1349), 6 },
                    { 75, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1245), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1258), 6 },
                    { 74, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1161), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1173), 6 },
                    { 73, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1081), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1093), 6 },
                    { 72, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1004), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(1016), 6 },
                    { 71, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(908), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(924), 6 },
                    { 70, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(836), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(846), 5 },
                    { 69, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(775), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(785), 5 },
                    { 68, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(714), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(724), 5 },
                    { 45, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8929), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8942), 2 },
                    { 87, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2180), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2190), 8 },
                    { 44, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8847), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8859), 2 },
                    { 42, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8666), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8676), 2 },
                    { 18, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6818), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6830), 1 },
                    { 17, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6737), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6748), 1 },
                    { 16, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6662), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6675), 1 },
                    { 15, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6563), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6572), 1 },
                    { 14, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6502), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6511), 1 },
                    { 13, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6441), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6450), 1 },
                    { 12, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6380), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6391), 1 },
                    { 11, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6319), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6330), 1 },
                    { 19, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6899), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6912), 1 },
                    { 10, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6258), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6268), 1 },
                    { 8, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6135), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6145), 1 },
                    { 7, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6070), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6082), 1 },
                    { 6, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5922), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5932), 1 },
                    { 5, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5855), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5865), 1 },
                    { 4, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5792), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5802), 1 },
                    { 3, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5726), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5737), 1 },
                    { 2, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5630), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(5658), 1 },
                    { 1, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(2562), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(3265), 1 },
                    { 9, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6195), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6205), 1 },
                    { 20, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6985), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(6998), 1 },
                    { 21, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7077), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7091), 1 },
                    { 22, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7246), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7260), 1 },
                    { 41, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8606), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8616), 2 },
                    { 40, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8545), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8555), 2 },
                    { 39, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8483), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8493), 2 },
                    { 38, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8423), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8433), 2 },
                    { 37, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8362), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8372), 2 },
                    { 36, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8294), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8305), 2 },
                    { 35, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8169), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8179), 2 },
                    { 34, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8107), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8117), 2 },
                    { 33, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8041), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8051), 2 },
                    { 32, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7979), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7989), 2 },
                    { 31, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7917), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7928), 2 },
                    { 30, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7856), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7866), 1 },
                    { 29, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7795), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7805), 1 },
                    { 28, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7735), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7745), 1 },
                    { 27, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7674), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7684), 1 },
                    { 26, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7613), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7623), 1 },
                    { 25, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7551), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7561), 1 },
                    { 24, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7466), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7484), 1 },
                    { 23, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7358), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(7378), 1 },
                    { 43, new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8765), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 3, 2, 19, 21, 50, 389, DateTimeKind.Local).AddTicks(8778), 2 },
                    { 88, new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2241), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 3, 2, 19, 21, 50, 390, DateTimeKind.Local).AddTicks(2252), 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

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
