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
            tabla.Columns.Add("Origen");
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripción");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("UM");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Destino/Obra");
            tabla.Columns.Add("Transportista");
            tabla.Columns.Add("Categoría");
            tabla.Columns.Add("Subcategoría");
            tabla.Columns.Add("Observaciones");
            tabla.Columns.Add("Remito Interno");

            grillaIngreso.DataSource = tabla;
        }
    }
}
