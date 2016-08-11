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

namespace catedratico
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txt_contraseña.PasswordChar = '*';
        }
        public void login()
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                string sQuery = "select * from Usuario where username = '" + txt_usuario.Text.Trim() + "'";
                DataTable dt = new DataTable();
                MySqlCommand comando = new MySqlCommand(sQuery, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    DataRow fila = dt.Rows[0];
                    String sUsuario = fila[0].ToString();
                    String sContra = fila[2].ToString();
                    String sTipo = fila[1].ToString();



                    if (sTipo == "catedratico")
                    {
                        if (txt_contraseña.Text.Trim() == sContra.Trim())
                        {
                            this.Hide();
                            Usuario.UserName = sUsuario.Trim();
                            //MessageBox.Show("lolxD");
                            form_cat fc = new form_cat();
                            fc.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("contraseña incorrecta");
                        }
                    }





                    if (sTipo == "catedratico")
                    {

                        if (txt_contraseña.Text.Trim() == sContra.Trim())
                        {
                            MessageBox.Show("usted tiene acceso al apartado de catedraticos");
                        }
                        else
                        {
                            MessageBox.Show("contraseña incorrecta");
                        }

                    }



                }
                else { MessageBox.Show("Usuario inexistente"); }
                con.Close();
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void btn_logear_Click(object sender, EventArgs e) //BOTON DE LOGEO
        {
            login();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                login();
            }
        }
    }
}
