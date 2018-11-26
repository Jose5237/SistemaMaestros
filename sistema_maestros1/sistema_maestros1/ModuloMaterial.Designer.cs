namespace sistema_maestros1
{
    partial class ModuloMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloMaterial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscadorMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtCostoMaterial = new System.Windows.Forms.TextBox();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.txtIdMaterial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnModificarMaterial = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.esconder_pantalla = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEscuelaMaterial = new System.Windows.Forms.ComboBox();
            this.cbTallerMaterial = new System.Windows.Forms.ComboBox();
            this.cbDinamicaMaterial = new System.Windows.Forms.ComboBox();
            this.btnMenuPrincipal2 = new System.Windows.Forms.Button();
            this.btnMaterial2 = new System.Windows.Forms.Button();
            this.btnDinamicas2 = new System.Windows.Forms.Button();
            this.btnProfesores2 = new System.Windows.Forms.Button();
            this.btnPadreOTutor2 = new System.Windows.Forms.Button();
            this.btnTalleres2 = new System.Windows.Forms.Button();
            this.btnEscuelas2 = new System.Windows.Forms.Button();
            this.btnAlumnos2 = new System.Windows.Forms.Button();
            this.btnPagos2 = new System.Windows.Forms.Button();
            this.btnRecomendaciones2 = new System.Windows.Forms.Button();
            this.btnIncidencias2 = new System.Windows.Forms.Button();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.txtIdEscuela = new System.Windows.Forms.TextBox();
            this.txtIdTaller = new System.Windows.Forms.TextBox();
            this.txtIdDinamica = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(430, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 39);
            this.label12.TabIndex = 67;
            this.label12.Text = "Modulo de Materiales";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscadorMaterial
            // 
            this.txtBuscadorMaterial.Location = new System.Drawing.Point(813, 55);
            this.txtBuscadorMaterial.Multiline = true;
            this.txtBuscadorMaterial.Name = "txtBuscadorMaterial";
            this.txtBuscadorMaterial.Size = new System.Drawing.Size(283, 30);
            this.txtBuscadorMaterial.TabIndex = 90;
            this.txtBuscadorMaterial.TextChanged += new System.EventHandler(this.txtBuscadorMaterial_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Buscar Material: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1097, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 88;
            this.pictureBox4.TabStop = false;
            // 
            // txtCostoMaterial
            // 
            this.txtCostoMaterial.Enabled = false;
            this.txtCostoMaterial.Location = new System.Drawing.Point(166, 395);
            this.txtCostoMaterial.Name = "txtCostoMaterial";
            this.txtCostoMaterial.Size = new System.Drawing.Size(212, 20);
            this.txtCostoMaterial.TabIndex = 86;
            this.txtCostoMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoMaterial_KeyPress);
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Enabled = false;
            this.txtNombreMaterial.Location = new System.Drawing.Point(166, 348);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(211, 20);
            this.txtNombreMaterial.TabIndex = 85;
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.Enabled = false;
            this.txtIdMaterial.Location = new System.Drawing.Point(166, 301);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.Size = new System.Drawing.Size(211, 20);
            this.txtIdMaterial.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label4.Location = new System.Drawing.Point(163, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "ID material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label2.Location = new System.Drawing.Point(163, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Costo unitario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label1.Location = new System.Drawing.Point(163, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.btnEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(393, 53);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(96, 37);
            this.btnEliminarMaterial.TabIndex = 80;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = false;
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // btnModificarMaterial
            // 
            this.btnModificarMaterial.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarMaterial.FlatAppearance.BorderSize = 0;
            this.btnModificarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMaterial.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMaterial.Location = new System.Drawing.Point(282, 53);
            this.btnModificarMaterial.Name = "btnModificarMaterial";
            this.btnModificarMaterial.Size = new System.Drawing.Size(96, 37);
            this.btnModificarMaterial.TabIndex = 79;
            this.btnModificarMaterial.Text = "Modificar";
            this.btnModificarMaterial.UseVisualStyleBackColor = false;
            this.btnModificarMaterial.Click += new System.EventHandler(this.btnModificarMaterial_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(170, 53);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(96, 37);
            this.btnAgregarMaterial.TabIndex = 78;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // esconder_pantalla
            // 
            this.esconder_pantalla.AutoSize = true;
            this.esconder_pantalla.BackColor = System.Drawing.Color.Transparent;
            this.esconder_pantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.esconder_pantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.esconder_pantalla.Font = new System.Drawing.Font("Comfortaa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esconder_pantalla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.esconder_pantalla.Location = new System.Drawing.Point(1077, -7);
            this.esconder_pantalla.Margin = new System.Windows.Forms.Padding(0);
            this.esconder_pantalla.Name = "esconder_pantalla";
            this.esconder_pantalla.Size = new System.Drawing.Size(33, 40);
            this.esconder_pantalla.TabIndex = 94;
            this.esconder_pantalla.Text = "_";
            this.esconder_pantalla.Click += new System.EventHandler(this.esconder_pantalla_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Comfortaa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(1114, -2);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 40);
            this.exit.TabIndex = 93;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAceptar.Location = new System.Drawing.Point(167, 473);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(211, 30);
            this.btnAceptar.TabIndex = 95;
            this.btnAceptar.Text = "GUARDAR✔";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label3.Location = new System.Drawing.Point(163, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Escuela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label5.Location = new System.Drawing.Point(163, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Dinamica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.label7.Location = new System.Drawing.Point(163, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Taller:";
            // 
            // cbEscuelaMaterial
            // 
            this.cbEscuelaMaterial.Enabled = false;
            this.cbEscuelaMaterial.FormattingEnabled = true;
            this.cbEscuelaMaterial.Location = new System.Drawing.Point(166, 156);
            this.cbEscuelaMaterial.Name = "cbEscuelaMaterial";
            this.cbEscuelaMaterial.Size = new System.Drawing.Size(211, 21);
            this.cbEscuelaMaterial.TabIndex = 100;
            this.cbEscuelaMaterial.SelectedIndexChanged += new System.EventHandler(this.cbEscuelaMaterial_SelectedIndexChanged);
            // 
            // cbTallerMaterial
            // 
            this.cbTallerMaterial.Enabled = false;
            this.cbTallerMaterial.FormattingEnabled = true;
            this.cbTallerMaterial.Location = new System.Drawing.Point(166, 205);
            this.cbTallerMaterial.Name = "cbTallerMaterial";
            this.cbTallerMaterial.Size = new System.Drawing.Size(211, 21);
            this.cbTallerMaterial.TabIndex = 101;
            this.cbTallerMaterial.SelectedIndexChanged += new System.EventHandler(this.cbTallerMaterial_SelectedIndexChanged);
            // 
            // cbDinamicaMaterial
            // 
            this.cbDinamicaMaterial.Enabled = false;
            this.cbDinamicaMaterial.FormattingEnabled = true;
            this.cbDinamicaMaterial.Location = new System.Drawing.Point(166, 253);
            this.cbDinamicaMaterial.Name = "cbDinamicaMaterial";
            this.cbDinamicaMaterial.Size = new System.Drawing.Size(211, 21);
            this.cbDinamicaMaterial.TabIndex = 102;
            this.cbDinamicaMaterial.SelectedIndexChanged += new System.EventHandler(this.cbDinamicaMaterial_SelectedIndexChanged);
            // 
            // btnMenuPrincipal2
            // 
            this.btnMenuPrincipal2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal2.Location = new System.Drawing.Point(3, 46);
            this.btnMenuPrincipal2.Name = "btnMenuPrincipal2";
            this.btnMenuPrincipal2.Size = new System.Drawing.Size(143, 38);
            this.btnMenuPrincipal2.TabIndex = 110;
            this.btnMenuPrincipal2.Text = "☰    Menu   ";
            this.btnMenuPrincipal2.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal2.Click += new System.EventHandler(this.btnMenuPrincipal2_Click);
            // 
            // btnMaterial2
            // 
            this.btnMaterial2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaterial2.Enabled = false;
            this.btnMaterial2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaterial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaterial2.Location = new System.Drawing.Point(3, 344);
            this.btnMaterial2.Name = "btnMaterial2";
            this.btnMaterial2.Size = new System.Drawing.Size(143, 42);
            this.btnMaterial2.TabIndex = 109;
            this.btnMaterial2.Text = "      Materiales";
            this.btnMaterial2.UseVisualStyleBackColor = false;
            this.btnMaterial2.Click += new System.EventHandler(this.btnMaterial2_Click);
            // 
            // btnDinamicas2
            // 
            this.btnDinamicas2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDinamicas2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDinamicas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinamicas2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinamicas2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDinamicas2.Location = new System.Drawing.Point(3, 301);
            this.btnDinamicas2.Name = "btnDinamicas2";
            this.btnDinamicas2.Size = new System.Drawing.Size(143, 42);
            this.btnDinamicas2.TabIndex = 108;
            this.btnDinamicas2.Text = "      Dinamicas";
            this.btnDinamicas2.UseVisualStyleBackColor = false;
            this.btnDinamicas2.Click += new System.EventHandler(this.btnDinamicas2_Click);
            // 
            // btnProfesores2
            // 
            this.btnProfesores2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfesores2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfesores2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProfesores2.Location = new System.Drawing.Point(3, 258);
            this.btnProfesores2.Name = "btnProfesores2";
            this.btnProfesores2.Size = new System.Drawing.Size(143, 42);
            this.btnProfesores2.TabIndex = 107;
            this.btnProfesores2.Text = "      Profesores";
            this.btnProfesores2.UseVisualStyleBackColor = false;
            this.btnProfesores2.Click += new System.EventHandler(this.btnProfesores2_Click);
            // 
            // btnPadreOTutor2
            // 
            this.btnPadreOTutor2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPadreOTutor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPadreOTutor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadreOTutor2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadreOTutor2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPadreOTutor2.Location = new System.Drawing.Point(3, 215);
            this.btnPadreOTutor2.Name = "btnPadreOTutor2";
            this.btnPadreOTutor2.Size = new System.Drawing.Size(143, 42);
            this.btnPadreOTutor2.TabIndex = 106;
            this.btnPadreOTutor2.Text = "            Padre o Tutor";
            this.btnPadreOTutor2.UseVisualStyleBackColor = false;
            this.btnPadreOTutor2.Click += new System.EventHandler(this.btnPadreOTutor2_Click);
            // 
            // btnTalleres2
            // 
            this.btnTalleres2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTalleres2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTalleres2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalleres2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalleres2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTalleres2.Location = new System.Drawing.Point(3, 172);
            this.btnTalleres2.Name = "btnTalleres2";
            this.btnTalleres2.Size = new System.Drawing.Size(143, 42);
            this.btnTalleres2.TabIndex = 105;
            this.btnTalleres2.Text = "   Talleres";
            this.btnTalleres2.UseVisualStyleBackColor = false;
            this.btnTalleres2.Click += new System.EventHandler(this.btnTalleres2_Click);
            // 
            // btnEscuelas2
            // 
            this.btnEscuelas2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEscuelas2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEscuelas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscuelas2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuelas2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEscuelas2.Location = new System.Drawing.Point(3, 129);
            this.btnEscuelas2.Name = "btnEscuelas2";
            this.btnEscuelas2.Size = new System.Drawing.Size(143, 42);
            this.btnEscuelas2.TabIndex = 104;
            this.btnEscuelas2.Text = "     Escuelas";
            this.btnEscuelas2.UseVisualStyleBackColor = false;
            this.btnEscuelas2.Click += new System.EventHandler(this.btnEscuelas2_Click);
            // 
            // btnAlumnos2
            // 
            this.btnAlumnos2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlumnos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlumnos2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlumnos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlumnos2.Location = new System.Drawing.Point(3, 86);
            this.btnAlumnos2.Name = "btnAlumnos2";
            this.btnAlumnos2.Size = new System.Drawing.Size(143, 42);
            this.btnAlumnos2.TabIndex = 103;
            this.btnAlumnos2.Text = "      Alumnos";
            this.btnAlumnos2.UseVisualStyleBackColor = false;
            this.btnAlumnos2.Click += new System.EventHandler(this.btnAlumnos2_Click);
            // 
            // btnPagos2
            // 
            this.btnPagos2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagos2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPagos2.Location = new System.Drawing.Point(3, 387);
            this.btnPagos2.Name = "btnPagos2";
            this.btnPagos2.Size = new System.Drawing.Size(143, 42);
            this.btnPagos2.TabIndex = 111;
            this.btnPagos2.Text = "Pagos";
            this.btnPagos2.UseVisualStyleBackColor = false;
            this.btnPagos2.Click += new System.EventHandler(this.btnPagos2_Click);
            // 
            // btnRecomendaciones2
            // 
            this.btnRecomendaciones2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecomendaciones2.Enabled = false;
            this.btnRecomendaciones2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecomendaciones2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomendaciones2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendaciones2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRecomendaciones2.Location = new System.Drawing.Point(3, 473);
            this.btnRecomendaciones2.Name = "btnRecomendaciones2";
            this.btnRecomendaciones2.Size = new System.Drawing.Size(143, 42);
            this.btnRecomendaciones2.TabIndex = 132;
            this.btnRecomendaciones2.Text = "Recomendaciones";
            this.btnRecomendaciones2.UseVisualStyleBackColor = false;
            this.btnRecomendaciones2.Click += new System.EventHandler(this.btnRecomendaciones2_Click);
            // 
            // btnIncidencias2
            // 
            this.btnIncidencias2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncidencias2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncidencias2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIncidencias2.Location = new System.Drawing.Point(3, 430);
            this.btnIncidencias2.Name = "btnIncidencias2";
            this.btnIncidencias2.Size = new System.Drawing.Size(143, 42);
            this.btnIncidencias2.TabIndex = 131;
            this.btnIncidencias2.Text = "    Incidencias";
            this.btnIncidencias2.UseVisualStyleBackColor = false;
            this.btnIncidencias2.Click += new System.EventHandler(this.btnIncidencias2_Click);
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.AllowUserToDeleteRows = false;
            this.dgvMaterial.AllowUserToOrderColumns = true;
            this.dgvMaterial.AllowUserToResizeColumns = false;
            this.dgvMaterial.AllowUserToResizeRows = false;
            this.dgvMaterial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterial.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaterial.EnableHeadersVisualStyles = false;
            this.dgvMaterial.GridColor = System.Drawing.Color.PowderBlue;
            this.dgvMaterial.Location = new System.Drawing.Point(423, 105);
            this.dgvMaterial.MultiSelect = false;
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.ReadOnly = true;
            this.dgvMaterial.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvMaterial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(690, 513);
            this.dgvMaterial.TabIndex = 139;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // txtIdEscuela
            // 
            this.txtIdEscuela.Location = new System.Drawing.Point(220, 136);
            this.txtIdEscuela.Name = "txtIdEscuela";
            this.txtIdEscuela.Size = new System.Drawing.Size(100, 20);
            this.txtIdEscuela.TabIndex = 140;
            // 
            // txtIdTaller
            // 
            this.txtIdTaller.Location = new System.Drawing.Point(220, 185);
            this.txtIdTaller.Name = "txtIdTaller";
            this.txtIdTaller.Size = new System.Drawing.Size(100, 20);
            this.txtIdTaller.TabIndex = 141;
            // 
            // txtIdDinamica
            // 
            this.txtIdDinamica.Location = new System.Drawing.Point(237, 233);
            this.txtIdDinamica.Name = "txtIdDinamica";
            this.txtIdDinamica.Size = new System.Drawing.Size(100, 20);
            this.txtIdDinamica.TabIndex = 142;
            // 
            // ModuloMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.txtIdDinamica);
            this.Controls.Add(this.txtIdTaller);
            this.Controls.Add(this.txtIdEscuela);
            this.Controls.Add(this.dgvMaterial);
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
            this.Controls.Add(this.cbDinamicaMaterial);
            this.Controls.Add(this.cbTallerMaterial);
            this.Controls.Add(this.cbEscuelaMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.esconder_pantalla);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.txtBuscadorMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtCostoMaterial);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.txtIdMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarMaterial);
            this.Controls.Add(this.btnModificarMaterial);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModuloMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloMaterial";
            this.Load += new System.EventHandler(this.ModuloMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscadorMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtCostoMaterial;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.TextBox txtIdMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button btnModificarMaterial;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Label esconder_pantalla;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEscuelaMaterial;
        private System.Windows.Forms.ComboBox cbTallerMaterial;
        private System.Windows.Forms.ComboBox cbDinamicaMaterial;
        private System.Windows.Forms.Button btnMenuPrincipal2;
        private System.Windows.Forms.Button btnMaterial2;
        private System.Windows.Forms.Button btnDinamicas2;
        private System.Windows.Forms.Button btnProfesores2;
        private System.Windows.Forms.Button btnPadreOTutor2;
        private System.Windows.Forms.Button btnTalleres2;
        private System.Windows.Forms.Button btnEscuelas2;
        private System.Windows.Forms.Button btnAlumnos2;
        private System.Windows.Forms.Button btnPagos2;
        private System.Windows.Forms.Button btnRecomendaciones2;
        private System.Windows.Forms.Button btnIncidencias2;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.TextBox txtIdEscuela;
        private System.Windows.Forms.TextBox txtIdTaller;
        private System.Windows.Forms.TextBox txtIdDinamica;
    }
}