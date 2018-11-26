using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_maestros1
{
    public partial class ModuloRecomendaciones : Form
    {
        public ModuloRecomendaciones()
        {
            InitializeComponent();
        }

        int opcionBotones = 0;

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                principal principal = new principal();
                principal.Show();
            }
        }

        private void esconder_pantalla_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //BOTON DE MENU PRINCIPAL
        private void btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                principal principal = new principal();
                principal.Show();
            }
        }

        //BOTON DE ALUMNOS
        private void btnAlumnos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloAlumnos modalumno = new ModuloAlumnos();
                modalumno.Show();
            }
        }

        //BOTON DE ESCUELAS
        private void btnEscuelas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloEscuelas modescuela = new ModuloEscuelas();
                modescuela.Show();
            }
        }

        //BOTON DE TALLERES
        private void btnTalleres2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloTalleres modtaller = new ModuloTalleres();
                modtaller.Show();
            }
        }

        //BOTON DE PADRES Y TUTORES
        private void btnPadreOTutor2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
                modpadre.Show();
            }
        }

        //BOTON DE PROFESORES
        private void btnProfesores2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloProfesores modprofesor = new ModuloProfesores();
                modprofesor.Show();
            }
        }

        //BOTON DE DINAMICAS
        private void btnDinamicas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloDinamicas moddinamica = new ModuloDinamicas();
                moddinamica.Show();
            }
        }

        //BOTON DE MATERIALES
        private void btnMaterial2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloMaterial modmaterial = new ModuloMaterial();
                modmaterial.Show();
            }
        }

        //BOTON DE PAGOS
        private void btnPagos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloPagos pago = new ModuloPagos();
                pago.Show();
            }
        }

        //BOTON DE INCIDENCIAS
        private void btnIncidencias2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloIncidencias incidencia = new ModuloIncidencias();
                incidencia.Show();
            }
        }

        //BOTON DE RECOMENDACIONES
        private void btnRecomendaciones2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloRecomendaciones recomendaciones = new ModuloRecomendaciones();
                recomendaciones.Show();
            }
        }

        private void btnAgregarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;
        }

        private void btnModificarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;
        }

        private void btnEliminarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbEscuelaRec.Text != "" && cbTallerRec.Text != "" && cbDinamicaRec.Text != "" && cbMaterialRec.Text != "" && txtIdRecomendacion.Text != "" && txtEspecificacionesRec.Text != "" && txtRecomendacionUsoRec.Text != "")
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(opcionBotones == 0)
                    {

                    } else if (opcionBotones == 1)
                    {

                    } else if (opcionBotones == 2)
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }

        private void txtBuscadorRecomendacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
