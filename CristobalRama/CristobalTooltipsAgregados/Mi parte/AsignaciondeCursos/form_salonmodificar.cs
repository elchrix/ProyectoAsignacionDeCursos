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
    public partial class form_salonmodificar : Form
    {
        public form_salonmodificar()
        {
            InitializeComponent();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //se abre conexion y se modifica la base de datos con los datos nuevos ingresados
                MySqlConnection con = Conexion.ObtenerConexion();
                form_salon s = new form_salon();
                string no_salon = txt_no_salon.Text.Trim();
                string ID_edificio = cbo_edificio.SelectedItem.ToString();
                string tamanio = txt_tamanio.Text.Trim();
                string capacidad =txt_cantaprox.Text.Trim();
                string estatus = cbo_estatus.SelectedItem.ToString();
                

                //string quey = "update asignacionprueba.salon set id_edificio='"+this.cbo_edificio.SelectedItem.ToString()+"',tamaño='"+this.txt_tamanio.Text+"',capacidad_aprox='"+this.txt_cantaprox.Text+"',estatus='"+this.cbo_estatus.SelectedItem.ToString()+"' where no_salon='"+no_salon+"';";
                MySqlCommand comando = new MySqlCommand("update asignacionprueba.salon set id_edificio='" + ID_edificio + "',tamaño='" + tamanio + "',capacidad_aprox='" + capacidad + "',estatus='" + estatus + "' where no_salon='" + no_salon + "';", con);
               
              
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Actualizacion Exitosa");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form_salonmodificar_Load(object sender, EventArgs e)
        {
            cbo_estatus.SelectedIndex = 0;
        }
    }
}
