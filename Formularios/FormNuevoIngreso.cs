using GestionDeStock.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.Formularios
{
    public partial class FormNuevoIngreso : Form
    {
        public FormNuevoIngreso()
        {
            InitializeComponent();
        }

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            var popup = new FormSeleccionarArticulo();
            popup.ShowDialog();
        }
    }
}
