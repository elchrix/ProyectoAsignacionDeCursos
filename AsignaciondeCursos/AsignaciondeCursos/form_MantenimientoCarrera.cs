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
    public partial class form_MantenimientoCarrera : Form
    {
        public form_MantenimientoCarrera()
        {
            InitializeComponent();
        }

        private void form_MantenimientoCarrera_Load(object sender, EventArgs e)
        {
            try
            {

                MantenimientosManejo man = new MantenimientosManejo();
                man.llenar_id_facultad(cbo_idfacultad);


                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dtd = new DataTable();
                string queryd = "select c.id_carrera, c.nombre_carrera, c.ciclos, f.nombre_facultad from Carrera c, Facultad f where c.id_facultad = f.id_facultad";
                MySqlCommand msc = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(msc);
                adapd.Fill(dtd);
                dgv_carrera.DataSource = dtd;

                dgv_carrera.Columns[0].HeaderText = "ID Carrera";
                dgv_carrera.Columns[1].HeaderText = "Nombre carrera";
                dgv_carrera.Columns[2].HeaderText = "Ciclos";
                dgv_carrera.Columns[3].HeaderText = "Nombre facultad";



            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            int resultado = MantenimientosManejo.AgregarCarrera(txt_idcarrera.Text.Trim(), cbo_idfacultad.SelectedValue.ToString().Trim(), cbo_ciclos.Text.Trim(), txt_nombrecarrera.Text.Trim());

            if (resultado > 0)
            {
                MessageBox.Show("Carrera agregada");
            }
            else
            {
                MessageBox.Show("Error");
            }

            txt_nombrecarrera.Text = "";
            cbo_ciclos.SelectedIndex = -1;
            txt_idcarrera.Text = "";
            MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Carrera" + txt_idcarrera.Text.Trim() + cbo_idfacultad.SelectedValue.ToString().Trim());

            //  txt_idcarrera.Text = (Convert.ToInt16(txt_idcarrera.Text) + 1).ToString();



            try
            {
                        MySqlConnection con = Conexion.ObtenerConexion();
                        DataTable dt = new DataTable();
                        string query = "select c.id_carrera, c.nombre_carrera, c.ciclos, f.nombre_facultad from Carrera c, Facultad f where c.id_facultad = f.id_facultad";
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

        private void btn_elimnar_Click(object sender, EventArgs e)
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


                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Carrera" + txt_idcarrera.Text.Trim() + cbo_idfacultad.SelectedValue.ToString().Trim());

                    DataTable dtd = new DataTable();
                    string queryd = "select c.id_carrera, c.nombre_carrera, c.ciclos, f.nombre_facultad from Carrera c, Facultad f where c.id_facultad = f.id_facultad";
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            form_ModificarCarrera mte = new form_ModificarCarrera();

            
            try
            {
                string id_carrera = Convert.ToString(dgv_carrera.CurrentRow.Cells[0].Value);
                string nombre_carrera = Convert.ToString(dgv_carrera.CurrentRow.Cells[1].Value);
                string ciclos = Convert.ToString(dgv_carrera.CurrentRow.Cells[2].Value);
                string nombre_facultad = Convert.ToString(dgv_carrera.CurrentRow.Cells[3].Value);

                mte.txt_carrera.Text = id_carrera;
                mte.cbo_ciclos.Text = ciclos;
                mte.txt_nombre_carrera.Text = nombre_carrera;
                mte.nombre_facu = nombre_facultad;
               

                mte.Show();
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select c.id_carrera, c.nombre_carrera, c.ciclos, f.nombre_facultad from Carrera c, Facultad f where c.id_facultad = f.id_facultad");
            dgv_carrera.DataSource = dt;
        }
    }
}
