using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdentityFromCategoriaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            // 1. Eliminar la columna Id
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categorias");

            // 2. Crear nueva columna CategoriaId sin IDENTITY
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0); // cuidado si tenés datos previos

            // 3. Definirla como clave primaria
            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            // 4. Volver a crear la relación
            migrationBuilder.AddForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Categorias");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categorias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
