using System;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmCadena : Form
    {
        public FrmCadena()
        {
            InitializeComponent();
        }
     
        private String Contar(int tam, string frase)
        {
            return "" + (tam - frase.Length);
        }




        private void tbTexto_TextChanged(object sender, EventArgs e)
        {
            lblLetras.Text = Contar(50, tbTexto.Text);
        }

        private void FrmCadena_Load(object sender, EventArgs e)
        {

        }
    }
}
