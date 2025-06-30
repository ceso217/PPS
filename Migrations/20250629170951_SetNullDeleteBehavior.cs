using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class SetNullDeleteBehavior : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos",
                column: "UnidadMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos",
                column: "TransportistaId",
                principalTable: "Transportistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos",
                column: "TransportistaId",
                principalTable: "Transportistas",
                principalColumn: "Id");
        }
    }
}
