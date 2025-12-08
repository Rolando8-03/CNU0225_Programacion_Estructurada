namespace FrmVector
{
    partial class FrmPrincipal
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
            this.bloqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloqueToolStripMenuItem,
            this.arreglosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bloqueToolStripMenuItem
            // 
            this.bloqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salieToolStripMenuItem});
            this.bloqueToolStripMenuItem.Name = "bloqueToolStripMenuItem";
            this.bloqueToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.bloqueToolStripMenuItem.Text = "Archivo";
            this.bloqueToolStripMenuItem.Click += new System.EventHandler(this.bloqueToolStripMenuItem_Click);
            // 
            // salieToolStripMenuItem
            // 
            this.salieToolStripMenuItem.Name = "salieToolStripMenuItem";
            this.salieToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salieToolStripMenuItem.Text = "Salir";
            this.salieToolStripMenuItem.Click += new System.EventHandler(this.salieToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vectorToolStripMenuItem,
            this.matrizToolStripMenuItem});
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vectorToolStripMenuItem.Text = "Vector";
            this.vectorToolStripMenuItem.Click += new System.EventHandler(this.vectorToolStripMenuItem_Click);
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem,
            this.cadenaToolStripMenuItem});
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.matrizToolStripMenuItem.Text = "Matriz";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x2ToolStripMenuItem.Text = "2 x 2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x3ToolStripMenuItem.Text = "3 x 3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // cadenaToolStripMenuItem
            // 
            this.cadenaToolStripMenuItem.Name = "cadenaToolStripMenuItem";
            this.cadenaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadenaToolStripMenuItem.Text = "Cadena";
            this.cadenaToolStripMenuItem.Click += new System.EventHandler(this.cadenaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bloqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadenaToolStripMenuItem;
    }
}

