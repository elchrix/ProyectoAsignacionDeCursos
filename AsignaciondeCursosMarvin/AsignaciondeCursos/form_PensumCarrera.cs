using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AsignaciondeCursos
{
    public partial class form_PensumCarrera : Form
    {
        public form_PensumCarrera()
        {
            InitializeComponent();
        }

        String id_facultad;
        String id_carrera;
        String anio_pensum;

        private void btn_conexion_Click(object sender, EventArgs e)
        {
            Conexion conec = new Conexion();
            MessageBox.Show("Exito!");
        }

        private void form_PensumCarrera_Load(object sender, EventArgs e)
        {// CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE FACULTAD
            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Facultad",conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            adap.Fill(cargadt);
            cbo_facultad.DataSource = cargadt;
            cbo_facultad.DisplayMember = "nombre_facultad";
            cbo_facultad.ValueMember = "id_facultad";

        }

        private void cbo_facultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGA DEL PRIMER COMBO BOX, QUE ES COMBO BOX DE CARRERA
            cbo_facultad.DisplayMember = "nombre_facultad";
            cbo_facultad.ValueMember = "id_facultad";

            id_facultad = cbo_facultad.SelectedValue.ToString().Trim();

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Carrera where id_facultad ="+ id_facultad,conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(cargadt);

            cbo_carrera.DataSource = cargadt;
            cbo_carrera.DisplayMember = "nombre_carrera";
            cbo_carrera.ValueMember = "id_carrera";




        }

        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_carrera.DisplayMember = "nombre_carrera";
            cbo_carrera.ValueMember = "id_carrera";

            id_carrera = cbo_carrera.SelectedValue.ToString().Trim();

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from Pensum where id_carrera="+ id_carrera,conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            adap.Fill(dt);
            //dgv_pensum.DataSource = dt;
            cbo_pensum.DataSource = dt;
            cbo_pensum.DisplayMember = "anio_pensum";
            cbo_pensum.ValueMember = "anio_pensum";
            
        }

        private void cbo_pensum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_pensum.DisplayMember = "anio_pensum";
            cbo_pensum.ValueMember = "anio_pensum";

            anio_pensum = cbo_pensum.SelectedValue.ToString().Trim();
            id_carrera = cbo_carrera.SelectedValue.ToString().Trim();


            MySqlConnection conn = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select id_carrera,nombre_curso,codigo_curso,no_ciclo,no_creditos,prerrequisitos from Curso where id_carrera='"+id_carrera+"'and anio_pensum='"+ anio_pensum+"'" ,conn);
            MySqlDataAdapter adapp = new MySqlDataAdapter(cmd);

            adapp.Fill(dt);
            dgv_pensum.DataSource = dt;
            
        }

        private void btn_GenerarPensumPdf_Click(object sender, EventArgs e)
        {
            
            int contador = 0;
            

            try
            {
                String ruta = @"C:\Users\Marvin\Documents\PensumsGenerados";

                Document DocumentoPensum = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
                PdfWriter nombre_doc = PdfWriter.GetInstance(DocumentoPensum, new FileStream(ruta + "pensum.pdf", FileMode.Create));
                DocumentoPensum.Open();

           
            
            do
            {
                    switch (contador)
                    {
                        case 0:
                            Paragraph primersem = new Paragraph(new Phrase("Primer Semestre\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                            primersem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(primersem);break;
                            
                        case 3:
                            Paragraph segundosem = new Paragraph(new Phrase("Segundo Semestre\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                            segundosem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(segundosem);break;
                            
                    }
                Paragraph titulo_decripcion_auto = new Paragraph(new Phrase("\n" + dgv_pensum.Rows[contador].Cells[1].Value.ToString() + dgv_pensum.Rows[contador].Cells[2].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                titulo_decripcion_auto.Alignment = Element.ALIGN_CENTER;
                DocumentoPensum.Add(titulo_decripcion_auto);
                contador++;
            }
            while (contador <= 29);
                    
                DocumentoPensum.Close();
                System.Diagnostics.Process.Start(ruta + "pensum.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =  dgv_pensum.Rows[0].Cells[1].Value.ToString();
            for (int i=1;i<=5;i++)
            {
                textBox1.Text = textBox1.Text+ dgv_pensum.Rows[i].Cells[1].Value.ToString();
            }
            /*int contador2=0;
            while (contador2 <= 30)
            {
                //string nombrecu = dgv_pensum.Rows[contador2].Cells[0].Value.ToString();

                textBox1.Text = dgv_pensum.Rows[contador2].Cells[0].Value.ToString(); 

                //contador2++;
            }*/
        }
    }
}
