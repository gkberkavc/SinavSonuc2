using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ders_1",
                table: "Ders_1");

            migrationBuilder.RenameTable(
                name: "Ders_1",
                newName: "Dersler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dersler",
                table: "Dersler",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dersler",
                table: "Dersler");

            migrationBuilder.RenameTable(
                name: "Dersler",
                newName: "Ders_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ders_1",
                table: "Ders_1",
                column: "Id");
        }
    }
}
