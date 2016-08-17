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
using MySql.Data;
/* 
 * AUTOR: 901-12-4330 YONY CALITO
 * VERSION: 2.3
 * CREACION COD: 10/08/2016
 * UD:14/08/2016
 */

namespace AsignaciondeCursos
{
    public partial class form_cursosact : Form
    {
        public string[] curso;
        public string scurso;
        public string scurso1;

        public form_cursosact()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void form_cursosact_Load(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.Now;
            txt_anio.Text = Convert.ToString(date1.Year);
            txt_semestre.Text = Convert.ToString(date1.Month);
            if(date1.Month >= 7)
            {
                txt_semestre.Text = "2";
            }
            else
            {
                txt_semestre.Text = "1";
            }
            
            try
            {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string query = "SELECT CONCAT(cc.id_carrera,'-',cc.codigo_curso,'-',cc.anio,cc.semestre,cc.seccion,cc.id_jornada,'----',cr.nombre_curso) as CUA FROM catedratico_curso cc INNER JOIN catedratico c ON cc.id_catedratico = c.id_catedratico INNER JOIN curso cr ON cc.codigo_curso = cr.codigo_curso WHERE((cc.id_catedratico = '" +Usuario.Cate_id+"')and(cc.anio='"+txt_anio.Text.Trim()+"')and(cc.semestre='"+txt_semestre.Text.Trim()+"'));";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            comboBox1.DisplayMember = "CUA";
            comboBox1.ValueMember = "CUA";
            comboBox1.DataSource = dt;
            con.Close();
            }

            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            scurso = comboBox1.Text;
            curso = scurso.Split('-');
            scurso1 = curso[1];



            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                string query = "SELECT DISTINCT CONCAT(ca.id_carrera,ca.codigo_curso, ca.anio, ca.semestre, ca.seccion, ca.id_jornada) AS CUA, CONCAT(a.id_carrera, '-', a.anio_ingreso, '-', a.no_carne)AS CARNE, CONCAT(a.primer_nombre, ' ', a.segundo_nombre, ' ', a.primer_apellido, ' ', a.segundo_apellido) AS Nombre_Completo FROM cursos_recibidos as ca INNER JOIN alumno a ON ((ca.id_carrera=a.id_carrera)and(ca.anio_ingreso=a.anio_ingreso)and(ca.no_carne=a.no_carne)) INNER JOIN catedratico_curso cc ON((ca.id_carrera = cc.id_carrera)AND(ca.codigo_curso = cc.codigo_curso)AND(ca.anio = cc.anio)AND(ca.semestre = cc.semestre)and(ca.seccion = cc.seccion)and(ca.id_jornada = cc.id_jornada)) INNER JOIN curso cr ON ca.codigo_curso = cr.codigo_curso WHERE((ca.anio='"+txt_anio.Text.Trim()+"')and(ca.semestre='"+txt_semestre.Text.Trim()+"')and ca.codigo_curso ='" + scurso1 + "');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            scurso = "";
        }
        public void leer_datos()
        {
            string[] carne;
            string scarne;
            string scarrera;
            string sanio_ingreso;
            string sno_carne;
            int cont = (dataGridView1.Rows.Count);
            int bandera = 1;




            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (bandera < cont)
                {
                    if (Convert.ToBoolean(fila.Cells["aprobado"].Value))
                    {
                        scarne = fila.Cells["CARNE"].Value.ToString();
                        carne = scarne.Split('-');
                        scarrera = carne[0];
                        sanio_ingreso = carne[1];
                        sno_carne = carne[2];

                        try
                        {
                            MySqlConnection con = Conexion.ObtenerConexion();
                            string query = "UPDATE cursos_recibidos SET nota='aprobado' WHERE ((id_carrera='" + scarrera + "')AND(anio_ingreso='" + sanio_ingreso + "')AND(no_carne='" + sno_carne + "')AND(codigo_curso='" + scurso1 + "'))";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Carne:" + scarrera + sanio_ingreso + sno_carne + "     Nota almacenada con exito");
                            con.Close();
                            scarrera = "\0";
                            sanio_ingreso = "\0";
                            sno_carne = "\0";
                            bandera = bandera + 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        try
                        {
                            scarne = fila.Cells["CARNE"].Value.ToString();
                            carne = scarne.Split('-');
                            scarrera = carne[0];
                            sanio_ingreso = carne[1];
                            sno_carne = carne[2];
                            MySqlConnection con = Conexion.ObtenerConexion();
                            string query = "UPDATE cursos_recibidos SET nota='noaprobado' WHERE ((id_carrera='" + scarrera + "')AND(anio_ingreso='" + sanio_ingreso + "')AND(no_carne='" + sno_carne + "')AND(codigo_curso='" + scurso1 + "'))";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Carne:" + scarrera + sanio_ingreso + sno_carne + "     Nota almacenada con exito");
                            con.Close();
                            scarrera = "\0";
                            sanio_ingreso = "\0";
                            sno_carne = "\0";
                            bandera = bandera + 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                else
                {
                    break;
                }
            }
        }
    private void btn_guardarn_Click(object sender, EventArgs e)
    {
            leer_datos();
            dataGridView1.Enabled = false;
            MessageBox.Show("Notas almacenadas con exito");
    }
  
    private void btn_editarnotas_Click(object sender, EventArgs e)
    {
            form_comprobacion ncomp = new form_comprobacion();
            this.Enabled = false;
            ncomp.ShowDialog();   
    }

    }
}