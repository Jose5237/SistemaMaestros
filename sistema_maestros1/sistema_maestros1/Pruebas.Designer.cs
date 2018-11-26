namespace sistema_maestros1
{
    partial class Pruebas
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
            this.dgvPruebas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPruebas
            // 
            this.dgvPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPruebas.Location = new System.Drawing.Point(183, 111);
            this.dgvPruebas.Name = "dgvPruebas";
            this.dgvPruebas.Size = new System.Drawing.Size(439, 200);
            this.dgvPruebas.TabIndex = 1;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPruebas);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPruebas;
    }
}