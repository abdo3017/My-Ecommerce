using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class changeAllDataBase5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_IdCategory",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_Categorys_CategoryId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_CategoryId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Products_IdCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "IdCategory",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "IdCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "IdType",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "IdType");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Types",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCategory",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdCategory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_CategoryId",
                table: "Types",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdCategory",
                table: "Products",
                column: "IdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_IdCategory",
                table: "Products",
                column: "IdCategory",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Categorys_CategoryId",
                table: "Types",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
