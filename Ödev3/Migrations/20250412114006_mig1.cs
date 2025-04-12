using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ödev3.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Soyad = table.Column<string>(type: "TEXT", nullable: false),
                    DogumTarihi = table.Column<string>(type: "TEXT", nullable: false),
                    Boy = table.Column<int>(type: "INTEGER", nullable: false),
                    Kilo = table.Column<int>(type: "INTEGER", nullable: false),
                    Burc = table.Column<string>(type: "TEXT", nullable: false),
                    BurcYorumu = table.Column<string>(type: "TEXT", nullable: false),
                    VKI = table.Column<double>(type: "REAL", nullable: false),
                    VKI_Yorum = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanici");
        }
    }
}
