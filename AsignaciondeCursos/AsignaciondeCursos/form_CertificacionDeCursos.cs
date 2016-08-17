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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AsignaciondeCursos
{
    public partial class form_CertificacionDeCursos : Form
    {
        public form_CertificacionDeCursos()
        {
            InitializeComponent();
        }

        private void btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            String id_carrera = txt_carrera.Text.Trim();
            String id_anioingreso = txt_anio.Text.Trim();
            String uid = txt_uid.Text.Trim();
            String ruta = "";
            ruta = "repo.pdf";
            Document DocumentoPensum = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter nombre_doc = PdfWriter.GetInstance(DocumentoPensum, new FileStream(ruta, FileMode.Create));
            DocumentoPensum.Open();
            try
            {

                //String id_carrera = txt_carrera.Text.Trim();
                //String id_anioingreso = txt_anio.Text.Trim();
                //String uid = txt_uid.Text.Trim();

                //String ruta = "";
                //ruta = "repo.pdf";

                //Document DocumentoPensum = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                //PdfWriter nombre_doc = PdfWriter.GetInstance(DocumentoPensum, new FileStream(ruta, FileMode.Create));
                //DocumentoPensum.Open();
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
                DataTable consulta = null;
                consulta = ClaseReportes.DatosCertificacionDeCursos(id_carrera, id_anioingreso, uid);
                dgv_muestra.DataSource = consulta;



                // conexion para obtener la carrera del alumno
                MySqlConnection conex = Conexion.ObtenerConexion();
                DataTable cargadt = new DataTable();

                MySqlCommand cmd = new MySqlCommand("select nombre_carrera from carrera where id_carrera =" + dgv_muestra.Rows[0].Cells["id_carrera"].Value.ToString(), conex);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(cargadt);
                DataRow row = cargadt.Rows[0];
                String carrera = row["nombre_carrera"].ToString();




                Paragraph encabezado = new Paragraph(new Phrase("\n UNIVERSIDAD JOHNNY CALITO FLORES \n" + "", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                encabezado.Alignment = Element.ALIGN_CENTER;
                DocumentoPensum.Add(encabezado);

                Paragraph mensaje = new Paragraph(new Phrase("\nEL INFRASCRITO DIRECTOR DEL DEPARTAMENTO \n ACADEMICO DE LA ASOCIACION DE UNIVERSIDADES ESPAÑOLAS\nCERTIFICA A:\n" +
                dgv_muestra.Rows[0].Cells["primer_nombre"].Value.ToString() + " " + dgv_muestra.Rows[0].Cells["segundo_nombre"].Value.ToString() + " " + dgv_muestra.Rows[0].Cells["primer_apellido"].Value.ToString() + " " + dgv_muestra.Rows[0].Cells["segundo_apellido"].Value.ToString() +
                "\n Carné:" + dgv_muestra.Rows[0].Cells["id_carrera"].Value.ToString() + "-" + dgv_muestra.Rows[0].Cells["anio_ingreso"].Value.ToString() + "-" + dgv_muestra.Rows[0].Cells["no_carne"].Value.ToString() + "\nEN EL CÚAL HACE CONSTAR QUE LAS SIGUIENTES ASIGNATURAS FUERÓN APROBADAS EN LA CARRERA DE:\n" + carrera,
                new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                mensaje.Alignment = Element.ALIGN_CENTER;
                DocumentoPensum.Add(mensaje);

                Paragraph titulos = new Paragraph(new Phrase("\n   CODIGO      CURSO              ESTADO \n" + "", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                titulos.Alignment = Element.ALIGN_LEFT;
                DocumentoPensum.Add(titulos);



                for (int control = 0; control < dgv_muestra.Rows.Count - 1; control++)// CICLO FOR QUE VA A RECORRER EL DATA GRIED PARA LEER LOS DATOS Y ENVIARLOS AL PDF, SE VAN A LIMPIAR LAS VARIABLES EN CADA CICLO PARA REUTILIZARLAS
                {
                    Paragraph cursosaprobados = new Paragraph(new Phrase("\n    " + dgv_muestra.Rows[control].Cells["codigo_curso"].Value.ToString() + "      " + dgv_muestra.Rows[control].Cells["nombre_curso"].Value.ToString() + "         " + dgv_muestra.Rows[control].Cells["nota"].Value.ToString(), formatocuerpo));
                    cursosaprobados.Alignment = Element.ALIGN_LEFT;
                    DocumentoPensum.Add(cursosaprobados);

                }


                DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios  cambios

                System.Diagnostics.Process.Start(ruta); // el documento PDF se ejecuta automaticamente para que no se haga el doble cli
        }
            catch
            {
                DocumentoPensum.Close();
                MessageBox.Show("No hay datos del alumno a certificar");    
            }
}

        private void form_CertificacionDeCursos_Load(object sender, EventArgs e)
        {

        }

        private void txt_uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_VistaPrevia.PerformClick();
            }

        }
    }
}
