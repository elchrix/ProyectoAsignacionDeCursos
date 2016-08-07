using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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


        public static DataTable ObtenerCursosDisponibles(DataTable dt_CursosAprobados)
        {
            MySqlConnection con = Conexion.ObtenerConexion();

            DataTable dt_CursosDisponibles = new DataTable();
            
            int iCont = 0;
            foreach (DataRow fila in dt_CursosAprobados.Rows)
            {
                string sQuery = "select id_carrera, codigo_curso, no_ciclo" +
                    " from Curso where id_carrera = '"+fila[0].ToString().Trim()+"' and prerrequisitos = '"+ fila[1].ToString().Trim()+"'";
                MySqlCommand comando = new MySqlCommand(sQuery, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt_CursosDisponibles);
            }
            //-----
            try
            {
                DataRow row = dt_CursosAprobados.Rows[0];
                string sQuerynull = "select id_carrera, codigo_curso, no_ciclo" +
                        " from Curso where id_carrera = '" + row[0].ToString().Trim() + "' and prerrequisitos is null ";
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
                        filaCD[0] = null;
                        filaCD[1] = null;
                        filaCD[2] = null;
                    }
                    else
                      {
                          
                      }
                }
            }
           
            con.Close();
            return dt_CursosDisponibles;
            
        }
    }
}
