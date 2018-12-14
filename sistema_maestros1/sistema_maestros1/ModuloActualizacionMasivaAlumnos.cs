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

namespace sistema_maestros1
{
    public partial class ModuloActualizacionMasivaAlumnos : Form
    {
        public ModuloActualizacionMasivaAlumnos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de realizar esta accion?\nSi realiza esta operacion todos los alumnos de la escuela seleccionada subiran de grado o nivel educativo dependiendo el caso\nSi la escuela cuenta con el siguiente nivel educativo de los alumnos de ultimo grado, seran actualizados a ese nivel\nSi la escuela no cuenta con el siguiente nivel educativo, el status de los alumnos de ultimo grado sera INACTIVO", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                webservices3435.WSPHP ws = new webservices3435.WSPHP();
                String respuestaEscuela = ws.consultaNiveles(txtIdEscuela.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaEscuela);
                string[] niveles = new string[3];
                int j = 0;
                foreach (var nomEsc in respEsc)
                {
                    niveles[j] = nomEsc.ne_nivel_educativo_niveles_escuela;
                    j++;
                }

                for (int i = 0; i <= j; i++)
                {
                    if (niveles[i] == "SECUNDARIA")
                    {
                        ws.validarGrado(txtIdEscuela.Text);
                        ws.actualizarGrupos("3", "2", txtIdEscuela.Text, "SECUNDARIA");
                        ws.actualizarGrupos("2", "1", txtIdEscuela.Text, "SECUNDARIA");
                    }
                    else if (niveles[i] == "PRIMARIA")
                    {
                        ws.actualizarNivel("SECUNDARIA", "PRIMARIA", txtIdEscuela.Text, "6");
                        ws.actualizarGrupos("6", "5", txtIdEscuela.Text, "PRIMARIA");
                        ws.actualizarGrupos("5", "4", txtIdEscuela.Text, "PRIMARIA");
                        ws.actualizarGrupos("4", "3", txtIdEscuela.Text, "PRIMARIA");
                        ws.actualizarGrupos("3", "2", txtIdEscuela.Text, "PRIMARIA");
                        ws.actualizarGrupos("2", "1", txtIdEscuela.Text, "PRIMARIA");
                    }
                    else if (niveles[i] == "PRESCOLAR")
                    {
                        ws.actualizarNivel("PRIMARIA", "PRESCOLAR", txtIdEscuela.Text, "3");
                        ws.actualizarGrupos("3", "2", txtIdEscuela.Text, "PRESCOLAR");
                        ws.actualizarGrupos("2", "1", txtIdEscuela.Text, "PRESCOLAR");
                    }
                }
                MessageBox.Show("El nivel y grado de todos los alumnos de la escuela " + cbEscuela.Text + " han sido actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela.Text), typeof(DataTable));
                    dgvAlumnos.DataSource = dt;
                    dgvAlumnos.ClearSelection();
                    NombresColumnas();
                }
                btnActualizarGrado.Visible = false;
                btnCargarTodo.Visible = true;
                cbEscuela.Text = "Seleccionar Escuela";
                
            }
        }

        private void ModuloActualizacionMasivaAlumnos_Load(object sender, EventArgs e)
        {
            cargarDatosTabla();
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    String respuestaEscuela = wsPHP.cargarDatosEscuela();
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomEsc.es_nombre_escuela;
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        cbEscuela.Items.Add(item);

                    }

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuela.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuela.Text = id;
                }
                DataTable dt = new DataTable();
                dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela.Text), typeof(DataTable));
                dgvAlumnos.DataSource = dt;
                if(dgvAlumnos.RowCount != 0)
                    NombresColumnas();
            }
        }

        public void NombresColumnas()
        {
            dgvAlumnos.Columns[0].HeaderText = "Escuela";
            dgvAlumnos.Columns[1].HeaderText = "ID Alumno";
            dgvAlumnos.Columns[2].HeaderText = "Nombre(s)";
            dgvAlumnos.Columns[3].HeaderText = "Apellido Paterno";
            dgvAlumnos.Columns[4].HeaderText = "Apellido Materno";
            dgvAlumnos.Columns[5].HeaderText = "Grado";
            dgvAlumnos.Columns[6].HeaderText = "Nivel Escolar";
            dgvAlumnos.Columns[7].HeaderText = "Status";
        }

        public void cargarDatosTabla()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnos.DataSource = dt;

                    dgvAlumnos.ClearSelection();
                    NombresColumnas();

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

        private void btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Menu'?", "¡Ir a Menu!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                principal principal = new principal();
                principal.Show();

            }
        }

        private void btnAlumnos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Alumnos'?", "¡Modulo Alumnos!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloAlumnos modalumno = new ModuloAlumnos();
                modalumno.Show();

            }
        }

        private void btnEscuelas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Escuelas'?", "¡Modulo Escuelas!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloEscuelas modescuela = new ModuloEscuelas();
                modescuela.Show();

            }
        }

        private void btnTalleres2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Talleres'?", "¡Modulo Talleres!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloTalleres modtaller = new ModuloTalleres();
                modtaller.Show();
            }
        }

        private void btnPadreOTutor2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Padre o Tutor'?", "¡Modulo Padre o Tutor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
                modpadre.Show();

            }
        }

        private void btnProfesores2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Profesores'?", "¡Modulo Profesores!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloProfesores modprofesor = new ModuloProfesores();
                modprofesor.Show();

            }
        }

        private void btnDinamicas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Dinamicas'?", "¡Modulo Dinamicas!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloDinamicas moddinamica = new ModuloDinamicas();
                moddinamica.Show();

            }
        }

        private void btnMaterial2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Materiales'?", "¡Modulo Materiales!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                ModuloMaterial modmaterial = new ModuloMaterial();
                modmaterial.Show();

            }
        }

        private void btnPagos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Materiales'?", "¡Modulo Materiales!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloPagos pago = new ModuloPagos();
                pago.Show();
            }
        }

        private void btnIncidencias2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloIncidencias incidencia = new ModuloIncidencias();
                incidencia.Show();
            }
        }

        private void btnRecomendaciones2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
                recomendacion.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarDatosTabla();
            btnCargarTodo.Visible = false;
            btnActualizarGrado.Visible = true;
        }
    }
}
