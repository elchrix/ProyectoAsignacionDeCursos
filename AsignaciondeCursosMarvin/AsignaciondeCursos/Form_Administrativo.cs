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
    public partial class Form_Administrativo : Form
    {
        public Form_Administrativo()
        {
            InitializeComponent();
        }

        private void btn_MenuAsig_Click(object sender, EventArgs e)
        {
            
            spc_asignaciones.Panel2Collapsed = !spc_asignaciones.Panel2Collapsed;
        }

        private void Form_Administrativo_Load(object sender, EventArgs e)
        {
            spc_asignaciones.Panel2Collapsed = true;
            spc_ingresos.Panel2Collapsed = true;
            spc_reportes.Panel2Collapsed = true;
        }

        private void btn_MenuIngresos_Click(object sender, EventArgs e)
        {
            spc_ingresos.Panel2Collapsed = !spc_ingresos.Panel2Collapsed;
        }

        private void btn_MenuReportes_Click(object sender, EventArgs e)
        {
            spc_reportes.Panel2Collapsed = !spc_reportes.Panel2Collapsed;
        }

        private void llbl_AsignarAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_AsignarAlumno f = new form_AsignarAlumno();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void llbl_AsignarCatedratico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_AsignarCated f = new form_AsignarCated();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void llbl_pensum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_PensumCarrera f = new form_PensumCarrera();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }
    }
}
