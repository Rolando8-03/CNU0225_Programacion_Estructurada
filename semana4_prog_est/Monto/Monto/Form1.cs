using System;
using System.Windows.Forms;
using Monto.DAO;

namespace Monto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "Precio: " + precio + "\nMonto: " + Calculo.CalcularMonto(precio) + "\nPrecio: " + precio;
        }

        private void btnCalcularRef_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "Precio: " + precio + "\nMonto: " + Calculo.CalcularMonto(ref precio) + "\nPrecio: " + precio ;
        }
    } 
}
