namespace sistema_maestros1
{
    partial class ModuloActualizacionMasivaAlumnos
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
            this.cbEscuela = new System.Windows.Forms.ComboBox();
            this.cbNivelEducativo = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.btnActualizarGrado = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdEscuela = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEscuela
            // 
            this.cbEscuela.FormattingEnabled = true;
            this.cbEscuela.Location = new System.Drawing.Point(127, 93);
            this.cbEscuela.Name = "cbEscuela";
            this.cbEscuela.Size = new System.Drawing.Size(121, 21);
            this.cbEscuela.TabIndex = 0;
            this.cbEscuela.Text = "Seleccionar Escuela";
            this.cbEscuela.SelectedIndexChanged += new System.EventHandler(this.cbEscuela_SelectedIndexChanged);
            // 
            // cbNivelEducativo
            // 
            this.cbNivelEducativo.FormattingEnabled = true;
            this.cbNivelEducativo.Items.AddRange(new object[] {
            "PRESCOLAR",
            "PRIMARIA",
            "SECUNDARIA"});
            this.cbNivelEducativo.Location = new System.Drawing.Point(127, 147);
            this.cbNivelEducativo.Name = "cbNivelEducativo";
            this.cbNivelEducativo.Size = new System.Drawing.Size(121, 21);
            this.cbNivelEducativo.TabIndex = 1;
            this.cbNivelEducativo.Text = "Seleccionar Nivel Educativo";
            this.cbNivelEducativo.SelectedIndexChanged += new System.EventHandler(this.cbNivelEducativo_SelectedIndexChanged);
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(127, 205);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 21);
            this.cbGrado.TabIndex = 2;
            this.cbGrado.Text = "Seleccionar Grado";
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // btnActualizarGrado
            // 
            this.btnActualizarGrado.Location = new System.Drawing.Point(99, 332);
            this.btnActualizarGrado.Name = "btnActualizarGrado";
            this.btnActualizarGrado.Size = new System.Drawing.Size(108, 23);
            this.btnActualizarGrado.TabIndex = 4;
            this.btnActualizarGrado.Text = "Pasar de grado";
            this.btnActualizarGrado.UseVisualStyleBackColor = true;
            this.btnActualizarGrado.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(293, 64);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(469, 321);
            this.dgvAlumnos.TabIndex = 5;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(212, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdEscuela
            // 
            this.txtIdEscuela.Location = new System.Drawing.Point(176, 72);
            this.txtIdEscuela.Name = "txtIdEscuela";
            this.txtIdEscuela.Size = new System.Drawing.Size(72, 20);
            this.txtIdEscuela.TabIndex = 9;
            // 
            // ModuloActualizacionMasivaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdEscuela);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnActualizarGrado);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.cbNivelEducativo);
            this.Controls.Add(this.cbEscuela);
            this.Name = "ModuloActualizacionMasivaAlumnos";
            this.Text = "ModuloActualizacionMasivaAlumnos";
            this.Load += new System.EventHandler(this.ModuloActualizacionMasivaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEscuela;
        private System.Windows.Forms.ComboBox cbNivelEducativo;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Button btnActualizarGrado;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdEscuela;
    }
}