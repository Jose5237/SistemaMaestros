using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using variablesGlobales;

namespace sistema_maestros1
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            lblNombreUsuario.Text = Globales.usuario;
        }

        int presionado = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(presionado == 0)
            {
                btnMenuPrincipal.Visible = false;
                btnMenuPrincipal2.Visible = true;

                groupBoxEscuelas.Visible = false;
                groupBoxTalleres.Visible = false;

                btnEscuelas2.Visible = true;
                btnAlumnos2.Visible = true;
                btnTalleres2.Visible = true;
                btnPadreOTutor2.Visible = true;
                btnDinamicas2.Visible = true;
                btnMaterial2.Visible = true;
                btnProfesores2.Visible = true;
                btnPagos2.Visible = true;
                btnIncidencias2.Visible = true;
                btnRecomendaciones2.Visible = true;


                presionado = 1;

            }






        }

        private void btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            if (presionado == 1)
            {
                btnMenuPrincipal2.Visible = false;
                btnMenuPrincipal.Visible = true;

                groupBoxEscuelas.Visible = true;
                groupBoxTalleres.Visible = true;

                btnEscuelas2.Visible = false;
                btnAlumnos2.Visible = false;
                btnTalleres2.Visible = false;
                btnPadreOTutor2.Visible = false;
                btnDinamicas2.Visible = false;
                btnMaterial2.Visible = false;
                btnProfesores2.Visible = false;
                btnPagos2.Visible = false;
                btnIncidencias2.Visible = false;
                btnRecomendaciones2.Visible = false;



                presionado = 0;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesión?", "¡Cerrar sesión!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void esconder_pantalla_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAlumnos1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAlumnos modalumno = new ModuloAlumnos();
            modalumno.Show();
        }

        private void btnEscuela1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloEscuelas modescuela = new ModuloEscuelas();
            modescuela.Show();
        }

        private void btnTalleres1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloTalleres modtaller = new ModuloTalleres();
            modtaller.Show();
        }

        private void btnPadreOTutor1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
            modpadre.Show();
        }

        private void btnProfesores1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloProfesores modprofe = new ModuloProfesores();
            modprofe.Show();
        }

        private void btnDinamicas1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloDinamicas moddinamica = new ModuloDinamicas();
            moddinamica.Show();
        }

        private void btnMateriales1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloMaterial modmaterial = new ModuloMaterial();
            modmaterial.Show();
        }

        private void btnPagos1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloPagos pago = new ModuloPagos();
            pago.Show();
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

                ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
                recomendacion.Show();
            }
        }

        private void btnIncidencias1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloIncidencias incidencia = new ModuloIncidencias();
            incidencia.Show();
        }

        private void btnRecomendaciones1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
            recomendacion.Show();
        }

        private void btnAlumnos2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAlumnos modalumno = new ModuloAlumnos();
            modalumno.Show();
        }

        private void btnEscuelas2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloEscuelas modescuela = new ModuloEscuelas();
            modescuela.Show();
        }

        private void btnTalleres2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloTalleres modtaller = new ModuloTalleres();
            modtaller.Show();
        }

        private void btnPadreOTutor2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
            modpadre.Show();
        }

        private void btnProfesores2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloProfesores modprofe = new ModuloProfesores();
            modprofe.Show();
        }

        private void btnDinamicas2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloDinamicas moddinamica = new ModuloDinamicas();
            moddinamica.Show();
        }

        private void btnMaterial2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloMaterial modmaterial = new ModuloMaterial();
            modmaterial.Show();
        }

        private void btnPagos2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloPagos pago = new ModuloPagos();
            pago.Show();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    String respuestaTaller = wsPHP.cargarDatosDeTaller();
                    var respTal = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);



                    foreach (var nomTal in respTal)
                    {
                        listTaller.Items.Add(nomTal.ta_nombre_taller);
                        
                    }

                    String respuestaEscuela = wsPHP.cargarDatosEscuela();
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);



                    foreach (var nomEsc in respEsc)
                    {
                        listEscuela.Items.Add(nomEsc.es_nombre_escuela);

                    }


                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
