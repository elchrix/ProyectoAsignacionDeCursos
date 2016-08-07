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
    public partial class Modificar_facultaad : Form
    {
        public Modificar_facultaad()
        {
            InitializeComponent();
        }

        private void Btn_ingresarfacultad_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                Mantenimiento_pensum fc = new Mantenimiento_pensum();

                string id_facultad = txt_idfacultad.Text.Trim();
                string nombre_carrera = txt_nombrefacultad.Text.Trim();

                
                String cuery = " UPDATE facultad set nombre_facultad = '" + this.txt_nombrefacultad.Text+ "'where id_facultad = '" + this.txt_idfacultad.Text + "';";
         
                MySqlCommand comando = new MySqlCommand(cuery, con);


                MySqlDataReader dr;
                dr = comando.ExecuteReader();


                con.Close();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Mantenimiento_facultad mf = new Mantenimiento_facultad();
            mf.Show();
            this.Hide();

        }
    }
}




                



