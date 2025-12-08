using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TercerCorteApp
{
    // Todo en español y sencillo. Árbol ahora es no binario (cada nodo tiene lista de hijos).
    public partial class Form1 : Form
    {
        // Nodo no binario
        private class NodoArbol
        {
            public int Valor;
            public List<NodoArbol> Hijos;
            public NodoArbol(int v)
            {
                Valor = v;
                Hijos = new List<NodoArbol>();
            }
        }

        // Bosque simple: lista de nodos raíz (permite varios árboles)
        private class Bosque
        {
            public List<NodoArbol> Raices = new List<NodoArbol>();

            // Buscar nodo por valor (devuelve primer nodo encontrado)
            public NodoArbol Buscar(int valor)
            {
                foreach (var r in Raices)
                {
                    var encontrado = BuscarRec(r, valor);
                    if (encontrado != null) return encontrado;
                }
                return null;
            }

            private NodoArbol BuscarRec(NodoArbol actual, int valor)
            {
                if (actual == null) return null;
                if (actual.Valor == valor) return actual;
                foreach (var h in actual.Hijos)
                {
                    var res = BuscarRec(h, valor);
                    if (res != null) return res;
                }
                return null;
            }

            // Insertar: si padreValor es null o vacío -> añadir como nueva raíz
            public void Insertar(int valor, string padreTexto)
            {
                if (string.IsNullOrWhiteSpace(padreTexto))
                {
                    Raices.Add(new NodoArbol(valor));
                    return;
                }
                if (!int.TryParse(padreTexto.Trim(), out int padreVal))
                    throw new ArgumentException("Valor de padre inválido.");
                var padre = Buscar(padreVal);
                if (padre == null) throw new InvalidOperationException("Padre no encontrado.");
                padre.Hijos.Add(new NodoArbol(valor));
            }

            // Eliminar: elimina la primera ocurrencia del valor (subárbol entero)
            public bool Eliminar(int valor)
            {
                // revisar raíces
                for (int i = 0; i < Raices.Count; i++)
                {
                    if (Raices[i].Valor == valor)
                    {
                        Raices.RemoveAt(i);
                        return true;
                    }
                }
                // buscar padre del nodo a eliminar
                foreach (var r in Raices)
                {
                    if (EliminarRec(r, valor)) return true;
                }
                return false;
            }

            private bool EliminarRec(NodoArbol actual, int valor)
            {
                for (int i = 0; i < actual.Hijos.Count; i++)
                {
                    if (actual.Hijos[i].Valor == valor)
                    {
                        actual.Hijos.RemoveAt(i);
                        return true;
                    }
                    if (EliminarRec(actual.Hijos[i], valor)) return true;
                }
                return false;
            }

            // Recorridos simples (preorden para cada raíz)
            public List<int> PreOrden()
            {
                var res = new List<int>();
                foreach (var r in Raices) PreOrdenRec(r, res);
                return res;
            }
            private void PreOrdenRec(NodoArbol n, List<int> lista)
            {
                if (n == null) return;
                lista.Add(n.Valor);
                foreach (var h in n.Hijos) PreOrdenRec(h, lista);
            }

            public List<int> PostOrden()
            {
                var res = new List<int>();
                foreach (var r in Raices) PostOrdenRec(r, res);
                return res;
            }
            private void PostOrdenRec(NodoArbol n, List<int> lista)
            {
                if (n == null) return;
                foreach (var h in n.Hijos) PostOrdenRec(h, lista);
                lista.Add(n.Valor);
            }

            public List<int> Nivel(string orden)
            {
                // recorrido por niveles simple (BFS) concatenado por raíces
                var res = new List<int>();
                var cola = new Queue<NodoArbol>();
                foreach (var r in Raices) cola.Enqueue(r);
                while (cola.Count > 0)
                {
                    var cur = cola.Dequeue();
                    res.Add(cur.Valor);
                    foreach (var h in cur.Hijos) cola.Enqueue(h);
                }
                return res;
            }
        }

        private readonly Bosque bosque = new Bosque();
        private readonly Random rng = new Random();
        private List<int> listaActual = new List<int>();
        private NodoArbol nodoSimple = null;

        public Form1()
        {
            InitializeComponent();

            // asignar eventos de forma sencilla aquí
            pestanaArbol.Click += (s, e) => tabPrincipal.SelectedTab = tabArbol;
            pestanaNodo.Click += (s, e) => tabPrincipal.SelectedTab = tabNodo;
            pestanaLista.Click += (s, e) => tabPrincipal.SelectedTab = tabLista;

            btnInsertarArbol.Click += BtnInsertarArbol_Click;
            btnEliminarArbol.Click += BtnEliminarArbol_Click;
            btnBuscarArbol.Click += BtnBuscarArbol_Click;
            btnRefrescarArbol.Click += BtnRefrescarArbol_Click;

            btnCrearNodo.Click += BtnCrearNodo_Click;
            btnInspeccionarNodo.Click += BtnInspeccionarNodo_Click;

            btnGenerarLista.Click += BtnGenerarLista_Click;
            btnOrdenar.Click += BtnOrdenar_Click;
            btnBuscarLista.Click += BtnBuscarLista_Click;

            // inicializar combos
            comboOrdenar.SelectedIndex = 0;
            comboBuscar.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // forma desea simple: nada especial al cargar
        }

        // ---------- Árbol no binario (bosque) ----------
        private void BtnInsertarArbol_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtValorArbol.Text.Trim(), out int v))
                    throw new ArgumentException("Ingrese un entero válido.");
                bosque.Insertar(v, txtPadreArbol.Text);
                RefrescarVistaArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insertar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarArbol_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtValorArbol.Text.Trim(), out int v))
                    throw new ArgumentException("Ingrese un entero válido.");
                bool ok = bosque.Eliminar(v);
                if (!ok) MessageBox.Show("No se encontró el valor para eliminar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarVistaArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarArbol_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtValorArbol.Text.Trim(), out int v))
                    throw new ArgumentException("Ingrese un entero válido.");
                var sw = Stopwatch.StartNew();
                var nodo = bosque.Buscar(v);
                sw.Stop();
                lblDuracionArbol.Text = $"Duración: {sw.Elapsed.TotalMilliseconds:F4} ms";
                MessageBox.Show(nodo != null ? "Encontrado." : "No encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefrescarArbol_Click(object sender, EventArgs e)
        {
            RefrescarVistaArbol();
        }

        private void RefrescarVistaArbol()
        {
            try
            {
                treeViewArbol.BeginUpdate();
                treeViewArbol.Nodes.Clear();
                foreach (var raiz in bosque.Raices)
                {
                    var nodoUI = new TreeNode(raiz.Valor.ToString());
                    ConstruirNodoUI(raiz, nodoUI);
                    treeViewArbol.Nodes.Add(nodoUI);
                }
                treeViewArbol.EndUpdate();
                // mostrar recorridos simples
                txtRecorridos.Text = "PreOrden: " + string.Join(", ", bosque.PreOrden()) + Environment.NewLine
                                   + "PostOrden: " + string.Join(", ", bosque.PostOrden());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refrescar vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConstruirNodoUI(NodoArbol origen, TreeNode ui)
        {
            foreach (var h in origen.Hijos)
            {
                var hijo = new TreeNode(h.Valor.ToString());
                ui.Nodes.Add(hijo);
                ConstruirNodoUI(h, hijo);
            }
        }

        // ---------- Nodo simple ----------
        private void BtnCrearNodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtValorNodo.Text.Trim(), out int v))
                    throw new ArgumentException("Ingrese un entero válido.");
                nodoSimple = new NodoArbol(v);
                MessageBox.Show("Nodo creado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crear nodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInspeccionarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (nodoSimple == null) throw new InvalidOperationException("No hay nodo creado.");
                txtInfoNodo.Text = $"Valor: {nodoSimple.Valor}{Environment.NewLine}Hijos: {nodoSimple.Hijos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inspeccionar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Lista: generar, ordenar, buscar ----------
        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)numericCantidad.Value;
                if (cantidad <= 0) throw new ArgumentException("Cantidad debe ser mayor que 0.");
                listaActual = Enumerable.Range(0, cantidad).Select(_ => rng.Next(0, 100000)).ToList();
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generar lista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista()
        {
            listBoxNumeros.BeginUpdate();
            listBoxNumeros.Items.Clear();
            foreach (var v in listaActual) listBoxNumeros.Items.Add(v);
            listBoxNumeros.EndUpdate();
        }

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
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada.");
                        idx = BusquedaBinaria(arr, clave);
                        break;
                    case "Jump":
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada.");
                        idx = BusquedaJump(arr, clave);
                        break;
                    case "Interpolacion":
                        if (!EstaOrdenado(arr)) throw new InvalidOperationException("Lista debe estar ordenada.");
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

        // ---------- Algoritmos de ordenación (sencillos) ----------
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
            while (lo <= hi && clave >= arr[lo] && clave <= arr[hi])
            {
                if (lo == hi) return arr[lo] == clave ? lo : -1;
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
