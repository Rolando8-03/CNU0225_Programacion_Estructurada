using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class FrmArbol : Form
    {
        public FrmArbol()
        {
            InitializeComponent();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            { 
                tvArbol.SelectedNode.Nodes.Add(tbNodo.Text);
            }
            else if (tvArbol.Nodes.Count == 0)
            {
                tvArbol.Nodes.Add(tbNodo.Text);
            }
            else 
            {
                MessageBox.Show("Seleccione un nodo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tvArbol.ExpandAll();
            tbNodo.Clear();
            tbNodo.Focus();
        }
    }
}
