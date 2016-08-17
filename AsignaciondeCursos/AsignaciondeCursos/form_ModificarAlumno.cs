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
    public partial class form_ModificarAlumno : Form
    {
        public form_ModificarAlumno()
        {
            InitializeComponent();
        }

        public String sCarrera;
        public String sPensum;

        private void form_ModificarAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                 dt = MantenimientosManejo.CargarGrid("select id_carrera from Carrera");
                foreach (DataRow row in dt.Rows)
                {
                    cbo_carrera.Items.Add(row[0].ToString().Trim());
                }
                //String query_carrera = "select id_carrera from Carrera";
                //MySqlCommand comando_carrera = new MySqlCommand(query_carrera, con);
                //MySqlDataAdapter adaptador_carrera = new MySqlDataAdapter(comando_carrera);
                //adaptador_carrera.Fill(dt);
                //cbo_carrera.DataSource = dt;
                //cbo_carrera.DisplayMember = "id_carrera";
                // cbo_carrera.ValueMember = "id_carrera";



                //CARGAR PENSUM
                DataTable dt2 = MantenimientosManejo.CargarGrid("select anio_pensum from Pensum where id_carrera = '" + cbo_carrera.Text.Trim() + "'");
                foreach (DataRow row in dt2.Rows)
                {
                    cbo_pensum.Items.Add(row[0].ToString().Trim());
                }

                cbo_carrera.Text = sCarrera;
                cbo_pensum.Text = sPensum;
            }
            catch(System.Exception es) { MessageBox.Show(es.Message); }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int resultado = MantenimientosManejo.AlumnoModificar(cbo_carrera.Text.Trim(), txt_anio.Text.Trim(), txt_carne.Text.Trim(), txt_nombre1a.Text.Trim(), txt_nombre2a.Text.Trim(), txt_apellido1a.Text.Trim(), txt_apellido2a.Text.Trim(), txt_correoa.Text.Trim(), txt_direcciona.Text.Trim(), dtp_nac_alumno.Text.Trim(), cbo_pensum.Text.Trim());
            MantenimientosManejo.ModificaBitacora(Usuario.UserName, "UPDATE - Alumno " + cbo_carrera.Text.Trim() +" - "+ txt_anio.Text.Trim() +" - "+ txt_carne.Text.Trim() +" - "+ txt_nombre1a.Text.Trim() +" - "+ txt_nombre2a.Text.Trim() +" - "+ txt_apellido1a.Text.Trim() +" - "+ txt_apellido2a.Text.Trim() +" - "+ txt_correoa.Text.Trim() +" - "+ txt_direcciona.Text.Trim() +" - "+ dtp_nac_alumno.Text.Trim() +" - "+ cbo_pensum.Text.Trim());
            if (resultado == 0)
            {
                MessageBox.Show("Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo Ingresar");
            }
        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt2 = MantenimientosManejo.CargarGrid("select anio_pensum from Pensum where id_carrera = '" + cbo_carrera.Text.Trim() + "'");
            //foreach (DataRow row in dt2.Rows)
            //{
            //    cbo_pensum.Items.Add(row[0].ToString().Trim());
            //}
        }

        private void cbo_pensum_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_pensum.Items.Clear();
            DataTable dt2 = MantenimientosManejo.CargarGrid("select anio_pensum from Pensum where id_carrera = '" + cbo_carrera.Text.Trim() + "'");
            foreach (DataRow row in dt2.Rows)
            {
                cbo_pensum.Items.Add(row[0].ToString().Trim());
            }
        }
    }
}
