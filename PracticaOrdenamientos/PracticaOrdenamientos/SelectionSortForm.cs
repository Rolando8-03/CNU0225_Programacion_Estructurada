using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PracticaOrdenamientos
{
    public partial class SelectionSortForm : Form
    {
        public SelectionSortForm()
        {
            InitializeComponent();
        }

        private void SelectionSortForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var arr = Enumerable.Range(0, 10).Select(_ => rnd.Next(0, 100)).ToArray();
            txtArray.Text = string.Join(", ", arr);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arr;
            try
            {
                arr = ParseInput(txtArray.Text);
            }
            catch
            {
                MessageBox.Show("Valor incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstResult.Items.Clear();
            lstResult.Items.Add("Antes: " + string.Join(", ", arr));

            var sw = Stopwatch.StartNew();
            SelectionSort(arr);
            sw.Stop();

            lstResult.Items.Add("Después:  " + string.Join(", ", arr));
            lstResult.Items.Add($"Tiempo: {sw.ElapsedMilliseconds} ms");
        }

        private int[] ParseInput(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new Exception("Empty");
            var parts = text.Split(new[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Select(p => int.Parse(p.Trim())).ToArray();
        }

        private void SelectionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIdx]) minIdx = j;
                }
                var tmp = a[i];
                a[i] = a[minIdx];
                a[minIdx] = tmp;
            }
        }
    }
}
