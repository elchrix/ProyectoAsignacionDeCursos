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
                //llamando a clase ObtenerConexion
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dtd = new DataTable();
                //query select para llenar el datagridview
                string queryd = "select * from facultad";
                //parte de llenado de gridview
                MySqlCommand msc = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                adapd.Fill(dtd);
                dgv_facultad.DataSource = dtd;
                //columnas de los campos del datagridview
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

            //limpiar campo 
            txt_nombrefacultad.Text = "";
            MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Facultad" + txt_nombrefacultad.Text.Trim());

            //txt_idfacultad.Text = (Convert.ToInt16(txt_idfacultad.Text) + 1).ToString();
            //Llamando a la clase ObtenerConexion
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            //query select
            string query = "select * from facultad;";
            //llenado del datagridview
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            dgv_facultad.DataSource = dt;
            con.Close();
        }
        //boton eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[0].Value);



                MySqlConnection con = Conexion.ObtenerConexion();
                //dialogo que si deseea eliminar
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar la facultad?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //query delete
                    String cuery = "delete from facultad where id_facultad  = '" + id_facultad + "'";


                    MySqlCommand comando = new MySqlCommand(cuery, con);


                    comando.ExecuteNonQuery();

                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Facultad" + txt_nombrefacultad.Text.Trim());

                    DataTable dtd = new DataTable();
                    //cuery select
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
            //llamando al form modificar facultad
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
                //control de errores
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //para llenado del datagridview con actualizacion por eso el select 
            DataTable dt = MantenimientosManejo.CargarGrid("select * from facultad");
            dgv_facultad.DataSource = dt;
        }
    }
}
