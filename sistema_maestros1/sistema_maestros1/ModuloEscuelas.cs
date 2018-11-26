using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        int opcionBotones = 0;


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

        #endregion

        //BOTON AGREGAR ESCUELA
        private void btnAgregarEscuela_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            txtIdEscuela.Enabled = true; txtIdEscuela.Text = "";
            txtNombreEscuela.Enabled = true; txtNombreEscuela.Text = "";
            txtDireccionEscuela.Enabled = true; txtDireccionEscuela.Text = "";
            txtTel1Escuela.Enabled = true; txtTel1Escuela.Text = "";
            txtTel2Escuela.Enabled = true; txtTel2Escuela.Text = "";
            txtTel3Escuela.Enabled = true; txtTel3Escuela.Text = "";
            txtCorreoEscuela.Enabled = true; txtCorreoEscuela.Text = "";
            txtContactoEscuela.Enabled = true; txtContactoEscuela.Text = "";
            txtResponsablePagoEscuela.Enabled = true; txtResponsablePagoEscuela.Text = "";

            btnAceptar.Enabled = true;
        }

        //BOTON MODIFICAR ESCUELA
        private void btnModificarEscuela_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            txtIdEscuela.Enabled = false;
            txtNombreEscuela.Enabled = true;
            txtDireccionEscuela.Enabled = true; 
            txtTel1Escuela.Enabled = true;
            txtTel2Escuela.Enabled = true; 
            txtTel3Escuela.Enabled = true;
            txtCorreoEscuela.Enabled = true;
            txtContactoEscuela.Enabled = true;
            txtResponsablePagoEscuela.Enabled = true;

            btnAceptar.Enabled = true;
        }

        //BOTON ELIMINAR ESCUELA
        private void btnEliminarEscuela_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            txtIdEscuela.Enabled = false;
            txtNombreEscuela.Enabled = false;
            txtDireccionEscuela.Enabled = false;
            txtTel1Escuela.Enabled = false;
            txtTel2Escuela.Enabled = false;
            txtTel3Escuela.Enabled = false;
            txtCorreoEscuela.Enabled = false;
            txtContactoEscuela.Enabled = false;
            txtResponsablePagoEscuela.Enabled = false;

            btnAceptar.Enabled = true;
        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdEscuela.Text != "") && (txtNombreEscuela.Text != "") && (txtDireccionEscuela.Text != "") && (txtTel1Escuela.Text != "") && (txtCorreoEscuela.Text != "") && (txtContactoEscuela.Text != "") && (txtResponsablePagoEscuela.Text != ""))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (opcionBotones == 0)
                    {

                        ClassEscuela es = new ClassEscuela();
                        es.es_id_escuela = txtIdEscuela.Text;
                        es.es_nombre_escuela = txtNombreEscuela.Text;
                        es.es_direccion_escuela = txtDireccionEscuela.Text;
                        es.es_telefono1_escuela = txtTel1Escuela.Text;
                        es.es_telefono2_escuela = txtTel2Escuela.Text;
                        es.es_telefono3_escuela = txtTel3Escuela.Text;
                        es.es_correo_escuela = txtCorreoEscuela.Text;
                        es.es_contacto_escuela = txtContactoEscuela.Text;
                        es.es_responsable_pago_escuela = txtResponsablePagoEscuela.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                string mensaje = wsPHP.agregarEscuela(es.es_id_escuela, es.es_nombre_escuela, es.es_direccion_escuela, es.es_telefono1_escuela, es.es_telefono2_escuela, es.es_telefono3_escuela, es.es_correo_escuela, es.es_contacto_escuela ,es.es_responsable_pago_escuela);
                                MessageBox.Show(mensaje, "¡Escuela Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido agregar la escuela", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else if (opcionBotones == 1)
                    {

                        ClassEscuela es = new ClassEscuela();
                        es.es_id_escuela = txtIdEscuela.Text;
                        es.es_nombre_escuela = txtNombreEscuela.Text;
                        es.es_direccion_escuela = txtDireccionEscuela.Text;
                        es.es_telefono1_escuela = txtTel1Escuela.Text;
                        es.es_telefono2_escuela = txtTel2Escuela.Text;
                        es.es_telefono3_escuela = txtTel3Escuela.Text;
                        es.es_correo_escuela = txtCorreoEscuela.Text;
                        es.es_contacto_escuela = txtContactoEscuela.Text;
                        es.es_responsable_pago_escuela = txtResponsablePagoEscuela.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                string mensaje = wsPHP.modificarEscuela(es.es_id_escuela, es.es_nombre_escuela, es.es_direccion_escuela, es.es_telefono1_escuela, es.es_telefono2_escuela, es.es_telefono3_escuela, es.es_correo_escuela, es.es_contacto_escuela ,es.es_responsable_pago_escuela);
                                MessageBox.Show(mensaje, "¡Escuela Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido modificar la escuela", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                    }
                    else if (opcionBotones == 2)
                    {
                        ClassEscuela es = new ClassEscuela();
                        es.es_id_escuela = txtIdEscuela.Text;



                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                string mensaje = wsPHP.eliminarEscuela(es.es_id_escuela);
                                MessageBox.Show(mensaje, "¡Escuela Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido eliminar esta escuela", "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                    {
                        try
                        {
                            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosEscuela(), typeof(DataTable));
                            dgvEscuela.DataSource = dt;

                        }
                        catch
                        {
                            MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    txtIdEscuela.Enabled = false; txtIdEscuela.Text = "";
                    txtNombreEscuela.Enabled = false; txtNombreEscuela.Text = "";
                    txtDireccionEscuela.Enabled = false; txtDireccionEscuela.Text = "";
                    txtTel1Escuela.Enabled = false; txtTel1Escuela.Text = "";
                    txtTel2Escuela.Enabled = false; txtTel2Escuela.Text = "";
                    txtTel3Escuela.Enabled = false; txtTel3Escuela.Text = "";
                    txtCorreoEscuela.Enabled = false; txtCorreoEscuela.Text = "";
                    txtContactoEscuela.Enabled = false; txtContactoEscuela.Text = "";
                    txtResponsablePagoEscuela.Enabled = false; txtResponsablePagoEscuela.Text = "";

                    btnAceptar.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }

        private void ModuloEscuelas_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosEscuela(), typeof(DataTable));
                dgvEscuela.DataSource = dt;

                dgvEscuela.Columns[0].HeaderText = "ID Escuela";
                dgvEscuela.Columns[1].HeaderText = "Nombre Escuela";
                dgvEscuela.Columns[2].HeaderText = "Direccion";
                dgvEscuela.Columns[3].HeaderText = "Telefono 1";
                dgvEscuela.Columns[4].HeaderText = "Telefono 2";
                dgvEscuela.Columns[5].HeaderText = "Telefono 3";
                dgvEscuela.Columns[6].HeaderText = "Correo Electronico";
                dgvEscuela.Columns[7].HeaderText = "Contacto Directo";
                dgvEscuela.Columns[8].HeaderText = "Responsable de Pago";

            }
        }

        private void dgvEscuela_CellContentClick(object sender, DataGridViewCellEventArgs e)
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



            txtIdEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombreEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtDireccionEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtTel1Escuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtTel2Escuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtTel3Escuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtCorreoEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtContactoEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[7].Value.ToString());
            txtResponsablePagoEscuela.Text = Convert.ToString(dgvEscuela.Rows[e.RowIndex].Cells[8].Value.ToString());
        }

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
                        dgvEscuela.Columns[0].HeaderText = "ID Escuela";
                        dgvEscuela.Columns[1].HeaderText = "Nombre Escuela";
                        dgvEscuela.Columns[2].HeaderText = "Direccion";
                        dgvEscuela.Columns[3].HeaderText = "Telefono 1";
                        dgvEscuela.Columns[4].HeaderText = "Telefono 2";
                        dgvEscuela.Columns[5].HeaderText = "Telefono 3";
                        dgvEscuela.Columns[6].HeaderText = "Correo Electronico";
                        dgvEscuela.Columns[7].HeaderText = "Contacto Directo";
                        dgvEscuela.Columns[8].HeaderText = "Responsable de Pago";

                    }
                    catch
                    {
                        MessageBox.Show("No se encuentra ninguna escuela con estos datos, Por favor ingrese un nombre o ID Escuela correcto", "No existe esta escuela", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                }
            }
        }
    }
}
