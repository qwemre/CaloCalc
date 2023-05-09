using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class vol3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yiyecekler_Kategori_KategoriID",
                table: "Yiyecekler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "Kategoriler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler",
                column: "KategoriID");

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "YiyecekID",
                keyValue: 1,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Yiyecekler_Kategoriler_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID",
                principalTable: "Kategoriler",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yiyecekler_Kategoriler_KategoriID",
                table: "Yiyecekler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler");

            migrationBuilder.RenameTable(
                name: "Kategoriler",
                newName: "Kategori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "KategoriID");

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "YiyecekID",
                keyValue: 1,
                column: "Porsiyon",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Yiyecekler_Kategori_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
