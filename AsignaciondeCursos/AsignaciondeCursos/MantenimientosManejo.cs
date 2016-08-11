using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    class MantenimientosManejo
    {

        public static int AlumnoAgregar(String codCarne, String anio, String carne, String primer_noma, String segundo_noma, String primer_apa, String segundo_apa, String correoa, String direcciona, String fechaa, String anio_pensum)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                int devolver = 0;
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Alumno(id_carrera, año_ingreso, no_carne, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, correo_electronico, direccion, fecha_nac, anio_pensum)" +
                    " values('" + codCarne + "','" + anio + "','" + carne + "','" + primer_noma + "','" + segundo_noma + "','" + primer_apa + "','" + segundo_apa + "','" + correoa + "','" + direcciona + "','" + fechaa + "','"+anio_pensum+"')"), con);
                devolver = cmd.ExecuteNonQuery();
                return devolver;
            }
            catch
            {
                return 1;
            }
        }

        public static DataTable CargarGrid(String query)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            con.Close();
            return dt;   
        }

       public static int AlumnoModificar(String codCarne, String anio, String carne, String primer_noma, String segundo_noma, String primer_apa, String segundo_apa, String correoa, String direcciona, String fechaa, String anio_pensum)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                //int devolver = 0;
                //MySqlCommand cmd = new MySqlCommand(string.Format("update Alumno set id_carrera = '" + codCarne + "', anio_ingreso = '" + anio + "', no_carne = '" + carne + "', primer_nombre = '" + primer_noma + "', segundo_nombre = '" + segundo_noma + "', primer_apellido = '" + primer_apa + "', segundo_apellido = '" + segundo_apa + "', correo_electronico = '" + correoa + "', direccion = '" + direcciona +  "', anio_pensum = '" + anio_pensum + "' where id_carrera = '"+codCarne+"' and anio_ingreso = '"+anio+"' and no_carne='"+carne+"')"), con);
                //devolver = cmd.ExecuteNonQuery();
                //return devolver;
                String cuery = "update Alumno set id_carrera = @id_carrera, año_ingreso = @anio_ingreso, no_carne = @no_carne, primer_nombre = @primer_nombre, segundo_nombre = @segundo_nombre, primer_apellido = @primer_apellido, segundo_apellido = @segundo_apellido, correo_electronico = @correo_electronico, direccion = @direccion, anio_pensum = @anio_pensum where id_carrera = '" + codCarne + "' and año_ingreso = '" + anio + "' and no_carne='" + carne +"' ";
                MySqlCommand comando = new MySqlCommand(cuery, con);
                comando.Parameters.AddWithValue("@id_carrera", codCarne);
                comando.Parameters.AddWithValue("@anio_ingreso", anio);
                comando.Parameters.AddWithValue("@no_carne", carne);
                comando.Parameters.AddWithValue("@primer_nombre", primer_noma);
                comando.Parameters.AddWithValue("@segundo_nombre", segundo_noma);
                comando.Parameters.AddWithValue("@primer_apellido", primer_apa);
                comando.Parameters.AddWithValue("@segundo_apellido", segundo_apa);
                comando.Parameters.AddWithValue("@correo_electronico", correoa);
                comando.Parameters.AddWithValue("@direccion", direcciona);
                comando.Parameters.AddWithValue("@anio_pensum", anio_pensum);

                comando.ExecuteNonQuery();
                return 0;
            }
            catch
            {
                return 1;
            }
       }

        public void llenar_cod_carrera(ComboBox cb)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                MySqlDataReader dr;

                cmd = new MySqlCommand("Select id_carrera from carrera", con);
                dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    cb.Items.Add(dr["id_carrera"].ToString());


                }
                cb.SelectedIndex = 0;

                dr.Close();
                con.Close();


            }

            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void llenar_aniopensum(ComboBox cb, String carrera)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                MySqlDataReader dr;

                cmd = new MySqlCommand("Select anio_pensum from pensum where id_carrera = '"+carrera+"'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["anio_pensum"].ToString());


                }
                cb.SelectedIndex = 0;

                dr.Close();


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }

        public static int agregarcurso(String id_carrera, string cod_curso, string numero, string numero_ciclo, string numero_creditos, string laboratorio, string prerrequisitos, string creditos_necesarios, string nombre_curso, string aniopensum)
        {
            int devolver = 0;
            if ( prerrequisitos == "" )
            {
                
                MySqlConnection con = Conexion.ObtenerConexion();
               
                MySqlCommand comando = new MySqlCommand(string.Format("insert into Curso (id_carrera,codigo_curso, numero, no_ciclo, no_creditos, laboratorio, prerrequisitos, creditos_necesarios, nombre_curso, anio_pensum) values('" + id_carrera + "','" + cod_curso + "','" + numero + "','" + numero_ciclo + "','" + numero_creditos + "','" + laboratorio + "','" + prerrequisitos + "','" + creditos_necesarios + "','" + nombre_curso + "','" + aniopensum + "' )"), con);
                 comando.ExecuteNonQuery();

                String cuery = "update curso set prerrequisitos = NULL where id_carrera = '"+id_carrera+"' and codigo_curso = '"+cod_curso+"'";
                MySqlCommand comando2 = new MySqlCommand(cuery, con);
           

                devolver = comando2.ExecuteNonQuery();
            }
               else
                {
               
                MySqlConnection con = Conexion.ObtenerConexion();

                MySqlCommand comando = new MySqlCommand(string.Format("insert into Curso (id_carrera,codigo_curso, numero, no_ciclo, no_creditos, laboratorio, prerrequisitos, creditos_necesarios, nombre_curso, anio_pensum) values('" + id_carrera + "','" + cod_curso + "','" + numero + "','" + numero_ciclo + "','" + numero_creditos + "','" + laboratorio + "','" + prerrequisitos + "','" + creditos_necesarios + "','" + nombre_curso + "','" + aniopensum + "' )"), con);
                devolver = comando.ExecuteNonQuery();
            }
            return devolver;
        }

        public static int FacultadAgregar( String nombre_facultad)
        {
            int devolver = 0;
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into facultad(id_facultad,nombre_facultad) values( NULL ,'" + nombre_facultad + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;

        }

        public void llenar_id_facultad(ComboBox cb)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                DataTable dt = new DataTable();

                cmd = new MySqlCommand("Select id_facultad, nombre_facultad from facultad", con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "nombre_facultad";
                cb.ValueMember = "id_facultad";
                //cb.SelectedIndex = 0;

               


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }

        public static int AgregarCarrera(String id_carrera, string id_facultad, string ciclos, string nombre_carrera)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into carrera(id_carrera,id_facultad,ciclos,nombre_carrera) values('" + id_carrera + "','" + id_facultad + "','" + ciclos + "','" + nombre_carrera + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }


        public static int AgregarPensum(String id_carrera, string anio_pensum)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into pensum(id_carrera,anio_pensum) values('" + id_carrera + "','" + anio_pensum + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }


        public static int CatedraticoAgregar( String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, String direccion, String correo, String fecha)
        {
            try
            {

                MySqlConnection con = Conexion.ObtenerConexion();
                int devolver = 0;
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into Catedratico(id_catedratico, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, direccion, correo_electronico, fecha_nac) values( NULL ,'" + primer_nombre + "','" + segundo_nombre + "','" + primer_apellido + "','" + segundo_apellido + "','" + direccion + "','" + correo + "','" + fecha + "')"), con);
                devolver = cmd.ExecuteNonQuery();
                return devolver;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 1;
            }
        }


        public static void InsertaBitacora(String encargado, String accion)
        {
            //String fecha = DateTime.Now.ToString();
            MySqlConnection con = Conexion.ObtenerConexion();
            
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into bitacora(usuario,accion,hora_y_fecha) values( '" + encargado + "','" + accion + "', Sysdate()  )"), con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }


        public static void ModificaBitacora(String encargado, String accion)
        {
            String fecha = DateTime.Now.ToString();
            MySqlConnection con = Conexion.ObtenerConexion();
            
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into bitacora(usuario,accion,hora_y_fecha) values( '" + encargado + "','" + accion + "', Sysdate() )"), con);
             cmd.ExecuteNonQuery();
            
        }

        public static void EliminaBitacora(String encargado, String accion)
        {
            String fecha = DateTime.Now.ToString();
            MySqlConnection con = Conexion.ObtenerConexion();
           
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into bitacora(usuario,accion,hora_y_fecha) values( '" + encargado + "','" + accion + "', Sysdate() )"), con);
            cmd.ExecuteNonQuery();
            
        }



    }
}
