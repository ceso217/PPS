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
using static GestionDeStock.Formularios.SeleccionarRegistro;

namespace GestionDeStock.Formularios
{
    public partial class EditarArticulo : Form
    {
        DataTable tabla;
        public EditarArticulo()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Categoría");
            tabla.Columns.Add("Subcategoría");
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripción");
            tabla.Columns.Add("MN");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("UM");
            tabla.Columns.Add("Stock");
            tabla.Columns.Add("ArticuloId", typeof(int));

            grilla.DataSource = tabla;

            grilla.Columns["ArticuloId"].Visible = false;
            grilla.Height = grilla.ColumnHeadersHeight * 2;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeRows = false;
            grilla.ReadOnly = true;
            grilla.ScrollBars = ScrollBars.None;

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

                marcas.Insert(0, new Marca
                {
                    Id = 0,
                    Nombre = "Seleccione una marca"
                });

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.DisplayMember = "Nombre";
                comboBoxMarca.ValueMember = "Id";

                unidadesDeMedida.Insert(0, new UnidadMedida
                {
                    Id = 0,
                    Nombre = "Seleccione una unidad de medida"
                });

                comboBoxUM.DataSource = unidadesDeMedida;
                comboBoxUM.DisplayMember = "Nombre";
                comboBoxUM.ValueMember = "Id";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // método de actualización de subcategorías según la categoría seleccionada
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

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            var popup = new SeleccionarRegistro(TipoDeDatos.Articulos, TipoMovimiento.Ingreso);
            var resultados = popup.ShowDialog();

            if (resultados == DialogResult.OK)
            {
                tabla.Rows.Clear();
                using (var context = new StockBDContext())
                {
                    var aSelected = context.Articulos
                        .Select(a => new
                        {
                            Categoria = a.Subcategoria.Categoria,
                            Subcategoria = a.Subcategoria,
                            a.CodigoArticulo,
                            a.Descripcion,
                            a.MN,
                            MarcaNombre = a.Marca.Nombre,
                            UMNombre = a.UnidadMedida.Nombre,
                            a.Modelo,
                            a.Stock,
                            a.Id
                        })
                        .FirstOrDefault(a => a.Id == popup.idSeleccionado);

                    tabla.Rows.Add(
                    aSelected.Categoria.Nombre,
                    aSelected.Subcategoria.Nombre,
                    aSelected.CodigoArticulo,
                    aSelected.Descripcion,
                    aSelected?.MN,
                    aSelected?.MarcaNombre,
                    aSelected?.Modelo,
                    aSelected?.UMNombre,
                    aSelected.Stock,
                    aSelected.Id);

                    textBoxDescripcion.Text = aSelected.Descripcion;
                    textBoxMN.Text = aSelected?.MN;
                    textBoxModelo.Text = aSelected?.Modelo;
                    comboBoxCategoria.SelectedValue = aSelected.Categoria.CategoriaId;
                    comboBoxSubcategoria.SelectedValue = aSelected.Subcategoria.Id;
                }
                grilla.AllowUserToAddRows = false;
            }
        }

        // evento de edición del artículo
        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool cambioDeCodigoArticulo = false;

            if (grilla.AllowUserToAddRows)
            {
                MessageBox.Show("Debe seleccionar un artículo a editar.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una categoría válida.", "Categoría inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxSubcategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una subcategoría válida.", "Subcategoría inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var context = new StockBDContext())
                {
                    int articuloId = Convert.ToInt32(grilla.Rows[0].Cells["ArticuloId"].Value);

                    var articulo = context.Articulos.FirstOrDefault(a => a.Id == articuloId);

                    var subcategoriaId = (int)comboBoxSubcategoria.SelectedValue;

                    var subcategoriaSeleccionada = subcategoriaId != 0 ? context.Subcategorias.FirstOrDefault(s => s.Id == subcategoriaId) : null;

                    var categoriaId = (int)comboBoxCategoria.SelectedValue;


                    articulo.MN = textBoxMN.Text;
                    articulo.Modelo = textBoxModelo.Text;
                    articulo.Descripcion = textBoxDescripcion.Text;

                    if ((int)comboBoxUM.SelectedIndex != 0)
                    {
                        articulo.UnidadMedidaId = (int)comboBoxUM.SelectedValue;
                    }
                    if ((int)comboBoxMarca.SelectedIndex != 0)
                    {
                        articulo.MarcaId = (int)comboBoxMarca.SelectedValue;
                    }

                    if(categoriaId != articulo.CategoriaId && (int)comboBoxCategoria.SelectedIndex != 0)
                    {
                        articulo.CategoriaId = categoriaId;
                        cambioDeCodigoArticulo = true;
                    }
                    if(subcategoriaId != articulo.SubcategoriaId && (int)comboBoxSubcategoria.SelectedIndex != 0)
                    {
                        articulo.SubcategoriaId = subcategoriaId;
                        articulo.CodigoSubcategoria = subcategoriaSeleccionada.CodigoSubcategoria;
                        cambioDeCodigoArticulo = true;
                    }

                    var articulos = context.Articulos.Where(a => a.CategoriaId == categoriaId && a.SubcategoriaId == subcategoriaSeleccionada.Id).OrderBy(a => a.CodigoArticulo).ToList();

                    if (cambioDeCodigoArticulo)
                    {
                        articulo.CodigoArticulo = articulos.LastOrDefault() == null ? (categoriaId * 100000 + subcategoriaSeleccionada.CodigoSubcategoria * 10000 + 1) : articulos.Last().CodigoArticulo + 1;
                    }

                    context.SaveChanges();
                }
                this.Close();
            }
        }
    }
}
