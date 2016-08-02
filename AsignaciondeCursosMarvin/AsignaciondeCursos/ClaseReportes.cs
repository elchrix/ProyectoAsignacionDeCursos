using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient
;
namespace AsignaciondeCursos
{
    class ClaseReportes
    {
        

            public static DataTable ObtenerCursosAprobados(String id_carrera, String anio_ingreso, String no_carne)
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dt = new DataTable();
                string query = "select id_carrera, codigo_curso" +
                    " from Cursos_recibidos where id_carrera = '" + id_carrera + "' and anio_ingreso = '" + anio_ingreso + "' and no_carne = '" + no_carne + "' and  nota = 'aprobado'";
                MySqlCommand comando = new MySqlCommand(query, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                con.Close();
                return dt;
            }

        public static DataTable DatosPensum(String id_carrera, String anio_pensum,String ciclo)
        {
            MySqlConnection con = Conexion.ObtenerConexion();

            DataTable dt = new DataTable();
            string query = "select id_carrera,nombre_curso,codigo_curso,no_ciclo,no_creditos,prerrequisitos from Curso where id_carrera='" + id_carrera + "'and anio_pensum='" + anio_pensum + "' and no_ciclo = '" + ciclo +"'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            con.Close();
            return dt;
        }


    }
}
