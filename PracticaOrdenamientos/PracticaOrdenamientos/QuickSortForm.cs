using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PracticaOrdenamientos
{
    public partial class QuickSortForm : Form
    {
        public QuickSortForm()
        {
            InitializeComponent();
        }

        private void QuickSortForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var arr = Enumerable.Range(0, 12).Select(_ => rnd.Next(0, 100)).ToArray();
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
                MessageBox.Show("Valor incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstResult.Items.Clear();
            lstResult.Items.Add("Antes: " + string.Join(", ", arr));

            var sw = Stopwatch.StartNew();
            QuickSort(arr, 0, arr.Length - 1);
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

        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high);
                QuickSort(arr, low, p - 1);
                QuickSort(arr, p + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
            var tmp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tmp2;
            return i + 1;
        }
    }
}
