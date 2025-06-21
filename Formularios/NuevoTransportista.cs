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

namespace GestionDeStock.Formularios
{
    public partial class NuevoTransportista : Form
    {
        public Transportista TransportistaCreado { get; private set; }
        public NuevoTransportista()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearTransportista_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {

                var transportistas = context.Transportistas.ToList();

                bool existe = false;

                foreach (var t in transportistas)
                {
                    if (t.Nombre.ToLower() == textBoxNuevoTransportista.Text.ToLower())
                    {
                        MessageBox.Show("El transportista \"" + textBoxNuevoTransportista.Text + "\" ya existe.", "Transportista existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBoxNuevoTransportista.Text))
                {
                    MessageBox.Show("El campo \"Nombre del nuevo transportista\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!existe)
                {
                    TransportistaCreado = new Transportista()
                    {
                        Nombre = textBoxNuevoTransportista.Text
                    };

                    context.Transportistas.Add(TransportistaCreado);
                    context.SaveChanges();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxNuevaTransportista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCrearTransportista.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

