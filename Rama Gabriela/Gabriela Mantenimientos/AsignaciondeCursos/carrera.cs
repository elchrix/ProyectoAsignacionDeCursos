using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    public partial class carrera : Form
    {
        public carrera()
        {
            InitializeComponent();
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

        private void cbo_idfacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carrera_Load(object sender, EventArgs e)
        {
            MantenimientoAgregar man = new MantenimientoAgregar();

            man.llenar_id_carrera(cbo_idfacultad);
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
