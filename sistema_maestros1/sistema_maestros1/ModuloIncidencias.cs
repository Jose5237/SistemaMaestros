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

namespace sistema_maestros1
{
    public partial class ModuloIncidencias : Form
    {
        public ModuloIncidencias()
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

                ModuloIncidencias incidencias = new ModuloIncidencias();
                incidencias.Show();
            }
        }

        //BOTON DE RECOMENDACIONES
        private void btnRecomendaciones2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de pasar a otra ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                ModuloRecomendaciones recomendaciones = new ModuloRecomendaciones();
                recomendaciones.Show();
            }
        }

        #endregion


        //METODOS DE VALIDACIONES
        #region

        private void cbEscuelaIncidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTipoIncidencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON DE AGREGAR INCIDENCIA
        private void btnAgregarIncidencia_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvIncidencia.ClearSelection();
            dgvIncidencia.Enabled = false;

            txtIdEscuelaIncidencia.Enabled = false; txtIdEscuelaIncidencia.Text = "";
            cbEscuelaIncidencia.Enabled = true; cbEscuelaIncidencia.Text = "Seleccionar Escuela";
            txtIdIncidencia.Enabled = false; txtIdIncidencia.Text = "";
            txtNombreIncidencia.Enabled = true; txtNombreIncidencia.Text = "";
            txtDescripcionIncidencia.Enabled = true; txtDescripcionIncidencia.Text = "";
            cbTipoIncidencias.Enabled = true; cbTipoIncidencias.Text = "Seleccionar Tipo de Incidencia";

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.MediumSeaGreen;

        }

        //BOTON DE MODIFICAR INCIDENCIA
        private void btnModificarIncidencia_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            dgvIncidencia.Enabled = true;

            txtIdEscuelaIncidencia.Enabled = false; 
            cbEscuelaIncidencia.Enabled = false; 
            txtIdIncidencia.Enabled = false; 
            txtNombreIncidencia.Enabled = true;
            txtDescripcionIncidencia.Enabled = true; 
            cbTipoIncidencias.Enabled = true;

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.SteelBlue;
        }

        //BOTON DE ELIMINAR INCIDENCIA
        private void btnEliminarIncidencia_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvIncidencia.Enabled = true;

            txtIdEscuelaIncidencia.Enabled = false;
            cbEscuelaIncidencia.Enabled = false;
            txtIdIncidencia.Enabled = false;
            txtNombreIncidencia.Enabled = false;
            txtDescripcionIncidencia.Enabled = false;
            cbTipoIncidencias.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.IndianRed;
        }

        //BOTON DE ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaIncidencia.Text != "" && txtIdEscuelaIncidencia.Text != "") && (txtNombreIncidencia.Text != "") && (txtDescripcionIncidencia.Text != "") && (cbTipoIncidencias.Text != "Seleccionar Tipo de Incidencia"))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
                    {
                        generarID();
                        
                        ClassIncidencia ins = new ClassIncidencia();
                        ins.in_id_escuela = txtIdEscuelaIncidencia.Text;
                        ins.in_id_incidencias = label5.Text;

                        ins.in_nombre_incidencias = txtNombreIncidencia.Text;
                        ins.in_descripcion_incidencias = txtDescripcionIncidencia.Text;
                        ins.in_tipo_incidencia = cbTipoIncidencias.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.agregarIncidencias(ins.in_id_escuela, ins.in_id_incidencias, ins.in_nombre_incidencias, ins.in_descripcion_incidencias, ins.in_tipo_incidencia);
                            MessageBox.Show(mensaje, "¡Insidencia Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else if (opcionBotones == 1)
                    {

                        ClassIncidencia ins = new ClassIncidencia();
                        ins.in_id_escuela = txtIdEscuelaIncidencia.Text;
                        ins.in_id_incidencias = txtIdIncidencia.Text;
                        ins.in_nombre_incidencias = txtNombreIncidencia.Text;
                        ins.in_descripcion_incidencias = txtDescripcionIncidencia.Text;
                        ins.in_tipo_incidencia = cbTipoIncidencias.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.modificarIncidencias(ins.in_id_escuela, ins.in_id_incidencias, ins.in_nombre_incidencias, ins.in_descripcion_incidencias, ins.in_tipo_incidencia);
                            MessageBox.Show(mensaje, "¡Incidencia Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else if (opcionBotones == 2)
                    {
                        ClassIncidencia ins = new ClassIncidencia();
                        ins.in_id_escuela = txtIdEscuelaIncidencia.Text;
                        ins.in_id_incidencias = txtIdIncidencia.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarIncidencias(ins.in_id_escuela, ins.in_id_incidencias);
                            MessageBox.Show(mensaje, "¡Incidencia Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    cargarDatosTabla();
                    inicializacionCampos();
                    dgvIncidencia.Enabled = true;

                }
            }

            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }
        

        //SELECTEDINDEX DE COMBOBOX
        private void cbEscuelaIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaIncidencia.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuelaIncidencia.Text = id;
                }
            }
        }


        //LOAD
        private void ModuloIncidencias_Load(object sender, EventArgs e)
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
                        cbEscuelaIncidencia.Items.Add(item);
                    }

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //CELLCONTENT (DGV)
        private void dgvIncidencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            cbEscuelaIncidencia.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdEscuelaIncidencia.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtIdIncidencia.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtNombreIncidencia.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtDescripcionIncidencia.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[3].Value.ToString());
            cbTipoIncidencias.Text = Convert.ToString(dgvIncidencia.Rows[e.RowIndex].Cells[4].Value.ToString());
        }


        //BUSCADOR DE INCIDENCIAS
        private void txtBuscadorIncidencia_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorIncidencia.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarIncidencias(txtBuscadorIncidencia.Text), typeof(DataTable));
                        dgvIncidencia.DataSource = dt;
                        NombresColumnas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ninguna  incidencia con estos datos, Por favor ingrese los datos correctos", "No existe ningun registro con este dato", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarIncidencias(), typeof(DataTable));
                    dgvIncidencia.DataSource = dt;
                    NombresColumnas();
                    dgvIncidencia.ClearSelection();

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
            sub1 = txtIdEscuelaIncidencia.Text + "in";
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.buscarMAXIDI(txtIdEscuelaIncidencia.Text);

            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(9, 2));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (2 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label5.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvIncidencia.Columns[0].HeaderText = "Escuela";
            dgvIncidencia.Columns[1].HeaderText = "ID Incidencia";
            dgvIncidencia.Columns[2].HeaderText = "Nombre Incidencia";
            dgvIncidencia.Columns[3].HeaderText = "Descripcion";
            dgvIncidencia.Columns[4].HeaderText = "Tipo Incidencia";
        }

        public void inicializacionCampos()
        {
            txtIdEscuelaIncidencia.Enabled = false; txtIdEscuelaIncidencia.Text = "";
            cbEscuelaIncidencia.Enabled = false; cbEscuelaIncidencia.Text = "Seleccionar Escuela";
            txtIdIncidencia.Enabled = false; txtIdIncidencia.Text = "";
            txtNombreIncidencia.Enabled = false; txtNombreIncidencia.Text = "";
            txtDescripcionIncidencia.Enabled = false; txtDescripcionIncidencia.Text = "";
            cbTipoIncidencias.Enabled = false; cbTipoIncidencias.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion


    }
}
