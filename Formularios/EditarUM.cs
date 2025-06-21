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
    public partial class EditarUM : Form
    {
        public EditarUM()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var unidadesDeMedida = context.UnidadesDeMedida.ToList();

                unidadesDeMedida.Insert(0, new UnidadMedida
                {
                    Id = 0,
                    Nombre = "Seleccione una categoría"
                });

                comboBoxUM.DataSource = unidadesDeMedida;
                comboBoxUM.ValueMember = "Id";
                comboBoxUM.DisplayMember = "Nombre";
            }
            comboBoxUM.SelectedIndexChanged += (s, e) =>
            {
                var umSeleccionada = comboBoxUM.SelectedItem as UnidadMedida;
                if (umSeleccionada.Nombre == "Seleccione una unidad de medida")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = umSeleccionada.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var umSeleccionado = comboBoxUM.SelectedItem as UnidadMedida;
            if (comboBoxUM.SelectedIndex == 0)
            {
                MessageBox.Show("Unidad de medida no seleccionada.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == umSeleccionado.Nombre)
            {
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var umId = (int)comboBoxUM.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var um = context.UnidadesDeMedida.FirstOrDefault(c => c.Id == umId);
                    um.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
