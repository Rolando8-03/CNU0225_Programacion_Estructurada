namespace FrmVector
{
    partial class FrmMatriz3x3
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
            this.tbDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDato
            // 
            this.tbDato.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDato.Location = new System.Drawing.Point(120, 63);
            this.tbDato.Name = "tbDato";
            this.tbDato.Size = new System.Drawing.Size(100, 27);
            this.tbDato.TabIndex = 0;
            this.tbDato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDato_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato:";
            // 
            // lblMatriz
            // 
            this.lblMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMatriz.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz.Location = new System.Drawing.Point(52, 117);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(168, 125);
            this.lblMatriz.TabIndex = 2;
            this.lblMatriz.Text = "Matriz";
            // 
            // FrmMatriz3x3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 323);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDato);
            this.Name = "FrmMatriz3x3";
            this.Text = "Matriz 3x3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatriz;
    }
}