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
using MySql.Data;
/* 
 * AUTOR: 901-12-4330 YONY CALITO
 * VERSION: 2.3
 * CREACION COD: 01/08/2016
 * UD:14/08/2016
 */

namespace AsignaciondeCursos
{
    public partial class form_cat : Form
    {
        public form_cat()
        {
            InitializeComponent();
        }

        //private void btn_historial_Click(object sender, EventArgs e)
        //{
        //    //if (this.splitContainer1.Panel2.Controls.Count > 0)
        //    //    this.splitContainer1.Panel2.Controls.RemoveAt(0);
        //    //form_historial fhist = new form_historial();
        //    //fhist.TopLevel = false;
        //    //fhist.FormBorderStyle = FormBorderStyle.None;
        //    //fhist.Dock = DockStyle.Fill;
        //    //this.splitContainer1.Panel2.Controls.Add(fhist);
        //    //this.splitContainer1.Panel2.Tag = fhist;
        //    //fhist.Show();
        //}

        private void form_cat_Load(object sender, EventArgs e)
        {
            string id_cat = "";
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                MessageBox.Show(Usuario.UserName);
                string query = "SELECT id_catedratico FROM catedratico WHERE username='" + Usuario.UserName + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                id_cat = Convert.ToString(cmd.ExecuteScalar());
                Usuario.Cate_id = id_cat;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            this.Visible = false;

        }

        private void form_cat_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Form_Login fl = new Form_Login();
            fl.Show();
        }

        //private void btn_cursosact_Click(object sender, EventArgs e)
        //{
        //    //if (this.splitContainer1.Panel2.Controls.Count > 0)
        //    //    this.splitContainer1.Panel2.Controls.RemoveAt(0);
        //    //form_cursosact fact = new form_cursosact();
        //    //fact.TopLevel = false;
        //    //fact.FormBorderStyle = FormBorderStyle.None;
        //    //fact.Dock = DockStyle.Fill;
        //    //this.splitContainer1.Panel2.Controls.Add(fact);
        //    //this.splitContainer1.Panel2.Tag = fact;
        //    //fact.Show();
        //}

        private void btn_cursos_Activos_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            form_cursosact fact = new form_cursosact();
            fact.TopLevel = false;
            fact.FormBorderStyle = FormBorderStyle.None;
            fact.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fact);
            this.splitContainer1.Panel2.Tag = fact;
            fact.Show();
        }

        private void btn_hisrial_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            form_historial fhist = new form_historial();
            fhist.TopLevel = false;
            fhist.FormBorderStyle = FormBorderStyle.None;
            fhist.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fhist);
            this.splitContainer1.Panel2.Tag = fhist;
            fhist.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            form_CambiarContraseña fhist = new form_CambiarContraseña();
            fhist.TopLevel = false;
            fhist.FormBorderStyle = FormBorderStyle.None;
            fhist.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fhist);
            this.splitContainer1.Panel2.Tag = fhist;
            fhist.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
