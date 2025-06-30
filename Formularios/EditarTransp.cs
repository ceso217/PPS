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
    public partial class EditarTransp : Form
    {
        public EditarTransp()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var transportistas = context.Transportistas.ToList();

                transportistas.Insert(0, new Transportista  
                {
                    Id = 0,
                    Nombre = "Seleccione un transportista"
                });

                comboBoxTransp.DataSource = transportistas;
                comboBoxTransp.ValueMember = "Id";
                comboBoxTransp.DisplayMember = "Nombre";
            }
            comboBoxTransp.SelectedIndexChanged += (s, e) =>
            {
                var transportistaSeleccionado = comboBoxTransp.SelectedItem as Transportista;
                if (transportistaSeleccionado.Nombre == "Seleccione un transportista")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = transportistaSeleccionado.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var transportistaSeleccionado = comboBoxTransp.SelectedItem as Transportista;
            if (comboBoxTransp.SelectedIndex == 0)
            {
                MessageBox.Show("Transportista no seleccionados.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == transportistaSeleccionado.Nombre)
            {
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var transportistaId = (int)comboBoxTransp.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var transportista = context.Transportistas.FirstOrDefault(d => d.Id == transportistaId);
                    transportista.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
