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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace AsignaciondeCursos
{
    public partial class form_ListadoAlumno : Form
    {
        public form_ListadoAlumno()
        {
            InitializeComponent();
        }
        String id_facultad;
        String id_carrera;
        

        private void form_ListadoAlumno_Load(object sender, EventArgs e)
        {
            // CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE FACULTAD
            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();
            
            MySqlCommand cmd = new MySqlCommand("select nombre_facultad, id_facultad from Facultad", conex);
            //MySqlCommand cmd = new MySqlCommand("select'<<Selecione un valor>>' as nombre_facultad,-1 as id_facultad from facultad union select nombre_facultad, id_facultad from Facultad", conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            

            adap.Fill(cargadt);

            cbo_facultad.DataSource = cargadt;
            cbo_facultad.DisplayMember = "nombre_facultad";
            cbo_facultad.ValueMember = "id_facultad";
        }

        private void cbo_facultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE CARRERA
                cbo_facultad.DisplayMember = "nombre_facultad";
                cbo_facultad.ValueMember = "id_facultad";

                id_facultad = cbo_facultad.SelectedValue.ToString().Trim();

                MySqlConnection conex = Conexion.ObtenerConexion();
                DataTable cargadt = new DataTable();

                MySqlCommand cmd = new MySqlCommand("select * from Carrera where id_facultad =" + id_facultad, conex);
                //MySqlCommand cmd = new MySqlCommand("select'<<Seleccione una carrera>>' as nombre_carrera,-1 as id_carrera from carrera union select nombre_carrera,id_carrera from Carrera where id_facultad =" + id_facultad, conex);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(cargadt);

                cbo_carrera.DataSource = cargadt;
                cbo_carrera.DisplayMember = "nombre_carrera";
                cbo_carrera.ValueMember = "id_carrera";

                id_carrera = cbo_carrera.SelectedValue.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_GenerarLista_Click(object sender, EventArgs e)
        {
            textBox1.Text = id_carrera;

            String ruta = "";
            ruta = @"C:\Users\Marvin\Documents\PensumsGenerados";

            Document DocumentoPensum = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter nombre_doc = PdfWriter.GetInstance(DocumentoPensum, new FileStream(ruta + "pensum.pdf", FileMode.Create));
            DocumentoPensum.Open();
            // ---------------------- la hoja de de PDF tiene un ancho de 600 
            //------------------------ LOGO UNIVERSIDAD 
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logo2.jpg");
            logo.SetAbsolutePosition(30f, 650f);
            //logo.Alignment = Element.ALIGN_LEFT;
            logo.ScaleAbsoluteHeight(125);
            logo.ScaleAbsoluteWidth(125);

            DocumentoPensum.Add(logo);

            // Formatos del Pdf
            iTextSharp.text.Font formatotitulos = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font formatocuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);



            // Encabezado umg
            Paragraph encabezado = new Paragraph(new Phrase("\nUniversidad Complutense de Madrid\n" + cbo_facultad.Text + "\n" + cbo_carrera.Text , new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
            encabezado.Alignment = Element.ALIGN_CENTER;
            DocumentoPensum.Add(encabezado);

            Paragraph titulos = new Paragraph(new Phrase("\n\n\n\n       Código       Curso           Créditos        Requisitos", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            titulos.Alignment = Element.ALIGN_CENTER;
            DocumentoPensum.Add(titulos);

            DataTable matriz = ClaseReportes.DatosAlumnoPorCarrea(id_carrera);
            dgv_muestra.DataSource = matriz;

            for (int control = 0; control < dgv_muestra.Rows.Count - 1; control++)// CICLO FOR QUE VA A RECORRER EL DATA GRIED PARA LEER LOS DATOS Y ENVIARLOS AL PDF, SE VAN A LIMPIAR LAS VARIABLES EN CADA CICLO PARA REUTILIZARLAS
            {
                Paragraph ciclouno = new Paragraph(new Phrase("\n " + dgv_muestra.Rows[control].Cells["id_carrera"].Value.ToString() + "      " + dgv_muestra.Rows[control].Cells["primer_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["primer_apellido"].Value.ToString(), formatocuerpo));
                ciclouno.Alignment = Element.ALIGN_LEFT;
                DocumentoPensum.Add(ciclouno);

            }


            DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios

            System.Diagnostics.Process.Start(ruta + "pensum.pdf"); // el documento PDF se ejecuta automaticamente para que no se haga el doble clic
        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
