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
using MySql.Data;
namespace catedratico
{
    public partial class form_historial : Form
    {
        public form_historial()
        {
            InitializeComponent();
        }

        private void form_historial_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string query = "SELECT DISTINCT cc.anio from catedratico_curso cc, catedratico c WHERE c.usuario = '"+Usuario.UserName+"' ORDER BY cc.anio desc;";
//            string query2 = "SELECT DISTINCT cc.semestre from catedratico_curso cc, catedratico c WHERE c.usuario = '" + Usuario.UserName + "' ORDER BY cc.semestre desc;";
            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());
  //          MySqlCommand cmd2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //        MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da.Fill(dt);
            comboBox1.DisplayMember = "anio";
            comboBox1.ValueMember = "anio";
      //      comboBox2.DisplayMember = "semestre";
        //    comboBox2.ValueMember = "semestre";
          //  comboBox2.DataSource = dt2;
            comboBox1.DataSource = dt;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT cc.id_carrera, cc.codigo_curso, cc.id_jornada, cc.seccion,cc.id_edificio,cc.no_salon, cc.hora FROM catedratico_curso cc, catedratico c  WHERE (anio='"+comboBox1.Text+ "')AND (c.usuario ='" + Usuario.UserName + "')AND(semestre='" + comboBox2.Text + "')", Conexion.ObtenerConexion());
                //MySqlCommand cmd = new MySqlCommand("SELECT * FROM Alumno", Conexion.ObtenerConexion());
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
