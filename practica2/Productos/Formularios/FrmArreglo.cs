using Productos.Dao;
using System;
using System.Windows.Forms;

namespace Productos.Formularios
{
    public partial class FrmArreglo : Form
    {
        int mayores = 0, menores = 0;
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                try 
                {
                    if (int.TryParse(tbEdad.Text, out int edad) && edad > 0)
                    {
                        EdadDao.edades[EdadDao.pos++] = edad;
                        if (edad >= 18) { lblMayores1.Text = (++mayores).ToString();}
                        else { lblMenores.Text = (++menores).ToString(); }
                        lblPromedio.Text = EdadDao.Promedio().ToString();
                        int valor_mayores = mayores *100 / EdadDao.edades.Length;
                        int valor_menores = menores*100 / EdadDao.edades.Length;
                        int valor = (EdadDao.pos*100)/EdadDao.edades.Length;
                        pbCapacidad.Value = valor;
                        pbMayores.Value = valor_mayores;
                        pbMenores.Value = valor_menores;
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("No puedes agregar más elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    tbEdad.Clear();
                    tbEdad.Focus();
                    mostrarEdades();
                    e.SuppressKeyPress = true;
                }
            }
        }
        public void mostrarEdades()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = EdadDao.edades;
            lbEdades.Refresh();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {
            mostrarEdades();
        }

        private void lblMayores1_Click(object sender, EventArgs e)
        {

        }
    }
}
