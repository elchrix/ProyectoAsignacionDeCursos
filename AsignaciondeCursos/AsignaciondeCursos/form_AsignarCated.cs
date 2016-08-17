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
    public partial class form_AsignarCated : Form
    {
        public form_AsignarCated()
        {
            InitializeComponent();
        }

     

        private void form_AsignarCated_Load(object sender, EventArgs e)
        {
            cbo_semestre.SelectedIndex = 0;
            cbo_año.SelectedIndex = 0;

            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = MantenimientosManejo.CargarGrid("Select id_carrera, nombre_carrera from Carrera");

            cbo_carrera.DataSource = dt;
            cbo_carrera.DisplayMember = "nombre_carrera";
            cbo_carrera.ValueMember = "id_carrera";

            con.Close();
        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sCarrera = cbo_carrera.SelectedValue.ToString().Trim();

            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = MantenimientosManejo.CargarGrid("select anio_pensum from Pensum where id_carrera = '" + sCarrera + "'");

            cbo_pensum.DataSource = dt;
            cbo_pensum.DisplayMember = "anio_pensum";
            cbo_pensum.ValueMember = "anio_pensum";

            con.Close();
        }

        private void cbo_pensum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgv_cursos.Rows.Clear();
            String sCarrera = cbo_carrera.SelectedValue.ToString().Trim();
            String sPensum = cbo_pensum.SelectedValue.ToString().Trim();

            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
            {
                dt = MantenimientosManejo.CargarGrid("select id_carrera, codigo_curso, nombre_curso, no_ciclo, anio_pensum from Curso where id_carrera = '"+sCarrera+"' and anio_pensum='"+sPensum+ "'and no_ciclo = '1' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '3' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '5' or id_carrera = '" + sCarrera + "'and anio_pensum ='" + sPensum + "'and no_ciclo = '7' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "' and no_ciclo = '9'");
                
                dgv_cursos.DataSource = dt;
            }
            else
            {
                dt = MantenimientosManejo.CargarGrid("select id_carrera, codigo_curso, nombre_curso, no_ciclo, anio_pensum from Curso where id_carrera = '" + sCarrera + "' and anio_pensum='" + sPensum + "'and no_ciclo = '2' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '4' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '6' or id_carrera = '" + sCarrera + "'and anio_pensum ='" + sPensum + "'and no_ciclo = '8' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "' and no_ciclo = '10'");

                dgv_cursos.DataSource = dt;
            }

            dgv_cursos.Columns[0].HeaderText = "ID Carrera";
            dgv_cursos.Columns[1].HeaderText = "Codigo de curso";
            dgv_cursos.Columns[2].HeaderText = "Nombre de curso";
            dgv_cursos.Columns[3].HeaderText = "ciclo";
            dgv_cursos.Columns[4].HeaderText = "año de pensum";
            con.Close();
        }

        private void cbo_semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_pensum.SelectedIndex != -1)
            {
                String sCarrera = cbo_carrera.SelectedValue.ToString().Trim();
                String sPensum = cbo_pensum.SelectedValue.ToString().Trim();

                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                {
                    dt = MantenimientosManejo.CargarGrid("select id_carrera, codigo_curso, nombre_curso, no_ciclo, anio_pensum from Curso where id_carrera = '" + sCarrera + "' and anio_pensum='" + sPensum + "'and no_ciclo = '1' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '3' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '5' or id_carrera = '" + sCarrera + "'and anio_pensum ='" + sPensum + "'and no_ciclo = '7' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "' and no_ciclo = '9'");

                    dgv_cursos.DataSource = dt;
                }
                else
                {
                    dt = MantenimientosManejo.CargarGrid("select id_carrera, codigo_curso, nombre_curso, no_ciclo, anio_pensum from Curso where id_carrera = '" + sCarrera + "' and anio_pensum='" + sPensum + "'and no_ciclo = '2' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '4' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "'and no_ciclo = '6' or id_carrera = '" + sCarrera + "'and anio_pensum ='" + sPensum + "'and no_ciclo = '8' or id_carrera = '" + sCarrera + "'and anio_pensum='" + sPensum + "' and no_ciclo = '10'");

                    dgv_cursos.DataSource = dt;
                }

                dgv_cursos.Columns[0].HeaderText = "ID Carrera";
                dgv_cursos.Columns[1].HeaderText = "Codigo de curso";
                dgv_cursos.Columns[2].HeaderText = "Nombre de curso";
                dgv_cursos.Columns[3].HeaderText = "ciclo";
                dgv_cursos.Columns[4].HeaderText = "año de pensum";
                con.Close();
            }
        }

        private void dgv_cursos_DoubleClick(object sender, EventArgs e)
        {
            String carrera = Convert.ToString(dgv_cursos.CurrentRow.Cells[0].Value);
            String cod_curso = Convert.ToString(dgv_cursos.CurrentRow.Cells[1].Value);
            String nombre = Convert.ToString(dgv_cursos.CurrentRow.Cells[2].Value);
            lbl_cod1.Visible = true;
            lbl_cod1.Text = carrera + "-" + cod_curso;
            lbl_cur1.Visible = true;
            lbl_cur1.Text = nombre;
            cbo_jor1.Visible = true;
            cbo_sec1.Visible = true;
            chb_asignar1.Visible = true;

            DataTable dt = MantenimientosManejo.CargarGrid("select * from Jornada");
            cbo_jor1.DataSource = dt;
            cbo_jor1.DisplayMember = "tipo_jornada";
            cbo_jor1.ValueMember = "id_jornada";
        }

        private void cbo_jor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHorario(lbl_cod1.Text.Trim(),lbl_hora1,cbo_jor1);
            MostrarSecciones(lbl_cod1.Text.Trim(), cbo_jor1, cbo_sec1);
        }


        private void MostrarHorario(string curso, Label lbl_hora, ComboBox cbo_jor)
        {
            try
            {
                if (!String.IsNullOrEmpty(curso))
                {
                    char delimitador = '-';
                    string[] tokens = new string[3];
                    tokens = curso.Split(delimitador);

                    String sCarrera = tokens[0];
                    String sCod_curso = tokens[1];

                    MySqlConnection con = Conexion.ObtenerConexion();
                    DataTable dt = new DataTable();
                    String sQuery = "select numero from Curso where id_carrera = '" + sCarrera + "' and codigo_curso = '" + sCod_curso + "'";
                    MySqlCommand comando = new MySqlCommand(sQuery, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    String numero = fila[0].ToString().Trim();
                String horario="";
                String dias = "";
                try
                {
                    dt.Reset();
                    String sQuery2 = "select horario, dias from Horario where hora = '" + numero + "' and id_jornada = '" + cbo_jor.SelectedValue.ToString().Trim() + "'";
                    MySqlCommand comando2 = new MySqlCommand(sQuery2, con);
                    MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
                    adaptador2.Fill(dt);
                    fila = dt.Rows[0];
                     horario = fila[0].ToString().Trim();
                     dias = fila[1].ToString().Trim();
                    lbl_hora.Visible = true;
                }
                catch { }
                    //---
                    DataTable dts = MantenimientosManejo.CargarGrid("select no_salon, id_edificio from Salon order by RAND() LIMIT 1");
                    DataRow filas = dts.Rows[0];
                    String salon = filas[0].ToString();
                    String edificio = filas[1].ToString();
                    lbl_hora.Text = horario + " " + dias + " | " + edificio + " " + salon;
                    //--------

                    //lbl_hora.Text = horario + " " + dias ;
                    con.Close();
                }
            }
            catch(System.Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void MostrarSecciones(String curso, ComboBox cbo_jor, ComboBox cbo_sec)
        {
            try
            {
                cbo_sec.Items.Clear();
                if (!String.IsNullOrEmpty(curso))
                {
                    char delimitador = '-';
                    string[] tokens = new string[3];
                    tokens = curso.Split(delimitador);

                    String sCarrera = tokens[0];
                    String sCod_curso = tokens[1];
                    String sJornada = cbo_jor.SelectedValue.ToString().Trim();
                    String año = cbo_año.Text.Trim();
                    String semestre = cbo_semestre.Text.Trim();

                    MySqlConnection con = Conexion.ObtenerConexion();
                    DataTable dt = new DataTable();
                    String sQuery = "select count(*) from Cursos_recibidos where id_carrera = '" + sCarrera + "' and codigo_curso = '" + sCod_curso + "' and id_jornada ='" + sJornada + "' and anio = '" + año + "' and semestre = '" + semestre + "'";
                    MySqlCommand comando = new MySqlCommand(sQuery, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    int cant_alumnos = Convert.ToInt32(fila[0]);
                    // MessageBox.Show(cant_alumnos);
                    if (cant_alumnos < 40)
                    {
                        cbo_sec.Items.Add("A");

                    }
                    else if (cant_alumnos >= 40 && cant_alumnos < 80)
                    {
                        cbo_sec.Items.Add("A");
                        cbo_sec.Items.Add("B");

                    }
                    else if (cant_alumnos >= 80 && cant_alumnos < 120)
                    {
                        cbo_sec.Items.Add("A");
                        cbo_sec.Items.Add("B");
                        cbo_sec.Items.Add("C");
                    }
                    con.Close();
                }
        }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }

}

        private void cbo_sec1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_sec1.SelectedIndex != -1) {
                String curso = lbl_cod1.Text.Trim();
                char delimitador = '-';
                string[] tokens = new string[3];
                tokens = curso.Split(delimitador);

                String sCarrera = tokens[0];
                String sCod_curso = tokens[1];
                String sJornada = cbo_jor1.SelectedValue.ToString().Trim();
                String año = cbo_año.Text.Trim();
                String semestre = cbo_semestre.Text.Trim();
                String seccion = cbo_sec1.SelectedItem.ToString().Trim();
                String catedratico = txt_id_cat.Text.Trim();

                //CREAR TABLA
                DataTable dt = MantenimientosManejo.CargarGrid("select * from Catedratico_curso where codigo_curso = '" + sCod_curso + "' and id_carrera = '" + sCarrera + "' and id_jornada = '" + sJornada + "' and seccion = '" + seccion + "' and anio = '" + año + "' and semestre = '" + semestre + "'");
                if (dt.Rows.Count == 0)
                {

                } else
                {

                    MessageBox.Show("Ya hay un catedratico para ese curso");
                    cbo_sec1.SelectedIndex = -1;
                    //bloquear boton
                }
            }
        }

        private void btn_asignación_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (chb_asignar1.Checked == true)
                {
                    if (!String.IsNullOrEmpty(txt_id_cat.Text))
                   {
                        String curso = lbl_cod1.Text.Trim();
                    char delimitador = '-';
                    string[] tokens = new string[3];
                    tokens = curso.Split(delimitador);

                    String sCarrera = tokens[0];
                    String sCod_curso = tokens[1];
                    String sJornada = cbo_jor1.SelectedValue.ToString().Trim();
                    String año = cbo_año.Text.Trim();
                    String semestre = cbo_semestre.Text.Trim();
                    String seccion = cbo_sec1.SelectedItem.ToString().Trim();
                    String catedratico = txt_id_cat.Text.Trim();

                    MySqlConnection con = Conexion.ObtenerConexion();
                    DataTable dt = new DataTable();
                    String sQuery = "select numero from Curso where id_carrera = '" + sCarrera + "' and codigo_curso = '" + sCod_curso + "'";
                    MySqlCommand comando = new MySqlCommand(sQuery, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    String hora = fila[0].ToString().Trim();

                    int resultado = AsignacionesManejo.InsertarAsignacionCatedratico(catedratico, sCarrera, sCod_curso, año, semestre, sJornada, seccion, hora);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Asignacion Exitosa");
                    }
                    else { MessageBox.Show("Imposible asignar"); }
                    }else { MessageBox.Show("debe ingresar un catedratico"); }
                }

            }
            catch(System.Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
    }

