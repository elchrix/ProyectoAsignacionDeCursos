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
        String id_curso;
        String id_seccion;
        String sc = "<<Seleccione un curso>>";


        private void form_ListadoAlumno_Load(object sender, EventArgs e)
        {

            // Inicializar el modo de selección de los combo box, se inicializaran de forma desabilitada para que el usuario escoja una opcion
            cbo_facultad.Enabled = false;
            cbo_carrera.Enabled = false;
            cbo_curso.Enabled = false;
            cbo_seccion.Enabled = false;

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            //MySqlCommand cmd = new MySqlCommand("select nombre_facultad, id_facultad from Facultad", conex);
            MySqlCommand cmd = new MySqlCommand("select '<<Selecione un valor>>' as nombre_facultad,-1 as id_facultad from facultad union select nombre_facultad, id_facultad from Facultad", conex);
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
               
                
                
                    // CARGA DEL segundo COMBO BOX, COMBO BOX DE CARRERA
                    cbo_facultad.DisplayMember = "nombre_facultad";
                    cbo_facultad.ValueMember = "id_facultad";

                    id_facultad = cbo_facultad.SelectedValue.ToString().Trim();

                    MySqlConnection conex = Conexion.ObtenerConexion();
                    DataTable cargadt = new DataTable();

                    //MySqlCommand cmd = new MySqlCommand("select * from Carrera where id_facultad =" + id_facultad, conex);
                    MySqlCommand cmd = new MySqlCommand("select'<<Seleccione una carrera>>' as nombre_carrera,-1 as id_carrera from carrera union select nombre_carrera,id_carrera from Carrera where id_facultad =" + id_facultad, conex);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(cargadt);

                    cbo_carrera.DataSource = cargadt;
                    cbo_carrera.DisplayMember = "nombre_carrera";
                    cbo_carrera.ValueMember = "id_carrera";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_GenerarLista_Click(object sender, EventArgs e)
        {

            try
            {
                id_carrera = cbo_carrera.SelectedValue.ToString().Trim();
                id_curso = cbo_curso.SelectedValue.ToString().Trim();
                id_seccion = cbo_seccion.SelectedValue.ToString().Trim();

                if (id_facultad != "-1" && id_carrera != "-1" && id_curso != "-1" && id_seccion != sc) // GENERA LISTADO DE ALUMNOS POR SECCION SEGUN CURSO
                {


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



                    // Encabezado 


                    DataTable matriz = ClaseReportes.DatosAlumnosPorSeccion(id_seccion, id_curso);
                    dgv_muestra.DataSource = matriz;

                    Paragraph encabezado = new Paragraph(new Phrase("\nUniversidad Complutense de Madrid\n" + cbo_facultad.Text + "\n" + cbo_carrera.Text + "\n Listado de alumnos por Curso: " + dgv_muestra.Rows[0].Cells["nombre_curso"].Value.ToString() + "\n Sección: " + dgv_muestra.Rows[0].Cells["seccion"].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    DocumentoPensum.Add(encabezado);

                    Paragraph titulos = new Paragraph(new Phrase("\n\n\n\n  Carnet      Estudiante\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                    titulos.Alignment = Element.ALIGN_JUSTIFIED;
                    DocumentoPensum.Add(titulos);


                    for (int control = 0; control < dgv_muestra.Rows.Count - 1; control++)// CICLO FOR QUE VA A RECORRER EL DATA GRIED PARA LEER LOS DATOS Y ENVIARLOS AL PDF, SE VAN A LIMPIAR LAS VARIABLES EN CADA CICLO PARA REUTILIZARLAS
                    {
                        Paragraph ciclouno = new Paragraph(new Phrase("\n " + dgv_muestra.Rows[control].Cells["id_carrera"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["anio_ingreso"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["no_carne"].Value.ToString() + "   " + dgv_muestra.Rows[control].Cells["primer_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["primer_apellido"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_apellido"].Value.ToString(), formatocuerpo));
                        ciclouno.Alignment = Element.ALIGN_JUSTIFIED;
                        DocumentoPensum.Add(ciclouno);

                    }


                    DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios

                    System.Diagnostics.Process.Start(ruta + "pensum.pdf"); // el documento PDF se ejecuta automaticamente para que no se haga el doble clic
                                                                           //}
                }






                else if (id_facultad != "-1" && id_carrera != "-1" && id_curso != "-1" && id_seccion == sc) // GENERA LISTADO DE ALUMNOS POR CURSO
                {
                    //                textBox1.Text = id_carrera;

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


                    DataTable matriz = ClaseReportes.DatosAlumnosPorCurso(id_curso);
                    dgv_muestra.DataSource = matriz;

                    Paragraph encabezado = new Paragraph(new Phrase("\nUniversidad Complutense de Madrid\n" + cbo_facultad.Text + "\n" + cbo_carrera.Text + "\n Listado de alumnos por Curso: " + dgv_muestra.Rows[0].Cells["nombre_curso"].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    DocumentoPensum.Add(encabezado);

                    Paragraph titulos = new Paragraph(new Phrase("\n\n\n\n  Carnet      Estudiante\n\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                    titulos.Alignment = Element.ALIGN_JUSTIFIED;
                    DocumentoPensum.Add(titulos);


                    for (int control = 0; control < dgv_muestra.Rows.Count - 1; control++)// CICLO FOR QUE VA A RECORRER EL DATA GRIED PARA LEER LOS DATOS Y ENVIARLOS AL PDF, SE VAN A LIMPIAR LAS VARIABLES EN CADA CICLO PARA REUTILIZARLAS
                    {
                        Paragraph ciclouno = new Paragraph(new Phrase("\n " + dgv_muestra.Rows[control].Cells["id_carrera"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["anio_ingreso"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["no_carne"].Value.ToString() + "   " + dgv_muestra.Rows[control].Cells["primer_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["primer_apellido"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_apellido"].Value.ToString(), formatocuerpo));
                        ciclouno.Alignment = Element.ALIGN_JUSTIFIED;
                        DocumentoPensum.Add(ciclouno);

                    }


                    DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios

                    System.Diagnostics.Process.Start(ruta + "pensum.pdf"); // el documento PDF se ejecuta automaticamente para que no se haga el doble clic

                }



                // GENERA LISTADO DE ALUMNOS POR CARRERA
                else if (id_facultad != "-1" && id_carrera != "-1" && id_curso == "-1" && id_seccion == sc)
                {
                    //                textBox1.Text = id_carrera;

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
                    Paragraph encabezado = new Paragraph(new Phrase("\nUniversidad Complutense de Madrid\n" + "Listado de alumnos por carrera \n" + cbo_facultad.Text + "\n" + cbo_carrera.Text, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    DocumentoPensum.Add(encabezado);

                    Paragraph titulos = new Paragraph(new Phrase("\n\n\n\n  Carnet      Estudiante", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 13f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                    titulos.Alignment = Element.ALIGN_JUSTIFIED;
                    DocumentoPensum.Add(titulos);

                    DataTable matriz = ClaseReportes.DatosAlumnoPorCarrea(id_carrera);
                    dgv_muestra.DataSource = matriz;

                    for (int control = 0; control < dgv_muestra.Rows.Count - 1; control++)// CICLO FOR QUE VA A RECORRER EL DATA GRIED PARA LEER LOS DATOS Y ENVIARLOS AL PDF, SE VAN A LIMPIAR LAS VARIABLES EN CADA CICLO PARA REUTILIZARLAS
                    {
                        Paragraph ciclouno = new Paragraph(new Phrase("\n " + dgv_muestra.Rows[control].Cells["id_carrera"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["anio_ingreso"].Value.ToString() + "-" + dgv_muestra.Rows[control].Cells["no_carne"].Value.ToString() + "   " + dgv_muestra.Rows[control].Cells["primer_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_nombre"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["primer_apellido"].Value.ToString() + " " + dgv_muestra.Rows[control].Cells["segundo_apellido"].Value.ToString(), formatocuerpo));
                        ciclouno.Alignment = Element.ALIGN_JUSTIFIED;
                        DocumentoPensum.Add(ciclouno);

                    }


                    DocumentoPensum.Close(); // se cierra el documento una ves realizados los cambios

                    System.Diagnostics.Process.Start(ruta + "pensum.pdf"); // el documento PDF se ejecuta automaticamente para que no se haga el doble clic
                                                                           //}
                }

                else
                {
                    MessageBox.Show("Uno o más campos están vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void cbo_carrera_SelectedIndexChanged(object sender, EventArgs e)// AQUI ESTOY!!!!!!!!!!!!
        {
            


                // CARGA DEL tercer COMBO BOX, COMBO BOX DE CURSOS SEGUN CARRERA ASIGNADA
                cbo_carrera.DisplayMember = "nombre_carrera";
                cbo_carrera.ValueMember = "id_carrera";

                id_carrera = cbo_carrera.SelectedValue.ToString().Trim();

                MySqlConnection conex = Conexion.ObtenerConexion();
                DataTable cargadt = new DataTable();

                //MySqlCommand cmd = new MySqlCommand("select * from curso where id_carrera =" + id_carrera, conex);
                MySqlCommand cmd = new MySqlCommand("select'<<Seleccione un curso>>' as nombre_curso,-1 as codigo_curso from curso union select nombre_curso,codigo_curso from curso where id_carrera =" + id_carrera, conex);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(cargadt);

                cbo_curso.DataSource = cargadt;
                cbo_curso.DisplayMember = "nombre_curso";
                cbo_curso.ValueMember = "codigo_curso";

            
            
        }


        private void rdb_ListaPorCarrera_CheckedChanged(object sender, EventArgs e)
        {// HABILITARÁ LOS COMBO BOX DE FACULTAD Y CARRERA, LOS DEMÁS ESTAN DESHABILITADOS
            cbo_facultad.Enabled = true;
            cbo_carrera.Enabled = true;

            cbo_curso.Enabled = false;
            cbo_seccion.Enabled = false;

            cbo_curso.SelectedValue = "-1";

        }

        private void cbo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGA DEL cuarto COMBO BOX, COMBO BOX DE seccion SEGUN curso seleccionado
            cbo_curso.DisplayMember = "nombre_curso";
            cbo_curso.ValueMember = "codigo_curso";

            id_curso = cbo_curso.SelectedValue.ToString().Trim();

            MySqlConnection conex = Conexion.ObtenerConexion();
            DataTable cargadt = new DataTable();

            
            MySqlCommand cmd = new MySqlCommand("select'<<Seleccione un curso>>' as seccion,-1 as seccion from cursos_recibidos union select seccion, anio from cursos_recibidos where codigo_curso =" + id_curso, conex);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(cargadt);

            cbo_seccion.DataSource = cargadt;
            cbo_seccion.DisplayMember = "seccion";
            cbo_seccion.ValueMember = "seccion";

        }

        private void rdb_ListaPorCurso_CheckedChanged(object sender, EventArgs e)
        {// HABILITARÁ LOS COMBO BOX DE FACULTAD, CARRERA, CURSO, LOS DEMÁS ESTAN DESHABILITADOS
            cbo_facultad.Enabled = true;
            cbo_carrera.Enabled = true;
            cbo_curso.Enabled = true;

            cbo_seccion.Enabled = false;
            cbo_seccion.SelectedValue = sc;
        }

        private void rdb_ListaPorSeccion_CheckedChanged(object sender, EventArgs e)
        {// HABILITARÁ TODOS LOS COMBO BOX 
            cbo_facultad.Enabled = true;
            cbo_carrera.Enabled = true;
            cbo_curso.Enabled = true;
            cbo_seccion.Enabled = true;
        }
    }
}
