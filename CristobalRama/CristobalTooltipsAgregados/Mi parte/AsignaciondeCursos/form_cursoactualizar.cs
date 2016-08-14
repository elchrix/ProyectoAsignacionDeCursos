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
    public partial class form_cursoactualizar : Form
    {
        public form_cursoactualizar()
        {
            InitializeComponent();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();


                form_IngresoCurso c = new form_IngresoCurso();

                string codigo = cbo_cod_carrera.SelectedItem.ToString();
                string sabado = txt_numero_sabado.Text.Trim();
                string num = txt_numero.Text.Trim();
                string ciclo = txt_numero_ciclos.Text.Trim();
                string credito = txt_no_creditos.Text.Trim();
                string necesario = txt_creditos_necesarios.Text.Trim();
                string lab = cbo_laboratorio.SelectedItem.ToString();
                string pre = txt_prerrequisitos.Text.Trim();
                string nom = txt_nombre_curso.Text.Trim();

                //string quey = "update curso set numero_sab= '" +sabado+ "',numero='"+num+"',no_ciclo='"+ciclo+"',no_creditos='"+credito+"',laboratorio='"+lab+"',prerrequisitos='"+pre+"',nombre_curso='"+nom+"' where codigo_curso = '" +codigo+"';";
                //MySqlCommand comando = new MySqlCommand(quey, con);
                //MySqlDataReader dr;
                //dr = comando.ExecuteReader();
                MySqlCommand comando = new MySqlCommand("update curso set numero_sab= '" + sabado + "',numero='" + num + "',no_ciclo='" + ciclo + "',no_creditos='" + credito + "',laboratorio='" + lab + "',prerrequisitos='" + pre + "',nombre_curso='" + nom + "' where codigo_curso = '" +codigo+ "'", con);
                comando.ExecuteNonQuery();    
                con.Close();
                MessageBox.Show("Actualizacion Exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form_cursoactualizar_Load(object sender, EventArgs e)
        {
            cbo_laboratorio.SelectedIndex = 0;
        }
    }
}
