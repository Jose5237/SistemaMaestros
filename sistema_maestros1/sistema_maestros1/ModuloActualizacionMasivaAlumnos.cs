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
    public partial class ModuloActualizacionMasivaAlumnos : Form
    {
        public ModuloActualizacionMasivaAlumnos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void ModuloActualizacionMasivaAlumnos_Load(object sender, EventArgs e)
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
                        cbEscuela.Items.Add(item);

                    }

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                String respuestaEscuela = wsPHP.cargarNombresEscuela(cbEscuela.Text);
                var respEsc = JsonConvert.DeserializeObject<List<ClassEscuela>>(respuestaEscuela);

                foreach (var nomEsc in respEsc)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Value = Convert.ToString(nomEsc.es_id_escuela);
                    string id = item.Value.ToString();
                    txtIdEscuela.Text = id;
                }
                DataTable dt = new DataTable();
                dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarAlumno(txtIdEscuela.Text), typeof(DataTable));
                dgvAlumnos.DataSource = dt;
            }
        }

        private void cbNivelEducativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                DataTable dt = new DataTable();
                dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.filtrarAlumnosXnivel(txtIdEscuela.Text, cbNivelEducativo.Text), typeof(DataTable));
                dgvAlumnos.DataSource = dt;

            }
            if (cbNivelEducativo.SelectedIndex == 0 || cbNivelEducativo.SelectedIndex == 2)
            {
                cbGrado.Items.Clear();
                cbGrado.Items.Add("1°");
                cbGrado.Items.Add("2°");
                cbGrado.Items.Add("3°");
                
            }
            else if (cbNivelEducativo.SelectedIndex == 1)
            {
                cbGrado.Items.Clear();
                cbGrado.Items.Add("1°");
                cbGrado.Items.Add("2°");
                cbGrado.Items.Add("3°");
                cbGrado.Items.Add("4°");
                cbGrado.Items.Add("5°");
                cbGrado.Items.Add("6°");
                
            }
            
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cargarDatosTabla()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {

                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAlumno(), typeof(DataTable));
                    dgvAlumnos.DataSource = dt;
                    //NombresColumnas();

                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
