﻿using System;
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
    public partial class form_EdificioSalon : Form
    {
        public form_EdificioSalon()
        {
            InitializeComponent();
        }

        private void Btn_ingresaredificio_Click(object sender, EventArgs e)
        {
       

            int resultado = MantenimientoAgregar.EdificioAgregar(txt_idedificio.Text,txt_pisos.Text,txt_tamanio.Text,txt_cantsalones.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Edificio Agregado Exitosamente");        
            }
            else
            {
                MessageBox.Show("No se pudo agregar el edificio");
            }
        }

        private void form_EdificioSalon_Load(object sender, EventArgs e)
        {
            MantenimientoAgregar mantenimiento = new MantenimientoAgregar();
            mantenimiento.llenar_idificio(cbo_edificio);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int resultado = MantenimientoAgregar.agregarsalon(txt_no_salon.Text, cbo_edificio.SelectedItem.ToString(), txt_tamanio.Text ,txt_cantsalones.Text,cboestatus.SelectedItem.ToString());
            if (resultado > 0)
            {
                MessageBox.Show("Salon Agregado Exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el salon");
            }
        }

    }
}