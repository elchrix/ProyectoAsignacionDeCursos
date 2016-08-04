using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    class Conexion
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection cnn;
        public static MySqlConnection ObtenerConexion()
        {
             MySqlConnection con = new MySqlConnection("server=127.0.0.1; database= asignacionprueba; Uid=root; pwd=1234;");
            //MySqlConnection con = new MySqlConnection("server=sql3.freemysqlhosting.net; database=sql3128925; Uid=sql3128925; pwd=qBkpBh3Dce;");
            con.Open();
            return con;
        }
        public Conexion()
        {
            try
            {
                cnn = new MySqlConnection("server=127.0.0.1; database= asignacionprueba; Uid=root; pwd=1234;");
                cnn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarId_Carrera(ComboBox cb)
        {
            try
            {
                cmd = new MySqlCommand("select id_carrera from carrera", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["id_carrera"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}












