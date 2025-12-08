using System.Windows.Forms;
using System.Collections.Generic;

namespace FrmListas
{
    public partial class Form1 : Form
    {
        List<string> frutas = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbFruta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            frutas.Add(tbFruta.Text.ToString());
            lblFruta.Text = string.Join(" | ", frutas) + " | ";
            tbFruta.Clear();
            tbFruta.Focus();
            e.SuppressKeyPress = true;
        }

        private void btnRemover_Click(object sender, System.EventArgs e)
        {
            if (frutas.Count > 0){
                frutas.RemoveAt(0);
                lblFruta.Text = string.Join(" | ", frutas) + " | ";
            }else
            {
                MessageBox.Show("La lista está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRevertir_Click(object sender, System.EventArgs e)
        {
            if (frutas.Count > 0)
            {
                frutas.Reverse();
                lblFruta.Text = string.Join(" | ", frutas) + " | ";
            }
            else
            {
                MessageBox.Show("La lista está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnOrdenar_Click(object sender, System.EventArgs e)
        {
            if (frutas.Count > 0)
            {
                frutas.Sort();
                lblFruta.Text = string.Join(" | ", frutas) + " | ";
            }
            else
            {
                MessageBox.Show("La lista está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbEliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (frutas.Contains(tbEliminar.Text.ToString()))
            {
                frutas.Remove(tbEliminar.Text.ToString());
                lblFruta.Text = string.Join(" | ", frutas) + " | ";
                tbEliminar.Clear();
            }
            else
            {
                MessageBox.Show("La fruta no se encuentra en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
