using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_maestros1
{
    public partial class ModuloPagos : Form
    {
        public ModuloPagos()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                principal principal = new principal();
                principal.Show();
            }
        }

        private void btnAlumnos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloAlumnos modalumno = new ModuloAlumnos();
                modalumno.Show();
            }
        }

        private void btnEscuelas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloEscuelas modescuela = new ModuloEscuelas();
                modescuela.Show();
            }
        }

        private void btnTalleres2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloTalleres modtaller = new ModuloTalleres();
                modtaller.Show();
            }
        }

        private void btnPadreOTutor2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
                modpadre.Show();
            }
        }

        private void btnProfesores2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloProfesores modprofesor = new ModuloProfesores();
                modprofesor.Show();
            }
        }

        private void btnDinamicas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloDinamicas moddinamica = new ModuloDinamicas();
                moddinamica.Show();
            }
        }

        private void btnMaterial2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloMaterial modmaterial = new ModuloMaterial();
                modmaterial.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

                ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
                recomendacion.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtIdAlumnoPagos.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    //wsPHP.buscarPagos(txtIdAlumnoPagos.Text);
                    DataTable dt = new DataTable();
                    dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtIdAlumnoPagos.Text), typeof(DataTable));
                    dgvPagos.DataSource = dt;
                    NombresColumnasPagos();
                    
                    //try
                    //{
                    //    
                    //
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("No se encontro ningun pago con el nombre del alumno que indicaste, Por favor ingrese un nombre de alumno orrecto", "No existe este tutor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //    //cargarDatosTabla();
                    //}
                }
            }
            else
            {
                MessageBox.Show("Primero indique un alumno para poder hacer su busqueda de pagos", "Seleccione Alumno para busqueda de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


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

        private void ModuloPagos_Load(object sender, EventArgs e)
        {
            cargarDatosTablaAlumnos();
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
                        cbEscuelaPagos.Items.Add(item);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbEscuelaPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {


                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaPagos.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);



                foreach (var nomEsc in respEsc)
                {
                    //cbEscuelaAlumno.ValueMember = nomEsc.es_id_escuela;
                    //cbEscuelaAlumno.DisplayMember = nomEsc.es_nombre_escuela;
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    //cbEscuelaAlumno.Items.Add(nomEsc.es_nombre_escuela.ToString());
                    string id = item.Value.ToString();
                    txtIdEscuela1.Text = id;
                }

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela1.Text), typeof(DataTable));
                dgvAlumnoPagos.DataSource = dt;
            }
        }



        public void cargarDatosTablaAlumnos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela1.Text), typeof(DataTable));
                    dgvAlumnoPagos.DataSource = dt;
                    NombresColumnasAlumno();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAlumnoPagos_TextChanged(object sender, EventArgs e)
        {
            if (txtAlumnoPagos.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumnosPagos(txtIdEscuela1.Text,txtAlumnoPagos.Text), typeof(DataTable));
                        dgvAlumnoPagos.DataSource = dt;
                        NombresColumnasAlumno();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ningun alumno con estos datos, Por favor ingrese un nombre o ID Alumno correcto", "No existe este alumno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cargarDatosTablaAlumnos();
                    }
                }
            }
            else
                cargarDatosTablaAlumnos();
        }

        private void dgvAlumnoPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAlumnoPagos.Text = Convert.ToString(dgvAlumnoPagos.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtAlumnoPagos.Text = Convert.ToString(dgvAlumnoPagos.Rows[e.RowIndex].Cells[2].Value.ToString());
            cargarDatosTablaAlumnosTodos();
        }

        public void cargarDatosTablaAlumnosTodos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnoPagos.DataSource = dt;
                    NombresColumnasAlumno();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void cargarDatosTablaPagos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtNomAlumnoPagos.Text), typeof(DataTable));
                    dgvPagos.DataSource = dt;
                    NombresColumnasPagos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NombresColumnasAlumno()
        {
            dgvAlumnoPagos.Columns[0].HeaderText = "Escuela";
            dgvAlumnoPagos.Columns[1].HeaderText = "ID Alumno";
            dgvAlumnoPagos.Columns[2].HeaderText = "Nombre(s)";
            dgvAlumnoPagos.Columns[3].HeaderText = "Apellido Paterno";
            dgvAlumnoPagos.Columns[4].HeaderText = "Apellido Materno";
            dgvAlumnoPagos.Columns[5].HeaderText = "Grado";
            dgvAlumnoPagos.Columns[6].HeaderText = "Nivel Educativo";
            dgvAlumnoPagos.Columns[7].HeaderText = "Status";
        }

        public void NombresColumnasPagos()
        {
            dgvPagos.Columns[0].HeaderText = "Escuela";
            dgvPagos.Columns[1].HeaderText = "Alumno";
            dgvPagos.Columns[2].HeaderText = "ID Pago";
            dgvPagos.Columns[3].HeaderText = "Enero";
            dgvPagos.Columns[4].HeaderText = "Febrero";
            dgvPagos.Columns[5].HeaderText = "Marzo";
            dgvPagos.Columns[6].HeaderText = "Abril";
            dgvPagos.Columns[7].HeaderText = "Mayo";
            dgvPagos.Columns[8].HeaderText = "Junio";
            dgvPagos.Columns[9].HeaderText = "Julio";
            dgvPagos.Columns[10].HeaderText = "Agosto";
            dgvPagos.Columns[11].HeaderText = "Septiembre";
            dgvPagos.Columns[12].HeaderText = "Octubre";
            dgvPagos.Columns[13].HeaderText = "Noviembre";
            dgvPagos.Columns[14].HeaderText = "Diciembre";
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnasPagos();

            txtIdPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtEscuelaPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNomAlumnoPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[1].Value.ToString());

        }

        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    string mes = "pa_fecha_" + cbMesPagos.Text + "_pago";
                    string mensaje = wsPHP.modificarPagos(txtIdPagos.Text, mes, Convert.ToString(dtFechaPagos.Value.ToString("yyyy-MM-dd")));
                    MessageBox.Show(mensaje, "¡Pago Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //try
                    //{
                    //    
                    //    
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Ha ocurrido un error, no se ha podido actualizar los datos", "¡Error al registrar el pago!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                cargarDatosTablaPagos();
            }
        }
    }
}
