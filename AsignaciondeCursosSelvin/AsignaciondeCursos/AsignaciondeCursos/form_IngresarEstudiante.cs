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
    public partial class form_IngresarEstudiante : Form
    {
        public form_IngresarEstudiante()
        {
            InitializeComponent();
        }

        private void btn_ingresara_Click(object sender, EventArgs e)
        {
            int resultado = MantenimientoAgregar.AlumnoAgregar(txt_codCarne.Text,txt_anio.Text, txt_carne.Text, txt_nombre1a.Text, txt_nombre2a.Text, txt_apellido1a.Text, txt_apellido2a.Text, txt_correoa.Text, txt_direcciona.Text, txt_fechaa.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo Ingresar");
            }
        }

        private void btn_eliminarA_Click(object sender, EventArgs e)
        {
            form_Modificar_Eliminar frm = new form_Modificar_Eliminar();
            frm.Show();
        }
    }
}
