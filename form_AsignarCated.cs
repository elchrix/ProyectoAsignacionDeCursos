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
    public partial class form_AsignarCated : Form
    {
        public form_AsignarCated()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            if(con != null)
              {
                MessageBox.Show("conexion exitosa");
            }
            else { MessageBox.Show("conexion fallida"); }


            con.Close();
        }

        private void form_AsignarCated_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string query = "select * from Alumno";
            MySqlCommand cmd = new MySqlCommand (query, Conexion.ObtenerConexion());
            MySqlDataAdapter adap = new MySqlDataAdapter (cmd);
            adap.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
