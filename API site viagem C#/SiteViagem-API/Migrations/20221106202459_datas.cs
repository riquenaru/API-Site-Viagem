using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteViagem_API.Migrations
{
    public partial class datas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Local",
                table: "Destino",
                newName: "LocalEmbarque");

            migrationBuilder.AddColumn<string>(
                name: "DataEmbarque",
                table: "Destino",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DataRetorno",
                table: "Destino",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocalDestino",
                table: "Destino",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataEmbarque",
                table: "Destino");

            migrationBuilder.DropColumn(
                name: "DataRetorno",
                table: "Destino");

            migrationBuilder.DropColumn(
                name: "LocalDestino",
                table: "Destino");

            migrationBuilder.RenameColumn(
                name: "LocalEmbarque",
                table: "Destino",
                newName: "Local");
        }
    }
}
