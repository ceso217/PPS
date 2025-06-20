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
    public partial class FormNuevoDeposito : Form
    {
        public Deposito NuevoDeposito { get; private set; }
        public FormNuevoDeposito()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearDeposito_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {

                var depositos = context.Proveedores.ToList();

                bool existe = false;

                foreach (var d in depositos)
                {
                    if (d.Nombre.ToLower() == textBoxNuevoDeposito.Text.ToLower())
                    {
                        MessageBox.Show("El depósito \"" + textBoxNuevoDeposito.Text + "\" ya existe.", "Depósito existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBoxNuevoDeposito.Text))
                {
                    MessageBox.Show("El campo \"Nombre del nuevo depósito\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!existe)
                {
                    NuevoDeposito = new Deposito()
                    {
                        Nombre = textBoxNuevoDeposito.Text
                    };

                    context.Depositos.Add(NuevoDeposito);
                    context.SaveChanges();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxNuevaDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCrearDeposito.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
