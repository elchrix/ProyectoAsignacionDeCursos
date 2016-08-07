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
    public partial class Mantenimiento_pensum : Form
    {
        public Mantenimiento_pensum()
        {
            InitializeComponent();
        }

        private void Btn_ingresarpensum_Click(object sender, EventArgs e)
        {
            {
                int resultado = MantenimientoAgregar.AgregarPensum(cbo_idcarrera.SelectedItem.ToString(), txt_anio.Text);
                if (resultado > 0)
                {
                    MessageBox.Show("Pensum agregado");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                txt_anio.Text = "";
              
                {
                    {
                        {
                            try
                            {
                                MySqlConnection con = Conexion.ObtenerConexion();
                                DataTable dt = new DataTable();
                                string query = "select * from pensum";
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

                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id_carrera = Convert.ToString(dgv_pensum.CurrentRow.Cells[0].Value);
                    string anio_pensum = Convert.ToString(dgv_pensum.CurrentRow.Cells[1].Value);



                    MySqlConnection con = Conexion.ObtenerConexion();
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el pensum?", "Aceptar", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        String cuery = "delete from pensum where id_carrera  = '" + id_carrera + "' and anio_pensum = '" + anio_pensum + "'";


                        MySqlCommand comando = new MySqlCommand(cuery, con);


                        comando.ExecuteNonQuery();





                        DataTable dtd = new DataTable();
                        string queryd = "select * from pensum";
                        MySqlCommand cmdd = new MySqlCommand(queryd, con);
                        MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);
                        adapd.Fill(dtd);
                        dgv_pensum.DataSource = dtd;
                    }

                    con.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Mantenimiento_pensum_Load(object sender, EventArgs e)
        {
            try
            {
                MantenimientoAgregar man = new MantenimientoAgregar();
                man.llenar_id_facultad(cbo_idcarrera);


                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dtd = new DataTable();
                string queryd = "select* from pensum";
                MySqlCommand msc = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                adapd.Fill(dtd);
                dgv_pensum.DataSource = dtd;

                dgv_pensum.Columns[0].HeaderText = "Id Carrera";
                dgv_pensum.Columns[1].HeaderText = "Año Pensum";




            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            {
                {
                    try
                    {
                        MySqlConnection con = Conexion.ObtenerConexion();
                        DataTable dt = new DataTable();
                        string query = "select* from pensum";
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

            }

        }

        private void txt_anio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

