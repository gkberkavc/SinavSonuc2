using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlar_Ogrenciler_OgrenciId",
                table: "Notlar");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "OgretimUyeleri");

            migrationBuilder.RenameColumn(
                name: "OgrenciId",
                table: "Notlar",
                newName: "KullanıcıId");

            migrationBuilder.RenameIndex(
                name: "IX_Notlar_OgrenciId",
                table: "Notlar",
                newName: "IX_Notlar_KullanıcıId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlar_Kullanıcılar_KullanıcıId",
                table: "Notlar",
                column: "KullanıcıId",
                principalTable: "Kullanıcılar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlar_Kullanıcılar_KullanıcıId",
                table: "Notlar");

            migrationBuilder.RenameColumn(
                name: "KullanıcıId",
                table: "Notlar",
                newName: "OgrenciId");

            migrationBuilder.RenameIndex(
                name: "IX_Notlar_KullanıcıId",
                table: "Notlar",
                newName: "IX_Notlar_OgrenciId");

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciNo = table.Column<int>(type: "int", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgretimUyeleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimUyeleri", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Notlar_Ogrenciler_OgrenciId",
                table: "Notlar",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
