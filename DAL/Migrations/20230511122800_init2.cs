using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yiyecekler_Ogunler_OgunID",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "Porsiyon",
                table: "Yiyecekler");

            migrationBuilder.AlterColumn<int>(
                name: "OgunID",
                table: "Yiyecekler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Yiyecekler_Ogunler_OgunID",
                table: "Yiyecekler",
                column: "OgunID",
                principalTable: "Ogunler",
                principalColumn: "OgunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yiyecekler_Ogunler_OgunID",
                table: "Yiyecekler");

            migrationBuilder.AlterColumn<int>(
                name: "OgunID",
                table: "Yiyecekler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Porsiyon",
                table: "Yiyecekler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Yiyecekler_Ogunler_OgunID",
                table: "Yiyecekler",
                column: "OgunID",
                principalTable: "Ogunler",
                principalColumn: "OgunID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
