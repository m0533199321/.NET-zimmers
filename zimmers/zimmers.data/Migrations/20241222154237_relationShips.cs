using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zimmers.data.Migrations
{
    public partial class relationShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CleanerId",
                table: "zimmer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "zimmer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZimmerId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_zimmer_CleanerId",
                table: "zimmer",
                column: "CleanerId");

            migrationBuilder.CreateIndex(
                name: "IX_zimmer_OwnerId",
                table: "zimmer",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ZimmerId",
                table: "orders",
                column: "ZimmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_UserId",
                table: "orders",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_zimmer_ZimmerId",
                table: "orders",
                column: "ZimmerId",
                principalTable: "zimmer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zimmer_cleaners_CleanerId",
                table: "zimmer",
                column: "CleanerId",
                principalTable: "cleaners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zimmer_owners_OwnerId",
                table: "zimmer",
                column: "OwnerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_UserId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_zimmer_ZimmerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmer_cleaners_CleanerId",
                table: "zimmer");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmer_owners_OwnerId",
                table: "zimmer");

            migrationBuilder.DropIndex(
                name: "IX_zimmer_CleanerId",
                table: "zimmer");

            migrationBuilder.DropIndex(
                name: "IX_zimmer_OwnerId",
                table: "zimmer");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_ZimmerId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "CleanerId",
                table: "zimmer");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "zimmer");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "ZimmerId",
                table: "orders");
        }
    }
}
