namespace AsignaciondeCursos
{
    partial class form_AsignarCated
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
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.btn_asignación = new System.Windows.Forms.Button();
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cbo_año = new System.Windows.Forms.ComboBox();
            this.cbo_semestre = new System.Windows.Forms.ComboBox();
            this.lbl_hora1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chb_asignar1 = new System.Windows.Forms.CheckBox();
            this.cbo_sec1 = new System.Windows.Forms.ComboBox();
            this.cbo_jor1 = new System.Windows.Forms.ComboBox();
            this.lbl_cod1 = new System.Windows.Forms.Label();
            this.lbl_cur1 = new System.Windows.Forms.Label();
            this.txt_id_cat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(260, 108);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(212, 21);
            this.cbo_carrera.TabIndex = 0;
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(490, 108);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(97, 21);
            this.cbo_pensum.TabIndex = 1;
            this.cbo_pensum.SelectedIndexChanged += new System.EventHandler(this.cbo_pensum_SelectedIndexChanged);
            // 
            // btn_asignación
            // 
            this.btn_asignación.Location = new System.Drawing.Point(418, 12);
            this.btn_asignación.Name = "btn_asignación";
            this.btn_asignación.Size = new System.Drawing.Size(66, 63);
            this.btn_asignación.TabIndex = 2;
            this.btn_asignación.Text = "Asignar";
            this.btn_asignación.UseVisualStyleBackColor = true;
            this.btn_asignación.Click += new System.EventHandler(this.btn_asignación_Click);
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(15, 146);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.ReadOnly = true;
            this.dgv_cursos.Size = new System.Drawing.Size(855, 187);
            this.dgv_cursos.TabIndex = 3;
            this.dgv_cursos.DoubleClick += new System.EventHandler(this.dgv_cursos_DoubleClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(735, 339);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(135, 20);
            this.txt_buscar.TabIndex = 4;
            // 
            // cbo_año
            // 
            this.cbo_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_año.FormattingEnabled = true;
            this.cbo_año.Items.AddRange(new object[] {
            "2016\t",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbo_año.Location = new System.Drawing.Point(200, 12);
            this.cbo_año.Name = "cbo_año";
            this.cbo_año.Size = new System.Drawing.Size(62, 21);
            this.cbo_año.TabIndex = 5;
            // 
            // cbo_semestre
            // 
            this.cbo_semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_semestre.FormattingEnabled = true;
            this.cbo_semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_semestre.Location = new System.Drawing.Point(94, 12);
            this.cbo_semestre.Name = "cbo_semestre";
            this.cbo_semestre.Size = new System.Drawing.Size(62, 21);
            this.cbo_semestre.TabIndex = 6;
            this.cbo_semestre.SelectedIndexChanged += new System.EventHandler(this.cbo_semestre_SelectedIndexChanged);
            // 
            // lbl_hora1
            // 
            this.lbl_hora1.AutoSize = true;
            this.lbl_hora1.Location = new System.Drawing.Point(419, 90);
            this.lbl_hora1.Name = "lbl_hora1";
            this.lbl_hora1.Size = new System.Drawing.Size(41, 13);
            this.lbl_hora1.TabIndex = 100;
            this.lbl_hora1.Text = "label13";
            this.lbl_hora1.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(473, 65);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 13);
            this.label30.TabIndex = 97;
            this.label30.Text = "Horario:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(713, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 96;
            this.label29.Text = "Sección:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(293, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 95;
            this.label28.Text = "Jornada:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(82, 65);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 13);
            this.label27.TabIndex = 94;
            this.label27.Text = "Curso:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 93;
            this.label26.Text = "Codigo:";
            // 
            // chb_asignar1
            // 
            this.chb_asignar1.AutoSize = true;
            this.chb_asignar1.Location = new System.Drawing.Point(794, 86);
            this.chb_asignar1.Name = "chb_asignar1";
            this.chb_asignar1.Size = new System.Drawing.Size(61, 17);
            this.chb_asignar1.TabIndex = 91;
            this.chb_asignar1.Text = "Asignar";
            this.chb_asignar1.UseVisualStyleBackColor = true;
            this.chb_asignar1.Visible = false;
            // 
            // cbo_sec1
            // 
            this.cbo_sec1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sec1.FormattingEnabled = true;
            this.cbo_sec1.Location = new System.Drawing.Point(716, 83);
            this.cbo_sec1.Name = "cbo_sec1";
            this.cbo_sec1.Size = new System.Drawing.Size(44, 21);
            this.cbo_sec1.TabIndex = 89;
            this.cbo_sec1.Visible = false;
            this.cbo_sec1.SelectedIndexChanged += new System.EventHandler(this.cbo_sec1_SelectedIndexChanged);
            // 
            // cbo_jor1
            // 
            this.cbo_jor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_jor1.FormattingEnabled = true;
            this.cbo_jor1.Location = new System.Drawing.Point(292, 82);
            this.cbo_jor1.Name = "cbo_jor1";
            this.cbo_jor1.Size = new System.Drawing.Size(121, 21);
            this.cbo_jor1.TabIndex = 87;
            this.cbo_jor1.Visible = false;
            this.cbo_jor1.SelectedIndexChanged += new System.EventHandler(this.cbo_jor1_SelectedIndexChanged);
            // 
            // lbl_cod1
            // 
            this.lbl_cod1.AutoSize = true;
            this.lbl_cod1.Location = new System.Drawing.Point(5, 91);
            this.lbl_cod1.Name = "lbl_cod1";
            this.lbl_cod1.Size = new System.Drawing.Size(0, 13);
            this.lbl_cod1.TabIndex = 86;
            this.lbl_cod1.Visible = false;
            // 
            // lbl_cur1
            // 
            this.lbl_cur1.AutoSize = true;
            this.lbl_cur1.Location = new System.Drawing.Point(82, 91);
            this.lbl_cur1.Name = "lbl_cur1";
            this.lbl_cur1.Size = new System.Drawing.Size(42, 13);
            this.lbl_cur1.TabIndex = 85;
            this.lbl_cur1.Text = "curso 1";
            this.lbl_cur1.Visible = false;
            // 
            // txt_id_cat
            // 
            this.txt_id_cat.Location = new System.Drawing.Point(406, 19);
            this.txt_id_cat.Name = "txt_id_cat";
            this.txt_id_cat.Size = new System.Drawing.Size(71, 20);
            this.txt_id_cat.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_jor1);
            this.groupBox1.Controls.Add(this.txt_id_cat);
            this.groupBox1.Controls.Add(this.lbl_cur1);
            this.groupBox1.Controls.Add(this.lbl_hora1);
            this.groupBox1.Controls.Add(this.lbl_cod1);
            this.groupBox1.Controls.Add(this.cbo_sec1);
            this.groupBox1.Controls.Add(this.chb_asignar1);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 142);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "ID catedratico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Carrera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Pensum:";
            // 
            // form_AsignarCated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 560);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_semestre);
            this.Controls.Add(this.cbo_año);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_cursos);
            this.Controls.Add(this.btn_asignación);
            this.Controls.Add(this.cbo_pensum);
            this.Controls.Add(this.cbo_carrera);
            this.Name = "form_AsignarCated";
            this.Text = "form_AsignarCated";
            this.Load += new System.EventHandler(this.form_AsignarCated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbo_pensum;
        private System.Windows.Forms.Button btn_asignación;
        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cbo_año;
        private System.Windows.Forms.ComboBox cbo_semestre;
        private System.Windows.Forms.Label lbl_hora1;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.CheckBox chb_asignar1;
        public System.Windows.Forms.ComboBox cbo_sec1;
        public System.Windows.Forms.ComboBox cbo_jor1;
        public System.Windows.Forms.Label lbl_cod1;
        public System.Windows.Forms.Label lbl_cur1;
        private System.Windows.Forms.TextBox txt_id_cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}