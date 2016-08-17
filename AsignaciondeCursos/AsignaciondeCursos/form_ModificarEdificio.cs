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
    public partial class form_ModificarEdificio : Form
    {
        public form_ModificarEdificio()
        {
            InitializeComponent();
        }

        private void Btn_modificaredificio_Click(object sender, EventArgs e)
        {
            try
            {
                //se abre conexion y se modifica la base de datos con los datos nuevos ingresados
                MySqlConnection con = Conexion.ObtenerConexion();

                string ID_edicio = txt_idedificio.Text.Trim();
                string NO_piso =  txt_pisos.Text.Trim();
                string TAmanio = txt_tamanio.Text.Trim();
                string CAn_salon = txt_cantsalones.Text.Trim();

                string quey = "update edificio set no_pisos =  '"+ NO_piso + "', tamaño = '" + TAmanio + "',cant_salones= '" + CAn_salon + "' where id_edificio = '" + ID_edicio + "';";
                MySqlCommand comando = new MySqlCommand(quey, con);
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                con.Close();
                MessageBox.Show("Actualizacion Exitosa");
                MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Edificio " + txt_idedificio.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
