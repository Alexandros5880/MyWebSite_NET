﻿using System;
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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "34a7c9c0-08c8-4ec4-98f0-c05f60697ec9", new DateTime(2022, 8, 19, 18, 12, 30, 370, DateTimeKind.Local).AddTicks(692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "7140f91f-1d5a-426f-aa10-138a49e0f59d", "-Platanios719791", new DateTime(2022, 8, 19, 18, 12, 30, 370, DateTimeKind.Local).AddTicks(3217), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEEQ8Mi3ENEAS5teSUgtMKIardLzIfVzznPzhWZya2m+il/nF58uKwxR1mVFR8k5yhA==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 8, 19, 18, 12, 30, 286, DateTimeKind.Local).AddTicks(8826), "My CV", true, new DateTime(2022, 8, 19, 18, 12, 30, 342, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 8, 19, 18, 12, 30, 355, DateTimeKind.Local).AddTicks(7291), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 8, 19, 18, 12, 30, 355, DateTimeKind.Local).AddTicks(3040), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 8, 19, 18, 12, 30, 355, DateTimeKind.Local).AddTicks(1582), "", "/img/home/me.jpg", true, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(8639), "\r\n                        The first book I started with was C++ at the age of 15 influenced by my brother \r\n                        'Anthony Platanios', but only as a hobby. When I was 18 I started working at a \r\n                        local gym as an instructor and I stayed in that field for 7 years. \r\n                        Right after that a friend of mine that is a programmer saw a code I made for my \r\n                        motorcycle and encouraged me to pursue programming.\r\n                    ", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 18, 12, 30, 344, DateTimeKind.Local).AddTicks(3557), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 19, 18, 12, 30, 344, DateTimeKind.Local).AddTicks(4012), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5843), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5890), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5941), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5949), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5987), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(5995), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6032), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6040), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6516), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6528), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6569), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6577), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6615), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(6623), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4671), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4679), 5 },
                    { 62, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4620), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4628), 5 },
                    { 61, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4568), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4576), 5 },
                    { 60, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4516), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4524), 5 },
                    { 59, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4462), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4471), 5 },
                    { 58, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4409), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4418), 4 },
                    { 57, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4357), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4366), 4 },
                    { 56, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4305), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4314), 4 },
                    { 64, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4787), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4797), 5 },
                    { 55, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4253), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4262), 4 },
                    { 53, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4150), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4158), 4 },
                    { 52, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4098), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4106), 4 },
                    { 51, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4044), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4053), 3 },
                    { 50, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3993), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4002), 3 },
                    { 49, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3940), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3949), 3 },
                    { 48, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3885), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3895), 3 },
                    { 47, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3769), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3778), 3 },
                    { 46, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3716), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3725), 3 },
                    { 54, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4201), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4210), 4 },
                    { 65, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4841), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4850), 5 },
                    { 66, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4896), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4906), 5 },
                    { 67, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4949), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(4968), 5 },
                    { 86, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7088), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7097), 7 },
                    { 85, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7036), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7045), 7 },
                    { 84, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6985), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6993), 6 },
                    { 83, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6934), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6943), 6 },
                    { 82, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6883), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6892), 6 },
                    { 81, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6832), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6841), 6 },
                    { 80, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6777), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6786), 6 },
                    { 79, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6721), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6731), 6 },
                    { 78, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6613), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6631), 6 },
                    { 77, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6317), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6335), 6 },
                    { 76, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6142), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6154), 6 },
                    { 75, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6076), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6086), 6 },
                    { 74, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5997), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(6009), 6 },
                    { 73, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5916), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5927), 6 },
                    { 72, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5836), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5846), 6 },
                    { 71, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5743), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5757), 6 },
                    { 70, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5625), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5645), 5 },
                    { 69, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5365), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5377), 5 },
                    { 68, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5225), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(5240), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3662), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3671), 2 },
                    { 87, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7139), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7148), 8 },
                    { 44, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3610), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3619), 2 },
                    { 42, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3505), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3514), 2 },
                    { 18, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2152), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2162), 1 },
                    { 17, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1994), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2003), 1 },
                    { 16, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1933), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1942), 1 },
                    { 15, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1880), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1889), 1 },
                    { 14, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1828), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1837), 1 },
                    { 13, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1778), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1786), 1 },
                    { 12, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1726), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1734), 1 },
                    { 11, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1674), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1683), 1 },
                    { 19, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2213), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2222), 1 },
                    { 10, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1622), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1631), 1 },
                    { 8, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1514), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1523), 1 },
                    { 7, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1462), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1470), 1 },
                    { 6, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1409), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1418), 1 },
                    { 5, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1352), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1361), 1 },
                    { 4, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1300), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1308), 1 },
                    { 3, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1243), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1252), 1 },
                    { 2, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1172), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1188), 1 },
                    { 1, new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(8100), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 353, DateTimeKind.Local).AddTicks(8696), 1 },
                    { 9, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1566), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(1575), 1 },
                    { 20, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2267), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2276), 1 },
                    { 21, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2321), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2330), 1 },
                    { 22, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2375), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2383), 1 },
                    { 41, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3453), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3461), 2 },
                    { 40, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3400), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3408), 2 },
                    { 39, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3347), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3356), 2 },
                    { 38, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3296), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3304), 2 },
                    { 37, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3243), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3251), 2 },
                    { 36, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3190), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3198), 2 },
                    { 35, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3136), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3145), 2 },
                    { 34, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3080), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3090), 2 },
                    { 33, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2955), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2963), 2 },
                    { 32, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2902), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2911), 2 },
                    { 31, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2848), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2857), 2 },
                    { 30, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2794), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2803), 1 },
                    { 29, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2741), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2750), 1 },
                    { 28, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2689), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2697), 1 },
                    { 27, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2637), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2645), 1 },
                    { 26, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2585), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2593), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2532), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2541), 1 },
                    { 24, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2480), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2489), 1 },
                    { 23, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2428), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(2436), 1 },
                    { 43, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3557), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(3566), 2 },
                    { 88, new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7192), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 8, 19, 18, 12, 30, 354, DateTimeKind.Local).AddTicks(7201), 8 }
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
