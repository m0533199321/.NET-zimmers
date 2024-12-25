using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zimmers.data.Migrations
{
    public partial class relationShips3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_cleaners_cleanerId",
                table: "zimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_owners_ownerId",
                table: "zimmers");

            migrationBuilder.DropColumn(
                name: "Cleaner_id",
                table: "zimmers");

            migrationBuilder.DropColumn(
                name: "Owner_id",
                table: "zimmers");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Zimmer_id",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "zimmers",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "cleanerId",
                table: "zimmers",
                newName: "CleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_ownerId",
                table: "zimmers",
                newName: "IX_zimmers_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_cleanerId",
                table: "zimmers",
                newName: "IX_zimmers_CleanerId");

            migrationBuilder.AddForeignKey(
                name: "FK_zimmers_cleaners_CleanerId",
                table: "zimmers",
                column: "CleanerId",
                principalTable: "cleaners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zimmers_owners_OwnerId",
                table: "zimmers",
                column: "OwnerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_cleaners_CleanerId",
                table: "zimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_owners_OwnerId",
                table: "zimmers");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "zimmers",
                newName: "ownerId");

            migrationBuilder.RenameColumn(
                name: "CleanerId",
                table: "zimmers",
                newName: "cleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_OwnerId",
                table: "zimmers",
                newName: "IX_zimmers_ownerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_CleanerId",
                table: "zimmers",
                newName: "IX_zimmers_cleanerId");

            migrationBuilder.AddColumn<int>(
                name: "Cleaner_id",
                table: "zimmers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Owner_id",
                table: "zimmers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Zimmer_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
