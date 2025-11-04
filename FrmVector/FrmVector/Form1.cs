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
    }
}
