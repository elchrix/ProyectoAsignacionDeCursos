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

        //---------------------------------------------------------------
        //private void btn_MenuAsig_Click(object sender, EventArgs e)
        //{
            
        //    spc_asignaciones.Panel2Collapsed = !spc_asignaciones.Panel2Collapsed;
        //}

        private void Form_Administrativo_Load(object sender, EventArgs e)
        {
           // spc_asignaciones.Panel2Collapsed = true;
           // spc_ingresos.Panel2Collapsed = true;
            //spc_reportes.Panel2Collapsed = true;
        }

        //private void btn_MenuIngresos_Click(object sender, EventArgs e)
        //{
        //    spc_ingresos.Panel2Collapsed = !spc_ingresos.Panel2Collapsed;
        //}

        //private void btn_MenuReportes_Click(object sender, EventArgs e)
        //{
        //    spc_reportes.Panel2Collapsed = !spc_reportes.Panel2Collapsed;
        //}

        //private void llbl_AsignarAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_AsignarAlumno f = new form_AsignarAlumno();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_AsignarCatedratico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_AsignarCated f = new form_AsignarCated();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        private void Form_Administrativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void llbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //Form_Login f = new Form_Login();
        //    //f.Show();
        //    //this.Hide();
        //}

        //private void llbl_MantAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_MantenimientosAlumno f = new form_MantenimientosAlumno();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_mant_cursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_MantenimientosCursos f = new form_MantenimientosCursos();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_mant_facultad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_MantenimientoFacultad f = new form_MantenimientoFacultad();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_carrera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        ////    if (this.spc_principal.Panel2.Controls.Count > 0)
        ////        this.spc_principal.Panel2.Controls.RemoveAt(0);
        ////    form_MantenimientoCarrera f = new form_MantenimientoCarrera();
        ////    f.TopLevel = false;
        ////    f.FormBorderStyle = FormBorderStyle.None;
        ////    f.Dock = DockStyle.Fill;
        ////    this.spc_principal.Panel2.Controls.Add(f);
        ////    this.spc_principal.Panel2.Tag = f;
        ////    f.Show();
        //}

        //private void llbl_mant_pensum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_MantenimientosPensum f = new form_MantenimientosPensum();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_mant_catedratico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_MantenimientoCatedratico f = new form_MantenimientoCatedratico();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_crear_cuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_CrearCuenta f = new form_CrearCuenta();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        //private void llbl_cambiar_contraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //if (this.spc_principal.Panel2.Controls.Count > 0)
        //    //    this.spc_principal.Panel2.Controls.RemoveAt(0);
        //    //form_CambiarContraseña f = new form_CambiarContraseña();
        //    //f.TopLevel = false;
        //    //f.FormBorderStyle = FormBorderStyle.None;
        //    //f.Dock = DockStyle.Fill;
        //    //this.spc_principal.Panel2.Controls.Add(f);
        //    //this.spc_principal.Panel2.Tag = f;
        //    //f.Show();
        //}

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_Bitacora f = new form_Bitacora();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }
        //-----------------------------------------------------------------------------
        //NUEVA INTERFAZ

        private void btn_asignar_alumno_Click(object sender, EventArgs e)
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

        private void btn_asignar_catedratico_Click(object sender, EventArgs e)
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

        private void btn_mant_alumno_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientosAlumno f = new form_MantenimientosAlumno();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_cursos_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientosCursos f = new form_MantenimientosCursos();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_cated_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientoCatedratico f = new form_MantenimientoCatedratico();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_carrera_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientoCarrera f = new form_MantenimientoCarrera();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_facu_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientoFacultad f = new form_MantenimientoFacultad();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_pensum_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientosPensum f = new form_MantenimientosPensum();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_edificio_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientoEdificio f = new form_MantenimientoEdificio();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_mant_salon_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_MantenimientoSalon f = new form_MantenimientoSalon();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_cambiar_contra_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_CambiarContraseña f = new form_CambiarContraseña();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_crearcuenta_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_CrearCuenta f = new form_CrearCuenta();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            this.Hide();
        }

        private void btn_repo_cert_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_CertificacionDeCursos f = new form_CertificacionDeCursos();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_rep_alum_Click(object sender, EventArgs e)
        {
            if (this.spc_principal.Panel2.Controls.Count > 0)
                this.spc_principal.Panel2.Controls.RemoveAt(0);
            form_ListadoAlumno f = new form_ListadoAlumno();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.spc_principal.Panel2.Controls.Add(f);
            this.spc_principal.Panel2.Tag = f;
            f.Show();
        }

        private void btn_rep_pensum_Click(object sender, EventArgs e)
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
