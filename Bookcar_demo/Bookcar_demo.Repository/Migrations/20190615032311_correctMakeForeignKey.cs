using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookcar_demo.Repository.Migrations
{
    public partial class correctMakeForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModel_Make_MakeId",
                table: "CarModel");

            migrationBuilder.DropColumn(
                name: "CarMakeId",
                table: "CarModel");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "CarModel",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModel_Make_MakeId",
                table: "CarModel",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "MakeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModel_Make_MakeId",
                table: "CarModel");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "CarModel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CarMakeId",
                table: "CarModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModel_Make_MakeId",
                table: "CarModel",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "MakeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
