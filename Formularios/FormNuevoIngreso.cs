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
    public partial class FormNuevoIngreso : Form
    {
        public FormNuevoIngreso()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font(menu.Font.FontFamily, 11);
            menu.Items.Add("Categorías", null, (s, ev) => MessageBox.Show("Elegiste opción 1"));
            menu.Items.Add("Subcategorías", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Artículos", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Marcas", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));
            menu.Items.Add("Unidades de medida", null, (s, ev) => MessageBox.Show("Elegiste opción 2"));

            menu.Show(textBox1, new Point(0, textBox1.Height));
        }
    }
}
