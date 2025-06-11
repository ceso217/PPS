using GestionDeStock.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeStock.Controles
{
    public partial class ucInventario : UserControl
    {
        DataTable tabla;
        public ucInventario()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Categoría");
            tabla.Columns.Add("Subcategoría");
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripción");
            tabla.Columns.Add("MN");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("UM");
            tabla.Columns.Add("Stock");


            using (var context = new StockBDContext())
            {
                var articulos = context.Articulos
                    .Include(a => a.Marca)
                    .Include(a => a.UnidadMedida)
                    .Include(a => a.Subcategoria)
                        .ThenInclude(s => s.Categoria)
                    .OrderBy(a => a.CategoriaId)
                    .ThenBy(a => a.CodigoSubcategoria)
                    .ThenBy(a => a.CodigoArticulo)
                        .ToList();

                foreach (var articulo in articulos)
                {
                    tabla.Rows.Add(
                        articulo.Subcategoria.Categoria.Nombre,
                        articulo.Subcategoria.Nombre,
                        (articulo.CategoriaId + "" + articulo.CodigoSubcategoria + "" + articulo.CodigoArticulo),
                        articulo.Descripcion,
                        articulo.MN,
                        articulo.Marca?.Nombre,
                        articulo.Modelo,
                        articulo.UnidadMedida?.Nombre,
                        articulo.Stock);
                }
            }

            grilla.DataSource = tabla;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoArtículo();
            popup.ShowDialog();
        }
    }
}
