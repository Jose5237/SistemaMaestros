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
    public partial class ModuloProfesores : Form
    {

        Validaciones v = new Validaciones();

        public ModuloProfesores()
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

        private void txtNombreProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoPatProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoMatProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        #endregion


        //METODO PARA ENCRIPTAR CONTRASEÑA EN EL DGV
        private void dgvProfe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else
                    e.Value = "null";
            }
        }


        //BOTON AGREGAR PROFESOR
        private void btnAgregarProfe_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvProfe.Enabled = false;

            txtIdProfe.Enabled = false; txtIdProfe.Text = "";
            txtNombreProfe.Enabled = true; txtNombreProfe.Text = "";
            txtApellidoPatProfe.Enabled = true; txtApellidoPatProfe.Text = "";
            txtApellidoMatProfe.Enabled = true; txtApellidoMatProfe.Text = "";
            txtPasswordProfe.Enabled = true; txtPasswordProfe.Text = "";
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true;
        }

        //BOTON MODIFICAR PROFESOR
        private void btnModificarProfe_Click(object sender, EventArgs e)
        {
            dgvProfe.Enabled = true;

            opcionBotones = 1;

            txtNombreProfe.Enabled = true;
            txtApellidoPatProfe.Enabled = true;
            txtApellidoMatProfe.Enabled = true;
            txtPasswordProfe.Enabled = true;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true;
        }

        //BOTON ELIMINAR PROFESOR
        private void btnEliminarProfe_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvProfe.Enabled = true;

            txtNombreProfe.Enabled = false;
            txtApellidoPatProfe.Enabled = false;
            txtApellidoMatProfe.Enabled = false;
            txtPasswordProfe.Enabled = false;
            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true;
        }
        
        //BOTON DE ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreProfe.Text != "" && txtApellidoPatProfe.Text != "" && txtApellidoMatProfe.Text != "" && txtPasswordProfe.Text != "")
            {
                if (txtPasswordProfe.Text.Length > 5)
                {
                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (opcionBotones == 0)
                        {
                            generarID();
                            ClassProfesor pr = new ClassProfesor();
                            pr.pr_id_profesor = label7.Text;
                            pr.pr_nombre_profesor = txtNombreProfe.Text;
                            pr.pr_apellidoPat_profesor = txtApellidoPatProfe.Text;
                            pr.pr_apellidoMat_profesor = txtApellidoMatProfe.Text;
                            pr.pr_contrasena_profesor = txtPasswordProfe.Text;
                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                try
                                {
                                    string mensaje = wsPHP.agregardatosprofesor(pr.pr_id_profesor, pr.pr_nombre_profesor, pr.pr_apellidoPat_profesor, pr.pr_apellidoMat_profesor, pr.pr_contrasena_profesor);
                                    MessageBox.Show(mensaje, "¡Profesor Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvProfe.Enabled = true;
                                    btnAceptar.BackColor = Color.Silver;
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido agregar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else if (opcionBotones == 1)
                        {
                            ClassProfesor pr = new ClassProfesor();
                            pr.pr_id_profesor = txtIdProfe.Text;
                            pr.pr_nombre_profesor = txtNombreProfe.Text;
                            pr.pr_apellidoPat_profesor = txtApellidoPatProfe.Text;
                            pr.pr_apellidoMat_profesor = txtApellidoMatProfe.Text;
                            pr.pr_contrasena_profesor = txtPasswordProfe.Text;
                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                try
                                {
                                    string mensaje = wsPHP.modificardatosprofesor(pr.pr_id_profesor, pr.pr_nombre_profesor, pr.pr_apellidoPat_profesor, pr.pr_apellidoMat_profesor, pr.pr_contrasena_profesor);
                                    MessageBox.Show(mensaje, "¡Profesor Modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnAceptar.BackColor = Color.Silver;
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido modificar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (opcionBotones == 2)
                        {
                            ClassProfesor pr = new ClassProfesor();
                            pr.pr_id_profesor = txtIdProfe.Text;
                            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                            {
                                try
                                {
                                    string mensaje = wsPHP.eliminardatosprofesor(pr.pr_id_profesor);
                                    MessageBox.Show(mensaje, "¡Profesor Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnAceptar.BackColor = Color.Silver;
                                }
                                catch
                                {
                                    MessageBox.Show("Ha ocurrido un error, no se ha podido Eliminar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        cargarDatosTabla();
                        inicializacionCampos();
                        dgvProfe.Enabled = true;
                    }
            }
                else
                    MessageBox.Show("La contraseña debe tener almenos 6 caracteres", "¡Contraseña Insegura!");
            }
            else
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
        }


        //LOAD
        private void ModuloProfesores_Load(object sender, EventArgs e)
        {
            cargarDatosTabla();
        }


        //CELLCONTENT (DGV)
        private void dgvProfe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            txtIdProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombreProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtApellidoPatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtApellidoMatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtPasswordProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[4].Value.ToString());
        }


        //BUSCADOR DE PROFESOR
        private void txtBuscadorProfe_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorProfe.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarDatosProfesor(txtBuscadorProfe.Text), typeof(DataTable));
                        dgvProfe.DataSource = dt;
                        NombresColumnas();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ningun Profesor con estos datos, Por favor ingrese un nombre o ID Profesor correcto", "No existe este profesor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosProfesor(), typeof(DataTable));
                    dgvProfe.DataSource = dt;
                    NombresColumnas();
                    dgvProfe.ClearSelection();
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
            sub1 = "p";
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.BuscarMAXIDP();
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(1, 4));
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
            dgvProfe.Columns[0].HeaderText = "ID Profesor";
            dgvProfe.Columns[1].HeaderText = "Nombre";
            dgvProfe.Columns[2].HeaderText = "Apellido Paterno";
            dgvProfe.Columns[3].HeaderText = "Apellido Materno";
            dgvProfe.Columns[4].HeaderText = "Contraseña";
        }

        public void inicializacionCampos()
        {
            txtIdProfe.Enabled = false; txtIdProfe.Text = "";
            txtNombreProfe.Enabled = false; txtNombreProfe.Text = "";
            txtApellidoPatProfe.Enabled = false; txtApellidoPatProfe.Text = "";
            txtApellidoMatProfe.Enabled = false; txtApellidoMatProfe.Text = "";
            txtPasswordProfe.Enabled = false; txtPasswordProfe.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion
        
    }
}
