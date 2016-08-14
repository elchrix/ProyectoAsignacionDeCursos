using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //libreria de mysql

namespace AsignaciondeCursos
{
    public partial class form_MantenimientosPensum : Form
    {
        public form_MantenimientosPensum()
        {
            InitializeComponent();
        }


        private void form_MantenimientosPensum_Load(object sender, EventArgs e)
        {

            try
            {
                //llamando a clase ObtenerConexion
                MySqlConnection con = Conexion.ObtenerConexion();
                MySqlCommand cmd;
                DataTable dt = new DataTable();
                //query select
                cmd = new MySqlCommand("Select id_carrera, nombre_carrera from Carrera", con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt);

                cbo_idcarrera.DataSource = dt;
                cbo_idcarrera.DisplayMember = "nombre_carrera";
                cbo_idcarrera.ValueMember = "id_carrera";
                 
                //llenado de los datagridviews
                
                DataTable dtd = new DataTable();
                string queryd = "select p.id_carrera, p.anio_pensum, c.nombre_carrera from pensum p, carrera c where p.id_carrera = c.id_carrera";
                MySqlCommand msc = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                adapd.Fill(dtd);
                dgv_pensum.DataSource = dtd;

                //Campos de las columnas del datagridview
                dgv_pensum.Columns[0].HeaderText = "ID carrera";
                dgv_pensum.Columns[1].HeaderText = "Año Pensum";
                dgv_pensum.Columns[2].HeaderText = "Carrera";



            }
            catch (System.Exception ex)
            {
                //pra control de errores
                MessageBox.Show(ex.Message);
            }
        }
        //boton de ingresar

            //boton ingresar

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
             //ingresar campos
                int resultado = MantenimientosManejo.AgregarPensum(cbo_idcarrera.SelectedValue.ToString().Trim(), txt_anio.Text.Trim());
                if (resultado > 0)
                {
                    MessageBox.Show("Pensum agregado");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                //limpiar text box
                txt_anio.Text = "";

            MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Pensum" + cbo_idcarrera.SelectedValue.ToString().Trim() + txt_anio.Text.Trim());



                             try
                             {
                //llamando a clase ObtenerConexion
                                MySqlConnection con = Conexion.ObtenerConexion();
                                DataTable dt = new DataTable();
                                string query = "select p.id_carrera, p.anio_pensum, c.nombre_carrera from pensum p, carrera c where p.id_carrera = c.id_carrera";
                                MySqlCommand cmd = new MySqlCommand(query, con);
                                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                                adap.Fill(dt);
                                dgv_pensum.DataSource = dt;
                                con.Close();
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                     
            
        }

        //boton eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_carrera = Convert.ToString(dgv_pensum.CurrentRow.Cells[0].Value);
                string anio_pensum = Convert.ToString(dgv_pensum.CurrentRow.Cells[1].Value);


                //llamando a la clase ObtnerConexion
                MySqlConnection con = Conexion.ObtenerConexion();
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el pensum?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //query delete
                    String cuery = "delete from pensum where id_carrera  = '" + id_carrera + "' and anio_pensum = '" + anio_pensum + "'";


                    MySqlCommand comando = new MySqlCommand(cuery, con);


                    comando.ExecuteNonQuery();
                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Pensum" + cbo_idcarrera.SelectedValue.ToString().Trim() + txt_anio.Text.Trim());
                    DataTable dt = MantenimientosManejo.CargarGrid("select p.id_carrera, p.anio_pensum, c.nombre_carrera from pensum p, carrera c where p.id_carrera = c.id_carrera");
                    dgv_pensum.DataSource = dt;
                }
                //llenar conexion
                con.Close();
            }
            catch (System.Exception ex)
            {
                //para control de errores
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //llamando al formulario modificar pensum
            form_ModificarPensum f = new form_ModificarPensum();

            try
            {
                string id_carrera = Convert.ToString(dgv_pensum.CurrentRow.Cells[0].Value).Trim();
                string año_pensum = Convert.ToString(dgv_pensum.CurrentRow.Cells[1].Value).Trim();
                string nombre_carrera = Convert.ToString(dgv_pensum.CurrentRow.Cells[2].Value).Trim();
                f.carrera = id_carrera;
                f.nombre_car = nombre_carrera;
                f.año = año_pensum;
                //f.cbo_idcarrera.Text = nombre_carrera;
                f.txt_anio.Text = año_pensum;

                f.Show();

            }
            catch
            {
                //para control de errores
                MessageBox.Show("No existen registros que modificar");
            }

        }
        //boton actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {  //llenando el datagridview con el  nuevo select 
            DataTable dt = MantenimientosManejo.CargarGrid("select p.id_carrera, p.anio_pensum, c.nombre_carrera from pensum p, carrera c where p.id_carrera = c.id_carrera");
            dgv_pensum.DataSource = dt;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
