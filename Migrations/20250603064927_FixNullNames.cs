using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class FixNullNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadMedidaId",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MN",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos",
                column: "UnidadMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadMedidaId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MN",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos",
                column: "UnidadMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
