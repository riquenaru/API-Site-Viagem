using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteViagem_API.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destino",
                columns: table => new
                {
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inserido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuantPass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destino", x => x.DestinoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destino");
        }
    }
}
