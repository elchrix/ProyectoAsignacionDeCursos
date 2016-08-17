using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    class AsignacionesManejo
    {

        public static DataTable ObtenerCursosAprobados (String id_carrera, String anio_ingreso, String no_carne)
        {
            MySqlConnection con = Conexion.ObtenerConexion();

            DataTable dt = new DataTable();
            string query = "select id_carrera, codigo_curso" +
                " from Cursos_recibidos where id_carrera = '" + id_carrera+ "' and anio_ingreso = '" + anio_ingreso + "' and no_carne = '" + no_carne + "' and  nota = 'aprobado'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
           adaptador.Fill(dt);
                con.Close();
            return dt;
        }


        public static DataTable ObtenerCursosDisponibles(DataTable dt_CursosAprobados, String pensum)
        {
            MySqlConnection con = Conexion.ObtenerConexion();

            DataTable dt_CursosDisponibles = new DataTable();
            
            int iCont = 0;
            foreach (DataRow fila in dt_CursosAprobados.Rows)
            {
                string sQuery = "select id_carrera, codigo_curso, no_ciclo, nombre_curso" +
                    " from Curso where id_carrera = '"+fila[0].ToString().Trim()+"' and prerrequisitos = '"+ fila[1].ToString().Trim()+"' and anio_pensum = '"+pensum+"'";
                MySqlCommand comando = new MySqlCommand(sQuery, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt_CursosDisponibles);
            }
            //-----
            try
            {
                DataRow row = dt_CursosAprobados.Rows[0];
                string sQuerynull = "select id_carrera, codigo_curso, no_ciclo, nombre_curso" +
                        " from Curso where id_carrera = '" + row[0].ToString().Trim() + "' and anio_pensum ='"+pensum+"' and prerrequisitos is null ";
                MySqlCommand comando2 = new MySqlCommand(sQuerynull, con);
                MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
                adaptador2.Fill(dt_CursosDisponibles);
            }
            catch { }
            //-----
            foreach (DataRow filaCA in dt_CursosAprobados.Rows)
            {
                foreach(DataRow filaCD in dt_CursosDisponibles.Rows)
                {
                    if(filaCD[0].ToString().Trim()==filaCA[0].ToString().Trim() && filaCD[1].ToString().Trim() == filaCA[1].ToString().Trim())
                    {
                        // dt_CursosDisponibles.Rows.Remove(filaCD);
                        filaCD[0] = "xx";
                        filaCD[1] = "xx";
                        filaCD[2] = "xx";
                        filaCD[3] = "xx";
                    }
                    else
                      {
                          
                      }
                }
            }
           
            con.Close();
            return dt_CursosDisponibles;
            
        }


        public static DataTable ObtenerPrimerosCursos(String carrera, String pensum)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt_PrimerosCursos = new DataTable();
   
            string sQuery = "select id_carrera, codigo_curso, no_ciclo, nombre_curso" +
                    " from Curso where id_carrera = '" +carrera+ "' and anio_pensum = '"+pensum+"' and prerrequisitos is null ";
            MySqlCommand comando2 = new MySqlCommand(sQuery, con);
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
            adaptador2.Fill(dt_PrimerosCursos);
            con.Close();
            return dt_PrimerosCursos;
        }




        public static void ValidarSemestre(String semestre, String carrera, String cod_curso, String ciclo, String nombre_curso, int cont)
        {
            //if (semestre == "1")
            //{
            //    if (ciclo == "1" || ciclo == "3" || ciclo == "5" || ciclo == "7" || ciclo == "9")
            //    {
                  //ImprimirCursos(carrera, cod_curso, ciclo, nombre_curso, cont);
    
            //  }
            //}
            //else if (semestre == "2")
            //{
            //    if (ciclo == "2" || ciclo == "4" || ciclo == "6" || ciclo == "8" || ciclo == "10")
            //    {

            //      ImprimirCursos(carrera, cod_curso, ciclo, nombre_curso, cont);
            //    }

            //}
        }





        public static void ImprimirCursos(String carrera, String cod_curso, String ciclo, String nombre_curso, int cont)
        {
            //form_AsignarAlumno al = new form_AsignarAlumno();
            
            //switch (cont)
            //{
            //    case 1:
            //        form_AsignarAlumno a = new form_AsignarAlumno();
            //        a.lbl_cod1.Visible = true;
            //        a.lbl_cod1.Text = carrera + "-" + cod_curso;
            //        a.lbl_cur1.Visible = true;
            //        a.lbl_cur1.Text = nombre_curso;
            //        a.lbl_ciclo1.Visible = true;
            //        a.lbl_ciclo1.Text = "hola";
            //        a.cbo_jor1.Visible = true;
            //        a.cbo_sec1.Visible = true;
            //        a.chb_asignar1.Visible = true;
            //        MessageBox.Show("imprimir cursos");
            //        break;

            //    case 2:

            //        al.lbl_cod2.Visible = true;
            //        al.lbl_cod2.Text = carrera + "-" + cod_curso;
            //        al.lbl_cur2.Visible = true;
            //        al.lbl_cur2.Text = nombre_curso;
            //        al.lbl_ciclo2.Visible = true;
            //        al.lbl_ciclo2.Text = ciclo;
            //        al.cbo_jor2.Visible = true;
            //        al.cbo_sec2.Visible = true;
            //        al.chb_asignar2.Visible = true;
            //        break;

            //}
        
        }



        public static int InsertarAsignacion(String id_carrera, String cod_curso, String año_ingreso,String carne,  String año, String semestre, String salon, String edificio, String hora, String jornada, String seccion)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Cursos_recibidos(id_carrera, codigo_curso, anio, semestre, anio_ingreso, no_carne, seccion, no_salon, id_edificio, hora, id_jornada)" +
                    " values('" + id_carrera + "','" + cod_curso + "','" + año + "','" + semestre + "','" + año_ingreso + "','" + carne + "','" + seccion + "','" + salon + "','" + edificio + "','" + hora + "','" + jornada + "')"), con);
                 cmd.ExecuteNonQuery();
                con.Close();
                return 1;
               
            }
            catch
            {
                return 0;
            }

        }


        public static int InsertarAsignacionCatedratico(String catedratico, String carrera, String cod_curso,String año, String semestre,String jornada, String seccion, String hora)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Catedratico_curso(id_catedratico, id_carrera, codigo_curso, anio, semestre, id_jornada, seccion, hora)" +
                    " values('" + catedratico + "','" + carrera + "','" +cod_curso + "','" + año + "','" + semestre + "','" + jornada + "','" + seccion + "','" +hora+"')"), con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;

            }
            catch
            {
                return 0;
            }

        }







    }
}
