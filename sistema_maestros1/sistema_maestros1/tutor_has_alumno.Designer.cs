namespace sistema_maestros1
{
    partial class tutor_has_alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tutor_has_alumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscadorPadre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvAhT = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtIdEscuela = new System.Windows.Forms.TextBox();
            this.dgvAhasTAll = new System.Windows.Forms.DataGridView();
            this.txtIDAlumno2 = new System.Windows.Forms.TextBox();
            this.txtIDEscuela2 = new System.Windows.Forms.TextBox();
            this.txtIDPadre2 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPadre2 = new System.Windows.Forms.TextBox();
            this.txtAlumno2 = new System.Windows.Forms.TextBox();
            this.txtEscuela2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhasTAll)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Enabled = false;
            this.txtNombreAlumno.Location = new System.Drawing.Point(72, 43);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(200, 20);
            this.txtNombreAlumno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Padre:";
            // 
            // txtBuscadorPadre
            // 
            this.txtBuscadorPadre.Location = new System.Drawing.Point(72, 75);
            this.txtBuscadorPadre.Name = "txtBuscadorPadre";
            this.txtBuscadorPadre.Size = new System.Drawing.Size(179, 20);
            this.txtBuscadorPadre.TabIndex = 2;
            this.txtBuscadorPadre.TextChanged += new System.EventHandler(this.txtBuscadorPadre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTutor
            // 
            this.dgvTutor.AllowUserToAddRows = false;
            this.dgvTutor.AllowUserToDeleteRows = false;
            this.dgvTutor.AllowUserToOrderColumns = true;
            this.dgvTutor.AllowUserToResizeColumns = false;
            this.dgvTutor.AllowUserToResizeRows = false;
            this.dgvTutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutor.EnableHeadersVisualStyles = false;
            this.dgvTutor.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvTutor.Location = new System.Drawing.Point(15, 101);
            this.dgvTutor.MultiSelect = false;
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.ReadOnly = true;
            this.dgvTutor.RowHeadersVisible = false;
            this.dgvTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutor.Size = new System.Drawing.Size(388, 191);
            this.dgvTutor.TabIndex = 86;
            this.dgvTutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutor_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(410, 166);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 27);
            this.btnAgregar.TabIndex = 87;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(410, 199);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(30, 27);
            this.btnQuitar.TabIndex = 88;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvAhT
            // 
            this.dgvAhT.AllowUserToAddRows = false;
            this.dgvAhT.AllowUserToDeleteRows = false;
            this.dgvAhT.AllowUserToOrderColumns = true;
            this.dgvAhT.AllowUserToResizeColumns = false;
            this.dgvAhT.AllowUserToResizeRows = false;
            this.dgvAhT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAhT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAhT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAhT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAhT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhT.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAhT.Location = new System.Drawing.Point(446, 101);
            this.dgvAhT.Name = "dgvAhT";
            this.dgvAhT.ReadOnly = true;
            this.dgvAhT.RowHeadersVisible = false;
            this.dgvAhT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAhT.Size = new System.Drawing.Size(390, 191);
            this.dgvAhT.TabIndex = 89;
            this.dgvAhT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAhT_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(273, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 26);
            this.label3.TabIndex = 90;
            this.label3.Text = "Asignar Padres o Tutor a Alumno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(206, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(211, 30);
            this.btnAceptar.TabIndex = 91;
            this.btnAceptar.Text = "GUARDAR ✔";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(819, 4);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 25);
            this.exit.TabIndex = 92;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Enabled = false;
            this.txtIdAlumno.Location = new System.Drawing.Point(278, 43);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlumno.TabIndex = 93;
            this.txtIdAlumno.Visible = false;
            // 
            // txtIdEscuela
            // 
            this.txtIdEscuela.Enabled = false;
            this.txtIdEscuela.Location = new System.Drawing.Point(379, 43);
            this.txtIdEscuela.Name = "txtIdEscuela";
            this.txtIdEscuela.Size = new System.Drawing.Size(100, 20);
            this.txtIdEscuela.TabIndex = 94;
            this.txtIdEscuela.Visible = false;
            // 
            // dgvAhasTAll
            // 
            this.dgvAhasTAll.AllowUserToAddRows = false;
            this.dgvAhasTAll.AllowUserToDeleteRows = false;
            this.dgvAhasTAll.AllowUserToOrderColumns = true;
            this.dgvAhasTAll.AllowUserToResizeColumns = false;
            this.dgvAhasTAll.AllowUserToResizeRows = false;
            this.dgvAhasTAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAhasTAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAhasTAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAhasTAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAhasTAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhasTAll.Location = new System.Drawing.Point(12, 337);
            this.dgvAhasTAll.MultiSelect = false;
            this.dgvAhasTAll.Name = "dgvAhasTAll";
            this.dgvAhasTAll.ReadOnly = true;
            this.dgvAhasTAll.RowHeadersVisible = false;
            this.dgvAhasTAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAhasTAll.Size = new System.Drawing.Size(631, 191);
            this.dgvAhasTAll.TabIndex = 95;
            this.dgvAhasTAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAhasTAll_CellContentClick);
            // 
            // txtIDAlumno2
            // 
            this.txtIDAlumno2.Enabled = false;
            this.txtIDAlumno2.Location = new System.Drawing.Point(727, 335);
            this.txtIDAlumno2.Name = "txtIDAlumno2";
            this.txtIDAlumno2.Size = new System.Drawing.Size(100, 20);
            this.txtIDAlumno2.TabIndex = 96;
            this.txtIDAlumno2.Visible = false;
            // 
            // txtIDEscuela2
            // 
            this.txtIDEscuela2.Enabled = false;
            this.txtIDEscuela2.Location = new System.Drawing.Point(727, 387);
            this.txtIDEscuela2.Name = "txtIDEscuela2";
            this.txtIDEscuela2.Size = new System.Drawing.Size(100, 20);
            this.txtIDEscuela2.TabIndex = 97;
            this.txtIDEscuela2.Visible = false;
            // 
            // txtIDPadre2
            // 
            this.txtIDPadre2.Enabled = false;
            this.txtIDPadre2.Location = new System.Drawing.Point(727, 438);
            this.txtIDPadre2.Name = "txtIDPadre2";
            this.txtIDPadre2.Size = new System.Drawing.Size(100, 20);
            this.txtIDPadre2.TabIndex = 98;
            this.txtIDPadre2.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(662, 498);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 30);
            this.btnEliminar.TabIndex = 99;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPadre2
            // 
            this.txtPadre2.Location = new System.Drawing.Point(661, 459);
            this.txtPadre2.Name = "txtPadre2";
            this.txtPadre2.Size = new System.Drawing.Size(166, 20);
            this.txtPadre2.TabIndex = 102;
            // 
            // txtAlumno2
            // 
            this.txtAlumno2.Location = new System.Drawing.Point(661, 408);
            this.txtAlumno2.Name = "txtAlumno2";
            this.txtAlumno2.Size = new System.Drawing.Size(166, 20);
            this.txtAlumno2.TabIndex = 101;
            // 
            // txtEscuela2
            // 
            this.txtEscuela2.Location = new System.Drawing.Point(661, 357);
            this.txtEscuela2.Name = "txtEscuela2";
            this.txtEscuela2.Size = new System.Drawing.Size(166, 20);
            this.txtEscuela2.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Escuela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 104;
            this.label5.Text = "Alumno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Alumno:";
            // 
            // tutor_has_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPadre2);
            this.Controls.Add(this.txtAlumno2);
            this.Controls.Add(this.txtEscuela2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIDPadre2);
            this.Controls.Add(this.txtIDEscuela2);
            this.Controls.Add(this.txtIDAlumno2);
            this.Controls.Add(this.dgvAhasTAll);
            this.Controls.Add(this.txtIdEscuela);
            this.Controls.Add(this.txtIdAlumno);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAhT);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscadorPadre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutor_has_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tutor_has_alumno";
            this.Load += new System.EventHandler(this.tutor_has_alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhasTAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscadorPadre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvAhT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.TextBox txtIdEscuela;
        private System.Windows.Forms.DataGridView dgvAhasTAll;
        private System.Windows.Forms.TextBox txtIDAlumno2;
        private System.Windows.Forms.TextBox txtIDEscuela2;
        private System.Windows.Forms.TextBox txtIDPadre2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPadre2;
        private System.Windows.Forms.TextBox txtAlumno2;
        private System.Windows.Forms.TextBox txtEscuela2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}