using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstructurasDinamicasG6
{
    public partial class FrmPilaRM : Form
    {
        Stack<int> pilaEdades = new Stack<int>();
        public FrmPilaRM()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pilaEdades.Push(edad);
            Mostrar();
            tbEdad.Focus();

        }
        private void Mostrar()
        {
            string msn = "";
            foreach (int edad in pilaEdades)
            {
                msn += " " + edad + " |";
            }
            lblEdades.Text = msn;
            tbEdad.Clear();
            tbEdad.Focus();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pilaEdades.Count > 0)
            {
                pilaEdades.Pop();
                Mostrar();
            }
            else
            {
                MessageBox.Show("La pila está vacía","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pilaEdades.Count > 0)
            {
                int cima = pilaEdades.Peek();
                MessageBox.Show("La edad en la cima de la pila es: " + cima, "Cima de la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La pila está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Stack<int> pilaAuxiliar = new Stack<int>();
            while (pilaEdades.Count > 0)
            {
                int temp = pilaEdades.Pop();
                while (pilaAuxiliar.Count > 0 && pilaAuxiliar.Peek() > temp)
                {
                    pilaEdades.Push(pilaAuxiliar.Pop());
                }
                pilaAuxiliar.Push(temp);
            }
            pilaEdades = pilaAuxiliar;
            string msn = "";
            foreach (int edad in pilaEdades)
            {
                msn += " " + edad + " |";
            }
            lblEdades.Text = msn;
            tbEdad.Clear();
            tbEdad.Focus();
        }
    }
}
