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
    public partial class EditarSubcategoria : Form
    {
        public EditarSubcategoria()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (var context = new StockBDContext())
            {
                var categorias = context.Categorias.ToList();
                var subcategorias = context.Subcategorias.ToList();
                var marcas = context.Marcas.ToList();
                var unidadesDeMedida = context.UnidadesDeMedida.ToList();

                categorias.Insert(0, new Categoria
                {
                    CategoriaId = 0,
                    Nombre = "Seleccione una categoría"
                });

                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "CategoriaId";

                var placeholder = new List<Subcategoria>();
                placeholder.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Primero seleccione una categoría"
                });

                comboBoxSubcategoria.DataSource = placeholder;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";

                // invocación del método de actualización de subcategorías según la categoría seleccionada
                comboBoxCategoria.SelectedIndexChanged += (s, e) =>
                {
                    actualizarSubcategorias(subcategorias, placeholder);
                };

                comboBoxSubcategoria.SelectedIndexChanged += (s, e) =>
                {
                    var subcategoriaSeleccionada = comboBoxSubcategoria.SelectedItem as Subcategoria;
                    if (subcategoriaSeleccionada.Nombre == "Seleccione una subcategoría" || subcategoriaSeleccionada.Nombre == "Primero seleccione una categoría")
                    {
                        textBoxNuevoNombre.Text = "";
                    }
                    else
                    {
                        textBoxNuevoNombre.Text = subcategoriaSeleccionada.Nombre;
                        using (var context = new StockBDContext())
                        {
                            var subcategorias = context.Subcategorias.ToList();
                            var subcategoriaElegida = subcategorias.FirstOrDefault(s => s.Id == subcategoriaSeleccionada.Id);
                        }
                    }
                };
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var subcategoriaSeleccionada = comboBoxSubcategoria.SelectedItem as Subcategoria;
            if (comboBoxSubcategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Subcategoría no seleccionada.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBoxNuevoNombre.Text))
            {
                MessageBox.Show("El campo \"Nuevo nombre\" esta vacío.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxNuevoNombre.Text == subcategoriaSeleccionada.Nombre)
            {
                MessageBox.Show("No hubó ningún campo modificado en la subcategoría.", "Sin campos modificados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;
                using (var context = new StockBDContext())
                {
                    var subcategoria = context.Subcategorias.FirstOrDefault(c => c.Id == subcategoriaId);
                    subcategoria.Nombre = textBoxNuevoNombre.Text;
                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void actualizarSubcategorias(List<Subcategoria> subcategorias, List<Subcategoria> placeholder)
        {
            var categoriaId = (int)comboBoxCategoria.SelectedValue;

            var subcategoriasSeleccionadas = subcategorias
                .Where(s => s.CategoriaId == categoriaId)
                .ToList();

            if (categoriaId == 0)
            {
                comboBoxSubcategoria.DataSource = placeholder;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";
            }
            else
            {
                subcategoriasSeleccionadas.Insert(0, new Subcategoria
                {
                    Id = 0,
                    Nombre = "Seleccione una subcategoría"
                });

                comboBoxSubcategoria.DataSource = subcategoriasSeleccionadas;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "Id";
            }
        }
    }
}
