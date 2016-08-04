using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    class MantenimientoAgregar
    {
      public static int FacultadAgregar(String Id_facultad,String nombre_facultad)
        {
            int devolver = 0;
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into facultad(id_facultad,nombre_facultad) values('" + Id_facultad + "','" + nombre_facultad + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;

        }
        public static int EdificioAgregar(String ID_Edificio,String No_pisos, String Tamanio, String Salones)
        {
            int devolver = 0;
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into edificio(id_edificio,no_pisos,tamaño,cant_salones) values('" + ID_Edificio + "','" + No_pisos + "','" + Tamanio + "','" + Salones + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }

        public static int PensumAgregar(String ID_Pensum, String Anio)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into pensum(id_carrera,anio_pensum) values('"+ID_Pensum+"','"+Anio+"')"),con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }
        public static int AlumnoAgregar(String codCarne, String anio, String carne,  String primer_noma, String segundo_noma, String primer_apa, String segundo_apa, String correoa, String direcciona, String fechaa)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                int devolver = 0;
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Alumno(id_carrera, año_ingreso, no_carne, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, correo_electronico, direccion, fecha_nac) values('" + codCarne + "','" + anio + "','" + carne + "','" + primer_noma + "','" + segundo_noma + "','" + primer_apa + "','" + segundo_apa + "','" + correoa + "','" + direcciona + "','" + fechaa + "')"), con);
                devolver = cmd.ExecuteNonQuery();
                return devolver;
            }
            catch
            {
                return 1;
            }
        }

        public static int CatedraticoAgregar(String id_catedratico, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, String direccion, String correo, String fecha) {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                int devolver = 0;
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Catedratico(id_catedratico, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, direccion, correo_electronico, fecha_nac) values('" + id_catedratico + "','" + primer_nombre + "','" + segundo_nombre + "','" + primer_apellido + "','" + segundo_apellido + "','" + direccion + "','" + correo + "','" + fecha + "')"), con);
                devolver = cmd.ExecuteNonQuery();
                return devolver;
            }
            catch {
                return 1;
            }    
        }
      
    }
}
