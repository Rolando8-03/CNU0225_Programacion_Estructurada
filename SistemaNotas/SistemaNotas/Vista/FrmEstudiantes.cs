using SistemaNotas.Controlador;
using System;
using System.Collections;
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
    public partial class FrmEstudiantes : Form
    {
        EstudiantesController lista_estudiantes = new EstudiantesController();
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {

        }
        private void Listar()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista_estudiantes.ObtenerTodasEstudiantes();
            dgvRegistros.Refresh();
            tbCodigo.Clear();
            tbNombre.Clear();
            tbCodigo.Focus();
            tbNombre.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista_estudiantes.AgregarEstudiantes(tbNombre.Text, tbCodigo.Text);
            Listar();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
            tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista_estudiantes.Eliminar(tbNombre.Text, tbCodigo.Text);
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista_estudiantes.ObtenerTodasEstudiantes(tbDato.Text);
            dgvRegistros.Refresh();
        }
    }
}
