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
    public partial class modificar_pensum : Form
    {
        public modificar_pensum()
        {
            InitializeComponent();
        }

        private void Btn_ingresarpensum_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection con = Conexion.ObtenerConexion();

                     
                    string id_carrera = cbo_idcarrera.SelectedItem.ToString();
                    string anio_pensum = txt_anio.Text;

                 

                    String cuery = "delete from carrera where id_carrera = id_carrera ";

                    MySqlCommand comando = new MySqlCommand(cuery, con);
                    MySqlParameter[] nuevoreg = new MySqlParameter[9];   
                    nuevoreg[0] = comando.Parameters.Add("id Carrera", MySqlDbType.VarChar,10,id_carrera);
                    nuevoreg[1] = comando.Parameters.Add("año Pensum", MySqlDbType.VarChar, 10, anio_pensum);
                    

                    comando.ExecuteNonQuery();
                    
                    con.Close();
                    MessageBox.Show("hola");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
