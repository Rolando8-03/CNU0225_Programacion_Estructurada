namespace Productos.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.pbCapacidad = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMayores = new System.Windows.Forms.Label();
            this.lblMayores1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMenores = new System.Windows.Forms.Label();
            this.pbMayores = new System.Windows.Forms.ProgressBar();
            this.pbMenores = new System.Windows.Forms.ProgressBar();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Location = new System.Drawing.Point(12, 12);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(214, 426);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(69, 322);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.ItemHeight = 16;
            this.lbEdades.Location = new System.Drawing.Point(26, 125);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(146, 180);
            this.lbEdades.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edad:";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(72, 52);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 22);
            this.tbEdad.TabIndex = 0;
            this.tbEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // pbCapacidad
            // 
            this.pbCapacidad.Location = new System.Drawing.Point(264, 32);
            this.pbCapacidad.Name = "pbCapacidad";
            this.pbCapacidad.Size = new System.Drawing.Size(307, 23);
            this.pbCapacidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Mayores de Edad: ";
            // 
            // lblMayores
            // 
            this.lblMayores.AutoSize = true;
            this.lblMayores.Location = new System.Drawing.Point(464, 111);
            this.lblMayores.Name = "lblMayores";
            this.lblMayores.Size = new System.Drawing.Size(0, 16);
            this.lblMayores.TabIndex = 3;
            // 
            // lblMayores1
            // 
            this.lblMayores1.AutoSize = true;
            this.lblMayores1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayores1.Location = new System.Drawing.Point(465, 111);
            this.lblMayores1.Name = "lblMayores1";
            this.lblMayores1.Size = new System.Drawing.Size(2, 18);
            this.lblMayores1.TabIndex = 4;
            this.lblMayores1.Click += new System.EventHandler(this.lblMayores1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Menores de Edad: ";
            // 
            // lblMenores
            // 
            this.lblMenores.AutoSize = true;
            this.lblMenores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenores.Location = new System.Drawing.Point(464, 204);
            this.lblMenores.Name = "lblMenores";
            this.lblMenores.Size = new System.Drawing.Size(2, 18);
            this.lblMenores.TabIndex = 6;
            // 
            // pbMayores
            // 
            this.pbMayores.Location = new System.Drawing.Point(264, 149);
            this.pbMayores.Name = "pbMayores";
            this.pbMayores.Size = new System.Drawing.Size(307, 23);
            this.pbMayores.TabIndex = 7;
            // 
            // pbMenores
            // 
            this.pbMenores.Location = new System.Drawing.Point(264, 245);
            this.pbMenores.Name = "pbMenores";
            this.pbMenores.Size = new System.Drawing.Size(307, 23);
            this.pbMenores.TabIndex = 8;
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.pbMenores);
            this.Controls.Add(this.pbMayores);
            this.Controls.Add(this.lblMenores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMayores1);
            this.Controls.Add(this.lblMayores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCapacidad);
            this.Controls.Add(this.gbEdades);
            this.Name = "FrmArreglo";
            this.Text = "Arreglo";
            this.Load += new System.EventHandler(this.FrmArreglo_Load);
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ProgressBar pbCapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMayores;
        private System.Windows.Forms.Label lblMayores1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMenores;
        private System.Windows.Forms.ProgressBar pbMayores;
        private System.Windows.Forms.ProgressBar pbMenores;
    }
}