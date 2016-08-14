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
namespace AsignaciondeCursos
{
    public partial class form_historial : Form
    {
        public form_historial()
        {
            InitializeComponent();
        }

        private void form_historial_Load(object sender, EventArgs e)
        {
           /* 
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Catedratico_curso WHERE anio='"+comboBox1.SelectedText+"' AND semestre='"+comboBox2.SelectedText+"'",Conexion.ObtenerConexion());
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Catedratico_curso WHERE anio='" + comboBox1.Text + "' AND semestre='" + comboBox2.Text + "'", Conexion.ObtenerConexion());
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
    }
}
