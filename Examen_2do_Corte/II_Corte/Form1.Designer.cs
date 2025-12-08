namespace II_Corte
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el nombre del destinatario";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(21, 79);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(325, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el tipo de envio";
            // 
            // btnRegular
            // 
            this.btnRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegular.ForeColor = System.Drawing.Color.Lime;
            this.btnRegular.Location = new System.Drawing.Point(21, 185);
            this.btnRegular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(132, 58);
            this.btnRegular.TabIndex = 3;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnUrgente
            // 
            this.btnUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgente.ForeColor = System.Drawing.Color.Red;
            this.btnUrgente.Location = new System.Drawing.Point(161, 185);
            this.btnUrgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(132, 58);
            this.btnUrgente.TabIndex = 4;
            this.btnUrgente.Text = "Urgente";
            this.btnUrgente.UseVisualStyleBackColor = true;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // lbLista
            // 
            this.lbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 25;
            this.lbLista.Location = new System.Drawing.Point(440, 30);
            this.lbLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(379, 179);
            this.lbLista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnUrgente);
            this.Controls.Add(this.btnRegular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gestión de envios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.ListBox lbLista;
    }
}

