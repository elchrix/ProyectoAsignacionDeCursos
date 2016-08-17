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
    public partial class form_modificar_facultad : Form
    {
        public form_modificar_facultad()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                //Mantenimiento_pensum fc = new Mantenimiento_pensum();

                string id_facultad = txt_idfacultad.Text.Trim();
                string nombre_carrera = txt_nombrefacultad.Text.Trim();


                String cuery = " UPDATE facultad set nombre_facultad = '" + txt_nombrefacultad.Text + "'where id_facultad = '" +txt_idfacultad.Text + "';";

                MySqlCommand comando = new MySqlCommand(cuery, con);

                comando.ExecuteNonQuery();
                //MySqlDataReader dr;
                //dr = comando.ExecuteReader();
                MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Facultad " + txt_nombrefacultad.Text.Trim());
                MessageBox.Show("Modificacion exitosa");
               
                con.Close();
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
