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
    public partial class Form_AgregarCatedratico : Form
    {
        public Form_AgregarCatedratico()
        {
            InitializeComponent();
        }

        private void btn_ingresarc_Click(object sender, EventArgs e)
        {
            int resultado = MantenimientoAgregar.CatedraticoAgregar(txt_idcatedratico.Text, txt_nombre1c.Text, txt_nombre2c.Text, txt_apellido1c.Text, txt_apellido2c.Text, txt_direccionc.Text, txt_correoc.Text, txt_fechac.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo Ingresar");
            }
        }
    }
}
