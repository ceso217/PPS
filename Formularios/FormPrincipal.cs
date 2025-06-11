using GestionDeStock.Controles;
using System.Windows.Forms;

namespace GestionDeStock
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void MostrarUC(UserControl uc)
        {
            panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            MostrarUC(new ucInventario());
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            MostrarUC(new ucIngreso());
        }

    }
}
