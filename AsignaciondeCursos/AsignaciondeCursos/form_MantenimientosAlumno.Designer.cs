namespace AsignaciondeCursos
{
    partial class form_MantenimientosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientosAlumno));
            this.gpb_DatosAlumno = new System.Windows.Forms.GroupBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.dtp_nac_alumno = new System.Windows.Forms.DateTimePicker();
            this.txt_apellido2a = new System.Windows.Forms.TextBox();
            this.txt_apellido1a = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_nombre2a = new System.Windows.Forms.TextBox();
            this.txt_correoa = new System.Windows.Forms.TextBox();
            this.txt_direcciona = new System.Windows.Forms.TextBox();
            this.txt_nombre1a = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_carne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminarA = new System.Windows.Forms.Button();
            this.btn_ingresara = new System.Windows.Forms.Button();
            this.dgw_alumnos = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.gpb_DatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_DatosAlumno
            // 
            this.gpb_DatosAlumno.Controls.Add(this.cbo_carrera);
            this.gpb_DatosAlumno.Controls.Add(this.label6);
            this.gpb_DatosAlumno.Controls.Add(this.cbo_pensum);
            this.gpb_DatosAlumno.Controls.Add(this.label12);
            this.gpb_DatosAlumno.Controls.Add(this.lbl_carrera);
            this.gpb_DatosAlumno.Controls.Add(this.dtp_nac_alumno);
            this.gpb_DatosAlumno.Controls.Add(this.txt_apellido2a);
            this.gpb_DatosAlumno.Controls.Add(this.txt_apellido1a);
            this.gpb_DatosAlumno.Controls.Add(this.label14);
            this.gpb_DatosAlumno.Controls.Add(this.txt_nombre2a);
            this.gpb_DatosAlumno.Controls.Add(this.txt_correoa);
            this.gpb_DatosAlumno.Controls.Add(this.txt_direcciona);
            this.gpb_DatosAlumno.Controls.Add(this.txt_nombre1a);
            this.gpb_DatosAlumno.Controls.Add(this.label11);
            this.gpb_DatosAlumno.Controls.Add(this.label8);
            this.gpb_DatosAlumno.Controls.Add(this.label10);
            this.gpb_DatosAlumno.Controls.Add(this.label9);
            this.gpb_DatosAlumno.Controls.Add(this.label7);
            this.gpb_DatosAlumno.Controls.Add(this.txt_carne);
            this.gpb_DatosAlumno.Controls.Add(this.label5);
            this.gpb_DatosAlumno.Controls.Add(this.txt_anio);
            this.gpb_DatosAlumno.Controls.Add(this.label4);
            this.gpb_DatosAlumno.Controls.Add(this.label1);
            this.gpb_DatosAlumno.Controls.Add(this.label3);
            this.gpb_DatosAlumno.Controls.Add(this.label2);
            this.gpb_DatosAlumno.Location = new System.Drawing.Point(62, 12);
            this.gpb_DatosAlumno.Name = "gpb_DatosAlumno";
            this.gpb_DatosAlumno.Size = new System.Drawing.Size(561, 257);
            this.gpb_DatosAlumno.TabIndex = 12;
            this.gpb_DatosAlumno.TabStop = false;
            this.gpb_DatosAlumno.Text = "Datos del Alumno:";
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(147, 41);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(63, 21);
            this.cbo_carrera.TabIndex = 14;
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pensum:";
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(357, 177);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(113, 21);
            this.cbo_pensum.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Carrera:";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Location = new System.Drawing.Point(115, 185);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(40, 13);
            this.lbl_carrera.TabIndex = 20;
            this.lbl_carrera.Text = "carrera";
            this.lbl_carrera.Visible = false;
            // 
            // dtp_nac_alumno
            // 
            this.dtp_nac_alumno.Location = new System.Drawing.Point(118, 217);
            this.dtp_nac_alumno.Name = "dtp_nac_alumno";
            this.dtp_nac_alumno.Size = new System.Drawing.Size(200, 20);
            this.dtp_nac_alumno.TabIndex = 9;
            this.dtp_nac_alumno.Value = new System.DateTime(2016, 8, 4, 22, 2, 24, 0);
            // 
            // txt_apellido2a
            // 
            this.txt_apellido2a.Location = new System.Drawing.Point(298, 94);
            this.txt_apellido2a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido2a.Name = "txt_apellido2a";
            this.txt_apellido2a.Size = new System.Drawing.Size(172, 20);
            this.txt_apellido2a.TabIndex = 6;
            // 
            // txt_apellido1a
            // 
            this.txt_apellido1a.Location = new System.Drawing.Point(118, 94);
            this.txt_apellido1a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido1a.Name = "txt_apellido1a";
            this.txt_apellido1a.Size = new System.Drawing.Size(171, 20);
            this.txt_apellido1a.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Apellido:";
            // 
            // txt_nombre2a
            // 
            this.txt_nombre2a.Location = new System.Drawing.Point(298, 69);
            this.txt_nombre2a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre2a.Name = "txt_nombre2a";
            this.txt_nombre2a.Size = new System.Drawing.Size(172, 20);
            this.txt_nombre2a.TabIndex = 4;
            // 
            // txt_correoa
            // 
            this.txt_correoa.Location = new System.Drawing.Point(118, 143);
            this.txt_correoa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correoa.Name = "txt_correoa";
            this.txt_correoa.Size = new System.Drawing.Size(352, 20);
            this.txt_correoa.TabIndex = 8;
            // 
            // txt_direcciona
            // 
            this.txt_direcciona.Location = new System.Drawing.Point(118, 119);
            this.txt_direcciona.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direcciona.Name = "txt_direcciona";
            this.txt_direcciona.Size = new System.Drawing.Size(352, 20);
            this.txt_direcciona.TabIndex = 7;
            // 
            // txt_nombre1a
            // 
            this.txt_nombre1a.Location = new System.Drawing.Point(118, 69);
            this.txt_nombre1a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre1a.Name = "txt_nombre1a";
            this.txt_nombre1a.Size = new System.Drawing.Size(171, 20);
            this.txt_nombre1a.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fecha Nac:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingrese carné:";
            // 
            // txt_carne
            // 
            this.txt_carne.Location = new System.Drawing.Point(295, 42);
            this.txt_carne.Name = "txt_carne";
            this.txt_carne.Size = new System.Drawing.Size(82, 20);
            this.txt_carne.TabIndex = 2;
            this.txt_carne.TextChanged += new System.EventHandler(this.txt_carne_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(232, 42);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(41, 20);
            this.txt_anio.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod. Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año";
            // 
            // btn_eliminarA
            // 
            this.btn_eliminarA.Location = new System.Drawing.Point(659, 441);
            this.btn_eliminarA.Name = "btn_eliminarA";
            this.btn_eliminarA.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarA.TabIndex = 12;
            this.btn_eliminarA.Text = "Eliminar";
            this.btn_eliminarA.UseVisualStyleBackColor = true;
            this.btn_eliminarA.Click += new System.EventHandler(this.btn_eliminarA_Click);
            // 
            // btn_ingresara
            // 
            this.btn_ingresara.Location = new System.Drawing.Point(659, 135);
            this.btn_ingresara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresara.Name = "btn_ingresara";
            this.btn_ingresara.Size = new System.Drawing.Size(64, 26);
            this.btn_ingresara.TabIndex = 10;
            this.btn_ingresara.Text = "Ingresar";
            this.btn_ingresara.UseVisualStyleBackColor = true;
            this.btn_ingresara.Click += new System.EventHandler(this.btn_ingresara_Click);
            // 
            // dgw_alumnos
            // 
            this.dgw_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_alumnos.Location = new System.Drawing.Point(62, 285);
            this.dgw_alumnos.Name = "dgw_alumnos";
            this.dgw_alumnos.Size = new System.Drawing.Size(561, 225);
            this.dgw_alumnos.TabIndex = 13;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(659, 371);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(62, 516);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(58, 28);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // form_MantenimientosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 546);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgw_alumnos);
            this.Controls.Add(this.btn_ingresara);
            this.Controls.Add(this.btn_eliminarA);
            this.Controls.Add(this.gpb_DatosAlumno);
            this.Name = "form_MantenimientosAlumno";
            this.Text = "form_MantenimientosAlumno";
            this.Load += new System.EventHandler(this.form_MantenimientosAlumno_Load);
            this.gpb_DatosAlumno.ResumeLayout(false);
            this.gpb_DatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_DatosAlumno;
        private System.Windows.Forms.DateTimePicker dtp_nac_alumno;
        private System.Windows.Forms.Button btn_eliminarA;
        private System.Windows.Forms.Button btn_ingresara;
        private System.Windows.Forms.TextBox txt_apellido2a;
        private System.Windows.Forms.TextBox txt_apellido1a;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_nombre2a;
        private System.Windows.Forms.TextBox txt_correoa;
        private System.Windows.Forms.TextBox txt_direcciona;
        private System.Windows.Forms.TextBox txt_nombre1a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_carne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgw_alumnos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_pensum;
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_actualizar;
    }
}