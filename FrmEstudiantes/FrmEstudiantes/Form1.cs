using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmEstudiantes
{
    class Estudiante
    {
        string nombre { get; set; }
        string apellido { get; set; }
        string carrera { get; set; }
        float nota { get; set; }    
    }
    public partial class Form1 : Form
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((tbApellido.Text = "") || (tbNombre.Text == "") || (tbCarrera == "") || (tbNota.Text = ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
        }
    }
}
