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
           

            int resultado = MantenimientoAgregar.FacultadAgregar(txt_idfacultad.Text,txt_nombrefacultad.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Facultad Agregada Exitosamente");        
            }
            else
            {
                MessageBox.Show("No se pudo agregar la facultad");
            }
            
        }

        private void form_FacutadCarreraPensum_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarId_Carrera(cbo_idcarrera);
        }

        private void Btn_ingresarpensum_Click(object sender, EventArgs e)
        {
            int resultado = MantenimientoAgregar.PensumAgregar(cbo_idcarrera.SelectedItem.ToString(), txt_anio.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Pensum agregado");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Btn_ingresarcarrera_Click(object sender, EventArgs e)
        {

        }
    }
}
