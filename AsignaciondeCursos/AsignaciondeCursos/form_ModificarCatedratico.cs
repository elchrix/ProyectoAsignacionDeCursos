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
    public partial class form_ModificarCatedratico : Form
    {
        public form_ModificarCatedratico()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                dtp_fechaNacCto.Format = DateTimePickerFormat.Custom;
                dtp_fechaNacCto.CustomFormat = "yyyy-MM-dd";
                MySqlCommand comando = new MySqlCommand(" update catedratico set primer_nombre = '" + txt_nombre1Cto.Text + "' ,segundo_nombre = '" + txt_nombre2Cto.Text + "' ,primer_apellido = '" + txt_apellido1Cto.Text + "',segundo_apellido = '" + txt_apellido2Cto.Text + "' ,direccion = '" + txt_direccionCto.Text + "' ,correo_electronico = '" + txt_correoCto.Text + "' ,fecha_nac = '" + dtp_fechaNacCto.Text + "' where id_catedratico = '" + txt_idCto1.Text + "'", con);
                comando.ExecuteNonQuery();

                //form_MantenimientoCatedratico f = new form_MantenimientoCatedratico();
                //DataTable dt = MantenimientosManejo.CargarGrid("select * from catedratico");
                //f.dgv_catedraticos.DataSource = dt;
                MessageBox.Show("actualizado con exito");
                //cn.mostrar();
                MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Catedratico " + txt_nombre1Cto.Text.Trim() +" - "+ txt_nombre2Cto.Text.Trim() +" - "+ txt_apellido1Cto.Text.Trim() +" - "+ txt_apellido2Cto.Text.Trim() +" - "+ txt_direccionCto.Text.Trim() +" - "+ txt_correoCto.Text.Trim() +" - "+ dtp_fechaNacCto.Text.Trim());

                con.Close();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form_ModificarCatedratico_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
