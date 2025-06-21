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
    public partial class NuevoProveedor : Form
    {
        public Proveedor ProveedorCreado { get; private set; }
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {

                var proveedores = context.Proveedores.ToList();

                bool existe = false;

                foreach (var p in proveedores)
                {
                    if (p.Nombre.ToLower() == textBoxNuevoProveedor.Text.ToLower())
                    {
                        MessageBox.Show("El proveedor \"" + textBoxNuevoProveedor.Text + "\" ya existe.", "Proveedor existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBoxNuevoProveedor.Text))
                {
                    MessageBox.Show("El campo \"Nombre del nuevo proveedor\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!existe)
                {
                    ProveedorCreado = new Proveedor()
                    {
                        Nombre = textBoxNuevoProveedor.Text
                    };

                    context.Proveedores.Add(ProveedorCreado);
                    context.SaveChanges();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxNuevaProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCrearProveedor.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
