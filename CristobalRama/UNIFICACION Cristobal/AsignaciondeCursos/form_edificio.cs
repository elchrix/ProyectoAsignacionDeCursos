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
    public partial class form_edificio : Form
    {
        public form_edificio()
        {
            InitializeComponent();
        }

        private void txt_cantsalones_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_edificio_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dtd = new DataTable();
                string queryd = "select * from edificio";
                MySqlCommand cmdd = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);

                adapd.Fill(dtd);
                dgv_edificio.DataSource = dtd;
                dgv_edificio.Columns[0].HeaderText = "ID Edificio";
                dgv_edificio.Columns[1].HeaderText = "No. Pisos";
                dgv_edificio.Columns[2].HeaderText = "Tamaño";
                dgv_edificio.Columns[3].HeaderText = "Cant. Salones";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Btn_modificaredifici_Click(object sender, EventArgs e)
        {
            form_edificiomodificar ed = new form_edificiomodificar();
            try
            {
                string id_edificio = Convert.ToString(dgv_edificio.CurrentRow.Cells[0].Value);
                string no_piso = Convert.ToString(dgv_edificio.CurrentRow.Cells[1].Value);
                string tamanio = Convert.ToString(dgv_edificio.CurrentRow.Cells[2].Value);
                string can_salon = Convert.ToString(dgv_edificio.CurrentRow.Cells[3].Value);

                ed.txt_idedificio.Text = id_edificio;
                ed.txt_pisos.Text = no_piso;
                ed.txt_tamanio.Text = tamanio;
                ed.txt_cantsalones.Text = can_salon;
                

                ed.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_ingresaredificio_Click(object sender, EventArgs e)
        {

            try
            {
                int resultado = MantenimientoAgregar.EdificioAgregar(txt_idedificio.Text, txt_pisos.Text, txt_tamanio.Text, txt_cantsalones.Text);
                if (resultado > 0)
                {
                    MessageBox.Show("Edificio Agregado Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el edificio");
                }
                txt_cantsalones.Text = "";
                txt_pisos.Text = "";
                txt_tamanio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                string query = "select * from edificio";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dgv_edificio.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_elimnar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                string id_edificio = Convert.ToString(dgv_edificio.CurrentRow.Cells[0].Value);
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar al cliente?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    string query = "delete from edificio where id_edificio= '" + id_edificio + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string query1 = "select * from edificio";
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dtd);
                    dgv_edificio.DataSource = dtd;
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
