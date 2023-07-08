using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class creatnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    branch_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                    city_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.city_Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    menuCategory_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                    news_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                    promotionDetail_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                    promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                name: "Users",
                columns: table => new
                {
                    user_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    UserImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: " varchar(100)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    rewardPoints = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservation_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reservationTime = table.Column<string>(type: "varchar(10)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    branch_Id = table.Column<string>(type: "nchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservation_Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Branches_branch_Id",
                        column: x => x.branch_Id,
                        principalTable: "Branches",
                        principalColumn: "branch_Id");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    district_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    districtName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    city_Id = table.Column<string>(type: "nchar(5)", nullable: true)
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
                    nenu_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    nenuName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    nenuImage = table.Column<string>(type: "varchar(400)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    hotDeal = table.Column<bool>(type: "bit", nullable: false),
                    bestSaller = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    menuCategory_Id = table.Column<string>(type: "nchar(5)", nullable: true)
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
                name: "PromotionBranchs",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    branch_Id = table.Column<string>(type: "nchar(5)", nullable: false),
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
                    promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    promotionDetail_Id = table.Column<string>(type: "nchar(5)", nullable: false)
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
                name: "Addresses",
                columns: table => new
                {
                    address_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    phone = table.Column<string>(type: " varchar(15)", nullable: false),
                    email = table.Column<string>(type: " varchar(100)", nullable: false),
                    addressDetail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    ward = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    isDefault = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    user_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.address_Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "user_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    orderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalPrice = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    paymentMethod = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    user_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_Id);
                    table.ForeignKey(
                        name: "FK_Orders_Promotions_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "user_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionUsers",
                columns: table => new
                {
                    promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    user_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionUsers", x => new { x.promotion_Id, x.user_Id });
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Promotions_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Promotions",
                        principalColumn: "promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Users_promotion_Id",
                        column: x => x.promotion_Id,
                        principalTable: "Users",
                        principalColumn: "user_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationUsers",
                columns: table => new
                {
                    reservation_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    user_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationUsers", x => new { x.reservation_Id, x.user_Id });
                    table.ForeignKey(
                        name: "FK_ReservationUsers_Reservations_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Reservations",
                        principalColumn: "reservation_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationUsers_Users_reservation_Id",
                        column: x => x.reservation_Id,
                        principalTable: "Users",
                        principalColumn: "user_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    ward_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    wardName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    district_Id = table.Column<string>(type: "nchar(5)", nullable: true)
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
                    orderDetail_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    order_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    menuName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    menuImage = table.Column<string>(type: "varchar(300)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    menuTotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => new { x.order_Id, x.orderDetail_Id });
                    table.ForeignKey(
                        name: "FK_Order_Details_Orders_order_Id",
                        column: x => x.order_Id,
                        principalTable: "Orders",
                        principalColumn: "order_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_user_Id",
                table: "Addresses",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_city_Id",
                table: "Districts",
                column: "city_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_menuCategory_Id",
                table: "Menus",
                column: "menuCategory_Id");

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
                name: "IX_Orders_user_Id",
                table: "Orders",
                column: "user_Id");

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
                name: "Menus");

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
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
