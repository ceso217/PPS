using GestionDeStock.DBContext;
using GestionDeStock.Models;

namespace GestionDeStock.Formularios
{
    public partial class FormNuevaCategoria : Form
    {
        public FormNuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {

                var categorias = context.Categorias.ToList();

                bool existe = false;

                foreach (var c in categorias)
                {
                    if (c.Nombre == textBoxNuevaCategoria.Text)
                    {
                        MessageBox.Show("La categoría \"" + textBoxNuevaCategoria.Text + "\" ya existe.", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBoxNuevaCategoria.Text))
                {
                    MessageBox.Show("El campo \"Nombre de la nueva categoría\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (!existe)
                {
                    var nuevaCategoria = new Categoria
                    {
                        Nombre = textBoxNuevaCategoria.Text,
                        CategoriaId = categorias.Count == 0 ? 1 : categorias.Last().CategoriaId + 1
                    };

                    context.Categorias.Add(nuevaCategoria);
                    context.SaveChanges();

                    this.Close();
                }
            }
        }
    }
}
