using GestionDeStock.DBContext;
using GestionDeStock.Models;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace GestionDeStock.Controles
{
    public partial class ucMovimientos : UserControl
    {
        DataTable tabla;
        private System.Windows.Forms.Timer timerBusqueda;
        public ucMovimientos()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Tipo");
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

            grillaMovimientos.DataSource = tabla;
            grillaMovimientos.AllowUserToAddRows = false;
            grillaMovimientos.ReadOnly = true;

            foreach (DataGridViewColumn col in grillaMovimientos.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            timerBusqueda = new System.Windows.Forms.Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;

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
                    Nombre = "Seleccione una categoría"
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

                consultar("");
            }

            grillaMovimientos.CellFormatting += (s, e) =>
            {
                if ((string)grillaMovimientos.Rows[e.RowIndex].Cells["Tipo"].Value == "Ingreso")
                {
                    grillaMovimientos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                else
                {
                    grillaMovimientos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
            };
        }

        private void consultar(string filtro)
        {
            tabla.Rows.Clear();
            using (var context = new StockBDContext())
            {
                var movimientos = context.Movimientos
                    .Select(m => new
                    {
                        m.Tipo,
                        m.Fecha,
                        CodigoArticulo = m.Articulo.CodigoArticulo,
                        Descripcion = m.Articulo.Descripcion,
                        Marca = m.Articulo.Marca.Nombre,
                        UM = m.Articulo.UnidadMedida.Nombre,
                        m.Cantidad,
                        Deposito = m.Deposito,
                        Proveedor = m.Proveedor.Nombre,
                        Transportista = m.Transportista.Nombre,
                        Categoria = m.Articulo.Subcategoria.Categoria,
                        Subcategoria = m.Articulo.Subcategoria,
                        m.Notas
                    }).ToList();

                var categoriaId = (int)comboBoxCategoria.SelectedValue;
                var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;
                var depositoId = (int)comboBoxDeposito.SelectedValue;

                if (filtro == "Buscar por código, descripción, etc.") { filtro = ""; }

                if (categoriaId != 0)
                {
                    movimientos = movimientos.Where(m => m.Categoria.CategoriaId == categoriaId).ToList();
                    if (subcategoriaId != 0)
                    {
                        movimientos = movimientos.Where(m => m.Subcategoria.Id == subcategoriaId).ToList();
                    }
                }

                if (depositoId != 0)
                {
                    movimientos = movimientos.Where(m => m.Deposito != null && m.Deposito.Id == depositoId).ToList();
                }


                if (!string.IsNullOrEmpty(filtro))
                {
                    movimientos = movimientos.Where(m => m.Descripcion.ToLower().Contains(filtro.ToLower()) || m.CodigoArticulo.ToString().Contains(filtro)).ToList();
                }

                foreach (var m in movimientos)
                {
                    tabla.Rows.Add(
                        m.Tipo == TipoMovimiento.Ingreso ? "Ingreso" : "Salida",
                        m.Fecha.ToString("dd/MM/yyyy hh:mm tt"),
                        m?.Deposito?.Nombre,
                        m.Categoria.Nombre,
                        m.Subcategoria.Nombre,
                        m.CodigoArticulo,
                        m.Descripcion,
                        m?.Marca,
                        m?.UM,
                        m.Cantidad,
                        m?.Proveedor,
                        m?.Transportista,
                        m.Notas
                        );
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

        private void grillaMovimientos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (grillaMovimientos.Columns[e.ColumnIndex].Name == "Descripción" || grillaMovimientos.Columns[e.ColumnIndex].Name == "Id")
            {
                var fila = grillaMovimientos.Rows[e.RowIndex];
                var id = fila.Cells["Id"].Value?.ToString();

                textBoxBusqueda.ForeColor = Color.Black;
                textBoxBusqueda.Text = id;
            }
        }
    }
}