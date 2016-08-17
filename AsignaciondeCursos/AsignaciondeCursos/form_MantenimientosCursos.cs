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
    public partial class form_MantenimientosCursos : Form
    {
        public form_MantenimientosCursos()
        {
            InitializeComponent();
        }

        private void txt_numero_ciclos_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_MantenimientosCursos_Load(object sender, EventArgs e)
        {
            MantenimientosManejo mante = new MantenimientosManejo();
            mante.llenar_cod_carrera(cbo_cod_carrera);
            mante.llenar_aniopensum(cbo_pensum,cbo_cod_carrera.Text.Trim());
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dtd = new DataTable();
                string queryd = "select id_carrera,codigo_curso,nombre_curso,anio_pensum,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios from curso";
                MySqlCommand cmdd = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);

                adapd.Fill(dtd);
                dgv_curso.DataSource = dtd;
                dgv_curso.Columns[0].HeaderText = "ID Carrera";
                dgv_curso.Columns[1].HeaderText = "Cod Curso";
                dgv_curso.Columns[2].HeaderText = "Nombre Curso";
                dgv_curso.Columns[3].HeaderText = "Anio Pensum";
                dgv_curso.Columns[4].HeaderText = "Numero";
                dgv_curso.Columns[5].HeaderText = "No Ciclo";
                dgv_curso.Columns[6].HeaderText = "No Creditos";
                dgv_curso.Columns[7].HeaderText = "Laboratorio";
                dgv_curso.Columns[8].HeaderText = "Prerrequisitos";
                dgv_curso.Columns[9].HeaderText = "Creditos Necesarios";
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = MantenimientosManejo.agregarcurso(cbo_cod_carrera.SelectedItem.ToString().Trim(), txt_cod_curso.Text.Trim(), cbo_numero.Text.Trim(), cbo_numero_ciclos.Text.Trim(), txt_no_creditos.Text.Trim(), cbo_laboratorio.SelectedItem.ToString().Trim(), txt_prerrequisitos.Text.Trim(), txt_creditos_necesarios.Text.Trim(), txt_nombre_curso.Text.Trim(), cbo_pensum.SelectedItem.ToString().Trim());
                MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Cursos " + cbo_cod_carrera.SelectedItem.ToString().Trim() +" - "+ txt_cod_curso.Text.Trim() +" - "+ cbo_numero.Text.Trim() +" - "+ cbo_numero_ciclos.Text.Trim() +" - "+ txt_no_creditos.Text.Trim() +" - "+ cbo_laboratorio.SelectedItem.ToString().Trim() +" - "+ txt_prerrequisitos.Text.Trim() +" - "+ txt_creditos_necesarios.Text.Trim() +" - "+ txt_nombre_curso.Text.Trim() +" - "+ cbo_pensum.SelectedItem.ToString().Trim());

                if (resultado > 0)
                {
                    MessageBox.Show("Curso Agregado Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el Curso");
                }
                txt_cod_curso.Text = "";
                cbo_numero.SelectedValue = -1;
                txt_prerrequisitos.Text = "";
                txt_creditos_necesarios.Text = "";
                txt_no_creditos.Text = "";
                cbo_numero_ciclos.SelectedValue = -1;
                txt_nombre_curso.Text = "";
            }
            catch(System.Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void Btn_elimnar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                string sCarrera = Convert.ToString(dgv_curso.CurrentRow.Cells[0].Value);
                string sCod_curso = Convert.ToString(dgv_curso.CurrentRow.Cells[1].Value);
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el Curso?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    string query = "delete from Curso where id_carrera = '"+sCarrera+"' and codigo_curso= '" + sCod_curso + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string query1 = "select id_carrera,codigo_curso,anio_pensum,numero_sab,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios,nombre_curso from curso";
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dtd);
                    dgv_curso.DataSource = dtd;
                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Cursos " + sCarrera + sCod_curso);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_cod_carrera_MouseClick(object sender, MouseEventArgs e)
        {
            //cbo_pensum.Items.Clear();
            //MantenimientosManejo mante = new MantenimientosManejo();
            //mante.llenar_aniopensum(cbo_pensum, cbo_cod_carrera.Text.Trim());
        }

        private void cbo_pensum_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_pensum.Items.Clear();
            MantenimientosManejo mante = new MantenimientosManejo();
            mante.llenar_aniopensum(cbo_pensum, cbo_cod_carrera.Text.Trim());
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select id_carrera,codigo_curso,nombre_curso,anio_pensum,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios from curso");
            dgv_curso.DataSource = dt;
        }
    }
}
