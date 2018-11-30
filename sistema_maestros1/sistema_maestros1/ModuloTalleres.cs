﻿using Newtonsoft.Json;
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

        int opcionBotones = 0;

        //BOTONES DEL MODULO (no tan importantes)
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


        //METODOS PARA VALIDAR
        #region
        //METODO DE txtCostoTaller PARA ACEPTAR SOLO NUMEROS
        private void txtCostoTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumerosDecimal(e);
        }

        private void cbEscuelaTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaIniTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaFinTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNivelTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGradoTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        //BOTON AGREGAR TALLER
        private void btnAgregarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;
            dgvTaller.Enabled = false;
            btnAceptar.BackColor = Color.Green;
            cbEscuelaTaller.Enabled = true; cbEscuelaTaller.Text = "Seleccionar Escuela";
            txtIdTaller.Text = "";
            txtNombreTaller.Enabled = true; txtNombreTaller.Text = "";
            txtDescripcionTaller.Enabled = true; txtDescripcionTaller.Text = "";
            txtCostoTaller.Enabled = true; txtCostoTaller.Text = "";

            dtFechaIniTaller.Enabled = true; dtFechaIniTaller.Text = "";
            dtFechaFinTaller.Enabled = true; dtFechaFinTaller.Text = "";
            dtFechaFinTaller.Value = dtFechaIniTaller.Value.AddDays(1);

            cbNivelTaller.Enabled = true; cbNivelTaller.Text = "Seleccionar Nivel Educativo";
            cbGradoTaller.Enabled = true; cbGradoTaller.Text = "Seleccionar Grado";
            
            txtIdProfesorTaller.Enabled = false; txtIdProfesorTaller.Text = "";
            cbProfeTaller.Enabled = true; cbProfeTaller.Text = "Seleccionar Profesor";

            txtHabilidadesTaller.Enabled = true; txtHabilidadesTaller.Text = "";
            txtJustificacionCostoTaller.Enabled = true; txtJustificacionCostoTaller.Text = "";
            txtHerramientasTaller.Enabled = true; txtHerramientasTaller.Text = "";

            btnAceptar.Enabled = true;  btnAceptar.Visible = true;

        }

        //BOTON MODIFICAR TALLER
        private void btnModificarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;
            btnAceptar.BackColor = Color.SkyBlue;
            cbEscuelaTaller.Enabled = false;
            dgvTaller.Enabled = false;
            txtNombreTaller.Enabled = true; 
            txtDescripcionTaller.Enabled = true;
            txtCostoTaller.Enabled = true; 
            dtFechaIniTaller.Enabled = true; 
            dtFechaFinTaller.Enabled = true; 
            cbNivelTaller.Enabled = true; 
            cbGradoTaller.Enabled = true; 
            txtIdProfesorTaller.Enabled = false;
            txtHabilidadesTaller.Enabled = true;
            txtJustificacionCostoTaller.Enabled = true;
            txtHerramientasTaller.Enabled = true;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true;
        }

        //BOTON ELIMINAR TALLER
        private void btnEliminarTaller_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;
            dgvTaller.Enabled = false;
            btnAceptar.BackColor = Color.IndianRed;
            cbEscuelaTaller.Enabled = false;
            txtIdTaller.Enabled = false;
            txtNombreTaller.Enabled = false;
            txtDescripcionTaller.Enabled = false;
            txtCostoTaller.Enabled = false;
            dtFechaIniTaller.Enabled = false;
            dtFechaFinTaller.Enabled = false;
            cbNivelTaller.Enabled = false;
            cbGradoTaller.Enabled = false;
            txtIdProfesorTaller.Enabled = false;
            cbProfeTaller.Enabled = false;
            txtHabilidadesTaller.Enabled = false;
            txtJustificacionCostoTaller.Enabled = false;
            txtHerramientasTaller.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true;
        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int valid;
            if (cbEscuelaTaller.Text != "Seleccionar Escuela" && txtNombreTaller.Text != "" && txtCostoTaller.Text != "" && txtDescripcionTaller.Text != "" && dtFechaIniTaller.Text != "" && dtFechaFinTaller.Text != "" && cbNivelTaller.Text != "" && cbGradoTaller.Text != "" && cbProfeTaller.Text != "Seleccionar Profesor" && txtHabilidadesTaller.Text != "" && txtJustificacionCostoTaller.Text != "" && txtHerramientasTaller.Text != "")
            {
                webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();
                txtFechaInicio.Text = dtFechaIniTaller.Text;
                txtFechaFin.Text = dtFechaFinTaller.Text;
                if (opcionBotones == 0)
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        generarID();
                        ClassTaller ta = new ClassTaller();
                        ta.ta_id_escuela = txtIdEscuela.Text;
                        ta.ta_id_taller = label16.Text;
                        ta.ta_nombre_taller = txtNombreTaller.Text;
                        ta.ta_costo_taller = Convert.ToDouble(txtCostoTaller.Text);
                        ta.ta_descripcion_taller = txtDescripcionTaller.Text;
                        ta.ta_fecha_ini_taller = dtFechaIniTaller.Text;
                        ta.ta_fecha_fin_taller = dtFechaFinTaller.Text;
                        ta.ta_nivel_educativo_taller = cbNivelTaller.Text;
                        ta.ta_grados_taller = cbGradoTaller.Text;
                        //ta.ta_id_profesor_taller = cbProfesorTaller.Text;
                        ta.ta_id_profesor = txtIdProfesorTaller.Text;
                        ta.ta_habilidades_taller = txtHabilidadesTaller.Text;
                        ta.ta_justificacioncosto_taller = txtJustificacionCostoTaller.Text;
                        ta.ta_herramientas_taller = txtHerramientasTaller.Text;
                        Globales.fechaIni_taller = txtFechaFin.Text;
                        string auxgrados = cbGradoTaller.Text.Replace("º","");
                        valid= wsPHP.validarTallerXgrupo(txtIdEscuela.Text, cbNivelTaller.Text, auxgrados, Globales.fechaIni_taller);
                        if (valid == 0)
                        {
                            try
                            {
                                string mensaje = wsPHP.agregarTaller(ta.ta_id_escuela, ta.ta_id_taller, ta.ta_nombre_taller, ta.ta_costo_taller, ta.ta_descripcion_taller, ta.ta_fecha_ini_taller, ta.ta_fecha_fin_taller, ta.ta_nivel_educativo_taller, ta.ta_grados_taller, ta.ta_id_profesor, ta.ta_habilidades_taller, ta.ta_justificacioncosto_taller, ta.ta_herramientas_taller);
                                MessageBox.Show(mensaje, "¡Taller Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvTaller.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("No se pudo agregar este taller", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("No puede asigar dos o mas taller al mismo grupo en el mismo periodo. Por favor seleccione otra fecha inicial", "¡Error!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    }
                }
                else if (opcionBotones == 1)
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ClassTaller ta = new ClassTaller();
                        ta.ta_id_escuela = txtIdEscuela.Text;
                        ta.ta_id_taller = txtIdTaller.Text;
                        ta.ta_nombre_taller = txtNombreTaller.Text;
                        ta.ta_costo_taller = Convert.ToDouble(txtCostoTaller.Text);
                        ta.ta_descripcion_taller = txtDescripcionTaller.Text;
                        ta.ta_fecha_ini_taller = txtFechaInicio.Text;
                        ta.ta_fecha_fin_taller = txtFechaFin.Text;
                        ta.ta_nivel_educativo_taller = cbNivelTaller.Text;
                        ta.ta_grados_taller = cbGradoTaller.Text;
                        ta.ta_id_profesor = txtIdProfesorTaller.Text;
                        ta.ta_habilidades_taller = txtHabilidadesTaller.Text;
                        ta.ta_justificacioncosto_taller = txtJustificacionCostoTaller.Text;
                        ta.ta_herramientas_taller = txtHerramientasTaller.Text;
                        Globales.fechaIni_taller = ta.ta_fecha_fin_taller;
                        valid = wsPHP.validarTallerXgrupo(txtIdEscuela.Text, cbNivelTaller.Text, cbGradoTaller.Text, Globales.fechaIni_taller);
                        if(valid == 0)
                        {
                            try
                            {
                                string mensaje = wsPHP.modificarTaller(ta.ta_id_escuela, ta.ta_id_taller, ta.ta_nombre_taller, ta.ta_costo_taller, ta.ta_descripcion_taller, ta.ta_fecha_ini_taller, ta.ta_fecha_fin_taller, ta.ta_nivel_educativo_taller, ta.ta_grados_taller, ta.ta_id_profesor, ta.ta_habilidades_taller, ta.ta_justificacioncosto_taller, ta.ta_herramientas_taller);
                                MessageBox.Show(mensaje, "¡Taller Modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("No se pudo modificar los datos de este taller", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("No puede asigar dos o mas taller al mismo grupo en el mismo periodo. Por favor seleccione otra fecha inicial", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (opcionBotones == 2)
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ClassTaller ta = new ClassTaller();
                        ta.ta_id_taller = txtIdTaller.Text;
                        ta.ta_id_escuela = txtIdEscuela.Text;
                        //using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        //{
                        string mensaje = wsPHP.eliminarTaller(ta.ta_id_taller, ta.ta_id_escuela);
                        MessageBox.Show(mensaje, "¡Taller Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                }
                cargarDatosTabla();
                inicializacionCampos();
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
            btnAceptar.BackColor = Color.Silver;
        }

        private void dgvTallers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

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

        private void ModuloTalleres_Load(object sender, EventArgs e)
        {

            


            //dtFechaFinTaller.Value = dtFechaIniTaller.Value.AddDays(1);

            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    cargarDatosTabla();
                    
                    //label16.Text = wsPHP.cargarDatosDeTaller();
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


                    // string respuestaProfe = wsPHP.cargarNombreProfesor(txtProfeTaller.Text);
                    // var respProf = JsonConvert.DeserializeObject<List<ClassProfesor>>(respuestaProfe);
                    // 
                    // 
                    // 
                    // foreach (var nomProf in respProf)
                    // {
                    //     txtProfeTaller.Text = nomProf.pr_nombre_profesor + " " + nomProf.pr_apellidoPat_profesor;
                    //
                    //     txtIdProfesorTaller.Text = Convert.ToString(nomProf.pr_id_profesor);
                    //     coll.Add(txtProfeTaller.Text);
                    // }
                    // 
                    // txtIdProfesorTaller.AutoCompleteCustomSource = coll;

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void cbEscuelaTaller_SelectedIndexChanged(object sender, EventArgs e)
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


                


            }
        }

       // private void cbProfesorTaller_SelectedIndexChanged(object sender, EventArgs e)
       // {
       //     using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
       //     {
       //
       //
       //         //String respuestaProfesor = wsPHP.cargarNombresProfesor(cbProfesorTaller.Text);
       //         //var respProf = JsonConvert.DeserializeObject<List<ClassProfesor>>(respuestaProfesor);
       //         //
       //         //
       //         //
       //         //foreach (var nomProf in respProf)
       //         //{
       //         //
       //         //    ComboBoxItem item = new ComboBoxItem();
       //         //    item.Value = Convert.ToString(nomProf.pr_id_profesor);
       //         //    string id = item.Value.ToString();
       //         //    txtIdProfesorTaller.Text = id;
       //         //}
       //     }
       // }

       /* public void AutoCompletar()
        {
            txtProfeTaller.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProfeTaller.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {


                string respuestaProfe = wsPHP.cargarNombreProfesor(txtProfeTaller.Text);
                var respProf = JsonConvert.DeserializeObject<List<ClassProfesor>>(respuestaProfe);



                foreach (var nomProf in respProf)
                {
                    txtProfeTaller.Text = nomProf.pr_nombre_profesor + " " + nomProf.pr_apellidoPat_profesor;
                    txtIdProfesorTaller.Text = Convert.ToString(nomProf.pr_id_profesor);
                    coll.Add(txtIdProfesorTaller.Text);
                }

                txtProfeTaller.AutoCompleteCustomSource = coll;

            }

        }*/

        private void cbNivelTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNivelTaller.SelectedIndex == 0 || cbNivelTaller.SelectedIndex == 2)
            {
                cbGradoTaller.Items.Clear();
                cbGradoTaller.Items.Add("1°");
                cbGradoTaller.Items.Add("2°");
                cbGradoTaller.Items.Add("3°");

                cbGradoTaller.Items.Add("1°"+"2°");
                cbGradoTaller.Items.Add("1°"+"3°");
                cbGradoTaller.Items.Add("2°"+"3°");
                cbGradoTaller.Items.Add("1°"+"2°"+"3°");
            }
            else if (cbNivelTaller.SelectedIndex == 1)
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

        private void dtFechaFinTaller_ValueChanged(object sender, EventArgs e)
        {

            txtFechaFin.Text = Convert.ToString(dtFechaFinTaller.Value.ToString("yyyy-MM-dd"));

            //dtFechaIniTaller.Value = DateTime.ParseExact(txtFechaInicio.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            if (((dtFechaFinTaller.Value.Month == dtFechaIniTaller.Value.Month) && (dtFechaFinTaller.Value.Day >= dtFechaIniTaller.Value.Day)))
            {

            } else if((dtFechaFinTaller.Value.Year < dtFechaIniTaller.Value.Year) || (dtFechaFinTaller.Value.Month < dtFechaIniTaller.Value.Month) || ((dtFechaFinTaller.Value.Month == dtFechaIniTaller.Value.Month) && (dtFechaFinTaller.Value.Day < dtFechaIniTaller.Value.Day)))
            {
                MessageBox.Show("¡ERROR! No puedes ingresar una fecha de termino menor a la fecha de inicio de un taller", "¡ERROR EN LAS FECHAS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaFinTaller.Value = dtFechaIniTaller.Value.AddDays(1);
            }
        }

        private void dgvTaller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            cbEscuelaTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdEscuela.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtNombreTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtCostoTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtDescripcionTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[4].Value.ToString());
            string fechaI = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[5].Value.ToString());
            string fechaF = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[6].Value.ToString());
            cbNivelTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[7].Value.ToString());
            cbGradoTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[8].Value.ToString());
            cbProfeTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[9].Value.ToString());
            txtIdProfesorTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[9].Value.ToString());
            txtHabilidadesTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[10].Value.ToString());
            txtJustificacionCostoTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[11].Value.ToString());
            txtHerramientasTaller.Text = Convert.ToString(dgvTaller.Rows[e.RowIndex].Cells[12].Value.ToString());


            string newI = fechaI.Replace("-", "/");
            txtFechaInicio.Text = newI;
            dtFechaIniTaller.Value = DateTime.ParseExact(newI, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            string newF = fechaF.Replace("-", "/");
            txtFechaFin.Text = newF;
            dtFechaFinTaller.Value = DateTime.ParseExact(newF, "yyyy/MM/dd", CultureInfo.InvariantCulture);

        }

        public void cargarDatosTabla()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosDeTaller(), typeof(DataTable));
                    dgvTaller.DataSource = dt;


                    NombresColumnas();
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
            dgvTaller.Columns[1].HeaderText = "ID Taller";
            dgvTaller.Columns[2].HeaderText = "Nombre Taller";
            dgvTaller.Columns[3].HeaderText = "Costo";
            dgvTaller.Columns[4].HeaderText = "Descripcion del Taller";
            dgvTaller.Columns[5].HeaderText = "Fecha de Inicio";
            dgvTaller.Columns[6].HeaderText = "Fecha de Termino";
            dgvTaller.Columns[7].HeaderText = "Nivel Educativo";
            dgvTaller.Columns[8].HeaderText = "Grado";
            dgvTaller.Columns[9].HeaderText = "Profesor";
            dgvTaller.Columns[10].HeaderText = "Habilidades a desarrollar";
            dgvTaller.Columns[11].HeaderText = "Justificacion de costo";
            dgvTaller.Columns[12].HeaderText = "Herramientas";
        }

        public void inicializacionCampos()
        {
            cbEscuelaTaller.Enabled = false; cbEscuelaTaller.Text = "Seleccionar Escuela";
            txtIdEscuela.Text = "";

            txtIdTaller.Enabled = false; txtIdTaller.Text = "";
            txtNombreTaller.Enabled = false; txtNombreTaller.Text = "";
            txtDescripcionTaller.Enabled = false; txtDescripcionTaller.Text = "";
            txtCostoTaller.Enabled = false; txtCostoTaller.Text = "";

            dtFechaIniTaller.Enabled = false; dtFechaIniTaller.Text = "";
            txtFechaInicio.Text = "";

            dtFechaFinTaller.Enabled = false; dtFechaFinTaller.Text = "";
            txtFechaFin.Text = "";

            cbNivelTaller.Enabled = false; cbNivelTaller.Text = "Seleccionar Nivel Educativo";
            cbGradoTaller.Enabled = false; cbGradoTaller.Text = "Seleccionar Grado";

            txtIdProfesorTaller.Enabled = false; txtIdProfesorTaller.Text = "";
            cbProfeTaller.Enabled = false; cbProfeTaller.Text = "";

            txtHabilidadesTaller.Enabled = false; txtHabilidadesTaller.Text = "";
            txtJustificacionCostoTaller.Enabled = false; txtJustificacionCostoTaller.Text = "";
            txtHerramientasTaller.Enabled = false; txtHerramientasTaller.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }


        

        private void cbProfeTaller_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbGradoTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaIniTaller_ValueChanged(object sender, EventArgs e)
        {
            txtFechaInicio.Text = Convert.ToString(dtFechaIniTaller.Value.ToString("yyyy-MM-dd"));

           // ClassTaller tal = new ClassTaller();
           // tal.ta_id_escuela = txtIdEscuela.Text;
           // tal.ta_fecha_ini_taller = txtFechaInicio.Text;
           // tal.ta_fecha_fin_taller = txtFechaInicio.Text;
           // tal.ta_nivel_educativo_taller = cbNivelTaller.Text;
           // tal.ta_grados_taller = cbGradoTaller.Text;
           //
           // webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();
           // int consultar = wsPHP.validarTallerXgrupo(tal.ta_id_escuela, tal.ta_nivel_educativo_taller, tal.ta_grados_taller, tal.ta_fecha_ini_taller);
           //
           //
           // if (consultar != 0)
           // {
           //     MessageBox.Show("No se pueden asignar 2 taller a los mismos grupos en un mismo periodo de tiempo", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
            

        }
    }
}
