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
    public partial class ModuloRecomendaciones : Form
    {
        public ModuloRecomendaciones()
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

                ModuloRecomendaciones recomendaciones = new ModuloRecomendaciones();
                recomendaciones.Show();
            }
        }

        #endregion


        //METODOS DE VALIDACIONES
        #region

        private void cbEscuelaRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTallerRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDinamicaRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMaterialRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON AGREGAR RECOMENDACION
        private void btnAgregarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            dgvRecomendacion.ClearSelection();
            dgvRecomendacion.Enabled = false;

            cbEscuelaRec.Enabled = true; cbEscuelaRec.Text = "Seleccionar Escuela";
            txtIdEscuelaRec.Text = "";

            cbTallerRec.Enabled = true; cbTallerRec.Text = "Seleccionar Taller";
            txtIdTallerRec.Text = "";

            cbDinamicaRec.Enabled = true; cbDinamicaRec.Text = "Seleccionar Dinamica";
            txtIdDinamicaRec.Text = "";

            cbMaterialRec.Enabled = true; cbMaterialRec.Text = "Seleccionar Material";
            txtIdMaterialRec.Text = "";

            txtIdRecomendacion.Enabled = false; txtIdRecomendacion.Text = "";
            txtRecomendacionUsoRec.Enabled = true; txtRecomendacionUsoRec.Text = "";

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Text = "GUARDAR ✔";
        }

        //BOTON MODIFICAR RECOMENDACION
        private void btnModificarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            dgvRecomendacion.Enabled = true;

            cbEscuelaRec.Enabled = false;
            cbTallerRec.Enabled = false;
            cbDinamicaRec.Enabled = false;
            cbMaterialRec.Enabled = false;

            txtIdRecomendacion.Enabled = false;
            txtRecomendacionUsoRec.Enabled = true;

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Text = "GUARDAR ✔";
        }

        //BOTON ELIMINAR RECOMENDACION
        private void btnEliminarRecomendacion_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvRecomendacion.Enabled = true;

            cbEscuelaRec.Enabled = false;
            cbTallerRec.Enabled = false;
            cbDinamicaRec.Enabled = false;
            cbMaterialRec.Enabled = false;

            txtIdRecomendacion.Enabled = false;
            txtRecomendacionUsoRec.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.Visible = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Text = "Eliminar";
        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbEscuelaRec.Text != "" && cbTallerRec.Text != "" && cbDinamicaRec.Text != "" && cbMaterialRec.Text != "" && txtRecomendacionUsoRec.Text != "")
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(opcionBotones == 0)
                    {

                        generarID();
                        
                        ClassRecomendacion re = new ClassRecomendacion();
                        re.re_id_escuela = txtIdEscuelaRec.Text;
                        re.re_id_taller = txtIdTallerRec.Text;
                        re.re_id_dinamica = txtIdDinamicaRec.Text;
                        re.re_id_material = txtIdMaterialRec.Text;
                        re.re_id_recomendaciones = label8.Text;
                        re.re_recomendaciones_recomendaciones = txtRecomendacionUsoRec.Text;
                        
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.AgregarRecomendaciones(re.re_id_escuela, re.re_id_taller, re.re_id_dinamica, re.re_id_material, re.re_id_recomendaciones, re.re_recomendaciones_recomendaciones);
                            MessageBox.Show(mensaje, "¡Recomendacion Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    } else if (opcionBotones == 1)
                    {

                        ClassRecomendacion re = new ClassRecomendacion();
                        re.re_id_escuela = txtIdEscuelaRec.Text;
                        re.re_id_taller = txtIdTallerRec.Text;
                        re.re_id_dinamica = txtIdDinamicaRec.Text;
                        re.re_id_material = txtIdMaterialRec.Text;
                        re.re_id_recomendaciones = txtIdRecomendacion.Text;
                        re.re_recomendaciones_recomendaciones = txtRecomendacionUsoRec.Text;


                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.modificarRecomendaciones(re.re_id_escuela, re.re_id_taller, re.re_id_dinamica, re.re_id_material, re.re_id_recomendaciones, re.re_especificaciones_recomendaciones, re.re_recomendaciones_recomendaciones);
                            MessageBox.Show(mensaje, "¡Recomendacion Modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    } else if (opcionBotones == 2)
                    {
                        ClassRecomendacion re = new ClassRecomendacion();
                        re.re_id_escuela = txtIdEscuelaRec.Text;
                        re.re_id_taller = txtIdTallerRec.Text;
                        re.re_id_dinamica = txtIdDinamicaRec.Text;
                        re.re_id_material = txtIdMaterialRec.Text;
                        re.re_id_recomendaciones = txtIdRecomendacion.Text;


                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarRecomendaciones(re.re_id_escuela, re.re_id_taller, re.re_id_dinamica, re.re_id_material, re.re_id_recomendaciones);
                            MessageBox.Show(mensaje, "¡Recomendacion Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    cargarDatosTabla();
                    inicializacionCampos();
                    dgvRecomendacion.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }


        //SELECTEDINDEX DE COMBOBOX
        #region

        private void cbEscuelaRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaRec.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);
                
                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuelaRec.Text = id;
                }
                
                //NUEVO AGREGADO TALLER
                String respuestaTal = wsPHP.buscarTaller(txtIdEscuelaRec.Text);
                var resptal = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTal);
                cbTallerRec.Items.Clear();
                foreach (var nomtal in resptal)
                {

                    ComboBoxItem item = new ComboBoxItem();

                    item.Text = nomtal.ta_nombre_taller;
                    item.Value = Convert.ToString(nomtal.ta_id_taller);
                    string id = item.Value.ToString();

                    cbTallerRec.Items.Add(item);
                }
            }
        }

        private void cbTallerRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaTaller = wsPHP.buscarTaller(cbTallerRec.Text);
                var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);
                
                foreach (var nomTall in respTall)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomTall.ta_id_taller);
                    string id = item.Value.ToString();
                    txtIdTallerRec.Text = id;
                    
                }

                //NUEVO AGREGADO dinamica
                String respuestaDin = wsPHP.buscarDinamicaXTallerYEscuela(txtIdEscuelaRec.Text, txtIdTallerRec.Text);
                var respDin = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDin);
                cbDinamicaRec.Items.Clear();
                foreach (var nomDin in respDin)
                {

                    ComboBoxItem item = new ComboBoxItem();

                    item.Text = nomDin.di_nombre_dinamica;
                    item.Value = Convert.ToString(nomDin.di_id_dinamica);
                    string id = item.Value.ToString();

                    cbDinamicaRec.Items.Add(item);
                }
            }
        }

        private void cbDinamicaRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaDinamica = wsPHP.buscarDinamica(cbDinamicaRec.Text);
                var respDina = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDinamica);
                
                foreach (var nomDina in respDina)
                {

                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomDina.di_id_dinamica);
                    string id = item.Value.ToString();
                    txtIdDinamicaRec.Text = id;
                    
                }

                //NUEVO AGREGADO
                String respuestaMat = wsPHP.buscarMaterialxdinamica(txtIdEscuelaRec.Text, txtIdTallerRec.Text, txtIdDinamicaRec.Text);
                var respMat = JsonConvert.DeserializeObject<List<ClassMaterial>>(respuestaMat);
                cbMaterialRec.Items.Clear();
                foreach (var nomMat in respMat)
                {
                    ComboBoxItem item = new ComboBoxItem();

                    item.Text = nomMat.ma_nombre_material;
                    item.Value = Convert.ToString(nomMat.ma_id_material);
                    string id = item.Value.ToString();

                    cbMaterialRec.Items.Add(item);
                }
            }
        }

        private void cbMaterialRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                String respuestaMaterial = wsPHP.buscarMaterial(cbMaterialRec.Text);
                var respMate = JsonConvert.DeserializeObject<List<ClassMaterial>>(respuestaMaterial);
                
                foreach (var nomMate in respMate)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomMate.ma_id_material);
                    string id = item.Value.ToString();
                    txtIdMaterialRec.Text = id;
                    
                }
            }
        }

        #endregion

        
        //LOAD
        private void ModuloRecomendaciones_Load(object sender, EventArgs e)
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
                        cbEscuelaRec.Items.Add(item);
            
                    }

                    //TALLER

                    if (txtIdEscuelaRec.Text != "")
                    {


                        String respuestaTaller = wsPHP.cargarDatosDeTaller();
                        var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);

                        foreach (var nomTall in respTall)
                        {
                            ComboBoxItem item = new ComboBoxItem();

                            item.Text = nomTall.ta_nombre_taller;
                            item.Value = Convert.ToString(nomTall.ta_id_taller);
                            cbTallerRec.Items.Add(item);
                        }
                    }

                    //DINAMICA

                    if (txtIdTallerRec.Text != "")
                    {


                        String respuestaDinamica = wsPHP.cargarDatosDinamica();
                        var respDina = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDinamica);

                        foreach (var nomDina in respDina)
                        {
                            ComboBoxItem item = new ComboBoxItem();

                            item.Text = nomDina.di_nombre_dinamica;
                            item.Value = Convert.ToString(nomDina.di_id_dinamica);
                            cbDinamicaRec.Items.Add(item);

                        }
                    }
            
                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        //CELLCONTENT (DGV)
        private void dgvRecomendacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombresColumnas();

            cbEscuelaRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[0].Value.ToString());
            cbTallerRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[1].Value.ToString());
            cbDinamicaRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[2].Value.ToString());
            cbMaterialRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[3].Value.ToString());
            
            txtIdEscuelaRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtIdTallerRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtIdDinamicaRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtIdMaterialRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[7].Value.ToString());

            txtIdRecomendacion.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtRecomendacionUsoRec.Text = Convert.ToString(dgvRecomendacion.Rows[e.RowIndex].Cells[9].Value.ToString());
        }


        //BUSCADOR DE RECOMENDACIONES
        private void txtBuscadorRecomendacion_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorRecomendacion.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarRecomendaciones(txtBuscadorRecomendacion.Text), typeof(DataTable));
                        dgvRecomendacion.DataSource = dt;
                        NombresColumnas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ninguna recomendacion con estos datos, Por favor ingrese un nombre o ID Material correcto", "No existe esta recomendacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarRecomendaciones(), typeof(DataTable));
                    dgvRecomendacion.DataSource = dt;
                    NombresColumnas();

                    dgvRecomendacion.ClearSelection();
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
            sub1 = "re";
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.buscarMAXIDR(txtIdEscuelaRec.Text, txtIdTallerRec.Text, txtIdDinamicaRec.Text, txtIdMaterialRec.Text);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(2, 3));
            //incrementar para nuevo ID
            n++;
            //Generar los 0 necesarios para el ID
            sub2 = new string('0', (3 - Convert.ToString(n).Length));
            //Concatenar el ID
            newID = sub1 + sub2 + Convert.ToString(n);
            label8.Text = newID;
        }

        public void NombresColumnas()
        {
            dgvRecomendacion.Columns[0].HeaderText = "Escuela";
            dgvRecomendacion.Columns[1].HeaderText = "Taller";
            dgvRecomendacion.Columns[2].HeaderText = "Dinamica";
            dgvRecomendacion.Columns[3].HeaderText = "Material";
            dgvRecomendacion.Columns[4].Visible = false;
            dgvRecomendacion.Columns[5].Visible = false;
            dgvRecomendacion.Columns[6].Visible = false;
            dgvRecomendacion.Columns[7].Visible = false;
            dgvRecomendacion.Columns[8].HeaderText = "ID Recomendacion";
            dgvRecomendacion.Columns[9].HeaderText = "Recomendaciones de Uso";
        }

        public void inicializacionCampos()
        {
            cbEscuelaRec.Enabled = false; cbEscuelaRec.Text = "Seleccionar Escuela";
            txtIdEscuelaRec.Text = "";

            cbTallerRec.Enabled = false; cbTallerRec.Text = "Seleccionar Taller";
            txtIdTallerRec.Text = "";

            cbDinamicaRec.Enabled = false; cbDinamicaRec.Text = "Seleccionar Dinamica";
            txtIdDinamicaRec.Text = "";

            cbMaterialRec.Enabled = false; cbMaterialRec.Text = "Seleccionar Material";
            txtIdMaterialRec.Text = "";

            txtIdRecomendacion.Enabled = false; txtIdRecomendacion.Text = "";
            txtRecomendacionUsoRec.Enabled = false; txtRecomendacionUsoRec.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion

        private void cbEscuelaRec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIdTallerRec.Text = "";
            cbTallerRec.Text = "Seleccionar Taller";

            txtIdDinamicaRec.Text = "";
            cbDinamicaRec.Text = "Seleccionar Dinamica";

            txtIdMaterialRec.Text = "";
            cbMaterialRec.Text = "Seleccionar Material";
        }

        private void cbTallerRec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIdDinamicaRec.Text = "";
            cbDinamicaRec.Text = "Seleccionar Dinamica";

            txtIdMaterialRec.Text = "";
            cbMaterialRec.Text = "Seleccionar Material";
        }

        private void cbDinamicaRec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIdMaterialRec.Text = "";
            cbMaterialRec.Text = "Seleccionar Material";
        }
    }
}
