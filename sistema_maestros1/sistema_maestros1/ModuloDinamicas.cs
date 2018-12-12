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

using variablesGlobales;

namespace sistema_maestros1
{
    public partial class ModuloDinamicas : Form
    {

        Validaciones v = new Validaciones();

        public ModuloDinamicas()
        {
            InitializeComponent();
        }

        //VARIABLES
        int opcionBotones = 0;

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

        //BOTON DE DINAMICAS (NO HACE NADA)
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

                ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
                recomendacion.Show();
            }
        }

        #endregion


        //METODOS DE VALIDACIONES
        #region

        //METODO DE txtHabilidadesDinamicas PARA ACEPTAR SOLO LETRAS
        private void txtHabilidadesDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetrasYComas(e);
        }

        private void cbEscuelaDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTallerDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaIniDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaFinDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON AGREGAR DINAMICA
        private void btnAgregarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvDinamica.Enabled = false;

            cbEscuelaDinamicas.Enabled = true; cbEscuelaDinamicas.Text = "Seleccionar Escuela";
            txtIdEscuela.Text = "";

            cbTallerDinamicas.Enabled = true; cbTallerDinamicas.Text = "Seleccionar Taller";
            txtIdTaller.Text = "";
            txtFechaIniTaller.Text = "";
            txtFechaIniTaller.Text = "";
            txtFechaFinTaller.Text = "";

            txtIdDinamicas.Text = "";
            txtNombreDinamicas.Enabled = true; txtNombreDinamicas.Text = "";
            txtDescripcionDinamicas.Enabled = true; txtDescripcionDinamicas.Text = "";

            dtFechaIniDinamicas.Enabled = true;
            dtFechaFinDinamicas.Enabled = true;
            dtFechaFinDinamicas.Value = dtFechaIniDinamicas.Value.AddDays(1);
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            
            txtHabilidadesDinamicas.Enabled = true; txtHabilidadesDinamicas.Text = "";
            txtJustificacionCostoDinamicas.Enabled = true; txtJustificacionCostoDinamicas.Text = "";
            txtHerramientasDinamicas.Enabled = true; txtHerramientasDinamicas.Text = "";

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true;


        }

        //BOTON MODIFICAR DINAMICA
        private void btnModificarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;
            dgvDinamica.Enabled = true;

            cbEscuelaDinamicas.Enabled = false;
            cbTallerDinamicas.Enabled = false;
            txtIdDinamicas.Enabled = false;
            txtNombreDinamicas.Enabled = true; 
            txtDescripcionDinamicas.Enabled = true; 
            dtFechaIniDinamicas.Enabled = true;
            dtFechaFinDinamicas.Enabled = true;
            txtHabilidadesDinamicas.Enabled = true;
            txtJustificacionCostoDinamicas.Enabled = true; 
            txtHerramientasDinamicas.Enabled = true;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true;

        }

        //BOTON ELIMINAR DINAMICA
        private void btnEliminarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;
            dgvDinamica.Enabled = true;

            cbEscuelaDinamicas.Enabled = false;
            txtIdEscuela.Enabled = false;

            cbTallerDinamicas.Enabled = false;
            txtIdTaller.Enabled = false;

            txtIdDinamicas.Enabled = false;
            txtNombreDinamicas.Enabled = false;

            txtDescripcionDinamicas.Enabled = false;
            dtFechaIniDinamicas.Enabled = false;
            dtFechaFinDinamicas.Enabled = false;
            txtHabilidadesDinamicas.Enabled = false;
            txtJustificacionCostoDinamicas.Enabled = false;
            txtHerramientasDinamicas.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true;



        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaDinamicas.Text != "" && txtIdEscuela.Text != "") && (cbTallerDinamicas.Text != "" && txtIdTaller.Text != "") && (txtNombreDinamicas.Text != "") && (txtDescripcionDinamicas.Text != "") && (dtFechaIniDinamicas.Text != "") && (dtFechaFinDinamicas.Text != "") && (txtHabilidadesDinamicas.Text != "") && (txtJustificacionCostoDinamicas.Text != "") && (txtHerramientasDinamicas.Text != ""))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txtFechaInicio.Text = dtFechaIniDinamicas.Text;
                    txtFechaFin.Text = dtFechaFinDinamicas.Text;

                    if (opcionBotones == 0)
                    {
                        generarID();
                        ClassDinamica di = new ClassDinamica();
                        di.di_id_escuela = txtIdEscuela.Text;
                        di.di_id_taller = txtIdTaller.Text;
                        di.di_id_dinamica = label13.Text;
                        di.di_nombre_dinamica = txtNombreDinamicas.Text;
                        di.di_descripcion_dinamica = txtDescripcionDinamicas.Text;
                        di.di_fecha_ini_dinamica = dtFechaIniDinamicas.Text;
                        di.di_fecha_fin_dinamica = dtFechaFinDinamicas.Text;
                        di.di_habilidades_dinamica = txtHabilidadesDinamicas.Text;
                        di.di_justificacioncosto_dinamica = txtJustificacionCostoDinamicas.Text;
                        di.di_herramientas_dinamica = txtHerramientasDinamicas.Text;


                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {

                            int validarfechasiguales = wsPHP.validarDinamicaXtaller(di.di_id_escuela, di.di_id_taller, di.di_fecha_ini_dinamica);
                            if (validarfechasiguales > 0)
                            {
                                MessageBox.Show("Ya existe una dinamica de este taller en este mismo periodo de tiempo, favor de seleccionar una fecha diferente", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string mensaje = wsPHP.agregarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica, di.di_nombre_dinamica, di.di_descripcion_dinamica, di.di_fecha_ini_dinamica, di.di_fecha_fin_dinamica, di.di_habilidades_dinamica, di.di_justificacioncosto_dinamica, di.di_herramientas_dinamica);
                                MessageBox.Show(mensaje, "¡Dinamica Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarDatosTabla();
                                inicializacionCampos();

                            }
                        }

                    }
                    else if (opcionBotones == 1)
                    {
                        ClassDinamica di = new ClassDinamica();
                        di.di_id_escuela = txtIdEscuela.Text;
                        di.di_id_taller = txtIdTaller.Text;
                        di.di_id_dinamica = txtIdDinamicas.Text;
                        di.di_nombre_dinamica = txtNombreDinamicas.Text;
                        di.di_descripcion_dinamica = txtDescripcionDinamicas.Text;
                        di.di_fecha_ini_dinamica = dtFechaIniDinamicas.Text;
                        di.di_fecha_fin_dinamica = dtFechaFinDinamicas.Text;
                        di.di_habilidades_dinamica = txtHabilidadesDinamicas.Text;
                        di.di_justificacioncosto_dinamica = txtJustificacionCostoDinamicas.Text;
                        di.di_herramientas_dinamica = txtHerramientasDinamicas.Text;


                        int validarfechasiguales;
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {


                            if (txtFechaInicio.Text != dgvDinamica.CurrentRow.Cells[5].Value.ToString())
                            {
                                validarfechasiguales = wsPHP.validarDinamicaXtaller(di.di_id_escuela, di.di_id_taller, di.di_fecha_ini_dinamica);
                                if (validarfechasiguales == 0)
                                {
                                    string mensaje = wsPHP.modificarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica, di.di_nombre_dinamica, di.di_descripcion_dinamica, di.di_fecha_ini_dinamica, di.di_fecha_fin_dinamica, di.di_habilidades_dinamica, di.di_justificacioncosto_dinamica, di.di_herramientas_dinamica);
                                    MessageBox.Show(mensaje, "¡Dinamica Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarDatosTabla();
                                    inicializacionCampos();
                                }
                                else
                                {
                                    MessageBox.Show("Ya existe una dinamica de este taller en este mismo periodo de tiempo, favor de seleccionar una fecha diferente", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                validarfechasiguales = 0;
                                if (validarfechasiguales == 0)
                                {
                                    string mensaje = wsPHP.modificarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica, di.di_nombre_dinamica, di.di_descripcion_dinamica, di.di_fecha_ini_dinamica, di.di_fecha_fin_dinamica, di.di_habilidades_dinamica, di.di_justificacioncosto_dinamica, di.di_herramientas_dinamica);
                                    MessageBox.Show(mensaje, "¡Dinamica Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarDatosTabla();
                                    inicializacionCampos();
                                }
                                else if (validarfechasiguales > 0)
                                {
                                    MessageBox.Show("Ya existe una dinamica de este taller en este mismo periodo de tiempo, favor de seleccionar una fecha diferente", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }


                        }

                    }
                    else if (opcionBotones == 2)
                    {
                        ClassDinamica di = new ClassDinamica();
                        di.di_id_escuela = txtIdEscuela.Text;
                        di.di_id_taller = txtIdTaller.Text;
                        di.di_id_dinamica = txtIdDinamicas.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica);
                            MessageBox.Show(mensaje, "¡Dinamica Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatosTabla();
                            inicializacionCampos();
                        }


                    }

                    dgvDinamica.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }


        //SELECTEDINDEX DE COMBOBOX
        #region

        private void cbEscuelaDinamicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaDinamicas.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                
                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuela.Text = id;
                }

                //TALLER
                String respuestaTal = wsPHP.buscarTaller(txtIdEscuela.Text);
                var resptal = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTal);
                cbTallerDinamicas.Items.Clear();
                foreach (var nomtal in resptal)
                {
                    ComboBoxItem item = new ComboBoxItem();

                    item.Text = nomtal.ta_nombre_taller;
                    item.Value = Convert.ToString(nomtal.ta_id_taller);
                    string id = item.Value.ToString();

                    cbTallerDinamicas.Items.Add(item);
                }

            }
        }

        private void cbTallerDinamicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaTaller = wsPHP.buscarTaller(cbTallerDinamicas.Text);
                var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);
                
                foreach (var nomTall in respTall)
                {

                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomTall.ta_id_taller);
                    
                    txtFechaIniTaller.Text = Convert.ToString(nomTall.ta_fecha_ini_taller);
                    txtFechaFinTaller.Text = Convert.ToString(nomTall.ta_fecha_fin_taller);

                    string id = item.Value.ToString();
                    txtIdTaller.Text = id;
                }
            }
        }


        #endregion


        //EVENTO_VALUE DATETIME FECHAS
        #region

        private void dtFechaIniDinamicas_ValueChanged(object sender, EventArgs e)
        {

            txtFechaInicio.Text = Convert.ToString(dtFechaIniDinamicas.Value);

            if (dtFechaIniDinamicas.Value.Date < Convert.ToDateTime(txtFechaIniTaller.Text))
            {
                MessageBox.Show("¡ERROR! No puedes asignarle una fecha menor a la dinamica de la fecha de inicio de un taller", "¡ERROR EN LAS FECHAS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaIniDinamicas.Value = Convert.ToDateTime(txtFechaIniTaller.Text);
            }
            if (dtFechaIniDinamicas.Value.Date > Convert.ToDateTime(txtFechaFinTaller.Text))
            {
                MessageBox.Show("¡ERROR! No puedes asignarle una fecha de termino de dinamica 'MAYOR' a la de fecha de inicio de un taller", "¡ERROR EN LAS FECHAS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaIniDinamicas.Value = Convert.ToDateTime(txtFechaIniTaller.Text);
            }
        }

        private void dtFechaFinDinamicas_ValueChanged(object sender, EventArgs e)
        {

            txtFechaFin.Text = Convert.ToString(dtFechaFinDinamicas.Value);

            if (((dtFechaFinDinamicas.Value.Month == dtFechaIniDinamicas.Value.Month) && (dtFechaFinDinamicas.Value.Day >= dtFechaIniDinamicas.Value.Day)))
            {

            }
            else if ((dtFechaFinDinamicas.Value.Year < dtFechaIniDinamicas.Value.Year) || (dtFechaFinDinamicas.Value.Month < dtFechaIniDinamicas.Value.Month) || ((dtFechaFinDinamicas.Value.Month == dtFechaIniDinamicas.Value.Month) && (dtFechaFinDinamicas.Value.Day < dtFechaIniDinamicas.Value.Day)))
            {
                MessageBox.Show("¡ERROR! No puedes ingresar una fecha de termino menor a la fecha de inicio de un taller", "¡ERROR EN LAS FECHAS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaFinDinamicas.Value = dtFechaIniDinamicas.Value.AddDays(1);
            }
            if (txtFechaFinTaller.Text != "" && txtFechaFin.Text != "")
            {
                if (Convert.ToDateTime(txtFechaFin.Text) > Convert.ToDateTime(txtFechaFinTaller.Text))
                {
                    MessageBox.Show("¡ERROR! No puedes ingresar una fecha de termino mayor a la fecha de termino de un taller", "¡ERROR EN LAS FECHAS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtFechaFinDinamicas.Value = Convert.ToDateTime(txtFechaFinTaller.Text);
                }
            }
        }

        #endregion


        //LOAD
        private void ModuloDinamicas_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    cargarDatosTabla();


                    String respuestaEscuela = wsPHP.cargarDatosEscuela();
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                    
                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomEsc.es_nombre_escuela;
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        cbEscuelaDinamicas.Items.Add(item);

                    }

                    //TALLER
                    String respuestaTaller = wsPHP.cargarDatosDeTaller();
                    var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);
                    
                    foreach (var nomTall in respTall)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomTall.ta_nombre_taller;
                        item.Value = Convert.ToString(nomTall.ta_id_taller);
                        cbTallerDinamicas.Items.Add(item);
                    }

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        //CELLCONTENT (DGV)
        private void dgvDinamica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

            NombresColumnas();

            webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();

            txtIdEscuela.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[0].Value.ToString());
            String resNombreEscuela = wsPHP.buscarEscuela(txtIdEscuela.Text);
            var nomEscuela = JsonConvert.DeserializeObject<List<ClassEscuela>>(resNombreEscuela);
            
            foreach (var nombreEscuela in nomEscuela)
            {
                cbEscuelaDinamicas.Text = Convert.ToString(nombreEscuela.es_nombre_escuela);
            }
            
            txtIdTaller.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[1].Value.ToString());
            String resNombreTaller = wsPHP.buscarTallerXIDescuela(txtIdEscuela.Text ,txtIdTaller.Text);
            var nomTaller = JsonConvert.DeserializeObject<List<ClassTaller>>(resNombreTaller);
            
            foreach (var nombreTaller in nomTaller)
            {
                cbTallerDinamicas.Text = Convert.ToString(nombreTaller.ta_nombre_taller);
            }
            
            
            String resFechaIniTal = wsPHP.buscarTallerXIDescuela(txtIdEscuela.Text, txtIdTaller.Text);
            var des_fechaI_ta = JsonConvert.DeserializeObject<List<ClassTaller>>(resFechaIniTal);
            
            foreach (var fechIT in des_fechaI_ta)
            {
                
                txtFechaIniTaller.Text = Convert.ToString(fechIT.ta_fecha_ini_taller);
                txtFechaFinTaller.Text = Convert.ToString(fechIT.ta_fecha_fin_taller);
                
            }
            
            txtIdDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtNombreDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtDescripcionDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[4].Value.ToString());
            string fechaI = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[5].Value.ToString());
            string fechaF = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtHabilidadesDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[7].Value.ToString());
            txtJustificacionCostoDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtHerramientasDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[9].Value.ToString());
            
            string newI = fechaI.Replace("-", "/");
            txtFechaInicio.Text = newI;
            dtFechaIniDinamicas.Value = DateTime.ParseExact(newI, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            string newF = fechaF.Replace("-", "/");
            txtFechaFin.Text = newF;
            dtFechaFinDinamicas.Value = DateTime.ParseExact(newF, "yyyy/MM/dd", CultureInfo.InvariantCulture);
        }

        
        //BUSCADOR DE DINAMICAS
        private void txtBuscadorDinamicas_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorDinamicas.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {

                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarDinamica(txtBuscadorDinamicas.Text), typeof(DataTable));
                        dgvDinamica.DataSource = dt;
                        NombresColumnas();
                        
                    }
                    catch
                    {
                        MessageBox.Show("No se encuentra ningun taller con estos datos, Por favor ingrese un nombre o ID Taller correcto", "No existe este taller", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cargarDatosTabla();
                    }
                }
            }
            else
                cargarDatosTabla();
        }


        //METODOS FACILITADORES 'cargarDatosTabla(), generarID(), NombresColumnas(), inicializacionCampos()'
        #region

        public void cargarDatosTabla()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosDinamica(), typeof(DataTable));
                    dgvDinamica.DataSource = dt;
                    NombresColumnas();
                    dgvDinamica.ClearSelection();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void generarID()
        {
            webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();
            string sub1, sub2, newID, ultimoID;
            int n;
            //guardar dpro|dele|dqui
            sub1 = "d" + cbTallerDinamicas.Text.Substring(0, 3);
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.buscarMAXIDD(txtIdEscuela.Text, txtIdTaller.Text, sub1);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(4, 3));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (3 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label13.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvDinamica.Columns[0].HeaderText = "Escuela";
            dgvDinamica.Columns[1].HeaderText = "Taller";
            dgvDinamica.Columns[2].HeaderText = "ID Dinamica";
            dgvDinamica.Columns[3].HeaderText = "Nombre Dinamica";
            dgvDinamica.Columns[4].HeaderText = "Descripcion";
            dgvDinamica.Columns[5].HeaderText = "Fecha de Inicio";
            dgvDinamica.Columns[6].HeaderText = "Fecha de Termino";
            dgvDinamica.Columns[7].HeaderText = "Habilidades a desarrollar";
            dgvDinamica.Columns[8].HeaderText = "Justificacion de costo";
            dgvDinamica.Columns[9].HeaderText = "Herramientas";
        }

        public void inicializacionCampos()
        {
            cbEscuelaDinamicas.Enabled = false; cbEscuelaDinamicas.Text = "Seleccionar Escuela";
            txtIdEscuela.Enabled = false; txtIdEscuela.Text = "";

            cbTallerDinamicas.Enabled = false; cbTallerDinamicas.Text = "Seleccionar Taller";
            txtIdTaller.Enabled = false; txtIdTaller.Text = "";
            txtFechaIniTaller.Text = "";
            txtFechaFinTaller.Text = "";

            txtIdDinamicas.Enabled = false; txtIdDinamicas.Text = "";
            txtNombreDinamicas.Enabled = false; txtNombreDinamicas.Text = "";
            txtDescripcionDinamicas.Enabled = false; txtDescripcionDinamicas.Text = "";
            dtFechaIniDinamicas.Enabled = false;
            dtFechaFinDinamicas.Enabled = false;
            txtHabilidadesDinamicas.Enabled = false; txtHabilidadesDinamicas.Text = "";
            txtJustificacionCostoDinamicas.Enabled = false; txtJustificacionCostoDinamicas.Text = "";
            txtHerramientasDinamicas.Enabled = false; txtHerramientasDinamicas.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }
        
        #endregion

    }
}
