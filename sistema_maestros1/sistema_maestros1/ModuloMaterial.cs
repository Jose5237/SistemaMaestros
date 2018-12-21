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
    public partial class ModuloMaterial : Form
    {

        Validaciones v = new Validaciones();

        public ModuloMaterial()
        {
            InitializeComponent();
        }

        //VARIABLES
        int opcionBotones = 3;

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

        //BOTON DE MATERIALES (NO HACE NADA)
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
        //METODO DE txtCostoMaterial PARA SOLO ACEPTAR NUMEROS Y NUMEROS CON PUNTO DECIMAL
        private void txtCostoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 46 && txtCostoMaterial.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }


        private void cbEscuelaMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTallerMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDinamicaMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion


        //BOTON AGREGAR MATERIAL
        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {

            opcionBotones = 0;

            dgvMaterial.ClearSelection();
            dgvMaterial.Enabled = false;

            cbEscuelaMaterial.Enabled = true; cbEscuelaMaterial.Text = "Seleccionar Escuela";
            txtIdEscuela.Text = "";

            cbTallerMaterial.Enabled = true; cbTallerMaterial.Text = "Seleccionar Taller";
            txtIdTaller.Text = "";

            cbDinamicaMaterial.Enabled = true; cbDinamicaMaterial.Text = "Seleccionar Dinamica";
            txtIdDinamica.Text = "";
            txtIdMaterial.Text = "";
            txtNombreMaterial.Enabled = true; txtNombreMaterial.Text = "";
            txtCostoMaterial.Enabled = true; txtCostoMaterial.Text = "";

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.MediumSeaGreen; btnAceptar.Visible = true; btnAceptar.Text = "GUARDAR ✔";
        }

        //BOTON MODIFICAR MATERIAL
        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;

            dgvMaterial.Enabled = true;

            cbEscuelaMaterial.Enabled = false;
            cbTallerMaterial.Enabled = false;
            cbDinamicaMaterial.Enabled = false;
            txtIdMaterial.Enabled = false;
            txtNombreMaterial.Enabled = true;
            txtCostoMaterial.Enabled = true;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.SteelBlue; btnAceptar.Visible = true; btnAceptar.Text = "GUARDAR ✔";

        }

        //BOTON ELIMINAR MATERIAL
        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            dgvMaterial.Enabled = true;

            cbEscuelaMaterial.Enabled = false;
            cbTallerMaterial.Enabled = false;
            cbDinamicaMaterial.Enabled = false;
            txtIdMaterial.Enabled = false;
            txtNombreMaterial.Enabled = false;
            txtCostoMaterial.Enabled = false;

            btnAceptar.Enabled = true; btnAceptar.BackColor = Color.IndianRed; btnAceptar.Visible = true; btnAceptar.Text = "Eliminar";

        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaMaterial.Text != "" && txtIdEscuela.Text != "") && (cbTallerMaterial.Text != "" && txtIdTaller.Text != "") && (cbDinamicaMaterial.Text != "" && txtIdDinamica.Text != "") && (txtNombreMaterial.Text != "") && (txtCostoMaterial.Text != ""))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
                    {
                        generarID();
                        ClassMaterial ma = new ClassMaterial();
                        ma.ma_id_escuela = txtIdEscuela.Text;
                        ma.ma_id_taller = txtIdTaller.Text;
                        ma.ma_id_dinamica = txtIdDinamica.Text;
                        ma.ma_id_material = label8.Text;
                        ma.ma_nombre_material = txtNombreMaterial.Text;
                        ma.ma_costo_material = Convert.ToDouble(txtCostoMaterial.Text);

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.agregarMaterial(ma.ma_id_escuela, ma.ma_id_taller, ma.ma_id_dinamica, ma.ma_id_material, ma.ma_nombre_material, ma.ma_costo_material);
                            MessageBox.Show(mensaje, "¡Material Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else if (opcionBotones == 1)
                    {
                        cbEscuelaMaterial.Enabled = false;
                        cbTallerMaterial.Enabled = false;
                        cbDinamicaMaterial.Enabled = false;
                        ClassMaterial ma = new ClassMaterial();
                        ma.ma_id_escuela = txtIdEscuela.Text;
                        ma.ma_id_taller = txtIdTaller.Text;
                        ma.ma_id_dinamica = txtIdDinamica.Text;
                        ma.ma_id_material = txtIdMaterial.Text;
                        ma.ma_nombre_material = txtNombreMaterial.Text;
                        ma.ma_costo_material = Convert.ToDouble(txtCostoMaterial.Text);

                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.modificarMaterial(ma.ma_id_escuela, ma.ma_id_taller, ma.ma_id_dinamica, ma.ma_id_material, ma.ma_nombre_material, ma.ma_costo_material);
                            MessageBox.Show(mensaje, "¡Material Modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else if (opcionBotones == 2)
                    {
                        ClassMaterial ma = new ClassMaterial();
                        ma.ma_id_escuela = txtIdEscuela.Text;
                        ma.ma_id_taller = txtIdTaller.Text;
                        ma.ma_id_dinamica = txtIdDinamica.Text;
                        ma.ma_id_material = txtIdMaterial.Text;
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarMaterial(ma.ma_id_escuela, ma.ma_id_taller, ma.ma_id_dinamica, ma.ma_id_material);
                            MessageBox.Show(mensaje, "¡Material Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    cargarDatosTabla();
                    inicializacionCampos();
                    dgvMaterial.Enabled = true;

                }
            }

            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }


        //SELECTEDINDEX DE COMBOBOX
        #region

        private void cbEscuelaMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuelaMaterial.Text);
                    var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                    foreach (var nomEsc in respEsc)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomEsc.es_id_escuela);
                        string id = item.Value.ToString();
                        txtIdEscuela.Text = id;
                    }

                    //NUEVO AGREGADO TALLER
                    String respuestaTal = wsPHP.buscarTaller(txtIdEscuela.Text);
                    var resptal = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTal);
                    cbTallerMaterial.Items.Clear();
                    foreach (var nomtal in resptal)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomtal.ta_nombre_taller;
                        item.Value = Convert.ToString(nomtal.ta_id_taller);
                        string id = item.Value.ToString();

                        cbTallerMaterial.Items.Add(item);
                    }
                }
            }
        }

        private void cbTallerMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaTaller = wsPHP.buscarTaller(cbTallerMaterial.Text);
                    var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);

                    foreach (var nomTall in respTall)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomTall.ta_id_taller);
                        string id = item.Value.ToString();
                        txtIdTaller.Text = id;

                    }

                    //NUEVO AGREGADO
                    String respuestaDin = wsPHP.buscarDinamicaXTallerYEscuela(txtIdEscuela.Text, txtIdTaller.Text);
                    var respDin = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDin);
                    cbDinamicaMaterial.Items.Clear();
                    foreach (var nomDin in respDin)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomDin.di_nombre_dinamica;
                        item.Value = Convert.ToString(nomDin.di_id_dinamica);
                        string id = item.Value.ToString();
                        cbDinamicaMaterial.Items.Add(item);
                    }
                }
            }
        }

        private void cbDinamicaMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    String respuestaDinamica = wsPHP.buscarDinamica(cbDinamicaMaterial.Text);
                    var respDina = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDinamica);

                    foreach (var nomDina in respDina)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = Convert.ToString(nomDina.di_id_dinamica);
                        string id = item.Value.ToString();
                        txtIdDinamica.Text = id;

                    }
                }
            }
        }

        #endregion

        //LOAD
        private void ModuloMaterial_Load(object sender, EventArgs e)
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
                        cbEscuelaMaterial.Items.Add(item);
            
                    }

                    //TALLER

                    if (txtIdEscuela.Text != "")
                    {



                        String respuestaTaller = wsPHP.cargarDatosDeTaller();
                        var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);

                        foreach (var nomTall in respTall)
                        {
                            ComboBoxItem item = new ComboBoxItem();

                            item.Text = nomTall.ta_nombre_taller;
                            item.Value = Convert.ToString(nomTall.ta_id_taller);
                            cbTallerMaterial.Items.Add(item);

                        }
                    }

                    //DINAMICA

                    if (txtIdTaller.Text != "")
                    {


                        String respuestaDinamica = wsPHP.cargarDatosDinamica();
                        var respDina = JsonConvert.DeserializeObject<List<ClassDinamica>>(respuestaDinamica);

                        foreach (var nomDina in respDina)
                        {
                            ComboBoxItem item = new ComboBoxItem();

                            item.Text = nomDina.di_nombre_dinamica;
                            item.Value = Convert.ToString(nomDina.di_id_dinamica);
                            cbDinamicaMaterial.Items.Add(item);

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
        private void dgvMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            //NombresColumnas();

            cbEscuelaMaterial.Text = dgvMaterial.CurrentRow.Cells[0].Value.ToString();
            cbTallerMaterial.Text = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            cbDinamicaMaterial.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();

            txtIdEscuela.Text = dgvMaterial.CurrentRow.Cells[3].Value.ToString();
            txtIdTaller.Text = dgvMaterial.CurrentRow.Cells[4].Value.ToString();
            txtIdDinamica.Text = dgvMaterial.CurrentRow.Cells[5].Value.ToString();

            txtIdMaterial.Text     = dgvMaterial.CurrentRow.Cells[6].Value.ToString();
            txtNombreMaterial.Text = dgvMaterial.CurrentRow.Cells[7].Value.ToString();
            txtCostoMaterial.Text  = dgvMaterial.CurrentRow.Cells[8].Value.ToString();
        }

        //BUSCADOR DE MATERIAL
        private void txtBuscadorMaterial_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorMaterial.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarMaterial(txtBuscadorMaterial.Text), typeof(DataTable));
                        dgvMaterial.DataSource = dt;
                        NombresColumnas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ningun alumno con estos datos, Por favor ingrese un nombre o ID Alumno correcto", "No existe este alumno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosMaterial(), typeof(DataTable));
                    dgvMaterial.DataSource = dt;
                    NombresColumnas();
                    dgvMaterial.ClearSelection();

                } catch (Exception)
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
            sub1 = "m" + cbTallerMaterial.Text.Substring(0, 3);
            //Obtener el ultimo id de la BDD
            ultimoID = wsPHP.buscarMAXIDM(txtIdEscuela.Text, txtIdTaller.Text, txtIdDinamica.Text, sub1);
            if (ultimoID == "")
                n = 0;
            else
                //guardar el numero del ultimo ID
                n = Convert.ToInt32(ultimoID.Substring(4, 3));
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
            dgvMaterial.Columns[0].HeaderText = "Escuela";
            dgvMaterial.Columns[1].HeaderText = "Taller";
            dgvMaterial.Columns[2].Visible = false;
            dgvMaterial.Columns[3].Visible = false;
            dgvMaterial.Columns[4].Visible = false;
            dgvMaterial.Columns[5].HeaderText = "Dinamica";
            dgvMaterial.Columns[6].HeaderText = "ID Material";
            dgvMaterial.Columns[7].HeaderText = "Nombre de Material";
            dgvMaterial.Columns[8].HeaderText = "Costo Unitario";
        }

        public void inicializacionCampos()
        {
            cbEscuelaMaterial.Enabled = false; cbEscuelaMaterial.Text = "Seleccionar Escuela";
            txtIdEscuela.Text = "";

            cbTallerMaterial.Enabled = false; cbTallerMaterial.Text = "Seleccionar Taller";
            txtIdTaller.Text = "";

            cbDinamicaMaterial.Enabled = false; cbDinamicaMaterial.Text = "Seleccionar Dinamica";
            txtIdDinamica.Text = "";

            txtIdMaterial.Enabled = false; txtIdMaterial.Text = "";
            txtNombreMaterial.Enabled = false; txtNombreMaterial.Text = "";
            txtCostoMaterial.Enabled = false; txtCostoMaterial.Text = "";

            btnAceptar.Enabled = false; btnAceptar.Visible = false;
        }

        #endregion

        private void cbEscuelaMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                txtIdTaller.Text = "";
                cbTallerMaterial.Text = "Seleccionar Taller";

                txtIdDinamica.Text = "";
                cbDinamicaMaterial.Text = "Seleccionar Dinamica";
            }
        }

        private void cbTallerMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (opcionBotones == 0)
            {
                txtIdDinamica.Text = "";
                cbDinamicaMaterial.Text = "Seleccionar Dinamica";
            }
        }

       
    }
}
