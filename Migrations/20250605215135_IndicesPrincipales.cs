using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class IndicesPrincipales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodigoSubcategoria",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CategoriaId_CodigoSubcategoria_CodigoArticulo",
                table: "Articulos",
                columns: new[] { "CategoriaId", "CodigoSubcategoria", "CodigoArticulo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Articulos_CategoriaId_CodigoSubcategoria_CodigoArticulo",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CodigoSubcategoria",
                table: "Articulos");
        }
    }
}
