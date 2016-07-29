using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection con = new MySqlConnection("server= sql3.freemysqlhosting.net; database= sql3128925; Uid=sql3128925; pwd=qBkpBh3Dce;");
            //MySqlConnection con = new MySqlConnection("server=db4free.net; database=asignacursosdb; Uid=grupo4auditoria; pwd=Auditoria123;");
            con.Open();
            return con;
        }
    }
}
