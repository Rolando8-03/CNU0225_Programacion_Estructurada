using System;
using System.Windows.Forms;
using CiudadesLibrary.DAO;
using CiudadesLibrary.Modelos;

namespace CiudadesApp
{
    public partial class Form1 : Form
    {
        CiudadDAO lista = new CiudadDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = tbNombre.Text;
            ciudad.poblacion = int.Parse(tbPoblacion.Text);
            ciudad.FechaFundacion = dtpFundacion.Value;
            lista.AgregarCiudad(ciudad);
            llenarDataGrid();
        }
        private void llenarDataGrid()
        {
            dgvRegistros.DataSource = lista.MostrarCiudad();
            dgvRegistros.Refresh();

        }
    }
}
