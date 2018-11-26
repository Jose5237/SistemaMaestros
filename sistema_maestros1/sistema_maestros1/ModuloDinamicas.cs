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
    public partial class ModuloDinamicas : Form
    {

        Validaciones v = new Validaciones();

        public ModuloDinamicas()
        {
            InitializeComponent();
        }
        int opcionBotones = 0;


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

        //METODO DE txtHabilidadesDinamicas PARA ACEPTAR SOLO LETRAS
        private void txtHabilidadesDinamicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetrasYComas(e);
        }

        //BOTON AGREGAR DINAMICA
        private void btnAgregarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            cbEscuelaDinamicas.Enabled = true; cbEscuelaDinamicas.Text = "Seleccionar Escuela";
            txtIdEscuela.Enabled = true; txtIdEscuela.Text = "";

            cbTallerDinamicas.Enabled = true; cbTallerDinamicas.Text = "Seleccionar Taller";
            txtIdTaller.Enabled = true; txtIdTaller.Text = "";

            txtIdDinamicas.Enabled = true; txtIdDinamicas.Text = "";
            txtNombreDinamicas.Enabled = true; txtNombreDinamicas.Text = "";
            txtDescripcionDinamicas.Enabled = true; txtDescripcionDinamicas.Text = "";
            dtFechaIniDinamicas.Enabled = true;
            dtFechaFinDinamicas.Enabled = true;
            txtHabilidadesDinamicas.Enabled = true; txtHabilidadesDinamicas.Text = "";
            txtJustificacionCostoDinamicas.Enabled = true; txtJustificacionCostoDinamicas.Text = "";
            txtHerramientasDinamicas.Enabled = true; txtHerramientasDinamicas.Text = "";

            btnAceptar.Enabled = true;
            

        }

        //BOTON MODIFICAR DINAMICA
        private void btnModificarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            //cbEscuelaDinamicas.Enabled = true;
            //txtIdEscuela.Enabled = true;

            //cbTallerDinamicas.Enabled = true;
            //txtIdTaller.Enabled = true;

            //txtIdDinamicas.Enabled = true; 
            //txtNombreDinamicas.Enabled = true; 
            txtDescripcionDinamicas.Enabled = true; 
            dtFechaIniDinamicas.Enabled = true;
            dtFechaFinDinamicas.Enabled = true;
            txtHabilidadesDinamicas.Enabled = true;
            txtJustificacionCostoDinamicas.Enabled = true; 
            txtHerramientasDinamicas.Enabled = true;

            btnAceptar.Enabled = true;

        }

        //BOTON ELIMINAR DINAMICA
        private void btnEliminarDinamicas_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

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

            btnAceptar.Enabled = true;



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

        private void ModuloDinamicas_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosDinamica(), typeof(DataTable));
                    dgvDinamica.DataSource = dt;
                    NombresColumnas();

                    String respuestaEscuela = wsPHP.cargarDatosEscuela();
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);



                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomEsc.es_nombre_escuela;
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        cbEscuelaDinamicas.Items.Add(item);

                    }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaDinamicas.Text != "" && txtIdEscuela.Text != "") && (cbTallerDinamicas.Text != "" && txtIdTaller.Text != "") && (txtIdDinamicas.Text != "") && (txtNombreDinamicas.Text != "") && (txtDescripcionDinamicas.Text != "") && (dtFechaIniDinamicas.Text != "") && (dtFechaFinDinamicas.Text != "") && (txtHabilidadesDinamicas.Text != "") && (txtJustificacionCostoDinamicas.Text != "") && (txtHerramientasDinamicas.Text != ""))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txtFechaInicio.Text = dtFechaIniDinamicas.Text;
                    txtFechaFin.Text = dtFechaFinDinamicas.Text;



                    if (opcionBotones == 0)
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

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.agregarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica, di.di_nombre_dinamica, di.di_descripcion_dinamica, di.di_fecha_ini_dinamica, di.di_fecha_fin_dinamica, di.di_habilidades_dinamica, di.di_justificacioncosto_dinamica, di.di_herramientas_dinamica);
                            MessageBox.Show(mensaje, "¡Dinamica Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.modificarDinamica(di.di_id_escuela, di.di_id_taller, di.di_id_dinamica, di.di_nombre_dinamica, di.di_descripcion_dinamica, di.di_fecha_ini_dinamica, di.di_fecha_fin_dinamica, di.di_habilidades_dinamica, di.di_justificacioncosto_dinamica, di.di_herramientas_dinamica);
                            MessageBox.Show(mensaje, "¡Dinamica Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else if (opcionBotones == 2)
                    {
                        ClassDinamica di = new ClassDinamica();

                        di.di_id_dinamica = txtIdDinamicas.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarDinamica(di.di_id_dinamica);
                            MessageBox.Show(mensaje, "¡Dinamica Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }

                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                    {

                        try
                        {
                            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosDinamica(), typeof(DataTable));
                            dgvDinamica.DataSource = dt;
                            NombresColumnas();

                        }
                        catch
                        {
                            MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    cbEscuelaDinamicas.Enabled = false; cbEscuelaDinamicas.Text = "Seleccionar Escuela";
                    txtIdEscuela.Enabled = false; txtIdEscuela.Text = "";

                    cbTallerDinamicas.Enabled = false; cbTallerDinamicas.Text = "Seleccionar Taller";
                    txtIdTaller.Enabled = false; txtIdTaller.Text = "";

                    txtIdDinamicas.Enabled = false; txtIdDinamicas.Text = "";
                    txtNombreDinamicas.Enabled = false; txtNombreDinamicas.Text = "";
                    txtDescripcionDinamicas.Enabled = false; txtDescripcionDinamicas.Text = "";
                    dtFechaIniDinamicas.Enabled = false;
                    dtFechaFinDinamicas.Enabled = false;
                    txtHabilidadesDinamicas.Enabled = false; txtHabilidadesDinamicas.Text = "";
                    txtJustificacionCostoDinamicas.Enabled = false; txtJustificacionCostoDinamicas.Text = "";
                    txtHerramientasDinamicas.Enabled = false; txtHerramientasDinamicas.Text = "";

                    btnAceptar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }

        private void dgvDinamica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            cbEscuelaDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdEscuela.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[0].Value.ToString());

            cbTallerDinamicas.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtIdTaller.Text = Convert.ToString(dgvDinamica.Rows[e.RowIndex].Cells[1].Value.ToString());

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



                //NUEVO AGREGADO
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
                    string id = item.Value.ToString();
                    txtIdTaller.Text = id;


                }
            }
        }

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
                    }


                }
            }
        }
    }


}
