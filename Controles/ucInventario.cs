using GestionDeStock.DBContext;
using GestionDeStock.Formularios;
using GestionDeStock.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static GestionDeStock.Formularios.SeleccionarRegistro;

namespace GestionDeStock.Controles
{
    public partial class ucInventario : UserControl
    {
        DataTable tabla;
        private System.Windows.Forms.Timer timerBusqueda;

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

            grilla.DataSource = tabla;
            foreach (DataGridViewColumn col in grilla.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; 


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
                    actualizarSubcategorias(subcategorias, placeholder, comboBoxCategoria, comboBoxSubcategoria);
                    consultar(textBoxBusqueda.Text);
                };
                comboBoxSubcategoria.SelectedIndexChanged += (s, e) =>
                {
                    consultar(textBoxBusqueda.Text);
                };
            }
        }

        // método de actualización de subcategorías según la categoría seleccionada
        public void actualizarSubcategorias(List<Subcategoria> subcategorias, List<Subcategoria> placeholder, ComboBox comboCate, ComboBox comboSubcate)
        {
            var categoriaId = (int)comboCate.SelectedValue;

            var subcategoriasSeleccionadas = subcategorias
                .Where(s => s.CategoriaId == categoriaId)
                .ToList();

            if (categoriaId == 0)
            {
                comboSubcate.DataSource = placeholder;
                comboSubcate.DisplayMember = "Nombre";
                comboSubcate.ValueMember = "Id";
            }
            else
            {
                subcategoriasSeleccionadas.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Todas las subcategorías"
                });

                comboSubcate.DataSource = subcategoriasSeleccionadas;
                comboSubcate.DisplayMember = "Nombre";
                comboSubcate.ValueMember = "Id";
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

        //apertura de modal para crear artículo y actualización de registros
        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            var popup = new NuevoArtículo();
            popup.ShowDialog();
            consultar("");
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

        // funiconalidad del botón editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editarCategoria = new EditarCategoria();
            var editarMarca = new EditarMarca();
            var editarUM = new EditarUM();
            var editarArticulo = new EditarArticulo();
            var editarSubcategoria = new EditarSubcategoria();
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font(menu.Font.FontFamily, 11);
            menu.Items.Add("Artículos", null, (s, ev) => { editarArticulo.ShowDialog(); consultar(""); });
            menu.Items.Add("Categorías", null, (s, ev) => { editarCategoria.ShowDialog(); consultar(""); });
            menu.Items.Add("Marcas", null, (s, ev) => { editarMarca.ShowDialog(); consultar(""); });
            menu.Items.Add("Subcategorías", null, (s, ev) => { editarSubcategoria.ShowDialog(); consultar(""); });
            menu.Items.Add("Unidades de medida", null, (s, ev) => { editarUM.ShowDialog(); consultar(""); });

            menu.Show(btnEditar, new Point(0, btnEditar.Height));
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext()) {

                var categorias = context.Categorias.ToList();
                categorias.Insert(0, new Categoria
                {
                    CategoriaId = 0,
                    Nombre = "Seleccione una categoría"

                });

                var marcas = context.Marcas.ToList();
                marcas.Insert(0, new Marca
                {
                    Id = 0,
                    Nombre = "Seleccione una marca"

                });

                var ums = context.UnidadesDeMedida.ToList();
                ums.Insert(0, new UnidadMedida
                {
                    Id = 0,
                    Nombre = "Seleccione una unidad de medida"
                });

                var eliminarCategoria = new Eliminar("Categoría",categorias, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var categoria = (Categoria)entidad;
                        context.Categorias.Remove(categoria);
                        context.SaveChanges();
                    }
                });

                var eliminarMarca = new Eliminar("Marca", marcas, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var marca = (Marca)entidad;
                        context.Marcas.Remove(marca);
                        context.SaveChanges();
                    }
                });

                var eliminarUM = new Eliminar("Unidad de medida", ums, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var um = (UnidadMedida)entidad;
                        context.UnidadesDeMedida.Remove(um);
                        context.SaveChanges();
                    }
                });

                var eliminarArticulo = new EliminarSeleccionar(TipoDeDatos.Articulos, TipoMovimiento.Ingreso);
                var editarSubcategoria = new EditarSubcategoria();
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Font = new Font(menu.Font.FontFamily, 11);
                menu.Items.Add("Artículos", null, (s, ev) => { eliminarArticulo.ShowDialog(); consultar(""); });
                menu.Items.Add("Categorías", null, (s, ev) => { eliminarCategoria.ShowDialog(); consultar(""); });
                menu.Items.Add("Marcas", null, (s, ev) => { eliminarMarca.ShowDialog(); consultar(""); });
                menu.Items.Add("Subcategorías", null, (s, ev) => { editarSubcategoria.ShowDialog(); consultar(""); });
                menu.Items.Add("Unidades de medida", null, (s, ev) => { eliminarUM.ShowDialog(); consultar(""); });

                menu.Show(btnEliminar, new Point(0, btnEliminar.Height));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
            textBoxBusqueda.ForeColor = Color.Gray;
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxSubcategoria.SelectedIndex = 0;
            consultar("");
        }

    }
}
