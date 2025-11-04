using System;
using ClassLibrary1.DAO;
using System.Windows.Forms;
using ClassLibrary1.Modelos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ProductoDAO DAO = new ProductoDAO();
        public Form1()
        {
            InitializeComponent();
        }
        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = DAO.GetProducts();
            this.dgvRegistros.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = tbNombre.Text;
                prod.Codigo = tbCodigo.Text;
                prod.Precio = int.Parse(tbPrecio.Text);
            }catch (FormatException)
            {
                MessageBox.Show("No puedes poner letras en el precio", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DAO.AgregarProducto(prod);
            LlenarGrid();
        }
    }
            
}
