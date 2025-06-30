using GestionDeStock.DBContext;
using GestionDeStock.Models;
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

namespace GestionDeStock.Formularios
{
    public partial class EliminarSeleccionar : Form
    {
        TipoDeDatos tipoD;
        TipoMovimiento tipoM;
        DataTable tabla;
        Articulo aSeleccionado;
        Movimiento mSeleccionado;
        public EliminarSeleccionar(TipoDeDatos tipoDeDatos, TipoMovimiento tipoMovimiento)
        {
            InitializeComponent();
            tipoD = tipoDeDatos;
            Iniciar();

            if (tipoDeDatos == TipoDeDatos.Articulos)
            {
                labelTitulo.Text = "Eliminar artículo";
                this.Text = labelTitulo.Text;
                btnSeleccionar.Text = "Seleccionar artículo";
                labelElemento.Text = "Artículo:";
            }
            else
            {
                if (tipoMovimiento == TipoMovimiento.Ingreso)
                {
                    labelTitulo.Text = "Eliminar ingreso";
                    this.Text = labelTitulo.Text;
                    btnSeleccionar.Text = "Seleccionar ingreso";
                    labelElemento.Text = "Ingreso:";
                }
                else
                {
                    labelTitulo.Text = "Eliminar salida";
                    this.Text = labelTitulo.Text;
                    btnSeleccionar.Text = "Seleccionar salida";
                    labelElemento.Text = "Salida:";
                }
            }
        }

        private void Iniciar()
        {
            if (tipoD == TipoDeDatos.Articulos)
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
            }
            else
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

            grilla.Height = grilla.ColumnHeadersHeight * 2;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeRows = false;
            grilla.ReadOnly = true;
            grilla.ScrollBars = ScrollBars.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var popup = new SeleccionarRegistro(tipoD, tipoM);
            var resultados = popup.ShowDialog();

            if (resultados == DialogResult.OK)
            {
                tabla.Rows.Clear();
                using (var context = new StockBDContext())
                {
                    if (tipoD == TipoDeDatos.Articulos)
                    {
                        aSeleccionado = context.Articulos.FirstOrDefault(a => a.Id == popup.idSeleccionado);
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
                    else
                    {
                        mSeleccionado = context.Movimientos.FirstOrDefault(a => a.Id == popup.idSeleccionado);
                        var mSelected = context.Movimientos
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
                        mSelected.Fecha.ToString("dd/MM/yyyy hh:mm tt"),
                        mSelected?.DepositoNombre,
                        mSelected.Categoria.Nombre,
                        mSelected.Subcategoria.Nombre,
                        mSelected.CodigoArticulo,
                        mSelected.Descripcion,
                        mSelected?.Marca,
                        mSelected?.UM,
                        mSelected.Cantidad,
                        mSelected?.ProveedorNombre,
                        mSelected?.TransportistaNombre,
                        mSelected?.Notas,
                        mSelected?.Id
                        );
                    }
                    grilla.AllowUserToAddRows = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {
                if (tipoD == TipoDeDatos.Articulos)
                {
                    context.Articulos.Remove(aSeleccionado);
                }
                else
                {
                    //if(tipoM == TipoMovimiento.Ingreso)
                    //{
                    //    var articulo = context.Movimientos.FirstOrDefault(a => a.Id == mSeleccionado.ArticuloId);

                    //        var nuevoArticulo = context.Articulos.FirstOrDefault(m => m.Id == (int)grilla.Rows[0].Cells["ArticuloId"].Value);

                    //        articuloEditado.Stock -= cantidadAnterior;
                    //        nuevoArticulo.Stock += nuevaCantidad;
                    //    else
                    //    {
                    //        articuloEditado.Stock = articuloEditado.Stock - cantidadAnterior + nuevaCantidad;
                    //    }
                    //    if (comboBoxProveedor.SelectedIndex != 0)
                    //    {
                    //        movimiento.ProveedorId = (int)comboBoxProveedor.SelectedValue;
                    //    }
                    //    if (comboBoxDeposito.SelectedIndex != 0)
                    //    {
                    //        movimiento.DepositoId = (int)comboBoxDeposito.SelectedValue;
                    //    }
                    //    if (comboBoxTransportista.SelectedIndex != 0)
                    //    {
                    //        movimiento.TransportistaId = (int)comboBoxTransportista.SelectedValue;
                    //    }
                    //    movimiento.Notas = textBoxNotas.Text;
                    //    movimiento.Cantidad = nuevaCantidad;
                    //    context.SaveChanges();
                    //    this.Close();
                    //}
                    //context.Movimientos.Remove(mSeleccionado);
                }
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
