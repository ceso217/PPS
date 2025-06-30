using GestionDeStock.DBContext;
using GestionDeStock.Models;
using System.Data;
using static GestionDeStock.Formularios.SeleccionarRegistro;

namespace GestionDeStock.Formularios
{
    public partial class EditarMovimiento : Form
    {
        DataTable tabla;
        DataTable tablaCambio;
        TipoMovimiento tipoMovimiento;
        bool cambioDeArticulo = false;

        public EditarMovimiento(TipoMovimiento tipo)
        {
            InitializeComponent();
            tipoMovimiento = tipo;
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
            tabla.Columns.Add("MovimientoId", typeof(int));

            tablaCambio = new DataTable();
            tablaCambio.Columns.Add("Categoría");
            tablaCambio.Columns.Add("Subcategoría");
            tablaCambio.Columns.Add("Id");
            tablaCambio.Columns.Add("Descripción");
            tablaCambio.Columns.Add("MN");
            tablaCambio.Columns.Add("Marca");
            tablaCambio.Columns.Add("Modelo");
            tablaCambio.Columns.Add("UM");
            tablaCambio.Columns.Add("Stock");
            tablaCambio.Columns.Add("ArticuloId", typeof(int));

            grilla.DataSource = tabla;
            grillaCambio.DataSource = tablaCambio;

            grilla.Columns["MovimientoId"].Visible = false;
            grilla.Height = grilla.ColumnHeadersHeight * 2;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeRows = false;
            grilla.ReadOnly = true;
            grilla.ScrollBars = ScrollBars.None;

            grillaCambio.Columns["ArticuloId"].Visible = false;
            grillaCambio.Height = grilla.ColumnHeadersHeight * 2;
            grillaCambio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaCambio.RowHeadersVisible = false;
            grillaCambio.AllowUserToDeleteRows = false;
            grillaCambio.AllowUserToResizeRows = false;
            grillaCambio.ReadOnly = true;
            grillaCambio.ScrollBars = ScrollBars.None;

            using (var context = new StockBDContext())
            {
                var depositos = context.Depositos.ToList();
                var transportistas = context.Transportistas.ToList();
                var proveedores = context.Proveedores.ToList();

                if (depositos.Count > 0)
                {
                    depositos.Insert(0, new Deposito
                    {
                        Id = 0,
                        Nombre = "Selecciona un depósito"

                    });
                }
                else
                {
                    depositos.Insert(0, new Deposito
                    {
                        Id = 0,
                        Nombre = "No hay ningún depósito creado aún"

                    });
                }

                if (transportistas.Count > 0)
                {
                    transportistas.Insert(0, new Transportista
                    {
                        Id = 0,
                        Nombre = "Selecciona un transportista"

                    });
                }
                else
                {
                    transportistas.Insert(0, new Transportista
                    {
                        Id = 0,
                        Nombre = "No hay ningún transportista creado aún"

                    });
                }

                if (proveedores.Count > 0)
                {
                    proveedores.Insert(0, new Proveedor
                    {
                        Id = 0,
                        Nombre = "Selecciona un proveedor"

                    });
                }
                else
                {
                    proveedores.Insert(0, new Proveedor
                    {
                        Id = 0,
                        Nombre = "No hay ningún proveedor creado aún"

                    });
                }

                comboBoxProveedor.DataSource = proveedores;
                comboBoxProveedor.ValueMember = "Id";
                comboBoxProveedor.DisplayMember = "Nombre";

                comboBoxDeposito.DataSource = depositos;
                comboBoxDeposito.ValueMember = "Id";
                comboBoxDeposito.DisplayMember = "Nombre";

                comboBoxTransportista.DataSource = transportistas;
                comboBoxTransportista.ValueMember = "Id";
                comboBoxTransportista.DisplayMember = "Nombre";

                if (tipoMovimiento == TipoMovimiento.Salida)
                {
                    label1.Text = "Nueva Salida";
                    this.Text = "Nueva Salida";
                }
            }
        }

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            var popup = new SeleccionarRegistro(TipoDeDatos.Movimientos, tipoMovimiento);
            var resultados = popup.ShowDialog();

            if (resultados == DialogResult.OK)
            {
                tabla.Rows.Clear();
                using (var context = new StockBDContext())
                {
                    var aSelected = context.Movimientos
                        .Select(i => new
                        {
                            i.Fecha,
                            CodigoArticulo = i.Articulo.CodigoArticulo,
                            Descripcion = i.Articulo.Descripcion,
                            Marca = i.Articulo.Marca.Nombre,
                            UM = i.Articulo.UnidadMedida.Nombre,
                            i.Cantidad,
                            DepositoNombre = i.Deposito.Nombre,
                            ProveedorNombre = i.Proveedor.Nombre,
                            TransportistaNombre = i.Transportista.Nombre,
                            Categoria = i.Articulo.Subcategoria.Categoria,
                            Subcategoria = i.Articulo.Subcategoria,
                            i.Notas,
                            i.Id
                        })
                        .FirstOrDefault(a => a.Id == popup.idSeleccionado);

                    tabla.Rows.Add(
                    aSelected.Fecha.ToString("dd/MM/yyyy hh:mm tt"),
                    aSelected?.DepositoNombre,
                    aSelected.Categoria.Nombre,
                    aSelected.Subcategoria.Nombre,
                    aSelected.CodigoArticulo,
                    aSelected.Descripcion,
                    aSelected?.Marca,
                    aSelected?.UM,
                    aSelected.Cantidad,
                    aSelected?.ProveedorNombre,
                    aSelected?.TransportistaNombre,
                    aSelected?.Notas,
                    aSelected?.Id
                    );
                    textBoxNotas.Text = aSelected?.Notas;
                    numericUpDownCantidad.Value = aSelected.Cantidad;
                }
                grilla.AllowUserToAddRows = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grilla.AllowUserToAddRows)
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((int)numericUpDownCantidad.Value == 0)
            {
                MessageBox.Show("El campo \"Cantidad\" debe ser mayor a 0.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int movimientoSeleccionadoId = (int)grilla.Rows[0].Cells["MovimientoId"].Value;
                int codigoArticulo = Convert.ToInt32(grilla.Rows[0].Cells["Id"].Value);
                var cantidadAnterior = Convert.ToInt32(grilla.Rows[0].Cells["Cantidad"].Value);
                int nuevaCantidad = (int)numericUpDownCantidad.Value;

                if (tipoMovimiento == TipoMovimiento.Ingreso)
                {
                    using (var context = new StockBDContext())
                    {
                        var movimiento = context.Movimientos.FirstOrDefault(m => m.Id == movimientoSeleccionadoId);
                        var articuloEditado = context.Articulos.FirstOrDefault(a => a.CodigoArticulo == codigoArticulo);

                        if (cambioDeArticulo)
                        {
                            var nuevoArticulo = context.Articulos.FirstOrDefault(m => m.Id == (int)grillaCambio.Rows[0].Cells["ArticuloId"].Value);

                            movimiento.ArticuloId = nuevoArticulo.Id;
                            articuloEditado.Stock -= cantidadAnterior;
                            nuevoArticulo.Stock += nuevaCantidad;
                        }
                        else
                        {
                            articuloEditado.Stock = articuloEditado.Stock - cantidadAnterior + nuevaCantidad;
                        }
                        if (comboBoxProveedor.SelectedIndex != 0)
                        {
                            movimiento.ProveedorId = (int)comboBoxProveedor.SelectedValue;
                        }
                        if (comboBoxDeposito.SelectedIndex != 0)
                        {
                            movimiento.DepositoId = (int)comboBoxDeposito.SelectedValue;
                        }
                        if (comboBoxTransportista.SelectedIndex != 0)
                        {
                            movimiento.TransportistaId = (int)comboBoxTransportista.SelectedValue;
                        }
                        movimiento.Notas = textBoxNotas.Text;
                        movimiento.Cantidad = nuevaCantidad;
                        context.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    using (var context = new StockBDContext())
                    {
                        var movimiento = context.Movimientos.FirstOrDefault(m => m.Id == movimientoSeleccionadoId);
                        var articuloEditado = context.Articulos.FirstOrDefault(a => a.CodigoArticulo == codigoArticulo);

                        // condicional sobre si cambió el artículo de la salida o no
                        if (cambioDeArticulo)
                        {
                            var nuevoArticulo = context.Articulos.FirstOrDefault(m => m.Id == (int)grillaCambio.Rows[0].Cells["ArticuloId"].Value);

                            // si lo hizo comprueba que cantidad de stock que quiere salir sea menor o igual a la cantidad existente del nuevo artículo
                            if (nuevoArticulo.Stock < nuevaCantidad)
                            {
                                MessageBox.Show("La cantidad de stock que quiere salir es mayor a la cantidad de stock existente del articulo.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                // y si lo es, repone el stock del artículo anterior y quita el stock de la salida del nuevo, además de vincular el nuevo artículo con la salida
                                movimiento.ArticuloId = nuevoArticulo.Id;
                                articuloEditado.Stock += cantidadAnterior;
                                nuevoArticulo.Stock -= nuevaCantidad;
                            }
                        }
                        else
                        {
                            // si no modifica el artículo seleccionado comprueba nuevamente que haya stock suficiente y hace la salida
                            if (articuloEditado.Stock + cantidadAnterior < nuevaCantidad)
                            {
                                MessageBox.Show("La cantidad de stock que quiere salir es mayor a la cantidad de stock existente del articulo.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                articuloEditado.Stock += cantidadAnterior - nuevaCantidad;
                            }
                        }
                        // comprueba si hizo modificaciones en los demás campos y si es así aplica dicha edición
                        if (comboBoxProveedor.SelectedIndex != 0)
                        {
                            movimiento.ProveedorId = (int)comboBoxProveedor.SelectedValue;
                        }
                        if (comboBoxDeposito.SelectedIndex != 0)
                        {
                            movimiento.DepositoId = (int)comboBoxDeposito.SelectedValue;
                        }
                        if (comboBoxTransportista.SelectedIndex != 0)
                        {
                            movimiento.TransportistaId = (int)comboBoxTransportista.SelectedValue;
                        }
                        movimiento.Notas = textBoxNotas.Text;
                        movimiento.Cantidad = nuevaCantidad;
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }

        private void btnCambioArticulo_Click(object sender, EventArgs e)
        {
            if (grilla.AllowUserToAddRows)
            {
                MessageBox.Show("Primero debe seleccionar el artículo a editar.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var popup = new SeleccionarRegistro(TipoDeDatos.Articulos, tipoMovimiento);
                var resultados = popup.ShowDialog();

                if (resultados == DialogResult.OK)
                {
                    cambioDeArticulo = true;
                    tablaCambio.Rows.Clear();
                    using (var context = new StockBDContext())
                    {
                        var aSelected = context.Articulos
                            .Select(a => new
                            {
                                CategoriaNombre = a.Subcategoria.Categoria.Nombre,
                                SubcategoriaNombre = a.Subcategoria.Nombre,
                                a.CodigoArticulo,
                                a.Descripcion,
                                a.MN,
                                MarcaNombre = a.Marca.Nombre,
                                UMNombre = a.UnidadMedida.Nombre,
                                a.Modelo,
                                a.Stock,
                                a.Id
                            })
                            .FirstOrDefault(a => a.Id == popup.idSeleccionado);

                        tablaCambio.Rows.Add(
                        aSelected.CategoriaNombre,
                        aSelected.SubcategoriaNombre,
                        aSelected.CodigoArticulo,
                        aSelected.Descripcion,
                        aSelected?.MN,
                        aSelected?.MarcaNombre,
                        aSelected?.Modelo,
                        aSelected?.UMNombre,
                        aSelected.Stock,
                        aSelected.Id);
                    }
                    grillaCambio.AllowUserToAddRows = false;
                }
            }
        }
    }
}
