using GestionDeStock.DBContext;
using GestionDeStock.Models;
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

namespace GestionDeStock.Formularios
{
    public partial class FormSeleccionarArticulo : Form
    {
        DataTable tabla;
        private System.Windows.Forms.Timer timerBusqueda;

        public FormSeleccionarArticulo()
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

            grilla.DataSource = tabla;

            timerBusqueda = new System.Windows.Forms.Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;

            using (var context = new StockBDContext())
            {
                var categorias = context.Categorias.ToList();
                var subcategorias = context.Subcategorias.ToList();

                categorias.Insert(0, new Categoria
                {
                    CategoriaId = 0,
                    Nombre = "Todas las categorías"
                });

                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "CategoriaId";

                var placeholder = new List<Subcategoria>();
                placeholder.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Primero seleccione una categoría"
                });

                comboBoxSubcategoria.DataSource = placeholder;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";

                consultar("");

                // invocación del método de actualización de subcategorías según la categoría seleccionada
                comboBoxCategoria.SelectedIndexChanged += (s, e) =>
                {
                    actualizarSubcategorias(subcategorias, placeholder);
                    consultar(textBoxBusqueda.Text);
                };
                comboBoxSubcategoria.SelectedIndexChanged += (s, e) =>
                {
                    consultar(textBoxBusqueda.Text);
                };
            }
        }

        // método de actualización de subcategorías según la categoría seleccionada
        private void actualizarSubcategorias(List<Subcategoria> subcategorias, List<Subcategoria> placeholder)
        {
            var categoriaId = (int)comboBoxCategoria.SelectedValue;

            var subcategoriasSeleccionadas = subcategorias
                .Where(s => s.CategoriaId == categoriaId)
                .ToList();

            if (categoriaId == 0)
            {
                comboBoxSubcategoria.DataSource = placeholder;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";
            }
            else
            {
                subcategoriasSeleccionadas.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Todas las subcategorías"
                });

                comboBoxSubcategoria.DataSource = subcategoriasSeleccionadas;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";
            }
        }

        // método para obtener registros
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

                var categoriaId = (int)comboBoxCategoria.SelectedValue;
                var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;

                if (filtro == "Buscar por código, descripción, etc.")
                {
                    filtro = "";
                }

                // filtro de busqueda
                if (categoriaId != 0)
                {
                    articulos = articulos.Where(a => a.CategoriaId == categoriaId).ToList();
                    if (subcategoriaId != 0)
                    {
                        articulos = articulos.Where(a => a.SubcategoriaId == subcategoriaId).ToList();
                    }
                }
                if (!string.IsNullOrEmpty(filtro))
                {
                    articulos = articulos.Where(a => a.Descripcion.ToLower().Contains(filtro.ToLower()) ||
                    a.CodigoArticulo.ToString().Contains(filtro)).ToList();
                }

                foreach (var articulo in articulos)
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

        //método para borrar el placeholder al hacer click en el textbox
        private void textBoxBusqueda_Enter(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text == "Buscar por código, descripción, etc.")
            {
                textBoxBusqueda.Text = "";
                textBoxBusqueda.ForeColor = Color.Black;
            }
        }

        //método para colocar el placeholder al salir del textbox si este esta vacio
        private void textBoxBusqueda_Leave(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text.IsNullOrEmpty())
            {
                textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
                textBoxBusqueda.ForeColor = Color.Gray;
            }
        }

        //reinicia el timer que provoca el filtro por busqueda cada vez que se escribe en el textbox
        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            timerBusqueda.Start();
        }

        //evento del timer que filtra cuando se busca algo por el textbox
        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            timerBusqueda.Stop();

            var filtroBusqueda = textBoxBusqueda.Text;

            if (filtroBusqueda == "Buscar por código, descripción, etc.")
            {
                return;
            }

            consultar(filtroBusqueda);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
            textBoxBusqueda.ForeColor = Color.Gray;
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxSubcategoria.SelectedIndex = 0;
            consultar("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
