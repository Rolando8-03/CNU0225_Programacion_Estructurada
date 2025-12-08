namespace AnálisisProg
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenarMerge = new System.Windows.Forms.Button();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblTiempoIni = new System.Windows.Forms.Label();
            this.lblTiempoFin = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnOrdenarSelection = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarSaltos = new System.Windows.Forms.Button();
            this.btnBusquedaInterpolada = new System.Windows.Forms.Button();
            this.gbRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerar.Location = new System.Drawing.Point(54, 102);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(198, 51);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Números";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenarMerge
            // 
            this.btnOrdenarMerge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenarMerge.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenarMerge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOrdenarMerge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrdenarMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarMerge.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarMerge.ForeColor = System.Drawing.Color.Green;
            this.btnOrdenarMerge.Location = new System.Drawing.Point(270, 102);
            this.btnOrdenarMerge.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarMerge.Name = "btnOrdenarMerge";
            this.btnOrdenarMerge.Size = new System.Drawing.Size(200, 51);
            this.btnOrdenarMerge.TabIndex = 1;
            this.btnOrdenarMerge.Text = "Merge Sort";
            this.btnOrdenarMerge.UseVisualStyleBackColor = false;
            this.btnOrdenarMerge.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.lstOrdenada);
            this.gbRegistros.Controls.Add(this.lstDatos);
            this.gbRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRegistros.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistros.Location = new System.Drawing.Point(54, 177);
            this.gbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.gbRegistros.Size = new System.Drawing.Size(632, 432);
            this.gbRegistros.TabIndex = 2;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros: 0";
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.ItemHeight = 24;
            this.lstOrdenada.Location = new System.Drawing.Point(391, 56);
            this.lstOrdenada.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(215, 364);
            this.lstOrdenada.TabIndex = 1;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 24;
            this.lstDatos.Location = new System.Drawing.Point(33, 56);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(4);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(215, 364);
            this.lstDatos.TabIndex = 0;
            // 
            // lblTiempoIni
            // 
            this.lblTiempoIni.AutoSize = true;
            this.lblTiempoIni.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoIni.Location = new System.Drawing.Point(50, 726);
            this.lblTiempoIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoIni.Name = "lblTiempoIni";
            this.lblTiempoIni.Size = new System.Drawing.Size(296, 24);
            this.lblTiempoIni.TabIndex = 3;
            this.lblTiempoIni.Text = "Tiempo de Inicio: 00:00:00";
            // 
            // lblTiempoFin
            // 
            this.lblTiempoFin.AutoSize = true;
            this.lblTiempoFin.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFin.Location = new System.Drawing.Point(423, 726);
            this.lblTiempoFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoFin.Name = "lblTiempoFin";
            this.lblTiempoFin.Size = new System.Drawing.Size(263, 24);
            this.lblTiempoFin.TabIndex = 4;
            this.lblTiempoFin.Text = "Tiempo de Fin: 00:00:00";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(240, 764);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(230, 24);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración: 0 Segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de Registros:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCantidad.Location = new System.Drawing.Point(318, 39);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(368, 28);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOrdenarSelection
            // 
            this.btnOrdenarSelection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenarSelection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenarSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrdenarSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarSelection.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarSelection.ForeColor = System.Drawing.Color.Green;
            this.btnOrdenarSelection.Location = new System.Drawing.Point(488, 102);
            this.btnOrdenarSelection.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarSelection.Name = "btnOrdenarSelection";
            this.btnOrdenarSelection.Size = new System.Drawing.Size(198, 51);
            this.btnOrdenarSelection.TabIndex = 8;
            this.btnOrdenarSelection.Text = "Selection Sort";
            this.btnOrdenarSelection.UseVisualStyleBackColor = false;
            this.btnOrdenarSelection.Click += new System.EventHandler(this.btnOrdenarSelection_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbBuscar.Location = new System.Drawing.Point(145, 632);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(157, 28);
            this.tbBuscar.TabIndex = 9;
            this.tbBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 632);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // btnBuscarSaltos
            // 
            this.btnBuscarSaltos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarSaltos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarSaltos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscarSaltos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSaltos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuscarSaltos.Location = new System.Drawing.Point(336, 632);
            this.btnBuscarSaltos.Name = "btnBuscarSaltos";
            this.btnBuscarSaltos.Size = new System.Drawing.Size(152, 62);
            this.btnBuscarSaltos.TabIndex = 11;
            this.btnBuscarSaltos.Text = "Buscar por Saltos";
            this.btnBuscarSaltos.UseVisualStyleBackColor = false;
            this.btnBuscarSaltos.Click += new System.EventHandler(this.btnBuscarSaltos_Click);
            // 
            // btnBusquedaInterpolada
            // 
            this.btnBusquedaInterpolada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusquedaInterpolada.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBusquedaInterpolada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBusquedaInterpolada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaInterpolada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBusquedaInterpolada.Location = new System.Drawing.Point(534, 632);
            this.btnBusquedaInterpolada.Name = "btnBusquedaInterpolada";
            this.btnBusquedaInterpolada.Size = new System.Drawing.Size(152, 62);
            this.btnBusquedaInterpolada.TabIndex = 12;
            this.btnBusquedaInterpolada.Text = "Búsqueda Interpolada";
            this.btnBusquedaInterpolada.UseVisualStyleBackColor = false;
            this.btnBusquedaInterpolada.Click += new System.EventHandler(this.btnBusquedaInterpolada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 802);
            this.Controls.Add(this.btnBusquedaInterpolada);
            this.Controls.Add(this.btnBuscarSaltos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnOrdenarSelection);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblTiempoFin);
            this.Controls.Add(this.lblTiempoIni);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.btnOrdenarMerge);
            this.Controls.Add(this.btnGenerar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Eficiencia de Algoritmos";
            this.gbRegistros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenarMerge;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.Label lblTiempoIni;
        private System.Windows.Forms.Label lblTiempoFin;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.Button btnOrdenarSelection;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarSaltos;
        private System.Windows.Forms.Button btnBusquedaInterpolada;
    }
}

