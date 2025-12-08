using System;
using System.Text;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmMatriz2x2 : Form
    {
        int[,] matriz = new int[2, 2];
        int fila = 0, columna =0;
        public FrmMatriz2x2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(tbDatos.Text);
            matriz [ fila, columna] = valor;
            tbDatos.Clear();
            columna++;
            lblMatriz.Text = Mostrar();
            if (columna == 2)
            {
                columna = 0; 
                fila++;

            }
            if (fila == 2)
            {
                MessageBox.Show("Matriz llena","Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;    
                btnAgregar.Enabled = false;
            }
            tbDatos.Focus();
        }
        private String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz 2x2");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append($"{matriz[i,j],4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void FrmMatriz2x2_Load(object sender, EventArgs e)
        {

        }
    }
}
