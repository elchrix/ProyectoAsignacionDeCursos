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
    class MantenimientoModificar
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; database= AsignacionPrueba; Uid=root; pwd='';");
        private MySqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da;
        public MySqlCommand comando;
        public void conectar() {
            
        }
        public void consulta(string sql, string tabla) {
            try
            {
                ds.Tables.Clear();
                da = new MySqlDataAdapter(sql, con);
                cmb = new MySqlCommandBuilder(da);
                da.Fill(ds, tabla);
            }
            catch {
                MessageBox.Show("errado");
            }
        }
        public bool eliminar(string tabla, string condicion) {
            try
            {
                con.Open();
                string elimina = "delete from" + tabla + " where " + condicion;
                comando = new MySqlCommand(elimina, con);
                int i = comando.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch {
                return false;
            }
        }

        public bool actualizar(string tabla, string campos, string condicion) {
            
            try
            {
                con.Open();
                string actualizar = "update" + tabla + " set " + campos + " where " + condicion;
                comando = new MySqlCommand(actualizar, con);
                int i = comando.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch {
                MessageBox.Show("error conexion");
                return false;
            }
        }

    }
}
