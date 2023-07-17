using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLau_API.Migrations
{
    /// <inheritdoc />
    public partial class chinhsuadb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reservationTime",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "customerSize_Id",
                table: "Reservations",
                type: "nchar(5)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "reservationTime_Id",
                table: "Reservations",
                type: "nchar(5)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CustomerSize",
                columns: table => new
                {
                    customerSize_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSize", x => x.customerSize_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTime",
                columns: table => new
                {
                    reservationTime_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTime", x => x.reservationTime_Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchReservationTime",
                columns: table => new
                {
                    branch_Id = table.Column<string>(type: "nchar(5)", nullable: false),
                    reservationTime_Id = table.Column<string>(type: "nchar(5)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_customerSize_Id",
                table: "Reservations",
                column: "customerSize_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_reservationTime_Id",
                table: "Reservations",
                column: "reservationTime_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BranchReservationTime_reservationTime_Id",
                table: "BranchReservationTime",
                column: "reservationTime_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_CustomerSize_customerSize_Id",
                table: "Reservations",
                column: "customerSize_Id",
                principalTable: "CustomerSize",
                principalColumn: "customerSize_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationTime_reservationTime_Id",
                table: "Reservations",
                column: "reservationTime_Id",
                principalTable: "ReservationTime",
                principalColumn: "reservationTime_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_CustomerSize_customerSize_Id",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationTime_reservationTime_Id",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "BranchReservationTime");

            migrationBuilder.DropTable(
                name: "CustomerSize");

            migrationBuilder.DropTable(
                name: "ReservationTime");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_customerSize_Id",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_reservationTime_Id",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "customerSize_Id",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "reservationTime_Id",
                table: "Reservations");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "reservationTime",
                table: "Reservations",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
