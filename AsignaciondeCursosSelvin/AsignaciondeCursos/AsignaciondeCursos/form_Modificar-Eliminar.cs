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
    public partial class form_Modificar_Eliminar : Form
    {
        
        MantenimientoModificar con = new MantenimientoModificar();
        Conexion cnn = new Conexion();
        public form_Modificar_Eliminar()
        {
            InitializeComponent();
        }
        public void mostrar() {
            con.consulta("select * from Alumno", "Alumno");
            data.DataSource = con.ds.Tables[0];

        }

        private void form_Modificar_Eliminar_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrar();   

        }

        private void datagrid(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datadoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDcarreram.Text = data.SelectedRows[0].Cells[0].Value.ToString();
            txt_aniom.Text = data.SelectedRows[0].Cells[1].Value.ToString();
            txt_carnem.Text = data.SelectedRows[0].Cells[2].Value.ToString();
            txt_nombre1m.Text = data.SelectedRows[0].Cells[4].Value.ToString();
            txt_nombre2m.Text = data.SelectedRows[0].Cells[5].Value.ToString();
            txt_apellido1m.Text = data.SelectedRows[0].Cells[6].Value.ToString();
            txt_apellido2m.Text = data.SelectedRows[0].Cells[7].Value.ToString();
            txt_correom.Text = data.SelectedRows[0].Cells[8].Value.ToString();
            txt_direccionm.Text = data.SelectedRows[0].Cells[9].Value.ToString();
            txt_fecham.Text = data.SelectedRows[0].Cells[10].Value.ToString();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (con.eliminar(" Alumno "," no_carne = "+txt_carnem.Text)) {
                MessageBox.Show("exitoso borrado");
                mostrar();
            }
            else
            {
                MessageBox.Show("borrado errado");
            }
        }

        private void btn_modificarm_Click(object sender, EventArgs e)
        {
            string actualizar = "primer_nombre='" + txt_nombre1m.Text + "'segundo_nombre='" + txt_nombre2m.Text + "'primer_apellido='" + txt_apellido1m.Text + "'segundo_apellido='" + txt_apellido2m.Text + "'direccion='" + txt_direccionm.Text + "'correo_electronico='" + txt_correom.Text + "'fecha_nac='" + txt_fecham.Text + "'";
            if (con.actualizar(" Alumno ", actualizar, " id_carrera = " + txt_IDcarreram.Text)) {
                MessageBox.Show("datsos actualizados");
                mostrar();
            }
            else {
                MessageBox.Show("error de actualizacion");
            }
        }
    }
    }

