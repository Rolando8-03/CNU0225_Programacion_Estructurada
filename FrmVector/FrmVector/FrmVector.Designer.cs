namespace FrmVector
{
    partial class FrmVector
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
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.pgbNumeros = new System.Windows.Forms.ProgressBar();
            this.lblNumeros2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNumeros
            // 
            this.tbNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeros.Location = new System.Drawing.Point(129, 49);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(100, 28);
            this.tbNumeros.TabIndex = 1;
            this.tbNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumeros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumeros_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Números Mayores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Números Agregados";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(227, 112);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(2, 26);
            this.lblNumeros.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(227, 178);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(2, 26);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Click += new System.EventHandler(this.label5_Click);
            // 
            // pgbNumeros
            // 
            this.pgbNumeros.Location = new System.Drawing.Point(227, 230);
            this.pgbNumeros.Name = "pgbNumeros";
            this.pgbNumeros.Size = new System.Drawing.Size(201, 23);
            this.pgbNumeros.TabIndex = 7;
            // 
            // lblNumeros2
            // 
            this.lblNumeros2.AutoSize = true;
            this.lblNumeros2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNumeros2.Location = new System.Drawing.Point(434, 228);
            this.lblNumeros2.Name = "lblNumeros2";
            this.lblNumeros2.Size = new System.Drawing.Size(2, 26);
            this.lblNumeros2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(22, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "⚠️ Nota: Solo puedes agregar 10 números en total. ⚠️";
            // 
            // FrmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumeros2);
            this.Controls.Add(this.pgbNumeros);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumeros);
            this.Controls.Add(this.label1);
            this.Name = "FrmVector";
            this.Text = "FrmVector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ProgressBar pgbNumeros;
        private System.Windows.Forms.Label lblNumeros2;
        private System.Windows.Forms.Label label5;
    }
}