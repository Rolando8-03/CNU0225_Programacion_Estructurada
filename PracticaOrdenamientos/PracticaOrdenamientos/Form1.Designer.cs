namespace PracticaOrdenamientos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ordenamientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ordenamientosToolStripMenuItem
            // 
            this.ordenamientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.selectionSortToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem,
            this.quickSortToolStripMenuItem});
            this.ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            this.ordenamientosToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bubbleSortToolStripMenuItem.Text = "Bubble Sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.bubbleSortToolStripMenuItem_Click);
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            this.selectionSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectionSortToolStripMenuItem.Text = "Selection Sort";
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.selectionSortToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertionSortToolStripMenuItem.Text = "Insertion Sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.insertionSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mergeSortToolStripMenuItem.Text = "Merge Sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quickSortToolStripMenuItem.Text = "Quick Sort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Practica de Ordenamientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
    }
}

