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
    public partial class EditarProveedor : Form
    {
        public EditarProveedor()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var proveedores = context.Proveedores.ToList();

                proveedores.Insert(0, new Proveedor
                {
                    Id = 0,
                    Nombre = "Seleccione un proveedor"
                });

                comboBoxProveedor.DataSource = proveedores;
                comboBoxProveedor.ValueMember = "Id";
                comboBoxProveedor.DisplayMember = "Nombre";
            }
            comboBoxProveedor.SelectedIndexChanged += (s, e) =>
            {
                var proveedorSeleccionado = comboBoxProveedor.SelectedItem as Proveedor;
                if (proveedorSeleccionado.Nombre == "Seleccione un proveedor")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = proveedorSeleccionado.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var proveedorSeleccionado = comboBoxProveedor.SelectedItem as Proveedor;
            if (comboBoxProveedor.SelectedIndex == 0)
            {
                MessageBox.Show("Proveedor no seleccionado.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == proveedorSeleccionado.Nombre)
            {
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var proveedorId = (int)comboBoxProveedor.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var proveedor = context.Proveedores.FirstOrDefault(d => d.Id == proveedorId);
                    proveedor.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
