using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class form_PensumCarrera : Form
    {
        public form_PensumCarrera()
        {
            InitializeComponent();
        }

        String id_facultad;
        String id_carrera;
        String id_pensum;

        private void btn_conexion_Click(object sender, EventArgs e)
        {
            Conexion conec = new Conexion();
            MessageBox.Show("Exito!");
        }

        private void form_PensumCarrera_Load(object sender, EventArgs e)
        {// CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE FACULTAD
            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Facultad",conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            adap.Fill(cargadt);
            cbo_facultad.DataSource = cargadt;
            cbo_facultad.DisplayMember = "nombre_facultad";
            cbo_facultad.ValueMember = "id_facultad";

        }

        private void cbo_facultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE CARRERA
            cbo_facultad.DisplayMember = "nombre_facultad";
            cbo_facultad.ValueMember = "id_facultad";

            id_facultad = cbo_facultad.SelectedValue.ToString().Trim();

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Carrera where id_facultad ="+ id_facultad,conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(cargadt);

            cbo_carrera.DataSource = cargadt;
            cbo_carrera.DisplayMember = "nombre_carrera";
            cbo_carrera.ValueMember = "id_carrera";




        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_carrera.DisplayMember = "nombre_carrera";
            cbo_carrera.ValueMember = "id_carrera";

            id_carrera = cbo_carrera.SelectedValue.ToString().Trim();

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Pensum where id_carrera="+ id_carrera,conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            adap.Fill(dt);
            //dgv_pensum.DataSource = dt;
            cbo_pensum.DataSource = dt;
            cbo_pensum.DisplayMember = "anio_pensum";
            cbo_pensum.ValueMember = "id_pensum";
            
        }

        private void cbo_pensum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_pensum.DisplayMember = "anio_pensum";
            cbo_pensum.ValueMember = "id_pensum";

            id_pensum = cbo_pensum.SelectedValue.ToString().Trim();
            id_carrera = cbo_carrera.SelectedValue.ToString().Trim();


            MySqlConnection conn = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Curso where id_carrera="+id_carrera ,conn);
            MySqlDataAdapter adapp = new MySqlDataAdapter(cmd);

            adapp.Fill(dt);
            dgv_pensum.DataSource = dt;
            //dgv_pensum.Columns[0].HeaderText = "Curso";*/
        }
    }
}
