﻿using Newtonsoft.Json;
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
    public partial class ModuloAlumnos : Form
    {

        Validaciones v = new Validaciones();

        public ModuloAlumnos()
        {
            InitializeComponent();
        }

        //VARIABLES
        int opcionBotones = 3;


        //EVENTO_CLICK BOTONES 'X COMUNES' DE MODULO
        #region

        //BOTON DE SALIR
        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de volver al menu princiapal?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("¿Estas seguro de ir a 'Menu'?", "¡Ir a Menu!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                principal principal = new principal();
                principal.Show();

            }
        }

        //BOTON DE ALUMNOS (NO HACE NADA)
        private void btnAlumnos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Alumnos'?", "¡Modulo Alumnos!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloAlumnos modalumno = new ModuloAlumnos();
                modalumno.Show();

            }
        }

        //BOTON DE ESCUELAS
        private void btnEscuelas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Escuelas'?", "¡Modulo Escuelas!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloEscuelas modescuela = new ModuloEscuelas();
                modescuela.Show();

                

            }
        }

        //BOTON DE TALLERES
        private void btnTalleres2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Talleres'?", "¡Modulo Talleres!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloTalleres modtaller = new ModuloTalleres();
                modtaller.Show();


            }
        }

        //BOTON DE PADRES Y TUTORES
        private void btnPadreOTutor2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Padre o Tutor'?", "¡Modulo Padre o Tutor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloPadre_o_Tutor modpadre = new ModuloPadre_o_Tutor();
                modpadre.Show();

            }
        }

        //BOTON DE PROFESORES
        private void btnProfesores2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Profesores'?", "¡Modulo Profesores!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloProfesores modprofesor = new ModuloProfesores();
                modprofesor.Show();

            }
        }

        //BOTON DE DINAMICAS
        private void btnDinamicas2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Dinamicas'?", "¡Modulo Dinamicas!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ModuloDinamicas moddinamica = new ModuloDinamicas();
                moddinamica.Show();

            }
        }

        //BOTON DE MATERIALES
        private void btnMaterial2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Materiales'?", "¡Modulo Materiales!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                ModuloMaterial modmaterial = new ModuloMaterial();
                modmaterial.Show();

            }
        }

        //BOTON DE PAGOS
        private void btnPagos2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de ir a 'Modulo Materiales'?", "¡Modulo Materiales!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        //METODO DEL txtNombreAlumno PARA ACEPTAR SOLO LETRAS
        private void txtNombreAlumno_KeyPress(object sender, KeyPressEventArgs V)
        {
            v.SoloLetras(V);
        }

        //METODO DEL txtApellidoPatAlumno PARA ACEPTAR SOLO LETRAS
        private void txtApellidoPatAlumno_KeyPress(object sender, KeyPressEventArgs V)
        {
            v.SoloLetras(V);
        }

        //METODO DEL txtApellidoMatAlumno PARA ACEPTAR SOLO LETRAS
        private void txtApellidoMatAlumno_KeyPress(object sender, KeyPressEventArgs V)
        {
            v.SoloLetras(V);
        }

        //Metodos para no poder editar el texto de los combobox
        private void cbEscuelaAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Metodos para no poder editar el texto de los combobox
        private void cbNivelAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Metodos para no poder editar el texto de los combobox
        private void cbGradoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Metodos para no poder editar el texto de los combobox
        private void cbStatusAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON AGREGAR ALUMNO
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            dgvAlumnos.ClearSelection();
            //dgvAlumnos.Enabled = false;

            opcionBotones = 0;

            cbEscuelaAlumno.Enabled = true; cbEscuelaAlumno.Text = "Seleccionar Escuela";
            txtIdEscuelaAlumno.Text = "";
            txtIdAlumno.Text = "";
            txtNombreAlumno.Enabled = true; txtNombreAlumno.Text = "";
            txtApellidoPatAlumno.Enabled = true; txtApellidoPatAlumno.Text = "";
            txtApellidoMatAlumno.Enabled = true; txtApellidoMatAlumno.Text = "";
            cbGradoAlumno.Enabled = true; cbGradoAlumno.Text = "Seleccionar Grado";
            cbNivelAlumno.Enabled = true; cbNivelAlumno.Text = "Seleccionar Nivel Educativo";
            cbStatusAlumno.Enabled = true; cbStatusAlumno.Text = "Seleccionar Status";
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true; btnAceptar.Text = "GUARDAR ✔";
            btnAsignarPadre.Visible = false;
        }
         
        //BOTON MODIFICAR ALUMNO
        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            //dgvAlumnos.Enabled = true;

            opcionBotones = 1;

            txtNombreAlumno.Enabled = true;
            txtApellidoPatAlumno.Enabled = true; 
            txtApellidoMatAlumno.Enabled = true;
            cbStatusAlumno.Enabled = true;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true;
            btnAsignarPadre.Visible = true; btnAsignarPadre.Enabled = true; btnAceptar.Text = "GUARDAR ✔";

            Globales.id_escuela = txtIdEscuelaAlumno.Text;
            Globales.id_alumno = txtIdAlumno.Text;
            Globales.nombre_alumno = txtNombreAlumno.Text + " " + txtApellidoPatAlumno.Text + " " + txtApellidoMatAlumno.Text;

        }

        //BOTON ELIMINAR ALUMNO
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
            {
                //dgvAlumnos.Enabled = true;
                opcionBotones = 2;
                cbEscuelaAlumno.Enabled = false;
                txtIdEscuelaAlumno.Enabled = false;
                txtIdAlumno.Enabled = false;
                txtNombreAlumno.Enabled = false;
                txtApellidoPatAlumno.Enabled = false;
                txtApellidoMatAlumno.Enabled = false;
                cbGradoAlumno.Enabled = false;
                cbNivelAlumno.Enabled = false;
            cbStatusAlumno.Enabled = false;
                btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true; btnAceptar.Text = "Eliminar";
            btnAsignarPadre.Visible = false;
            }
        
        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaAlumno.Text != "Seleccionar Escuela") && (txtNombreAlumno.Text != "") && (txtApellidoPatAlumno.Text != "") && (txtApellidoMatAlumno.Text != "") && (cbGradoAlumno.Text != "Seleccionar Grado") && (cbStatusAlumno.Text != "Seleccionar Status"))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
                    {
                        generarID();
                        generarIDPAGO();
                        ClassAlumno al = new ClassAlumno();
                        al.al_id_escuela = txtIdEscuelaAlumno.Text;
                        al.al_id_alumno = label10.Text;
                        al.al_nombre_alumno = txtNombreAlumno.Text;
                        al.al_apellidoPat_alumno = txtApellidoPatAlumno.Text;
                        al.al_apellidoMat_alumno = txtApellidoMatAlumno.Text;
                        al.al_grado_alumno = cbGradoAlumno.Text;
                        al.al_nivel_educativo_alumno = cbNivelAlumno.Text;
                        al.al_status_alumno = cbStatusAlumno.Text;

                        Globales.id_escuela = al.al_id_escuela;
                        Globales.id_alumno = al.al_id_alumno;
                        Globales.nombre_alumno = al.al_nombre_alumno + " " + al.al_apellidoPat_alumno + " " + al.al_apellidoMat_alumno;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                string mensaje = wsPHP.agregarAlumno(al.al_id_escuela, al.al_id_alumno, al.al_nombre_alumno, al.al_apellidoPat_alumno, al.al_apellidoMat_alumno, al.al_grado_alumno, al.al_nivel_educativo_alumno, al.al_status_alumno);
                                wsPHP.agregarPagos(al.al_id_escuela, al.al_id_alumno, label11.Text);
                                MessageBox.Show(mensaje, "¡Alumno Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tutor_has_alumno tha = new tutor_has_alumno();
                                tha.Show();
                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido modificar los datos", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        //dgvAlumnos.Enabled = true;
                    }

                    else if (opcionBotones == 1)
                    {
                        ClassAlumno al = new ClassAlumno();
                        al.al_id_escuela = txtIdEscuelaAlumno.Text;
                        al.al_id_alumno = txtIdAlumno.Text;
                        al.al_nombre_alumno = txtNombreAlumno.Text;
                        al.al_apellidoPat_alumno = txtApellidoPatAlumno.Text;
                        al.al_apellidoMat_alumno = txtApellidoMatAlumno.Text;
                        al.al_grado_alumno = cbGradoAlumno.Text;
                        al.al_nivel_educativo_alumno = cbNivelAlumno.Text;
                        al.al_status_alumno = cbStatusAlumno.Text;

                        Globales.id_escuela = al.al_id_escuela;
                        Globales.id_alumno = al.al_id_alumno;
                        Globales.nombre_alumno = al.al_nombre_alumno + " " + al.al_apellidoPat_alumno + " " + al.al_apellidoMat_alumno;

                        if ((cbEscuelaAlumno.Text != "Seleccionar Escuela") && (txtIdEscuelaAlumno.Text != "") && (txtNombreAlumno.Text != "" && txtIdAlumno.Text != "") && (txtApellidoPatAlumno.Text != "") && (txtApellidoMatAlumno.Text != "") && (cbGradoAlumno.Text != "Seleccionar Grado") && (cbStatusAlumno.Text != "Seleccionar Status"))
                        {
                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                try
                                {
                                    string mensaje = wsPHP.modificarAlumno(al.al_id_escuela, al.al_id_alumno, al.al_nombre_alumno, al.al_apellidoPat_alumno, al.al_apellidoMat_alumno, al.al_grado_alumno, al.al_nivel_educativo_alumno, al.al_status_alumno);
                                    MessageBox.Show(mensaje, "¡Alumno Modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (MessageBox.Show("¿Deseas tambien actualizar las relaciones de Padres con Alumno?", "Cambiar relacion Padres con Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        tutor_has_alumno tha = new tutor_has_alumno();
                                        tha.Show();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido modificar el usuario", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                            MessageBox.Show("Debes seleccionar antes un registro para modificar","¡ERROR!");
                    }
                    else if (opcionBotones == 2)
                    {
                        ClassAlumno al = new ClassAlumno();
                        al.al_id_alumno = txtIdAlumno.Text;

                        if ((cbEscuelaAlumno.Text != "Seleccionar Escuela") && (txtIdEscuelaAlumno.Text != "") && (txtNombreAlumno.Text != "" && txtIdAlumno.Text != "") && (txtApellidoPatAlumno.Text != "") && (txtApellidoMatAlumno.Text != "") && (cbGradoAlumno.Text != "Seleccionar Grado") && (cbStatusAlumno.Text != "Seleccionar Status"))
                        {
                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                try
                                {
                                    string mensaje = wsPHP.eliminarAlumno(al.al_id_alumno);
                                    MessageBox.Show(mensaje, "¡Usuario Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido eliminar este usuario", "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                            MessageBox.Show("Debes seleccionar antes un registro para eliminar","¡ERROR!");
                    }
                    cargarDatosTabla();
                    inicializacionCampos();
                    dgvAlumnos.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }
        
        
        //BOTON RELACIONAR ALUMNOS CON PADRES
        private void btnAsignarPadre_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaAlumno.Text != "Seleccionar Escuela") && (txtNombreAlumno.Text != "") && (txtApellidoPatAlumno.Text != "") && (txtApellidoMatAlumno.Text != "") && (cbGradoAlumno.Text != "Seleccionar Grado") && (cbStatusAlumno.Text != "Seleccionar Status"))
            {
                tutor_has_alumno tha = new tutor_has_alumno();

                Globales.id_escuela = txtIdEscuelaAlumno.Text;
                Globales.id_alumno = txtIdAlumno.Text;
                Globales.nombre_alumno = txtNombreAlumno.Text + " " + txtApellidoPatAlumno.Text + " " + txtApellidoMatAlumno.Text;
                tha.Show();
            }
            else
                MessageBox.Show("Antes debes seleccionar un registro para poder asignarle un Padre o Tutor","Seleccionar Registro");
                
        }


        //SELECTEDINDEX DE COMBOBOX
        #region

        //selectComboEscuela
        private void cbEscuelaAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaAlumno.Text);
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        string id = item.Value.ToString();
                        txtIdEscuelaAlumno.Text = id;
                    }

                    cbNivelAlumno.Text = "Seleccionar Nivel Educativo";
                    cbGradoAlumno.Text = "Seleccionar Grado";

                    String respuestaNivelE = wsPHP.consultaNiveles(txtIdEscuelaAlumno.Text);
                    var respNiv = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaNivelE);
                    cbNivelAlumno.Items.Clear();
                    foreach (var nomNiv in respNiv)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomNiv.ne_nivel_educativo_niveles_escuela;
                        item.Value = Convert.ToString(nomNiv.ne_id_escuela);
                        cbNivelAlumno.Items.Add(item);
                    }
                }
            }
        }

        //selectComboNivelEducativo
        private void cbNivelAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNivelAlumno.Text == "PRESCOLAR" || cbNivelAlumno.Text == "SECUNDARIA")
            {
                cbGradoAlumno.Items.Clear();
                cbGradoAlumno.Items.Add("1°");
                cbGradoAlumno.Items.Add("2°");
                cbGradoAlumno.Items.Add("3°");
            }
            else if (cbNivelAlumno.Text == "PRIMARIA")
            {
                cbGradoAlumno.Items.Clear();
                cbGradoAlumno.Items.Add("1°");
                cbGradoAlumno.Items.Add("2°");
                cbGradoAlumno.Items.Add("3°");
                cbGradoAlumno.Items.Add("4°");
                cbGradoAlumno.Items.Add("5°");
                cbGradoAlumno.Items.Add("6°");
            }

            
        }

        #endregion

        //LOAD
        private void ModuloAlumnos_Load_1(object sender, EventArgs e)
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
                        cbEscuelaAlumno.Items.Add(item);
            
                    }
            
                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //CELLCONTENT (DGV)
        private void dgvAlumnos_MouseClick(object sender, MouseEventArgs e)
        {
            if (opcionBotones != 0)
            {
                NombresColumnas();
                cbEscuelaAlumno.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
                txtIdEscuelaAlumno.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
                txtIdAlumno.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                txtNombreAlumno.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
                txtApellidoPatAlumno.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
                txtApellidoMatAlumno.Text = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
                cbGradoAlumno.Text = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();
                cbNivelAlumno.Text = dgvAlumnos.CurrentRow.Cells[7].Value.ToString();
                cbStatusAlumno.Text = dgvAlumnos.CurrentRow.Cells[8].Value.ToString();
            }
        }
      


        //BUSCADOR DE ALUMNOS
        private void txtBuscadorAlumno_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscadorAlumno.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtBuscadorAlumno.Text), typeof(DataTable));
                        dgvAlumnos.DataSource = dt;
                        NombresColumnas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ningun alumno con estos datos, Por favor ingrese un nombre o ID Alumno correcto", "No existe este alumno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnos.DataSource = dt;
                    NombresColumnas();
                    dgvAlumnos.ClearSelection();

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
            //guardar tu|ma|pa
            sub1 = txtIdEscuelaAlumno.Text;
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.BuscarMAXIDA(sub1);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(8, 4));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (4 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + "a" + sub2 + Convert.ToString(n);
            label10.Text = newID;
        }

        public void generarIDPAGO()
        {
            webservices3435.WSPHP wsPHP = new webservices3435.WSPHP();
            string sub1, sub2, newID, ultimoID;
            int n;
            //guardar tu|ma|pa
            sub1 = "p";
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.BuscarMAXIDA(sub1);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(1, 3));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (3 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label11.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvAlumnos.Columns[0].HeaderText = "Escuela";
            dgvAlumnos.Columns[1].Visible = false;
            dgvAlumnos.Columns[2].HeaderText = "ID Alumno";
            dgvAlumnos.Columns[3].HeaderText = "Nombre(s)";
            dgvAlumnos.Columns[4].HeaderText = "Apellido Paterno";
            dgvAlumnos.Columns[5].HeaderText = "Apellido Materno";
            dgvAlumnos.Columns[6].HeaderText = "Grado";
            dgvAlumnos.Columns[7].HeaderText = "Nivel Escolar";
            dgvAlumnos.Columns[8].HeaderText = "Status";
        }

        public void inicializacionCampos()
        {
            cbEscuelaAlumno.Enabled = false; cbEscuelaAlumno.Text = "Seleccionar Escuela";
            txtIdEscuelaAlumno.Enabled = false; txtIdEscuelaAlumno.Text = "";
            txtIdAlumno.Enabled = false; txtIdAlumno.Text = "";
            txtNombreAlumno.Enabled = false; txtNombreAlumno.Text = "";
            txtApellidoPatAlumno.Enabled = false; txtApellidoPatAlumno.Text = "";
            txtApellidoMatAlumno.Enabled = false; txtApellidoMatAlumno.Text = "";
            cbGradoAlumno.Enabled = false; cbGradoAlumno.Text = "Seleccionar Grado";
            cbNivelAlumno.Enabled = false; cbNivelAlumno.Text = "Seleccionar Nivel Educativo";
            cbStatusAlumno.Enabled = false; cbStatusAlumno.Text = "Seleccionar Status";
            btnAceptar.Enabled = false; btnAceptar.Visible = false;
            btnAsignarPadre.Visible = false;
        }

        #endregion


        private void cbNivelAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            cbGradoAlumno.Text = "Seleccionar Grado";
        }
        

       
    }
}
