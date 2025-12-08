namespace TercerCorteApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles - Lista
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.ComboBox comboOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblDuracionOrden;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.TextBox txtValorBuscar;
        private System.Windows.Forms.Button btnBuscarLista;
        private System.Windows.Forms.Label lblDuracionBusqueda;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.comboOrdenar = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblDuracionOrden = new System.Windows.Forms.Label();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.txtValorBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarLista = new System.Windows.Forms.Button();
            this.lblDuracionBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(332, 23);
            this.numericCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(210, 28);
            this.numericCantidad.TabIndex = 0;
            this.numericCantidad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(577, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(127, 37);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.ItemHeight = 24;
            this.listBoxNumeros.Location = new System.Drawing.Point(24, 23);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(279, 364);
            this.listBoxNumeros.TabIndex = 2;
            // 
            // comboOrdenar
            // 
            this.comboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrdenar.Items.AddRange(new object[] {
            "Selection",
            "Quick",
            "Merge",
            "Insertion"});
            this.comboOrdenar.Location = new System.Drawing.Point(332, 86);
            this.comboOrdenar.Name = "comboOrdenar";
            this.comboOrdenar.Size = new System.Drawing.Size(210, 32);
            this.comboOrdenar.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(577, 81);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(127, 37);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            // 
            // lblDuracionOrden
            // 
            this.lblDuracionOrden.Location = new System.Drawing.Point(328, 135);
            this.lblDuracionOrden.Name = "lblDuracionOrden";
            this.lblDuracionOrden.Size = new System.Drawing.Size(300, 23);
            this.lblDuracionOrden.TabIndex = 5;
            this.lblDuracionOrden.Text = "Duración orden: -";
            // 
            // comboBuscar
            // 
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.Items.AddRange(new object[] {
            "Secuencial",
            "Binaria",
            "Jump",
            "Interpolacion"});
            this.comboBuscar.Location = new System.Drawing.Point(332, 190);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(210, 32);
            this.comboBuscar.TabIndex = 6;
            // 
            // txtValorBuscar
            // 
            this.txtValorBuscar.Location = new System.Drawing.Point(577, 190);
            this.txtValorBuscar.Name = "txtValorBuscar";
            this.txtValorBuscar.Size = new System.Drawing.Size(127, 28);
            this.txtValorBuscar.TabIndex = 7;
            // 
            // btnBuscarLista
            // 
            this.btnBuscarLista.Location = new System.Drawing.Point(732, 183);
            this.btnBuscarLista.Name = "btnBuscarLista";
            this.btnBuscarLista.Size = new System.Drawing.Size(127, 37);
            this.btnBuscarLista.TabIndex = 8;
            this.btnBuscarLista.Text = "Buscar";
            // 
            // lblDuracionBusqueda
            // 
            this.lblDuracionBusqueda.Location = new System.Drawing.Point(328, 254);
            this.lblDuracionBusqueda.Name = "lblDuracionBusqueda";
            this.lblDuracionBusqueda.Size = new System.Drawing.Size(300, 23);
            this.lblDuracionBusqueda.TabIndex = 9;
            this.lblDuracionBusqueda.Text = "Duración búsqueda: -";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(877, 423);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.comboOrdenar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblDuracionOrden);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.txtValorBuscar);
            this.Controls.Add(this.btnBuscarLista);
            this.Controls.Add(this.lblDuracionBusqueda);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Ordenamientos y Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}