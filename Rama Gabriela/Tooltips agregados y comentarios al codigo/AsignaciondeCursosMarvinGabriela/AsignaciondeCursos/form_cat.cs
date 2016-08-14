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
    public partial class form_cat : Form
    {
        public form_cat()
        {
            InitializeComponent();
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            form_historial fhist = new form_historial();
            fhist.TopLevel = false;
            fhist.FormBorderStyle = FormBorderStyle.None;
            fhist.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fhist);
            this.splitContainer1.Panel2.Tag = fhist;
            fhist.Show();
        }

        private void form_cat_Load(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void form_cat_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Form_Login fl = new Form_Login();
            fl.Show();
        }

        private void btn_cursosact_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            form_cursosact fact = new form_cursosact();
            fact.TopLevel = false;
            fact.FormBorderStyle = FormBorderStyle.None;
            fact.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fact);
            this.splitContainer1.Panel2.Tag = fact;
            fact.Show();
        }
    }
   
}
