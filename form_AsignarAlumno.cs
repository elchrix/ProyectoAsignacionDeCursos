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
    public partial class form_AsignarAlumno : Form
    {
        public form_AsignarAlumno()
        {
            InitializeComponent();
        }

     

        private void form_AsignarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void txt_carne_TextChanged(object sender, EventArgs e)
        {
           // try
          //  {
                String sCarrera = txt_carrera.Text.Trim();
                String sAño = txt_año.Text.Trim();
                String sCarne = txt_carne.Text.Trim();

                MySqlConnection con = Conexion.ObtenerConexion();

                //OBTENER NOMBRE, DIRECCION Y CORREO DEL ALUMNO:
                    DataTable dt = new DataTable();
                    string query = "select primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, direccion, correo_electronico" +
                        " from Alumno where id_carrera = '" + sCarrera + "' and año_ingreso = '" + sAño + "' and no_carne = '" + sCarne + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                try
                {
                    adaptador.Fill(dt);

                    DataRow fila1 = dt.Rows[0];
                    lbl_nombre.Text = fila1[0].ToString() +" "+ fila1[1].ToString() +" "+ fila1[2].ToString() +" "+ fila1[3].ToString();
                    lbl_direccion.Text = fila1[4].ToString();
                    lbl_correo.Text = fila1[5].ToString();

                    //OBTENER CARRERA Y FACULTAD DEL ALUMNO:

                    dt.Reset();
                    String query_carrera = "select nombre_carrera from Carrera where id_carrera = '"+sCarrera+"'";
                    MySqlCommand comando_carrera = new MySqlCommand(query_carrera, con);
                    MySqlDataAdapter adaptador_carrera = new MySqlDataAdapter(comando_carrera);
                    adaptador_carrera.Fill(dt);
                    fila1 = dt.Rows[0];
                    lbl_carrera.Text  = fila1[0].ToString();
                    
                    dt.Reset();
                    String query_facu_id = "select id_facultad from Carrera where id_carrera = '" + sCarrera + "'";
                    MySqlCommand comando_facu_id = new MySqlCommand(query_facu_id, con);
                    MySqlDataAdapter adaptador_facu_id = new MySqlDataAdapter(comando_facu_id);
                    adaptador_facu_id.Fill(dt);
                    fila1 = dt.Rows[0];
                    String facu_id = fila1[0].ToString();
                    dt.Reset();
                    String query_facu_nom = "select nombre_facultad from Facultad where id_facultad = '" + facu_id + "'";
                    MySqlCommand comando_facu_nom = new MySqlCommand(query_facu_nom, con);
                    MySqlDataAdapter adaptador_facu_nom = new MySqlDataAdapter(comando_facu_nom);
                    adaptador_facu_nom.Fill(dt);
                    fila1 = dt.Rows[0];
                    lbl_facultad.Text = fila1[0].ToString();
                }
                catch {}

                //OBTENER CURSOS DISPONIBLES PARA EL ALUMNO
                DataTable dt_CursosAprobados = AsignacionesManejo.ObtenerCursosAprobados(sCarrera, sAño, sCarne);
                DataTable dt_CursosDisponibles = AsignacionesManejo.ObtenerCursosDisponibles(dt_CursosAprobados);
               // dataGridView1.DataSource = dt_CursosDisponibles;



                con.Close();
           // }
           //// catch (System.Exception ex)
           // {
              //  MessageBox.Show(ex.Message);
          //  }
        }

        private void txt_carrera_MouseClick(object sender, MouseEventArgs e)
        {
            txt_carrera.Text = "";
            txt_año.Text = "";
            txt_carne.Text = "";
            lbl_nombre.Text = "";
            lbl_facultad.Text = "";
            lbl_direccion.Text = "";
            lbl_correo.Text = "";
            lbl_carrera.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
