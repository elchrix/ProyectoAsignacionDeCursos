namespace AsignaciondeCursos
{
    partial class form_MantenimientoCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientoCarrera));
            this.btn_elimnar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_carrera = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_ciclos = new System.Windows.Forms.ComboBox();
            this.cbo_idfacultad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombrecarrera = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_idcarrera = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_elimnar
            // 
            this.btn_elimnar.Location = new System.Drawing.Point(639, 350);
            this.btn_elimnar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_elimnar.Name = "btn_elimnar";
            this.btn_elimnar.Size = new System.Drawing.Size(86, 32);
            this.btn_elimnar.TabIndex = 56;
            this.btn_elimnar.Text = "Eliminar";
            this.btn_elimnar.UseVisualStyleBackColor = true;
            this.btn_elimnar.Click += new System.EventHandler(this.btn_elimnar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(637, 296);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(88, 32);
            this.btn_modificar.TabIndex = 54;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_carrera
            // 
            this.dgv_carrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_carrera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrera.Location = new System.Drawing.Point(23, 228);
            this.dgv_carrera.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_carrera.Name = "dgv_carrera";
            this.dgv_carrera.RowTemplate.Height = 24;
            this.dgv_carrera.Size = new System.Drawing.Size(581, 181);
            this.dgv_carrera.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_ciclos);
            this.groupBox2.Controls.Add(this.cbo_idfacultad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nombrecarrera);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_idcarrera);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(23, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(581, 129);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrera";
            // 
            // cbo_ciclos
            // 
            this.cbo_ciclos.FormattingEnabled = true;
            this.cbo_ciclos.Items.AddRange(new object[] {
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
            this.cbo_ciclos.Location = new System.Drawing.Point(307, 53);
            this.cbo_ciclos.Name = "cbo_ciclos";
            this.cbo_ciclos.Size = new System.Drawing.Size(61, 21);
            this.cbo_ciclos.TabIndex = 38;
            // 
            // cbo_idfacultad
            // 
            this.cbo_idfacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idfacultad.FormattingEnabled = true;
            this.cbo_idfacultad.Location = new System.Drawing.Point(226, 53);
            this.cbo_idfacultad.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_idfacultad.Name = "cbo_idfacultad";
            this.cbo_idfacultad.Size = new System.Drawing.Size(76, 21);
            this.cbo_idfacultad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nombre de Carrera:";
            // 
            // txt_nombrecarrera
            // 
            this.txt_nombrecarrera.Location = new System.Drawing.Point(374, 54);
            this.txt_nombrecarrera.Name = "txt_nombrecarrera";
            this.txt_nombrecarrera.Size = new System.Drawing.Size(185, 20);
            this.txt_nombrecarrera.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Facultad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Ingrese:";
            // 
            // txt_idcarrera
            // 
            this.txt_idcarrera.Location = new System.Drawing.Point(146, 54);
            this.txt_idcarrera.Name = "txt_idcarrera";
            this.txt_idcarrera.Size = new System.Drawing.Size(76, 20);
            this.txt_idcarrera.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Ciclos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = " Carrera:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(637, 119);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(79, 41);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(23, 414);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(58, 28);
            this.btn_actualizar.TabIndex = 59;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // form_MantenimientoCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 517);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_elimnar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_carrera);
            this.Name = "form_MantenimientoCarrera";
            this.Text = "form_MantenimientoCarrera";
            this.Load += new System.EventHandler(this.form_MantenimientoCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrera)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_elimnar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dgv_carrera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.ComboBox cbo_idfacultad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombrecarrera;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_idcarrera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_ciclos;
        private System.Windows.Forms.Button btn_actualizar;
    }
}