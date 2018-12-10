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
using System.Text.RegularExpressions;


namespace sistema_maestros1
{
    public partial class ModuloPadre_o_Tutor : Form
    {

        Validaciones v = new Validaciones();


        public ModuloPadre_o_Tutor()
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

        //BOTON DE PADRES Y TUTORES (NO HACE NADA)
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

        
        //METODOS DE VALIDACION
        #region
        //METODO DE tctNombrePadre PARA SOLO ACEPTAR LETRAS
        private void tctNombrePadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        //METODO DE txtApellidoPatPadre PARA SOLO ACEPTAR LETRAS
        private void txtApellidoPatPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        //METODO DE txtApellidomatPadre PARA SOLO ACEPTAR LETRAS
        private void txtApellidoMatPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        //METODO DE txtTelefonoPadre PARA SOLO ACEPTAR LETRAS
        private void txtTelefonoPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }


        //Metodos para no poder editar el texto de los combobox
        private void cbParentescoPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON AGREGAR PADRES
        private void btnAgregarPadre_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvPadre.Enabled = false;

            txtIdPadre.Enabled = false; txtIdPadre.Text = "";
            tctNombrePadre.Enabled = true; tctNombrePadre.Text = "";
            txtApellidoPatPadre.Enabled = true; txtApellidoPatPadre.Text = "";
            txtApellidoMatPadre.Enabled = true; txtApellidoMatPadre.Text = "";
            txtTelefonoPadre.Enabled = true; txtTelefonoPadre.Text = "";
            cbParentescoPadre.Enabled = true; cbParentescoPadre.Text = "Seleccionar el parentesco";
            txtCorreoPadre.Enabled = true; txtCorreoPadre.Text = "";
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true;
        }

        //BOTON MODIFICAR PADRES
        private void btnModificarPadre_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            dgvPadre.Enabled = true;

            txtIdPadre.Enabled = false;
            tctNombrePadre.Enabled = true; 
            txtApellidoPatPadre.Enabled = true; 
            txtApellidoMatPadre.Enabled = true; 
            txtTelefonoPadre.Enabled = true;
            cbParentescoPadre.Enabled = false;
            txtCorreoPadre.Enabled = true;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true;
        }

        //BOTON ELIMINAR PADRES
        private void btnEliminarPadre_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvPadre.Enabled = true;

            txtIdPadre.Enabled = false;
            tctNombrePadre.Enabled = false;
            txtApellidoPatPadre.Enabled = false;
            txtApellidoMatPadre.Enabled = false;
            txtTelefonoPadre.Enabled = false;
            cbParentescoPadre.Enabled = false;
            txtCorreoPadre.Enabled = false;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true;
        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tctNombrePadre.Text != "" && txtApellidoPatPadre.Text != "" && txtApellidoMatPadre.Text != "" && txtTelefonoPadre.Text != "" && cbParentescoPadre.Text != "Seleccionar el parentesco" && txtCorreoPadre.Text != "" )
            {
                string email = txtCorreoPadre.Text;
                bool verificar = email.Contains("@"); 
                bool verificar2 = email.Contains(".com");

                if ((verificar == true && verificar2 == true) || (txtCorreoPadre.Text == "No aplica" || txtCorreoPadre.Text == "no aplica" || txtCorreoPadre.Text == "No Aplica") || (txtCorreoPadre.Text == "n/a" || txtCorreoPadre.Text == "N/a" || txtCorreoPadre.Text == "N/A"))
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        
                        if (opcionBotones == 0)
                        {
                            generarID();
                            ClassPadres tu = new ClassPadres();
                            tu.tu_id_tutor = label7.Text;
                            tu.tu_nombre_tutor = tctNombrePadre.Text;
                            tu.tu_apellidoPat_tutor = txtApellidoPatPadre.Text;
                            tu.tu_apellidoMat_tutor = txtApellidoMatPadre.Text;
                            tu.tu_telefono_tutor = txtTelefonoPadre.Text;
                            tu.tu_parentesco_tutor = cbParentescoPadre.Text;
                            tu.tu_correo_tutor = txtCorreoPadre.Text;

                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                string mensaje2 = wsPHP.validarNumero(txtTelefonoPadre.Text);
                                if (mensaje2 != null)
                                {
                                    MessageBox.Show("Este numero ya se encuentra registrado y le pertenece a " + mensaje2, "¡Numeros repetidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    try
                                    {
                                        dgvPadre.Enabled = true;
                                        string mensaje = wsPHP.agregarTutor(tu.tu_id_tutor, tu.tu_nombre_tutor, tu.tu_apellidoPat_tutor, tu.tu_apellidoMat_tutor, tu.tu_telefono_tutor, tu.tu_parentesco_tutor, tu.tu_correo_tutor);
                                        MessageBox.Show(mensaje, "¡Usuario Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        cargarDatosTabla();
                                        inicializacionCampos();
                                        dgvPadre.Enabled = true;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Ha ocurrido un error, no se ha podido agregar el usuario", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    
                                }
                            }
                        }
                    
                    else if (opcionBotones == 1)
                    {
                        ClassPadres tu = new ClassPadres();
                        tu.tu_id_tutor = txtIdPadre.Text;
                        tu.tu_nombre_tutor = tctNombrePadre.Text;
                        tu.tu_apellidoPat_tutor = txtApellidoPatPadre.Text;
                        tu.tu_apellidoMat_tutor = txtApellidoMatPadre.Text;
                        tu.tu_telefono_tutor = txtTelefonoPadre.Text;
                        tu.tu_parentesco_tutor = cbParentescoPadre.Text;
                        tu.tu_correo_tutor = txtCorreoPadre.Text;
                            string mensaje2;
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            if (txtTelefonoPadre.Text != dgvPadre.CurrentRow.Cells[4].Value.ToString())
                            {
                                    mensaje2 = wsPHP.validarNumero(txtTelefonoPadre.Text);
                                    if (mensaje2 == null)
                                    {

                                        try
                                        {
                                            string mensaje = wsPHP.modificarTutor(tu.tu_id_tutor, tu.tu_nombre_tutor, tu.tu_apellidoPat_tutor, tu.tu_apellidoMat_tutor, tu.tu_telefono_tutor, tu.tu_parentesco_tutor, tu.tu_correo_tutor);
                                            MessageBox.Show(mensaje, "¡tutor modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cargarDatosTabla();
                                            inicializacionCampos();
                                            dgvPadre.Enabled = true;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ha ocurrido un error, no se ha podido modificar el usuario", "¡Error al modificar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                    }

                                    else
                                    {
                                        MessageBox.Show("Este numero ya se encuentra registrado y le pertenece a " + mensaje2, "¡Numeros repetidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    mensaje2 = null;
                                    if (mensaje2 == null)
                                    {

                                        try
                                        {
                                            string mensaje = wsPHP.modificarTutor(tu.tu_id_tutor, tu.tu_nombre_tutor, tu.tu_apellidoPat_tutor, tu.tu_apellidoMat_tutor, tu.tu_telefono_tutor, tu.tu_parentesco_tutor, tu.tu_correo_tutor);
                                            MessageBox.Show(mensaje, "¡tutor modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cargarDatosTabla();
                                            inicializacionCampos();
                                            dgvPadre.Enabled = true;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ha ocurrido un error, no se ha podido modificar el usuario", "¡Error al modificar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        
                                    }
                                    
                                    else if (wsPHP.validarNumero(txtTelefonoPadre.Text) != "")
                                    {
                                        mensaje2 = wsPHP.validarNumero(txtTelefonoPadre.Text);
                                        MessageBox.Show("Este numero ya se encuentra registrado y le pertenece a " + mensaje2, "¡Numeros repetidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }
                    }

                    else if (opcionBotones == 2)
                    {
                        ClassPadres tu = new ClassPadres();
                        tu.tu_id_tutor = txtIdPadre.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {

                                try
                                {
                                    string mensaje = wsPHP.eliminarTutor(tu.tu_id_tutor);
                                    MessageBox.Show(mensaje, "¡Tutor Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarDatosTabla();
                                    inicializacionCampos();
                                    dgvPadre.Enabled = true;
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido eliminar este usuario", "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                    }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Correo Invalido", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            
        }


        //LOAD
        private void ModuloPadre_o_Tutor_Load(object sender, EventArgs e)
        {
            cargarDatosTabla();
        }


        //CELLCONTENT (DGV)
        private void dgvPadre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            txtIdPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[0].Value.ToString());
            tctNombrePadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtApellidoPatPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtApellidoMatPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtTelefonoPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[4].Value.ToString());
            cbParentescoPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtCorreoPadre.Text = Convert.ToString(dgvPadre.Rows[e.RowIndex].Cells[6].Value.ToString());
        }


        //BUSCADOR DE PADRES
        private void txtBuscadorPadre_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorPadre.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarTutor(txtBuscadorPadre.Text), typeof(DataTable));
                        dgvPadre.DataSource = dt;
                        NombresColumnas();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ninguna padre/tutor con estos datos, Por favor ingrese un nombre o ID Padre correcto", "No existe este tutor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosTutor(), typeof(DataTable));
                    dgvPadre.DataSource = dt;

                    NombresColumnas();
                    dgvPadre.ClearSelection();

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
            sub1 = cbParentescoPadre.Text.Substring(0, 2);
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.BuscarMAXID(sub1);
            if (ultimoID == "")
                n = 0;
            //ultimoID = "0000";
            //n = Convert.ToInt32(ultimoID.Substring(2,2));
            else
                n = Convert.ToInt32(ultimoID.Substring(2, 4));
            //guardar el numero del ultimo ID
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (4 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label7.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvPadre.Columns[0].HeaderText = "ID Padre o Tutor";
            dgvPadre.Columns[1].HeaderText = "Nombre(s)";
            dgvPadre.Columns[2].HeaderText = "Apellido Paterno";
            dgvPadre.Columns[3].HeaderText = "Apellido Materno";
            dgvPadre.Columns[4].HeaderText = "Telefono";
            dgvPadre.Columns[5].HeaderText = "Parentesco";
            dgvPadre.Columns[6].HeaderText = "Correo electronico";
        }

        public void inicializacionCampos()
        {
            txtIdPadre.Enabled = false; txtIdPadre.Text = "";
            tctNombrePadre.Enabled = false; tctNombrePadre.Text = "";
            txtApellidoPatPadre.Enabled = false; txtApellidoPatPadre.Text = "";
            txtApellidoMatPadre.Enabled = false; txtApellidoMatPadre.Text = "";
            txtTelefonoPadre.Enabled = false; txtTelefonoPadre.Text = "";
            cbParentescoPadre.Enabled = false; cbParentescoPadre.Text = "Seleccionar el parentesco";
            txtCorreoPadre.Enabled = false; txtCorreoPadre.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion
        
    }
}
