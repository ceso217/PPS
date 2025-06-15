using GestionDeStock.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

            consultar("");

            grilla.DataSource = tabla;
        }

        private void consultar(string filtro)
        {
            tabla.Clear();

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

                // filtro de busqueda
                var articulosFiltrados = string.IsNullOrEmpty(filtro) ? articulos : articulos
                    .Where(a => a.Descripcion.ToLower().Contains(filtro.Trim().ToLower()) ||
                    //a.Modelo.ToLower().Contains(filtro) ||
                    //a.Marca?.Nombre.ToLower().Contains(filtro) == true ||
                    a.Subcategoria?.Nombre.ToLower().Contains(filtro) == true ||
                    a.Subcategoria?.Categoria?.Nombre.ToLower().Contains(filtro) == true ||
                    a.CodigoArticulo.ToString().Contains(filtro));

                foreach (var articulo in articulosFiltrados)
                {
                    tabla.Rows.Add(
                        articulo.Subcategoria.Categoria.Nombre,
                        articulo.Subcategoria.Nombre,
                        articulo.CodigoArticulo,
                        articulo.Descripcion,
                        articulo.MN,
                        articulo.Marca?.Nombre,
                        articulo.Modelo,
                        articulo.UnidadMedida?.Nombre,
                        articulo.Stock);
                }
            }
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoArtículo();
            popup.ShowDialog();
            consultar("");
        }

        private void textBoxBusqueda_Enter(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text == "Buscar por código, descripción, etc.")
            {
                textBoxBusqueda.Text = "";
                textBoxBusqueda.ForeColor = Color.Black;
            }
        }

        private void textBoxBusqueda_Leave(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text.IsNullOrEmpty())
            {
                textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
                textBoxBusqueda.ForeColor = Color.Gray;
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            var filtroBusqueda = textBoxBusqueda.Text;

            if (filtroBusqueda == "Buscar por código, descripción, etc.")
            {
                return;
            }

            consultar(filtroBusqueda);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font(menu.Font.FontFamily, 11);
            menu.Items.Add("Categorías", null, (s, ev) => MessageBox.Show("Elegiste opción 1"));
            menu.Items.Add("Subcategorías", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Artículos", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Marcas", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Unidades de medida", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));


            menu.Show(btnEditar, new Point(0, btnEditar.Height));
        }
    }
}
