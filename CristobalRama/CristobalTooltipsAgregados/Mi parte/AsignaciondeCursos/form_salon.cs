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
    public partial class form_salon : Form
    {
        public form_salon()
        {
            InitializeComponent();
        }


        private void form_EdificioSalon_Load(object sender, EventArgs e)
        {
            //En esta linea llamamos a la clase donde se encuentra el metodo de insercion hacia la base de datos
            MantenimientoAgregar m = new MantenimientoAgregar();
            //Aqui llamamos la funcion para llenar el combobox 
            m.llenar_saloncombobox(cbo_edificio);
            try
            {
                //En esta linea se llama a la clase de conexion 
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dtd = new DataTable();
                string queryd = "select * from salon";
                MySqlCommand cmdd = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);

                adapd.Fill(dtd);
                dgv_salon.DataSource = dtd;
                dgv_salon.Columns[0].HeaderText = "No. Salon";
                dgv_salon.Columns[1].HeaderText = "ID Edificio";
                dgv_salon.Columns[2].HeaderText = "Tamaño";
                dgv_salon.Columns[3].HeaderText = "Capacidad Aprox";
                dgv_salon.Columns[4].HeaderText = "Estatus";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama a la clase manteminetoagregar y se le envia los datos como parametros para ingresarlos a la base de datos    
                int resultado = MantenimientoAgregar.agregarsalon(txt_no_salon.Text, cbo_edificio.SelectedItem.ToString(), txt_tamanio.Text, txt_cantaprox.Text);
                if (resultado > 0)
                {
                    MessageBox.Show("Salon Agregado Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el salon");
                }
                txt_cantaprox.Text = "";
                txt_no_salon.Text = "";
                txt_tamanio.Text = "";
                cbo_edificio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //se refresca el gridview con los nuevos datos en la base de datos
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                string query = "select * from salon";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dgv_salon.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            //envia como parametro a el formulario de modificacion los datos seleccionados en el gridview
            form_salonmodificar ed = new form_salonmodificar();
            try
            {
                string no_salon = Convert.ToString(dgv_salon.CurrentRow.Cells[0].Value);
                string id_edificio = Convert.ToString(dgv_salon.CurrentRow.Cells[1].Value);
                string tamanio = Convert.ToString(dgv_salon.CurrentRow.Cells[2].Value);
                string capacidad = Convert.ToString(dgv_salon.CurrentRow.Cells[3].Value);
                string estutus = Convert.ToString(dgv_salon.CurrentRow.Cells[4].Value);
                ed.txt_no_salon.Text = no_salon;
                ed.cbo_edificio.Items.Add(id_edificio);
                ed.cbo_edificio.SelectedIndex = 0;
                ed.txt_tamanio.Text = tamanio;
                ed.txt_cantaprox.Text = capacidad;
                


                ed.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_elimnar_Click(object sender, EventArgs e)
        {
            try
            {
                //se abre la conexion a la base de datos y se elemina el campo seleccionado de la base de datos
                MySqlConnection con = Conexion.ObtenerConexion();

                string no_salon = Convert.ToString(dgv_salon.CurrentRow.Cells[0].Value);
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el Salon?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    string query = "delete from salon where no_salon = '" + no_salon + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string query1 = "select * from salon";
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dtd);
                    dgv_salon.DataSource = dtd;
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }
    }
}
