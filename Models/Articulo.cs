using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Models
{
    public class Articulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SubcategoriaId { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public int CategoriaId { get; set; }
        public  int CodigoSubcategoria { get; set; }
        public int CodigoArticulo { get; set; }
        public string Descripcion { get;set; }
        public string? MN { get; set; } = null;
        public string? Modelo { get; set; } = null;
        public int Stock {  get; set; }
        public int? MarcaId { get; set; } = null;
        public Marca Marca { get; set; }
        public int? UnidadMedidaId { get; set; } = null;
        public UnidadMedida UnidadMedida { get; set; }
        public ICollection<Movimiento> Ingresos { get; set; }
    }
}