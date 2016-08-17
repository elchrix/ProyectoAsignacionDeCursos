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
/* 
 * AUTOR: 901-12-4330 YONY CALITO
 * VERSION: 2.3
 * CREACION COD: 10/08/2016
 * UD:14/08/2016
 */
namespace AsignaciondeCursos
{
    public partial class form_historial : Form
    {
        MySqlConnection con = Conexion.ObtenerConexion();
        public form_historial()
        {
            InitializeComponent();
        }

        private void form_historial_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                string query = "SELECT DISTINCT cc.anio from catedratico_curso cc, catedratico c WHERE cc.id_catedratico = '" + Usuario.Cate_id + "' ORDER BY cc.anio desc;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                comboBox1.DisplayMember = "anio";
                comboBox1.ValueMember = "anio";
                comboBox1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                //MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT cc.id_carrera, cc.codigo_curso, cc.id_jornada, cc.seccion,cc.id_edificio,cc.no_salon, h.horario FROM catedratico_curso cc, catedratico c, horario h  WHERE (cc.anio='"+comboBox1.Text+ "')AND (cc.id_catedratico='" + Usuario.Cate_id + "')AND(cc.semestre='" + comboBox2.Text + "')",con);
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT cc.id_carrera, cc.codigo_curso, cc.id_jornada, cc.seccion,cc.id_edificio,cc.no_salon, h.horario FROM catedratico_curso cc INNER JOIN catedratico c ON cc.id_catedratico = c.id_catedratico INNER JOIN horario h ON cc.hora=h.hora  WHERE (cc.anio='" + comboBox1.Text + "')AND (cc.id_catedratico='" + Usuario.Cate_id + "')AND(cc.semestre='" + comboBox2.Text + "')", con);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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
