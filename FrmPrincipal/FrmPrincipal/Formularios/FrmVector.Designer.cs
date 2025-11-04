namespace FrmPrincipal.Formularios
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
            this.tbEdades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbEdades
            // 
            this.tbEdades.Location = new System.Drawing.Point(199, 77);
            this.tbEdades.Name = "tbEdades";
            this.tbEdades.Size = new System.Drawing.Size(100, 22);
            this.tbEdades.TabIndex = 0;
            this.tbEdades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdades_KeyDown);
            // 
            // FrmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tbEdades);
            this.Name = "FrmVector";
            this.Text = "FrmVector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEdades;
    }
}