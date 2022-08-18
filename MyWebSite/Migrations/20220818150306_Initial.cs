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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "32f22f4c-4ae8-4c92-9723-fde902b65687", new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(4215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "27dce381-6e7b-4d46-9530-a12936976aff", "-Platanios719791", new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(5934), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAEHcL6d2C5GXce5mwRHKFqcuuvtSrUr2DnXhcVyrsppx+TJpBpLBWA7As/X6zaa/9JA==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 8, 18, 18, 3, 4, 962, DateTimeKind.Local).AddTicks(9629), "My CV", true, new DateTime(2022, 8, 18, 18, 3, 4, 966, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 8, 18, 18, 3, 4, 971, DateTimeKind.Local).AddTicks(1933), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(5335), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(3773), "", "/img/home/me.jpg", true, new DateTime(2022, 8, 18, 18, 3, 4, 970, DateTimeKind.Local).AddTicks(439), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(5391), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(5874), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9114), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9130), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9263), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9275), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9324), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9334), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9375), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9385), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9897), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9911), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9955), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 8, 18, 18, 3, 4, 968, DateTimeKind.Local).AddTicks(9964), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(15), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7446), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7456), 5 },
                    { 62, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7389), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7399), 5 },
                    { 61, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7332), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7341), 5 },
                    { 60, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7275), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7284), 5 },
                    { 59, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7218), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7228), 5 },
                    { 58, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7162), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7171), 4 },
                    { 57, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7105), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7114), 4 },
                    { 56, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7041), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7052), 4 },
                    { 64, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7503), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7512), 5 },
                    { 55, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6931), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6941), 4 },
                    { 53, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6817), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6827), 4 },
                    { 52, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6755), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6766), 4 },
                    { 51, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6606), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6616), 3 },
                    { 50, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6548), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6557), 3 },
                    { 49, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6490), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6499), 3 },
                    { 48, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6432), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6441), 3 },
                    { 47, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6374), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6384), 3 },
                    { 46, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6316), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6326), 3 },
                    { 54, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6875), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6884), 4 },
                    { 65, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7560), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7570), 5 },
                    { 66, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7622), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7631), 5 },
                    { 67, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7679), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7689), 5 },
                    { 86, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8890), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8899), 7 },
                    { 85, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8825), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8836), 7 },
                    { 84, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8720), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8730), 6 },
                    { 83, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8664), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8673), 6 },
                    { 82, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8607), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8616), 6 },
                    { 81, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8549), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8558), 6 },
                    { 80, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8491), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8500), 6 },
                    { 79, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8434), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8443), 6 },
                    { 78, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8375), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8384), 6 },
                    { 77, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8317), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8326), 6 },
                    { 76, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8259), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8269), 6 },
                    { 75, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8201), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8211), 6 },
                    { 74, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8143), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8152), 6 },
                    { 73, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8084), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8093), 6 },
                    { 72, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8025), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8035), 6 },
                    { 71, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7965), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7975), 6 },
                    { 70, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7900), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7911), 5 },
                    { 69, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7794), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7803), 5 },
                    { 68, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7736), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(7746), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6256), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6266), 2 },
                    { 87, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8948), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(8957), 8 },
                    { 44, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6174), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6188), 2 },
                    { 42, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6026), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6036), 2 },
                    { 18, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4479), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4489), 1 },
                    { 17, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4417), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4427), 1 },
                    { 16, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4359), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4368), 1 },
                    { 15, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4299), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4309), 1 },
                    { 14, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4239), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4249), 1 },
                    { 13, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4181), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4190), 1 },
                    { 12, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4122), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4131), 1 },
                    { 11, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4055), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4066), 1 },
                    { 19, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4537), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4547), 1 },
                    { 10, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3932), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3941), 1 },
                    { 8, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3812), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3821), 1 },
                    { 7, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3754), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3763), 1 },
                    { 6, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3695), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3704), 1 },
                    { 5, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3632), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3642), 1 },
                    { 4, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3572), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3582), 1 },
                    { 3, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3510), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3520), 1 },
                    { 2, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3434), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3450), 1 },
                    { 1, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(1123), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(1633), 1 },
                    { 9, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3871), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(3880), 1 },
                    { 20, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4595), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4605), 1 },
                    { 21, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4652), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4662), 1 },
                    { 22, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4709), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4719), 1 },
                    { 41, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5964), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5975), 2 },
                    { 40, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5807), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5816), 2 },
                    { 39, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5749), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5759), 2 },
                    { 38, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5691), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5701), 2 },
                    { 37, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5633), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5643), 2 },
                    { 36, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5575), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5585), 2 },
                    { 35, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5518), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5528), 2 },
                    { 34, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5459), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5469), 2 },
                    { 33, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5398), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5407), 2 },
                    { 32, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5341), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5350), 2 },
                    { 31, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5281), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5291), 2 },
                    { 30, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5223), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5233), 1 },
                    { 29, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5167), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5176), 1 },
                    { 28, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5110), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5119), 1 },
                    { 27, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5051), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(5061), 1 },
                    { 26, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4987), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4998), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4884), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4894), 1 },
                    { 24, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4827), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4837), 1 },
                    { 23, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4769), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(4779), 1 },
                    { 43, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6084), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(6094), 2 },
                    { 88, new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(9007), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 8, 18, 18, 3, 4, 969, DateTimeKind.Local).AddTicks(9016), 8 }
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
