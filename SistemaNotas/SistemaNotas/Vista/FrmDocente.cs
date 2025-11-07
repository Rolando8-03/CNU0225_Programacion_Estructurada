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
    public partial class FrmDocente : Form
    {
        private DocenteController docentes = new DocenteController();

        public FrmDocente()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(docentes.Agregar(tbCif.Text, tbNombres.Text, tbApellidos.Text, dtpFechaNac.Value, tbTitulo.Text))
            {
                tbCif.Clear();
                tbNombres.Clear();
                tbApellidos.Clear();
                dtpFechaNac.Value = DateTime.Now;
                tbTitulo.Clear();
                docentes.GuardarJson("c:\\backup\\docentes.json");
                MessageBox.Show("Registro guardado", "Sistema de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al guardar", "Sistema de notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbCif.Focus();
        }
    }
}
