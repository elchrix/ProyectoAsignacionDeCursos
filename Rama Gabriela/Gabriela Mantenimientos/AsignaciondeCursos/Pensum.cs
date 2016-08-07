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
    public partial class eliminar_registros : Form
    {
        public eliminar_registros()
        {
            InitializeComponent();
        }

        private void dgv_eliminar_facultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable datatablee = new DataTable();
            string query = "select * from facultad";
            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(datatablee);

            dgv_eliminar_facultad.DataSource = datatablee;
        }
    }
}
