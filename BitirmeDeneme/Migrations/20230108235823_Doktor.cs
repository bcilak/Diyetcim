using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
namespace BitirmeDeneme.Migrations
{
    public partial class Doktor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isim = table.Column<string>(nullable: true),
                    soyisim = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    sifre = table.Column<string>(nullable: true),
                    cinsiyet = table.Column<string>(nullable: true),
                    unvan = table.Column<string>(nullable: true),
                    aciklama = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "Doktor"); ;
        }
    }
}
