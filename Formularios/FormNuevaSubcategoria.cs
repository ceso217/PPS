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
    public partial class FormNuevaSubcategoria : Form
    {
        public FormNuevaSubcategoria()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
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
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "CategoriaId";
            }
        }

        private void btnCrearSubcategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNuevaSubcategoria.Text))
            {
                MessageBox.Show("El campo \"Nombre de la nueva subcategoría\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una categoría válida.", "Categoría inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var context = new StockBDContext())
                {
                    var categoriaPerteneciente = comboBoxCategoria.SelectedItem as Categoria;

                    var subcategorias = context.Subcategorias.Where(s => s.CategoriaId == categoriaPerteneciente.CategoriaId).ToList();

                    bool existe = false;

                    foreach (var s in subcategorias)
                    {
                        if (s.Nombre == textBoxNuevaSubcategoria.Text)
                        {
                            MessageBox.Show("La subcategoría \"" + textBoxNuevaSubcategoria.Text + "\" ya existe.", "Subcategoría existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        var nuevaSubcategoria = new Subcategoria
                        {
                            CategoriaId = categoriaPerteneciente.CategoriaId,
                            Nombre = textBoxNuevaSubcategoria.Text,
                            CodigoSubcategoria = subcategorias.Count == 0 ? 1 : subcategorias.Last().CategoriaId + 1
                        };

                        context.Subcategorias.Add(nuevaSubcategoria);
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
