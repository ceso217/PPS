using GestionDeStock.DBContext;
using GestionDeStock.Formularios;
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

namespace GestionDeStock
{
    public partial class NuevoArtículo : Form
    {
        public NuevoArtículo()
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

                // evento de apertura del formulario de creación de subcategoria
                btnCrearSubcategoria.Click += (s, e) =>
                {
                    int idCategoriaSeleccionada = (int)comboBoxCategoria.SelectedValue;

                    var popup = new NuevaSubcategoria(idCategoriaSeleccionada);

                    var resultado = popup.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        Subcategoria nueva = popup.SubcategoriaCreada;
                        Categoria seleccionada = popup.CategoriaPerteneciente;

                        using (var context = new StockBDContext())
                        {
                            subcategorias = context.Subcategorias.ToList();
                        }

                        actualizarSubcategorias(subcategorias, placeholder);

                        comboBoxCategoria.SelectedIndex = seleccionada.CategoriaId;
                        comboBoxSubcategoria.SelectedValue = nueva.Id;
                    }
                };

                // evento de creación del artículo
                btnAgregar.Click += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
                    {
                        MessageBox.Show("El campo \" Descripción\" es obligatorio.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            var subcategoriaSeleccionada = comboBoxSubcategoria.SelectedItem as Subcategoria;

                            var articulos = context.Articulos.Where(a => a.CategoriaId == (int)comboBoxCategoria.SelectedValue && a.SubcategoriaId == subcategoriaSeleccionada.Id).OrderBy(a => a.CodigoArticulo).ToList();

                            int codigoArticulo = 1;

                            if (articulos.LastOrDefault() != null)
                            {
                                codigoArticulo = articulos.Last().CodigoArticulo + 1;
                            }

                            var nuevoArticulo = new Articulo
                            {
                                // recordar que esto funciona siempre y cuando no haya más de 9 subcategorías en la misma categoría o más de 9999 artículos en la misma subcategoría
                                CodigoArticulo = articulos.LastOrDefault() == null ? ((int)comboBoxCategoria.SelectedValue * 100000 + subcategoriaSeleccionada.CodigoSubcategoria * 10000 + 1) : articulos.Last().CodigoArticulo +1,
                                CategoriaId = (int)comboBoxCategoria.SelectedValue,
                                CodigoSubcategoria = subcategoriaSeleccionada.CodigoSubcategoria,
                                SubcategoriaId = subcategoriaSeleccionada.Id,
                                Descripcion = textBoxDescription.Text,
                                MN = textBox2.Text,
                                Modelo = textBox3.Text,
                                UnidadMedidaId = (int)comboBoxUM.SelectedValue == 0 ? null : (int?)comboBoxUM.SelectedValue,
                                MarcaId = (int)comboBoxMarca.SelectedValue == 0 ? null : (int?)comboBoxMarca.SelectedValue,
                                Stock = (int)numericUpDownStock.Value
                            };

                            context.Articulos.Add(nuevoArticulo);
                            context.SaveChanges();
                        }
                        this.Close();
                    }
                };
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            var popup = new NuevaCategoria();

            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
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

                    Categoria nueva = popup.CategoriaCreada;
                    comboBoxCategoria.SelectedIndex = nueva.CategoriaId;
                }
            }
        }

        private void btnCrearUM_Click(object sender, EventArgs e)
        {
            var popup = new NuevaUnidadDeMedida();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var ums = context.UnidadesDeMedida.ToList();
                    ums.Insert(0, new UnidadMedida
                    {
                        Id = 0,
                        Nombre = "Seleccione una unidad de medida"
                    });

                    comboBoxUM.DataSource = ums;
                    comboBoxUM.DisplayMember = "Nombre";
                    comboBoxUM.ValueMember = "Id";

                    comboBoxUM.SelectedValue = popup.NuevaUM.Id;
                }
            }
        }

        private void btnCrearMarca_Click(object sender, EventArgs e)
        {
            var popup = new NuevaMarca();
            var resultado = popup.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                using (var context = new StockBDContext())
                {
                    var marcas = context.Marcas.ToList();
                    marcas.Insert(0, new Marca
                    {
                        Id = 0,
                        Nombre = "Seleccione una marca"
                    });

                    comboBoxMarca.DataSource = marcas;
                    comboBoxMarca.DisplayMember = "Nombre";
                    comboBoxMarca.ValueMember = "Id";

                    comboBoxMarca.SelectedValue = popup.MarcaCreada.Id;
                }
            }
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
    }
} 