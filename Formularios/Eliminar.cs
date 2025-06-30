using GestionDeStock.DBContext;
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
    public partial class Eliminar : Form
    {
        string nombreEntidad;
        Action<object> eliminarCallback;
        int maxPuntoFinal;


        public Eliminar(string nombreEntidad, IEnumerable<object> elementos, Action<object> eliminarCallback)
        {
            InitializeComponent();
            this.eliminarCallback = eliminarCallback;
            this.nombreEntidad = nombreEntidad;
            this.Text = "Eliminar " + nombreEntidad.ToLower();
            labelTitulo.Text = "Eliminar " + nombreEntidad.ToLower();
            labelElementoEliminar.Text = nombreEntidad + " a eliminar:";
            maxPuntoFinal = comboBoxElemento.Location.X + comboBoxElemento.Size.Width;
            comboBoxElemento.Location = new Point(labelElementoEliminar.Location.X + labelElementoEliminar.Width +10,comboBoxElemento.Location.Y);
            comboBoxElemento.Width = comboBoxElemento.Width + (maxPuntoFinal - (comboBoxElemento.Location.X + comboBoxElemento.Width));
            comboBoxElemento.DataSource = elementos;
            comboBoxElemento.DisplayMember = "Nombre";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxElemento.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una opción válida.", "Opción invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult confirmacion;
                if (nombreEntidad == "Categoría")
                {
                    confirmacion = MessageBox
                        .Show("Al eliminar la categoría, también se eliminarán las subcategorías y los artículos asignados a ella. ¿Está seguro de que desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    confirmacion = MessageBox
                        .Show("¿Estás seguro que quieres eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (confirmacion == DialogResult.Yes)
                {
                    var seleccionado = comboBoxElemento.SelectedItem;

                    eliminarCallback(seleccionado);
                    MessageBox.Show($"{nombreEntidad} eliminada correctamente.", $"{nombreEntidad} eliminada.", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
