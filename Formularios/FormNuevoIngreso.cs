using GestionDeStock.DBContext;
using GestionDeStock.Models;
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

namespace GestionDeStock.Formularios
{
    public partial class FormNuevoIngreso : Form
    {
        DataTable tabla;
        public FormNuevoIngreso()
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
            tabla.Columns.Add("ArticuloId", typeof(int));

            grilla.DataSource = tabla;
        }

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            var popup = new FormSeleccionarArticulo();
            var resultados = popup.ShowDialog();

            if(resultados== DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var articuloSeleccionado = context.Articulos
                        .Include(a => a.Marca)
                        .Include(a => a.UnidadMedida)
                        .Include(a => a.Subcategoria)
                            .ThenInclude(s => s.Categoria)
                        .Where(a => a.Id == popup.ArticuloSeleccionadoId).ToList();

                    foreach(Articulo a in articuloSeleccionado)
                    {
                        tabla.Rows.Add(
                        a.Subcategoria.Categoria.Nombre,
                        a.Subcategoria.Nombre,
                        a.CodigoArticulo,
                        a.Descripcion,
                        a.MN,
                        a.Marca?.Nombre,
                        a.Modelo,
                        a.UnidadMedida?.Nombre,
                        a.Stock,
                        a.Id);
                    }
                    
                }
            }
        }
    }
}
