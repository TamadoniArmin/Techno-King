using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Connection.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdmin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<float>(type: "real", nullable: false),
                    SalesCount = table.Column<int>(type: "int", nullable: false),
                    CommentsId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperAdminId = table.Column<int>(type: "int", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    NewRole = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_SuperAdmin_SuperAdminId",
                        column: x => x.SuperAdminId,
                        principalTable: "SuperAdmin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SetAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusEnum = table.Column<int>(type: "int", nullable: false),
                    paymentStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCardId = table.Column<int>(type: "int", nullable: false),
                    SetAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_ShoppingCards_ShoppingCardId",
                        column: x => x.ShoppingCardId,
                        principalTable: "ShoppingCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductShoppingCard",
                columns: table => new
                {
                    SelectedProductsId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCardsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShoppingCard", x => new { x.SelectedProductsId, x.ShoppingCardsId });
                    table.ForeignKey(
                        name: "FK_ProductShoppingCard_Products_SelectedProductsId",
                        column: x => x.SelectedProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCard_ShoppingCards_ShoppingCardsId",
                        column: x => x.ShoppingCardsId,
                        principalTable: "ShoppingCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "IsDeleted" },
                values: new object[] { 1, false });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "SuperAdmin", "SUPERADMIN" },
                    { 2, null, "Admin", "ADMIN" },
                    { 3, null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImagePath", "IsDeleted", "ParentId", "Title" },
                values: new object[,]
                {
                    { 1, "Laptops, desktop PCs, and computing accessories", "images/categories/Laptops_&_Computers.png", false, null, "Laptops & Computers" },
                    { 2, "Smartphones and mobile communication devices", "images/categories/Mobile_Phones.jpg", false, null, "Mobile Phones" },
                    { 3, "Touchscreen tablets, smart pads, and e-readers", "images/categories/Tablets_&_E-reader.jpg", false, null, "Tablets & E-reader" },
                    { 10, "Tech accessories, cases, cables, and chargers", "images/categories/Accessories.jpg", false, null, "Accessories" },
                    { 11, "Smartwatches, fitness bands, and wearable tech", "images/categories/Wearables.jpg", false, null, "Wearables" },
                    { 12, "Headphones, earphones, speakers, and sound systems", "images/categories/Audio.jpg", false, null, "Audio" },
                    { 13, "DSLR, mirrorless cameras, action cams, and lenses", "images/categories/Cameras.jpg", false, null, "Cameras" },
                    { 14, "Gaming consoles, controllers, and gaming gear", "images/categories/Gaming.jpg", false, null, "Gaming" },
                    { 15, "Routers, modems, switches, and network gear", "images/categories/Networking.jpg", false, null, "Networking" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IsDeleted" },
                values: new object[] { 1, false });

            migrationBuilder.InsertData(
                table: "SuperAdmin",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdminId", "Balance", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "ImagePath", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "Mobile", "NewRole", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredAt", "Role", "RoleId", "SecurityStamp", "SuperAdminId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, 1000000, "e975c22f-8ab0-44e3-805f-7fdd0dd974c7", null, "SuperAdmin@gmail.com", false, "armin", null, false, "tamadoni", false, null, "09377507920", 0, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAENZzgudddM6uMKVrN6RXQO9fhzSGKyginx5emR1QIKySt7TAfPHMHbsonZfYcotxbA==", null, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "ada9a37d-4e66-4f49-a14e-bf1f4bd0e6f0", 1, false, "SuperAdmin@gmail.com" },
                    { 2, 0, 1, 1000000, "27965def-0d29-4833-90d6-1a59788a1525", null, "Admin@gmail.com", false, "Kazem", null, false, "Hassani", false, null, "09333333333", 0, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDNGogG29TzbpfXR8dEyW54z9msx39N5p7J60B8qFXsXyqn3wlEH2YyTrCo/r898MQ==", null, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "56da5aa9-24c0-4932-8688-1c49e8aad93d", null, false, "Admin@gmail.com" },
                    { 3, 0, null, 1000000, "9f860973-8ca8-4f36-8aaf-9dc177c92bac", 1, "Customer@gmail.com", false, "Ali", null, false, "baghani", false, null, "09222222222", 0, "CUSTOMER@GMAIL.COM", "CUSTOMER@GMAIL.COM", "AQAAAAIAAYagAAAAEHKRtQ90vsbb39tRXod/l3TdKUV4dN+SoRhYrRCgQYgesUOEVcWcBotKpqNf7OIujw==", null, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "bd984d87-783f-4230-9797-4c37e661373b", null, false, "Customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImagePath", "IsDeleted", "ParentId", "Title" },
                values: new object[,]
                {
                    { 4, "Laptops, notebooks, and mobile workstations", "images/categories/Laptops.png", false, 1, "Laptops" },
                    { 5, "Android and iOS mobile devices", "images/categories/Smartphones.jpg", false, 2, "Smartphones" },
                    { 6, "Touchscreen tablets and smart pads", "images/categories/Tablets.jpg", false, 3, "Tablets" },
                    { 7, "Protective covers and phone cases", "images/categories/Phone_Cases.jpg", false, 10, "Phone Cases" },
                    { 8, "Wireless earbuds, TWS, and over-ear headphones", "images/categories/Headphones_&_Earphones.jpg", false, 12, "Headphones & Earphones" },
                    { 9, "Bluetooth and portable audio speakers", "images/categories/Speakers.jpg", false, 12, "Speakers" },
                    { 16, "Smart fitness and lifestyle watches", "images/categories/Smartwatches.jpg", false, 11, "Smartwatches" },
                    { 17, "Activity trackers and health bands", "images/categories/Fitness_Bands.jpg", false, 11, "Fitness Bands" },
                    { 18, "Professional cameras and interchangeable lenses", "images/categories/DSLR_&_Mirrorless.jpg", false, 13, "DSLR & Mirrorless" },
                    { 19, "Compact action cameras and camcorders", "images/categories/Action_Cameras.jpg", false, 13, "Action Cameras" },
                    { 20, "PlayStation, Xbox, and Nintendo consoles", "images/categories/Gaming_Consoles.jpg", false, 14, "Gaming Consoles" },
                    { 21, "Controllers, gamepads, and VR headsets", "images/categories/Gaming_Accessories.jpg", false, 14, "Gaming Accessories" },
                    { 22, "Wireless routers and Mesh Wi-Fi systems", "images/categories/Wi-Fi_Routers.jpg", false, 15, "Wi-Fi Routers" },
                    { 23, "ADSL/VDSL modems and Ethernet network switches", "images/categories/Modems_&_Switches.jpg", false, 15, "Modems & Switches" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AverageRating", "Brand", "CommentsId", "CustomerId", "Description", "DiscountPercentage", "ImageUrl1", "ImageUrl2", "ImageUrl3", "IsDeleted", "Name", "Price", "SalesCount", "SubCategoryId" },
                values: new object[,]
                {
                    { 7, 4.1f, "Epson", null, null, "Home theater projector featuring 4K resolution capabilities and 3000 lumens brightness.", 12, "images/Products/Epson_Home_Cinema_Projector/image_1.jpg", "images/Products/Epson_Home_Cinema_Projector/image_2.jpg", "images/Products/Epson_Home_Cinema_Projector/image_3.jpg", false, "Epson Home Cinema Projector", 12000f, 45, 10 },
                    { 43, 4.6f, "Anker", null, null, "Soda-can sized mini smart projector with Google TV and 1080p Laser display.", 10, "images/Products/Anker_Nebula_Capsule_3/image_1.jpg", "images/Products/Anker_Nebula_Capsule_3/image_2.jpg", "images/Products/Anker_Nebula_Capsule_3/image_3.jpg", false, "Anker Nebula Capsule 3", 18000f, 125, 10 },
                    { 44, 4.8f, "XGIMI", null, null, "Premium home projector with Harman Kardon speakers and Intelligent Screen Adaptation.", 8, "images/Products/XGIMI_Horizon_Pro_4K/image_1.png", "images/Products/XGIMI_Horizon_Pro_4K/image_2.jpg", "images/Products/XGIMI_Horizon_Pro_4K/image_3.jpg", false, "XGIMI Horizon Pro 4K", 34000f, 95, 10 },
                    { 45, 4.3f, "BenQ", null, null, "Low input lag Full HD projector designed for console gaming and sports viewing.", 15, "images/Products/BenQ_TH585P_Gaming_Projector/image_1.webp", "images/Products/BenQ_TH585P_Gaming_Projector/image_2.jpg", "images/Products/BenQ_TH585P_Gaming_Projector/image_3.webp", false, "BenQ TH585P Gaming Projector", 16000f, 80, 10 },
                    { 46, 4.2f, "Samsung", null, null, "Portable smart projector with 180-degree cradle design and Gaming Hub support.", 5, "images/Products/Samsung_The_Freestyle_Gen_2/image_1.webp", "images/Products/Samsung_The_Freestyle_Gen_2/image_2.png", "images/Products/Samsung_The_Freestyle_Gen_2/image_3.jpg", false, "Samsung The Freestyle Gen 2", 21000f, 210, 10 },
                    { 47, 4.1f, "LG", null, null, "Compact Smart TV LED projector with built-in battery lasting up to 2.5 hours.", 10, "images/Products/LG_CineBeam_PF50KA/image_1.jpg", "images/Products/LG_CineBeam_PF50KA/image_2.jpg", "images/Products/LG_CineBeam_PF50KA/image_3.jpg", false, "LG CineBeam PF50KA", 14500f, 65, 10 },
                    { 48, 4.4f, "ViewSonic", null, null, "Instant auto-focus 1080p LED portable projector with Harman Kardon speakers.", 18, "images/Products/ViewSonic_M2e_Smart_Projector/image_1.jpg", "images/Products/ViewSonic_M2e_Smart_Projector/image_2.jpg", "images/Products/ViewSonic_M2e_Smart_Projector/image_3.jpg", false, "ViewSonic M2e Smart Projector", 13000f, 110, 10 },
                    { 49, 4f, "Optoma", null, null, "Home theater projector with Enhanced Gaming Mode and 3600 lumens brightness.", 7, "images/Products/Optoma_HD146X_High_Performance/image_1.jpg", "images/Products/Optoma_HD146X_High_Performance/image_2.jpg", "images/Products/Optoma_HD146X_High_Performance/image_3.jpg", false, "Optoma HD146X High Performance", 15500f, 135, 10 },
                    { 50, 3.9f, "Wanbo", null, null, "Mini LCD projector with native 1080p support and fully enclosed optical engine.", 20, "images/Products/Wanbo_T2_Max_Portable_Projector/image_1.png", "images/Products/Wanbo_T2_Max_Portable_Projector/image_2.jpg", "images/Products/Wanbo_T2_Max_Portable_Projector/image_3.jpg", false, "Wanbo T2 Max Portable Projector", 5000f, 310, 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AverageRating", "Brand", "CommentsId", "CustomerId", "Description", "DiscountPercentage", "ImageUrl1", "ImageUrl2", "ImageUrl3", "IsDeleted", "Name", "Price", "SalesCount", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 4.5f, "Dell", null, null, "Lightweight and powerful laptop featuring Intel Core i7 processor and 13-inch Full HD display.", 10, "images/Products/Dell_XPS_13_Laptop/image_1.png", "images/Products/Dell_XPS_13_Laptop/image_2.png", "images/Products/Dell_XPS_13_Laptop/image_3.jpg", false, "Dell XPS 13 Laptop", 25000f, 120, 4 },
                    { 2, 4.8f, "Samsung", null, null, "Flagship smartphone featuring 200MP camera and 5000mAh long-lasting battery.", 5, "images/Products/Samsung_Galaxy_S24_Ultra/image_1.jpg", "images/Products/Samsung_Galaxy_S24_Ultra/image_2.png", "images/Products/Samsung_Galaxy_S24_Ultra/image_3.jpg", false, "Samsung Galaxy S24", 18000f, 450, 5 },
                    { 3, 4.7f, "Apple", null, null, "Apple tablet powered by M2 chip featuring a 10.9-inch Liquid Retina display.", 0, "images/Products/iPad_Air_M2/image_1.jpg", "images/Products/iPad_Air_M2/image_2.jpg", "images/Products/iPad_Air_M2/image_3.jpg", false, "iPad Air", 15000f, 85, 6 },
                    { 4, 4.2f, "Spigen", null, null, "Shockproof and scratch-resistant smartphone case with ergonomic grip design.", 15, "images/Products/Spigen_Protective_Phone_Case/image_1.jpg", "images/Products/Spigen_Protective_Phone_Case/image_2.jpg", "images/Products/Spigen_Protective_Phone_Case/image_3.jpg", false, "Spigen Protective Phone Case", 500f, 1200, 7 },
                    { 5, 4.9f, "Apple", null, null, "Apple wireless earbuds featuring Active Noise Cancellation and 6-hour battery life.", 20, "images/Products/AirPods_Pro_Wireless_Earbuds/image_1.jpg", "images/Products/AirPods_Pro_Wireless_Earbuds/image_2.jpg", "images/Products/AirPods_Pro_Wireless_Earbuds/image_3.jpg", false, "AirPods Pro Wireless Earbuds", 8000f, 600, 8 },
                    { 6, 4.4f, "JBL", null, null, "Waterproof Bluetooth speaker with 20-hour power bank capacity and 360-degree audio.", 8, "images/Products/JBL_Charge_5_Speaker/image_1.png", "images/Products/JBL_Charge_5_Speaker/image_2.jpg", "images/Products/JBL_Charge_5_Speaker/image_3.png", false, "JBL Charge 5 Speaker", 6000f, 310, 9 },
                    { 8, 4.3f, "HP", null, null, "High-performance gaming laptop with RTX 3060 graphics card and 16GB RAM.", 25, "images/Products/HP_Pavilion_Gaming_Laptop/image_1.jpg", "images/Products/HP_Pavilion_Gaming_Laptop/image_2.jpg", "images/Products/HP_Pavilion_Gaming_Laptop/image_3.jpg", false, "HP Pavilion Gaming Laptop", 22000f, 150, 4 },
                    { 9, 4.9f, "Apple", null, null, "Pro iPhone powered by A17 Pro chip and triple 48MP camera system.", 5, "images/Products/iPhone_15_Pro/image_1.jpg", "images/Products/iPhone_15_Pro/image_2.jpg", "images/Products/iPhone_15_Pro/image_3.jpg", false, "iPhone 15 Pro", 32000f, 280, 5 },
                    { 10, 4f, "OtterBox", null, null, "Heavy-duty rugged case built for extreme durability and drop protection.", 18, "images/Products/OtterBox_Defender_Case/image_1.jpg", "images/Products/OtterBox_Defender_Case/image_2.jpg", "images/Products/OtterBox_Defender_Case/image_3.jpg", false, "OtterBox Defender Case", 700f, 850, 7 },
                    { 11, 4.9f, "Apple", null, null, "Powered by M3 Max chip with 36GB unified memory and Liquid Retina XDR display.", 0, "images/Products/Apple_MacBook_Pro_16/image_1.jpg", "images/Products/Apple_MacBook_Pro_16/image_2.jpg", "images/Products/Apple_MacBook_Pro_16/image_3.jpg", false, "Apple MacBook Pro 16", 35000f, 210, 4 },
                    { 12, 4.7f, "ASUS", null, null, "Ultra-portable gaming laptop featuring AMD Ryzen 9 and RTX 4070 GPU.", 12, "images/Products/Asus_ROG_Zephyrus_G14/image_1.jpg", "images/Products/Asus_ROG_Zephyrus_G14/image_2.jpg", "images/Products/Asus_ROG_Zephyrus_G14/image_3.jpg", false, "ASUS ROG Zephyrus G14", 28000f, 95, 4 },
                    { 13, 4.6f, "Lenovo", null, null, "Business laptop engineered for durability with Intel Core i7 and carbon fiber chassis.", 8, "images/Products/Lenovo_ThinkPad_X1_Carbon/image_1.png", "images/Products/Lenovo_ThinkPad_X1_Carbon/image_2.png", "images/Products/Lenovo_ThinkPad_X1_Carbon/image_3.jpg", false, "Lenovo ThinkPad X1 Carbon", 26000f, 180, 4 },
                    { 14, 4.2f, "Acer", null, null, "Affordable and sleek laptop equipped with AMD Ryzen 7 processor for daily tasks.", 15, "images/Products/Acer_Swift_3/image_1.jpg", "images/Products/Acer_Swift_3/image_2.png", "images/Products/Acer_Swift_3/image_3.jpg", false, "Acer Swift 3", 14000f, 310, 4 },
                    { 15, 4.4f, "Microsoft", null, null, "Elegant touchscreen laptop with PixelSense display and long-lasting battery life.", 5, "images/Products/Microsoft_Surface_Laptop_5/image_1.jpg", "images/Products/Microsoft_Surface_Laptop_5/image_2.webp", "images/Products/Microsoft_Surface_Laptop_5/image_3.webp", false, "Microsoft Surface Laptop 5", 21000f, 115, 4 },
                    { 16, 4.8f, "Razer", null, null, "Premium gaming laptop featuring OLED 240Hz display and NVIDIA RTX 4080.", 7, "images/Products/Razer_Blade_15/image_1.jpg", "images/Products/Razer_Blade_15/image_2.jpg", "images/Products/Razer_Blade_15/image_3.jpg", false, "Razer Blade 15", 38000f, 75, 4 },
                    { 17, 4.6f, "Google", null, null, "Advanced AI camera system powered by Google Tensor G3 chip.", 10, "images/Products/Google_Pixel_8_Pro/image_1.jpg", "images/Products/Google_Pixel_8_Pro/image_2.jpg", "images/Products/Google_Pixel_8_Pro/image_3.jpg", false, "Google Pixel 8 Pro", 20000f, 330, 5 },
                    { 18, 4.5f, "Xiaomi", null, null, "Professional photography phone co-engineered with Leica quad-camera setup.", 12, "images/Products/Xiaomi_13_Ultra/image_1.jpg", "images/Products/Xiaomi_13_Ultra/image_2.jpg", "images/Products/Xiaomi_13_Ultra/image_3.jpg", false, "Xiaomi 13 Ultra", 17000f, 520, 5 },
                    { 19, 4.7f, "OnePlus", null, null, "Fast performance phone with Snapdragon 8 Gen 3 and 100W SUPERVOOC charging.", 8, "images/Products/OnePlus_12/image_1.png", "images/Products/OnePlus_12/image_2.png", "images/Products/OnePlus_12/image_3.jpg", false, "OnePlus 12", 16000f, 290, 5 },
                    { 20, 4.3f, "Sony", null, null, "Designed for content creators with 4K HDR OLED display and Exmor T sensor.", 0, "images/Products/Sony_Xperia_1_V/image_1.webp", "images/Products/Sony_Xperia_1_V/image_2.jpg", "images/Products/Sony_Xperia_1_V/image_3.jpg", false, "Sony Xperia 1 V", 24000f, 80, 5 },
                    { 21, 4.4f, "Samsung", null, null, "Foldable screen device with multi-tasking capabilities and S Pen support.", 15, "images/Products/Samsung_Galaxy_Z_Fold_5/image_1.jpg", "images/Products/Samsung_Galaxy_Z_Fold_5/image_2.jpg", "images/Products/Samsung_Galaxy_Z_Fold_5/image_3.png", false, "Samsung Galaxy Z Fold 5", 36000f, 140, 5 },
                    { 22, 4.8f, "Samsung", null, null, "Massive 14.6-inch Dynamic AMOLED 2X display with IP68 water resistance.", 10, "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_1.jpg", "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_2.jpg", "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_3.jpg", false, "Samsung Galaxy Tab S9 Ultra", 23000f, 110, 6 },
                    { 23, 4.9f, "Apple", null, null, "Ultimate iPad experience with XDR display, ProMotion technology, and Thunderbolt support.", 5, "images/Products/iPad_Pro_12.9_M2/image_1.webp", "images/Products/iPad_Pro_12.9_M2/image_2.jpg", "images/Products/iPad_Pro_12.9_M2/image_3.png", false, "iPad Pro 12.9 M2", 29000f, 200, 6 },
                    { 24, 4.2f, "Lenovo", null, null, "Versatile Android tablet featuring 120Hz AMOLED display and JBL quad speakers.", 18, "images/Products/Lenovo_Tab_P12_Pro/image_1.jpg", "images/Products/Lenovo_Tab_P12_Pro/image_2.png", "images/Products/Lenovo_Tab_P12_Pro/image_3.png", false, "Lenovo Tab P12 Pro", 12000f, 90, 6 },
                    { 25, 4.5f, "Microsoft", null, null, "2-in-1 tablet/laptop hybrid running full Windows 11 operating system.", 8, "images/Products/Microsoft_Surface_Pro_9/image_1.jpg", "images/Products/Microsoft_Surface_Pro_9/image_2.jpg", "images/Products/Microsoft_Surface_Pro_9/image_3.jpg", false, "Microsoft Surface Pro 9", 24000f, 160, 6 },
                    { 26, 4.4f, "Xiaomi", null, null, "Budget-friendly tablet featuring 144Hz WQHD+ display and Snapdragon 870.", 12, "images/Products/Xiaomi_Pad_6/image_1.jpg", "images/Products/Xiaomi_Pad_6/image_2.png", "images/Products/Xiaomi_Pad_6/image_3.jpg", false, "Xiaomi Pad 6", 8500f, 410, 6 },
                    { 27, 4.3f, "Apple", null, null, "Specially tanned leather cover with built-in magnets for fast wireless charging.", 0, "images/Products/Apple_Leather_Case_with_MagSafe/image_1.jpg", "images/Products/Apple_Leather_Case_with_MagSafe/image_2.jpg", "images/Products/Apple_Leather_Case_with_MagSafe/image_3.jpg", false, "Apple Leather Case with MagSafe", 1200f, 670, 7 },
                    { 28, 4.6f, "UAG", null, null, "Multi-layer protective armor case passing double military drop test standards.", 10, "images/Products/UAG_Monarch_Rugged_Case/image_1.jpg", "images/Products/UAG_Monarch_Rugged_Case/image_2.jpg", "images/Products/UAG_Monarch_Rugged_Case/image_3.jpg", false, "UAG Monarch Rugged Case", 900f, 390, 7 },
                    { 29, 4.1f, "ESR", null, null, "Ultra-thin transparent case with yellowing-resistant TPU material.", 20, "images/Products/ESR_Clear_Silicone_Case/image_1.jpg", "images/Products/ESR_Clear_Silicone_Case/image_2.jpg", "images/Products/ESR_Clear_Silicone_Case/image_3.jpg", false, "ESR Clear Silicone Case", 300f, 1500, 7 },
                    { 30, 4.4f, "Nillkin", null, null, "Slim protective cover equipped with a sliding lens cover for privacy and safety.", 5, "images/Products/Nillkin_CamShield_Case/image_1.jpg", "images/Products/Nillkin_CamShield_Case/image_2.jpg", "images/Products/Nillkin_CamShield_Case/image_3.jpg", false, "Nillkin CamShield Case", 450f, 780, 7 },
                    { 31, 4.8f, "Sony", null, null, "Industry-leading noise-canceling over-ear headphones with superior call quality.", 10, "images/Products/Sony_WH-1000XM5_Headphones/image_1.webp", "images/Products/Sony_WH-1000XM5_Headphones/image_2.jpg", "images/Products/Sony_WH-1000XM5_Headphones/image_3.jpg", false, "Sony WH-1000XM5 Headphones", 11000f, 890, 8 },
                    { 32, 4.6f, "Sennheiser", null, null, "Audiophile-grade sound quality paired with an exceptional 60-hour battery runtime.", 15, "images/Products/Sennheiser_Momentum_4_Wireless/image_1.jpg", "images/Products/Sennheiser_Momentum_4_Wireless/image_2.jpg", "images/Products/Sennheiser_Momentum_4_Wireless/image_3.jpg", false, "Sennheiser Momentum 4 Wireless", 10000f, 340, 8 },
                    { 33, 4.7f, "Bose", null, null, "Personalized noise cancellation and sound performance with CustomTune technology.", 5, "images/Products/Bose_QuietComfort_Earbuds_II/image_1.png", "images/Products/Bose_QuietComfort_Earbuds_II/image_2.png", "images/Products/Bose_QuietComfort_Earbuds_II/image_3.png", false, "Bose QuietComfort Earbuds II", 9000f, 420, 8 },
                    { 34, 4.3f, "Anker", null, null, "Budget TWS earbuds with heart rate sensor, spatial audio, and LDAC support.", 25, "images/Products/Anker_Soundcore_Liberty_4/image_1.jpg", "images/Products/Anker_Soundcore_Liberty_4/image_2.png", "images/Products/Anker_Soundcore_Liberty_4/image_3.jpg", false, "Anker Soundcore Liberty 4", 3500f, 980, 8 },
                    { 35, 4.5f, "Samsung", null, null, "Hi-Fi 24-bit audio earbuds featuring intelligent 360 audio and ergonomic fit.", 12, "images/Products/Galaxy_Buds_2_Pro/image_1.jpg", "images/Products/Galaxy_Buds_2_Pro/image_2.jpg", "images/Products/Galaxy_Buds_2_Pro/image_3.jpg", false, "Galaxy Buds 2 Pro", 6500f, 510, 8 },
                    { 36, 4.2f, "JBL", null, null, "Lightweight wireless over-ear headphones with Active Noise Cancelling and Pure Bass.", 18, "images/Products/JBL_Tune_760NC/image_1.jpg", "images/Products/JBL_Tune_760NC/image_2.jpg", "images/Products/JBL_Tune_760NC/image_3.jpg", false, "JBL Tune 760NC", 2800f, 630, 8 },
                    { 37, 4.7f, "Marshall", null, null, "Iconic vintage-style home speaker delivering room-filling stereo sound.", 5, "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_1.jpg", "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_2.jpg", "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_3.jpg", false, "Marshall Acton III Bluetooth Speaker", 9500f, 230, 9 },
                    { 38, 4.3f, "Sonos", null, null, "Smart portable speaker with Wi-Fi and Bluetooth connectivity and Automatic Trueplay.", 10, "images/Products/Sonos_Roam_Portable_Speaker/image_1.jpg", "images/Products/Sonos_Roam_Portable_Speaker/image_2.jpg", "images/Products/Sonos_Roam_Portable_Speaker/image_3.webp", false, "Sonos Roam Portable Speaker", 5500f, 190, 9 },
                    { 39, 4.8f, "Harman Kardon", null, null, "Transparent dome Bluetooth speaker featuring ambient lighting patterns and 360-degree sound.", 0, "images/Products/Harman_Kardon_Aura_Studio_4/image_1.png", "images/Products/Harman_Kardon_Aura_Studio_4/image_2.jpg", "images/Products/Harman_Kardon_Aura_Studio_4/image_3.png", false, "Harman Kardon Aura Studio 4", 11000f, 140, 9 },
                    { 40, 4.6f, "Bose", null, null, "Rugged outdoor Bluetooth speaker designed with PositionIQ technology and dust resistance.", 12, "images/Products/Bose_SoundLink_Flex/image_1.webp", "images/Products/Bose_SoundLink_Flex/image_2.jpg", "images/Products/Bose_SoundLink_Flex/image_3.jpg", false, "Bose SoundLink Flex", 4800f, 410, 9 },
                    { 41, 4.5f, "Anker", null, null, "Hi-Res 30W portable Bluetooth speaker with Qualcomm aptX audio technology.", 15, "images/Products/Anker_Soundcore_Motion+/image_1.jpg", "images/Products/Anker_Soundcore_Motion+/image_2.jpg", "images/Products/Anker_Soundcore_Motion+/image_3.webp", false, "Anker Soundcore Motion+", 3200f, 760, 9 },
                    { 42, 4.4f, "Ultimate Ears", null, null, "Powerful wireless Bluetooth speaker with deep bass, one-touch control, and IP67 rating.", 20, "images/Products/Ultimate_Ears_MEGABOOM_3/image_1.jpg", "images/Products/Ultimate_Ears_MEGABOOM_3/image_2.jpg", "images/Products/Ultimate_Ears_MEGABOOM_3/image_3.jpg", false, "Ultimate Ears MEGABOOM 3", 6200f, 280, 9 },
                    { 51, 4.8f, "Apple", null, null, "Advanced smartwatch featuring S9 SiP, Double Tap gesture, and bright Always-On Retina display.", 5, "images/Products/Apple_Watch_Series_9/image_1.jpg", "images/Products/Apple_Watch_Series_9/image_2.jpg", "images/Products/Apple_Watch_Series_9/image_3.jpg", false, "Apple Watch Series 9", 16000f, 520, 16 },
                    { 52, 4.6f, "Samsung", null, null, "Comprehensive health tracker with personalized heart rate zones and sleep coaching.", 10, "images/Products/Samsung_Galaxy_Watch_6/image_1.jpg", "images/Products/Samsung_Galaxy_Watch_6/image_2.jpg", "images/Products/Samsung_Galaxy_Watch_6/image_3.jpg", false, "Samsung Galaxy Watch 6", 12000f, 410, 16 },
                    { 53, 4.5f, "Xiaomi", null, null, "Lightweight fitness band featuring 1.62-inch AMOLED display and 16-day battery life.", 15, "images/Products/Xiaomi_Smart_Band_8/image_1.jpg", "images/Products/Xiaomi_Smart_Band_8/image_2.png", "images/Products/Xiaomi_Smart_Band_8/image_3.jpg", false, "Xiaomi Smart Band 8", 2000f, 1100, 17 },
                    { 54, 4.9f, "Sony", null, null, "Full-frame mirrorless camera with 33MP Exmor R sensor and 4K 60p video capabilities.", 0, "images/Products/Sony_Alpha_A7_IV/image_1.jpg", "images/Products/Sony_Alpha_A7_IV/image_2.jpg", "images/Products/Sony_Alpha_A7_IV/image_3.jpg", false, "Sony Alpha A7 IV", 95000f, 140, 18 },
                    { 55, 4.8f, "Canon", null, null, "Versatile full-frame camera offering 24.2MP sensor and up to 40 fps continuous shooting.", 5, "images/Products/Canon_EOS_R6_Mark_II/image_1.webp", "images/Products/Canon_EOS_R6_Mark_II/image_2.jpg", "images/Products/Canon_EOS_R6_Mark_II/image_3.webp", false, "Canon EOS R6 Mark II", 88000f, 95, 18 },
                    { 56, 4.7f, "GoPro", null, null, "Rugged action camera featuring 5.3K60 video recording and HyperSmooth 6.0 stabilization.", 8, "images/Products/GoPro_HERO12_Black/image_1.png", "images/Products/GoPro_HERO12_Black/image_2.jpg", "images/Products/GoPro_HERO12_Black/image_3.jpg", false, "GoPro HERO12 Black", 18000f, 380, 19 },
                    { 57, 4.9f, "Sony", null, null, "Next-gen gaming console with ultra-high speed SSD and DualSense wireless controller support.", 0, "images/Products/PlayStation_5_Console/image_1.png", "images/Products/PlayStation_5_Console/image_2.png", "images/Products/PlayStation_5_Console/image_3.png", false, "PlayStation 5 Console", 24000f, 850, 20 },
                    { 58, 4.8f, "Microsoft", null, null, "4K gaming console powered by 12 teraflops of raw graphic processing power.", 5, "images/Products/Xbox_Series_X/image_1.png", "images/Products/Xbox_Series_X/image_2.jpg", "images/Products/Xbox_Series_X/image_3.jpg", false, "Xbox Series X", 23000f, 620, 20 },
                    { 59, 4.6f, "Sony", null, null, "High-performance customizable wireless controller built for competitive gaming.", 10, "images/Products/DualSense_Edge_Controller/image_1.jpg", "images/Products/DualSense_Edge_Controller/image_2.jpg", "images/Products/DualSense_Edge_Controller/image_3.jpg", false, "DualSense Edge Controller", 8500f, 270, 21 },
                    { 60, 4.5f, "TP-Link", null, null, "Dual-Band Gigabit Wi-Fi 6 router providing ultra-fast speeds up to 5400 Mbps.", 12, "images/Products/TP-Link_Archer_AX73_Wi-Fi_6_Router/image_1.jpg", "images/Products/TP-Link_Archer_AX73_Wi-Fi_6_Router/image_2.jpg", "images/Products/TP-Link_Archer_AX73_Wi-Fi_6_Router/image_3.jpg", false, "TP-Link Archer AX73 Wi-Fi 6 Router", 5500f, 490, 22 },
                    { 61, 4.7f, "Asus", null, null, "High-efficiency Wi-Fi 6 router featuring dual 2.5G ports and commercial-grade security.", 7, "images/Products/Asus_RT-AX88U_Pro_Gaming_Router/image_1.png", "images/Products/Asus_RT-AX88U_Pro_Gaming_Router/image_2.jpg", "images/Products/Asus_RT-AX88U_Pro_Gaming_Router/image_3.jpg", false, "Asus RT-AX88U Pro Gaming Router", 12500f, 180, 23 }
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
                name: "IX_AspNetUsers_AdminId",
                table: "AspNetUsers",
                column: "AdminId",
                unique: true,
                filter: "[AdminId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerId",
                table: "AspNetUsers",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SuperAdminId",
                table: "AspNetUsers",
                column: "SuperAdminId",
                unique: true,
                filter: "[SuperAdminId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShoppingCardId",
                table: "Orders",
                column: "ShoppingCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerId",
                table: "Products",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCard_ShoppingCardsId",
                table: "ProductShoppingCard",
                column: "ShoppingCardsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCards_CustomerId",
                table: "ShoppingCards",
                column: "CustomerId");
        }

        /// <inheritdoc />
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductShoppingCard");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCards");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "SuperAdmin");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
