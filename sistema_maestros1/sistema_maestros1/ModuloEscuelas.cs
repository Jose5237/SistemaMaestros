using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sistema_maestros1
{

    public partial class ModuloEscuelas : Form
    {

        Validaciones v = new Validaciones();


        public ModuloEscuelas()
        {
            InitializeComponent();
        }

        //VARIABLES
        string aux = "", aux2 = "";
        int i;
        int opcionBotones = 0;
        string prescolar, primaria, secundaria, sub = "", estado = "";
        webservices3435.WSPHP ws = new webservices3435.WSPHP();

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

        //BOTON DE ESCUELAS (NO HACE NADA)
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

        //METODO DEL txtTel1Escuela PARA ACEPTAR SOLO NUMEROS
        private void txtTel1Escuela_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.SoloNumeros(e);
        }

        //METODO DEL txtTel2Escuela PARA ACEPTAR SOLO NUMEROS
        private void txtTel2Escuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        //METODO DEL txtTel3Escuela PARA ACEPTAR SOLO NUMEROS
        private void txtTel3Escuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        ////METODO DEL txtContactoEscuela PARA ACEPTAR SOLO LETRAS
        private void txtContactoEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetrasYComas(e);
        }

        //METODO DEL txtResponsablePagoEscuela PARA ACEPTAR LETRAS COMAS Y PUNTOS
        private void txtResponsablePagoEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetrasYComas(e);
        }

        #endregion


        //BOTON AGREGAR ESCUELA
        private void btnAgregarEscuela_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvEscuela.ClearSelection();
            dgvEscuela.Enabled = false;
            dgvEscuela.ScrollBars = ScrollBars.Both;
            comboBox1.Enabled = true;
            txtIdEscuela.Enabled = false; txtIdEscuela.Text = "";
            txtNombreEscuela.Enabled = true; txtNombreEscuela.Text = "";
            txtDireccionEscuela.Enabled = true; txtDireccionEscuela.Text = "";
            txtTel1Escuela.Enabled = true; txtTel1Escuela.Text = "";
            txtTel2Escuela.Enabled = true; txtTel2Escuela.Text = "";
            txtTel3Escuela.Enabled = true; txtTel3Escuela.Text = "";
            txtCorreoEscuela.Enabled = true; txtCorreoEscuela.Text = "";
            txtContactoEscuela.Enabled = true; txtContactoEscuela.Text = "";
            txtResponsablePagoEscuela.Enabled = true; txtResponsablePagoEscuela.Text = "";
            txtPrecioEscuela.Enabled = true; txtPrecioEscuela.Text = "";
            checkPrescolar.Enabled = true;
            checkPrimaria.Enabled = true;
            checkSecundaria.Enabled = true;
            checkPrescolar.Checked = false;
            checkPrimaria.Checked = false;
            checkSecundaria.Checked = false;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true; btnAceptar.Text = "GUARDAR ✔";
        }

        //BOTON MODIFICAR ESCUELA
        private void btnModificarEscuela_Click(object sender, EventArgs e)
        {
            dgvEscuela.Enabled = true;
            opcionBotones = 1;
            txtIdEscuela.Enabled = false;
            txtNombreEscuela.Enabled = true;
            comboBox1.Enabled = false;
            txtDireccionEscuela.Enabled = true;
            txtTel1Escuela.Enabled = true;
            txtTel2Escuela.Enabled = true;
            txtTel3Escuela.Enabled = true;
            txtCorreoEscuela.Enabled = true;
            txtContactoEscuela.Enabled = true;
            txtResponsablePagoEscuela.Enabled = true;
            txtPrecioEscuela.Enabled = true;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true; btnAceptar.Text = "GUARDAR ✔";

            //checkPrescolar.Enabled = true;
            //checkPrimaria.Enabled = true;
            //checkSecundaria.Enabled = true;
        }

        //BOTON ELIMINAR ESCUELA
        private void btnEliminarEscuela_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvEscuela.Enabled = true;

            txtIdEscuela.Enabled = false;
            txtNombreEscuela.Enabled = false;
            txtDireccionEscuela.Enabled = false;
            txtTel1Escuela.Enabled = false;
            txtTel2Escuela.Enabled = false;
            txtTel3Escuela.Enabled = false;
            txtCorreoEscuela.Enabled = false;
            txtContactoEscuela.Enabled = false;
            txtResponsablePagoEscuela.Enabled = false;
            txtPrecioEscuela.Enabled = false;
            checkPrescolar.Enabled = false;
            checkPrimaria.Enabled = false;
            checkSecundaria.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true; btnAceptar.Text = "Eliminar";
        }
        
        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtNombreEscuela.Text != "") && (txtDireccionEscuela.Text != "") && comboBox1.Text != "Estado" && (txtTel1Escuela.Text != "") && (txtCorreoEscuela.Text != "") && (txtContactoEscuela.Text != "") && (txtResponsablePagoEscuela.Text != "") && txtPrecioEscuela.Text != "")
            {
                if ((txtTel1Escuela.Text.Length == 7 || txtTel1Escuela.Text.Length == 10) && (txtTel2Escuela.Text.Length == 7 || txtTel2Escuela.Text.Length == 10 || txtTel2Escuela.Text == "") && (txtTel3Escuela.Text.Length == 7 || txtTel3Escuela.Text.Length == 10 || txtTel3Escuela.Text == ""))
                {
                    string email = txtCorreoEscuela.Text;
                    bool verificar = email.Contains("@");
                    bool verificar2 = email.Contains(".com");
                    if ((verificar == true && verificar2 == true) || (txtCorreoEscuela.Text == "No aplica" || txtCorreoEscuela.Text == "no aplica" || txtCorreoEscuela.Text == "No Aplica") || (txtCorreoEscuela.Text == "n/a" || txtCorreoEscuela.Text == "N/a" || txtCorreoEscuela.Text == "N/A"))
                    {
                        if (opcionBotones == 0)
                        {
                            generarID();

                            if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de agregar estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                ClassEscuela es = new ClassEscuela();
                                es.es_id_escuela = label8.Text;
                                es.es_nombre_escuela = txtNombreEscuela.Text;
                                es.es_direccion_escuela = estado + "," + txtDireccionEscuela.Text;
                                es.es_telefono1_escuela = txtTel1Escuela.Text;
                                es.es_telefono2_escuela = txtTel2Escuela.Text;
                                es.es_telefono3_escuela = txtTel3Escuela.Text;
                                es.es_correo_escuela = txtCorreoEscuela.Text;
                                es.es_contacto_escuela = txtContactoEscuela.Text;
                                es.es_responsable_pago_escuela = txtResponsablePagoEscuela.Text;
                                es.es_precio_escuela = Convert.ToDouble(txtPrecioEscuela.Text);

                                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                                {
                                    try
                                    {
                                        string mensaje = wsPHP.agregarEscuela(es.es_id_escuela, es.es_nombre_escuela, es.es_direccion_escuela, es.es_telefono1_escuela, es.es_telefono2_escuela, es.es_telefono3_escuela, es.es_correo_escuela, es.es_contacto_escuela, es.es_responsable_pago_escuela, es.es_precio_escuela);
                                        if (checkPrescolar.Checked == true)
                                            wsPHP.agregarNivel_escuela(prescolar, es.es_id_escuela);
                                        if (checkPrimaria.Checked == true)
                                            wsPHP.agregarNivel_escuela(primaria, es.es_id_escuela);
                                        if (checkSecundaria.Checked == true)
                                            wsPHP.agregarNivel_escuela(secundaria, es.es_id_escuela);
                                        MessageBox.Show(mensaje, "¡Escuela Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cargarDatosTabla();
                                        inicializacionCampos();
                                        dgvEscuela.Enabled = true;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Ha ocurrido un error, no se ha podido agregar la escuela", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else if (opcionBotones == 1)
                        {
                            if ((txtNombreEscuela.Text != "" && txtIdEscuela.Text != "") && (txtDireccionEscuela.Text != "") && (txtTel1Escuela.Text != "") && (txtCorreoEscuela.Text != "") && (txtContactoEscuela.Text != "") && (txtResponsablePagoEscuela.Text != "" ) && (txtPrecioEscuela.Text != ""))
                            {



                                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de realizar estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {

                                    ClassEscuela es = new ClassEscuela();
                                    es.es_id_escuela = txtIdEscuela.Text;
                                    es.es_nombre_escuela = txtNombreEscuela.Text;
                                    es.es_direccion_escuela = estado + "," + txtDireccionEscuela.Text;
                                    es.es_telefono1_escuela = txtTel1Escuela.Text;
                                    es.es_telefono2_escuela = txtTel2Escuela.Text;
                                    es.es_telefono3_escuela = txtTel3Escuela.Text;
                                    es.es_correo_escuela = txtCorreoEscuela.Text;
                                    es.es_contacto_escuela = txtContactoEscuela.Text;
                                    es.es_responsable_pago_escuela = txtResponsablePagoEscuela.Text;
                                    es.es_precio_escuela = Convert.ToDouble(txtPrecioEscuela.Text);



                                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                                    {

                                        try
                                        {
                                            string mensaje = wsPHP.modificarEscuela(es.es_id_escuela, es.es_nombre_escuela, es.es_direccion_escuela, es.es_telefono1_escuela, es.es_telefono2_escuela, es.es_telefono3_escuela, es.es_correo_escuela, es.es_contacto_escuela, es.es_responsable_pago_escuela,es.es_precio_escuela);
                                            if (checkPrescolar.Enabled == true && checkPrescolar.Checked == true)
                                                wsPHP.agregarNivel_escuela(prescolar, es.es_id_escuela);
                                            if (checkPrimaria.Enabled == true && checkPrimaria.Checked == true)
                                                wsPHP.agregarNivel_escuela(primaria, es.es_id_escuela);
                                            if (checkSecundaria.Enabled == true && checkSecundaria.Checked == true)
                                                wsPHP.agregarNivel_escuela(secundaria, es.es_id_escuela);
                                            MessageBox.Show(mensaje, "¡Escuela Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cargarDatosTabla();
                                            inicializacionCampos();
                                            dgvEscuela.Enabled = true;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ha ocurrido un error, no se ha podido modificar la escuela", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }


                                }
                            }
                            else
                                MessageBox.Show("Debes seleccionar antes un registro para modificar", "¡ERROR!");
                        }
                        else if (opcionBotones == 2)
                        {
                            if ((txtNombreEscuela.Text != "" && txtIdEscuela.Text != "") && (txtDireccionEscuela.Text != "") && (txtTel1Escuela.Text != "") && (txtCorreoEscuela.Text != "") && (txtContactoEscuela.Text != "") && (txtResponsablePagoEscuela.Text != ""))
                            {
                                if (verificarContrasena() == true)
                                {
                                    if (MessageBox.Show("¿Estas seguro de eliminar los datos de " + txtNombreEscuela.Text + "? Si eliminas una escuela tambien se eliminaran los taller, dinamicas, materiales y alumnos de esta escuela ", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        ClassEscuela es = new ClassEscuela();
                                        es.es_id_escuela = txtIdEscuela.Text;
                                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                                        {
                                            try
                                            {
                                                string mensaje = wsPHP.eliminarEscuela(es.es_id_escuela);
                                                MessageBox.Show(mensaje, "¡Escuela Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cargarDatosTabla();
                                                inicializacionCampos();
                                                dgvEscuela.Enabled = true;
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Ha ocurrido un error, no se ha podido eliminar esta escuela", "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Debes seleccionar antes un registro para eliminar", "¡ERROR!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Correo Invalido", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El numero telefonico debe tener 7 digitos si es numero local o 10 digitos si es numero celular", "¡ERROR!");

                }
            }
            else
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
        }
        //VERIFICAR CONTRASEÑA PARA ELIMINAR
        public bool verificarContrasena()
        {
            string passAdmin = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la Contraseña de Administrador: ", "Contraseña para dar permiso para realizar esta accion", "", this.Size.Width / 2 - 100, this.Size.Height / 2);
            if (passAdmin == "")
            {
                return false;
            }
            else if (passAdmin == "IGIWBnvMK$w2Gy?")
            {
                return true;
            }
            else
            {
                MessageBox.Show("La contraseña del administrador es incorrecta, para eliminar debes ingresar la contraseña del administrador", "Permisos denegados");
                verificarContrasena();
            }
            return false;
        }

        //LOAD
        private void ModuloEscuelas_Load(object sender, EventArgs e)
        {
            cargarDatosTabla();
        }


        //CELLCONTENT (DGV)
        private void dgvEscuela_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdEscuela.Text = dgvEscuela.CurrentRow.Cells[0].Value.ToString();
            txtNombreEscuela.Text = dgvEscuela.CurrentRow.Cells[1].Value.ToString();
            txtTel1Escuela.Text = dgvEscuela.CurrentRow.Cells[3].Value.ToString();
            txtTel2Escuela.Text = dgvEscuela.CurrentRow.Cells[4].Value.ToString();
            txtTel3Escuela.Text = dgvEscuela.CurrentRow.Cells[5].Value.ToString();
            txtCorreoEscuela.Text = dgvEscuela.CurrentRow.Cells[6].Value.ToString();
            txtContactoEscuela.Text = dgvEscuela.CurrentRow.Cells[7].Value.ToString();
            txtResponsablePagoEscuela.Text = dgvEscuela.CurrentRow.Cells[8].Value.ToString();
            txtPrecioEscuela.Text = dgvEscuela.CurrentRow.Cells[9].Value.ToString();
            checkPrescolar.Checked = false; checkPrescolar.Enabled = true;
            checkPrimaria.Checked = false; checkPrimaria.Enabled = true;
            checkSecundaria.Checked = false; checkSecundaria.Enabled = true;
            string x = dgvEscuela.CurrentRow.Cells[2].Value.ToString();
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] == ',')
                    break;
                else
                    aux += x[i];
            }
            for (int k = i + 1; k < x.Length; k++)
            {
                aux2 += x[k];
            }
            txtDireccionEscuela.Text = aux2;
            comboBox1.Text = dgvEscuela.CurrentRow.Cells[0].Value.ToString().Substring(0, 3) + " - " + aux;
            String respuestaEscuela = ws.consultaNiveles(txtIdEscuela.Text);
            var respEsc = JsonConvert.DeserializeObject<List<ClassNivelEducativo>>(respuestaEscuela);
            string[] niveles = new string[4];
            int j = 0;
            foreach (var nomEsc in respEsc)
            {
                niveles[j] = nomEsc.ne_nivel_educativo_niveles_escuela;
                j++;
            }
            for (i = 0; i <= j; i++)
            {
                if (niveles[i] == "SECUNDARIA")
                {
                    checkSecundaria.Checked = true;
                    checkSecundaria.Enabled = false;
                }
                if (niveles[i] == "PRIMARIA")
                {
                    checkPrimaria.Checked = true;
                    checkPrimaria.Enabled = false;
                }
                if (niveles[i] == "PRESCOLAR")
                {
                    checkPrescolar.Checked = true;
                    checkPrescolar.Enabled = false;
                }
            }
            aux = aux2 = "";
        }


        //BUSCADOR DE ESCUELAS
        private void txtBuscadorEscuela_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorEscuela.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarEscuela(txtBuscadorEscuela.Text), typeof(DataTable));
                        dgvEscuela.DataSource = dt;
                        NombresColumnas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ninguna escuela con estos datos, Por favor ingrese un nombre o ID Escuela correcto", "No existe esta escuela", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosEscuela(), typeof(DataTable));
                    dgvEscuela.DataSource = dt;
                    NombresColumnas();
                    dgvEscuela.ClearSelection();
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
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.BuscarMAXIDE(sub);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(3, 4));
            //guardar hgo
            sub1 = sub;
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (4 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label8.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvEscuela.Columns[0].HeaderText = "ID Escuela";
            dgvEscuela.Columns[1].HeaderText = "Nombre Escuela";
            dgvEscuela.Columns[2].HeaderText = "Direccion";
            dgvEscuela.Columns[3].HeaderText = "Telefono 1";
            dgvEscuela.Columns[4].HeaderText = "Telefono 2";
            dgvEscuela.Columns[5].HeaderText = "Telefono 3";
            dgvEscuela.Columns[6].HeaderText = "Correo Electronico";
            dgvEscuela.Columns[7].HeaderText = "Contacto Directo";
            dgvEscuela.Columns[8].HeaderText = "Responsable de Pago";
            dgvEscuela.Columns[9].HeaderText = "Precio Talleres";
        }

        public void inicializacionCampos()
        {
            txtIdEscuela.Enabled = false; txtIdEscuela.Text = "";
            txtNombreEscuela.Enabled = false; txtNombreEscuela.Text = "";
            txtDireccionEscuela.Enabled = false; txtDireccionEscuela.Text = "";
            txtTel1Escuela.Enabled = false; txtTel1Escuela.Text = "";
            txtTel2Escuela.Enabled = false; txtTel2Escuela.Text = "";
            txtTel3Escuela.Enabled = false; txtTel3Escuela.Text = "";
            txtCorreoEscuela.Enabled = false; txtCorreoEscuela.Text = "";
            txtContactoEscuela.Enabled = false; txtContactoEscuela.Text = "";
            txtResponsablePagoEscuela.Enabled = false; txtResponsablePagoEscuela.Text = "";
            comboBox1.Enabled = false; comboBox1.Text = "Estado";
            txtPrecioEscuela.Enabled = false; txtPrecioEscuela.Text = "";
            checkPrescolar.Enabled = false; checkPrescolar.Checked = false;
            checkPrimaria.Enabled = false; checkPrimaria.Checked = false; 
            checkSecundaria.Enabled = false; checkSecundaria.Checked = false;
            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion

        private void checkPrescolar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrescolar.Checked == true)
                prescolar = "PRESCOLAR";
        }

        private void txtPrecioEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtPrecioEscuela.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub = comboBox1.Text.Substring(0, 3);
            estado = comboBox1.Text.Substring(6, comboBox1.Text.Length-6);
            //label8.Text = sub+ " | " + estado;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void checkPrimaria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrimaria.Checked == true)
                primaria = "PRIMARIA";
        }

        private void checkSecundaria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSecundaria.Checked)
                secundaria = "SECUNDARIA";
        }
    }
}
