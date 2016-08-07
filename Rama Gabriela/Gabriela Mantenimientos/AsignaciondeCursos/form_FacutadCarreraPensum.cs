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
    public partial class form_FacutadCarreraPensum : Form
    {
        public form_FacutadCarreraPensum()
        {
            InitializeComponent();
        }

        private void Btn_Ingresar_Facultad(object sender, EventArgs e)

        {
          
            int resultado = MantenimientoAgregar.FacultadAgregar(txt_idfacultad.Text , txt_nombrefacultad.Text);
          
            if (resultado > 0)
            {
                MessageBox.Show("Facultad Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar la facultad");
            }

            
            txt_nombrecarrera.Text = "";

       
            

        }

        private void form_FacutadCarreraPensum_Load(object sender, EventArgs e)
        {
            MantenimientoAgregar man = new MantenimientoAgregar();
            man.llenar_id_facultad(cbo_idfacultad);

            man.llenar_id_carrera(cbo_idcarrera);
        }

        private void Btn_ingresarpensum_Click(object sender, EventArgs e)
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

        }

        private void Btn_ingresarcarrera_Click(object sender, EventArgs e)
        {

            int resultado = MantenimientoAgregar.AgregarCarrera(txt_idcarrera.Text, cbo_idfacultad.SelectedItem.ToString(), txt_nombrecarrera.Text, txt_ciclos.Text);

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




        }

        private void txt_nombrefacultad_KeyDown(object sender, KeyEventArgs e)
        {
                    }

        private void txt_anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombrefacultad_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txt_nombrefacultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbo_idfacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_idcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
