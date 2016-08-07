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
    public partial class form_IngresoCurso : Form
    {
        public form_IngresoCurso()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_IngresoCurso_Load(object sender, EventArgs e)
        {
            MantenimientoAgregar mante = new MantenimientoAgregar();
            mante.llenar_cod_carrera(cbo_cod_carrera);
            mante.llenar_aniopensum(cbo_pensum);
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();

                DataTable dtd = new DataTable();
                string queryd = "select id_carrera,codigo_curso,anio_pensum,numero_sab,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios,nombre_curso from curso";
                MySqlCommand cmdd = new MySqlCommand(queryd, con);
                MySqlDataAdapter adapd = new MySqlDataAdapter(cmdd);

                adapd.Fill(dtd);
                dgv_curso.DataSource = dtd;
                dgv_curso.Columns[0].HeaderText = "ID Carrera";
                dgv_curso.Columns[1].HeaderText = "Cod Curso";
                dgv_curso.Columns[2].HeaderText = "Anio Pensum";
                dgv_curso.Columns[3].HeaderText = "Numero Sab";
                dgv_curso.Columns[4].HeaderText = "Numero";
                dgv_curso.Columns[5].HeaderText = "No Ciclo";
                dgv_curso.Columns[6].HeaderText = "No Creditos";
                dgv_curso.Columns[7].HeaderText = "Laboratorio";
                dgv_curso.Columns[8].HeaderText = "Prerrequisitos";
                dgv_curso.Columns[9].HeaderText = "Creditos Necesarios";
                dgv_curso.Columns[10].HeaderText = "Nombre Curso";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)

        {


            int resultado = MantenimientoAgregar.agregarcurso(cbo_cod_carrera.SelectedItem.ToString(), txt_cod_curso.Text, txt_numero_sabado.Text, txt_numero.Text, txt_numero_ciclos.Text, txt_no_creditos.Text, cbo_laboratorio.SelectedItem.ToString(), txt_prerrequisitos.Text, txt_creditos_necesarios.Text, txt_nombre_curso.Text, cbo_pensum.SelectedItem.ToString());
            if (resultado > 0)
            {
                MessageBox.Show("Curso Agregado Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Curso");
            }
            txt_cod_curso.Text = "";
            txt_numero_sabado.Text = "";
            txt_numero.Text = "";
            txt_prerrequisitos.Text = "";
            txt_creditos_necesarios.Text = "";
            txt_no_creditos.Text = "";
            txt_numero_ciclos.Text = "";
            txt_nombre_curso.Text = "";
        }

        private void txt_cod_curso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cod_curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numero_ciclos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numero_sabado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombre_curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        private void txt_prerrequisitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_no_creditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_creditos_necesarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt = new DataTable();
                string queryd = "select id_carrera,codigo_curso,anio_pensum,numero_sab,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios,nombre_curso from curso";
                MySqlCommand cmd = new MySqlCommand(queryd, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dgv_curso.DataSource = dt;
                con.Close();
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
                MySqlConnection con = Conexion.ObtenerConexion();

                string cod_curso = Convert.ToString(dgv_curso.CurrentRow.Cells[1].Value);
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el Curso?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    string query = "delete from curso where codigo_curso= '" + cod_curso + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string query1 = "select id_carrera,codigo_curso,anio_pensum,numero_sab,numero,no_ciclo,no_creditos,laboratorio,prerrequisitos,creditos_necesarios,nombre_curso from curso";
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dtd);
                    dgv_curso.DataSource = dtd;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            form_cursoactualizar ca = new form_cursoactualizar();
            try
            {
                string id_carrera = Convert.ToString(dgv_curso.CurrentRow.Cells[0].Value);
                string cod_curso = Convert.ToString(dgv_curso.CurrentRow.Cells[1].Value);
                string anio_pensum = Convert.ToString(dgv_curso.CurrentRow.Cells[2].Value);
                string numero_sab = Convert.ToString(dgv_curso.CurrentRow.Cells[3].Value);
                string numero = Convert.ToString(dgv_curso.CurrentRow.Cells[4].Value);
                string no_ciclo = Convert.ToString(dgv_curso.CurrentRow.Cells[5].Value);
                string no_credito = Convert.ToString(dgv_curso.CurrentRow.Cells[6].Value);
                string lab = Convert.ToString(dgv_curso.CurrentRow.Cells[7].Value);
                string pre = Convert.ToString(dgv_curso.CurrentRow.Cells[8].Value);
                string necesarios = Convert.ToString(dgv_curso.CurrentRow.Cells[9].Value);
                string nombre = Convert.ToString(dgv_curso.CurrentRow.Cells[10].Value);

                ca.cbo_cod_carrera.Items.Add(id_carrera);ca.cbo_cod_carrera.SelectedIndex = 0;
                ca.cbo_curso.Items.Add(cod_curso);ca.cbo_curso.SelectedIndex = 0;
                ca.cbo_pensum.Items.Add(anio_pensum);ca.cbo_pensum.SelectedIndex = 0;
                ca.txt_numero_sabado.Text = numero_sab;
                ca.txt_numero.Text = numero;
                ca.txt_numero_ciclos.Text = no_ciclo;
                ca.txt_no_creditos.Text = no_credito;
                ca.txt_prerrequisitos.Text = pre;
                ca.txt_creditos_necesarios.Text = necesarios;
                ca.txt_nombre_curso.Text = nombre;


                ca.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}