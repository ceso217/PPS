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

        private void Iniciar()
        {

        }

        private void consultar(string filtro)
        {
            //comboBox2.Items.Clear();
            using (var context = new StockBDContext())
            {
                var articulos = context.Articulos.Where(a => a.Descripcion.ToLower().Contains(filtro.ToLower())).ToList();

                foreach (var a in articulos)
                {
                    comboBox2.Items.Add(a.Descripcion);
                }
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            consultar(comboBox2.Text);
        }
    }
}
