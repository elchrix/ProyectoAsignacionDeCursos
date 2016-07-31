﻿using System;
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
using System.Diagnostics;

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
            int recorre = 0;
            String facultad ;
            dgv_pensum.Sort(dgv_pensum.Columns["codigo_curso"], ListSortDirection.Ascending);

            try
            {

                String ruta = "";
                ruta = @"C:\Users\Marvin\Documents\PensumsGenerados";

                Document DocumentoPensum = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
                PdfWriter nombre_doc = PdfWriter.GetInstance(DocumentoPensum, new FileStream(ruta + "pensum.pdf", FileMode.Create));
                DocumentoPensum.Open();
                // ---------------------- la hoja de de PDF tiene un ancho de 600 
                //------------------------ LOGO UMG 
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logo2.jpg");
                logo.SetAbsolutePosition(30f,650f);
                //logo.Alignment = Element.ALIGN_LEFT;
                logo.ScaleAbsoluteHeight(125);
                logo.ScaleAbsoluteWidth(125);

                DocumentoPensum.Add(logo);

                // Encabezado umg
                Paragraph encabezado = new Paragraph(new Phrase("\nUniversidad Complutense de Madrid\n" + cbo_facultad.Text + "\n" + cbo_carrera.Text + "\nPensum "+cbo_pensum.Text, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                encabezado.Alignment = Element.ALIGN_CENTER;
                DocumentoPensum.Add(encabezado);

                Paragraph titulos = new Paragraph(new Phrase("\n\n\n\n       Código       Curso           Créditos        Requisitos", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                titulos.Alignment = Element.ALIGN_CENTER;
                DocumentoPensum.Add(titulos);
                //String ciclo_uno = dgv_pensum.Rows[contador].Cells[3].Value.ToString();

                do
            {
                   // String ciclo_uno = dgv_pensum.Rows[contador].Cells[3].Value.ToString();

                    switch (contador)
                    {
                        case 0:
                                                       
                                Paragraph primersem = new Paragraph(new Phrase("\nPrimer Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                                primersem.Alignment = Element.ALIGN_LEFT;
                                DocumentoPensum.Add(primersem); break;
                                                                                    
                        case 3:
                            Paragraph segundosem = new Paragraph(new Phrase("\nSegundo Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            segundosem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(segundosem);break;

                        case 6:
                            Paragraph tercersem = new Paragraph(new Phrase("\nTercer Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            tercersem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(tercersem); break;

                        case 9:
                            Paragraph cuartosem = new Paragraph(new Phrase("\nCuarto Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            cuartosem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(cuartosem); break;

                        case 12:
                            Paragraph quinsem = new Paragraph(new Phrase("\nQuinto Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            quinsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(quinsem); break;

                        case 15:
                            Paragraph sexsem = new Paragraph(new Phrase("\nSexto Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            sexsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(sexsem); break;

                        case 18:
                            Paragraph septsem = new Paragraph(new Phrase("\nSeptimo Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            septsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(septsem); break;

                        case 21:
                            Paragraph octsem = new Paragraph(new Phrase("\nOctavo Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            octsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(octsem); break;

                        case 24:
                            Paragraph novsem = new Paragraph(new Phrase("\nNoveno Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            novsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(novsem); break;

                        case 27:
                            Paragraph decsem = new Paragraph(new Phrase("\nDecimo Semestre", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                            decsem.Alignment = Element.ALIGN_LEFT;
                            DocumentoPensum.Add(decsem); break;
                    }

                    // Parrafo con los campos de los cursos de la carrera seleccioada

                Paragraph titulo_decripcion_auto = new Paragraph(new Phrase("\n                   "+dgv_pensum.Rows[contador].Cells[2].Value.ToString().Trim()+"         "+dgv_pensum.Rows[contador].Cells[1].Value.ToString().Trim()+"                "+dgv_pensum.Rows[contador].Cells[4].Value.ToString().Trim()+"            "+dgv_pensum.Rows[contador].Cells[5].Value.ToString() , new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                titulo_decripcion_auto.Alignment = Element.ALIGN_LEFT;
                DocumentoPensum.Add(titulo_decripcion_auto);
                contador++;
            }
            while (contador < dgv_pensum.Rows.Count);
                    
                DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios

                /*foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == ruta + "pensum.pdf") ;
                    {
                        proceso.Kill();
                    }

                }*/

                System.Diagnostics.Process.Start(ruta + "pensum.pdf"); // el documento PDF se ejecuta automaticamente para que no se haga el doble cli
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
               

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*int selectedIndex = cbo_facultad.SelectedIndex;
            int selectedItem = cbo_facultad.SelectedIndexChanged;

            MessageBox.Show("Item seleccionado: " +selectedItem.ToString()+"\n"+"Index: "+selectedIndex.ToString());*/
            //textBox1.Text = cbo_facultad.Text;

            
            
                Int32 i;
                String celda;
                DataGridViewCell dgc;
                //Recorremos el DataGridView con un bucle for 
                for (i = 0; i < dgv_pensum.Rows.Count; i++)
                {
                    /*dgc = dgv_pensum.Rows[i].Cells[0];
                    celda = ((String)dgc.Value) + "\r\n";
                    textBox1.Text += celda.Replace(".", ",");*/
                }
                MessageBox.Show("numero de columnas" + i);
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dgv_pensum.Sort(dgv_pensum.Rows(1), ListSortDirection.Ascending);
            dgv_pensum.Sort(dgv_pensum.Columns["codigo_curso"], ListSortDirection.Ascending);

        }
    }
}