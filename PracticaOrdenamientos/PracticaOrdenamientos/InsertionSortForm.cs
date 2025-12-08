using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PracticaOrdenamientos
{
    public partial class InsertionSortForm : Form
    {
        public InsertionSortForm()
        {
            InitializeComponent();
        }

        private void InsertionSortForm_Load(object sender, EventArgs e)
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
            InsertionSort(arr);
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

        private void InsertionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }
        }
    }
}
