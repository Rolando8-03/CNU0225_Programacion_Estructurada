namespace Monto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcularRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(145, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 69);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Monto con IVA";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(145, 65);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(167, 22);
            this.tbPrecio.TabIndex = 2;
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMonto
            // 
            this.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonto.Location = new System.Drawing.Point(93, 313);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(219, 97);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcularRef
            // 
            this.btnCalcularRef.Location = new System.Drawing.Point(145, 221);
            this.btnCalcularRef.Name = "btnCalcularRef";
            this.btnCalcularRef.Size = new System.Drawing.Size(167, 69);
            this.btnCalcularRef.TabIndex = 4;
            this.btnCalcularRef.Text = "Calcular Monto con IVA_REF";
            this.btnCalcularRef.UseVisualStyleBackColor = true;
            this.btnCalcularRef.Click += new System.EventHandler(this.btnCalcularRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.btnCalcularRef);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Monto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCalcularRef;
    }
}

