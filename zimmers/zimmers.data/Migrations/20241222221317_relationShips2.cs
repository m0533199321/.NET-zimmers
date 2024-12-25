using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zimmers.data.Migrations
{
    public partial class relationShips2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_zimmer_ZimmerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmer_cleaners_CleanerId",
                table: "zimmer");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmer_owners_OwnerId",
                table: "zimmer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zimmer",
                table: "zimmer");

            migrationBuilder.RenameTable(
                name: "zimmer",
                newName: "zimmers");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "zimmers",
                newName: "ownerId");

            migrationBuilder.RenameColumn(
                name: "CleanerId",
                table: "zimmers",
                newName: "cleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmer_OwnerId",
                table: "zimmers",
                newName: "IX_zimmers_ownerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmer_CleanerId",
                table: "zimmers",
                newName: "IX_zimmers_cleanerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zimmers",
                table: "zimmers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_zimmers_ZimmerId",
                table: "orders",
                column: "ZimmerId",
                principalTable: "zimmers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zimmers_cleaners_cleanerId",
                table: "zimmers",
                column: "cleanerId",
                principalTable: "cleaners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zimmers_owners_ownerId",
                table: "zimmers",
                column: "ownerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_zimmers_ZimmerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_cleaners_cleanerId",
                table: "zimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_owners_ownerId",
                table: "zimmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zimmers",
                table: "zimmers");

            migrationBuilder.RenameTable(
                name: "zimmers",
                newName: "zimmer");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "zimmer",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "cleanerId",
                table: "zimmer",
                newName: "CleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_ownerId",
                table: "zimmer",
                newName: "IX_zimmer_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_cleanerId",
                table: "zimmer",
                newName: "IX_zimmer_CleanerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zimmer",
                table: "zimmer",
                column: "Id");

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
    }
}
