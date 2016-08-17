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
    public partial class form_MantenimientosAlumno : Form
    {
        public form_MantenimientosAlumno()
        {
            InitializeComponent();
        }

        private void form_MantenimientosAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                String query_carrera = "select id_carrera from Carrera";
                MySqlCommand comando_carrera = new MySqlCommand(query_carrera, con);
                MySqlDataAdapter adaptador_carrera = new MySqlDataAdapter(comando_carrera);
                adaptador_carrera.Fill(dt);
                cbo_carrera.DataSource = dt;
                cbo_carrera.DisplayMember = "id_carrera";
                cbo_carrera.ValueMember = "id_carrera";

                //CARGAR DTG
                
                DataTable dt2 = MantenimientosManejo.CargarGrid("select id_carrera, anio_ingreso, no_carne, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, correo_electronico, direccion, anio_pensum from Alumno");
                dgw_alumnos.DataSource = dt2;
                dgw_alumnos.Columns[0].HeaderText = "ID carrera";
                dgw_alumnos.Columns[1].HeaderText = "Año ingreso";
                dgw_alumnos.Columns[2].HeaderText = "No. carné";
                dgw_alumnos.Columns[3].HeaderText = "Primer nombre";
                dgw_alumnos.Columns[4].HeaderText = "Segundo nombre";
                dgw_alumnos.Columns[5].HeaderText = "Primer apellido";
                dgw_alumnos.Columns[6].HeaderText = "Segundo apellido";
                dgw_alumnos.Columns[7].HeaderText = "Correo";
                dgw_alumnos.Columns[8].HeaderText = "Dirección";
                dgw_alumnos.Columns[9].HeaderText = "Pensum";

                con.Close();
            }catch(System.Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_ingresara_Click(object sender, EventArgs e)
        {
            
            try
            {
                dtp_nac_alumno.Format = DateTimePickerFormat.Custom;
                dtp_nac_alumno.CustomFormat = "yyyy-MM-dd";
                int resultado = MantenimientosManejo.AlumnoAgregar(cbo_carrera.SelectedValue.ToString().Trim(), txt_anio.Text.Trim(), txt_carne.Text.Trim(), txt_nombre1a.Text.Trim(), txt_nombre2a.Text.Trim(), txt_apellido1a.Text.Trim(), txt_apellido2a.Text.Trim(), txt_correoa.Text.Trim(), txt_direcciona.Text.Trim(), dtp_nac_alumno.Text.Trim(), cbo_pensum.Text.Trim());
                if (resultado > 0)
                {
                    MessageBox.Show("Agregada Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo Ingresar");
                }

                MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Alumno" + cbo_carrera.SelectedValue.ToString().Trim() +" - "+ txt_anio.Text.Trim() +" - "+ txt_carne.Text.Trim() +" - "+ txt_nombre1a.Text.Trim() +" - "+ txt_nombre2a.Text.Trim() +" - "+ txt_apellido1a.Text.Trim() +" - "+ txt_apellido2a.Text.Trim() +" - "+ txt_correoa.Text.Trim() +" - "+ txt_direcciona.Text.Trim() +" - "+ dtp_nac_alumno.Text.Trim() +" - "+ cbo_pensum.Text.Trim());
            }
            catch(System.Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txt_carne_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String sCarrera = cbo_carrera.SelectedValue.ToString().Trim();
                //String sCarrera = cbo_carrera.Text.Trim();
                //String sAño = txt_anio.Text.Trim();
                //String sCarne = txt_carne.Text.Trim();

                MySqlConnection con = Conexion.ObtenerConexion();

                //MOSTRAR CARRERA DEL ALUMNO NUEVO A INGRESAR AL SISTEMA PARA
                //UN MAYOR DETALLE DE INFORMACION Y MAS FACIL ASIGNACION  A UN PENSUM DE SU CARRERA
                DataTable dt = new DataTable();
                String query_carrera = "select nombre_carrera from Carrera where id_carrera = '" + sCarrera + "'";
                MySqlCommand comando_carrera = new MySqlCommand(query_carrera, con);
                MySqlDataAdapter adaptador_carrera = new MySqlDataAdapter(comando_carrera);
                adaptador_carrera.Fill(dt);
                DataRow fila1 = dt.Rows[0];
                lbl_carrera.Visible = true;
                lbl_carrera.Text = fila1[0].ToString();
                //OBTENER PENSUMS DE LA CARRERA
                cbo_pensum.Items.Clear();
                dt.Reset();
                String sQuery = "select anio_pensum from Pensum where id_carrera = '" + sCarrera + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cbo_pensum.Items.Add(row[0].ToString().Trim());
                }

                con.Close();
            }
            catch(System.Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void LimpiarAlumno()
        {
            
            txt_anio.Text = "";
            txt_carne.Text = "";
            txt_nombre1a.Text = "";
            txt_nombre2a.Text = "";
            txt_apellido1a.Text = "";
            txt_apellido2a.Text = "";
            txt_direcciona.Text = "";
            txt_correoa.Text = "";
            lbl_carrera.Visible = false;
            cbo_pensum.Items.Clear();
            cbo_pensum.Text = "";
        }

        private void txt_codCarne_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_codCarne_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {

           
              LimpiarAlumno();
                
           
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            form_ModificarAlumno f = new form_ModificarAlumno();
            try
            {
                string id_carrera = Convert.ToString(dgw_alumnos.CurrentRow.Cells[0].Value).Trim();
                string año_ingreso = Convert.ToString(dgw_alumnos.CurrentRow.Cells[1].Value);
                string no_carne = Convert.ToString(dgw_alumnos.CurrentRow.Cells[2].Value);
                string primernombre = Convert.ToString(dgw_alumnos.CurrentRow.Cells[3].Value);
                string segundonombre = Convert.ToString(dgw_alumnos.CurrentRow.Cells[4].Value);
                string primerapellido = Convert.ToString(dgw_alumnos.CurrentRow.Cells[5].Value);
                string segundoapellido = Convert.ToString(dgw_alumnos.CurrentRow.Cells[6].Value);
                string correo = Convert.ToString(dgw_alumnos.CurrentRow.Cells[7].Value);
                string direccion = Convert.ToString(dgw_alumnos.CurrentRow.Cells[8].Value);
                string pensum = Convert.ToString(dgw_alumnos.CurrentRow.Cells[9].Value);
                f.sCarrera = id_carrera;
                f.sPensum = pensum; 
               // f.cbo_carrera.SelectedText = id_carrera;
                // f.cbo_carrera.SelectedItem = id_carrera;
                f.txt_anio.Text = año_ingreso;
                f.txt_carne.Text = no_carne;
                f.txt_nombre1a.Text = primernombre;
                f.txt_nombre2a.Text = segundonombre;
                f.txt_apellido1a.Text = primerapellido;
                f.txt_apellido2a.Text = segundoapellido;
                f.txt_correoa.Text = correo;
                f.txt_direcciona.Text = direccion;

                f.Show();
                
            }
            catch { }
       }

        private void btn_eliminarA_Click(object sender, EventArgs e)
        {
            string id_carrera = Convert.ToString(dgw_alumnos.CurrentRow.Cells[0].Value);
            string año_ingreso = Convert.ToString(dgw_alumnos.CurrentRow.Cells[1].Value);
            string no_carne = Convert.ToString(dgw_alumnos.CurrentRow.Cells[2].Value);
            MySqlConnection con = Conexion.ObtenerConexion();

            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar al alumno?", "Aceptar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                try
                {
                    String sQuery = "delete from Alumno where id_carrera='" + id_carrera + "' and anio_ingreso = '" + año_ingreso + "' and no_carne = '" + no_carne + "'";
                    MySqlCommand comando = new MySqlCommand(sQuery, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminado exitoso");
                    actualizar();
                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Alumno " + cbo_carrera.SelectedValue.ToString().Trim() +" - "+ txt_anio.Text.Trim() +" - "+ txt_carne.Text.Trim() +" - "+ txt_nombre1a.Text.Trim() +" - "+ txt_nombre2a.Text.Trim() +" - "+ txt_apellido1a.Text.Trim() +" - "+ txt_apellido2a.Text.Trim() +" - "+ txt_correoa.Text.Trim() +" - "+ txt_direcciona.Text.Trim() +" - "+ dtp_nac_alumno.Text.Trim() +" - "+ cbo_pensum.Text.Trim());
                }
                catch { MessageBox.Show("Imposible eliminar"); }
            }
            con.Close();
        }
        private void actualizar()
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select id_carrera, anio_ingreso, no_carne, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, correo_electronico, direccion, anio_pensum from Alumno");
            dgw_alumnos.DataSource = dt;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txt_carne_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_carne_AcceptsTabChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
        }
    }
}
