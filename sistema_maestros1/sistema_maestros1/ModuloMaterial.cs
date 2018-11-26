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

        //METODO DE txtCostoMaterial PARA SOLO ACEPTAR NUMEROS Y NUMEROS CON PUNTO DECIMAL
        private void txtCostoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumerosDecimal(e);
        }

        //BOTON AGREGAR MATERIAL
        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            opcionBotones = 0;

            cbEscuelaMaterial.Enabled = true; cbEscuelaMaterial.Text = "Seleccionar Escuela";
            txtIdEscuela.Text = "";

            cbTallerMaterial.Enabled = true; cbTallerMaterial.Text = "Seleccionar Taller";
            txtIdTaller.Text = "";

            cbDinamicaMaterial.Enabled = true; cbDinamicaMaterial.Text = "Seleccionar Dinamica";
            txtIdDinamica.Text = "";

            txtIdMaterial.Enabled = true; txtIdMaterial.Text = "";
            txtNombreMaterial.Enabled = true; txtNombreMaterial.Text = "";
            txtCostoMaterial.Enabled = true; txtCostoMaterial.Text = "";

            btnAceptar.Enabled = true;
        }

        //BOTON MODIFICAR MATERIAL
        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            opcionBotones = 1;
            cbEscuelaMaterial.Enabled = true;
            cbTallerMaterial.Enabled = true; 
            cbDinamicaMaterial.Enabled = true; 
            txtIdMaterial.Enabled = true; 
            txtNombreMaterial.Enabled = true; 
            txtCostoMaterial.Enabled = true;

            btnAceptar.Enabled = true;

        }

        //BOTON ELIMINAR MATERIAL
        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            opcionBotones = 2;

            opcionBotones = 1;
            cbEscuelaMaterial.Enabled = false;
            cbTallerMaterial.Enabled = false;
            cbDinamicaMaterial.Enabled = false;
            txtIdMaterial.Enabled = false;
            txtNombreMaterial.Enabled = false;
            txtCostoMaterial.Enabled = false;

            btnAceptar.Enabled = true;

        }

        //BOTON ACEPTAR (CRUD)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cbEscuelaMaterial.Text != "" && txtIdEscuela.Text != "") && (cbTallerMaterial.Text != "" && txtIdTaller.Text != "") && (cbDinamicaMaterial.Text != "" && txtIdDinamica.Text != "") && (txtIdMaterial.Text != "") && (txtNombreMaterial.Text != "") && (txtCostoMaterial.Text != ""))
            {
                if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (opcionBotones == 0)
                    {

                        ClassMaterial ma = new ClassMaterial();
                        ma.ma_id_escuela = txtIdEscuela.Text;
                        ma.ma_id_taller = txtIdTaller.Text;
                        ma.ma_id_dinamica = txtIdDinamica.Text;
                        ma.ma_id_material = txtIdMaterial.Text;
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
                        ma.ma_id_material = txtIdMaterial.Text;
                        using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                        {
                            string mensaje = wsPHP.eliminarMaterial(ma.ma_id_material);
                            MessageBox.Show(mensaje, "¡Material Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                    {

                        try
                        {
                            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosMaterial(), typeof(DataTable));
                            dgvMaterial.DataSource = dt;
                           

                        }
                        catch
                        {
                            MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    cbEscuelaMaterial.Enabled = false; cbEscuelaMaterial.Text = "Seleccionar Escuela";
                    txtIdEscuela.Text = "";

                    cbTallerMaterial.Enabled = false; cbTallerMaterial.Text = "Seleccionar Taller";
                    txtIdTaller.Text = "";

                    cbDinamicaMaterial.Enabled = false; cbDinamicaMaterial.Text = "Seleccionar Dinamica";
                    txtIdDinamica.Text = "";

                    txtIdMaterial.Enabled = false; txtIdMaterial.Text = "";
                    txtNombreMaterial.Enabled = false; txtNombreMaterial.Text = "";
                    txtCostoMaterial.Enabled = false; txtCostoMaterial.Text = "";

                    btnAceptar.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Es necesario que llenes todos los campos", "¡ALERTA!");
            }
        }

        private void cbEscuelaMaterial_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ModuloMaterial_Load(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosMaterial(), typeof(DataTable));
                    dgvMaterial.DataSource = dt;

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

                    String respuestaTaller = wsPHP.cargarDatosDeTaller();
                    var respTall = JsonConvert.DeserializeObject<List<ClassTaller>>(respuestaTaller);



                    foreach (var nomTall in respTall)
                    {
                        ComboBoxItem item = new ComboBoxItem();

                        item.Text = nomTall.ta_nombre_taller;
                        item.Value = Convert.ToString(nomTall.ta_id_taller);
                        cbTallerMaterial.Items.Add(item);

                    }

                    //DINAMICA
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
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbTallerMaterial_SelectedIndexChanged(object sender, EventArgs e)
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
                String respuestaDin = wsPHP.buscarDinamicaXTallerYEscuela(txtIdTaller.Text,txtIdEscuela.Text);
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

        private void cbDinamicaMaterial_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbEscuelaMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdEscuela.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[0].Value.ToString());

            cbTallerMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtIdTaller.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[1].Value.ToString());

            cbDinamicaMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtIdDinamica.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[2].Value.ToString());

            txtIdMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtNombreMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtCostoMaterial.Text = Convert.ToString(dgvMaterial.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

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
                        
                    }
                    catch
                    {
                        MessageBox.Show("No se encuentra ningun material con estos datos, Por favor ingrese un nombre o ID Material correcto", "No existe este taller", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                }
            }
        }
    }
}
