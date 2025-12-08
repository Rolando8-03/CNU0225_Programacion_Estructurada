using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TercerCorteApp
{
    // Solo lista: generación, orden y búsqueda. Todo en español y sencillo.
    public partial class Form1 : Form
    {
        private readonly Random rng = new Random();
        private List<int> listaActual = new List<int>();

        public Form1()
        {
            InitializeComponent();

            // eventos
            this.btnGenerar.Click += BtnGenerar_Click;
            this.btnOrdenar.Click += BtnOrdenar_Click;
            this.btnBuscarLista.Click += BtnBuscarLista_Click;

            // seleccionar valores por defecto si existen items
            if (this.comboOrdenar.Items.Count > 0) this.comboOrdenar.SelectedIndex = 0;
            if (this.comboBuscar.Items.Count > 0) this.comboBuscar.SelectedIndex = 0;
        }

        // generar lista aleatoria
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)numericCantidad.Value;
                if (cantidad <= 0) throw new ArgumentException("Cantidad debe ser mayor que 0.");
                listaActual = Enumerable.Range(0, cantidad).Select(_ => rng.Next(100, 500)).ToList();
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista()
        {
            listBoxNumeros.BeginUpdate();
            listBoxNumeros.Items.Clear();
            foreach (var v in listaActual) listBoxNumeros.Items.Add(v);
            listBoxNumeros.EndUpdate();
        }

        // ordenar
        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaActual == null || listaActual.Count == 0) throw new InvalidOperationException("Lista vacía. Genere primero.");
                var metodo = comboOrdenar.SelectedItem as string;
                if (string.IsNullOrEmpty(metodo)) throw new ArgumentException("Seleccione método de orden.");
                int[] arr = listaActual.ToArray();
                var sw = Stopwatch.StartNew();
                switch (metodo)
                {
                    case "Selection": SelectionSort(arr); break;
                    case "Quick": QuickSort(arr, 0, arr.Length - 1); break;
                    case "Merge": arr = MergeSort(arr); break;
                    case "Insertion": InsertionSort(arr); break;
                    default: throw new ArgumentException("Método desconocido.");
                }
                sw.Stop();
                listaActual = arr.ToList();
                RefrescarLista();
                lblDuracionOrden.Text = $"Duración orden: {sw.Elapsed.TotalMilliseconds:F4} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ordenar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // buscar
        private void BtnBuscarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaActual == null || listaActual.Count == 0) throw new InvalidOperationException("Lista vacía. Genere primero.");
                if (!int.TryParse(txtValorBuscar.Text.Trim(), out int clave)) throw new ArgumentException("Ingrese entero válido.");
                var metodo = comboBuscar.SelectedItem as string;
                if (string.IsNullOrEmpty(metodo)) throw new ArgumentException("Seleccione método de búsqueda.");
                int[] arr = listaActual.ToArray();
                var sw = Stopwatch.StartNew();
                int idx = -1;
                switch (metodo)
                {
                    case "Secuencial": idx = BusquedaSecuencial(arr, clave); break;
                    case "Binaria":
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada para búsqueda binaria.");
                        idx = BusquedaBinaria(arr, clave);
                        break;
                    case "Jump":
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada para jump search.");
                        idx = BusquedaJump(arr, clave);
                        break;
                    case "Interpolacion":
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada para interpolación.");
                        idx = BusquedaInterpolacion(arr, clave);
                        break;
                    default: throw new ArgumentException("Método desconocido.");
                }
                sw.Stop();
                lblDuracionBusqueda.Text = $"Duración búsqueda: {sw.Elapsed.TotalMilliseconds:F4} ms";
                MessageBox.Show(idx >= 0 ? $"Encontrado en índice {idx}." : "No encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Algoritmos de ordenación ----------
        private static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++) if (arr[j] < arr[min]) min = j;
                int tmp = arr[i]; arr[i] = arr[min]; arr[min] = tmp;
            }
        }

        private static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key) { arr[j + 1] = arr[j]; j--; }
                arr[j + 1] = key;
            }
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high) return;
            int pivot = arr[(low + high) / 2];
            int i = low, j = high;
            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;
                if (i <= j) { int t = arr[i]; arr[i] = arr[j]; arr[j] = t; i++; j--; }
            }
            if (low < j) QuickSort(arr, low, j);
            if (i < high) QuickSort(arr, i, high);
        }

        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            int m = arr.Length / 2;
            var l = MergeSort(arr.Take(m).ToArray());
            var r = MergeSort(arr.Skip(m).ToArray());
            return Merge(l, r);
        }

        private static int[] Merge(int[] a, int[] b)
        {
            int[] res = new int[a.Length + b.Length];
            int i = 0, ia = 0, ib = 0;
            while (ia < a.Length && ib < b.Length)
            {
                if (a[ia] <= b[ib]) res[i++] = a[ia++];
                else res[i++] = b[ib++];
            }
            while (ia < a.Length) res[i++] = a[ia++];
            while (ib < b.Length) res[i++] = b[ib++];
            return res;
        }

        // ---------- Búsquedas ----------
        private static int BusquedaSecuencial(int[] arr, int clave)
        {
            for (int i = 0; i < arr.Length; i++) if (arr[i] == clave) return i;
            return -1;
        }

        private static int BusquedaBinaria(int[] arr, int clave)
        {
            int lo = 0, hi = arr.Length - 1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (arr[mid] == clave) return mid;
                if (arr[mid] < clave) lo = mid + 1;
                else hi = mid - 1;
            }
            return -1;
        }

        private static int BusquedaJump(int[] arr, int clave)
        {
            int n = arr.Length;
            if (n == 0) return -1;
            int paso = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (prev < n && arr[Math.Min(paso, n) - 1] < clave)
            {
                prev = paso;
                paso += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) return -1;
            }
            for (int i = prev; i < Math.Min(paso, n); i++) if (arr[i] == clave) return i;
            return -1;
        }

        private static int BusquedaInterpolacion(int[] arr, int clave)
        {
            int lo = 0, hi = arr.Length - 1;
            while (lo <= hi && arr.Length > 0 && clave >= arr[lo] && clave <= arr[hi])
            {
                if (lo == hi) return arr[lo] == clave ? lo : -1;
                if (arr[hi] == arr[lo]) break; // evitar división por cero
                long pos = lo + ((long)(hi - lo) * (clave - arr[lo])) / (arr[hi] - arr[lo]);
                if (pos < lo || pos > hi) return -1;
                if (arr[pos] == clave) return (int)pos;
                if (arr[pos] < clave) lo = (int)pos + 1;
                else hi = (int)pos - 1;
            }
            return -1;
        }

        private static bool EstaOrdenado(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++) if (arr[i - 1] > arr[i]) return false;
            return true;
        }
    }
}
