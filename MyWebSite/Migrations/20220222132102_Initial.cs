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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "72acdf34-d7eb-454a-b610-a9ebf544b7c8", new DateTime(2022, 2, 22, 15, 21, 1, 946, DateTimeKind.Local).AddTicks(5402), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "39132752-0401-45f0-8c10-e3d405a050b4", "-Platanios719791", new DateTime(2022, 2, 22, 15, 21, 1, 946, DateTimeKind.Local).AddTicks(9251), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEPpUxiotqoG9qSqjBUmRKq/bDHfD5nRb7yT2hNyOOVKeo0Ff/tJyzeBO7AmM/AueyQ==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 2, 22, 15, 21, 1, 938, DateTimeKind.Local).AddTicks(5960), "My CV", true, new DateTime(2022, 2, 22, 15, 21, 1, 941, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "AddressMap", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", "https://maps.google.com/maps?q=Greece%20Voula%20Fleming%2014%2016673&t=&z=17&ie=UTF8&iwloc=&output=embed", new DateTime(2022, 2, 22, 15, 21, 1, 945, DateTimeKind.Local).AddTicks(9428), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 2, 22, 15, 21, 1, 945, DateTimeKind.Local).AddTicks(4641), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 2, 22, 15, 21, 1, 945, DateTimeKind.Local).AddTicks(3207), "", "/img/home/me.jpg", true, new DateTime(2022, 2, 22, 15, 21, 1, 945, DateTimeKind.Local).AddTicks(400), "I'm a paragraph. Click here to add your own text and edit me. I’m a great place for you to tell a story and let your users know a little more about you.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 22, 15, 21, 1, 943, DateTimeKind.Local).AddTicks(6843), "Online School For Data Sience.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 15, 21, 1, 943, DateTimeKind.Local).AddTicks(7444), null, 33.03m, "CBProject", null },
                    { 2, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(610), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(626), null, 0m, "Economy", null },
                    { 3, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(672), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(681), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 4, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1214), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1227), null, 0m, "Elevators Managment", null },
                    { 5, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1274), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1283), null, 0m, "Elevators Dashboard", null },
                    { 6, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1325), "IPCameras Security Software.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1334), null, 0m, "IPCameras Dashboard", null },
                    { 7, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1372), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(1381), null, 0m, "Remote Auto Moto", null }
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
                    { 59, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7727), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7736), 4 },
                    { 58, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7672), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7681), 4 },
                    { 57, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7618), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7627), 4 },
                    { 56, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7563), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7572), 4 },
                    { 55, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7509), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7518), 4 },
                    { 54, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7454), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7463), 4 },
                    { 53, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7399), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7408), 4 },
                    { 52, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7344), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7353), 4 },
                    { 51, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7289), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7298), 4 },
                    { 50, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7220), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7231), 4 },
                    { 49, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6990), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6999), 3 },
                    { 48, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6935), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6944), 3 },
                    { 47, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6881), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6890), 3 },
                    { 46, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6827), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6836), 3 },
                    { 45, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6773), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6782), 3 },
                    { 44, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6718), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6727), 3 },
                    { 43, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6663), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6672), 3 },
                    { 60, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7781), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7790), 4 },
                    { 42, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6609), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6618), 3 },
                    { 61, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7836), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7845), 4 },
                    { 63, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7947), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7956), 4 },
                    { 80, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8982), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8991), 6 },
                    { 79, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8927), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8937), 6 },
                    { 78, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8824), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8833), 6 },
                    { 77, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8769), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8779), 6 },
                    { 76, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8716), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8725), 6 },
                    { 75, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8661), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8671), 6 },
                    { 74, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8607), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8616), 6 },
                    { 73, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8553), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8562), 6 },
                    { 72, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8498), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8508), 6 },
                    { 71, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8444), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8453), 6 },
                    { 70, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8391), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8399), 6 },
                    { 69, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8336), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8345), 6 },
                    { 68, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8281), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8290), 6 },
                    { 67, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8226), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8235), 6 },
                    { 66, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8169), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8179), 6 },
                    { 65, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8059), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8068), 5 },
                    { 64, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8003), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(8012), 5 },
                    { 62, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7891), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(7901), 4 },
                    { 81, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(9038), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(9047), 7 },
                    { 41, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6554), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6563), 3 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 39, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6444), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6453), 3 },
                    { 17, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5116), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5125), 1 },
                    { 16, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5061), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5070), 1 },
                    { 15, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5007), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5016), 1 },
                    { 14, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4953), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4962), 1 },
                    { 13, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4898), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4907), 1 },
                    { 12, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4844), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4853), 1 },
                    { 11, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4787), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4797), 1 },
                    { 10, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4733), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4742), 1 },
                    { 9, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4674), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4684), 1 },
                    { 8, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4620), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4629), 1 },
                    { 7, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4565), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4574), 1 },
                    { 6, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4509), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4518), 1 },
                    { 5, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4444), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4454), 1 },
                    { 4, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4312), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4321), 1 },
                    { 3, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4256), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4265), 1 },
                    { 2, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4188), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(4201), 1 },
                    { 1, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(2112), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(2533), 1 },
                    { 18, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5175), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5184), 1 },
                    { 40, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6500), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6509), 3 },
                    { 19, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5230), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5240), 1 },
                    { 21, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5394), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5403), 1 },
                    { 38, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6387), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6396), 3 },
                    { 37, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6331), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6340), 2 },
                    { 36, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6276), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6285), 2 },
                    { 35, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6220), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6230), 2 },
                    { 34, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6109), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6118), 2 },
                    { 33, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6052), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6060), 2 },
                    { 32, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5997), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(6006), 2 },
                    { 31, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5942), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5951), 2 },
                    { 30, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5887), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5896), 1 },
                    { 29, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5833), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5842), 1 },
                    { 28, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5779), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5788), 1 },
                    { 27, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5724), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5733), 1 },
                    { 26, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5668), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5678), 1 },
                    { 25, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5614), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5623), 1 },
                    { 24, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5559), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5568), 1 },
                    { 23, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5504), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5513), 1 },
                    { 22, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5450), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5459), 1 },
                    { 20, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5338), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(5348), 1 },
                    { 82, new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(9093), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 2, 22, 15, 21, 1, 944, DateTimeKind.Local).AddTicks(9103), 7 }
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