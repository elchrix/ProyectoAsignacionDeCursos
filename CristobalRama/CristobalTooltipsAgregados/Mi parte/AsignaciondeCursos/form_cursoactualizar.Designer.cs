﻿namespace AsignaciondeCursos
{
    partial class form_cursoactualizar
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
            this.gpb_DatosAlumno = new System.Windows.Forms.GroupBox();
            this.cbo_laboratorio = new System.Windows.Forms.ComboBox();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.txt_no_creditos = new System.Windows.Forms.TextBox();
            this.txt_creditos_necesarios = new System.Windows.Forms.TextBox();
            this.txt_prerrequisitos = new System.Windows.Forms.TextBox();
            this.txt_nombre_curso = new System.Windows.Forms.TextBox();
            this.txt_numero_ciclos = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_numero_sabado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.cbo_cod_carrera = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_curso = new System.Windows.Forms.ComboBox();
            this.gpb_DatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_DatosAlumno
            // 
            this.gpb_DatosAlumno.Controls.Add(this.cbo_curso);
            this.gpb_DatosAlumno.Controls.Add(this.cbo_laboratorio);
            this.gpb_DatosAlumno.Controls.Add(this.Btn_actualizar);
            this.gpb_DatosAlumno.Controls.Add(this.txt_no_creditos);
            this.gpb_DatosAlumno.Controls.Add(this.txt_creditos_necesarios);
            this.gpb_DatosAlumno.Controls.Add(this.txt_prerrequisitos);
            this.gpb_DatosAlumno.Controls.Add(this.txt_nombre_curso);
            this.gpb_DatosAlumno.Controls.Add(this.txt_numero_ciclos);
            this.gpb_DatosAlumno.Controls.Add(this.txt_numero);
            this.gpb_DatosAlumno.Controls.Add(this.txt_numero_sabado);
            this.gpb_DatosAlumno.Controls.Add(this.label14);
            this.gpb_DatosAlumno.Controls.Add(this.label13);
            this.gpb_DatosAlumno.Controls.Add(this.label12);
            this.gpb_DatosAlumno.Controls.Add(this.cbo_pensum);
            this.gpb_DatosAlumno.Controls.Add(this.cbo_cod_carrera);
            this.gpb_DatosAlumno.Controls.Add(this.label11);
            this.gpb_DatosAlumno.Controls.Add(this.label8);
            this.gpb_DatosAlumno.Controls.Add(this.label10);
            this.gpb_DatosAlumno.Controls.Add(this.label9);
            this.gpb_DatosAlumno.Controls.Add(this.label7);
            this.gpb_DatosAlumno.Controls.Add(this.label6);
            this.gpb_DatosAlumno.Controls.Add(this.label5);
            this.gpb_DatosAlumno.Controls.Add(this.label4);
            this.gpb_DatosAlumno.Controls.Add(this.label1);
            this.gpb_DatosAlumno.Controls.Add(this.label3);
            this.gpb_DatosAlumno.Controls.Add(this.label2);
            this.gpb_DatosAlumno.Location = new System.Drawing.Point(16, 172);
            this.gpb_DatosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_DatosAlumno.Name = "gpb_DatosAlumno";
            this.gpb_DatosAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_DatosAlumno.Size = new System.Drawing.Size(790, 287);
            this.gpb_DatosAlumno.TabIndex = 12;
            this.gpb_DatosAlumno.TabStop = false;
            this.gpb_DatosAlumno.Text = "Datos del Curso:";
            // 
            // cbo_laboratorio
            // 
            this.cbo_laboratorio.FormattingEnabled = true;
            this.cbo_laboratorio.Items.AddRange(new object[] {
            "Si ",
            "No"});
            this.cbo_laboratorio.Location = new System.Drawing.Point(418, 143);
            this.cbo_laboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_laboratorio.Name = "cbo_laboratorio";
            this.cbo_laboratorio.Size = new System.Drawing.Size(120, 24);
            this.cbo_laboratorio.TabIndex = 27;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(318, 225);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(104, 45);
            this.Btn_actualizar.TabIndex = 25;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // txt_no_creditos
            // 
            this.txt_no_creditos.Location = new System.Drawing.Point(418, 181);
            this.txt_no_creditos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_creditos.Name = "txt_no_creditos";
            this.txt_no_creditos.Size = new System.Drawing.Size(120, 22);
            this.txt_no_creditos.TabIndex = 24;
            // 
            // txt_creditos_necesarios
            // 
            this.txt_creditos_necesarios.Location = new System.Drawing.Point(164, 178);
            this.txt_creditos_necesarios.Margin = new System.Windows.Forms.Padding(4);
            this.txt_creditos_necesarios.Name = "txt_creditos_necesarios";
            this.txt_creditos_necesarios.Size = new System.Drawing.Size(120, 22);
            this.txt_creditos_necesarios.TabIndex = 23;
            // 
            // txt_prerrequisitos
            // 
            this.txt_prerrequisitos.Location = new System.Drawing.Point(663, 143);
            this.txt_prerrequisitos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prerrequisitos.Name = "txt_prerrequisitos";
            this.txt_prerrequisitos.Size = new System.Drawing.Size(111, 22);
            this.txt_prerrequisitos.TabIndex = 22;
            // 
            // txt_nombre_curso
            // 
            this.txt_nombre_curso.Location = new System.Drawing.Point(164, 143);
            this.txt_nombre_curso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_curso.Name = "txt_nombre_curso";
            this.txt_nombre_curso.Size = new System.Drawing.Size(120, 22);
            this.txt_nombre_curso.TabIndex = 20;
            // 
            // txt_numero_ciclos
            // 
            this.txt_numero_ciclos.Location = new System.Drawing.Point(663, 105);
            this.txt_numero_ciclos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_ciclos.Name = "txt_numero_ciclos";
            this.txt_numero_ciclos.Size = new System.Drawing.Size(111, 22);
            this.txt_numero_ciclos.TabIndex = 19;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(418, 105);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(120, 22);
            this.txt_numero.TabIndex = 18;
            // 
            // txt_numero_sabado
            // 
            this.txt_numero_sabado.Location = new System.Drawing.Point(164, 102);
            this.txt_numero_sabado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_sabado.Name = "txt_numero_sabado";
            this.txt_numero_sabado.Size = new System.Drawing.Size(120, 22);
            this.txt_numero_sabado.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre del curso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 178);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Creditos Necesarios:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Prerrequisitos:";
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(373, 58);
            this.cbo_pensum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(87, 24);
            this.cbo_pensum.TabIndex = 13;
            // 
            // cbo_cod_carrera
            // 
            this.cbo_cod_carrera.FormattingEnabled = true;
            this.cbo_cod_carrera.Location = new System.Drawing.Point(232, 58);
            this.cbo_cod_carrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_cod_carrera.Name = "cbo_cod_carrera";
            this.cbo_cod_carrera.Size = new System.Drawing.Size(95, 24);
            this.cbo_cod_carrera.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Laboratorio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "No. de Creditos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingrese:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "No. Ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero Sabado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod. Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pensum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Curso";
            // 
            // cbo_curso
            // 
            this.cbo_curso.FormattingEnabled = true;
            this.cbo_curso.Location = new System.Drawing.Point(496, 58);
            this.cbo_curso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_curso.Name = "cbo_curso";
            this.cbo_curso.Size = new System.Drawing.Size(95, 24);
            this.cbo_curso.TabIndex = 28;
            // 
            // form_cursoactualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 631);
            this.Controls.Add(this.gpb_DatosAlumno);
            this.Name = "form_cursoactualizar";
            this.Text = "form_cursoactualizar";
            this.Load += new System.EventHandler(this.form_cursoactualizar_Load);
            this.gpb_DatosAlumno.ResumeLayout(false);
            this.gpb_DatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_DatosAlumno;
        private System.Windows.Forms.ComboBox cbo_laboratorio;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_no_creditos;
        public System.Windows.Forms.TextBox txt_creditos_necesarios;
        public System.Windows.Forms.TextBox txt_prerrequisitos;
        public System.Windows.Forms.TextBox txt_nombre_curso;
        public System.Windows.Forms.TextBox txt_numero_ciclos;
        public System.Windows.Forms.TextBox txt_numero;
        public System.Windows.Forms.TextBox txt_numero_sabado;
        public System.Windows.Forms.ComboBox cbo_pensum;
        public System.Windows.Forms.ComboBox cbo_cod_carrera;
        public System.Windows.Forms.ComboBox cbo_curso;
    }
}