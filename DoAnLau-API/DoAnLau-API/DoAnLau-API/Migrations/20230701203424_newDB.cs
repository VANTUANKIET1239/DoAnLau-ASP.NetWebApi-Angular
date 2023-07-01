using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class newDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Ward = table.Column<string>(type: " nvarchar(20)", nullable: false),
                    District = table.Column<string>(type: " nvarchar(20)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    OpeningTime = table.Column<string>(type: "varchar(20)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    City_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.City_Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    MenuCategory_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.MenuCategory_Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    PromotionName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ValidityPeriod = table.Column<string>(type: "varchar(80)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromotionDetails = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Promotion_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: " varchar(100)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    RewardPoints = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Reservation_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationTime = table.Column<string>(type: "varchar(10)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Branch_Id = table.Column<string>(type: "nchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Reservation_Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branches",
                        principalColumn: "Branch_Id");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    District_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    City_Id = table.Column<string>(type: "nchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.District_Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Cities",
                        principalColumn: "City_Id");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Menu_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    MenuImage = table.Column<string>(type: "varchar(400)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    HotDeal = table.Column<bool>(type: "bit", nullable: false),
                    BestSaller = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    MenuCategory_Id = table.Column<string>(type: "nchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Menu_Id);
                    table.ForeignKey(
                        name: "FK_Menus_MenuCategories_MenuCategory_Id",
                        column: x => x.MenuCategory_Id,
                        principalTable: "MenuCategories",
                        principalColumn: "MenuCategory_Id");
                });

            migrationBuilder.CreateTable(
                name: "PromotionBranchs",
                columns: table => new
                {
                    Promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Branch_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionBranchs", x => new { x.Promotion_Id, x.Branch_Id });
                    table.ForeignKey(
                        name: "FK_PromotionBranchs_Branches_Promotion_Id",
                        column: x => x.Promotion_Id,
                        principalTable: "Branches",
                        principalColumn: "Branch_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionBranchs_Promotions_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Promotions",
                        principalColumn: "Promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Address_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Phone = table.Column<string>(type: " varchar(15)", nullable: false),
                    Email = table.Column<string>(type: " varchar(100)", nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    User_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Address_Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    User_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_Id);
                    table.ForeignKey(
                        name: "FK_Orders_Promotions_Promotion_Id",
                        column: x => x.Promotion_Id,
                        principalTable: "Promotions",
                        principalColumn: "Promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionUsers",
                columns: table => new
                {
                    Promotion_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    User_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionUsers", x => new { x.Promotion_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Promotions_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Promotions",
                        principalColumn: "Promotion_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Users_Promotion_Id",
                        column: x => x.Promotion_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationUsers",
                columns: table => new
                {
                    Reservation_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    User_Id = table.Column<string>(type: "nchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationUsers", x => new { x.Reservation_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_ReservationUsers_Reservations_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Reservations",
                        principalColumn: "Reservation_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationUsers_Users_Reservation_Id",
                        column: x => x.Reservation_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Ward_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    District_Id = table.Column<string>(type: "nchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Ward_Id);
                    table.ForeignKey(
                        name: "FK_Wards_Districts_District_Id",
                        column: x => x.District_Id,
                        principalTable: "Districts",
                        principalColumn: "District_Id");
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    OrderDetail_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Order_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    MenuImage = table.Column<string>(type: "varchar(300)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MenuTotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => new { x.Order_Id, x.OrderDetail_Id });
                    table.ForeignKey(
                        name: "FK_Order_Details_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_User_Id",
                table: "Addresses",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_City_Id",
                table: "Districts",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuCategory_Id",
                table: "Menus",
                column: "MenuCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_Order_Id",
                table: "Order_Details",
                column: "Order_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Promotion_Id",
                table: "Orders",
                column: "Promotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_User_Id",
                table: "Orders",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionBranchs_Branch_Id",
                table: "PromotionBranchs",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionUsers_User_Id",
                table: "PromotionUsers",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Branch_Id",
                table: "Reservations",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationUsers_User_Id",
                table: "ReservationUsers",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_District_Id",
                table: "Wards",
                column: "District_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "PromotionBranchs");

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
