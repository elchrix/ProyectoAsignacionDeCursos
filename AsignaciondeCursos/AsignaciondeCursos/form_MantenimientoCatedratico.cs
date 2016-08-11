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
    public partial class form_MantenimientoCatedratico : Form
    {
        public form_MantenimientoCatedratico()
        {
            InitializeComponent();
        }

        private void form_MantenimientoCatedratico_Load(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid( "Select * from catedratico");
            dgv_catedraticos.DataSource = dt;

            dgv_catedraticos.Columns[0].HeaderText = "ID Catedratico";
            dgv_catedraticos.Columns[1].HeaderText = "Primer nombre";
            dgv_catedraticos.Columns[2].HeaderText = "Segundo nombre";
            dgv_catedraticos.Columns[3].HeaderText = "Primer apellido";
            dgv_catedraticos.Columns[4].HeaderText = "Segundo apellido";
            dgv_catedraticos.Columns[5].HeaderText = "Dirrección";
            dgv_catedraticos.Columns[6].HeaderText = "Correo";
            dgv_catedraticos.Columns[7].HeaderText = "Fecha de nacimiento";
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            dtp_fechaNacCto.Format = DateTimePickerFormat.Custom;
            dtp_fechaNacCto.CustomFormat = "yyyy-MM-dd";
            int resultado = MantenimientosManejo.CatedraticoAgregar(txt_nombre1Cto.Text.Trim(), txt_nombre2Cto.Text.Trim(), txt_apellido1Cto.Text.Trim(), txt_apellido2Cto.Text.Trim(), txt_direccionCto.Text.Trim(), txt_correoCto.Text.Trim(), dtp_fechaNacCto.Text.Trim());
            if (resultado > 0)
            {
                MessageBox.Show("Se Ingreso Exitosamente");
                //con.mostrar();
                DataTable dt = MantenimientosManejo.CargarGrid("select * from catedratico");
                dgv_catedraticos.DataSource = dt;

                txt_nombre1Cto.Text = "";
                txt_nombre2Cto.Text = "";
                txt_apellido1Cto.Text = "";
                txt_apellido2Cto.Text = "";
                txt_direccionCto.Text = "";
                txt_correoCto.Text = "";

                MantenimientosManejo.InsertaBitacora(Usuario.UserName, "INSERT - Catedratico" + txt_nombre1Cto.Text.Trim() + txt_nombre2Cto.Text.Trim() + txt_apellido1Cto.Text.Trim() + txt_apellido2Cto.Text.Trim() + txt_direccionCto.Text.Trim() + txt_correoCto.Text.Trim() + dtp_fechaNacCto.Text.Trim());

            }
            else
            {
                MessageBox.Show("No se pudo realizar la insercion");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                string cod_catedratico = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[0].Value);
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el catedratico seleccionado?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    MySqlCommand comando = new MySqlCommand(" delete from catedratico where id_catedratico = '" + cod_catedratico + "'", con);
                    comando.ExecuteNonQuery();
                    DataTable dt = MantenimientosManejo.CargarGrid("select * from catedratico");
                    dgv_catedraticos.DataSource = dt;
                    MantenimientosManejo.EliminaBitacora(Usuario.UserName, "DELETE - Catedratico" + txt_nombre1Cto.Text.Trim() + txt_nombre2Cto.Text.Trim() + txt_apellido1Cto.Text.Trim() + txt_apellido2Cto.Text.Trim() + txt_direccionCto.Text.Trim() + txt_correoCto.Text.Trim() + dtp_fechaNacCto.Text.Trim());

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            try
            {
                form_ModificarCatedratico con = new form_ModificarCatedratico();
                string id_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[0].Value);
                string nom1_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[1].Value);
                string nom2_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[2].Value);
                string apell1_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[3].Value);
                string apell2_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[4].Value);
                string direccion_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[5].Value);
                string correo_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[6].Value);
                string fecha_catedra = Convert.ToString(dgv_catedraticos.CurrentRow.Cells[7].Value);

                con.txt_idCto1.Text = id_catedra;
                con.txt_nombre1Cto.Text = nom1_catedra;
                con.txt_nombre2Cto.Text = nom2_catedra;
                con.txt_apellido1Cto.Text = apell1_catedra;
                con.txt_apellido2Cto.Text = apell2_catedra;
                con.txt_direccionCto.Text = direccion_catedra;
                con.txt_correoCto.Text = correo_catedra;
                con.dtp_fechaNacCto.Text = fecha_catedra;
                con.Show();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = MantenimientosManejo.CargarGrid("select * from catedratico");
            dgv_catedraticos.DataSource = dt;
            
        }
    }
}
