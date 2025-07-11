using GestionDeStock.Controles;
using GestionDeStock.DBContext;
using GestionDeStock.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace GestionDeStock.Formularios
{
    public partial class SeleccionarRegistro : Form
    {
        public enum TipoDeDatos
        {
            Articulos = 0,
            Movimientos = 1
        }

        DataTable tabla;
        private System.Windows.Forms.Timer timerBusqueda;
        public int idSeleccionado { get; private set; }
        TipoDeDatos datos;
        TipoMovimiento tipo;

        public SeleccionarRegistro( TipoDeDatos funcion_, TipoMovimiento datos_)
        {
            InitializeComponent();
            datos = funcion_;
            tipo = datos_;
            Iniciar();
        }

        private void Iniciar()
        {
            if(datos == TipoDeDatos.Articulos)
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
                grilla.Columns["ArticuloId"].Visible = false;
            } else
            {
                tabla = new DataTable();
                tabla.Columns.Add("Fecha");
                tabla.Columns.Add("Depósito");
                tabla.Columns.Add("Categoría");
                tabla.Columns.Add("Subcategoría");
                tabla.Columns.Add("Id");
                tabla.Columns.Add("Descripción");
                tabla.Columns.Add("Marca");
                tabla.Columns.Add("UM");
                tabla.Columns.Add("Cantidad");
                tabla.Columns.Add("Proveedor");
                tabla.Columns.Add("Transportista");
                tabla.Columns.Add("Notas");
                tabla.Columns.Add("MovimientoId", typeof(int));

                grilla.DataSource = tabla;
                grilla.Columns["MovimientoId"].Visible = false;
            }

            timerBusqueda = new System.Windows.Forms.Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;
            grilla.AllowUserToAddRows = false;
            foreach (DataGridViewColumn col in grilla.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            using (var context = new StockBDContext())
            {
                var categorias = context.Categorias.ToList();
                var subcategorias = context.Subcategorias.ToList();
                var depositos = context.Depositos.ToList();

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

                depositos.Insert(0, new Deposito
                {
                    Id = 0,
                    Nombre = "Todos los depósitos"
                });

                comboBoxDeposito.DataSource = depositos;
                comboBoxDeposito.DisplayMember = "Nombre";
                comboBoxDeposito.ValueMember = "Id";

                consultar("");

                var controlInv = new ucInventario();

                // invocación del método de actualización de subcategorías según la categoría seleccionada
                comboBoxCategoria.SelectedIndexChanged += (s, e) =>
                {
                    controlInv.actualizarSubcategorias(subcategorias, placeholder, comboBoxCategoria, comboBoxSubcategoria);
                    consultar(textBoxBusqueda.Text);
                };
                comboBoxSubcategoria.SelectedIndexChanged += (s, e) =>
                {
                    consultar(textBoxBusqueda.Text);
                };
                comboBoxDeposito.SelectedIndexChanged += (s, e) =>
                {
                    consultar(textBoxBusqueda.Text);
                };
            }
        }

        // método para obtener registros
        private void consultar(string filtro)
        {
            tabla.Clear();

            using (var context = new StockBDContext())
            {
                if (datos == TipoDeDatos.Articulos)
                {
                    comboBoxDeposito.Enabled = false;
                    comboBoxDeposito.Visible = false;
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
                            articulo.Stock,
                            articulo.Id);
                    }
                }
                else
                {
                    //comboBoxDeposito.Location = new Point(548, 7);
                    //textBoxBusqueda.Location = new Point(762, 7);
                    //btnLimpiar.Location = new Point(1035, 6);

                    var tipoMovimiento = tipo == TipoMovimiento.Ingreso ? TipoMovimiento.Ingreso : TipoMovimiento.Salida;

                    var movimientos = context.Movimientos
                        .Where(i => i.Tipo == tipoMovimiento)
                        .Select(i => new
                        {
                            i.Fecha,
                            CodigoArticulo = i.Articulo.CodigoArticulo,
                            Descripcion = i.Articulo.Descripcion,
                            Marca = i.Articulo.Marca.Nombre,
                            UM = i.Articulo.UnidadMedida.Nombre,
                            i.Cantidad,
                            Deposito = i.Deposito,
                            Proveedor = i.Proveedor.Nombre,
                            Transportista = i.Transportista.Nombre,
                            Categoria = i.Articulo.Subcategoria.Categoria,
                            Subcategoria = i.Articulo.Subcategoria,
                            i.Notas,
                            i.Id
                        }).ToList();

                    var categoriaId = (int)comboBoxCategoria.SelectedValue;
                    var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;
                    var depositoId = (int)comboBoxDeposito.SelectedValue;

                    if (filtro == "Buscar por código, descripción, etc.") { filtro = ""; }

                    if (categoriaId != 0)
                    {
                        movimientos = movimientos.Where(i => i.Categoria.CategoriaId == categoriaId).ToList();
                        if (subcategoriaId != 0)
                        {
                            movimientos = movimientos.Where(i => i.Subcategoria.Id == subcategoriaId).ToList();
                        }
                    }

                    if (depositoId != 0)
                    {
                        movimientos = movimientos.Where(i => i.Deposito != null && i.Deposito.Id == depositoId).ToList();
                    }


                    if (!string.IsNullOrEmpty(filtro))
                    {
                        movimientos = movimientos.Where(i => i.Descripcion.ToLower().Contains(filtro.ToLower()) || i.CodigoArticulo.ToString().Contains(filtro)).ToList();
                    }

                    foreach (var i in movimientos)
                    {
                        tabla.Rows.Add(
                            i.Fecha.ToString("dd/MM/yyyy hh:mm tt"),
                            i?.Deposito?.Nombre,
                            i.Categoria.Nombre,
                            i.Subcategoria.Nombre,
                            i.CodigoArticulo,
                            i.Descripcion,
                            i?.Marca,
                            i?.UM,
                            i.Cantidad,
                            i?.Proveedor,
                            i?.Transportista,
                            i?.Notas,
                            i.Id
                            );
                    }
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
            comboBoxDeposito.SelectedIndex = 0;
            consultar("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (datos == TipoDeDatos.Articulos)
            {
                idSeleccionado = (int)grilla.CurrentRow.Cells["ArticuloId"].Value;
            }
            else
            {
                idSeleccionado = (int)grilla.CurrentRow.Cells["MovimientoId"].Value;
            }
        }
    }
}
