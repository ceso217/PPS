using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Models
{
    public enum TipoMovimiento
    {
        Ingreso = 0,
        Salida = 1
    }
    public class Movimiento
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string? Notas {  get; set; }
        public int? ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }
        public int? TransportistaId { get; set; }
        public Transportista? Transportista { get; set; }
        public int? DepositoId { get; set; }
        public Deposito? Deposito { get; set; }
        public int ArticuloId {  get; set; }
        public Articulo Articulo { get; set; }
        public TipoMovimiento Tipo { get; set; }
    }
}
