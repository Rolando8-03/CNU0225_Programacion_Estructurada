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
    public partial class FrmCarrerasDocentes : Form
    {
        CarreraController carreras = new CarreraController();
        DocenteController docentes = new DocenteController();

        public FrmCarrerasDocentes()
        {
            InitializeComponent();
        }

        private void FrmCarrerasDocentes_Load(object sender, EventArgs e)
        {
            MostrarCarrrera();
            MostrarDocentes();
        }

        private void MostrarCarrrera()
        {

            for (int i = 0; i < carreras.CargarJson("C:\\backup\\carreras.json").Count; i++)
            {
                string carrera = carreras.CargarJson("C:\\backup\\carreras.json")[i].Nombre;
                tvCarreras.Nodes.Add(carrera);
                tvCarreras.ExpandAll();
            }
        }

        private void MostrarDocentes()
        {

            for(int i = 0; i < docentes.CargarJson("C:\\backup\\docentes.json").Count; i++)
            {
                string nombre = docentes.CargarJson("C:\\backup\\docentes.json")[i].Nombres + " "+ docentes.CargarJson("C:\\backup\\docentes.json")[i].Apellidos;
                
                lbDocentes.Items.Add(nombre);
            }

        }
    }
}
