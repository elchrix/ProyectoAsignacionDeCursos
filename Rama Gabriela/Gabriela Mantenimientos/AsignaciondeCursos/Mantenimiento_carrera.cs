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
    public partial class Mantenimiento_carrera : Form
    {
        public Mantenimiento_carrera()
        {
            InitializeComponent();
        }

        private void Mantenimiento_carrera_Load(object sender, EventArgs e)
        {
            {
                try
                {

                    MantenimientoAgregar man = new MantenimientoAgregar();
                    man.llenar_id_facultad(cbo_idfacultad);


                    MySqlConnection con = Conexion.ObtenerConexion();
                    DataTable dtd = new DataTable();
                    string queryd = "select id_carrera,id_facultad,ciclos,nombre_carrera from carrera";
                    MySqlCommand msc = new MySqlCommand(queryd, con);
                    MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                    adapd.Fill(dtd);
                    dgv_carrera.DataSource = dtd;

                    dgv_carrera.Columns[0].HeaderText = "Id Carrera";
                    dgv_carrera.Columns[1].HeaderText = "Id Facultad";
                    dgv_carrera.Columns[2].HeaderText = "Ciclos";
                    dgv_carrera.Columns[3].HeaderText = "Nombre Carrera";



                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                int resultado = MantenimientoAgregar.AgregarCarrera(txt_idcarrera.Text, cbo_idfacultad.SelectedItem.ToString(), txt_ciclos.Text, txt_nombrecarrera.Text);

                if (resultado > 0)
                {
                    MessageBox.Show("Carrera agregada");
                }
                else
                {
                    MessageBox.Show("Error");
                }

                txt_nombrecarrera.Text = "";
                txt_ciclos.Text = "";
                txt_idcarrera.Text = (Convert.ToInt16(txt_idcarrera.Text) + 1).ToString();

                {
                    {
                        try
                        {
                            MySqlConnection con = Conexion.ObtenerConexion();
                            DataTable dt = new DataTable();
                            string query = "select id_carrera,id_facultad,ciclos,nombre_carrera from carrera";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                            adap.Fill(dt);
                            dgv_carrera.DataSource = dt;
                            con.Close();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Modificar_carrera mte = new Modificar_carrera();

            mte.Show();
            try
            {
                string id_carrera = Convert.ToString(dgv_carrera.CurrentRow.Cells[0].Value);
                string id_facultad = Convert.ToString(dgv_carrera.CurrentRow.Cells[1].Value);
                string ciclos = Convert.ToString(dgv_carrera.CurrentRow.Cells[2].Value);
                string nombre_carrera= Convert.ToString(dgv_carrera.CurrentRow.Cells[3].Value);

                mte.txt_carrera.Text = id_carrera;
                mte.txt_ciclos.Text = ciclos;
                mte.txt_ciclos.Text = nombre_carrera;
                mte.cbo_id__facultad.Items.Add(id_facultad);
                mte.cbo_id__facultad.SelectedIndex = 0;

                mte.Show();


                




              
                this.Close();
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        MySqlConnection con = Conexion.ObtenerConexion();
                        DataTable dt = new DataTable();
                        string query = "select id_carrera,id_facultad,ciclos, nombre_carrera from carrera";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                        adap.Fill(dt);
                        dgv_carrera.DataSource = dt;
                        con.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id_carrera = Convert.ToString(dgv_carrera.CurrentRow.Cells[0].Value);



                    MySqlConnection con = Conexion.ObtenerConexion();
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar la carrera?", "Aceptar", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        String cuery = "delete from carrera where id_carrera= '" + id_carrera + "'";


                        MySqlCommand comando = new MySqlCommand(cuery, con);


                        comando.ExecuteNonQuery();





                        DataTable dtd = new DataTable();
                        string queryd = "select id_carrera,id_facultad,ciclos,nombre_carrera from carrera";
                        MySqlCommand cmdd = new MySqlCommand(queryd, con);
                        MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);
                        adapd.Fill(dtd);
                        dgv_carrera.DataSource = dtd;
                    }

                    con.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
