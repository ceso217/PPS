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
    public partial class NuevaSubcategoria : Form
    {
        public Subcategoria SubcategoriaCreada { get; private set; }
        public Categoria CategoriaPerteneciente { get; private set; }
        private int CategoriaSeleccionada { get; set; }

        public NuevaSubcategoria(int categoriaId)
        {
            InitializeComponent();
            CategoriaSeleccionada = categoriaId;
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

                comboBoxCategoria.SelectedIndex = CategoriaSeleccionada;
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
                    CategoriaPerteneciente = comboBoxCategoria.SelectedItem as Categoria;

                    var subcategorias = context.Subcategorias.Where(s => s.CategoriaId == CategoriaPerteneciente.CategoriaId).ToList();

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
                        SubcategoriaCreada = new Subcategoria
                        {
                            CategoriaId = CategoriaPerteneciente.CategoriaId,
                            Nombre = textBoxNuevaSubcategoria.Text,
                            CodigoSubcategoria = subcategorias.Count == 0 ? 1 : subcategorias.Last().CodigoSubcategoria + 1
                        };

                        context.Subcategorias.Add(SubcategoriaCreada);
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNuevaSubcategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                btnCrearSubcategoria.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
