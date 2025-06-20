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
    public partial class EditarCategoria : Form
    {
        public EditarCategoria()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var categorias = context.Categorias.ToList();

                categorias.Insert(0, new Categoria
                {
                    CategoriaId = 0,
                    Nombre = "Seleccione una categoría"
                });

                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.ValueMember = "CategoriaId";
                comboBoxCategoria.DisplayMember = "Nombre";
            }
            comboBoxCategoria.SelectedIndexChanged += (s, e) =>
            {
                var categoriaSeleccionada = comboBoxCategoria.SelectedItem as Categoria;
                if (categoriaSeleccionada.Nombre == "Seleccione una categoría")
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = categoriaSeleccionada.Nombre;
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var categoriaSeleccionada = comboBoxCategoria.SelectedItem as Categoria;
            if(comboBoxCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Categoría no seleccionada.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.","Campo incompleto",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else if (textBox1.Text == categoriaSeleccionada.Nombre){
                MessageBox.Show("El campo \"Nuevo nombre\" no fue modificado.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var categoriaId = (int)comboBoxCategoria.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var categoria = context.Categorias.FirstOrDefault(c => c.CategoriaId == categoriaId);
                    categoria.Nombre = textBox1.Text;

                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
