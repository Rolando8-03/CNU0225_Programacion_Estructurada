using System;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void vectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmVector().Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bloqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz2x2().Show();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz3x3().Show();
        }

        private void cadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadena().Show();
        }
    }
}
