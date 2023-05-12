using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yasi = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<int>(type: "int", nullable: false),
                    YemekYemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PorsiyonAdet = table.Column<double>(type: "float", nullable: false),
                    ToplamKalori = table.Column<double>(type: "float", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunID);
                    table.ForeignKey(
                        name: "FK_Ogunler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YiyecekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Toplam = table.Column<int>(type: "int", nullable: true),
                    Fotograf = table.Column<byte[]>(type: "image", nullable: true),
                    FotografYolu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OgunID = table.Column<int>(type: "int", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.YiyecekID);
                    table.ForeignKey(
                        name: "FK_Yiyecekler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yiyecekler_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunID");
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi", "YiyecekID" },
                values: new object[,]
                {
                    { 1, "Ana Yemekler", 0 },
                    { 2, "Çorbalar", 0 },
                    { 3, "Salatalar", 0 },
                    { 4, "Tatlılar", 0 },
                    { 5, "İçecekler", 0 },
                    { 6, "Meyveler", 0 },
                    { 7, "Abur Cubur", 0 },
                    { 8, "Kahvaltılık", 0 },
                    { 9, "Sebzeler", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciID",
                table: "Ogunler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Yiyecekler_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yiyecekler_OgunID",
                table: "Yiyecekler",
                column: "OgunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
