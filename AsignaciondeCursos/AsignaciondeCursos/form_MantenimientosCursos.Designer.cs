namespace AsignaciondeCursos
{
    partial class form_MantenimientosCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientosCursos));
            this.cbo_laboratorio = new System.Windows.Forms.ComboBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_no_creditos = new System.Windows.Forms.TextBox();
            this.txt_creditos_necesarios = new System.Windows.Forms.TextBox();
            this.txt_prerrequisitos = new System.Windows.Forms.TextBox();
            this.txt_nombre_curso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.cbo_cod_carrera = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cod_curso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_elimnar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.cbo_numero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_numero_ciclos = new System.Windows.Forms.ComboBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_laboratorio
            // 
            this.cbo_laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_laboratorio.FormattingEnabled = true;
            this.cbo_laboratorio.Items.AddRange(new object[] {
            "S ",
            "N"});
            this.cbo_laboratorio.Location = new System.Drawing.Point(133, 94);
            this.cbo_laboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_laboratorio.Name = "cbo_laboratorio";
            this.cbo_laboratorio.Size = new System.Drawing.Size(91, 21);
            this.cbo_laboratorio.TabIndex = 57;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(157, 28);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(65, 65);
            this.btn_ingresar.TabIndex = 56;
            this.btn_ingresar.Text = "Agregar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_no_creditos
            // 
            this.txt_no_creditos.Location = new System.Drawing.Point(133, 120);
            this.txt_no_creditos.Name = "txt_no_creditos";
            this.txt_no_creditos.Size = new System.Drawing.Size(91, 20);
            this.txt_no_creditos.TabIndex = 55;
            // 
            // txt_creditos_necesarios
            // 
            this.txt_creditos_necesarios.Location = new System.Drawing.Point(134, 146);
            this.txt_creditos_necesarios.Name = "txt_creditos_necesarios";
            this.txt_creditos_necesarios.Size = new System.Drawing.Size(91, 20);
            this.txt_creditos_necesarios.TabIndex = 54;
            // 
            // txt_prerrequisitos
            // 
            this.txt_prerrequisitos.Location = new System.Drawing.Point(448, 156);
            this.txt_prerrequisitos.Name = "txt_prerrequisitos";
            this.txt_prerrequisitos.Size = new System.Drawing.Size(84, 20);
            this.txt_prerrequisitos.TabIndex = 53;
            // 
            // txt_nombre_curso
            // 
            this.txt_nombre_curso.Location = new System.Drawing.Point(134, 69);
            this.txt_nombre_curso.Name = "txt_nombre_curso";
            this.txt_nombre_curso.Size = new System.Drawing.Size(229, 20);
            this.txt_nombre_curso.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Nombre del curso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Creditos Necesarios:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Prerrequisitos:";
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(448, 74);
            this.cbo_pensum.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(84, 21);
            this.cbo_pensum.TabIndex = 43;
            this.cbo_pensum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_pensum_MouseClick);
            // 
            // cbo_cod_carrera
            // 
            this.cbo_cod_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cod_carrera.FormattingEnabled = true;
            this.cbo_cod_carrera.Location = new System.Drawing.Point(243, 27);
            this.cbo_cod_carrera.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_cod_carrera.Name = "cbo_cod_carrera";
            this.cbo_cod_carrera.Size = new System.Drawing.Size(72, 21);
            this.cbo_cod_carrera.TabIndex = 40;
            this.cbo_cod_carrera.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_cod_carrera_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Laboratorio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Creditos otorgados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "No. Ciclo:";
            // 
            // txt_cod_curso
            // 
            this.txt_cod_curso.Location = new System.Drawing.Point(349, 28);
            this.txt_cod_curso.Name = "txt_cod_curso";
            this.txt_cod_curso.Size = new System.Drawing.Size(56, 20);
            this.txt_cod_curso.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cod. Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cod Curso";
            // 
            // Btn_elimnar
            // 
            this.Btn_elimnar.Location = new System.Drawing.Point(317, 28);
            this.Btn_elimnar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_elimnar.Name = "Btn_elimnar";
            this.Btn_elimnar.Size = new System.Drawing.Size(65, 65);
            this.Btn_elimnar.TabIndex = 47;
            this.Btn_elimnar.Text = "Eliminar";
            this.Btn_elimnar.UseVisualStyleBackColor = true;
            this.Btn_elimnar.Click += new System.EventHandler(this.Btn_elimnar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(239, 27);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.Btn_modificar.TabIndex = 42;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // dgv_curso
            // 
            this.dgv_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_curso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Location = new System.Drawing.Point(55, 299);
            this.dgv_curso.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.RowTemplate.Height = 24;
            this.dgv_curso.Size = new System.Drawing.Size(580, 184);
            this.dgv_curso.TabIndex = 41;
            // 
            // cbo_numero
            // 
            this.cbo_numero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_numero.FormattingEnabled = true;
            this.cbo_numero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbo_numero.Location = new System.Drawing.Point(448, 129);
            this.cbo_numero.Name = "cbo_numero";
            this.cbo_numero.Size = new System.Drawing.Size(84, 21);
            this.cbo_numero.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Pensum:";
            // 
            // cbo_numero_ciclos
            // 
            this.cbo_numero_ciclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_numero_ciclos.FormattingEnabled = true;
            this.cbo_numero_ciclos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_numero_ciclos.Location = new System.Drawing.Point(448, 100);
            this.cbo_numero_ciclos.Name = "cbo_numero_ciclos";
            this.cbo_numero_ciclos.Size = new System.Drawing.Size(84, 21);
            this.cbo_numero_ciclos.TabIndex = 60;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(404, 27);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 61;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_cod_carrera);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_numero_ciclos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cod_curso);
            this.groupBox1.Controls.Add(this.cbo_numero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_laboratorio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_no_creditos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_creditos_necesarios);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_prerrequisitos);
            this.groupBox1.Controls.Add(this.cbo_pensum);
            this.groupBox1.Controls.Add(this.txt_nombre_curso);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(55, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 187);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso:";
            // 
            // form_MantenimientosCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.Btn_elimnar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.dgv_curso);
            this.Name = "form_MantenimientosCursos";
            this.Text = "form_MantenimientosCursos";
            this.Load += new System.EventHandler(this.form_MantenimientosCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_laboratorio;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_no_creditos;
        private System.Windows.Forms.TextBox txt_creditos_necesarios;
        private System.Windows.Forms.TextBox txt_prerrequisitos;
        private System.Windows.Forms.TextBox txt_nombre_curso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_pensum;
        private System.Windows.Forms.ComboBox cbo_cod_carrera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cod_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_elimnar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.ComboBox cbo_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_numero_ciclos;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}