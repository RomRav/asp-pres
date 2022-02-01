using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monpetittuto.Migrations
{
    public partial class AddShopToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}

//1. Crée le model ext : Article.cs
//2. Ajouter la table au fichier DbConnect.cs
//3. Lancer la console : add-migration 'nomDeLaMigration'
//3bis. Verif que mon fichier migration n'est pas vide.
//4. update-database
