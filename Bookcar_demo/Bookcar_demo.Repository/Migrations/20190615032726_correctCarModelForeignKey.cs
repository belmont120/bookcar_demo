using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookcar_demo.Repository.Migrations
{
    public partial class correctCarModelForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarModel_CarModelId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarModel_CarModelId",
                table: "Car",
                column: "CarModelId",
                principalTable: "CarModel",
                principalColumn: "CarModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarModel_CarModelId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "Car",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarModel_CarModelId",
                table: "Car",
                column: "CarModelId",
                principalTable: "CarModel",
                principalColumn: "CarModelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
