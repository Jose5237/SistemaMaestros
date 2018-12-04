﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using variablesGlobales;

namespace sistema_maestros1
{
    public partial class tutor_has_alumno : Form
    {
        public tutor_has_alumno()
        {
            InitializeComponent();
            AgregarDGVtutor();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar ventana?", "¡Cerrar ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Globales.nombre_alumno = "";
                Globales.id_alumno="";
                Globales.id_escuela="";
                this.Hide();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(dgvAhT.Rows.Count != 0)
            {
                if (MessageBox.Show("¿Esta seguro de la asignacion de padres/tutores con el alumno?", "Padres/Tutores a Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                    {


                        for (int i = 0; i <= dgvAhT.RowCount - 1; i++)
                        {
                            //ClassAlumnoHasTutor aht = new ClassAlumnoHasTutor();
                            //aht.al_id_alumno = txtIdAlumno.Text;
                            //aht.es_id_escuela = txtIdEscuela.Text;
                            //aht.al_id_tutor = dgvAhT.
                            wsPHP.agregarAlumnoTutor(txtIdAlumno.Text, txtIdEscuela.Text, dgvAhT.Rows[i].Cells[2].Value.ToString());
                            

                        }
                        MessageBox.Show("Se ha agregado correctamente la relacion Alumno -> Tutor", "¡Tutor has Alumno Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAhasT(), typeof(DataTable));
                        dgvAhasTAll.DataSource = dt;
                        NombresColumnasAhT();

                    }
                }
            } else
            {
                MessageBox.Show("¡ERROR! No se ha insertado ningun padre o tutor a este alumno", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void AgregarDGVtutor()
        {
            
            this.Controls.Add(dgvAhT);

            DataGridViewTextBoxColumn columnas1 = new DataGridViewTextBoxColumn();
            columnas1.HeaderText = "ID Alumno";

            DataGridViewTextBoxColumn columnas2 = new DataGridViewTextBoxColumn();
            columnas2.HeaderText = "Alumno";

            DataGridViewTextBoxColumn columnas3 = new DataGridViewTextBoxColumn();
            columnas3.HeaderText = "ID Tutor";

            DataGridViewTextBoxColumn columnas4 = new DataGridViewTextBoxColumn();
            columnas4.HeaderText = "Padre o Tutor";

            DataGridViewTextBoxColumn columnas5 = new DataGridViewTextBoxColumn();
            columnas5.HeaderText = "Parentesco";


            dgvAhT.Columns.Add(columnas1);
            dgvAhT.Columns.Add(columnas2);
            dgvAhT.Columns.Add(columnas3);
            dgvAhT.Columns.Add(columnas4);
            dgvAhT.Columns.Add(columnas5);
        }

        private void tutor_has_alumno_Load(object sender, EventArgs e)
        {
            txtNombreAlumno.Text = Globales.nombre_alumno;
            txtIdAlumno.Text = Globales.id_alumno;
            txtIdEscuela.Text = Globales.id_escuela;

            cargarDatosTablaPadres();

            
        }

        private void txtBuscadorPadre_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscadorPadre.Text != "")
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {

                    DataTable dt = new DataTable();
                    try
                    {
                        dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.buscarTutor(txtBuscadorPadre.Text), typeof(DataTable));
                        dgvTutor.DataSource = dt;
                        NombresColumnasPadres();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se encuentra ningun Padre/Tutor con estos datos, Por favor ingrese un nombre o ID Padre correcto", "No existe este tutor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cargarDatosTablaPadres();
                    }


                }
            }
            else
            {
                cargarDatosTablaPadres();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            dgvAhT.Rows.Add(Globales.id_alumno,Globales.nombre_alumno, dgvTutor.CurrentRow.Cells[0].Value.ToString(),dgvTutor.CurrentRow.Cells[1].Value.ToString(), dgvTutor.CurrentRow.Cells[5].Value.ToString());
        }

        private void dgvAhT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            int fila = dgvAhT.CurrentRow.Index;

            dgvAhT.Rows.RemoveAt(fila);
        }

        private void dgvAhasTAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtEscuela2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIDEscuela2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtAlumno2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtIDAlumno2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtPadre2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtIDPadre2.Text = Convert.ToString(dgvAhasTAll.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClassAlumnoHasTutor aht = new ClassAlumnoHasTutor();
            aht.es_id_escuela = txtIDEscuela2.Text;
            aht.al_id_alumno = txtIDAlumno2.Text;
            aht.al_id_tutor = txtIDPadre2.Text;

            if (MessageBox.Show("¿Estas seguro de realizar esta accion?", "¿Seguro de hacer estos cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
                {
                    try
                    {
                        string mensaje = wsPHP.eliminarAlumnoTutor(aht.al_id_alumno, aht.al_id_tutor);
                        MessageBox.Show(mensaje, "¡Relacion Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error, no se ha podido eliminar este usuario", "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cargarDatosTablaAhT();
                inicializarTextBox();
            }
        }


        public void inicializarTextBox()
        {
            txtIDEscuela2.Text = "";
            txtEscuela2.Text = "";
            txtIDAlumno2.Text = "";
            txtAlumno2.Text = "";
            txtIDPadre2.Text = "";
            txtPadre2.Text = "";
        }

        public void cargarDatosTablaPadres()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosTutor(), typeof(DataTable));
                    dgvTutor.DataSource = dt;

                    NombresColumnasPadres();

                    DataTable dt1 = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAhasT(), typeof(DataTable));
                    dgvAhasTAll.DataSource = dt1;
                    NombresColumnasAhT();



                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NombresColumnasPadres()
        {
            dgvTutor.Columns[0].Visible = false;
            dgvTutor.Columns[1].HeaderText = "Nombre(s)";
            dgvTutor.Columns[2].HeaderText = "Apellido Paterno";
            dgvTutor.Columns[3].HeaderText = "Apellido Materno";
            dgvTutor.Columns[4].Visible = false;
            dgvTutor.Columns[5].HeaderText = "Parentesco";
            dgvTutor.Columns[6].Visible = false;
        }

        public void cargarDatosTablaAhT()
        {
            using (webservices3435.WSPHP wsPHP = new webservices3435.WSPHP())
            {
                try
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsPHP.cargarDatosAhasT(), typeof(DataTable));
                    dgvAhasTAll.DataSource = dt;

                    NombresColumnasAhT();
                    
                }
                catch
                {
                    MessageBox.Show("Error en cargar los datos", "¡Error en los Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NombresColumnasAhT()
        {
            dgvAhasTAll.Columns[0].HeaderText = "Escuela";
            dgvAhasTAll.Columns[1].Visible = false;
            dgvAhasTAll.Columns[2].HeaderText = "Nombre del Alumno";
            dgvAhasTAll.Columns[3].Visible = false;
            dgvAhasTAll.Columns[4].HeaderText = "Padre o Tutor";
            dgvAhasTAll.Columns[5].Visible = false;
        }

        private void dgvTutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
