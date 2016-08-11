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
    public partial class form_ModificarPensum : Form
    {
        public form_ModificarPensum()
        {
            InitializeComponent();
        }

        public String nombre_car;
        public String año;
        public String carrera;
        private void form_ModificarPensum_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd;
            DataTable dt = new DataTable();

            cmd = new MySqlCommand("Select nombre_carrera from carrera", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            adaptador.Fill(dt);

            cbo_idcarrera.DataSource = dt;
            cbo_idcarrera.DisplayMember = "nombre_carrera";
            
            //cb.SelectedIndex = 0;
            cbo_idcarrera.Text = nombre_car;
            con.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                //Mantenimiento_pensum fc = new Mantenimiento_pensum();

                string año_pensum = txt_anio.Text.Trim();
                
                String cuery = " UPDATE pensum set anio_pensum = '" + año_pensum + "'where anio_pensum = '" + año + "' and  id_carrera = '"+carrera+"';";

                MySqlCommand comando = new MySqlCommand(cuery, con);

                comando.ExecuteNonQuery();
                //MySqlDataReader dr;
                //dr = comando.ExecuteReader();
                MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Pensum" + cbo_idcarrera.SelectedValue.ToString().Trim() + txt_anio.Text.Trim());
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
