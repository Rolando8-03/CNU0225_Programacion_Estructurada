namespace FrmVector
{
    partial class FrmMatriz2x2
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
            this.tbDatos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato:";
            // 
            // tbDatos
            // 
            this.tbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbDatos.Location = new System.Drawing.Point(125, 76);
            this.tbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Size = new System.Drawing.Size(88, 28);
            this.tbDatos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(68, 114);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMatriz.Location = new System.Drawing.Point(68, 164);
            this.lblMatriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(145, 146);
            this.lblMatriz.TabIndex = 3;
            this.lblMatriz.Text = "Matriz";
            // 
            // FrmMatriz2x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 343);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMatriz2x2";
            this.Text = "Matriz 2x2";
            this.Load += new System.EventHandler(this.FrmMatriz2x2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMatriz;
    }
}