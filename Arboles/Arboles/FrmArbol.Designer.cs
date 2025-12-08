namespace Arboles
{
    partial class FrmArbol
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
            this.tbNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArbol = new System.Windows.Forms.Button();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tbNodo
            // 
            this.tbNodo.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodo.Location = new System.Drawing.Point(111, 44);
            this.tbNodo.Name = "tbNodo";
            this.tbNodo.Size = new System.Drawing.Size(265, 28);
            this.tbNodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nodo:";
            // 
            // btnArbol
            // 
            this.btnArbol.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbol.Location = new System.Drawing.Point(398, 35);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(119, 37);
            this.btnArbol.TabIndex = 2;
            this.btnArbol.Text = "Agregar";
            this.btnArbol.UseVisualStyleBackColor = true;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // tvArbol
            // 
            this.tvArbol.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvArbol.Location = new System.Drawing.Point(44, 126);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(473, 279);
            this.tvArbol.TabIndex = 3;
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNodo);
            this.Name = "FrmArbol";
            this.Text = "FrmArbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.TreeView tvArbol;
    }
}