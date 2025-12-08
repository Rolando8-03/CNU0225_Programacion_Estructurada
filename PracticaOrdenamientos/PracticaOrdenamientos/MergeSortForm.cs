using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PracticaOrdenamientos
{
    public partial class MergeSortForm : Form
    {
        public MergeSortForm()
        {
            InitializeComponent();
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
            arr = MergeSort(arr);
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

        private int[] MergeSort(int[] a)
        {
            if (a.Length <= 1) return a;
            int mid = a.Length / 2;
            var left = MergeSort(a.Take(mid).ToArray());
            var right = MergeSort(a.Skip(mid).ToArray());
            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int i = 0, j = 0;
            var res = new int[left.Length + right.Length];
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j]) res[k++] = left[i++];
                else res[k++] = right[j++];
            }
            while (i < left.Length) res[k++] = left[i++];
            while (j < right.Length) res[k++] = right[j++];
            return res;
        }

        private void MergeSortForm_Load(object sender, EventArgs e)
        {

        }
    }
}
