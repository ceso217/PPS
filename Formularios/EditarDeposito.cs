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
    public partial class EditarDeposito : Form
    {
        public EditarDeposito()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var depositos = context.Depositos.ToList();

                depositos.Insert(0, new Deposito
                {
                    Id = 0,
                    Nombre = "Seleccione un depósito"
                });

                comboBoxDeposito.DataSource = depositos;
                comboBoxDeposito.ValueMember = "Id";
                comboBoxDeposito.DisplayMember = "Nombre";
            }
            comboBoxDeposito.SelectedIndexChanged += (s, e) =>
            {
                var depositoSeleccionado = comboBoxDeposito.SelectedItem as Deposito;
                if (depositoSeleccionado.Nombre == "Seleccione un depósito")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = depositoSeleccionado.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var depositoSeleccionado = comboBoxDeposito.SelectedItem as Deposito;
            if (comboBoxDeposito.SelectedIndex == 0)
            {
                MessageBox.Show("Depósito no seleccionado.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == depositoSeleccionado.Nombre)
            {
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var depositoId = (int)comboBoxDeposito.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var deposito = context.Depositos.FirstOrDefault(d => d.Id == depositoId);
                    deposito.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
