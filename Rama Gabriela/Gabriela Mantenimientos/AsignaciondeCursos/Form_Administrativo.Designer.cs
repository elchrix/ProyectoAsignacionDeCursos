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
            this.spc_principal = new System.Windows.Forms.SplitContainer();
            this.llbl_logout = new System.Windows.Forms.LinkLabel();
            this.spc_reportes = new System.Windows.Forms.SplitContainer();
            this.btn_MenuReportes = new System.Windows.Forms.Button();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.spc_ingresos = new System.Windows.Forms.SplitContainer();
            this.btn_MenuIngresos = new System.Windows.Forms.Button();
            this.llbl_ingresarcatedratico = new System.Windows.Forms.LinkLabel();
            this.llbl_ingresaralumno = new System.Windows.Forms.LinkLabel();
            this.llbl_ingresarcurso = new System.Windows.Forms.LinkLabel();
            this.llbl_carrfacupensum = new System.Windows.Forms.LinkLabel();
            this.llbl_salon = new System.Windows.Forms.LinkLabel();
            this.spc_asignaciones = new System.Windows.Forms.SplitContainer();
            this.btn_MenuAsig = new System.Windows.Forms.Button();
            this.llbl_AsignarCatedratico = new System.Windows.Forms.LinkLabel();
            this.llbl_AsignarAlumno = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).BeginInit();
            this.spc_principal.Panel1.SuspendLayout();
            this.spc_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_reportes)).BeginInit();
            this.spc_reportes.Panel1.SuspendLayout();
            this.spc_reportes.Panel2.SuspendLayout();
            this.spc_reportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_ingresos)).BeginInit();
            this.spc_ingresos.Panel1.SuspendLayout();
            this.spc_ingresos.Panel2.SuspendLayout();
            this.spc_ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_asignaciones)).BeginInit();
            this.spc_asignaciones.Panel1.SuspendLayout();
            this.spc_asignaciones.Panel2.SuspendLayout();
            this.spc_asignaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc_principal
            // 
            this.spc_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_principal.IsSplitterFixed = true;
            this.spc_principal.Location = new System.Drawing.Point(0, 0);
            this.spc_principal.Margin = new System.Windows.Forms.Padding(4);
            this.spc_principal.Name = "spc_principal";
            // 
            // spc_principal.Panel1
            // 
            this.spc_principal.Panel1.Controls.Add(this.llbl_logout);
            this.spc_principal.Panel1.Controls.Add(this.spc_reportes);
            this.spc_principal.Panel1.Controls.Add(this.spc_ingresos);
            this.spc_principal.Panel1.Controls.Add(this.spc_asignaciones);
            this.spc_principal.Size = new System.Drawing.Size(1173, 638);
            this.spc_principal.SplitterDistance = 313;
            this.spc_principal.SplitterWidth = 5;
            this.spc_principal.TabIndex = 0;
            // 
            // llbl_logout
            // 
            this.llbl_logout.AutoSize = true;
            this.llbl_logout.Location = new System.Drawing.Point(4, 603);
            this.llbl_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_logout.Name = "llbl_logout";
            this.llbl_logout.Size = new System.Drawing.Size(93, 17);
            this.llbl_logout.TabIndex = 0;
            this.llbl_logout.TabStop = true;
            this.llbl_logout.Text = "Cerrar sesión";
            this.llbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_logout_LinkClicked);
            // 
            // spc_reportes
            // 
            this.spc_reportes.IsSplitterFixed = true;
            this.spc_reportes.Location = new System.Drawing.Point(4, 370);
            this.spc_reportes.Margin = new System.Windows.Forms.Padding(4);
            this.spc_reportes.Name = "spc_reportes";
            this.spc_reportes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_reportes.Panel1
            // 
            this.spc_reportes.Panel1.Controls.Add(this.btn_MenuReportes);
            // 
            // spc_reportes.Panel2
            // 
            this.spc_reportes.Panel2.Controls.Add(this.linkLabel10);
            this.spc_reportes.Panel2.Controls.Add(this.linkLabel14);
            this.spc_reportes.Panel2.Controls.Add(this.linkLabel11);
            this.spc_reportes.Panel2.Controls.Add(this.linkLabel13);
            this.spc_reportes.Panel2.Controls.Add(this.linkLabel12);
            this.spc_reportes.Size = new System.Drawing.Size(276, 219);
            this.spc_reportes.SplitterDistance = 46;
            this.spc_reportes.SplitterWidth = 5;
            this.spc_reportes.TabIndex = 4;
            // 
            // btn_MenuReportes
            // 
            this.btn_MenuReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MenuReportes.Location = new System.Drawing.Point(0, 0);
            this.btn_MenuReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MenuReportes.Name = "btn_MenuReportes";
            this.btn_MenuReportes.Size = new System.Drawing.Size(276, 46);
            this.btn_MenuReportes.TabIndex = 4;
            this.btn_MenuReportes.Text = "Reportes";
            this.btn_MenuReportes.UseVisualStyleBackColor = true;
            this.btn_MenuReportes.Click += new System.EventHandler(this.btn_MenuReportes_Click);
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(91, 12);
            this.linkLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(80, 17);
            this.linkLabel10.TabIndex = 7;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "linkLabel10";
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Location = new System.Drawing.Point(91, 126);
            this.linkLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(80, 17);
            this.linkLabel14.TabIndex = 11;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "linkLabel14";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(91, 39);
            this.linkLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(80, 17);
            this.linkLabel11.TabIndex = 8;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "linkLabel11";
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Location = new System.Drawing.Point(91, 96);
            this.linkLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(80, 17);
            this.linkLabel13.TabIndex = 10;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "linkLabel13";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(91, 66);
            this.linkLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(80, 17);
            this.linkLabel12.TabIndex = 9;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "linkLabel12";
            // 
            // spc_ingresos
            // 
            this.spc_ingresos.IsSplitterFixed = true;
            this.spc_ingresos.Location = new System.Drawing.Point(4, 135);
            this.spc_ingresos.Margin = new System.Windows.Forms.Padding(4);
            this.spc_ingresos.Name = "spc_ingresos";
            this.spc_ingresos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_ingresos.Panel1
            // 
            this.spc_ingresos.Panel1.Controls.Add(this.btn_MenuIngresos);
            // 
            // spc_ingresos.Panel2
            // 
            this.spc_ingresos.Panel2.Controls.Add(this.linkLabel2);
            this.spc_ingresos.Panel2.Controls.Add(this.linkLabel1);
            this.spc_ingresos.Panel2.Controls.Add(this.llbl_ingresarcatedratico);
            this.spc_ingresos.Panel2.Controls.Add(this.llbl_ingresaralumno);
            this.spc_ingresos.Panel2.Controls.Add(this.llbl_ingresarcurso);
            this.spc_ingresos.Panel2.Controls.Add(this.llbl_carrfacupensum);
            this.spc_ingresos.Panel2.Controls.Add(this.llbl_salon);
            this.spc_ingresos.Size = new System.Drawing.Size(276, 228);
            this.spc_ingresos.SplitterDistance = 45;
            this.spc_ingresos.SplitterWidth = 5;
            this.spc_ingresos.TabIndex = 3;
            // 
            // btn_MenuIngresos
            // 
            this.btn_MenuIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MenuIngresos.Location = new System.Drawing.Point(0, 0);
            this.btn_MenuIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MenuIngresos.Name = "btn_MenuIngresos";
            this.btn_MenuIngresos.Size = new System.Drawing.Size(276, 45);
            this.btn_MenuIngresos.TabIndex = 3;
            this.btn_MenuIngresos.Text = "Ingresos";
            this.btn_MenuIngresos.UseVisualStyleBackColor = true;
            this.btn_MenuIngresos.Click += new System.EventHandler(this.btn_MenuIngresos_Click);
            // 
            // llbl_ingresarcatedratico
            // 
            this.llbl_ingresarcatedratico.AutoSize = true;
            this.llbl_ingresarcatedratico.Location = new System.Drawing.Point(73, 47);
            this.llbl_ingresarcatedratico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_ingresarcatedratico.Name = "llbl_ingresarcatedratico";
            this.llbl_ingresarcatedratico.Size = new System.Drawing.Size(134, 17);
            this.llbl_ingresarcatedratico.TabIndex = 5;
            this.llbl_ingresarcatedratico.TabStop = true;
            this.llbl_ingresarcatedratico.Text = "Ingresar catedratico";
            this.llbl_ingresarcatedratico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_ingresarcatedratico_LinkClicked);
            // 
            // llbl_ingresaralumno
            // 
            this.llbl_ingresaralumno.AutoSize = true;
            this.llbl_ingresaralumno.Location = new System.Drawing.Point(84, 15);
            this.llbl_ingresaralumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_ingresaralumno.Name = "llbl_ingresaralumno";
            this.llbl_ingresaralumno.Size = new System.Drawing.Size(111, 17);
            this.llbl_ingresaralumno.TabIndex = 0;
            this.llbl_ingresaralumno.TabStop = true;
            this.llbl_ingresaralumno.Text = "Ingresar Alumno";
            this.llbl_ingresaralumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // llbl_ingresarcurso
            // 
            this.llbl_ingresarcurso.AutoSize = true;
            this.llbl_ingresarcurso.Location = new System.Drawing.Point(84, 79);
            this.llbl_ingresarcurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_ingresarcurso.Name = "llbl_ingresarcurso";
            this.llbl_ingresarcurso.Size = new System.Drawing.Size(105, 17);
            this.llbl_ingresarcurso.TabIndex = 1;
            this.llbl_ingresarcurso.TabStop = true;
            this.llbl_ingresarcurso.Text = "Registrar curso";
            this.llbl_ingresarcurso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_ingresarcurso_LinkClicked);
            // 
            // llbl_carrfacupensum
            // 
            this.llbl_carrfacupensum.AutoSize = true;
            this.llbl_carrfacupensum.Location = new System.Drawing.Point(27, 108);
            this.llbl_carrfacupensum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_carrfacupensum.Name = "llbl_carrfacupensum";
            this.llbl_carrfacupensum.Size = new System.Drawing.Size(66, 17);
            this.llbl_carrfacupensum.TabIndex = 2;
            this.llbl_carrfacupensum.TabStop = true;
            this.llbl_carrfacupensum.Text = "Facultad ";
            this.llbl_carrfacupensum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_carrfacupensum_LinkClicked);
            // 
            // llbl_salon
            // 
            this.llbl_salon.AutoSize = true;
            this.llbl_salon.Location = new System.Drawing.Point(91, 136);
            this.llbl_salon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_salon.Name = "llbl_salon";
            this.llbl_salon.Size = new System.Drawing.Size(98, 17);
            this.llbl_salon.TabIndex = 3;
            this.llbl_salon.TabStop = true;
            this.llbl_salon.Text = "Ingresar salón";
            this.llbl_salon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_salon_LinkClicked);
            // 
            // spc_asignaciones
            // 
            this.spc_asignaciones.IsSplitterFixed = true;
            this.spc_asignaciones.Location = new System.Drawing.Point(4, 4);
            this.spc_asignaciones.Margin = new System.Windows.Forms.Padding(4);
            this.spc_asignaciones.Name = "spc_asignaciones";
            this.spc_asignaciones.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_asignaciones.Panel1
            // 
            this.spc_asignaciones.Panel1.Controls.Add(this.btn_MenuAsig);
            // 
            // spc_asignaciones.Panel2
            // 
            this.spc_asignaciones.Panel2.Controls.Add(this.llbl_AsignarCatedratico);
            this.spc_asignaciones.Panel2.Controls.Add(this.llbl_AsignarAlumno);
            this.spc_asignaciones.Size = new System.Drawing.Size(276, 124);
            this.spc_asignaciones.SplitterDistance = 47;
            this.spc_asignaciones.SplitterWidth = 5;
            this.spc_asignaciones.TabIndex = 2;
            // 
            // btn_MenuAsig
            // 
            this.btn_MenuAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MenuAsig.Location = new System.Drawing.Point(0, 0);
            this.btn_MenuAsig.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MenuAsig.Name = "btn_MenuAsig";
            this.btn_MenuAsig.Size = new System.Drawing.Size(276, 47);
            this.btn_MenuAsig.TabIndex = 2;
            this.btn_MenuAsig.Text = "Asignaciones";
            this.btn_MenuAsig.UseVisualStyleBackColor = true;
            this.btn_MenuAsig.Click += new System.EventHandler(this.btn_MenuAsig_Click);
            // 
            // llbl_AsignarCatedratico
            // 
            this.llbl_AsignarCatedratico.AutoSize = true;
            this.llbl_AsignarCatedratico.Location = new System.Drawing.Point(73, 38);
            this.llbl_AsignarCatedratico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_AsignarCatedratico.Name = "llbl_AsignarCatedratico";
            this.llbl_AsignarCatedratico.Size = new System.Drawing.Size(132, 17);
            this.llbl_AsignarCatedratico.TabIndex = 1;
            this.llbl_AsignarCatedratico.TabStop = true;
            this.llbl_AsignarCatedratico.Text = "Asignar Catedrático";
            this.llbl_AsignarCatedratico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_AsignarCatedratico_LinkClicked);
            // 
            // llbl_AsignarAlumno
            // 
            this.llbl_AsignarAlumno.AutoSize = true;
            this.llbl_AsignarAlumno.Location = new System.Drawing.Point(91, 11);
            this.llbl_AsignarAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_AsignarAlumno.Name = "llbl_AsignarAlumno";
            this.llbl_AsignarAlumno.Size = new System.Drawing.Size(107, 17);
            this.llbl_AsignarAlumno.TabIndex = 0;
            this.llbl_AsignarAlumno.TabStop = true;
            this.llbl_AsignarAlumno.Text = "Asignar Alumno";
            this.llbl_AsignarAlumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_AsignarAlumno_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(101, 108);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Carrera";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(165, 108);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 17);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Pensum";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 638);
            this.Controls.Add(this.spc_principal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Administrativo";
            this.Text = "Pantalla principal - Administrativo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Administrativo_FormClosed);
            this.Load += new System.EventHandler(this.Form_Administrativo_Load);
            this.spc_principal.Panel1.ResumeLayout(false);
            this.spc_principal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).EndInit();
            this.spc_principal.ResumeLayout(false);
            this.spc_reportes.Panel1.ResumeLayout(false);
            this.spc_reportes.Panel2.ResumeLayout(false);
            this.spc_reportes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_reportes)).EndInit();
            this.spc_reportes.ResumeLayout(false);
            this.spc_ingresos.Panel1.ResumeLayout(false);
            this.spc_ingresos.Panel2.ResumeLayout(false);
            this.spc_ingresos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_ingresos)).EndInit();
            this.spc_ingresos.ResumeLayout(false);
            this.spc_asignaciones.Panel1.ResumeLayout(false);
            this.spc_asignaciones.Panel2.ResumeLayout(false);
            this.spc_asignaciones.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_asignaciones)).EndInit();
            this.spc_asignaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_principal;
        private System.Windows.Forms.SplitContainer spc_reportes;
        private System.Windows.Forms.SplitContainer spc_ingresos;
        private System.Windows.Forms.SplitContainer spc_asignaciones;
        private System.Windows.Forms.LinkLabel llbl_AsignarAlumno;
        private System.Windows.Forms.LinkLabel llbl_AsignarCatedratico;
        private System.Windows.Forms.Button btn_MenuReportes;
        private System.Windows.Forms.Button btn_MenuIngresos;
        private System.Windows.Forms.Button btn_MenuAsig;
        private System.Windows.Forms.LinkLabel llbl_ingresaralumno;
        private System.Windows.Forms.LinkLabel llbl_ingresarcurso;
        private System.Windows.Forms.LinkLabel llbl_carrfacupensum;
        private System.Windows.Forms.LinkLabel llbl_salon;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel llbl_ingresarcatedratico;
        private System.Windows.Forms.LinkLabel llbl_logout;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

