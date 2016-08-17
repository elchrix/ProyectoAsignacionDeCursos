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
    public partial class form_MantenimientoSalon : Form
    {
        public form_MantenimientoSalon()
        {
            InitializeComponent();
        }

        private void form_MantenimientoSalon_Load(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select * from salon");
            dgv_salon.DataSource = dt;
            dgv_salon.Columns[0].HeaderText = "No. Salon";
            dgv_salon.Columns[1].HeaderText = "ID Edificio";
            dgv_salon.Columns[2].HeaderText = "Tamaño";
            dgv_salon.Columns[3].HeaderText = "Capacidad Aprox";
            dgv_salon.Columns[4].HeaderText = "Estatus";

            MantenimientosManejo m = new MantenimientosManejo();
            
            m.llenar_saloncombobox(cbo_edificio);
        }

        private void Btn_agregarsalon_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama a la clase manteminetoagregar y se le envia los datos como parametros para ingresarlos a la base de datos    

                int resultado = MantenimientosManejo.agregarsalon(txt_no_salon.Text, cbo_edificio.SelectedItem.ToString(), txt_tamanio.Text, txt_cantaprox.Text);
                MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Salon " + txt_no_salon.Text.Trim()+" - "+ cbo_edificio.SelectedItem.ToString());
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
                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Salon " + txt_no_salon.Text.Trim()+" - "+ cbo_edificio.Text);

                    DataTable dtd = new DataTable();
                    string query1 = "select * from salon";
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dtd);
                    dgv_salon.DataSource = dtd;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select * from salon");
            dgv_salon.DataSource = dt;
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            //envia como parametro a el formulario de modificacion los datos seleccionados en el gridview
            form_ModificarSalon ed = new form_ModificarSalon();
            try
            {
                string no_salon = Convert.ToString(dgv_salon.CurrentRow.Cells[0].Value);
                string id_edificio = Convert.ToString(dgv_salon.CurrentRow.Cells[1].Value);
                string tamanio = Convert.ToString(dgv_salon.CurrentRow.Cells[2].Value);
                string capacidad = Convert.ToString(dgv_salon.CurrentRow.Cells[3].Value);
                string estutus = Convert.ToString(dgv_salon.CurrentRow.Cells[4].Value);
                ed.txt_no_salon.Text = no_salon;
                ed.edificio = id_edificio;
                //ed.cbo_edificio.Items.Add(id_edificio);
               // ed.cbo_edificio.SelectedIndex = 0;
                ed.txt_tamanio.Text = tamanio;
                ed.txt_cantaprox.Text = capacidad;



                ed.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
