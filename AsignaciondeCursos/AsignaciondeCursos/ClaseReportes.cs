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
        

            public static DataTable DatosAlumnoPorCarrea(String id_carrera)
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dt = new DataTable();
            //string query = "select id_carrera, codigo_curso" +
            //" from Cursos_recibidos where id_carrera = '" + id_carrera + "' and anio_ingreso = '" + anio_ingreso + "' and no_carne = '" + no_carne + "' and  nota = 'aprobado'";
                string query = "select * from alumno where id_carrera="+id_carrera;
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

        public static DataTable DatosAlumnosPorCurso(String no_curso)// seleccion de alumnos por curso
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dat = new DataTable();
            String query = "select distinct al.id_carrera, al.anio_ingreso, al.no_carne, al.primer_nombre, al.segundo_nombre,al.primer_apellido, al.segundo_apellido,cu.nombre_curso, cr.seccion, cr.no_salon from alumno as al inner join cursos_recibidos as cr on ( al.id_carrera = cr.id_carrera)inner join curso as cu on(cr.id_carrera = cu.id_carrera) where cu.codigo_curso ='" +no_curso+"'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dat);
            con.Close();
            return dat;
        }

        public static DataTable DatosAlumnosPorSeccion(String seccion, String codigo_curso)// seleccion de alumnos por seccion segun curso
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dat = new DataTable();
            String query = "select distinct al.id_carrera, al.anio_ingreso, al.no_carne, al.primer_nombre, al.segundo_nombre,al.primer_apellido, al.segundo_apellido,cu.nombre_curso, cr.seccion, cr.no_salon from alumno as al inner join cursos_recibidos as cr on ( al.id_carrera = cr.id_carrera)inner join curso as cu on(cr.id_carrera = cu.id_carrera) where cr.seccion ='" + seccion + "' and cu.codigo_curso='"+codigo_curso+"'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dat);
            con.Close();
            return dat;
        }

        public static DataTable DatosCertificacionDeCursos(String id_carrera, String id_anioingreso, String uid)
        {
            String ap = "aprobado";
            MySqlConnection con = Conexion.ObtenerConexion();

            DataTable dt = new DataTable();
            string query = "select  al.id_carrera,al.anio_ingreso,al.no_carne, al.primer_nombre,al.segundo_nombre,al.primer_apellido,al.segundo_apellido,cu.codigo_curso,cu.nombre_curso,cr.nota from alumno as al inner join cursos_recibidos as cr on(al.id_carrera = cr.id_carrera)inner join curso as cu on(cr.id_carrera = cu.id_carrera) where al.id_carrera ='" +id_carrera+ "'and al.anio_ingreso ='"+ id_anioingreso +"'and al.no_carne = '"+ uid +"'and cr.nota = '"+ ap +"'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
