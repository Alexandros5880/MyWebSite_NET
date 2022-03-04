﻿using System;
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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "53805357-ab16-430f-ab57-720443b1a1c4", new DateTime(2022, 3, 4, 22, 1, 58, 292, DateTimeKind.Local).AddTicks(9263), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "fa604f4c-eb3a-4315-8c79-a8eaf1d58d5c", "-Platanios719791", new DateTime(2022, 3, 4, 22, 1, 58, 293, DateTimeKind.Local).AddTicks(3549), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAECgfDCmsCECNwIrVO1+wUnZ10SNXHy05Pg3jm/lFte86kyK4de5UkbFfVTrr0zap7w==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 3, 4, 22, 1, 58, 285, DateTimeKind.Local).AddTicks(2049), "My CV", true, new DateTime(2022, 3, 4, 22, 1, 58, 288, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 3, 4, 22, 1, 58, 292, DateTimeKind.Local).AddTicks(3276), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(8992), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(7570), "", "/img/home/me.jpg", true, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(4731), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(1264), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(1710), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4664), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4680), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4786), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4795), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4838), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4847), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4884), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(4892), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5361), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5373), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5413), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5422), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5459), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(5466), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1997), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2005), 5 },
                    { 62, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1945), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1954), 5 },
                    { 61, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1893), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1902), 5 },
                    { 60, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1841), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1849), 5 },
                    { 59, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1786), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1795), 5 },
                    { 58, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1732), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1741), 4 },
                    { 57, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1679), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1687), 4 },
                    { 56, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1619), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1629), 4 },
                    { 64, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2049), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2057), 5 },
                    { 55, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1515), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1523), 4 },
                    { 53, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1409), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1417), 4 },
                    { 52, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1355), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1364), 4 },
                    { 51, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1302), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1310), 3 },
                    { 50, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1250), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1258), 3 },
                    { 49, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1196), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1205), 3 },
                    { 48, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1143), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1152), 3 },
                    { 47, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1090), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1099), 3 },
                    { 46, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1036), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1044), 3 },
                    { 54, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1462), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(1471), 4 },
                    { 65, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2102), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2110), 5 },
                    { 66, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2158), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2167), 5 },
                    { 67, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2211), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2220), 5 },
                    { 86, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3348), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3357), 7 },
                    { 85, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3287), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3296), 7 },
                    { 84, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3161), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3169), 6 },
                    { 83, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3108), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3116), 6 },
                    { 82, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3055), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3063), 6 },
                    { 81, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3002), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3010), 6 },
                    { 80, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2949), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2957), 6 },
                    { 79, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2896), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2905), 6 },
                    { 78, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2844), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2852), 6 },
                    { 77, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2791), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2799), 6 },
                    { 76, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2738), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2747), 6 },
                    { 75, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2685), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2694), 6 },
                    { 74, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2632), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2641), 6 },
                    { 73, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2580), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2588), 6 },
                    { 72, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2527), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2535), 6 },
                    { 71, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2473), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2482), 6 },
                    { 70, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2417), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2426), 5 },
                    { 69, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2315), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2324), 5 },
                    { 68, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2263), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(2271), 5 },
                    { 45, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(982), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(990), 2 },
                    { 87, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3403), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3412), 8 },
                    { 44, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(928), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(937), 2 },
                    { 42, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(822), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(830), 2 },
                    { 18, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9424), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9432), 1 },
                    { 17, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9367), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9376), 1 },
                    { 16, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9314), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9323), 1 },
                    { 15, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9261), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9269), 1 },
                    { 14, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9207), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9216), 1 },
                    { 13, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9153), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9161), 1 },
                    { 12, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9097), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9106), 1 },
                    { 11, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9037), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9047), 1 },
                    { 19, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9478), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9486), 1 },
                    { 10, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8924), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8933), 1 },
                    { 8, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8815), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8824), 1 },
                    { 7, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8762), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8770), 1 },
                    { 6, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8708), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8717), 1 },
                    { 5, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8650), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8659), 1 },
                    { 4, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8595), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8604), 1 },
                    { 3, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8538), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8547), 1 },
                    { 2, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8469), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8483), 1 },
                    { 1, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(6190), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(6608), 1 },
                    { 9, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8869), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(8877), 1 },
                    { 20, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9532), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9541), 1 },
                    { 21, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9585), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9594), 1 },
                    { 22, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9639), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9648), 1 },
                    { 41, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(767), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(776), 2 },
                    { 40, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(659), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(667), 2 },
                    { 39, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(605), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(614), 2 },
                    { 38, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(552), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(560), 2 },
                    { 37, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(498), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(507), 2 },
                    { 36, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(445), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(453), 2 },
                    { 35, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(392), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(400), 2 },
                    { 34, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(339), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(348), 2 },
                    { 33, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(283), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(292), 2 },
                    { 32, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(230), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(239), 2 },
                    { 31, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(175), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(184), 2 },
                    { 30, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(121), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(130), 1 },
                    { 29, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(68), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(77), 1 },
                    { 28, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(15), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(23), 1 },
                    { 27, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9961), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9970), 1 },
                    { 26, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9901), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9911), 1 },
                    { 25, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9800), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9809), 1 },
                    { 24, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9747), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9755), 1 },
                    { 23, new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9693), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 3, 4, 22, 1, 58, 290, DateTimeKind.Local).AddTicks(9701), 1 },
                    { 43, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(875), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(884), 2 },
                    { 88, new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3458), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 3, 4, 22, 1, 58, 291, DateTimeKind.Local).AddTicks(3466), 8 }
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
