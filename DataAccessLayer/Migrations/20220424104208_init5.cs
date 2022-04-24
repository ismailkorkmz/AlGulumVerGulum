using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AppRole_AppRoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AppUser_AppUserId",
                table: "UserRole");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AppRole_AppRoleId",
                table: "UserRole",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AppUser_AppUserId",
                table: "UserRole",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AppRole_AppRoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AppUser_AppUserId",
                table: "UserRole");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AppRole_AppRoleId",
                table: "UserRole",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AppUser_AppUserId",
                table: "UserRole",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
