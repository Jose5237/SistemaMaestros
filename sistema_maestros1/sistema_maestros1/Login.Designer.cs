namespace sistema_maestros1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtLogin_User = new System.Windows.Forms.TextBox();
            this.txtLogin_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin_Acceder = new System.Windows.Forms.Button();
            this.linkLogin_contraseña = new System.Windows.Forms.LinkLabel();
            this.exit = new System.Windows.Forms.Label();
            this.esconder_pantalla = new System.Windows.Forms.Label();
            this.cbxVerPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Login";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(748, 339);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 356;
            this.lineShape2.X2 = 649;
            this.lineShape2.Y1 = 200;
            this.lineShape2.Y2 = 200;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 354;
            this.lineShape1.X2 = 647;
            this.lineShape1.Y1 = 118;
            this.lineShape1.Y2 = 118;
            // 
            // txtLogin_User
            // 
            this.txtLogin_User.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtLogin_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin_User.Font = new System.Drawing.Font("HelvLight", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_User.ForeColor = System.Drawing.Color.LightGray;
            this.txtLogin_User.Location = new System.Drawing.Point(354, 97);
            this.txtLogin_User.Multiline = true;
            this.txtLogin_User.Name = "txtLogin_User";
            this.txtLogin_User.Size = new System.Drawing.Size(294, 20);
            this.txtLogin_User.TabIndex = 2;
            this.txtLogin_User.Tag = "Usuario";
            this.txtLogin_User.Text = "Usuario";
            this.txtLogin_User.Enter += new System.EventHandler(this.txtLogin_User_Enter);
            this.txtLogin_User.Leave += new System.EventHandler(this.txtLogin_User_Leave);
            // 
            // txtLogin_Password
            // 
            this.txtLogin_Password.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtLogin_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin_Password.Font = new System.Drawing.Font("HelvLight", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtLogin_Password.ForeColor = System.Drawing.Color.LightGray;
            this.txtLogin_Password.Location = new System.Drawing.Point(356, 179);
            this.txtLogin_Password.Multiline = true;
            this.txtLogin_Password.Name = "txtLogin_Password";
            this.txtLogin_Password.Size = new System.Drawing.Size(294, 20);
            this.txtLogin_Password.TabIndex = 3;
            this.txtLogin_Password.Tag = "Contraseña";
            this.txtLogin_Password.Text = "Contraseña";
            this.txtLogin_Password.Enter += new System.EventHandler(this.txtLogin_Password_Enter);
            this.txtLogin_Password.Leave += new System.EventHandler(this.txtLogin_Password_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogin_Acceder
            // 
            this.btnLogin_Acceder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin_Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin_Acceder.FlatAppearance.BorderSize = 0;
            this.btnLogin_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin_Acceder.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Acceder.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogin_Acceder.Location = new System.Drawing.Point(356, 240);
            this.btnLogin_Acceder.Name = "btnLogin_Acceder";
            this.btnLogin_Acceder.Size = new System.Drawing.Size(294, 37);
            this.btnLogin_Acceder.TabIndex = 5;
            this.btnLogin_Acceder.Text = "ACCEDER";
            this.btnLogin_Acceder.UseVisualStyleBackColor = false;
            this.btnLogin_Acceder.Click += new System.EventHandler(this.btnLogin_Acceder_Click);
            // 
            // linkLogin_contraseña
            // 
            this.linkLogin_contraseña.AutoSize = true;
            this.linkLogin_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin_contraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLogin_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin_contraseña.Location = new System.Drawing.Point(409, 282);
            this.linkLogin_contraseña.Name = "linkLogin_contraseña";
            this.linkLogin_contraseña.Size = new System.Drawing.Size(186, 16);
            this.linkLogin_contraseña.TabIndex = 6;
            this.linkLogin_contraseña.TabStop = true;
            this.linkLogin_contraseña.Text = "¿Has olvidado tu contraseña?";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Comfortaa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(716, -3);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 40);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // esconder_pantalla
            // 
            this.esconder_pantalla.AutoSize = true;
            this.esconder_pantalla.BackColor = System.Drawing.Color.Transparent;
            this.esconder_pantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.esconder_pantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.esconder_pantalla.Font = new System.Drawing.Font("Comfortaa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esconder_pantalla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.esconder_pantalla.Location = new System.Drawing.Point(681, -8);
            this.esconder_pantalla.Margin = new System.Windows.Forms.Padding(0);
            this.esconder_pantalla.Name = "esconder_pantalla";
            this.esconder_pantalla.Size = new System.Drawing.Size(33, 40);
            this.esconder_pantalla.TabIndex = 1;
            this.esconder_pantalla.Text = "_";
            this.esconder_pantalla.Click += new System.EventHandler(this.esconder_pantalla_Click);
            // 
            // cbxVerPass
            // 
            this.cbxVerPass.AutoSize = true;
            this.cbxVerPass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbxVerPass.FlatAppearance.BorderSize = 0;
            this.cbxVerPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVerPass.Font = new System.Drawing.Font("HelvLight", 9F);
            this.cbxVerPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVerPass.Location = new System.Drawing.Point(355, 202);
            this.cbxVerPass.Name = "cbxVerPass";
            this.cbxVerPass.Size = new System.Drawing.Size(131, 19);
            this.cbxVerPass.TabIndex = 8;
            this.cbxVerPass.Text = "Mostrar Contraseña";
            this.cbxVerPass.UseVisualStyleBackColor = false;
            this.cbxVerPass.CheckedChanged += new System.EventHandler(this.cbxVerPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 339);
            this.Controls.Add(this.cbxVerPass);
            this.Controls.Add(this.esconder_pantalla);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.linkLogin_contraseña);
            this.Controls.Add(this.btnLogin_Acceder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLogin_Password);
            this.Controls.Add(this.txtLogin_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtLogin_User;
        private System.Windows.Forms.TextBox txtLogin_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin_Acceder;
        private System.Windows.Forms.LinkLabel linkLogin_contraseña;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label esconder_pantalla;
        private System.Windows.Forms.CheckBox cbxVerPass;
    }
}

