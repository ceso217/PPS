using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class FixNombresTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Marca_MarcaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Subcategorias_SubcategoriaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_UnidadMedida_UnidadMedidaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Articulo_ArticuloId",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Deposito_DepositoId",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Proveedor_ProveedorId",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Transportista_TransportistaId",
                table: "Movimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadMedida",
                table: "UnidadMedida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transportista",
                table: "Transportista");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marca",
                table: "Marca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deposito",
                table: "Deposito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo");

            migrationBuilder.RenameTable(
                name: "UnidadMedida",
                newName: "UnidadesDeMedida");

            migrationBuilder.RenameTable(
                name: "Transportista",
                newName: "Transportistas");

            migrationBuilder.RenameTable(
                name: "Proveedor",
                newName: "Proveedores");

            migrationBuilder.RenameTable(
                name: "Movimiento",
                newName: "Movimientos");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "Marcas");

            migrationBuilder.RenameTable(
                name: "Deposito",
                newName: "Depositos");

            migrationBuilder.RenameTable(
                name: "Articulo",
                newName: "Articulos");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_TransportistaId",
                table: "Movimientos",
                newName: "IX_Movimientos_TransportistaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_ProveedorId",
                table: "Movimientos",
                newName: "IX_Movimientos_ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_DepositoId",
                table: "Movimientos",
                newName: "IX_Movimientos_DepositoId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_ArticuloId",
                table: "Movimientos",
                newName: "IX_Movimientos_ArticuloId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_UnidadMedidaId",
                table: "Articulos",
                newName: "IX_Articulos_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_SubcategoriaId",
                table: "Articulos",
                newName: "IX_Articulos_SubcategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_MarcaId",
                table: "Articulos",
                newName: "IX_Articulos_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadesDeMedida",
                table: "UnidadesDeMedida",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transportistas",
                table: "Transportistas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depositos",
                table: "Depositos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Subcategorias_SubcategoriaId",
                table: "Articulos",
                column: "SubcategoriaId",
                principalTable: "Subcategorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos",
                column: "UnidadMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Articulos_ArticuloId",
                table: "Movimientos",
                column: "ArticuloId",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos",
                column: "TransportistaId",
                principalTable: "Transportistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Marcas_MarcaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Subcategorias_SubcategoriaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesDeMedida_UnidadMedidaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Articulos_ArticuloId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Depositos_DepositoId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Proveedores_ProveedorId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Transportistas_TransportistaId",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadesDeMedida",
                table: "UnidadesDeMedida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transportistas",
                table: "Transportistas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depositos",
                table: "Depositos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos");

            migrationBuilder.RenameTable(
                name: "UnidadesDeMedida",
                newName: "UnidadMedida");

            migrationBuilder.RenameTable(
                name: "Transportistas",
                newName: "Transportista");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedor");

            migrationBuilder.RenameTable(
                name: "Movimientos",
                newName: "Movimiento");

            migrationBuilder.RenameTable(
                name: "Marcas",
                newName: "Marca");

            migrationBuilder.RenameTable(
                name: "Depositos",
                newName: "Deposito");

            migrationBuilder.RenameTable(
                name: "Articulos",
                newName: "Articulo");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_TransportistaId",
                table: "Movimiento",
                newName: "IX_Movimiento_TransportistaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_ProveedorId",
                table: "Movimiento",
                newName: "IX_Movimiento_ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_DepositoId",
                table: "Movimiento",
                newName: "IX_Movimiento_DepositoId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_ArticuloId",
                table: "Movimiento",
                newName: "IX_Movimiento_ArticuloId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_UnidadMedidaId",
                table: "Articulo",
                newName: "IX_Articulo_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_SubcategoriaId",
                table: "Articulo",
                newName: "IX_Articulo_SubcategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_MarcaId",
                table: "Articulo",
                newName: "IX_Articulo_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadMedida",
                table: "UnidadMedida",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transportista",
                table: "Transportista",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marca",
                table: "Marca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deposito",
                table: "Deposito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Marca_MarcaId",
                table: "Articulo",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Subcategorias_SubcategoriaId",
                table: "Articulo",
                column: "SubcategoriaId",
                principalTable: "Subcategorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_UnidadMedida_UnidadMedidaId",
                table: "Articulo",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Articulo_ArticuloId",
                table: "Movimiento",
                column: "ArticuloId",
                principalTable: "Articulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Deposito_DepositoId",
                table: "Movimiento",
                column: "DepositoId",
                principalTable: "Deposito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Proveedor_ProveedorId",
                table: "Movimiento",
                column: "ProveedorId",
                principalTable: "Proveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Transportista_TransportistaId",
                table: "Movimiento",
                column: "TransportistaId",
                principalTable: "Transportista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
