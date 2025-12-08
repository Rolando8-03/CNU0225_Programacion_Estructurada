using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{

    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        class Estudiante
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Carrera { get; set; }
            public int Nota { get; set; }
            public Estudiante(string nombre, string apellido, int nota, string carrera)
            {
                Nombre = nombre;
                Apellido = apellido;
                Nota = nota;
                Carrera = carrera;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbApellido.Text == "" || tbNombre.Text == "" || tbCarrera.Text == "" || tbNota.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
            if (int.TryParse(tbNota.Text, out int nota))
            {
                if (nota < 0 || nota > 100)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 100.");
                    return;
                }
                Estudiante estudiante = new Estudiante(tbNombre.Text, tbApellido.Text, nota, tbCarrera.Text);
                estudiantes.Add(estudiante);
                MessageBox.Show("Estudiante agregado exitosamente.");
                tbNombre.Clear();
                tbApellido.Clear();
                tbCarrera.Clear();
                tbNota.Clear();
                dgvEstudiantes.DataSource = estudiantes;
                dgvEstudiantes.Refresh();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (estudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes para eliminar.");
                return;
            }
            estudiantes.RemoveAt(0); 
            dgvEstudiantes.DataSource = null;  
            dgvEstudiantes.DataSource = estudiantes;  
            dgvEstudiantes.Refresh();  
        }
    }
}
