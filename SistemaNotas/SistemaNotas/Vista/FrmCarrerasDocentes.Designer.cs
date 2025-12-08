namespace SistemaNotas.Vista
{
    partial class FrmCarrerasDocentes
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
            this.tvCarreras = new System.Windows.Forms.TreeView();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvCarreras
            // 
            this.tvCarreras.Location = new System.Drawing.Point(17, 18);
            this.tvCarreras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvCarreras.Name = "tvCarreras";
            this.tvCarreras.Size = new System.Drawing.Size(217, 339);
            this.tvCarreras.TabIndex = 0;
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.Location = new System.Drawing.Point(354, 18);
            this.lbDocentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(235, 329);
            this.lbDocentes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCarrerasDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.tvCarreras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCarrerasDocentes";
            this.Text = "Carreras - Docentes";
            this.Load += new System.EventHandler(this.FrmCarrerasDocentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvCarreras;
        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.Button button1;
    }
}