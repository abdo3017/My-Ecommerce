using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class changeAllDataBase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Categorys");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Types",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_CategoryId",
                table: "Types",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Categorys_CategoryId",
                table: "Types",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Types_Categorys_CategoryId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_CategoryId",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Types");

            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Categorys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
