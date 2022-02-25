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
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "48a89cd5-4fba-4eff-ad86-1019bce98909", new DateTime(2022, 2, 25, 15, 17, 8, 554, DateTimeKind.Local).AddTicks(1664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfingPassword", "CreatedDate", "Email", "EmailConfirmed", "LastUpdateDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "aba3ec62-84f1-433d-90fb-93242b927157", "-Platanios719791", new DateTime(2022, 2, 25, 15, 17, 8, 554, DateTimeKind.Local).AddTicks(6908), "alexandrosplatanios15@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "alexandrosplatanios15@gmail.com", "alexandrosplatanios15@gmail.com", "-Platanios719791", "AQAAAAEAACcQAAAAED3cUB82hoKPqnfyJYvL2qj+O1gJd2tCooZfoiGvlQHClsB8ITw+1e635xyizzS9lA==", "6949277783", false, "", false, "alexandrosplatanios15@gmail.com" });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "CVFullPath", "CVPath", "CreatedDate", "Description", "IsActive", "LastUpdateDate" },
                values: new object[] { 1, null, "/CV/CV.pdf", new DateTime(2022, 2, 25, 15, 17, 8, 542, DateTimeKind.Local).AddTicks(7502), "My CV", true, new DateTime(2022, 2, 25, 15, 17, 8, 547, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.InsertData(
                table: "ContactData",
                columns: new[] { "ID", "Address", "CreatedDate", "Email", "FacebookLink", "FullName", "InstagramLink", "IsActive", "LastUpdateDate", "LinkedLin", "Phone", "SubTitle", "Title" },
                values: new object[] { 1, "Fleming 14, Voula, 16673, Greece", new DateTime(2022, 2, 25, 15, 17, 8, 553, DateTimeKind.Local).AddTicks(3481), "alexandrosplatanios28@gmail.com", "https://www.facebook.com/profile.php?id=100013059701658", "Alexandros Platanios", "https://www.instagram.com/alexandros_platanios/", true, new DateTime(2022, 2, 25, 15, 17, 8, 552, DateTimeKind.Local).AddTicks(6986), "https://www.linkedin.com/in/alexandros-platanios-723984203/", "+30-6949277783", "Do you have any questions? Please do not hesitate to contact ME directly.I'll come back to you within a matter of hours to help you.", "Contact us" });

            migrationBuilder.InsertData(
                table: "HomeData",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "IsActive", "LastUpdateDate", "Paragraph", "SubTitle", "Title" },
                values: new object[] { 1, new DateTime(2022, 2, 25, 15, 17, 8, 552, DateTimeKind.Local).AddTicks(4924), "", "/img/home/me.jpg", true, new DateTime(2022, 2, 25, 15, 17, 8, 552, DateTimeKind.Local).AddTicks(679), "The first book I started with was C++ at the age of 15, but only as a hobby. When I was 18 I started working at a local gym as an instructor and I stayed in that field for 7 years. Right after that a friend of mine that is a programmer saw a code I made for my motorcycle and encouraged me to pursue programming.", "A bot about me", "Hello" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "DownloadLinkTar", "DownloadLinkZip", "LastUpdateDate", "Link", "Price", "Title", "WebPage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(1497), "CBProject * ASP .NET FRAMEWORK * 2020/2021 * Online Course Platform:The customer can watch video tutorials or read ebooks.", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(2004), null, 5.00m, "CBProject", null },
                    { 2, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5189), "IPCameras Dashborad * .NET CORE (WPF) * 2018/2019 * ESP32-CAM Dashboard:Support all model esp32 and a lot of markets ip cameras.", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5202), null, 5.00m, "IPCameras Dashboard", null },
                    { 3, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5247), "IPCameras Chip Software * ESP32 * C++:Frace Detaction + Face Recognition + Alerts + Effects", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.tar.gz", "https://github.com/Alexandros5880/ESP32-Cam/archive/refs/tags/v0.1.zip", new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5256), null, 0m, "IPCameras Chip Software * ESP32 * C++:", null },
                    { 4, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5293), "Salesforce App To Manipulate Your Wallet.", null, null, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5301), null, 0m, "Economy", null },
                    { 5, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5414), "WordPress WebSite For KungFou School.", null, null, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5423), null, 0m, "Eelementum", "https://elementumartialfitness.com" },
                    { 6, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5940), "A B&B App on Salesforce For Elevator Maintence Company.", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz", "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5952), null, 0m, "Elevators Managment", null },
                    { 7, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(5991), "A B&B App writen in Java For Elevator Maintence Company.", null, null, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(6000), null, 0m, "Elevators Dashboard", null },
                    { 8, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(6036), "Update Your Old Vichecle To Full Software Update.", null, null, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(6044), null, 0m, "Remote Auto Moto", null }
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
                    { 63, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4713), null, "~/ProjectImages/Elementum/img_5.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4735), 5 },
                    { 62, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4614), null, "~/ProjectImages/Elementum/img_4.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4628), 5 },
                    { 61, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4507), null, "~/ProjectImages/Elementum/img_3.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4527), 5 },
                    { 60, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4408), null, "~/ProjectImages/Elementum/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4420), 5 },
                    { 59, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4289), null, "~/ProjectImages/Elementum/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4313), 5 },
                    { 58, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3892), null, "~/ProjectImages/Economy/img_7.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3904), 4 },
                    { 57, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3802), null, "~/ProjectImages/Economy/img_6.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3819), 4 },
                    { 56, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3653), null, "~/ProjectImages/Economy/img_5.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3667), 4 },
                    { 64, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4827), null, "~/ProjectImages/Elementum/img_6.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4838), 5 },
                    { 55, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3572), null, "~/ProjectImages/Economy/img_4.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3587), 4 },
                    { 53, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3408), null, "~/ProjectImages/Economy/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3420), 4 },
                    { 52, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3319), null, "~/ProjectImages/Economy/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3336), 4 },
                    { 51, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3238), null, "~/ProjectImages/IPCamerasESP32/img_6.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3250), 3 },
                    { 50, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3158), null, "~/ProjectImages/IPCamerasESP32/img_5.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3170), 3 },
                    { 49, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3073), null, "~/ProjectImages/IPCamerasESP32/img_4.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3085), 3 },
                    { 48, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2999), null, "~/ProjectImages/IPCamerasESP32/img_3.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3011), 3 },
                    { 47, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2904), null, "~/ProjectImages/IPCamerasESP32/img_2.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2918), 3 },
                    { 46, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2814), null, "~/ProjectImages/IPCamerasESP32/img_1.jpg", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2829), 3 },
                    { 54, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3488), null, "~/ProjectImages/Economy/img_3.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(3501), 4 },
                    { 65, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4900), null, "~/ProjectImages/Elementum/img_7.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4912), 5 },
                    { 66, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(4988), null, "~/ProjectImages/Elementum/img_8.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5000), 5 },
                    { 67, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5064), null, "~/ProjectImages/Elementum/img_9.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5076), 5 },
                    { 86, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7399), null, "~/ProjectImages/ElevatorDashboard/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7421), 7 },
                    { 85, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7209), null, "~/ProjectImages/ElevatorDashboard/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7230), 7 },
                    { 84, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7102), null, "~/ProjectImages/ElevatorManagment/img_14.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7121), 6 },
                    { 83, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6997), null, "~/ProjectImages/ElevatorManagment/img_13.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7016), 6 },
                    { 82, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6895), null, "~/ProjectImages/ElevatorManagment/img_12.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6909), 6 },
                    { 81, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6787), null, "~/ProjectImages/ElevatorManagment/img_11.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6807), 6 },
                    { 80, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6680), null, "~/ProjectImages/ElevatorManagment/img_10.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6698), 6 },
                    { 79, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6568), null, "~/ProjectImages/ElevatorManagment/img_9.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6586), 6 },
                    { 78, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6459), null, "~/ProjectImages/ElevatorManagment/img_8.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6478), 6 },
                    { 77, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6302), null, "~/ProjectImages/ElevatorManagment/img_7.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(6333), 6 },
                    { 76, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5909), null, "~/ProjectImages/ElevatorManagment/img_6.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5922), 6 },
                    { 75, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5838), null, "~/ProjectImages/ElevatorManagment/img_5.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5849), 6 },
                    { 74, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5766), null, "~/ProjectImages/ElevatorManagment/img_4.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5778), 6 },
                    { 73, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5693), null, "~/ProjectImages/ElevatorManagment/img_3.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5705), 6 },
                    { 72, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5621), null, "~/ProjectImages/ElevatorManagment/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5633), 6 },
                    { 71, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5542), null, "~/ProjectImages/ElevatorManagment/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5555), 6 },
                    { 70, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5383), null, "~/ProjectImages/Elementum/img_12.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5395), 5 },
                    { 69, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5311), null, "~/ProjectImages/Elementum/img_11.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5322), 5 },
                    { 68, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5144), null, "~/ProjectImages/Elementum/img_10.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(5156), 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 45, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2732), null, "~/ProjectImages/IPCamerasDashboard/img_15.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2744), 2 },
                    { 87, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7513), null, "~/ProjectImages/RemoteAutoMoto/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7528), 8 },
                    { 44, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2654), null, "~/ProjectImages/IPCamerasDashboard/img_14.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2667), 2 },
                    { 42, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2478), null, "~/ProjectImages/IPCamerasDashboard/img_12.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2491), 2 },
                    { 18, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9957), null, "~/ProjectImages/CBProject/img_18.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9971), 1 },
                    { 17, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9856), null, "~/ProjectImages/CBProject/img_17.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9870), 1 },
                    { 16, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9744), null, "~/ProjectImages/CBProject/img_16.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9766), 1 },
                    { 15, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9462), null, "~/ProjectImages/CBProject/img_15.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9476), 1 },
                    { 14, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9380), null, "~/ProjectImages/CBProject/img_14.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9393), 1 },
                    { 13, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9305), null, "~/ProjectImages/CBProject/img_13.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9316), 1 },
                    { 12, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9221), null, "~/ProjectImages/CBProject/img_12.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(9234), 1 },
                    { 11, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8949), null, "~/ProjectImages/CBProject/img_11.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8961), 1 },
                    { 19, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(228), null, "~/ProjectImages/CBProject/img_19.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(249), 1 },
                    { 10, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8843), null, "~/ProjectImages/CBProject/img_10.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8855), 1 },
                    { 8, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8611), null, "~/ProjectImages/CBProject/img_8.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8668), 1 },
                    { 7, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8203), null, "~/ProjectImages/CBProject/img_7.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8213), 1 },
                    { 6, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8119), null, "~/ProjectImages/CBProject/img_6.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8132), 1 },
                    { 5, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(7978), null, "~/ProjectImages/CBProject/img_5.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8001), 1 },
                    { 4, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6720), null, "~/ProjectImages/CBProject/img_4.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6739), 1 },
                    { 3, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6633), null, "~/ProjectImages/CBProject/img_3.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6648), 1 },
                    { 2, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6480), null, "~/ProjectImages/CBProject/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(6513), 1 },
                    { 1, new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(6839), null, "~/ProjectImages/CBProject/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 549, DateTimeKind.Local).AddTicks(7309), 1 },
                    { 9, new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8745), null, "~/ProjectImages/CBProject/img_9.png", new DateTime(2022, 2, 25, 15, 17, 8, 550, DateTimeKind.Local).AddTicks(8765), 1 },
                    { 20, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(334), null, "~/ProjectImages/CBProject/img_20.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(347), 1 },
                    { 21, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(412), null, "~/ProjectImages/CBProject/img_21.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(425), 1 },
                    { 22, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(491), null, "~/ProjectImages/CBProject/img_22.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(507), 1 },
                    { 41, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2323), null, "~/ProjectImages/IPCamerasDashboard/img_11.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2338), 2 },
                    { 40, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2232), null, "~/ProjectImages/IPCamerasDashboard/img_10.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2248), 2 },
                    { 39, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2150), null, "~/ProjectImages/IPCamerasDashboard/img_9.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2162), 2 },
                    { 38, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2072), null, "~/ProjectImages/IPCamerasDashboard/img_8.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2085), 2 },
                    { 37, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1992), null, "~/ProjectImages/IPCamerasDashboard/img_7.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2005), 2 },
                    { 36, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1900), null, "~/ProjectImages/IPCamerasDashboard/img_6.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1913), 2 },
                    { 35, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1819), null, "~/ProjectImages/IPCamerasDashboard/img_5.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1834), 2 },
                    { 34, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1736), null, "~/ProjectImages/IPCamerasDashboard/img_4.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1747), 2 },
                    { 33, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1654), null, "~/ProjectImages/IPCamerasDashboard/img_3.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1669), 2 },
                    { 32, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1567), null, "~/ProjectImages/IPCamerasDashboard/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1578), 2 },
                    { 31, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1490), null, "~/ProjectImages/IPCamerasDashboard/img_1.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1501), 2 },
                    { 30, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1412), null, "~/ProjectImages/CBProject/img_30.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1425), 1 },
                    { 29, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1323), null, "~/ProjectImages/CBProject/img_29.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1337), 1 },
                    { 28, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1234), null, "~/ProjectImages/CBProject/img_28.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1252), 1 },
                    { 27, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1141), null, "~/ProjectImages/CBProject/img_27.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(1154), 1 },
                    { 26, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(930), null, "~/ProjectImages/CBProject/img_26.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(944), 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedDate", "ImageFullPath", "ImagePath", "LastUpdateDate", "ProjectId" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(823), null, "~/ProjectImages/CBProject/img_25.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(840), 1 },
                    { 24, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(682), null, "~/ProjectImages/CBProject/img_24.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(711), 1 },
                    { 23, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(582), null, "~/ProjectImages/CBProject/img_23.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(593), 1 },
                    { 43, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2561), null, "~/ProjectImages/IPCamerasDashboard/img_13.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(2573), 2 },
                    { 88, new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7617), null, "~/ProjectImages/RemoteAutoMoto/img_2.png", new DateTime(2022, 2, 25, 15, 17, 8, 551, DateTimeKind.Local).AddTicks(7636), 8 }
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
