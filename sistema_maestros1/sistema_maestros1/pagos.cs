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


        //EVENTO_CLICK BOTONES 'X COMUNES' DE MODULO
        #region

        //BOTON DE SALIR
        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                principal principal = new principal();
                principal.Show();
            }
        }

        //BOTON DE MINIMIZAR
        private void esconder_pantalla_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //BOTON MENU PRINCIPAL
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

        //BOTON DE PADRE O TUTOR
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

        //BOTON DE MATERIAL
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

        #endregion


        //VALIDACIONES
        #region

        private void cbMesPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON DE BUSCAR PAGOS DE ALUMNO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdAlumnoPagos.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    groupBox2.Visible = true;
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtIdAlumnoPagos.Text), typeof(DataTable));
                        dgvPagos.DataSource = dt;
                        NombresColumnasPagos();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encontro ningun pago con el nombre del alumno que indicaste, Por favor ingrese un nombre de alumno orrecto", "No existe este tutor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cargarDatosTablaAlumnosTodos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero indique un alumno para poder hacer su busqueda de pagos", "Seleccione Alumno para busqueda de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        //BOTON DE ACTUALIZAR PAGO
        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    try
                    {
                        string mes = "pa_fecha_" + cbMesPagos.Text + "_pago";
                        string mensaje = wsPHP.modificarPagos(txtIdPagos.Text, mes, Convert.ToString(dtFechaPagos.Value.ToString("yyyy-MM-dd")));
                        MessageBox.Show(mensaje, "¡Pago Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error, no se ha podido actualizar los datos", "¡Error al registrar el pago!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cargarDatosTablaPagos();
            }
        }


        //LOAD
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

        //SELECTEDINDEX DE COMBOBOX
        private void cbEscuelaPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaPagos.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                
                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuela1.Text = id;
                }

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela1.Text), typeof(DataTable));
                dgvAlumnoPagos.DataSource = dt;
            }
        }




        //BUSCADOR DE ALUMNOS
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


        //CELLCONTENT (DGV_ALUMNOS)
        private void dgvAlumnoPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAlumnoPagos.Text = Convert.ToString(dgvAlumnoPagos.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtAlumnoPagos.Text = Convert.ToString(dgvAlumnoPagos.Rows[e.RowIndex].Cells[2].Value.ToString());
            cargarDatosTablaAlumnosTodos();
            
        }


        //CELLCONTENT (DGV_PAGOS)
        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnasPagos();
            txtIdPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtEscuelaPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNomAlumnoPagos.Text = Convert.ToString(dgvPagos.Rows[e.RowIndex].Cells[1].Value.ToString());

        }


        //cargar datos de alumno dependiendo de la escuela
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

        //Cargar todos los alumnos en la tabla
        public void cargarDatosTablaAlumnosTodos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnoPagos.DataSource = dt;
                    NombresColumnasAlumno();
                    dgvAlumnoPagos.ClearSelection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Cargar tabla de pagos del alumno
        public void cargarDatosTablaPagos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtNomAlumnoPagos.Text), typeof(DataTable));
                    dgvPagos.DataSource = dt;
                    NombresColumnasPagos();
                    dgvPagos.ClearSelection();
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
            dgvPagos.Columns[2].Visible = false;
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


    }
}
