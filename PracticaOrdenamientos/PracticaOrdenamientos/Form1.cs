using System;
using System.Windows.Forms;

namespace PracticaOrdenamientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BubbleSortForm();
            f.Show();
        }

        private void selectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SelectionSortForm();
            f.Show();
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new InsertionSortForm();
            f.Show();
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new MergeSortForm();
            f.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QuickSortForm();
            f.Show();
        }
    }
}
