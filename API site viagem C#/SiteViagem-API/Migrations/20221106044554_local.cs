using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteViagem_API.Migrations
{
    public partial class local : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inserido",
                table: "Destino",
                newName: "Local");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Local",
                table: "Destino",
                newName: "Inserido");
        }
    }
}
