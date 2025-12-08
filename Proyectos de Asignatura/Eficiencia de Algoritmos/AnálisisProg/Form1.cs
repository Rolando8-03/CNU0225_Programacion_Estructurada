using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AnálisisProg
{
    public partial class Form1 : Form
    {
        List<long> numeros = new List<long>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGenerar.Enabled = false;
                int num = int.Parse(txtCantidad.Text);
                if (num <= 0)
                {
                    MessageBox.Show("Ingrese un número válido mayor a 0.");
                    btnGenerar.Enabled = true;
                    return;
                }
                Random rand = new Random();
                numeros.Clear();
                Stopwatch sw = new Stopwatch();
                lblTiempoIni.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("HH:mm:ss");
                sw.Start();
                for (int i = 0; i < num; i++)
                {
                    numeros.Add(rand.Next(100, 500));
                }
                lstDatos.DataSource = null;
                lstDatos.DataSource = numeros;
                sw.Stop();
                lblTiempoFin.Text = "Tiempo de Fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";
                gbRegistros.Text = "Registros: " + num;
                btnGenerar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Solo se aceptan números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGenerar.Enabled = true;

            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (numeros.Count > 0)
            {
                btnOrdenarMerge.Enabled = false;
                btnGenerar.Enabled = false;
                btnOrdenarSelection.Enabled = false;

                Stopwatch sw = new Stopwatch();
                lblTiempoIni.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("HH:mm:ss");
                sw.Start();

                // Local functions que implementan Merge Sort completamente dentro del método
                void Merge(List<long> list, long[] aux, int left, int mid, int right)
                {
                    int i = left, j = mid + 1, k = left;
                    while (i <= mid && j <= right)
                    {
                        if (list[i] <= list[j])
                            aux[k++] = list[i++];
                        else
                            aux[k++] = list[j++];
                    }
                    while (i <= mid) aux[k++] = list[i++];
                    while (j <= right) aux[k++] = list[j++];
                    for (int t = left; t <= right; t++) list[t] = aux[t];
                }
                void MergeSortInternal(List<long> list, long[] aux, int left, int right)
                {
                    if (left >= right) return;
                    int mid = left + (right - left) / 2;
                    MergeSortInternal(list, aux, left, mid);
                    MergeSortInternal(list, aux, mid + 1, right);
                    Merge(list, aux, left, mid, right);
                }

                void MergeSortLocal(List<long> list)
                {
                    if (list == null || list.Count <= 1) return;
                    long[] aux = new long[list.Count];
                    MergeSortInternal(list, aux, 0, list.Count - 1);
                }
                // Ejecutar el Merge Sort
                MergeSortLocal(numeros);

                lstOrdenada.DataSource = null;
                lstOrdenada.DataSource = numeros;
                sw.Stop();
                lblTiempoFin.Text = "Tiempo de Fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";

                btnOrdenarMerge.Enabled = true;
                btnGenerar.Enabled = true;
                btnOrdenarSelection.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOrdenarMerge.Enabled = true;
                btnGenerar.Enabled = true;
                btnOrdenarSelection.Enabled = true;
            }
        }

        private void btnOrdenarSelection_Click(object sender, EventArgs e)
        {
            if (numeros.Count > 0)
            {
                // Disable other controls while sorting
                btnOrdenarMerge.Enabled = false;
                btnGenerar.Enabled = false;
                btnOrdenarSelection.Enabled = false;

                int cant = numeros.Count;
                Stopwatch sw = new Stopwatch();
                lblTiempoIni.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("HH:mm:ss");
                sw.Start();

                // Selection sort implementation 
                for (int i = 0; i < cant - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < cant; j++)
                    {
                        if (numeros[j] < numeros[minIndex])
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        long temp = numeros[minIndex];
                        numeros[minIndex] = numeros[i];
                        numeros[i] = temp;
                    }
                }
                lstOrdenada.DataSource = null;
                lstOrdenada.DataSource = numeros;
                sw.Stop();
                lblTiempoFin.Text = "Tiempo de Fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";

                // Re-enable controls
                btnOrdenarMerge.Enabled = true;
                btnGenerar.Enabled = true;
                btnOrdenarSelection.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOrdenarMerge.Enabled = true;
                btnGenerar.Enabled = true;
                btnOrdenarSelection.Enabled = true;
            }
        }

        private void btnBuscarSaltos_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0)
            {
                MessageBox.Show("La lista está vacía. Genere datos primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("Ingrese un valor en el campo de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetInt;
            if (!int.TryParse(tbBuscar.Text.Trim(), out targetInt) || targetInt <= 0)
            {
                MessageBox.Show("Ingrese un número entero mayor que 0 en el campo de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long target = targetInt;
            // Work on a sorted copy so search makes sense
            List<long> sorted = new List<long>(numeros);
            sorted.Sort();
            lstOrdenada.DataSource = null;
            lstOrdenada.DataSource = sorted;

            Stopwatch sw = Stopwatch.StartNew();
            lblTiempoIni.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("HH:mm:ss");
            int n = sorted.Count;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            // Finding the block where element may be present
            while (prev < n && sorted[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) break;
            }
            // Linear search within block
            int indexFound = -1;
            int start = prev;
            int end = Math.Min(step, n) - 1;
            for (int i = start; i <= end; i++)
            {
                if (sorted[i] == target)
                {
                    indexFound = i;
                    break;
                }
            }

            sw.Stop();
            lblTiempoFin.Text = "Tiempo de Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";

            if (indexFound >= 0)
            {
                MessageBox.Show($"Valor {target} encontrado en índice {indexFound} (lista ordenada). Tiempo: {sw.ElapsedMilliseconds} ms", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Valor {target} NO encontrado. Tiempo: {sw.ElapsedMilliseconds} ms", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBusquedaInterpolada_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0)
            {
                MessageBox.Show("La lista está vacía. Genere datos primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("Ingrese un valor en el campo de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetInt;
            if (!int.TryParse(tbBuscar.Text.Trim(), out targetInt) || targetInt <= 0)
            {
                MessageBox.Show("Ingrese un número entero mayor que 0 en el campo de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long target = targetInt;

            // Work on a sorted copy so search makes sense
            List<long> sorted = new List<long>(numeros);
            sorted.Sort();
            lstOrdenada.DataSource = null;
            lstOrdenada.DataSource = sorted;

            Stopwatch sw = Stopwatch.StartNew();
            lblTiempoIni.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("HH:mm:ss");
            int low = 0;
            int high = sorted.Count - 1;
            int indexFound = -1;

            while (low <= high && target >= sorted[low] && target <= sorted[high])
            {
                if (low == high)
                {
                    if (sorted[low] == target) indexFound = low;
                    break;
                }

                // Estimate the position
                double fraction = (double)(target - sorted[low]) / (double)(sorted[high] - sorted[low]);
                int pos = low + (int)((high - low) * fraction);

                // Guard pos bounds
                if (pos < low) pos = low;
                if (pos > high) pos = high;

                if (sorted[pos] == target)
                {
                    indexFound = pos;
                    break;
                }
                if (sorted[pos] < target)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            sw.Stop();
            lblTiempoFin.Text = "Tiempo de Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";
            if (indexFound >= 0)
            {
                MessageBox.Show($"Valor {target} encontrado en índice {indexFound} (lista ordenada). Tiempo: {sw.ElapsedMilliseconds} ms", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Valor {target} NO encontrado. Tiempo: {sw.ElapsedMilliseconds} ms", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
