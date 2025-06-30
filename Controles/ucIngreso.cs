using GestionDeStock.DBContext;
using GestionDeStock.Formularios;
using GestionDeStock.Models;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using static GestionDeStock.Formularios.SeleccionarRegistro;

namespace GestionDeStock.Controles
{
    public partial class ucIngreso : UserControl
    {
        DataTable tabla;
        private System.Windows.Forms.Timer timerBusqueda;
        public ucIngreso()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
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

            grillaIngreso.DataSource = tabla;
            grillaIngreso.AllowUserToAddRows = false;
            grillaIngreso.ReadOnly = true;
            foreach (DataGridViewColumn col in grillaIngreso.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            timerBusqueda = new System.Windows.Forms.Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;

            using (var context = new StockBDContext())
            {
                var subcategorias = context.Subcategorias.ToList();

                cargarCategorias();

                var placeholder = new List<Subcategoria>();
                placeholder.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Seleccione una categoría"
                });

                comboBoxSubcategoria.DataSource = placeholder;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";

                cargarDepositos();

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
        }

        private void cargarCategorias()
        {
            using (var context = new StockBDContext())
            {
                var categorias = context.Categorias.ToList();

                categorias.Insert(0, new Categoria
                {
                    CategoriaId = 0,
                    Nombre = "Todas las categorías"
                });

                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "CategoriaId";
            }
        }
        private void cargarDepositos()
        {
            using (var context = new StockBDContext())
            {
                var depositos = context.Depositos.ToList();

                depositos.Insert(0, new Deposito
                {
                    Id = 0,
                    Nombre = "Todos los depósitos"
                });

                comboBoxDeposito.DataSource = depositos;
                comboBoxDeposito.DisplayMember = "Nombre";
                comboBoxDeposito.ValueMember = "Id";
            }
        }

        private void consultar(string filtro)
        {
            tabla.Rows.Clear();
            using (var context = new StockBDContext())
            {
                var ingresos = context.Movimientos
                    .Where(i => i.Tipo == Models.TipoMovimiento.Ingreso)
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
                        i.Notas
                    }).ToList();

                var categoriaId = (int)comboBoxCategoria.SelectedValue;
                var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;
                var depositoId = (int)comboBoxDeposito.SelectedValue;

                if (filtro == "Buscar por código, descripción, etc.") { filtro = ""; }

                if (categoriaId != 0)
                {
                    ingresos = ingresos.Where(i => i.Categoria.CategoriaId == categoriaId).ToList();
                    if (subcategoriaId != 0)
                    {
                        ingresos = ingresos.Where(i => i.Subcategoria.Id == subcategoriaId).ToList();
                    }
                }

                if (depositoId != 0)
                {
                    ingresos = ingresos.Where(i => i.Deposito != null && i.Deposito.Id == depositoId).ToList();
                }


                if (!string.IsNullOrEmpty(filtro))
                {
                    ingresos = ingresos.Where(i => i.Descripcion.ToLower().Contains(filtro.ToLower()) || i.CodigoArticulo.ToString().Contains(filtro)).ToList();
                }

                foreach (var i in ingresos)
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
                        i?.Notas
                        );
                }
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            var popup = new NuevoMovimiento(TipoMovimiento.Ingreso);
            popup.ShowDialog();
            consultar("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editarDeposito = new EditarDeposito();
            var editarProveedor = new EditarProveedor();
            var editarTransportista = new EditarTransp();
            var editarIngreso = new EditarMovimiento(TipoMovimiento.Ingreso);

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font(menu.Font.FontFamily, 11);
            menu.Items.Add("Depositos", null, (s, ev) => { editarDeposito.ShowDialog(); consultar(""); cargarDepositos(); });
            menu.Items.Add("Ingresos", null, (s, ev) => { editarIngreso.ShowDialog(); consultar(""); });
            menu.Items.Add("Proveedores", null, (s, ev) => { editarProveedor.ShowDialog(); consultar(""); });
            menu.Items.Add("Transportistas", null, (s, ev) => { editarTransportista.ShowDialog(); consultar(""); });

            menu.Show(btnEditar, new Point(0, btnEditar.Height));
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

        private void grillaIngreso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (grillaIngreso.Columns[e.ColumnIndex].Name == "Descripción" || grillaIngreso.Columns[e.ColumnIndex].Name == "Id")
            {
                var fila = grillaIngreso.Rows[e.RowIndex];
                var id = fila.Cells["Id"].Value?.ToString();

                textBoxBusqueda.ForeColor = Color.Black;
                textBoxBusqueda.Text = id;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {
                var depositos = context.Depositos.ToList();
                depositos.Insert(0, new Deposito
                {
                    Id = 0,
                    Nombre = "Seleccione un depósito"

                });
                var proveedores = context.Proveedores.ToList();
                proveedores.Insert(0, new Proveedor
                {
                    Id = 0,
                    Nombre = "Seleccione una proveedor"

                });
                var trasportistas = context.Transportistas.ToList();
                trasportistas.Insert(0, new Transportista
                {
                    Id = 0,
                    Nombre = "Seleccione un transportista"
                });

                var eliminarDeposito = new Eliminar("Depósito", depositos, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var deposito = (Deposito)entidad;
                        context.Depositos.Remove(deposito);
                        context.SaveChanges();
                    }
                });

                var eliminarProveedor = new Eliminar("Proveedor", proveedores, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var proveedor = (Proveedor)entidad;
                        context.Proveedores.Remove(proveedor);
                        context.SaveChanges();
                    }
                });

                var eliminarTransportista = new Eliminar("Transportista", trasportistas, entidad =>
                {
                    using (var context = new StockBDContext())
                    {
                        var transportista = (Transportista)entidad;
                        context.Transportistas.Remove(transportista);
                        context.SaveChanges();
                    }
                });

                var eliminarIngreso = new EliminarSeleccionar(TipoDeDatos.Movimientos, TipoMovimiento.Ingreso);
                var editarSubcategoria = new EditarSubcategoria();
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Font = new Font(menu.Font.FontFamily, 11);
                menu.Items.Add("Ingreso", null, (s, ev) => { eliminarIngreso.ShowDialog(); consultar(""); });
                menu.Items.Add("Depósito", null, (s, ev) => { eliminarDeposito.ShowDialog(); cargarDepositos(); consultar(""); });
                menu.Items.Add("Proveedor", null, (s, ev) => { eliminarProveedor.ShowDialog(); consultar(""); });
                menu.Items.Add("Transportista", null, (s, ev) => { eliminarTransportista.ShowDialog(); consultar(""); });

                menu.Show(btnEliminar, new Point(0, btnEliminar.Height));
            }
        }
    }
}
