namespace FrmVector
{
    partial class FrmCadena
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.lblLetras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa una frase:";
            // 
            // tbTexto
            // 
            this.tbTexto.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTexto.Location = new System.Drawing.Point(26, 67);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(471, 28);
            this.tbTexto.TabIndex = 1;
            this.tbTexto.TextChanged += new System.EventHandler(this.tbTexto_TextChanged);
            // 
            // lblLetras
            // 
            this.lblLetras.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.Location = new System.Drawing.Point(26, 118);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(471, 38);
            this.lblLetras.TabIndex = 2;
            this.lblLetras.Text = "0 - 60";
            this.lblLetras.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadena";
            this.Text = "Cadenas de Texto";
            this.Load += new System.EventHandler(this.FrmCadena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Label lblLetras;
    }
}