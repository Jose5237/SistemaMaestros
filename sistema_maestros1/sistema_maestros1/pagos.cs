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
    public partial class ModuloPagos : Form
    {
        public ModuloPagos()
        {
            InitializeComponent();
        }
        int mes = DateTime.Now.Month;
        string añopasado = Convert.ToString(DateTime.Now.Year - 1);
        string añoactual = Convert.ToString(DateTime.Now.Year);
        string añosiguiente = Convert.ToString(DateTime.Now.Year+1);
        int selectedMex;
        double suma;
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


        //BOTON MENU PRINCIPAL
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

        //BOTON DE PADRE O TUTOR
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

        //BOTON DE MATERIAL
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
        private void button1_Click(object sender, EventArgs e)
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


        //VALIDACIONES
        #region

        private void cbMesPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtFechaPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON DE BUSCAR PAGOS DE ALUMNO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdAlumnoPagos.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtIdAlumnoPagos.Text), typeof(DataTable));
                        dgvPagos.DataSource = dt;
                        NombresColumnasPagos();
                        txtIdEscuelaG2.Text = dgvPagos.Rows[0].Cells[0].Value.ToString();
                        txtEscuelaPagos.Text = cbEscuelaPagos.Text;
                        txtIdAlumnoG2.Text = dgvPagos.Rows[0].Cells[1].Value.ToString();
                        txtNomAlumnoPagos.Text = txtAlumnoPagos.Text;
                        txtIdPagos.Text = dgvPagos.Rows[0].Cells[2].Value.ToString();
                        groupBox2.Visible = true;
                        String respuestaEscuela = wsPHP.buscarEscuela(txtEscuelaPagos.Text);
                        var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                        foreach (var nomEsc in respEsc)
                        {
                            txtPrecioTaller.Text = Convert.ToString(nomEsc.es_precio_escuela);
                        }
                        dgvPagos.ClearSelection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encontro ningun pago con el nombre del alumno que indicaste, Por favor ingrese un nombre de alumno correcto", "No existe este tutor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero indique un alumno para poder hacer su busqueda de pagos", "Seleccione Alumno para busqueda de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        //BOTON DE ACTUALIZAR PAGO
        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            if (cbMesPagos.Text != "Seleccionar mes" && txtImportePago.Text != "")
            {
                if (txtIdAlumnoG2.Text == txtIdAlumnoPagos.Text)
                {


                    if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            try
                            {
                                suma = Convert.ToDouble(dgvPagos.Rows[0].Cells[selectedMex].Value.ToString()) + Convert.ToDouble(txtImportePago.Text);
                                if (suma > Convert.ToDouble(txtPrecioTaller.Text))
                                {
                                    if (MessageBox.Show("La suma del importe ya registrado y de la cantidad ingresada (" + Convert.ToString(suma) + ") superan la mensualidad del mes (" + txtPrecioTaller.Text + ")\n¿Esta seguro de guardar esa cantidad de dinero?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        string mes = "pa_" + cbMesPagos.Text + "_pago";
                                        string mensaje = wsPHP.modificarPagos(txtIdAlumnoG2.Text, mes, suma);
                                        MessageBox.Show(mensaje, "¡Pago Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    string mes2 = "pa_" + cbMesPagos.Text + "_pago";
                                    string mensaje2 = wsPHP.modificarPagos(txtIdAlumnoG2.Text, mes2, suma);
                                    MessageBox.Show(mensaje2, "¡Pago Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Ha ocurrido un error, no se ha podido actualizar los datos", "¡Error al registrar el pago!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        cargarDatosTablaPagos();
                        cbMesPagos.Text = "Seleccionar Mes";
                        txtImportePago.Text = "";
                        //vaciar();


                    }
                }
                else
                {
                    MessageBox.Show("El pago de este alumno no coincide con el alumno seleccionado en la tabla, favor de presionar boton de buscar para seleccionar el alumno correcto", "No coinciden los datos");
                    groupBox2.Visible = false;
                }
                }
            else
                MessageBox.Show("Primero debe seleccionar el mes y el monto a sumar", "¡Pago Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //LOAD
        private void ModuloPagos_Load(object sender, EventArgs e)
        {
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
                        cbEscuelaPagos.Items.Add(item);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //SELECTEDINDEX DE COMBOBOX
        private void cbEscuelaPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaPagos.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                
                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuela1.Text = id;
                }
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela1.Text), typeof(DataTable));
                dgvAlumnoPagos.DataSource = dt;
                dgvAlumnoPagos.BringToFront();
                label8.Visible = true;
                txtbuscar.Visible = true;
                lblmsg.Visible = false;
                if(dgvAlumnoPagos.RowCount == 0)
                {
                    label8.Visible = false;
                    txtbuscar.Visible = false;
                    MessageBox.Show("Esta escuela aun no tiene alumnos registrados\nPor favor vaya al modulo de Alumnos para agregar alumnos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    lblmsg.BringToFront();
                    lblmsg.Visible = true;
                }
                else
                    NombresColumnasAlumno();

            }
        }

       


      

        //cargar datos de alumno dependiendo de la escuela
        public void cargarDatosTablaAlumnos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela1.Text), typeof(DataTable));
                    dgvAlumnoPagos.DataSource = dt;
                    NombresColumnasAlumno();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Cargar tabla de pagos del alumno
        public void cargarDatosTablaPagos()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarPagos(txtIdAlumnoG2.Text), typeof(DataTable));
                    dgvPagos.DataSource = dt;
                    NombresColumnasPagos();
                    dgvPagos.ClearSelection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        public void NombresColumnasAlumno()
        {
            dgvAlumnoPagos.Columns[0].HeaderText = "Escuela";
            dgvAlumnoPagos.Columns[1].Visible = false;
            dgvAlumnoPagos.Columns[2].HeaderText = "ID Alumno";
            dgvAlumnoPagos.Columns[3].HeaderText = "Nombre(s)";
            dgvAlumnoPagos.Columns[4].HeaderText = "Apellido Paterno";
            dgvAlumnoPagos.Columns[5].HeaderText = "Apellido Materno";
            dgvAlumnoPagos.Columns[6].HeaderText = "Grado";
            dgvAlumnoPagos.Columns[7].HeaderText = "Nivel Educativo";
            dgvAlumnoPagos.Columns[8].HeaderText = "Status";
        }

        public void NombresColumnasPagos()
        {
            dgvPagos.Columns[0].Visible = false;
            dgvPagos.Columns[1].Visible = false;
            dgvPagos.Columns[2].Visible = false;

            if (mes >= 1 && mes <= 7)
            {
                dgvPagos.Columns[3].HeaderText = "AGO " + añopasado;
                dgvPagos.Columns[4].HeaderText = "SEP " + añopasado;
                dgvPagos.Columns[5].HeaderText = "OCT " + añopasado;
                dgvPagos.Columns[6].HeaderText = "NOV " + añopasado;
                dgvPagos.Columns[7].HeaderText = "DIC " + añopasado;
                dgvPagos.Columns[8].HeaderText = "ENE " + añoactual;
                dgvPagos.Columns[9].HeaderText = "FEB " + añoactual;
                dgvPagos.Columns[10].HeaderText = "MAR " + añoactual;
                dgvPagos.Columns[11].HeaderText = "ABR " + añoactual;
                dgvPagos.Columns[12].HeaderText = "MAY " + añoactual;
                dgvPagos.Columns[13].HeaderText = "JUN " + añoactual;
                dgvPagos.Columns[14].HeaderText = "JUL " + añoactual;
            } else if(mes >= 8 && mes <= 12)
            {
                dgvPagos.Columns[3].HeaderText = "AGO " + añoactual;
                dgvPagos.Columns[4].HeaderText = "SEP " + añoactual;
                dgvPagos.Columns[5].HeaderText = "OCT " + añoactual;
                dgvPagos.Columns[6].HeaderText = "NOV " + añoactual;
                dgvPagos.Columns[7].HeaderText = "DIC " + añoactual;
                dgvPagos.Columns[8].HeaderText = "ENE " + añosiguiente;
                dgvPagos.Columns[9].HeaderText = "FEB " + añosiguiente;
                dgvPagos.Columns[10].HeaderText = "MAR " + añosiguiente;
                dgvPagos.Columns[11].HeaderText = "ABR " + añosiguiente;
                dgvPagos.Columns[12].HeaderText = "MAY " + añosiguiente;
                dgvPagos.Columns[13].HeaderText = "JUN " + añosiguiente;
                dgvPagos.Columns[14].HeaderText = "JUL " + añosiguiente;
            }
        }
        public void vaciar()
        {
            txtIdPagos.Text = "";
            txtIdEscuelaG2.Text = "";
            txtEscuelaPagos.Text = "";
            txtIdAlumnoG2.Text = "";
            txtNomAlumnoPagos.Text = "";
            txtAlumnoPagos.Text = "";
            txtPrecioTaller.Text = "";
            cbMesPagos.Text = "Seleccionar mes";
            txtImportePago.Text = "";
            btnBuscar.Enabled = false;
            btnBuscar.BackColor = Color.Gainsboro;

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumnosPagos(txtIdEscuela1.Text, txtbuscar.Text), typeof(DataTable));
                    dgvAlumnoPagos.DataSource = dt;
                    if (dgvAlumnoPagos.RowCount < 1)
                    {
                        MessageBox.Show("No se encuentra ningun alumno con estos datos, Por favor ingrese un nombre o ID Alumno correcto", "No existe este alumno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cargarDatosTablaAlumnos();
                        NombresColumnasAlumno();
                    }
                }
            }
            else
            {
                cargarDatosTablaAlumnos();
                NombresColumnasAlumno();
            }
        }

        private void dgvAlumnoPagos_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdAlumnoPagos.Text =dgvAlumnoPagos.CurrentRow.Cells[2].Value.ToString();
            txtAlumnoPagos.Text = dgvAlumnoPagos.CurrentRow.Cells[3].Value.ToString();
            btnBuscar.BackColor = Color.SkyBlue;
            btnBuscar.Enabled = true;

        }

        private void cbMesPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMesPagos.Text == "agosto")
                selectedMex = 3;
            if (cbMesPagos.Text == "septiembre")
                selectedMex = 4;
            if (cbMesPagos.Text == "octubre")
                selectedMex = 5;
            if (cbMesPagos.Text == "noviembre")
                selectedMex = 6;
            if (cbMesPagos.Text == "diciembre")
                selectedMex = 7;
            if (cbMesPagos.Text == "enero")
                selectedMex = 8;
            if (cbMesPagos.Text == "febrero")
                selectedMex = 9;
            if (cbMesPagos.Text == "marzo")
                selectedMex = 10;
            if (cbMesPagos.Text == "abril")
                selectedMex = 11;
            if (cbMesPagos.Text == "mayo")
                selectedMex = 12;
            if (cbMesPagos.Text == "junio")
                selectedMex = 13;
            if (cbMesPagos.Text == "julio")
                selectedMex = 14;
        }

        private void cbEscuelaPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEscuelaPagos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtAlumnoPagos.Text = "";
            txtIdAlumnoPagos.Text = "";
            groupBox2.Visible = false;
        }
    }
}
