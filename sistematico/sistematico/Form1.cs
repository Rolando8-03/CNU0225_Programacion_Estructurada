using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistematico
{
    public partial class Form1 : Form
    {
        private int[] vector = new int[5];
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(tbNumero.Text);
                vector[pos++] = num;

            }catch(Exception ex)
            {
                MessageBox.Show("Ok");
            }
            finally
            {
                lblArreglo.Text = vector.ToString();

                double suma = 0, promedio = 0;

                for (int i = 0; i < pos; i++)
                {
                    suma += vector[i];
                }

                promedio = suma / pos;

                lblPromedio.Text = promedio.ToString();

                string datos = "";

                for (int i = 0; i < pos; i++)
                {
                    for (int j = i + 1; j < pos; j++)
                    {
                        if (vector[j] > vector[i])
                        {
                            int temp = vector[i];
                            vector[i] = vector[j];
                            vector[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    datos += vector[i];
                    if (i < 1)
                    {
                        lblMayor.Text = datos;
                    }
                    datos += ", ";
                }

                lblArreglo.Text = datos;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
