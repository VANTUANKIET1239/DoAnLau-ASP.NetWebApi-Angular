using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class updatenamedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Menus_menunenu_Id",
                table: "Order_Details");

            migrationBuilder.RenameColumn(
                name: "menunenu_Id",
                table: "Order_Details",
                newName: "menu_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Details_menunenu_Id",
                table: "Order_Details",
                newName: "IX_Order_Details_menu_Id");

            migrationBuilder.RenameColumn(
                name: "nenu_Id",
                table: "Menus",
                newName: "menu_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Menus_menu_Id",
                table: "Order_Details",
                column: "menu_Id",
                principalTable: "Menus",
                principalColumn: "menu_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Menus_menu_Id",
                table: "Order_Details");

            migrationBuilder.RenameColumn(
                name: "menu_Id",
                table: "Order_Details",
                newName: "menunenu_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Details_menu_Id",
                table: "Order_Details",
                newName: "IX_Order_Details_menunenu_Id");

            migrationBuilder.RenameColumn(
                name: "menu_Id",
                table: "Menus",
                newName: "nenu_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Menus_menunenu_Id",
                table: "Order_Details",
                column: "menunenu_Id",
                principalTable: "Menus",
                principalColumn: "nenu_Id");
        }
    }
}
