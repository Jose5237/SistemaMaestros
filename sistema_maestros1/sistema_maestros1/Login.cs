using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using variablesGlobales;

namespace sistema_maestros1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar la aplicación?", "¡Cerrar aplicación!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void esconder_pantalla_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Acceder_Click(object sender, EventArgs e)
        {

            if (txtLogin_User.Text != "" && txtLogin_Password.Text != "")
            {
                
                ClassProfesor login = new ClassProfesor();
                login.pr_nombre_profesor = txtLogin_User.Text;
                Globales.usuario = txtLogin_User.Text;
                login.pr_contrasena_profesor = txtLogin_Password.Text;

                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    int buscar = wsPHP.login(login.pr_nombre_profesor, login.pr_contrasena_profesor);

                    if(buscar == 1)
                    {
                        this.Hide();
                        principal principal = new principal();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no se encuentra registrado", "¡Usuario inexistente!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
                MessageBox.Show("Debes ingresar todos los campos para acceder","¡Falta llenar campos!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            
        }

        private void txtLogin_User_Enter(object sender, EventArgs e)
        {
            if (txtLogin_User.Text == "Usuario")
            {
                txtLogin_User.Text = "";
                txtLogin_User.ForeColor = Color.White;
            }
        }

        private void txtLogin_Password_Enter(object sender, EventArgs e)
        {
            if (txtLogin_Password.Text == "Contraseña")
            {
                txtLogin_Password.Text = "";
                txtLogin_Password.PasswordChar = Convert.ToChar("•");
                txtLogin_Password.ForeColor = Color.White;
            }
        }

        private void txtLogin_User_Leave(object sender, EventArgs e)
        {
            if (txtLogin_User.Text == "")
            {
                txtLogin_User.Text = "Usuario";

                txtLogin_User.ForeColor = Color.LightGray;
            }
        }

        private void txtLogin_Password_Leave(object sender, EventArgs e)
        {
            if (txtLogin_Password.Text == "")
            {
                txtLogin_Password.Text = "Contraseña";
                txtLogin_Password.PasswordChar = '\0';

                txtLogin_Password.ForeColor = Color.LightGray;
            }
        }

        private void cbxVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxVerPass.Checked == true)
            {
                if (txtLogin_Password.PasswordChar == '•')
                {
                    txtLogin_Password.PasswordChar = '\0';
                }
                
            }
            else
            {
                txtLogin_Password.PasswordChar = Convert.ToChar("•");
            }
        }
    }
}
