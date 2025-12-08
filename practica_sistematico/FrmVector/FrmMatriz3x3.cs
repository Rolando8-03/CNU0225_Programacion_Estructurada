using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmMatriz3x3 : Form
    {
        int[,] matriz = new int[3, 3];
        int fila = 0, columna = 0;
        public FrmMatriz3x3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            int valor = int.Parse(tbDato.Text);
            matriz[fila, columna] = valor;
            tbDato.Clear();
            columna++;
            lblMatriz.Text = Mostrar();
            if (columna == 3)
            {
                columna = 0;
                fila++;

            }
            if (fila == 3)
            {
                MessageBox.Show("Matriz llena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDato.Enabled = false;
            }
            tbDato.Focus();
        }
        private String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz 3x3");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append($"{matriz[i, j],4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
