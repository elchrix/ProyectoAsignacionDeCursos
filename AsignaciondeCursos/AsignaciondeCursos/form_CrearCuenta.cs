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
    public partial class form_CrearCuenta : Form
    {
        public form_CrearCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_usuario.Text))
            {
                String usuario = txt_usuario.Text;
                if (!String.IsNullOrEmpty(txt_contraseña.Text)) {

                    if (txt_contraseña.Text != txt_rep_contra.Text)
                    {
                        MessageBox.Show("Contraseñas no coinciden");
                    }
                    else {
                        MantenimientosManejo.UsuarioAgregar(usuario, txt_contraseña.Text.Trim(),"administrativo");
                        MessageBox.Show("contraseña creada con exito");
                    }
                }
                else { MessageBox.Show("debe ingresar una contraseña"); }

            } else { MessageBox.Show("Ingrese un usuario valido"); }
            }
        }
    }

