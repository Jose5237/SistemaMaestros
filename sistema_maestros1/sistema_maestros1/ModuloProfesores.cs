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

        //BOTON AGREGAR PROFESOR
        private void btnAgregarProfe_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            txtIdProfe.Enabled = true; txtIdProfe.Text = "";
            txtNombreProfe.Enabled = true; txtNombreProfe.Text = "";
            txtApellidoPatProfe.Enabled = true; txtApellidoPatProfe.Text = "";
            txtApellidoMatProfe.Enabled = true; txtApellidoMatProfe.Text = "";
            txtPasswordProfe.Enabled = true; txtPasswordProfe.Text = "";

            btnAceptar.Enabled = true;
        }

        //BOTON MODIFICAR PROFESOR
        private void btnModificarProfe_Click(object sender, EventArgs e)
        {
            
            opcionBotones = 1;

            txtNombreProfe.Enabled = true;
            txtApellidoPatProfe.Enabled = true;
            txtApellidoMatProfe.Enabled = true;
            txtPasswordProfe.Enabled = true;

            btnAceptar.Enabled = true;
        }

        //BOTON ELIMINAR PROFESOR
        private void btnEliminarProfe_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            txtIdProfe.Enabled = false; 
            txtNombreProfe.Enabled = false;
            txtApellidoPatProfe.Enabled = false;
            txtApellidoMatProfe.Enabled = false;
            txtPasswordProfe.Enabled = false;

            btnAceptar.Enabled = true;
        }

        //BOTON DE ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtIdProfe.Text != "" && txtNombreProfe.Text != "" && txtApellidoPatProfe.Text != "" && txtApellidoMatProfe.Text != "" && txtPasswordProfe.Text != "")
            {

                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
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
                                string mensaje = wsPHP.agregardatosprofesor(pr.pr_id_profesor, pr.pr_nombre_profesor, pr.pr_apellidoPat_profesor, pr.pr_apellidoMat_profesor, pr.pr_contrasena_profesor);
                                MessageBox.Show(mensaje, "¡Profesor Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido agregar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    } else if (opcionBotones == 1)
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


                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido modificar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    } else if (opcionBotones == 2)
                    {
                        ClassProfesor pr = new ClassProfesor();
                        pr.pr_id_profesor = txtIdProfe.Text;

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                string mensaje = wsPHP.eliminardatosprofesor(pr.pr_id_profesor);
                                MessageBox.Show(mensaje, "¡Profesor Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido Eliminar el profesor", "¡Error al agregar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                    {
                        try
                        {
                            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosProfesor(), typeof(DataTable));
                            dgvProfe.DataSource = dt;

                        }
                        catch
                        {
                            MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    txtIdProfe.Enabled = false; txtIdProfe.Text = "";
                    txtNombreProfe.Enabled = false; txtNombreProfe.Text = "";
                    txtApellidoPatProfe.Enabled = false; txtApellidoPatProfe.Text = "";
                    txtApellidoMatProfe.Enabled = false; txtApellidoMatProfe.Text = "";
                    txtPasswordProfe.Enabled = false; txtPasswordProfe.Text = "";
                    btnAceptar.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }

        private void ModuloProfesores_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosProfesor(), typeof(DataTable));
                dgvProfe.DataSource = dt;
            }
        }

        private void dgvProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombreProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtApellidoPatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtApellidoMatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtPasswordProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

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
                        dgvProfe.Columns[0].HeaderText = "ID Profesor";
                        dgvProfe.Columns[1].HeaderText = "Nombre";
                        dgvProfe.Columns[2].HeaderText = "Apellido Paterno";
                        dgvProfe.Columns[3].HeaderText = "Apellido Materno";
                        dgvProfe.Columns[4].HeaderText = "Contraseña";

                    }
                    catch
                    {
                        MessageBox.Show("No se encuentra ninguna escuela con estos datos, Por favor ingrese un nombre o ID Escuela correcto", "No existe esta escuela", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                }
            }
        }

        private void dgvProfe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvProfe.Columns[0].HeaderText = "ID Profesor";
            dgvProfe.Columns[1].HeaderText = "Nombre";
            dgvProfe.Columns[2].HeaderText = "Apellido Paterno";
            dgvProfe.Columns[3].HeaderText = "Apellido Materno";
            dgvProfe.Columns[4].HeaderText = "Contraseña";

            txtIdProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombreProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtApellidoPatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtApellidoMatProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtPasswordProfe.Text = Convert.ToString(dgvProfe.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

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
    }
}
