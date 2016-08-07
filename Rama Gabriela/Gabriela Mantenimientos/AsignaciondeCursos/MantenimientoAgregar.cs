using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace AsignaciondeCursos
{
    class MantenimientoAgregar
    {
        public static int FacultadAgregar(String Id_facultad, String nombre_facultad)
        {
            int devolver = 0;
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into facultad(id_facultad,nombre_facultad) values('" + Id_facultad + "','" + nombre_facultad + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;

        }
        public static int EdificioAgregar(String ID_Edificio, String No_pisos, String Tamanio, String Salones)
        {
            int devolver = 0;
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into edificio(id_edificio,no_pisos,tamaño,cant_salones) values('" + ID_Edificio + "','" + No_pisos + "','" + Tamanio + "','" + Salones + "')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }

     
        public static int AgregarCarrera(String id_carrera, string id_facultad, string ciclos, string nombre_carrera)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into carrera(id_carrera,id_facultad,ciclos,nombre_carrera) values('" +id_carrera + "','" + id_facultad + "','" +ciclos +"','"+nombre_carrera+ "')"), con);
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

        public static int agregarsalon(String no_salon, string id_edificio , string tamaño, string capacidad_aprox, string estatus)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into salon(no_salon,id_edificio,tamaño,capacidad_aprox, estatus) values('" + no_salon + "','" + id_edificio  + "','"+ tamaño +"','"+capacidad_aprox + "','" + estatus +"')"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
        }
        public static int agregarcurso(String id_carrera, string cod_curso, string numero_sab, string numero, string numero_ciclo, string laboratorio ,string numero_creditos, string prerrequisitos , string creditos_necesarios , string nombre_curso, string aniopensum)
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            int devolver = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into curso(id_carrera,codigo_curso,numero_sab, numero, no_ciclo, no_creditos, laboratorio, prerrequisitos, creditos_necesarios, nombre_curso, anio_pensum) values('" + id_carrera + "','" + cod_curso+ "','" + numero_sab+ "','" + numero + "','" + numero_ciclo + "','" + numero_creditos+ "','" + laboratorio+ "','" + prerrequisitos+ "','" + creditos_necesarios  +"','" + nombre_curso + "','" + aniopensum + "' )"), con);
            devolver = comando.ExecuteNonQuery();
            return devolver;
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
                while (dr.Read()) ;
                {
                    cb.Items.Add(dr["id_carrera"].ToString());


                }
                cb.SelectedIndex = 0;

                dr.Close();


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }
        public void llenar_aniopensum(ComboBox cb)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                MySqlDataReader dr;

                cmd = new MySqlCommand("Select anio_pensum from pensum", con);
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

        public void llenar_id_facultad(ComboBox cb)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                MySqlDataReader dr;

                cmd = new MySqlCommand("Select id_facultad from facultad",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["id_facultad"].ToString());


                }
                cb.SelectedIndex = 0;

                dr.Close();


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }

        public void llenar_id_carrera(ComboBox cb)

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


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }

        public void llenar_idificio(ComboBox cmb)

        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                MySqlDataReader dr;

                cmd = new MySqlCommand("Select id_edificio from edificio", con);
                dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    cmb.Items.Add(dr["id_edificio"].ToString());

                    
                }
                cmb.SelectedIndex = 0;

                dr.Close();


            }

            catch
            {
                MessageBox.Show("No se lleno el Combobox");
            }
        }
    }
}

