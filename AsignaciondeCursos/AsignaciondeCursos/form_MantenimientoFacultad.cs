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
    public partial class form_MantenimientoFacultad : Form
    {
        public form_MantenimientoFacultad()
        {
            InitializeComponent();
        }

        private void form_MantenimientoFacultad_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dtd = new DataTable();
                string queryd = "select * from facultad";
                MySqlCommand msc = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                adapd.Fill(dtd);
                dgv_facultad.DataSource = dtd;

                dgv_facultad.Columns[0].HeaderText = "ID facultad";
                dgv_facultad.Columns[1].HeaderText = "Nombre de la facultad";


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            int resultado = MantenimientosManejo.FacultadAgregar( txt_nombrefacultad.Text.Trim());

            if (resultado > 0)
            {
                MessageBox.Show("Facultad Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar la facultad");
            }


            txt_nombrefacultad.Text = "";
            MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Facultad " + txt_nombrefacultad.Text.Trim());

            //txt_idfacultad.Text = (Convert.ToInt16(txt_idfacultad.Text) + 1).ToString();

            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            string query = "select * from facultad;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            dgv_facultad.DataSource = dt;
            con.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[0].Value);



                MySqlConnection con = Conexion.ObtenerConexion();
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar la facultad?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    String cuery = "delete from facultad where id_facultad  = '" + id_facultad + "'";


                    MySqlCommand comando = new MySqlCommand(cuery, con);


                    comando.ExecuteNonQuery();

                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Facultad " + txt_nombrefacultad.Text.Trim());

                    DataTable dtd = new DataTable();
                    string queryd = "select * from facultad";
                    MySqlCommand cmdd = new MySqlCommand(queryd, con);
                    MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);
                    adapd.Fill(dtd);
                    dgv_facultad.DataSource = dtd;
                }

                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

           form_modificar_facultad mte = new form_modificar_facultad();
     
            try
            {
                string id_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[0].Value);
                string nombre_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[1].Value);

                mte.txt_idfacultad.Text = id_facultad;
                mte.txt_nombrefacultad.Text = nombre_facultad;

                mte.Show();
                
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select * from facultad");
            dgv_facultad.DataSource = dt;
        }
    }
}
