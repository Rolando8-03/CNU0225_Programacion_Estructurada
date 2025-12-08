namespace TercerCorteApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Menu y pestañas
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuPestanas;
        private System.Windows.Forms.ToolStripMenuItem pestanaArbol;
        private System.Windows.Forms.ToolStripMenuItem pestanaNodo;
        private System.Windows.Forms.ToolStripMenuItem pestanaLista;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabArbol;
        private System.Windows.Forms.TabPage tabNodo;
        private System.Windows.Forms.TabPage tabLista;

        // Controles - Árbol (no binario)
        private System.Windows.Forms.TextBox txtValorArbol;
        private System.Windows.Forms.TextBox txtPadreArbol;
        private System.Windows.Forms.Button btnInsertarArbol;
        private System.Windows.Forms.Button btnEliminarArbol;
        private System.Windows.Forms.Button btnBuscarArbol;
        private System.Windows.Forms.Button btnRefrescarArbol;
        private System.Windows.Forms.TreeView treeViewArbol;
        private System.Windows.Forms.TextBox txtRecorridos;
        private System.Windows.Forms.Label lblDuracionArbol;

        // Controles - Nodo
        private System.Windows.Forms.TextBox txtValorNodo;
        private System.Windows.Forms.Button btnCrearNodo;
        private System.Windows.Forms.Button btnInspeccionarNodo;
        private System.Windows.Forms.TextBox txtInfoNodo;

        // Controles - Lista
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Button btnGenerarLista;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.ComboBox comboOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblDuracionOrden;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.TextBox txtValorBuscar;
        private System.Windows.Forms.Button btnBuscarLista;
        private System.Windows.Forms.Label lblDuracionBusqueda;

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
            this.components = new System.ComponentModel.Container();

            // menu
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPestanas = new System.Windows.Forms.ToolStripMenuItem();
            this.pestanaArbol = new System.Windows.Forms.ToolStripMenuItem();
            this.pestanaNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.pestanaLista = new System.Windows.Forms.ToolStripMenuItem();

            this.menuPestanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.pestanaArbol, this.pestanaNodo, this.pestanaLista
            });
            this.menuPestanas.Text = "Pestañas";
            this.pestanaArbol.Text = "Árbol";
            this.pestanaNodo.Text = "Nodo";
            this.pestanaLista.Text = "Lista";

            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuPestanas });
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(984, 24);

            // tabControl
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabArbol = new System.Windows.Forms.TabPage();
            this.tabNodo = new System.Windows.Forms.TabPage();
            this.tabLista = new System.Windows.Forms.TabPage();

            this.tabPrincipal.Location = new System.Drawing.Point(12, 36);
            this.tabPrincipal.Size = new System.Drawing.Size(960, 600);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabArbol, this.tabNodo, this.tabLista
            });

            // --- Tab Árbol ---
            this.tabArbol.Text = "Árbol";
            this.txtValorArbol = new System.Windows.Forms.TextBox();
            this.txtPadreArbol = new System.Windows.Forms.TextBox();
            this.btnInsertarArbol = new System.Windows.Forms.Button();
            this.btnEliminarArbol = new System.Windows.Forms.Button();
            this.btnBuscarArbol = new System.Windows.Forms.Button();
            this.btnRefrescarArbol = new System.Windows.Forms.Button();
            this.treeViewArbol = new System.Windows.Forms.TreeView();
            this.txtRecorridos = new System.Windows.Forms.TextBox();
            this.lblDuracionArbol = new System.Windows.Forms.Label();

            this.txtValorArbol.Location = new System.Drawing.Point(16, 16);
            this.txtValorArbol.Size = new System.Drawing.Size(100, 22);
            this.txtValorArbol.Name = "txtValorArbol";
            this.txtValorArbol.Text = "";

            this.txtPadreArbol.Location = new System.Drawing.Point(130, 16);
            this.txtPadreArbol.Size = new System.Drawing.Size(100, 22);
            this.txtPadreArbol.Name = "txtPadreArbol";
            this.txtPadreArbol.Text = ""; // si se deja vacío se añade como hijo de raíz

            this.btnInsertarArbol.Location = new System.Drawing.Point(246, 14);
            this.btnInsertarArbol.Size = new System.Drawing.Size(80, 26);
            this.btnInsertarArbol.Text = "Insertar";
            this.btnInsertarArbol.Name = "btnInsertarArbol";

            this.btnEliminarArbol.Location = new System.Drawing.Point(334, 14);
            this.btnEliminarArbol.Size = new System.Drawing.Size(80, 26);
            this.btnEliminarArbol.Text = "Eliminar";
            this.btnEliminarArbol.Name = "btnEliminarArbol";

            this.btnBuscarArbol.Location = new System.Drawing.Point(422, 14);
            this.btnBuscarArbol.Size = new System.Drawing.Size(80, 26);
            this.btnBuscarArbol.Text = "Buscar";
            this.btnBuscarArbol.Name = "btnBuscarArbol";

            this.btnRefrescarArbol.Location = new System.Drawing.Point(510, 14);
            this.btnRefrescarArbol.Size = new System.Drawing.Size(80, 26);
            this.btnRefrescarArbol.Text = "Refrescar";
            this.btnRefrescarArbol.Name = "btnRefrescarArbol";

            this.treeViewArbol.Location = new System.Drawing.Point(16, 50);
            this.treeViewArbol.Size = new System.Drawing.Size(500, 520);
            this.treeViewArbol.Name = "treeViewArbol";

            this.txtRecorridos.Location = new System.Drawing.Point(530, 50);
            this.txtRecorridos.Size = new System.Drawing.Size(400, 420);
            this.txtRecorridos.Multiline = true;
            this.txtRecorridos.ReadOnly = true;

            this.lblDuracionArbol.Location = new System.Drawing.Point(530, 480);
            this.lblDuracionArbol.Size = new System.Drawing.Size(400, 23);
            this.lblDuracionArbol.Text = "Duración: -";

            this.tabArbol.Controls.Add(this.txtValorArbol);
            this.tabArbol.Controls.Add(this.txtPadreArbol);
            this.tabArbol.Controls.Add(this.btnInsertarArbol);
            this.tabArbol.Controls.Add(this.btnEliminarArbol);
            this.tabArbol.Controls.Add(this.btnBuscarArbol);
            this.tabArbol.Controls.Add(this.btnRefrescarArbol);
            this.tabArbol.Controls.Add(this.treeViewArbol);
            this.tabArbol.Controls.Add(this.txtRecorridos);
            this.tabArbol.Controls.Add(this.lblDuracionArbol);

            // --- Tab Nodo ---
            this.tabNodo.Text = "Nodo";
            this.txtValorNodo = new System.Windows.Forms.TextBox();
            this.btnCrearNodo = new System.Windows.Forms.Button();
            this.btnInspeccionarNodo = new System.Windows.Forms.Button();
            this.txtInfoNodo = new System.Windows.Forms.TextBox();

            this.txtValorNodo.Location = new System.Drawing.Point(16, 16);
            this.txtValorNodo.Size = new System.Drawing.Size(100, 22);

            this.btnCrearNodo.Location = new System.Drawing.Point(130, 14);
            this.btnCrearNodo.Size = new System.Drawing.Size(100, 26);
            this.btnCrearNodo.Text = "Crear nodo";

            this.btnInspeccionarNodo.Location = new System.Drawing.Point(240, 14);
            this.btnInspeccionarNodo.Size = new System.Drawing.Size(100, 26);
            this.btnInspeccionarNodo.Text = "Inspeccionar";

            this.txtInfoNodo.Location = new System.Drawing.Point(16, 50);
            this.txtInfoNodo.Size = new System.Drawing.Size(914, 520);
            this.txtInfoNodo.Multiline = true;
            this.txtInfoNodo.ReadOnly = true;

            this.tabNodo.Controls.Add(this.txtValorNodo);
            this.tabNodo.Controls.Add(this.btnCrearNodo);
            this.tabNodo.Controls.Add(this.btnInspeccionarNodo);
            this.tabNodo.Controls.Add(this.txtInfoNodo);

            // --- Tab Lista ---
            this.tabLista.Text = "Lista";
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.comboOrdenar = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblDuracionOrden = new System.Windows.Forms.Label();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.txtValorBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarLista = new System.Windows.Forms.Button();
            this.lblDuracionBusqueda = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();

            this.numericCantidad.Location = new System.Drawing.Point(16, 16);
            this.numericCantidad.Minimum = 1;
            this.numericCantidad.Maximum = 1000000;
            this.numericCantidad.Value = 50;
            this.numericCantidad.Size = new System.Drawing.Size(100, 22);

            this.btnGenerarLista.Location = new System.Drawing.Point(130, 14);
            this.btnGenerarLista.Size = new System.Drawing.Size(100, 26);
            this.btnGenerarLista.Text = "Generar";

            this.listBoxNumeros.Location = new System.Drawing.Point(16, 50);
            this.listBoxNumeros.Size = new System.Drawing.Size(400, 520);

            this.comboOrdenar.Location = new System.Drawing.Point(430, 50);
            this.comboOrdenar.Size = new System.Drawing.Size(200, 24);
            this.comboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrdenar.Items.AddRange(new object[] { "Selection", "Quick", "Merge", "Insertion" });

            this.btnOrdenar.Location = new System.Drawing.Point(640, 50);
            this.btnOrdenar.Size = new System.Drawing.Size(100, 26);
            this.btnOrdenar.Text = "Ordenar";

            this.lblDuracionOrden.Location = new System.Drawing.Point(430, 90);
            this.lblDuracionOrden.Size = new System.Drawing.Size(300, 23);
            this.lblDuracionOrden.Text = "Duración orden: -";

            this.comboBuscar.Location = new System.Drawing.Point(430, 130);
            this.comboBuscar.Size = new System.Drawing.Size(200, 24);
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.Items.AddRange(new object[] { "Secuencial", "Binaria", "Jump", "Interpolacion" });

            this.txtValorBuscar.Location = new System.Drawing.Point(640, 130);
            this.txtValorBuscar.Size = new System.Drawing.Size(100, 22);

            this.btnBuscarLista.Location = new System.Drawing.Point(750, 128);
            this.btnBuscarLista.Size = new System.Drawing.Size(80, 26);
            this.btnBuscarLista.Text = "Buscar";

            this.lblDuracionBusqueda.Location = new System.Drawing.Point(430, 170);
            this.lblDuracionBusqueda.Size = new System.Drawing.Size(300, 23);
            this.lblDuracionBusqueda.Text = "Duración búsqueda: -";

            this.tabLista.Controls.Add(this.numericCantidad);
            this.tabLista.Controls.Add(this.btnGenerarLista);
            this.tabLista.Controls.Add(this.listBoxNumeros);
            this.tabLista.Controls.Add(this.comboOrdenar);
            this.tabLista.Controls.Add(this.btnOrdenar);
            this.tabLista.Controls.Add(this.lblDuracionOrden);
            this.tabLista.Controls.Add(this.comboBuscar);
            this.tabLista.Controls.Add(this.txtValorBuscar);
            this.tabLista.Controls.Add(this.btnBuscarLista);
            this.tabLista.Controls.Add(this.lblDuracionBusqueda);

            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();

            // Form
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Text = "TercerCorteApp - Sencillo";
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion
    }
}

