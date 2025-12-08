using System;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmVector : Form
    {
        public static int[] vector = new int[10];
        public static int pos =0;
        public FrmVector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!int.TryParse(tbNumeros.Text, out int num))
            {
                MessageBox.Show("Ingrese un numero valido");
                return;
            }
            if (pos >= vector.Length)
            {
                MessageBox.Show("Vector lleno");
                return;
            }
            vector[pos++] = num;
            for (int i = 0; i < pos - 1; i++)
            {
                for (int j = i + 1; j < pos; j++)
                {
                    if (vector[i] < vector[j]) 
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }
            int suma = 0;
            for (int i = 0; i < pos; i++) suma += vector[i];
            double promedio = (double)suma / pos;
            lblPromedio.Text = promedio.ToString();
            string datos = "";
            for (int i = 0; i <= 3; i++)
            {
                datos += vector[i];
                if (i <= 3) datos += " - ";
            }
            lblNumeros.Text = datos;
            lblNumeros2.Text = pos.ToString();
            if (pgbNumeros.Maximum != vector.Length) pgbNumeros.Maximum = vector.Length;
            pgbNumeros.Value = pos;

            tbNumeros.Clear();
            tbNumeros.Focus();
            e.SuppressKeyPress = true;
        }

        private void FrmVector_Load(object sender, EventArgs e)
        {

        }
    }
}
