using Productos.Formularios;
using System;
using System.Windows.Forms;

namespace Productos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProducto().Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmArreglo frm = new FrmArreglo();
            frm.ShowDialog();
        }
    }
}
