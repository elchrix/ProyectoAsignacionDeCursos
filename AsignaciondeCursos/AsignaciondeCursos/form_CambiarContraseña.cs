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
    public partial class form_CambiarContraseña : Form
    {
        public form_CambiarContraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//boton cambair contraseña
        {
            String usuario = Usuario.UserName;

            DataTable dt = MantenimientosManejo.CargarGrid("select password from usuario where username = '"+usuario+"'");
            DataRow row = dt.Rows[0];
            String contraseña = row[0].ToString().Trim();
            if (txt_contraseña_actual.Text.Trim() == contraseña )
            {
                if(!String.IsNullOrEmpty(txt_contraseña_nueva.Text))
                {
                    if(txt_contraseña_nueva.Text == txt_rep_contra_nueva.Text)
                    {
                        MySqlConnection con = Conexion.ObtenerConexion();
                        String cuery = "update Usuario set password = '"+txt_contraseña_nueva.Text.Trim()+"' where username = '"+usuario+"'";

                        MySqlCommand comando = new MySqlCommand(cuery, con);

                        comando.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("contraseña cambiada con exito");
                    }
                    else { MessageBox.Show("contraseñas no coinciden"); }
                }else { MessageBox.Show("debe ingresar una contraseña nueva valida"); }

            }else { MessageBox.Show("contraseña erronea"); }

            
        }
    }
}
