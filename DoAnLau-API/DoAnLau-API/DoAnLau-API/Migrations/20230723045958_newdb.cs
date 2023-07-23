using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<bool>(type: "bit", nullable: false),
                    rewardPoints = table.Column<int>(type: "int", nullable: false),
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
                name: "Branches",
                columns: table => new
                {
                    branch_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    branchName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    addressDetail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    ward = table.Column<string>(type: " nvarchar(20)", nullable: false),
                    district = table.Column<string>(type: " nvarchar(20)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    openingTime = table.Column<string>(type: "varchar(20)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    city_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.city_Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSize",
                columns: table => new
                {
                    customerSize_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSize", x => x.customerSize_Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    menuCategory_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    categoryName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.menuCategory_Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    news_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.news_Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetails",
                columns: table => new
                {
                    promotionDetail_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetails", x => x.promotionDetail_Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PromotionImage = table.Column<string>(type: "varchar(300)", nullable: false),
                    promotionName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    validityPeriod = table.Column<string>(type: "varchar(80)", nullable: false),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    promotionDetails = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.promotion_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTime",
                columns: table => new
                {
                    reservationTime_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTime", x => x.reservationTime_Id);
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
                name: "Addresses",
                columns: table => new
                {
                    address_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    phone = table.Column<string>(type: " varchar(15)", nullable: false),
                    email = table.Column<string>(type: " varchar(100)", nullable: false),
                    addressDetail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    ward = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    isDefault = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.address_Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    district_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    districtName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    city_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.district_Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_city_Id",
                        column: x => x.city_Id,
                        principalTable: "Cities",
                        principalColumn: "city_Id");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    nenu_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nenuName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    nenuImage = table.Column<string>(type: "varchar(400)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    hotDeal = table.Column<bool>(type: "bit", nullable: false),
                    bestSaller = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    menuCategory_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.nenu_Id);
                    table.ForeignKey(
                        name: "FK_Menus_MenuCategories_menuCategory_Id",
                        column: x => x.menuCategory_Id,
                        principalTable: "MenuCategories",
                        principalColumn: "menuCategory_Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    orderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalPrice = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    paymentMethod = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    promotion_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Promotions_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionBranchs",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    branch_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionBranchs", x => new { x.promotion_Id, x.branch_Id });
                    table.ForeignKey(
                        name: "FK_PromotionBranchs_Branches_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "Branches",
                        principalColumn: "branch_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionBranchs_Promotions_branch_Id",
                        column: x => x.branch_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetailPromotions",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    promotionDetail_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetailPromotions", x => new { x.promotion_Id, x.promotionDetail_Id });
                    table.ForeignKey(
                        name: "FK_PromotionDetailPromotions_PromotionDetails_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "PromotionDetails",
                        principalColumn: "promotionDetail_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionDetailPromotions_Promotions_promotionDetail_Id",
                        column: x => x.promotionDetail_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionUsers",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionUsers", x => new { x.promotion_Id, x.user_Id });
                    table.ForeignKey(
                        name: "FK_PromotionUsers_AspNetUsers_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Promotions_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchReservationTime",
                columns: table => new
                {
                    branch_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    reservationTime_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchReservationTime", x => new { x.branch_Id, x.reservationTime_Id });
                    table.ForeignKey(
                        name: "FK_BranchReservationTime_Branches_reservationTime_Id",
                        column: x => x.reservationTime_Id,
                        principalTable: "Branches",
                        principalColumn: "branch_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchReservationTime_ReservationTime_branch_Id",
                        column: x => x.branch_Id,
                        principalTable: "ReservationTime",
                        principalColumn: "reservationTime_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservation_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    branch_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    customerSize_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    reservationTime_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservation_Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Branches_branch_Id",
                        column: x => x.branch_Id,
                        principalTable: "Branches",
                        principalColumn: "branch_Id");
                    table.ForeignKey(
                        name: "FK_Reservations_CustomerSize_customerSize_Id",
                        column: x => x.customerSize_Id,
                        principalTable: "CustomerSize",
                        principalColumn: "customerSize_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationTime_reservationTime_Id",
                        column: x => x.reservationTime_Id,
                        principalTable: "ReservationTime",
                        principalColumn: "reservationTime_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    ward_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    wardName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    district_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.ward_Id);
                    table.ForeignKey(
                        name: "FK_Wards_Districts_district_Id",
                        column: x => x.district_Id,
                        principalTable: "Districts",
                        principalColumn: "district_Id");
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    orderDetail_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    order_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    menuTotalPrice = table.Column<int>(type: "int", nullable: false),
                    menunenu_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => new { x.order_Id, x.orderDetail_Id });
                    table.ForeignKey(
                        name: "FK_Order_Details_Menus_menunenu_Id",
                        column: x => x.menunenu_Id,
                        principalTable: "Menus",
                        principalColumn: "nenu_Id");
                    table.ForeignKey(
                        name: "FK_Order_Details_Orders_order_Id",
                        column: x => x.order_Id,
                        principalTable: "Orders",
                        principalColumn: "order_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationUsers",
                columns: table => new
                {
                    reservation_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationUsers", x => new { x.reservation_Id, x.user_Id });
                    table.ForeignKey(
                        name: "FK_ReservationUsers_AspNetUsers_reservation_Id",
                        column: x => x.reservation_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationUsers_Reservations_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Reservations",
                        principalColumn: "reservation_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_userId",
                table: "Addresses",
                column: "userId");

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
                name: "IX_BranchReservationTime_reservationTime_Id",
                table: "BranchReservationTime",
                column: "reservationTime_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_city_Id",
                table: "Districts",
                column: "city_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_menuCategory_Id",
                table: "Menus",
                column: "menuCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_menunenu_Id",
                table: "Order_Details",
                column: "menunenu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_order_Id",
                table: "Order_Details",
                column: "order_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_promotion_Id",
                table: "Orders",
                column: "promotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_userId",
                table: "Orders",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionBranchs_branch_Id",
                table: "PromotionBranchs",
                column: "branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetailPromotions_promotionDetail_Id",
                table: "PromotionDetailPromotions",
                column: "promotionDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionUsers_user_Id",
                table: "PromotionUsers",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_branch_Id",
                table: "Reservations",
                column: "branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_customerSize_Id",
                table: "Reservations",
                column: "customerSize_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_reservationTime_Id",
                table: "Reservations",
                column: "reservationTime_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationUsers_user_Id",
                table: "ReservationUsers",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_district_Id",
                table: "Wards",
                column: "district_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

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
                name: "BranchReservationTime");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "PromotionBranchs");

            migrationBuilder.DropTable(
                name: "PromotionDetailPromotions");

            migrationBuilder.DropTable(
                name: "PromotionUsers");

            migrationBuilder.DropTable(
                name: "ReservationUsers");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "CustomerSize");

            migrationBuilder.DropTable(
                name: "ReservationTime");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
