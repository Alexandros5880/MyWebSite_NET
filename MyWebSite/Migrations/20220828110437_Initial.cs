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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "df0e2feb-e05a-45da-b6f0-64eb3259395b", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(9519), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "51c8d3e0-8fa1-4304-bfdf-028dfb1925fe", "-Platanios719791", new DateTime(2022, 8, 28, 14, 4, 36, 624, DateTimeKind.Local).AddTicks(1016), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEI/x/t9UVo/lStyqhpTCp+bwG2j/ma/oyK24XQf8erOXY/7//SrRxlr3JysYMoC/xw==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 8, 28, 14, 4, 36, 617, DateTimeKind.Local).AddTicks(6590), "My CV", true, new DateTime(2022, 8, 28, 14, 4, 36, 620, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(7530), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(4848), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(3715), "", "/img/home/me.jpg", true, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(1553), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(2086), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(2545), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4704), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4717), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4810), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4813), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4835), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4839), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4859), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(4863), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5239), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5247), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5269), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5273), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5294), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(5298), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9470), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9474), 5 },
                    { 62, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9443), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9447), 5 },
                    { 61, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9417), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9420), 5 },
                    { 60, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9391), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9394), 5 },
                    { 59, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9362), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9366), 5 },
                    { 58, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9334), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9338), 4 },
                    { 57, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9308), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9311), 4 },
                    { 56, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9280), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9284), 4 },
                    { 64, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9498), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9501), 5 },
                    { 55, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9214), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9218), 4 },
                    { 53, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9163), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9167), 4 },
                    { 52, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9135), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9139), 4 },
                    { 51, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9108), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9112), 3 },
                    { 50, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9081), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9085), 3 },
                    { 49, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9056), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9059), 3 },
                    { 48, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9030), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9033), 3 },
                    { 47, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9004), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9007), 3 },
                    { 46, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8976), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8979), 3 },
                    { 54, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9189), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9192), 4 },
                    { 65, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9523), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9527), 5 },
                    { 66, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9553), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9556), 5 },
                    { 67, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9579), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9582), 5 },
                    { 86, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(163), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(167), 7 },
                    { 85, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(133), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(137), 7 },
                    { 84, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(69), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(72), 6 },
                    { 83, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(43), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(46), 6 },
                    { 82, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(16), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(19), 6 },
                    { 81, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9990), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9993), 6 },
                    { 80, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9963), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9967), 6 },
                    { 79, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9938), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9941), 6 },
                    { 78, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9911), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9915), 6 },
                    { 77, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9885), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9889), 6 },
                    { 76, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9859), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9863), 6 },
                    { 75, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9833), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9837), 6 },
                    { 74, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9806), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9810), 6 },
                    { 73, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9779), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9783), 6 },
                    { 72, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9753), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9757), 6 },
                    { 71, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9724), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9728), 6 },
                    { 70, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9696), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9699), 5 },
                    { 69, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9630), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9633), 5 },
                    { 68, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9605), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(9608), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8943), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8947), 2 },
                    { 87, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(191), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(194), 8 },
                    { 44, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8917), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8921), 2 },
                    { 42, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8863), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8867), 2 },
                    { 18, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8143), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8147), 1 },
                    { 17, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8114), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8117), 1 },
                    { 16, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8087), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8091), 1 },
                    { 15, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8060), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8064), 1 },
                    { 14, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8034), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8038), 1 },
                    { 13, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8007), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8011), 1 },
                    { 12, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7981), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7984), 1 },
                    { 11, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7952), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7956), 1 },
                    { 19, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8170), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8174), 1 },
                    { 10, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7879), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7883), 1 },
                    { 8, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7824), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7828), 1 },
                    { 7, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7796), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7800), 1 },
                    { 6, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7769), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7772), 1 },
                    { 5, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7736), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7740), 1 },
                    { 4, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7707), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7711), 1 },
                    { 3, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7678), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7682), 1 },
                    { 2, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7630), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7641), 1 },
                    { 1, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(6060), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(6392), 1 },
                    { 9, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7851), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(7855), 1 },
                    { 20, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8196), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8200), 1 },
                    { 21, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8223), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8226), 1 },
                    { 22, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8249), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8253), 1 },
                    { 41, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8835), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8839), 2 },
                    { 40, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8804), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8809), 2 },
                    { 39, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8740), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8744), 2 },
                    { 38, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8714), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8717), 2 },
                    { 37, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8688), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8691), 2 },
                    { 36, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8662), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8666), 2 },
                    { 35, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8636), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8640), 2 },
                    { 34, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8610), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8614), 2 },
                    { 33, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8581), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8585), 2 },
                    { 32, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8554), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8558), 2 },
                    { 31, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8526), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8531), 2 },
                    { 30, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8498), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8502), 1 },
                    { 29, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8472), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8476), 1 },
                    { 28, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8445), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8448), 1 },
                    { 27, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8417), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8421), 1 },
                    { 26, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8389), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8392), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8326), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8330), 1 },
                    { 24, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8301), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8304), 1 },
                    { 23, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8275), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8279), 1 },
                    { 43, new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8890), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 8, 28, 14, 4, 36, 622, DateTimeKind.Local).AddTicks(8894), 2 },
                    { 88, new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(217), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 8, 28, 14, 4, 36, 623, DateTimeKind.Local).AddTicks(221), 8 }
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
