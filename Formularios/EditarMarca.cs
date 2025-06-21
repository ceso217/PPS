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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeStock.Formularios
{
    public partial class EditarMarca : Form
    {
        public EditarMarca()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var marcas = context.Marcas.ToList();

                marcas.Insert(0, new Marca
                {
                    Id = 0,
                    Nombre = "Seleccione una categoría"
                });

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Nombre";
            }
            comboBoxMarca.SelectedIndexChanged += (s, e) =>
            {
                var marcaSeleccionada = comboBoxMarca.SelectedItem as Marca;
                if (marcaSeleccionada.Nombre == "Seleccione una marca")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = marcaSeleccionada.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var marcaSeleccionada = comboBoxMarca.SelectedItem as Marca;
            if (comboBoxMarca.SelectedIndex == 0)
            {
                MessageBox.Show("Marca no seleccionada.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == marcaSeleccionada.Nombre)
            {
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var marcaId = (int)comboBoxMarca.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var marca = context.Marcas.FirstOrDefault(c => c.Id == marcaId);
                    marca.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
