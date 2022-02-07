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
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    DownloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "LastUpdateDate", "Name", "NormalizedName" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "0a80231a-c2ea-4f7a-ad38-064edcaf4789", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "63bc05b4-1aaa-430a-a305-bddfa589e448", "-Platanios719791", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAENZBM25zgwbrL6n/gxbL8l2Inh1wWLGULuAyB3POExU7/QXf1vCl00rG3vRf/m4XOA==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CreatedDate", "Description", "IsActive", "LastUpdateDate", "Path" },
                values: new object[] { 1, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "My CV", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/CV/CV.pdf" });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "AddressMap", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", "https://maps.google.com/maps?q=Greece%20Voula%20Fleming%2014%2016673&t=&z=17&ie=UTF8&iwloc=&output=embed", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), null, "~/img/home/me.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I'm a paragraph. Click here to add your own text and edit me. I’m a great place for you to tell a story and let your users know a little more about you.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLink", "LastUpdateDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Online School For Data Sience.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "CBProject" },
                    { 2, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Salesforce App To Manipulate Your Wallet.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "Economy" },
                    { 3, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "WordPress WebSite For KungFou School.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "Eelementum" },
                    { 4, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "A B&B App For Elevator Maintence Company.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "Elevators Dashboard" },
                    { 5, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "A B&B App For Elevator Maintence Company.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "Elevators Managment" },
                    { 6, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "IPCameras Security Software.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "IPCameras Dashboard" },
                    { 7, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Update Your Old Vichecle To Full Software Update.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "Remote Auto Moto" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 59, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 58, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 57, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 56, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 55, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 54, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 53, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 52, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 51, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 50, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_12.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 60, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 61, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_12.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 63, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_14.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 80, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 79, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 78, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 77, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 76, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 75, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 74, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 73, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 72, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 71, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 70, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 69, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 68, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 67, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 66, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 65, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorsManagmentSystem/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 64, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorsManagmentSystem/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 62, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/ElevatorDash/img_13.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 81, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 41, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 39, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_17.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_16.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_15.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_14.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_13.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_12.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 1, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_18.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_19.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_21.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Elementum/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/Economy/img_1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_30.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_29.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_28.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_27.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_26.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_25.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_24.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_23.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_22.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/CBProject/img_20.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 82, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
