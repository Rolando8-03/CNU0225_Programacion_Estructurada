using SistemaNotas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCarrera().Show();
        }

        private void asignarDocenteACarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarrerasDocentes frm = new FrmCarrerasDocentes();
            frm.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente frm = new FrmDocente();
            frm.Show();
        }
    }
}
