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
    public partial class Modificar_carrera : Form
    {
        public Modificar_carrera()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                Mantenimiento_carrera fc = new Mantenimiento_carrera();

                string id_carrera = txt_carrera.Text;
                string id_facultad = cbo_id__facultad.SelectedItem.ToString();
                string ciclos = txt_ciclos.Text;
                string nombre_carrera = txt_nombre_carrera.Text;
                string cuery = "update carrera set ciclos = '" + ciclos + "', nombre_carrera = '" + nombre_carrera + "'where id_carrera ='" + id_carrera + "';";
              

               
                MySqlCommand comando = new MySqlCommand(cuery, con);


                MySqlDataReader dr;
                dr = comando.ExecuteReader();


                con.Close();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Mantenimiento_carrera mf = new Mantenimiento_carrera();
            mf.Show();
            this.Hide();

        }
    }
}

