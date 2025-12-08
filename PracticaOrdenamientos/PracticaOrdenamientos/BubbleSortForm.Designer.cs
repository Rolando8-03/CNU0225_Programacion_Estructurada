namespace PracticaOrdenamientos
{
    partial class BubbleSortForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(16, 36);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(556, 22);
            this.txtArray.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(588, 33);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(92, 27);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(696, 33);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(92, 27);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(16, 74);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(772, 260);
            this.lstResult.TabIndex = 3;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 16);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(341, 16);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Ingrese números separados por una coma o un espacio";
            // 
            // BubbleSortForm
            // 
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtArray);
            this.Name = "BubbleSortForm";
            this.Text = "Bubble Sort";
            this.Load += new System.EventHandler(this.BubbleSortForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label lblInput;
    }
}