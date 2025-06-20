using GestionDeStock.DBContext;
using GestionDeStock.Formularios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeStock.Controles
{
    public partial class ucIngreso : UserControl
    {
        DataTable tabla;
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

            consultar();
        }

        private void consultar()
        {
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
                        Deposito = i.Deposito.Nombre,
                        Proveedor = i.Proveedor.Nombre,
                        Transportista = i.Transportista.Nombre,
                        Categoria = i.Articulo.Subcategoria.Categoria.Nombre,
                        Subcategoria = i.Articulo.Subcategoria.Nombre,
                        i.Notas
                    }).ToList();

                foreach (var i in ingresos)
                {
                    tabla.Rows.Add(
                        i.Fecha,
                        i.Deposito,
                        i.Categoria,
                        i.Subcategoria,
                        i.CodigoArticulo,
                        i.Descripcion,
                        i.Marca,
                        i.UM,
                        i.Cantidad,
                        i.Proveedor,
                        i.Transportista,
                        i.Notas
                        );
                }
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            var popup = new FormNuevoIngreso();

            popup.ShowDialog();
        }
    }
}
