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
    public partial class ModuloAlumnos : Form
    {

        Validaciones v = new Validaciones();

        public ModuloAlumnos()
        {
            InitializeComponent();
        }

        //VARIABLES
        int opcionBotones = 0;

        private void ModuloAlumnos_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                dgvAlumnos.DataSource = dt;
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAlumnos.Columns[0].HeaderText = "Escuela";
            dgvAlumnos.Columns[1].HeaderText = "ID Alumno";
            dgvAlumnos.Columns[2].HeaderText = "Nombre(s)";
            dgvAlumnos.Columns[3].HeaderText = "Apellido Paterno";
            dgvAlumnos.Columns[4].HeaderText = "Apellido Materno";
            dgvAlumnos.Columns[5].HeaderText = "Grado";
            dgvAlumnos.Columns[6].HeaderText = "Nivel Escolar";
            dgvAlumnos.Columns[7].HeaderText = "Status";

            cbEscuelaAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdEscuelaAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtNombreAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtApellidoPatAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtApellidoMatAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[4].Value.ToString());
            cbGradoAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[5].Value.ToString());
            cbNivelAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[6].Value.ToString());
            cbStatusAlumno.Text = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells[7].Value.ToString());
        }



            //BOTON DE MENU PRINCIPAL
            private void btnMenuPrincipal2_Click(object sender, EventArgs e)
           {
               if(MessageBox.Show("¿Estas seguro de ir a 'Menu'?","¡Ir a Menu!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        
          #endregion
        
            //BOTON AGREGAR ALUMNO
            private void btnAgregarAlumno_Click(object sender, EventArgs e)
            {
                opcionBotones = 0;
        
                cbEscuelaAlumno.Enabled = true; cbEscuelaAlumno.Text = "Seleccionar Escuela";
                txtIdEscuelaAlumno.Enabled = true;  txtIdEscuelaAlumno.Text = "";
                txtIdAlumno.Enabled = true; txtIdAlumno.Text = "";
                txtNombreAlumno.Enabled = true; txtNombreAlumno.Text = "";
                txtApellidoPatAlumno.Enabled = true; txtApellidoPatAlumno.Text = "";
                txtApellidoMatAlumno.Enabled = true; txtApellidoMatAlumno.Text = "";
                cbGradoAlumno.Enabled = true; cbGradoAlumno.Text = "Seleccionar Grado";
                cbNivelAlumno.Enabled = true; cbNivelAlumno.Text = "Seleccionar Nivel Educativo";
            cbStatusAlumno.Enabled = true; cbStatusAlumno.Text = "Seleccionar Status";
                btnAceptar.Enabled = true; 
                btnAsignarPadre.Visible = false; 
        
        
        
        
            }
        
            //BOTON MODIFICAR ALUMNO
            private void btnModificarAlumno_Click(object sender, EventArgs e)
            {
                opcionBotones = 1;
        
                //cbEscuelaAlumno.Enabled = true;
                //txtIdEscuelaAlumno.Enabled = true;
                txtNombreAlumno.Enabled = true;
                txtApellidoPatAlumno.Enabled = true; 
                txtApellidoMatAlumno.Enabled = true;
            cbStatusAlumno.Enabled = true;
                //cbGradoAlumno.Enabled = true; 
                //cbNivelAlumno.Enabled = true;
                btnAceptar.Enabled = true;
                btnAsignarPadre.Visible = true; btnAsignarPadre.Enabled = true;

            Globales.id_escuela = txtIdEscuelaAlumno.Text;
            Globales.id_alumno = txtIdAlumno.Text;
            Globales.nombre_alumno = txtNombreAlumno.Text + " " + txtApellidoPatAlumno.Text + " " + txtApellidoMatAlumno.Text;

        }

        //BOTON ELIMINAR ALUMNO
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
            {
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
                btnAceptar.Enabled = true;
                btnAsignarPadre.Visible = false;
            }
        
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
        
            //BOTON ACEPTAR (CRUD)
            private void btnAceptar_Click(object sender, EventArgs e)
            {
                if ((cbEscuelaAlumno.Text != "Seleccionar Escuela") && (txtIdAlumno.Text != "") && (txtNombreAlumno.Text != "") && (txtApellidoPatAlumno.Text != "") && (txtApellidoMatAlumno.Text != "") && (cbGradoAlumno.Text != "Seleccionar Grado") && (cbStatusAlumno.Text != "Seleccionar Status"))
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
        
                        if (opcionBotones == 0)
                        {

                            ClassAlumno al = new ClassAlumno();

                            //al.al_id_escuela = Convert.ToString(cbEscuelaAlumno.SelectedIndex);
        
                            al.al_id_escuela = txtIdEscuelaAlumno.Text;
        
                            //al.al_id_escuela = cbEscuelaAlumno.Text;
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
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                
                                try
                                {
                                    string mensaje = wsPHP.agregarAlumno(al.al_id_escuela, al.al_id_alumno, al.al_nombre_alumno, al.al_apellidoPat_alumno, al.al_apellidoMat_alumno, al.al_grado_alumno, al.al_nivel_educativo_alumno, al.al_status_alumno);
                                    MessageBox.Show(mensaje, "¡Alumno Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tutor_has_alumno tha = new tutor_has_alumno();
                                tha.Show();
        
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido agregar el usuario", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
        
                            }
        
                        }
                        else if (opcionBotones == 1)
                        {
                            ClassAlumno al = new ClassAlumno();
        
        
                            //al.al_id_escuela = cbEscuelaAlumno.SelectedIndex + 1;
                            al.al_id_escuela = txtIdEscuelaAlumno.Text;
        
                            //al.al_id_escuela = cbEscuelaAlumno.Text;
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
                        else if (opcionBotones == 2)
                        {
                            ClassAlumno al = new ClassAlumno();
                            
                            al.al_id_alumno = txtIdAlumno.Text;
        
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
        
                        cargarDatosTabla();
                        cbEscuelaAlumno.Enabled = false; cbEscuelaAlumno.Text = "Seleccionar Escuela";
                        txtIdEscuelaAlumno.Enabled = false; txtIdEscuelaAlumno.Text = "";
                        txtIdAlumno.Enabled = false; txtIdAlumno.Text = "";
                        txtNombreAlumno.Enabled = false; txtNombreAlumno.Text = "";
                        txtApellidoPatAlumno.Enabled = false; txtApellidoPatAlumno.Text = "";
                        txtApellidoMatAlumno.Enabled = false; txtApellidoMatAlumno.Text = "";
                        cbGradoAlumno.Enabled = false; cbGradoAlumno.Text = "Seleccionar Grado";
                        cbNivelAlumno.Enabled = false; cbNivelAlumno.Text = "Seleccionar Nivel Educativo";
                    cbStatusAlumno.Enabled = false; cbStatusAlumno.Text = "Seleccionar Status";
                        btnAceptar.Enabled = false;
                        btnAsignarPadre.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
                }
            }
        
            public void cargarDatosTabla()
            {
        
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    
                    try
                    {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnos.DataSource = dt;


                    dgvAlumnos.Columns[0].HeaderText = "Escuela";
                        dgvAlumnos.Columns[1].HeaderText = "ID Alumno";
                        dgvAlumnos.Columns[2].HeaderText = "Nombre(s)";
                        dgvAlumnos.Columns[3].HeaderText = "Apellido Paterno";
                        dgvAlumnos.Columns[4].HeaderText = "Apellido Materno";
                        dgvAlumnos.Columns[5].HeaderText = "Grado";
                        dgvAlumnos.Columns[6].HeaderText = "Nivel Escolar";
                    dgvAlumnos.Columns[7].HeaderText = "Status";

                }
                    catch
                    {
                        MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        
        
            }
        
            //BOTON RELACIONAR ALUMNOS CON PADRES
            private void btnAsignarPadre_Click(object sender, EventArgs e)
            {
                tutor_has_alumno tha = new tutor_has_alumno();
                tha.Show();
            }
        
            
        

        
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
        
        
                        }
                        catch
                        {
                            MessageBox.Show("No se encuentra ningun Padre o Tutor con estos datos, Por favor ingrese un nombre o ID Padre correcto", "No existe este usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
        
        
                    }
                }
            }
        
            private void cbEscuelaAlumno_SelectedIndexChanged(object sender, EventArgs e)
            {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaAlumno.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);



                foreach (var nomEsc in respEsc)
                {
                    //cbEscuelaAlumno.ValueMember = nomEsc.es_id_escuela;
                    //cbEscuelaAlumno.DisplayMember = nomEsc.es_nombre_escuela;
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    //cbEscuelaAlumno.Items.Add(nomEsc.es_nombre_escuela.ToString());
                    string id = item.Value.ToString();
                    txtIdEscuelaAlumno.Text = id;
                }
            }
        }

        private void ModuloAlumnos_Load_1(object sender, EventArgs e)
        {
            cargarDatosTabla();

             

            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                dgvAlumnos.DataSource = dt;
                try
                {


                    dgvAlumnos.Columns[0].HeaderText = "Escuela";
                    dgvAlumnos.Columns[1].HeaderText = "ID Alumno";
                    dgvAlumnos.Columns[2].HeaderText = "Nombre(s)";
                    dgvAlumnos.Columns[3].HeaderText = "Apellido Paterno";
                    dgvAlumnos.Columns[4].HeaderText = "Apellido Materno";
                    dgvAlumnos.Columns[5].HeaderText = "Grado";
                    dgvAlumnos.Columns[6].HeaderText = "Nivel Escolar";
                    dgvAlumnos.Columns[7].HeaderText = "Status";

                    String respuestaEscuela = wsPHP.cargarDatosEscuela();

                    //using (servidorweb.WSPHP wsPHP = new servidorweb.WSPHP())
                    //{
                    //    String respuestaEscuela = wsPHP.cargarNombresEscuela();
                    //   var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                    //
                    //   foreach (var nomEsc in respEsc)
                    //   {
                    //       cbEscuelaAlumno.Items.Add(nomEsc.es_nombre_escuela.ToString());
                    //
                    //       string id = nomEsc.es_id_escuela.ToString();
                    //       txtIdEscuelaAlumno.Text = id;
                    //

                    //}

                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);



                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomEsc.es_nombre_escuela;
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        cbEscuelaAlumno.Items.Add(item);

                    }

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbNivelAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNivelAlumno.SelectedIndex == 0 || cbNivelAlumno.SelectedIndex == 2)
            {
                cbGradoAlumno.Items.Clear();
                cbGradoAlumno.Items.Add("1°");
                cbGradoAlumno.Items.Add("2°");
                cbGradoAlumno.Items.Add("3°");
            }
            else if(cbNivelAlumno.SelectedIndex == 1)
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
    }
    }
