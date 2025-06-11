using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Migrations
{
    /// <inheritdoc />
    public partial class ModMovimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingreso");

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    TransportistaId = table.Column<int>(type: "int", nullable: false),
                    DepositoId = table.Column<int>(type: "int", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimiento_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimiento_Deposito_DepositoId",
                        column: x => x.DepositoId,
                        principalTable: "Deposito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimiento_Proveedor_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimiento_Transportista_TransportistaId",
                        column: x => x.TransportistaId,
                        principalTable: "Transportista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_ArticuloId",
                table: "Movimiento",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_DepositoId",
                table: "Movimiento",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_ProveedorId",
                table: "Movimiento",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_TransportistaId",
                table: "Movimiento",
                column: "TransportistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.CreateTable(
                name: "Ingreso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    DepositoId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    TransportistaId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingreso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingreso_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingreso_Deposito_DepositoId",
                        column: x => x.DepositoId,
                        principalTable: "Deposito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingreso_Proveedor_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingreso_Transportista_TransportistaId",
                        column: x => x.TransportistaId,
                        principalTable: "Transportista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_ArticuloId",
                table: "Ingreso",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_DepositoId",
                table: "Ingreso",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_ProveedorId",
                table: "Ingreso",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_TransportistaId",
                table: "Ingreso",
                column: "TransportistaId");
        }
    }
}
