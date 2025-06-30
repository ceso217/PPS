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
using static GestionDeStock.Formularios.SeleccionarRegistro;
using static System.Net.Mime.MediaTypeNames;

namespace GestionDeStock.Formularios
{
    public partial class NuevoMovimiento : Form
    {
        DataTable tabla;
        TipoMovimiento tipoMovimiento;
        public NuevoMovimiento(TipoMovimiento tipo)
        {
            InitializeComponent();
            tipoMovimiento = tipo;
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
            grilla.Columns["ArticuloId"].Visible = false;
            grilla.Height = grilla.ColumnHeadersHeight * 2;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeRows = false;
            grilla.ReadOnly = true;
            grilla.ScrollBars = ScrollBars.None;

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
            var popup = new SeleccionarRegistro(TipoDeDatos.Articulos, tipoMovimiento);
            var resultados = popup.ShowDialog();

            if (resultados == DialogResult.OK)
            {
                tabla.Rows.Clear();
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

                    tabla.Rows.Add(
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
                grilla.AllowUserToAddRows = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoDestino_Click(object sender, EventArgs e)
        {
            var popup = new NuevoDeposito();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var depositos = context.Depositos.ToList();

                    depositos.Insert(0, new Deposito
                    {
                        Id = 0,
                        Nombre = "Selecciona un depósito"

                    });
                    comboBoxDeposito.DataSource = depositos;
                    comboBoxDeposito.ValueMember = "Id";
                    comboBoxDeposito.DisplayMember = "Nombre";

                    Deposito nuevo = popup.DepositoCreado;
                    comboBoxDeposito.SelectedValue = nuevo.Id;
                }
            }
        }

        private void btnNuevoTransp_Click(object sender, EventArgs e)
        {
            var popup = new NuevoTransportista();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var transportistas = context.Transportistas.ToList();

                    transportistas.Insert(0, new Transportista
                    {
                        Id = 0,
                        Nombre = "Seleccione un transportista"

                    });
                    comboBoxTransportista.DataSource = transportistas;

                    Transportista nuevo = popup.TransportistaCreado;
                    comboBoxTransportista.SelectedValue = nuevo.Id;
                }
            }
        }
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            var popup = new NuevoProveedor();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var proveedores = context.Proveedores.ToList();

                    proveedores.Insert(0, new Proveedor
                    {
                        Id = 0,
                        Nombre = "Seleccione un proveedor"

                    });
                    comboBoxProveedor.DataSource = proveedores;
                    comboBoxProveedor.ValueMember = "Id";
                    comboBoxProveedor.DisplayMember = "Nombre";

                    Proveedor nuevo = popup.ProveedorCreado;
                    comboBoxProveedor.SelectedValue = nuevo.Id;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (grilla.AllowUserToAddRows)
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if((int)numericUpDownCantidad.Value == 0)
            {
                MessageBox.Show("El campo \"Cantidad\" debe ser mayor a 0.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                int articuloSeleccionadoId = (int)grilla.Rows[0].Cells["ArticuloId"].Value;
                int cantidad = (int)numericUpDownCantidad.Value;

                Movimiento nuevoIngreso = new Movimiento
                {
                    Fecha = DateTime.Now,
                    Cantidad = cantidad,
                    Notas = textBoxNotas.Text,
                    ProveedorId = (int)comboBoxProveedor.SelectedIndex == 0 ? null : (int)comboBoxProveedor.SelectedValue,
                    TransportistaId = (int)comboBoxTransportista.SelectedIndex == 0 ? null : (int)comboBoxTransportista.SelectedValue,
                    DepositoId = (int)comboBoxDeposito.SelectedIndex == 0 ? null : (int)comboBoxDeposito.SelectedValue,
                    ArticuloId = articuloSeleccionadoId,
                    Tipo = tipoMovimiento
                };

                if (tipoMovimiento == TipoMovimiento.Salida)
                {
                    using (var context = new StockBDContext())
                    {
                        var articulo = context.Articulos.FirstOrDefault(a => a.Id == articuloSeleccionadoId);
                        if (articulo.Stock < cantidad)
                        {
                            MessageBox.Show("La cantidad de stock que quiere salir es mayor a la cantidad de stock existente del articulo.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            articulo.Stock = articulo.Stock - cantidad;
                            context.Movimientos.Add(nuevoIngreso);
                            context.SaveChanges();
                            this.Close();
                        }
                    }
                }
                else
                {
                    using (var context = new StockBDContext())
                    {
                        context.Movimientos.Add(nuevoIngreso);
                        var articulo = context.Articulos.FirstOrDefault(a => a.Id == articuloSeleccionadoId);
                        articulo.Stock = articulo.Stock + cantidad;
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
    }
}
