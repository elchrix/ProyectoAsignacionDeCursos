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
    public partial class agregar_pensum : Form
    {
        public agregar_pensum()
        {
            InitializeComponent();
        }

       


private void pensuum_Load(object sender, EventArgs e)
        {
            MantenimientoAgregar man = new MantenimientoAgregar();
           

            man.llenar_id_carrera(cbo_idcarrera);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            {
            }
        }

        private void Btn_ingresarpensum_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Mantenimiento_Pensum mant = new Mantenimiento_Pensum();


          // mant.Show();

        }
    }
}
