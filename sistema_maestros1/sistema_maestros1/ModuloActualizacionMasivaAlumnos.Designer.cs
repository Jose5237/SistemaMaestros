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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloActualizacionMasivaAlumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbEscuela = new System.Windows.Forms.ComboBox();
            this.btnActualizarGrado = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.txtIdEscuela = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.esconder_pantalla = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.btnRecomendaciones2 = new System.Windows.Forms.Button();
            this.btnIncidencias2 = new System.Windows.Forms.Button();
            this.btnPagos2 = new System.Windows.Forms.Button();
            this.btnMenuPrincipal2 = new System.Windows.Forms.Button();
            this.btnMaterial2 = new System.Windows.Forms.Button();
            this.btnDinamicas2 = new System.Windows.Forms.Button();
            this.btnProfesores2 = new System.Windows.Forms.Button();
            this.btnPadreOTutor2 = new System.Windows.Forms.Button();
            this.btnTalleres2 = new System.Windows.Forms.Button();
            this.btnEscuelas2 = new System.Windows.Forms.Button();
            this.btnAlumnos2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEscuela
            // 
            this.cbEscuela.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscuela.FormattingEnabled = true;
            this.cbEscuela.Location = new System.Drawing.Point(172, 320);
            this.cbEscuela.Name = "cbEscuela";
            this.cbEscuela.Size = new System.Drawing.Size(250, 25);
            this.cbEscuela.TabIndex = 0;
            this.cbEscuela.Text = "Seleccionar Escuela";
            this.cbEscuela.SelectedIndexChanged += new System.EventHandler(this.cbEscuela_SelectedIndexChanged);
            this.cbEscuela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEscuela_KeyPress);
            // 
            // btnActualizarGrado
            // 
            this.btnActualizarGrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarGrado.BackgroundImage")));
            this.btnActualizarGrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarGrado.FlatAppearance.BorderSize = 0;
            this.btnActualizarGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarGrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizarGrado.Location = new System.Drawing.Point(301, 366);
            this.btnActualizarGrado.Name = "btnActualizarGrado";
            this.btnActualizarGrado.Size = new System.Drawing.Size(120, 31);
            this.btnActualizarGrado.TabIndex = 4;
            this.btnActualizarGrado.Text = "ACTUALIZAR";
            this.btnActualizarGrado.UseVisualStyleBackColor = true;
            this.btnActualizarGrado.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToOrderColumns = true;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.GridColor = System.Drawing.Color.Khaki;
            this.dgvAlumnos.Location = new System.Drawing.Point(442, 56);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(685, 568);
            this.dgvAlumnos.TabIndex = 5;
            // 
            // txtIdEscuela
            // 
            this.txtIdEscuela.Location = new System.Drawing.Point(350, 298);
            this.txtIdEscuela.Name = "txtIdEscuela";
            this.txtIdEscuela.Size = new System.Drawing.Size(72, 20);
            this.txtIdEscuela.TabIndex = 9;
            this.txtIdEscuela.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.Location = new System.Drawing.Point(168, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 83;
            this.label10.Text = "Escuela:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 214);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 176);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(293, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(575, 42);
            this.label12.TabIndex = 85;
            this.label12.Text = "Modulo de Actualizacion Masiva";
            // 
            // esconder_pantalla
            // 
            this.esconder_pantalla.AutoSize = true;
            this.esconder_pantalla.BackColor = System.Drawing.Color.Transparent;
            this.esconder_pantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.esconder_pantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.esconder_pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esconder_pantalla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.esconder_pantalla.Location = new System.Drawing.Point(1077, -7);
            this.esconder_pantalla.Margin = new System.Windows.Forms.Padding(0);
            this.esconder_pantalla.Name = "esconder_pantalla";
            this.esconder_pantalla.Size = new System.Drawing.Size(37, 39);
            this.esconder_pantalla.TabIndex = 87;
            this.esconder_pantalla.Text = "_";
            this.esconder_pantalla.Click += new System.EventHandler(this.esconder_pantalla_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(1114, -2);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 39);
            this.exit.TabIndex = 86;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnRecomendaciones2
            // 
            this.btnRecomendaciones2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecomendaciones2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecomendaciones2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomendaciones2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendaciones2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRecomendaciones2.Location = new System.Drawing.Point(3, 473);
            this.btnRecomendaciones2.Name = "btnRecomendaciones2";
            this.btnRecomendaciones2.Size = new System.Drawing.Size(143, 42);
            this.btnRecomendaciones2.TabIndex = 98;
            this.btnRecomendaciones2.Text = "Recomendaciones";
            this.btnRecomendaciones2.UseVisualStyleBackColor = false;
            this.btnRecomendaciones2.Click += new System.EventHandler(this.btnRecomendaciones2_Click);
            // 
            // btnIncidencias2
            // 
            this.btnIncidencias2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncidencias2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncidencias2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIncidencias2.Location = new System.Drawing.Point(3, 430);
            this.btnIncidencias2.Name = "btnIncidencias2";
            this.btnIncidencias2.Size = new System.Drawing.Size(143, 42);
            this.btnIncidencias2.TabIndex = 97;
            this.btnIncidencias2.Text = "Incidencias";
            this.btnIncidencias2.UseVisualStyleBackColor = false;
            this.btnIncidencias2.Click += new System.EventHandler(this.btnIncidencias2_Click);
            // 
            // btnPagos2
            // 
            this.btnPagos2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagos2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPagos2.Location = new System.Drawing.Point(3, 387);
            this.btnPagos2.Name = "btnPagos2";
            this.btnPagos2.Size = new System.Drawing.Size(143, 42);
            this.btnPagos2.TabIndex = 96;
            this.btnPagos2.Text = "Pagos";
            this.btnPagos2.UseVisualStyleBackColor = false;
            this.btnPagos2.Click += new System.EventHandler(this.btnPagos2_Click);
            // 
            // btnMenuPrincipal2
            // 
            this.btnMenuPrincipal2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal2.Location = new System.Drawing.Point(3, 46);
            this.btnMenuPrincipal2.Name = "btnMenuPrincipal2";
            this.btnMenuPrincipal2.Size = new System.Drawing.Size(143, 38);
            this.btnMenuPrincipal2.TabIndex = 88;
            this.btnMenuPrincipal2.Text = "☰    Menu   ";
            this.btnMenuPrincipal2.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal2.Click += new System.EventHandler(this.btnMenuPrincipal2_Click);
            // 
            // btnMaterial2
            // 
            this.btnMaterial2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaterial2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaterial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaterial2.Location = new System.Drawing.Point(3, 344);
            this.btnMaterial2.Name = "btnMaterial2";
            this.btnMaterial2.Size = new System.Drawing.Size(143, 42);
            this.btnMaterial2.TabIndex = 95;
            this.btnMaterial2.Text = "Materiales";
            this.btnMaterial2.UseVisualStyleBackColor = false;
            this.btnMaterial2.Click += new System.EventHandler(this.btnMaterial2_Click);
            // 
            // btnDinamicas2
            // 
            this.btnDinamicas2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDinamicas2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDinamicas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinamicas2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinamicas2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDinamicas2.Location = new System.Drawing.Point(3, 301);
            this.btnDinamicas2.Name = "btnDinamicas2";
            this.btnDinamicas2.Size = new System.Drawing.Size(143, 42);
            this.btnDinamicas2.TabIndex = 94;
            this.btnDinamicas2.Text = "Dinamicas";
            this.btnDinamicas2.UseVisualStyleBackColor = false;
            this.btnDinamicas2.Click += new System.EventHandler(this.btnDinamicas2_Click);
            // 
            // btnProfesores2
            // 
            this.btnProfesores2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfesores2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfesores2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProfesores2.Location = new System.Drawing.Point(3, 258);
            this.btnProfesores2.Name = "btnProfesores2";
            this.btnProfesores2.Size = new System.Drawing.Size(143, 42);
            this.btnProfesores2.TabIndex = 93;
            this.btnProfesores2.Text = "Profesores";
            this.btnProfesores2.UseVisualStyleBackColor = false;
            this.btnProfesores2.Click += new System.EventHandler(this.btnProfesores2_Click);
            // 
            // btnPadreOTutor2
            // 
            this.btnPadreOTutor2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPadreOTutor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPadreOTutor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadreOTutor2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadreOTutor2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPadreOTutor2.Location = new System.Drawing.Point(3, 215);
            this.btnPadreOTutor2.Name = "btnPadreOTutor2";
            this.btnPadreOTutor2.Size = new System.Drawing.Size(143, 42);
            this.btnPadreOTutor2.TabIndex = 92;
            this.btnPadreOTutor2.Text = "Padre o Tutor";
            this.btnPadreOTutor2.UseVisualStyleBackColor = false;
            this.btnPadreOTutor2.Click += new System.EventHandler(this.btnPadreOTutor2_Click);
            // 
            // btnTalleres2
            // 
            this.btnTalleres2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTalleres2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTalleres2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalleres2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalleres2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTalleres2.Location = new System.Drawing.Point(3, 172);
            this.btnTalleres2.Name = "btnTalleres2";
            this.btnTalleres2.Size = new System.Drawing.Size(143, 42);
            this.btnTalleres2.TabIndex = 91;
            this.btnTalleres2.Text = "Talleres";
            this.btnTalleres2.UseVisualStyleBackColor = false;
            this.btnTalleres2.Click += new System.EventHandler(this.btnTalleres2_Click);
            // 
            // btnEscuelas2
            // 
            this.btnEscuelas2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEscuelas2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEscuelas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscuelas2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuelas2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEscuelas2.Location = new System.Drawing.Point(3, 129);
            this.btnEscuelas2.Name = "btnEscuelas2";
            this.btnEscuelas2.Size = new System.Drawing.Size(143, 42);
            this.btnEscuelas2.TabIndex = 90;
            this.btnEscuelas2.Text = "Escuelas";
            this.btnEscuelas2.UseVisualStyleBackColor = false;
            this.btnEscuelas2.Click += new System.EventHandler(this.btnEscuelas2_Click);
            // 
            // btnAlumnos2
            // 
            this.btnAlumnos2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlumnos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlumnos2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlumnos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlumnos2.Location = new System.Drawing.Point(3, 86);
            this.btnAlumnos2.Name = "btnAlumnos2";
            this.btnAlumnos2.Size = new System.Drawing.Size(143, 42);
            this.btnAlumnos2.TabIndex = 89;
            this.btnAlumnos2.Text = "Alumnos";
            this.btnAlumnos2.UseVisualStyleBackColor = false;
            this.btnAlumnos2.Click += new System.EventHandler(this.btnAlumnos2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(3, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 99;
            this.button1.Text = "Actualizacion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCargarTodo
            // 
            this.btnCargarTodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarTodo.Location = new System.Drawing.Point(301, 366);
            this.btnCargarTodo.Name = "btnCargarTodo";
            this.btnCargarTodo.Size = new System.Drawing.Size(120, 31);
            this.btnCargarTodo.TabIndex = 100;
            this.btnCargarTodo.Text = "CARGAR TODOS";
            this.btnCargarTodo.UseVisualStyleBackColor = true;
            this.btnCargarTodo.Visible = false;
            this.btnCargarTodo.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModuloActualizacionMasivaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.btnCargarTodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRecomendaciones2);
            this.Controls.Add(this.btnIncidencias2);
            this.Controls.Add(this.btnPagos2);
            this.Controls.Add(this.btnMenuPrincipal2);
            this.Controls.Add(this.btnMaterial2);
            this.Controls.Add(this.btnDinamicas2);
            this.Controls.Add(this.btnProfesores2);
            this.Controls.Add(this.btnPadreOTutor2);
            this.Controls.Add(this.btnTalleres2);
            this.Controls.Add(this.btnEscuelas2);
            this.Controls.Add(this.btnAlumnos2);
            this.Controls.Add(this.esconder_pantalla);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdEscuela);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnActualizarGrado);
            this.Controls.Add(this.cbEscuela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuloActualizacionMasivaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloActualizacionMasivaAlumnos";
            this.Load += new System.EventHandler(this.ModuloActualizacionMasivaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEscuela;
        private System.Windows.Forms.Button btnActualizarGrado;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.TextBox txtIdEscuela;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label esconder_pantalla;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button btnRecomendaciones2;
        private System.Windows.Forms.Button btnIncidencias2;
        private System.Windows.Forms.Button btnPagos2;
        private System.Windows.Forms.Button btnMenuPrincipal2;
        private System.Windows.Forms.Button btnMaterial2;
        private System.Windows.Forms.Button btnDinamicas2;
        private System.Windows.Forms.Button btnProfesores2;
        private System.Windows.Forms.Button btnPadreOTutor2;
        private System.Windows.Forms.Button btnTalleres2;
        private System.Windows.Forms.Button btnEscuelas2;
        private System.Windows.Forms.Button btnAlumnos2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargarTodo;
    }
}