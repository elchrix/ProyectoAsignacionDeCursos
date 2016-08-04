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
    public partial class form_AsignarAlumno : Form
    {
        public form_AsignarAlumno()
        {
            InitializeComponent();
        }

        int iCont = 1;

        private void form_AsignarAlumno_Load(object sender, EventArgs e)
        {
            cbo_semestre.SelectedIndex = 0;
            //cbo_año.SelectedIndex = 0;
        }

        private void txt_carne_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
                String sCarrera = txt_carrera.Text.Trim();
                String sAño = txt_año.Text.Trim();
                String sCarne = txt_carne.Text.Trim();

                MySqlConnection con = Conexion.ObtenerConexion();

                //OBTENER NOMBRE, DIRECCION Y CORREO DEL ALUMNO:
                    DataTable dt = new DataTable();
                    string query = "select primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, direccion, correo_electronico" +
                        " from Alumno where id_carrera = '" + sCarrera + "' and año_ingreso = '" + sAño + "' and no_carne = '" + sCarne + "'";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
         
                adaptador.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                DataRow fila1 = dt.Rows[0];
                lbl_nombre.Text = fila1[0].ToString() + " " + fila1[1].ToString() + " " + fila1[2].ToString() + " " + fila1[3].ToString();
                lbl_direccion.Text = fila1[4].ToString();
                lbl_correo.Text = fila1[5].ToString();

                //OBTENER CARRERA Y FACULTAD DEL ALUMNO:

                dt.Reset();
                String query_carrera = "select nombre_carrera from Carrera where id_carrera = '" + sCarrera + "'";
                MySqlCommand comando_carrera = new MySqlCommand(query_carrera, con);
                MySqlDataAdapter adaptador_carrera = new MySqlDataAdapter(comando_carrera);
                adaptador_carrera.Fill(dt);
                fila1 = dt.Rows[0];
                lbl_carrera.Text = fila1[0].ToString();

                dt.Reset();
                String query_facu_id = "select id_facultad from Carrera where id_carrera = '" + sCarrera + "'";
                MySqlCommand comando_facu_id = new MySqlCommand(query_facu_id, con);
                MySqlDataAdapter adaptador_facu_id = new MySqlDataAdapter(comando_facu_id);
                adaptador_facu_id.Fill(dt);
                fila1 = dt.Rows[0];
                String facu_id = fila1[0].ToString();
                dt.Reset();
                String query_facu_nom = "select nombre_facultad from Facultad where id_facultad = '" + facu_id + "'";
                MySqlCommand comando_facu_nom = new MySqlCommand(query_facu_nom, con);
                MySqlDataAdapter adaptador_facu_nom = new MySqlDataAdapter(comando_facu_nom);
                adaptador_facu_nom.Fill(dt);
                fila1 = dt.Rows[0];
                lbl_facultad.Text = fila1[0].ToString();


                //OBTENER CURSOS DISPONIBLES PARA EL ALUMNO
                DataTable dt_CursosAprobados = AsignacionesManejo.ObtenerCursosAprobados(sCarrera, sAño, sCarne);
                if (dt_CursosAprobados.Rows.Count != 0)
                {
                    DataTable dt_CursosDisponibles = AsignacionesManejo.ObtenerCursosDisponibles(dt_CursosAprobados);

                    //IMPRIMIR CURSOS DISPONIBLES
                    ImprimirCursos(dt_CursosDisponibles);
                }
                else {
                    dt.Reset();
                    String sQuery2 = "select id_carrera, anio_pensum" +
                         " from  Alumno where id_carrera = '" + sCarrera + "' and año_ingreso = '" + sAño + "' and no_carne = '" + sCarne + "'";
                    MySqlCommand comando2 = new MySqlCommand(sQuery2, con);
                    MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
                    adaptador2.Fill(dt);
                    fila1 = dt.Rows[0];
                   

                   DataTable dt_PrimerosCursos = AsignacionesManejo.ObtenerPrimerosCursos(fila1[0].ToString().Trim(), fila1[1].ToString().Trim());
                    ImprimirCursos(dt_PrimerosCursos);
                    }
            }

                con.Close();
        //}
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
}



        private void ImprimirCursos(DataTable dt_CursosDisponibles)
        {
            foreach (DataRow fila in dt_CursosDisponibles.Rows)
            {
                if (fila[1].ToString() != "xx")
                {


                    switch (iCont)
                    {
                        case 1:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod1.Visible = true;
                                    lbl_cod1.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur1.Visible = true;
                                    lbl_cur1.Text = fila[3].ToString().Trim();
                                    lbl_ciclo1.Visible = true;
                                    lbl_ciclo1.Text = fila[2].ToString().Trim();
                                    cbo_jor1.Visible = true;
                                    cbo_sec1.Visible = true;
                                    chb_asignar1.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod1.Visible = true;
                                    lbl_cod1.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur1.Visible = true;
                                    lbl_cur1.Text = fila[3].ToString().Trim();
                                    lbl_ciclo1.Visible = true;
                                    lbl_ciclo1.Text = fila[2].ToString().Trim();
                                    cbo_jor1.Visible = true;
                                    cbo_sec1.Visible = true;
                                    chb_asignar1.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 2:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod2.Visible = true;
                                    lbl_cod2.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur2.Visible = true;
                                    lbl_cur2.Text = fila[3].ToString().Trim();
                                    lbl_ciclo2.Visible = true;
                                    lbl_ciclo2.Text = fila[2].ToString().Trim();
                                    cbo_jor2.Visible = true;
                                    cbo_sec2.Visible = true;
                                    chb_asignar2.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod2.Visible = true;
                                    lbl_cod2.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur2.Visible = true;
                                    lbl_cur2.Text = fila[3].ToString().Trim();
                                    lbl_ciclo2.Visible = true;
                                    lbl_ciclo2.Text = fila[2].ToString().Trim();
                                    cbo_jor2.Visible = true;
                                    cbo_sec2.Visible = true;
                                    chb_asignar2.Visible = true;
                                    iCont++;
                                }

                            }


                            break;

                        case 3:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod3.Visible = true;
                                    lbl_cod3.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur3.Visible = true;
                                    lbl_cur3.Text = fila[3].ToString().Trim();
                                    lbl_ciclo3.Visible = true;
                                    lbl_ciclo3.Text = fila[2].ToString().Trim();
                                    cbo_jor3.Visible = true;
                                    cbo_sec3.Visible = true;
                                    chb_asignar3.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod3.Visible = true;
                                    lbl_cod3.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur3.Visible = true;
                                    lbl_cur3.Text = fila[3].ToString().Trim();
                                    lbl_ciclo3.Visible = true;
                                    lbl_ciclo3.Text = fila[2].ToString().Trim();
                                    cbo_jor3.Visible = true;
                                    cbo_sec3.Visible = true;
                                    chb_asignar3.Visible = true;
                                    iCont++;
                                }

                            }



                            break;
                        case 4:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod4.Visible = true;
                                    lbl_cod4.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur4.Visible = true;
                                    lbl_cur4.Text = fila[3].ToString().Trim();
                                    lbl_ciclo4.Visible = true;
                                    lbl_ciclo4.Text = fila[2].ToString().Trim();
                                    cbo_jor4.Visible = true;
                                    cbo_sec4.Visible = true;
                                    chb_asignar4.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod4.Visible = true;
                                    lbl_cod4.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur4.Visible = true;
                                    lbl_cur4.Text = fila[3].ToString().Trim();
                                    lbl_ciclo4.Visible = true;
                                    lbl_ciclo4.Text = fila[2].ToString().Trim();
                                    cbo_jor4.Visible = true;
                                    cbo_sec4.Visible = true;
                                    chb_asignar4.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 5:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod5.Visible = true;
                                    lbl_cod5.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur5.Visible = true;
                                    lbl_cur5.Text = fila[3].ToString().Trim();
                                    lbl_ciclo5.Visible = true;
                                    lbl_ciclo5.Text = fila[2].ToString().Trim();
                                    cbo_jor5.Visible = true;
                                    cbo_sec5.Visible = true;
                                    chb_asignar5.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod5.Visible = true;
                                    lbl_cod5.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur5.Visible = true;
                                    lbl_cur5.Text = fila[3].ToString().Trim();
                                    lbl_ciclo5.Visible = true;
                                    lbl_ciclo5.Text = fila[2].ToString().Trim();
                                    cbo_jor5.Visible = true;
                                    cbo_sec5.Visible = true;
                                    chb_asignar5.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 6:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod6.Visible = true;
                                    lbl_cod6.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur6.Visible = true;
                                    lbl_cur6.Text = fila[3].ToString().Trim();
                                    lbl_ciclo6.Visible = true;
                                    lbl_ciclo6.Text = fila[2].ToString().Trim();
                                    cbo_jor6.Visible = true;
                                    cbo_sec6.Visible = true;
                                    chb_asignar6.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod6.Visible = true;
                                    lbl_cod6.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur6.Visible = true;
                                    lbl_cur6.Text = fila[3].ToString().Trim();
                                    lbl_ciclo6.Visible = true;
                                    lbl_ciclo6.Text = fila[2].ToString().Trim();
                                    cbo_jor6.Visible = true;
                                    cbo_sec6.Visible = true;
                                    chb_asignar6.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 7:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod7.Visible = true;
                                    lbl_cod7.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur7.Visible = true;
                                    lbl_cur7.Text = fila[3].ToString().Trim();
                                    lbl_ciclo7.Visible = true;
                                    lbl_ciclo7.Text = fila[2].ToString().Trim();
                                    cbo_jor7.Visible = true;
                                    cbo_sec7.Visible = true;
                                    chb_asignar7.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod7.Visible = true;
                                    lbl_cod7.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur7.Visible = true;
                                    lbl_cur7.Text = fila[3].ToString().Trim();
                                    lbl_ciclo7.Visible = true;
                                    lbl_ciclo7.Text = fila[2].ToString().Trim();
                                    cbo_jor7.Visible = true;
                                    cbo_sec7.Visible = true;
                                    chb_asignar7.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 8:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod8.Visible = true;
                                    lbl_cod8.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur8.Visible = true;
                                    lbl_cur8.Text = fila[3].ToString().Trim();
                                    lbl_ciclo8.Visible = true;
                                    lbl_ciclo8.Text = fila[2].ToString().Trim();
                                    cbo_jor8.Visible = true;
                                    cbo_sec8.Visible = true;
                                    chb_asignar8.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod8.Visible = true;
                                    lbl_cod8.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur8.Visible = true;
                                    lbl_cur8.Text = fila[3].ToString().Trim();
                                    lbl_ciclo8.Visible = true;
                                    lbl_ciclo8.Text = fila[2].ToString().Trim();
                                    cbo_jor8.Visible = true;
                                    cbo_sec8.Visible = true;
                                    chb_asignar8.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 9:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod9.Visible = true;
                                    lbl_cod9.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur9.Visible = true;
                                    lbl_cur9.Text = fila[3].ToString().Trim();
                                    lbl_ciclo9.Visible = true;
                                    lbl_ciclo9.Text = fila[2].ToString().Trim();
                                    cbo_jor9.Visible = true;
                                    cbo_sec9.Visible = true;
                                    chb_asignar9.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod9.Visible = true;
                                    lbl_cod9.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur9.Visible = true;
                                    lbl_cur9.Text = fila[3].ToString().Trim();
                                    lbl_ciclo9.Visible = true;
                                    lbl_ciclo9.Text = fila[2].ToString().Trim();
                                    cbo_jor9.Visible = true;
                                    cbo_sec9.Visible = true;
                                    chb_asignar9.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                        case 10:
                            if (cbo_semestre.SelectedItem.ToString().Trim() == "1")
                            {
                                if (fila[2].ToString().Trim() == "1" || fila[2].ToString().Trim() == "3" || fila[2].ToString().Trim() == "5" || fila[2].ToString().Trim() == "7" || fila[2].ToString().Trim() == "9")
                                {
                                    lbl_cod10.Visible = true;
                                    lbl_cod10.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur10.Visible = true;
                                    lbl_cur10.Text = fila[3].ToString().Trim();
                                    lbl_ciclo10.Visible = true;
                                    lbl_ciclo10.Text = fila[2].ToString().Trim();
                                    cbo_jor10.Visible = true;
                                    cbo_sec10.Visible = true;
                                    chb_asignar10.Visible = true;
                                    iCont++;
                                }
                            }
                            else if (cbo_semestre.SelectedItem.ToString().Trim() == "2")
                            {
                                if (fila[2].ToString().Trim() == "2" || fila[2].ToString().Trim() == "4" || fila[2].ToString().Trim() == "6" || fila[2].ToString().Trim() == "8" || fila[2].ToString().Trim() == "10")
                                {
                                    lbl_cod10.Visible = true;
                                    lbl_cod10.Text = fila[0].ToString().Trim() + "-" + fila[1].ToString().Trim();
                                    lbl_cur10.Visible = true;
                                    lbl_cur10.Text = fila[3].ToString().Trim();
                                    lbl_ciclo10.Visible = true;
                                    lbl_ciclo10.Text = fila[2].ToString().Trim();
                                    cbo_jor10.Visible = true;
                                    cbo_sec10.Visible = true;
                                    chb_asignar10.Visible = true;
                                    iCont++;
                                }

                            }


                            break;
                    }

                }
            }

        }

        private void txt_carrera_MouseClick(object sender, MouseEventArgs e)
        {
            //LIMIMPAR INFO DEL ALUMNO
            txt_carrera.Text = "";
            txt_año.Text = "";
            txt_carne.Text = "";
            lbl_nombre.Text = "";
            lbl_facultad.Text = "";
            lbl_direccion.Text = "";
            lbl_correo.Text = "";
            lbl_carrera.Text = "";

            LimpiarCursos();
        }

        private void LimpiarCursos()
        {
           

            //LIMIPIAR CURSOS
            lbl_cod1.Text = "";
            lbl_cod1.Visible = false;
            lbl_cur1.Text = "";
            lbl_cur1.Visible = false;
            lbl_ciclo1.Text = "";
            lbl_ciclo1.Visible = false;
            cbo_jor1.Visible = false;
            cbo_sec1.Visible = false;
            chb_asignar1.Visible = false;

            lbl_cod2.Text = "";
            lbl_cod2.Visible = false;
            lbl_cur2.Text = "";
            lbl_cur2.Visible = false;
            lbl_ciclo2.Text = "";
            lbl_ciclo2.Visible = false;
            cbo_jor2.Visible = false;
            cbo_sec2.Visible = false;
            chb_asignar2.Visible = false;

            lbl_cod3.Text = "";
            lbl_cod3.Visible = false;
            lbl_cur3.Text = "";
            lbl_cur3.Visible = false;
            lbl_ciclo3.Text = "";
            lbl_ciclo3.Visible = false;
            cbo_jor3.Visible = false;
            cbo_sec3.Visible = false;
            chb_asignar3.Visible = false;

            lbl_cod4.Text = "";
            lbl_cod4.Visible = false;
            lbl_cur4.Text = "";
            lbl_cur4.Visible = false;
            lbl_ciclo4.Text = "";
            lbl_ciclo4.Visible = false;
            cbo_jor4.Visible = false;
            cbo_sec4.Visible = false;
            chb_asignar4.Visible = false;

            lbl_cod5.Text = "";
            lbl_cod5.Visible = false;
            lbl_cur5.Text = "";
            lbl_cur5.Visible = false;
            lbl_ciclo5.Text = "";
            lbl_ciclo5.Visible = false;
            cbo_jor5.Visible = false;
            cbo_sec5.Visible = false;
            chb_asignar5.Visible = false;

            lbl_cod6.Text = "";
            lbl_cod6.Visible = false;
            lbl_cur6.Text = "";
            lbl_cur6.Visible = false;
            lbl_ciclo6.Text = "";
            lbl_ciclo6.Visible = false;
            cbo_jor6.Visible = false;
            cbo_sec6.Visible = false;
            chb_asignar6.Visible = false;

            lbl_cod7.Text = "";
            lbl_cod7.Visible = false;
            lbl_cur7.Text = "";
            lbl_cur7.Visible = false;
            lbl_ciclo7.Text = "";
            lbl_ciclo7.Visible = false;
            cbo_jor7.Visible = false;
            cbo_sec7.Visible = false;
            chb_asignar7.Visible = false;

            lbl_cod8.Text = "";
            lbl_cod8.Visible = false;
            lbl_cur8.Text = "";
            lbl_cur8.Visible = false;
            lbl_ciclo8.Text = "";
            lbl_ciclo8.Visible = false;
            cbo_jor8.Visible = false;
            cbo_sec8.Visible = false;
            chb_asignar8.Visible = false;

            lbl_cod9.Text = "";
            lbl_cod9.Visible = false;
            lbl_cur9.Text = "";
            lbl_cur9.Visible = false;
            lbl_ciclo9.Text = "";
            lbl_ciclo9.Visible = false;
            cbo_jor9.Visible = false;
            cbo_sec9.Visible = false;
            chb_asignar9.Visible = false;

            lbl_cod10.Text = "";
            lbl_cod10.Visible = false;
            lbl_cur10.Text = "";
            lbl_cur10.Visible = false;
            lbl_ciclo10.Text = "";
            lbl_ciclo10.Visible = false;
            cbo_jor10.Visible = false;
            cbo_sec10.Visible = false;
            chb_asignar10.Visible = false;

            iCont = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_carrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarCursos();
                String sCarrera = txt_carrera.Text.Trim();
                String sAño = txt_año.Text.Trim();
                String sCarne = txt_carne.Text.Trim();
                MySqlConnection con = Conexion.ObtenerConexion();
                DataTable dt_CursosAprobados = AsignacionesManejo.ObtenerCursosAprobados(sCarrera, sAño, sCarne);

                //if (dt_CursosAprobados.Rows.Count != 0)
                //{
                //    DataTable dt_CursosDisponibles = AsignacionesManejo.ObtenerCursosDisponibles(dt_CursosAprobados);

                //    //IMPRIMIR CURSOS DISPONIBLES
                //    ImprimirCursos(dt_CursosDisponibles);
                //}
                //else
                //{
                //    DataTable dt = new DataTable();
                //    DataRow fila1;
                //    String sQuery2 = "select id_carrera, anio_pensum" +
                //         " from  Alumno where id_carrera = '" + sCarrera + "' and año_ingreso = '" + sAño + "' and no_carne = '" + sCarne + "'";
                //    MySqlCommand comando2 = new MySqlCommand(sQuery2, con);
                //    MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
                //    adaptador2.Fill(dt);
                //    fila1 = dt.Rows[0];


                //    DataTable dt_PrimerosCursos = AsignacionesManejo.ObtenerPrimerosCursos(fila1[0].ToString().Trim(), fila1[1].ToString().Trim());
                //    ImprimirCursos(dt_PrimerosCursos);
                //}

                DataTable dt_CursosDisponibles = AsignacionesManejo.ObtenerCursosDisponibles(dt_CursosAprobados);


                ImprimirCursos(dt_CursosDisponibles);
                //con.Close();
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
