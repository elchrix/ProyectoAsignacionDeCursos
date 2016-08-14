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
    public partial class form_IngresarEstudiante : Form
    {
        public form_IngresarEstudiante()
        {
            InitializeComponent();
        }

        private void form_IngresarEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable nuevo = new DataTable();
                string query = "select * from alumno";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter dats = new MySqlDataAdapter(cmd);
                dats.Fill(nuevo);
                dgv_alumno.DataSource = nuevo;
                dgv_alumno.Columns[0].HeaderText = "codCarne";
                dgv_alumno.Columns[1].HeaderText = "año";
                dgv_alumno.Columns[2].HeaderText = "carne";
                dgv_alumno.Columns[3].HeaderText = "primerNombre";
                dgv_alumno.Columns[4].HeaderText = "segundoNombre";
                dgv_alumno.Columns[5].HeaderText = "primerApellido";
                dgv_alumno.Columns[6].HeaderText = "segundoApellido";
                dgv_alumno.Columns[7].HeaderText = "correo";
                dgv_alumno.Columns[8].HeaderText = "direccion";
                dgv_alumno.Columns[9].HeaderText = "fechaNacimiento";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
