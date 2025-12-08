using System;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            TreeNode raiz = new TreeNode("UAM");
            TreeNode hijo1 = new TreeNode("Edificio A");
            TreeNode hijo2 = new TreeNode("Edificio B");
            treeView1.Nodes.Add(raiz);
            raiz.Nodes.Add(hijo1);
            raiz.Nodes.Add(hijo2);
            treeView1.ExpandAll();
        }
    }
}
