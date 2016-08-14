using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //libreria de mysql 

namespace AsignaciondeCursos
{
    public partial class form_ModificarCarrera : Form
    {
        public form_ModificarCarrera()
        {
            InitializeComponent();
        }

        public  String nombre_facu;

        private void form_ModificarCarrera_Load(object sender, EventArgs e)
        {
            //llamando a la clase para llenar el combo Box
            MantenimientosManejo man = new MantenimientosManejo();
            man.llenar_id_facultad(cbo_id__facultad);

            cbo_id__facultad.Text = nombre_facu;
        }

        //boton modificar

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // llamando a la clase ObtenerConexion
                MySqlConnection con = Conexion.ObtenerConexion();

                
                //declarandole variables a los text box
                string id_carrera = txt_carrera.Text;
                string id_facultad = cbo_id__facultad.SelectedValue.ToString();
                string ciclos = cbo_ciclos.Text;
                string nombre_carrera = txt_nombre_carrera.Text;

                // query para actualizar campos
                string cuery = "update carrera set ciclos = '" + ciclos + "', nombre_carrera = '" + nombre_carrera + "' where id_carrera ='" + id_carrera + "';";



                MySqlCommand comando = new MySqlCommand(cuery, con);

                comando.ExecuteNonQuery();
                MessageBox.Show("Modificación exitosa");
                MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Carrera" + txt_carrera.Text.Trim() + cbo_id__facultad.SelectedValue.ToString().Trim());
                
                //cerrando conexion
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
