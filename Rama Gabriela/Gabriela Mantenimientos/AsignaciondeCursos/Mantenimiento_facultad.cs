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
    public partial class Mantenimiento_facultad : Form
    {
        public Mantenimiento_facultad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                int resultado = MantenimientoAgregar.FacultadAgregar(txt_idfacultad.Text, txt_nombrefacultad.Text);

                if (resultado > 0)
                {
                    MessageBox.Show("Facultad Agregada Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la facultad");
                }


                txt_nombrefacultad.Text = "";

                txt_idfacultad.Text = (Convert.ToInt16(txt_idfacultad.Text) + 1).ToString();

                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                string query = "select * from facultad;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                dgv_facultad.DataSource = dt;
                con.Close();


            }
        }

        private void txt_idfacultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {



            Modificar_facultaad mte = new Modificar_facultaad();
           
              mte.Show();
            try
            {
                string id_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[0].Value);
                string nombre_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[1].Value);

                
                
                mte.txt_idfacultad.Text = id_facultad;
                mte.txt_nombrefacultad.Text = nombre_facultad;

             
                mte.Show();





                mte.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        
    }

    private void btn_modificar_Load(object sender, EventArgs e)
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

                dgv_facultad.Columns[0].HeaderText = "Id Carrera";
                dgv_facultad.Columns[1].HeaderText = "Año del Pensum";


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
                        string query = "select * from facultad;";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                        adap.Fill(dt);
                        dgv_facultad.DataSource = dt;
                        con.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id_facultad = Convert.ToString(dgv_facultad.CurrentRow.Cells[0].Value);



                    MySqlConnection con = Conexion.ObtenerConexion();
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar la facultad?", "Aceptar", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        String cuery = "delete from facultad where id_facultad  = '"+id_facultad+"'";
                   
                      
                        MySqlCommand comando = new MySqlCommand(cuery, con);
                      
                  
                        comando.ExecuteNonQuery();


                       

                       
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
        }

        private void Btn_ingresarfacultad_Click(object sender, EventArgs e)
        {

        }

        private void llbl_carrfacupensum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
               
            }
        }
    }
    }

