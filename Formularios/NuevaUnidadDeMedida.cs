using GestionDeStock.DBContext;
using GestionDeStock.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
    public partial class NuevaUnidadDeMedida : Form
    {
        public UnidadMedida NuevaUM { get; private set; }
        public NuevaUnidadDeMedida()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {

                var ums = context.UnidadesDeMedida.ToList();

                bool existe = false;

                foreach (UnidadMedida um in ums)
                {

                    if (um.Nombre == textBox1.Text)
                    {
                        MessageBox.Show("La unidad de medida \"" + textBox1.Text + "\" ya existe.", "Unidad de medida existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("El campo \"Nombre de la nueva unidad de medida\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!existe)
                {
                    NuevaUM = new UnidadMedida()
                    {
                        Nombre = textBox1.Text
                    };

                    context.UnidadesDeMedida.Add(NuevaUM);
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCrear.PerformClick();
                e.Handled = true;
            }
        }
    }
}
