using SistemaNotas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas.Vista
{
    public partial class FrmCarrera : Form
    {
        CarreraController lista = new CarreraController();
        public FrmCarrera()
        {
            InitializeComponent();
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre.Text, tbCodigo.Text);
            Listar();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void Listar()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.ObtenerTodas();
            dgvRegistros.Refresh();
            tbCodigo.Clear();
            tbNombre.Clear();
            tbCodigo.Focus();
            tbNombre.Focus();
        }

        private void dgvRegistros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
            tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            tbNombre.Text = fila.Cells["Nombre"].Value.ToString();

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre.Text, tbCodigo.Text);
            Listar();
        }
    }
}
