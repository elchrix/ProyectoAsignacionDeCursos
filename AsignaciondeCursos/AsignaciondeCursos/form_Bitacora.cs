using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    public partial class form_Bitacora : Form
    {
        public form_Bitacora()
        {
            InitializeComponent();
        }

        private void form_Bitacora_Load(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select * from bitacora");
            dgv_bitacora.DataSource = dt;
        }
    }
}
