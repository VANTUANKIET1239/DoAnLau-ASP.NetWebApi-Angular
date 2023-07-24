using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class updatenamedb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nenuName",
                table: "Menus",
                newName: "menuName");

            migrationBuilder.RenameColumn(
                name: "nenuImage",
                table: "Menus",
                newName: "menuImage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "menuName",
                table: "Menus",
                newName: "nenuName");

            migrationBuilder.RenameColumn(
                name: "menuImage",
                table: "Menus",
                newName: "nenuImage");
        }
    }
}
