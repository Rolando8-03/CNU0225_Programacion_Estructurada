using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmVector
{
    public partial class FrmVector : Form
    {
        public static int[] vector = new int[10];
        public static int pos =0;
        int suma = 0;
        double promedio = 0;
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
           if (e.KeyCode == Keys.Enter)
           {
                try
                {
                    if (int.TryParse(lblNumeros.Text, out int num))
                    {
                        vector[pos++] = num;
                        for (int i = 0; i < pos; i++)
                        {
                            suma += vector[i];
                            for (int j = i + 1; j < pos; j++)
                            {

                            }
                        }
                        promedio = suma / pos;
                        lblPromedio.Text = promedio.ToString();
                        
                    }
                }
                catch
                {

                }
           }
        }
    }
}
