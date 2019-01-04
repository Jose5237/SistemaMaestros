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
    public partial class ModuloTalleres : Form
    {

        Validaciones v = new Validaciones();

        public ModuloTalleres()
        {
            InitializeComponent();
            
            //AutoCompletar();

        }

        //VARIABLES
        string auxgrados;
        string[] grados = new string[6];
        int j = 0, tallerexist;
        int opcionBotones = 3,val;
        DateTime fechaIDGV = new DateTime();
        DateTime fechaFDGV = new DateTime();
        webservices3435.WSPHP validar = new webservices3435.WSPHP();

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

        //BOTON DE TALLERES (NO HACE NADA)
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

                ModuloRecomendaciones recomendacion = new ModuloRecomendaciones();
                recomendacion.Show();
            }
        }

        #endregion


        //METODOS DE VALIDACIONES
        #region
        //METODO DE txtCostoTaller PARA ACEPTAR SOLO NUMEROS
        private void txtCostoTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtCostoTaller.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        //METODO PARA NO EDITAR EL TEXTO DE LOS COMBOBOX
        private void cbEscuelaTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //METODO PARA NO EDITAR EL TEXTO DE LOS DATE TIME PICKER
        private void dtFechaIniTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //METODO PARA NO EDITAR EL TEXTO DE LOS DATE TIME PICKER
        private void dtFechaFinTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //METODO PARA NO EDITAR EL TEXTO DE LOS COMBOBOX
        private void cbNivelTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //METODO PARA NO EDITAR EL TEXTO DE LOS COMBOBOX
        private void cbGradoTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        //BOTON AGREGAR TALLER
        private void btnAgregarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;
            dgvTaller.ClearSelection();
            vaciarEntradas();
            entradasDisponibles(opcionBotones);
            btnAceptar.BackColor = Color.MediumSeaGreen;

        }

        //BOTON MODIFICAR TALLER
        private void btnModificarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;
            entradasDisponibles(opcionBotones);
            dgvTaller.Enabled = true;
            cbEscuelaTaller.Enabled = false;
            cbNivelTaller.Enabled = false; 
            cbGradoTaller.Enabled = false;
            btnAceptar.BackColor = Color.SteelBlue;
        }

        //BOTON ELIMINAR TALLER
        private void btnEliminarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvTaller.Enabled = true;
            entradasDisponibles(opcionBotones);
            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Text = "Eliminar";
        }

        //METODO PARA VALIDAR FECHAS
        public int validarFechas(int valini, int valfin,char op)
        {
            //codigo para guardar los grados en un array y realizar la consulta de la bdd
            auxgrados = cbGradoTaller.Text;
            for (int i = 0; i < auxgrados.Length; i++)
            {
                grados[j] = Convert.ToString(auxgrados[i]);
                j++;
                i++;
            }
            if (auxgrados.Length < 4)
            {
                grados[1] = "0";
                grados[2] = "0";
            }
            else if (auxgrados.Length < 6)
                grados[2] = "0";
            tallerexist = validar.validarTallerXgrupo(txtIdEscuela.Text, cbNivelTaller.Text, grados[0], grados[1], grados[2], txtFechaInicio.Text);
            //Validaciones Fechas
            if (valini == 1)
            {
                if(op == 'm')
                {
                    if(dtFechaIniTaller.Value.Date > fechaIDGV)
                    {
                        if(dtFechaIniTaller.Value.Date > fechaFDGV)
                            MessageBox.Show("La fecha inicial del taller no puede ser mayor que la fecha final.\nPor favor seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            if (valini == 1 && valfin == 1)
                            {

                            }
                            if (valini == 1 && valfin != 1 || valini != 1 && valfin == 1)
                                return 1;
                        }
                    }
                }
                if(tallerexist >= 1)
                {
                    MessageBox.Show("La fecha inicial de este taller coincide con la fecha de otro taller.\nPor favor verifique que las fechas entre talleres sean distintias y seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (valini == 1 && valfin == 1)
                    {

                    }
                    if (valini == 1 && valfin != 1 || valini != 1 && valfin == 1)
                        return 1;
                }
                else
                {
                    if(dtFechaIniTaller.Value.Date > dtFechaFinTaller.Value.Date)
                    {
                        MessageBox.Show("La fecha inicial del taller no puede ser mayor a la fecha final.\nPor favor verifique las fechas y seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (valini == 1 && valfin == 1)
                        {

                        }
                        if (valini == 1 && valfin != 1 || valini != 1 && valfin == 1)
                            return 1;
                    }
                }
            }
            tallerexist = validar.validarTallerXgrupo(txtIdEscuela.Text, cbNivelTaller.Text, grados[0], grados[1], grados[2], txtFechaFin.Text);
            if (valfin == 1)
            {
                if (op == 'm')
                {
                    if(dtFechaFinTaller.Value.Date < fechaFDGV)
                    {
                        if(dtFechaFinTaller.Value.Date < fechaIDGV)
                        {
                            MessageBox.Show("La fecha final del taller no puede ser menor que la fecha inicial.\nPor favor seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                        return 1;
                    }
                }
                if (tallerexist >= 1)
                {
                    MessageBox.Show("La fecha final de este taller coincide con la fecha de otro taller.\nPor favor verifique que las fechas entre talleres sean distintias y seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
                else
                {
                    if (dtFechaFinTaller.Value.Date < dtFechaIniTaller.Value.Date)
                    {
                        MessageBox.Show("La fecha final del taller no puede ser menor a la fecha inicial.\nPor favor verifique las fechas y seleccione una distinta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                }
            }
            auxgrados = "";
            grados[0] = ""; grados[1] = ""; grados[2] = ""; grados[3] = ""; grados[4] = "";
            tallerexist = 0;
            j = 0;
            return 1;
        }
        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbEscuelaTaller.Text != "Seleccionar Escuela" && txtNombreTaller.Text != "" && txtCostoTaller.Text != "" && txtDescripcionTaller.Text != "" && dtFechaIniTaller.Text != "" && dtFechaFinTaller.Text != "" && cbNivelTaller.Text != "" && cbGradoTaller.Text != "" && cbProfeTaller.Text != "Seleccionar Profesor" && txtHabilidadesTaller.Text != "" && txtJustificacionCostoTaller.Text != "" && txtHerramientasTaller.Text != "")
            {
                webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();
                ClassTaller ta = new ClassTaller();
                ta.ta_id_escuela = txtIdEscuela.Text;
                ta.ta_nombre_taller = txtNombreTaller.Text;
                ta.ta_costo_taller = Convert.ToDouble(txtCostoTaller.Text);
                ta.ta_descripcion_taller = txtDescripcionTaller.Text;
                ta.ta_nivel_educativo_taller = cbNivelTaller.Text;
                ta.ta_grados_taller = cbGradoTaller.Text;
                ta.ta_fecha_ini_taller = txtFechaInicio.Text;
                ta.ta_fecha_fin_taller = txtFechaFin.Text;
                ta.ta_id_profesor = txtIdProfesorTaller.Text;
                ta.ta_habilidades_taller = txtHabilidadesTaller.Text;
                ta.ta_justificacioncosto_taller = txtJustificacionCostoTaller.Text;
                ta.ta_herramientas_taller = txtHerramientasTaller.Text;
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
                    {
                        if (validarFechas(1, 1,'a') == 1)
                        {
                            generarID();
                            ta.ta_id_taller = label16.Text;
                            try
                            {
                                string mensaje = wsPHP.agregarTaller(ta.ta_id_escuela, ta.ta_id_taller, ta.ta_nombre_taller, ta.ta_costo_taller, ta.ta_descripcion_taller, ta.ta_fecha_ini_taller, ta.ta_fecha_fin_taller, ta.ta_nivel_educativo_taller, ta.ta_grados_taller, ta.ta_id_profesor, ta.ta_habilidades_taller, ta.ta_justificacioncosto_taller, ta.ta_herramientas_taller);
                                MessageBox.Show(mensaje, "¡Taller Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvTaller.Enabled = true;
                                cargarDatosTabla();
                                vaciarEntradas();
                                entradasDisponibles(2);
                            }
                            catch
                            {
                                MessageBox.Show("No se pudo agregar este taller", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (opcionBotones == 1)
                    {
                        if (txtIdTaller.Text == "")
                            MessageBox.Show("Debes seleccionar antes un registro para editar", "ERROR");
                        else
                        {
                            ta.ta_id_taller = txtIdTaller.Text;
                            if (dtFechaIniTaller.Value.Date != fechaIDGV && dtFechaFinTaller.Value.Date != fechaFDGV)
                                val = validarFechas(1, 1, 'm');
                            else if (dtFechaIniTaller.Value.Date != fechaIDGV && dtFechaFinTaller.Value.Date == fechaFDGV)
                                val = validarFechas(1, 0, 'm');
                            else if (dtFechaIniTaller.Value.Date == fechaIDGV && dtFechaFinTaller.Value.Date != fechaFDGV)
                                val = validarFechas(0, 1, 'm');
                            else
                                val = 1;
                            if (val != 0)
                            {
                                try
                                {
                                    string mensaje = wsPHP.modificarTaller(ta.ta_id_escuela, ta.ta_id_taller, ta.ta_nombre_taller, ta.ta_costo_taller, ta.ta_descripcion_taller, ta.ta_fecha_ini_taller, ta.ta_fecha_fin_taller, ta.ta_nivel_educativo_taller, ta.ta_grados_taller, ta.ta_id_profesor, ta.ta_habilidades_taller, ta.ta_justificacioncosto_taller, ta.ta_herramientas_taller);
                                    MessageBox.Show(mensaje, "¡Taller Modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarDatosTabla();
                                    vaciarEntradas();
                                    entradasDisponibles(2);
                                }
                                catch
                                {
                                    MessageBox.Show("No se pudo modificar los datos de este taller", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (opcionBotones == 2)
                    {
                        if (txtIdTaller.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar antes un registro para Eliminar", "ERROR");
                        }
                        else
                        {
                            ta.ta_id_taller = txtIdTaller.Text;
                            ta.ta_id_escuela = txtIdEscuela.Text;
                            string mensaje = wsPHP.eliminarTaller(ta.ta_id_taller, ta.ta_id_escuela);
                            MessageBox.Show(mensaje, "¡Taller Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatosTabla();
                            vaciarEntradas();
                            entradasDisponibles(2);
                        } 
                    }
                }
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }
        //SELECTEDINDEX DE COMBOBOX
        #region

        private void cbEscuelaTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaTaller.Text);
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        string id = item.Value.ToString();
                        txtIdEscuela.Text = id;
                    }

                    String respuestaNivelE = wsPHP.consultaNiveles(txtIdEscuela.Text);
                    var respNiv = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaNivelE);
                    cbNivelTaller.Items.Clear();
                    foreach (var nomNiv in respNiv)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomNiv.ne_nivel_educativo_niveles_escuela;
                        item.Value = Convert.ToString(nomNiv.ne_id_escuela);

                        cbNivelTaller.Items.Add(item);
                    }
                }
            }
        }

        private void cbNivelTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            //{
            //    String respuestaNivelE = wsPHP.consultaNiveles(txtIdEscuelaNivel.Text);
            //    var respNiv = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaNivelE);
            //    //cbNivelTaller.Items.Clear();
            //    foreach (var nomNiv in respNiv)
            //    {
            //        ComboBoxItem item = new ComboBoxItem();
            //
            //        item.Text = nomNiv.ne_nivel_educativo_niveles_escuela;
            //        item.Value = Convert.ToString(nomNiv.ne_id_escuela);
            //        string id = Convert.ToString( item.Value);
            //        txtIdEscuelaNivel.Text = id;
            //        cbNivelTaller.Items.Add(item);
            //    }
            //}
            if (opcionBotones == 0)
            {
                cbGradoTaller.Text = "Seleccionar Grado";
                if (cbNivelTaller.Text == "PRESCOLAR" || cbNivelTaller.Text == "SECUNDARIA")
                {
                    cbGradoTaller.Items.Clear();
                    cbGradoTaller.Items.Add("1°");
                    cbGradoTaller.Items.Add("2°");
                    cbGradoTaller.Items.Add("3°");

                    cbGradoTaller.Items.Add("1°" + "2°");
                    cbGradoTaller.Items.Add("1°" + "3°");
                    cbGradoTaller.Items.Add("2°" + "3°");
                    cbGradoTaller.Items.Add("1°" + "2°" + "3°");
                }
                else if (cbNivelTaller.Text == "PRIMARIA")
                {
                    cbGradoTaller.Items.Clear();
                    cbGradoTaller.Items.Add("1°");
                    cbGradoTaller.Items.Add("2°");
                    cbGradoTaller.Items.Add("3°");
                    cbGradoTaller.Items.Add("4°");
                    cbGradoTaller.Items.Add("5°");
                    cbGradoTaller.Items.Add("6°");

                    cbGradoTaller.Items.Add("1°" + "2°");
                    cbGradoTaller.Items.Add("3°" + "4°");
                    cbGradoTaller.Items.Add("5°" + "6°");

                    cbGradoTaller.Items.Add("1°" + "2°" + "3°");
                    cbGradoTaller.Items.Add("4°" + "5°" + "6°");

                    cbGradoTaller.Items.Add("1°" + "2°" + "3°" + "4°" + "5°" + "6°");
                }
            }
        }

        private void cbProfeTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaProfes = wsPHP.buscarDatosProfesor(cbProfeTaller.Text);
                    var respProfes = JsonConvert.DeserializeObject<List<ClassProfesor>>(respuestaProfes);

                    foreach (var nomProfes in respProfes)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomProfes.pr_id_profesor);
                        string id = item.Value.ToString();
                        txtIdProfesorTaller.Text = id;
                    }
                }
            }
        }

        #endregion


        //METODOS VALUE DE DATETIME PARA VALIDACION DE LAS FECHAS
        #region

        private void dtFechaFinTaller_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFin.Text = Convert.ToString(dtFechaFinTaller.Value.ToString("yyyy-MM-dd"));
            fechaFDGV = Convert.ToDateTime(dgvTaller.CurrentRow.Cells[7].Value.ToString()).Date;
        }

        private void dtFechaIniTaller_ValueChanged(object sender, EventArgs e)
        {
            txtFechaInicio.Text = Convert.ToString(dtFechaIniTaller.Value.ToString("yyyy-MM-dd"));
            fechaIDGV = Convert.ToDateTime(dgvTaller.CurrentRow.Cells[6].Value.ToString()).Date;
        }

        #endregion


        //LOAD
        private void ModuloTalleres_Load(object sender, EventArgs e)
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
                        cbEscuelaTaller.Items.Add(item);
                    }

                    String respuestaProfes = wsPHP.cargarDatosProfesor();
                    var respProfes = JsonConvert.DeserializeObject<List<ClassProfesor>>(respuestaProfes);

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                    foreach (var nomProfes in respProfes)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomProfes.pr_nombre_profesor;
                        item.Value = Convert.ToString(nomProfes.pr_id_profesor);
                        cbProfeTaller.Items.Add(item);
                        collection.Add(item.Text);
                    }

                    cbProfeTaller.AutoCompleteCustomSource = collection;
                    cbProfeTaller.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cbProfeTaller.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


       


        //BUSCADOR TALLERES
        private void txtBuscadorTaller_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorTaller.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarTaller(txtBuscadorTaller.Text), typeof(DataTable));
                        dgvTaller.DataSource = dt;

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
            {
                cargarDatosTabla();
            }
        }


        //METODOS FACILITADORES 'cargarDatosTabla(), generarID(), NombresColumnas(), inicializacionCampos()'
        #region
        
        public void cargarDatosTabla()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosDeTaller(), typeof(DataTable));
                    dgvTaller.DataSource = dt;


                    NombresColumnas();
                    dgvTaller.ClearSelection();
                }
                catch
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
            //guardar pr|el|qi
            sub1 = txtNombreTaller.Text.Substring(0, 3);
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.buscarMAXIDT(txtIdEscuela.Text, sub1);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(3, 3));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (3 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label16.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvTaller.Columns[0].HeaderText = "Escuela";
            dgvTaller.Columns[1].Visible = false;
            dgvTaller.Columns[2].HeaderText = "ID Taller";
            dgvTaller.Columns[3].HeaderText = "Nombre Taller";
            dgvTaller.Columns[4].HeaderText = "Costo";
            dgvTaller.Columns[5].HeaderText = "Descripcion del Taller";
            dgvTaller.Columns[6].HeaderText = "Fecha de Inicio";
            dgvTaller.Columns[7].HeaderText = "Fecha de Termino";
            dgvTaller.Columns[8].HeaderText = "Nivel Educativo";
            dgvTaller.Columns[9].HeaderText = "Grado";
            dgvTaller.Columns[10].HeaderText = "Profesor";
            dgvTaller.Columns[11].HeaderText = "Habilidades a desarrollar";
            dgvTaller.Columns[12].HeaderText = "Justificacion de costo";
            dgvTaller.Columns[13].HeaderText = "Herramientas";
        }

        public void entradasDisponibles(int opcionBotones)
        {
            if(opcionBotones == 0 || opcionBotones == 1)
            {
               
                cbEscuelaTaller.Enabled = true;
                txtNombreTaller.Enabled = true;
                txtCostoTaller.Enabled = true;
                txtDescripcionTaller.Enabled = true;
                cbNivelTaller.Enabled = true;
                cbGradoTaller.Enabled = true;
                dtFechaIniTaller.Enabled = true;
                dtFechaFinTaller.Enabled = true;
                cbProfeTaller.Enabled = true;
                txtHabilidadesTaller.Enabled = true;
                txtJustificacionCostoTaller.Enabled = true;
                txtHerramientasTaller.Enabled = true;
                btnAceptar.Enabled = true; btnAceptar.Visible = true;
                btnAceptar.Text = "GUARDAR ✔";
            }
            else
            {
                txtIdEscuela.Enabled = false;
                cbEscuelaTaller.Enabled = false;
                txtIdTaller.Enabled = false;
                txtNombreTaller.Enabled = false;
                txtCostoTaller.Enabled = false;
                txtDescripcionTaller.Enabled = false;
                cbNivelTaller.Enabled = false;
                cbGradoTaller.Enabled = false;
                dtFechaIniTaller.Enabled = false;
                dtFechaFinTaller.Enabled = false;
                txtFechaInicio.Enabled = false;
                txtFechaFin.Enabled = false;
                txtIdProfesorTaller.Enabled = false;
                cbProfeTaller.Enabled = false;
                txtHabilidadesTaller.Enabled = false;
                txtJustificacionCostoTaller.Enabled = false;
                txtHerramientasTaller.Enabled = false;
            }
           
        }
        public void vaciarEntradas()
        {
            txtIdEscuela.Text = "";
            cbEscuelaTaller.Text = "Seleccionar Escuela";
            txtIdTaller.Text = "";
            txtNombreTaller.Text = "";
            txtCostoTaller.Text = "";
            txtDescripcionTaller.Text = "";
            cbNivelTaller.Text = "Seleccionar Nivel Educativo";
            cbGradoTaller.Text = "Seleccionar Grado";
            dtFechaIniTaller.Text = "";
            dtFechaFinTaller.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            txtIdProfesorTaller.Text = "";
            cbProfeTaller.Text = "";
            txtHabilidadesTaller.Text = "";
            txtJustificacionCostoTaller.Text = "";
            txtHerramientasTaller.Text = "";
            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }


        #endregion

        private void txtIdEscuela_TextChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaNivelE = wsPHP.consultaNiveles(txtIdEscuela.Text);
                    var respNiv = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaNivelE);
                    cbNivelTaller.Items.Clear();
                    foreach (var nomNiv in respNiv)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomNiv.ne_nivel_educativo_niveles_escuela;
                        item.Value = Convert.ToString(nomNiv.ne_id_escuela);

                        cbNivelTaller.Items.Add(item);
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbGradoTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEscuelaTaller_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dgvTaller_MouseClick(object sender, MouseEventArgs e)
        {
            if (opcionBotones != 0)
            {
                //NombresColumnas();
                cbEscuelaTaller.Text = dgvTaller.CurrentRow.Cells[0].Value.ToString();
                txtIdEscuela.Text = dgvTaller.CurrentRow.Cells[1].Value.ToString();
                txtIdTaller.Text = dgvTaller.CurrentRow.Cells[2].Value.ToString();
                txtNombreTaller.Text = dgvTaller.CurrentRow.Cells[3].Value.ToString();
                txtCostoTaller.Text = dgvTaller.CurrentRow.Cells[4].Value.ToString();
                txtDescripcionTaller.Text = dgvTaller.CurrentRow.Cells[5].Value.ToString();
                txtFechaInicio.Text = dgvTaller.CurrentRow.Cells[6].Value.ToString().Replace("-", "/");
                txtFechaFin.Text = dgvTaller.CurrentRow.Cells[7].Value.ToString().Replace("-", "/");
                cbNivelTaller.Text = dgvTaller.CurrentRow.Cells[8].Value.ToString();
                cbGradoTaller.Text = dgvTaller.CurrentRow.Cells[9].Value.ToString();
                cbProfeTaller.Text = dgvTaller.CurrentRow.Cells[10].Value.ToString();
                txtIdProfesorTaller.Text = dgvTaller.CurrentRow.Cells[10].Value.ToString();
                txtHabilidadesTaller.Text = dgvTaller.CurrentRow.Cells[11].Value.ToString();
                txtJustificacionCostoTaller.Text = dgvTaller.CurrentRow.Cells[12].Value.ToString();
                txtHerramientasTaller.Text = dgvTaller.CurrentRow.Cells[13].Value.ToString();
                dtFechaIniTaller.Value = DateTime.ParseExact(txtFechaInicio.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                dtFechaFinTaller.Value = DateTime.ParseExact(txtFechaFin.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            }
        }
    }
}
