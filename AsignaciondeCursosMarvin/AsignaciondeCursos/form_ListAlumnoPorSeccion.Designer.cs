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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerarLista = new System.Windows.Forms.Button();
            this.cbo_facultad = new System.Windows.Forms.ComboBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbo_seccion = new System.Windows.Forms.ComboBox();
            this.cbo_curso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv_muestra = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curso";
            // 
            // btn_GenerarLista
            // 
            this.btn_GenerarLista.Location = new System.Drawing.Point(90, 205);
            this.btn_GenerarLista.Name = "btn_GenerarLista";
            this.btn_GenerarLista.Size = new System.Drawing.Size(175, 114);
            this.btn_GenerarLista.TabIndex = 8;
            this.btn_GenerarLista.Text = "Vista Previa";
            this.btn_GenerarLista.UseVisualStyleBackColor = true;
            this.btn_GenerarLista.Click += new System.EventHandler(this.btn_GenerarLista_Click);
            // 
            // cbo_facultad
            // 
            this.cbo_facultad.FormattingEnabled = true;
            this.cbo_facultad.Location = new System.Drawing.Point(142, 74);
            this.cbo_facultad.Name = "cbo_facultad";
            this.cbo_facultad.Size = new System.Drawing.Size(121, 21);
            this.cbo_facultad.TabIndex = 9;
            this.cbo_facultad.Text = "Seleccione una opcion";
            this.cbo_facultad.SelectedIndexChanged += new System.EventHandler(this.cbo_facultad_SelectedIndexChanged);
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(393, 74);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(121, 21);
            this.cbo_carrera.TabIndex = 10;
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // cbo_seccion
            // 
            this.cbo_seccion.FormattingEnabled = true;
            this.cbo_seccion.Location = new System.Drawing.Point(142, 142);
            this.cbo_seccion.Name = "cbo_seccion";
            this.cbo_seccion.Size = new System.Drawing.Size(121, 21);
            this.cbo_seccion.TabIndex = 11;
            // 
            // cbo_curso
            // 
            this.cbo_curso.FormattingEnabled = true;
            this.cbo_curso.Location = new System.Drawing.Point(393, 142);
            this.cbo_curso.Name = "cbo_curso";
            this.cbo_curso.Size = new System.Drawing.Size(121, 21);
            this.cbo_curso.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // dgv_muestra
            // 
            this.dgv_muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestra.Location = new System.Drawing.Point(12, 325);
            this.dgv_muestra.Name = "dgv_muestra";
            this.dgv_muestra.Size = new System.Drawing.Size(606, 150);
            this.dgv_muestra.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // form_ListadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_muestra);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_curso);
            this.Controls.Add(this.cbo_seccion);
            this.Controls.Add(this.cbo_carrera);
            this.Controls.Add(this.cbo_facultad);
            this.Controls.Add(this.btn_GenerarLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_ListadoAlumno";
            this.Text = "Listado de Alumnos";
            this.Load += new System.EventHandler(this.form_ListadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgv_muestra;
        private System.Windows.Forms.TextBox textBox1;
    }
}