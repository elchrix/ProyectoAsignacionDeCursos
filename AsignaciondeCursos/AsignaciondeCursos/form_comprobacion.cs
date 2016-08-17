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
    public partial class form_comprobacion : Form
    {
        public form_comprobacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
           
        }

        
        

        private void form_comprobacion_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Usuario.UserName;
        }
    }
}
