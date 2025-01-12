using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zimmers.data.Migrations
{
    public partial class BigLetters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_UserId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_zimmers_ZimmerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_cleaners_CleanerId",
                table: "zimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_zimmers_owners_OwnerId",
                table: "zimmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zimmers",
                table: "zimmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners",
                table: "owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cleaners",
                table: "cleaners");

            migrationBuilder.RenameTable(
                name: "zimmers",
                newName: "Zimmers");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "owners",
                newName: "Owners");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "cleaners",
                newName: "Cleaners");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_OwnerId",
                table: "Zimmers",
                newName: "IX_Zimmers_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_zimmers_CleanerId",
                table: "Zimmers",
                newName: "IX_Zimmers_CleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_ZimmerId",
                table: "Orders",
                newName: "IX_Orders_ZimmerId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zimmers",
                table: "Zimmers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cleaners",
                table: "Cleaners",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Zimmers_ZimmerId",
                table: "Orders",
                column: "ZimmerId",
                principalTable: "Zimmers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zimmers_Cleaners_CleanerId",
                table: "Zimmers",
                column: "CleanerId",
                principalTable: "Cleaners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zimmers_Owners_OwnerId",
                table: "Zimmers",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Zimmers_ZimmerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Zimmers_Cleaners_CleanerId",
                table: "Zimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_Zimmers_Owners_OwnerId",
                table: "Zimmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zimmers",
                table: "Zimmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cleaners",
                table: "Cleaners");

            migrationBuilder.RenameTable(
                name: "Zimmers",
                newName: "zimmers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "owners");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "Cleaners",
                newName: "cleaners");

            migrationBuilder.RenameIndex(
                name: "IX_Zimmers_OwnerId",
                table: "zimmers",
                newName: "IX_zimmers_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Zimmers_CleanerId",
                table: "zimmers",
                newName: "IX_zimmers_CleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ZimmerId",
                table: "orders",
                newName: "IX_orders_ZimmerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "orders",
                newName: "IX_orders_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zimmers",
                table: "zimmers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners",
                table: "owners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cleaners",
                table: "cleaners",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_UserId",
                table: "orders",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_zimmers_ZimmerId",
                table: "orders",
                column: "ZimmerId",
                principalTable: "zimmers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
