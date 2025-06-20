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
using static System.Net.Mime.MediaTypeNames;

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

                comboBoxDestino.DataSource = depositos;
                comboBoxDestino.ValueMember = "Id";
                comboBoxDestino.DisplayMember = "Nombre";

                comboBoxTransportista.DataSource = transportistas;
                comboBoxTransportista.ValueMember = "Id";
                comboBoxTransportista.DisplayMember = "Nombre";
            }
        }

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();

            var popup = new FormSeleccionarArticulo();
            var resultados = popup.ShowDialog();

            if (resultados == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var articuloSeleccionado = context.Articulos
                        .Include(a => a.Marca)
                        .Include(a => a.UnidadMedida)
                        .Include(a => a.Subcategoria)
                            .ThenInclude(s => s.Categoria)
                        .Where(a => a.Id == popup.ArticuloSeleccionadoId).ToList();

                    foreach (Articulo a in articuloSeleccionado)
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
                grilla.AllowUserToAddRows = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoDestino_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoDeposito();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var depositos = context.Proveedores.ToList();

                    depositos.Insert(0, new Proveedor
                    {
                        Id = 0,
                        Nombre = "Selecciona un depósito"

                    });
                    comboBoxDestino.DataSource = depositos;
                    comboBoxDestino.ValueMember = "Id";
                    comboBoxDestino.DisplayMember = "Nombre";

                    Deposito nuevo = popup.NuevoDeposito;
                    comboBoxDestino.SelectedIndex = nuevo.Id;
                }
            }
        }

        private void btnNuevoTransp_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoTransportista();
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

                    Transportista nuevo = popup.NuevoTransportista;
                    comboBoxTransportista.SelectedIndex = nuevo.Id;
                }
            }
        }
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoProveedor();
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

                    Proveedor nuevo = popup.NuevoProveedor;
                    comboBoxProveedor.SelectedIndex = nuevo.Id;
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

                Movimiento nuevoIngreso = new Movimiento
                {
                    Fecha = DateTime.Now,
                    Cantidad = (int)numericUpDownCantidad.Value,
                    Notas = textBoxNotas.Text,
                    ProveedorId = (int)comboBoxProveedor.SelectedIndex == 0 ? null : (int)comboBoxProveedor.SelectedValue,
                    TransportistaId = (int)comboBoxTransportista.SelectedIndex == 0 ? null : (int)comboBoxTransportista.SelectedValue,
                    DepositoId = (int)comboBoxDestino.SelectedIndex == 0 ? null : (int)comboBoxDestino.SelectedValue,
                    ArticuloId = articuloSeleccionadoId,
                    Tipo = 0
                };

                using (var context = new StockBDContext())
                {
                    context.Movimientos.Add(nuevoIngreso);
                    context.SaveChanges();
                }
                this.Close();
            }
        }

    }
}
