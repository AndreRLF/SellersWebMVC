using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Seller",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Seller",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
