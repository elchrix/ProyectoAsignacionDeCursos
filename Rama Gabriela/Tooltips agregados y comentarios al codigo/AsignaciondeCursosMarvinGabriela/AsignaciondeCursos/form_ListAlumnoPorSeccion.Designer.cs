namespace AsignaciondeCursos
{
    partial class form_ListadoAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerarLista = new System.Windows.Forms.Button();
            this.cbo_facultad = new System.Windows.Forms.ComboBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbo_seccion = new System.Windows.Forms.ComboBox();
            this.cbo_curso = new System.Windows.Forms.ComboBox();
            this.dgv_muestra = new System.Windows.Forms.DataGridView();
            this.rdb_ListaPorCarrera = new System.Windows.Forms.RadioButton();
            this.rdb_ListaPorCurso = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_ListaPorSeccion = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curso";
            // 
            // btn_GenerarLista
            // 
            this.btn_GenerarLista.Location = new System.Drawing.Point(265, 225);
            this.btn_GenerarLista.Name = "btn_GenerarLista";
            this.btn_GenerarLista.Size = new System.Drawing.Size(104, 62);
            this.btn_GenerarLista.TabIndex = 8;
            this.btn_GenerarLista.Text = "Vista Previa";
            this.toolTip1.SetToolTip(this.btn_GenerarLista, "Genera una vista previa del reporte de alumnos");
            this.btn_GenerarLista.UseVisualStyleBackColor = true;
            this.btn_GenerarLista.Click += new System.EventHandler(this.btn_GenerarLista_Click);
            // 
            // cbo_facultad
            // 
            this.cbo_facultad.FormattingEnabled = true;
            this.cbo_facultad.Location = new System.Drawing.Point(58, 26);
            this.cbo_facultad.Name = "cbo_facultad";
            this.cbo_facultad.Size = new System.Drawing.Size(121, 21);
            this.cbo_facultad.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cbo_facultad, "Seleccione una facultad");
            this.cbo_facultad.SelectedIndexChanged += new System.EventHandler(this.cbo_facultad_SelectedIndexChanged);
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(243, 26);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(121, 21);
            this.cbo_carrera.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cbo_carrera, "Seleccione una carrera");
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // cbo_seccion
            // 
            this.cbo_seccion.FormattingEnabled = true;
            this.cbo_seccion.Location = new System.Drawing.Point(243, 73);
            this.cbo_seccion.Name = "cbo_seccion";
            this.cbo_seccion.Size = new System.Drawing.Size(121, 21);
            this.cbo_seccion.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cbo_seccion, "Seleccione una sección");
            // 
            // cbo_curso
            // 
            this.cbo_curso.FormattingEnabled = true;
            this.cbo_curso.Location = new System.Drawing.Point(58, 73);
            this.cbo_curso.Name = "cbo_curso";
            this.cbo_curso.Size = new System.Drawing.Size(121, 21);
            this.cbo_curso.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cbo_curso, "Seleccione un curso");
            this.cbo_curso.SelectedIndexChanged += new System.EventHandler(this.cbo_curso_SelectedIndexChanged);
            // 
            // dgv_muestra
            // 
            this.dgv_muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestra.Location = new System.Drawing.Point(1, 303);
            this.dgv_muestra.Name = "dgv_muestra";
            this.dgv_muestra.Size = new System.Drawing.Size(570, 145);
            this.dgv_muestra.TabIndex = 15;
            this.toolTip1.SetToolTip(this.dgv_muestra, "Datos que estarán impresos en la vista previa del reporte solicitado");
            // 
            // rdb_ListaPorCarrera
            // 
            this.rdb_ListaPorCarrera.AutoSize = true;
            this.rdb_ListaPorCarrera.Location = new System.Drawing.Point(28, 35);
            this.rdb_ListaPorCarrera.Name = "rdb_ListaPorCarrera";
            this.rdb_ListaPorCarrera.Size = new System.Drawing.Size(158, 17);
            this.rdb_ListaPorCarrera.TabIndex = 17;
            this.rdb_ListaPorCarrera.TabStop = true;
            this.rdb_ListaPorCarrera.Text = "Lista de alumnos por carrera";
            this.toolTip1.SetToolTip(this.rdb_ListaPorCarrera, "Habilita los campos correspondientes para generar el listado solicitado");
            this.rdb_ListaPorCarrera.UseVisualStyleBackColor = true;
            this.rdb_ListaPorCarrera.CheckedChanged += new System.EventHandler(this.rdb_ListaPorCarrera_CheckedChanged);
            // 
            // rdb_ListaPorCurso
            // 
            this.rdb_ListaPorCurso.AutoSize = true;
            this.rdb_ListaPorCurso.Location = new System.Drawing.Point(28, 58);
            this.rdb_ListaPorCurso.Name = "rdb_ListaPorCurso";
            this.rdb_ListaPorCurso.Size = new System.Drawing.Size(151, 17);
            this.rdb_ListaPorCurso.TabIndex = 18;
            this.rdb_ListaPorCurso.TabStop = true;
            this.rdb_ListaPorCurso.Text = "Lista de alumnos por curso";
            this.toolTip1.SetToolTip(this.rdb_ListaPorCurso, "Habilita los campos correspondientes para generar el listado solicitado");
            this.rdb_ListaPorCurso.UseVisualStyleBackColor = true;
            this.rdb_ListaPorCurso.CheckedChanged += new System.EventHandler(this.rdb_ListaPorCurso_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_ListaPorSeccion);
            this.groupBox1.Controls.Add(this.rdb_ListaPorCurso);
            this.groupBox1.Controls.Add(this.rdb_ListaPorCarrera);
            this.groupBox1.Location = new System.Drawing.Point(1, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Reporte";
            // 
            // rdb_ListaPorSeccion
            // 
            this.rdb_ListaPorSeccion.AutoSize = true;
            this.rdb_ListaPorSeccion.Location = new System.Drawing.Point(28, 81);
            this.rdb_ListaPorSeccion.Name = "rdb_ListaPorSeccion";
            this.rdb_ListaPorSeccion.Size = new System.Drawing.Size(162, 17);
            this.rdb_ListaPorSeccion.TabIndex = 19;
            this.rdb_ListaPorSeccion.TabStop = true;
            this.rdb_ListaPorSeccion.Text = "Lista de alumnos por sección";
            this.toolTip1.SetToolTip(this.rdb_ListaPorSeccion, "Habilita los campos correspondientes para generar el listado solicitado");
            this.rdb_ListaPorSeccion.UseVisualStyleBackColor = true;
            this.rdb_ListaPorSeccion.CheckedChanged += new System.EventHandler(this.rdb_ListaPorSeccion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_curso);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbo_seccion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo_carrera);
            this.groupBox2.Controls.Add(this.cbo_facultad);
            this.groupBox2.Location = new System.Drawing.Point(207, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 128);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reporte de Alumnos";
            // 
            // form_ListadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_muestra);
            this.Controls.Add(this.btn_GenerarLista);
            this.Name = "form_ListadoAlumno";
            this.Text = "Listado de Alumnos";
            this.Load += new System.EventHandler(this.form_ListadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GenerarLista;
        private System.Windows.Forms.ComboBox cbo_facultad;
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbo_seccion;
        private System.Windows.Forms.ComboBox cbo_curso;
        private System.Windows.Forms.DataGridView dgv_muestra;
        private System.Windows.Forms.RadioButton rdb_ListaPorCarrera;
        private System.Windows.Forms.RadioButton rdb_ListaPorCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_ListaPorSeccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}