namespace AsignaciondeCursos
{
    partial class Form_Administrativo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Administrativo));
            this.spc_principal = new System.Windows.Forms.SplitContainer();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.Barra_de_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_asignar_alumno = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_asignar_catedratico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_mant_alumno = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_cursos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_cated = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_carrera = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_facu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_pensum = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_edificio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mant_salon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_cambiar_contra = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_crearcuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cerrar_sesion = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_repo_cert = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rep_alum = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rep_pensum = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).BeginInit();
            this.spc_principal.Panel1.SuspendLayout();
            this.spc_principal.SuspendLayout();
            this.Barra_de_menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc_principal
            // 
            this.spc_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_principal.IsSplitterFixed = true;
            this.spc_principal.Location = new System.Drawing.Point(0, 0);
            this.spc_principal.Name = "spc_principal";
            this.spc_principal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_principal.Panel1
            // 
            this.spc_principal.Panel1.Controls.Add(this.linkLabel12);
            this.spc_principal.Panel1.Controls.Add(this.Barra_de_menus);
            this.spc_principal.Size = new System.Drawing.Size(886, 555);
            this.spc_principal.SplitterDistance = 25;
            this.spc_principal.TabIndex = 0;
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(704, 9);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(46, 13);
            this.linkLabel12.TabIndex = 9;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Bitácora";
            this.linkLabel12.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel12_LinkClicked);
            // 
            // Barra_de_menus
            // 
            this.Barra_de_menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4});
            this.Barra_de_menus.Location = new System.Drawing.Point(0, 0);
            this.Barra_de_menus.Name = "Barra_de_menus";
            this.Barra_de_menus.Size = new System.Drawing.Size(886, 25);
            this.Barra_de_menus.TabIndex = 0;
            this.Barra_de_menus.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_asignar_alumno,
            this.btn_asignar_catedratico});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 22);
            this.toolStripDropDownButton1.Text = "Asignaciones";
            // 
            // btn_asignar_alumno
            // 
            this.btn_asignar_alumno.Name = "btn_asignar_alumno";
            this.btn_asignar_alumno.Size = new System.Drawing.Size(178, 22);
            this.btn_asignar_alumno.Text = "Asignar Alumno";
            this.btn_asignar_alumno.Click += new System.EventHandler(this.btn_asignar_alumno_Click);
            // 
            // btn_asignar_catedratico
            // 
            this.btn_asignar_catedratico.Name = "btn_asignar_catedratico";
            this.btn_asignar_catedratico.Size = new System.Drawing.Size(178, 22);
            this.btn_asignar_catedratico.Text = "Asignar Catedrático";
            this.btn_asignar_catedratico.Click += new System.EventHandler(this.btn_asignar_catedratico_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_mant_alumno,
            this.btn_mant_cursos,
            this.btn_mant_cated,
            this.btn_mant_carrera,
            this.btn_mant_facu,
            this.btn_mant_pensum,
            this.btn_mant_edificio,
            this.btn_mant_salon});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(107, 22);
            this.toolStripDropDownButton2.Text = "Mantenimientos";
            // 
            // btn_mant_alumno
            // 
            this.btn_mant_alumno.Name = "btn_mant_alumno";
            this.btn_mant_alumno.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_alumno.Text = "Alumno";
            this.btn_mant_alumno.Click += new System.EventHandler(this.btn_mant_alumno_Click);
            // 
            // btn_mant_cursos
            // 
            this.btn_mant_cursos.Name = "btn_mant_cursos";
            this.btn_mant_cursos.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_cursos.Text = "Cursos";
            this.btn_mant_cursos.Click += new System.EventHandler(this.btn_mant_cursos_Click);
            // 
            // btn_mant_cated
            // 
            this.btn_mant_cated.Name = "btn_mant_cated";
            this.btn_mant_cated.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_cated.Text = "Catedrático";
            this.btn_mant_cated.Click += new System.EventHandler(this.btn_mant_cated_Click);
            // 
            // btn_mant_carrera
            // 
            this.btn_mant_carrera.Name = "btn_mant_carrera";
            this.btn_mant_carrera.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_carrera.Text = "Carrera";
            this.btn_mant_carrera.Click += new System.EventHandler(this.btn_mant_carrera_Click);
            // 
            // btn_mant_facu
            // 
            this.btn_mant_facu.Name = "btn_mant_facu";
            this.btn_mant_facu.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_facu.Text = "Facultad";
            this.btn_mant_facu.Click += new System.EventHandler(this.btn_mant_facu_Click);
            // 
            // btn_mant_pensum
            // 
            this.btn_mant_pensum.Name = "btn_mant_pensum";
            this.btn_mant_pensum.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_pensum.Text = "Pensum";
            this.btn_mant_pensum.Click += new System.EventHandler(this.btn_mant_pensum_Click);
            // 
            // btn_mant_edificio
            // 
            this.btn_mant_edificio.Name = "btn_mant_edificio";
            this.btn_mant_edificio.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_edificio.Text = "Edificio";
            this.btn_mant_edificio.Click += new System.EventHandler(this.btn_mant_edificio_Click);
            // 
            // btn_mant_salon
            // 
            this.btn_mant_salon.Name = "btn_mant_salon";
            this.btn_mant_salon.Size = new System.Drawing.Size(135, 22);
            this.btn_mant_salon.Text = "Salón";
            this.btn_mant_salon.Click += new System.EventHandler(this.btn_mant_salon_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_repo_cert,
            this.btn_rep_alum,
            this.btn_rep_pensum});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "Reportes";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cambiar_contra,
            this.btn_crearcuenta,
            this.btn_cerrar_sesion});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton4.Text = "Cuentas";
            // 
            // btn_cambiar_contra
            // 
            this.btn_cambiar_contra.Name = "btn_cambiar_contra";
            this.btn_cambiar_contra.Size = new System.Drawing.Size(180, 22);
            this.btn_cambiar_contra.Text = "Cambiar contraseña";
            this.btn_cambiar_contra.Click += new System.EventHandler(this.btn_cambiar_contra_Click);
            // 
            // btn_crearcuenta
            // 
            this.btn_crearcuenta.Name = "btn_crearcuenta";
            this.btn_crearcuenta.Size = new System.Drawing.Size(180, 22);
            this.btn_crearcuenta.Text = "Crear cuenta nueva";
            this.btn_crearcuenta.Click += new System.EventHandler(this.btn_crearcuenta_Click);
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(180, 22);
            this.btn_cerrar_sesion.Text = "Cerrar sesión";
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_repo_cert
            // 
            this.btn_repo_cert.Name = "btn_repo_cert";
            this.btn_repo_cert.Size = new System.Drawing.Size(194, 22);
            this.btn_repo_cert.Text = "Certificacion de cursos";
            this.btn_repo_cert.Click += new System.EventHandler(this.btn_repo_cert_Click);
            // 
            // btn_rep_alum
            // 
            this.btn_rep_alum.Name = "btn_rep_alum";
            this.btn_rep_alum.Size = new System.Drawing.Size(194, 22);
            this.btn_rep_alum.Text = "Alumnos por sección";
            this.btn_rep_alum.Click += new System.EventHandler(this.btn_rep_alum_Click);
            // 
            // btn_rep_pensum
            // 
            this.btn_rep_pensum.Name = "btn_rep_pensum";
            this.btn_rep_pensum.Size = new System.Drawing.Size(194, 22);
            this.btn_rep_pensum.Text = "Pensum";
            this.btn_rep_pensum.Click += new System.EventHandler(this.btn_rep_pensum_Click);
            // 
            // Form_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 555);
            this.Controls.Add(this.spc_principal);
            this.Name = "Form_Administrativo";
            this.Text = "Pantalla principal - Administrativo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Administrativo_FormClosed);
            this.Load += new System.EventHandler(this.Form_Administrativo_Load);
            this.spc_principal.Panel1.ResumeLayout(false);
            this.spc_principal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).EndInit();
            this.spc_principal.ResumeLayout(false);
            this.Barra_de_menus.ResumeLayout(false);
            this.Barra_de_menus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_principal;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.ToolStrip Barra_de_menus;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btn_asignar_alumno;
        private System.Windows.Forms.ToolStripMenuItem btn_asignar_catedratico;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_alumno;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_cursos;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_cated;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_carrera;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_facu;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_pensum;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_edificio;
        private System.Windows.Forms.ToolStripMenuItem btn_mant_salon;
        private System.Windows.Forms.ToolStripMenuItem btn_cambiar_contra;
        private System.Windows.Forms.ToolStripMenuItem btn_crearcuenta;
        private System.Windows.Forms.ToolStripMenuItem btn_cerrar_sesion;
        private System.Windows.Forms.ToolStripMenuItem btn_repo_cert;
        private System.Windows.Forms.ToolStripMenuItem btn_rep_alum;
        private System.Windows.Forms.ToolStripMenuItem btn_rep_pensum;
    }
}

