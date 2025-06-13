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
    public partial class FormNuevaUnidadDeMedida : Form
    {
        public FormNuevaUnidadDeMedida()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext()) { 

                var ums = context.UnidadesDeMedida.ToList();

                bool existe = false;

                foreach (UnidadMedida um in ums) {

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
                    UnidadMedida nuevaUM = new UnidadMedida()
                    {
                        Nombre = textBox1.Text
                    };

                    context.UnidadesDeMedida.Add(nuevaUM);
                    context.SaveChanges();

                    this.Close();
                }
            }
        }
    }
}
