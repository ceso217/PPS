using GestionDeStock.DBContext;
using GestionDeStock.Formularios;
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

namespace GestionDeStock.Controles
{
    public partial class ucSalida : UserControl
    {
        DataTable tabla;
        public ucSalida()
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

            grillaSalida.DataSource = tabla;
            grillaSalida.AllowUserToAddRows = false;
            grillaSalida.ReadOnly = true;

            consultar();
        }

        private void consultar()
        {
            tabla.Rows.Clear();
            using (var context = new StockBDContext())
            {
                var salidas = context.Movimientos
                    .Where(s => s.Tipo == Models.TipoMovimiento.Salida)
                    .Select(s => new
                    {
                        s.Fecha,
                        CodigoArticulo = s.Articulo.CodigoArticulo,
                        Descripcion = s.Articulo.Descripcion,
                        Marca = s.Articulo.Marca.Nombre,
                        UM = s.Articulo.UnidadMedida.Nombre,
                        s.Cantidad,
                        Deposito = s.Deposito.Nombre,
                        Proveedor = s.Proveedor.Nombre,
                        Transportista = s.Transportista.Nombre,
                        Categoria = s.Articulo.Subcategoria.Categoria.Nombre,
                        Subcategoria = s.Articulo.Subcategoria.Nombre,
                        s.Notas
                    }).ToList();

                foreach (var s in salidas)
                {
                    tabla.Rows.Add(
                        s.Fecha.ToString("dd/MM/yyyy hh:mm tt"),
                        s.Deposito,
                        s.Categoria,
                        s.Subcategoria,
                        s.CodigoArticulo,
                        s.Descripcion,
                        s.Marca,
                        s.UM,
                        s.Cantidad,
                        s.Proveedor,
                        s.Transportista,
                        s.Notas
                        );
                }
            }
        }

        private void btnNuevaSalida_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoMovimiento(TipoMovimiento.Salida);
            popup.ShowDialog();
            consultar();
        }
    }
}
