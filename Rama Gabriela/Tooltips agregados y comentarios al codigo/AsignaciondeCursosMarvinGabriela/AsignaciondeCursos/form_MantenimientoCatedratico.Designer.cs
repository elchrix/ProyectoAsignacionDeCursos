namespace AsignaciondeCursos
{
    partial class form_MantenimientoCatedratico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientoCatedratico));
            this.gpb_DatosAlumno = new System.Windows.Forms.GroupBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.dtp_fechaNacCto = new System.Windows.Forms.DateTimePicker();
            this.txt_correoCto = new System.Windows.Forms.TextBox();
            this.txt_direccionCto = new System.Windows.Forms.TextBox();
            this.txt_apellido2Cto = new System.Windows.Forms.TextBox();
            this.txt_apellido1Cto = new System.Windows.Forms.TextBox();
            this.txt_nombre2Cto = new System.Windows.Forms.TextBox();
            this.txt_nombre1Cto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_catedraticos = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.gpb_DatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catedraticos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_DatosAlumno
            // 
            this.gpb_DatosAlumno.Controls.Add(this.dtp_fechaNacCto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_correoCto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_direccionCto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_apellido2Cto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_apellido1Cto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_nombre2Cto);
            this.gpb_DatosAlumno.Controls.Add(this.txt_nombre1Cto);
            this.gpb_DatosAlumno.Controls.Add(this.label14);
            this.gpb_DatosAlumno.Controls.Add(this.label11);
            this.gpb_DatosAlumno.Controls.Add(this.label10);
            this.gpb_DatosAlumno.Controls.Add(this.label5);
            this.gpb_DatosAlumno.Controls.Add(this.label4);
            this.gpb_DatosAlumno.Location = new System.Drawing.Point(50, 12);
            this.gpb_DatosAlumno.Name = "gpb_DatosAlumno";
            this.gpb_DatosAlumno.Size = new System.Drawing.Size(571, 196);
            this.gpb_DatosAlumno.TabIndex = 14;
            this.gpb_DatosAlumno.TabStop = false;
            this.gpb_DatosAlumno.Text = "Datos del Catedratico:";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(639, 109);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(90, 31);
            this.btn_insertar.TabIndex = 32;
            this.btn_insertar.Text = "Guardar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // dtp_fechaNacCto
            // 
            this.dtp_fechaNacCto.Location = new System.Drawing.Point(187, 150);
            this.dtp_fechaNacCto.Name = "dtp_fechaNacCto";
            this.dtp_fechaNacCto.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaNacCto.TabIndex = 31;
            // 
            // txt_correoCto
            // 
            this.txt_correoCto.Location = new System.Drawing.Point(187, 115);
            this.txt_correoCto.Name = "txt_correoCto";
            this.txt_correoCto.Size = new System.Drawing.Size(259, 20);
            this.txt_correoCto.TabIndex = 30;
            // 
            // txt_direccionCto
            // 
            this.txt_direccionCto.Location = new System.Drawing.Point(187, 90);
            this.txt_direccionCto.Name = "txt_direccionCto";
            this.txt_direccionCto.Size = new System.Drawing.Size(259, 20);
            this.txt_direccionCto.TabIndex = 29;
            // 
            // txt_apellido2Cto
            // 
            this.txt_apellido2Cto.Location = new System.Drawing.Point(322, 54);
            this.txt_apellido2Cto.Name = "txt_apellido2Cto";
            this.txt_apellido2Cto.Size = new System.Drawing.Size(124, 20);
            this.txt_apellido2Cto.TabIndex = 28;
            // 
            // txt_apellido1Cto
            // 
            this.txt_apellido1Cto.Location = new System.Drawing.Point(187, 54);
            this.txt_apellido1Cto.Name = "txt_apellido1Cto";
            this.txt_apellido1Cto.Size = new System.Drawing.Size(129, 20);
            this.txt_apellido1Cto.TabIndex = 27;
            // 
            // txt_nombre2Cto
            // 
            this.txt_nombre2Cto.Location = new System.Drawing.Point(322, 31);
            this.txt_nombre2Cto.Name = "txt_nombre2Cto";
            this.txt_nombre2Cto.Size = new System.Drawing.Size(124, 20);
            this.txt_nombre2Cto.TabIndex = 26;
            // 
            // txt_nombre1Cto
            // 
            this.txt_nombre1Cto.Location = new System.Drawing.Point(187, 31);
            this.txt_nombre1Cto.Name = "txt_nombre1Cto";
            this.txt_nombre1Cto.Size = new System.Drawing.Size(129, 20);
            this.txt_nombre1Cto.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Apellido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fecha Nac:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(639, 411);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 32);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(639, 348);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 32);
            this.btn_modificar.TabIndex = 19;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_catedraticos
            // 
            this.dgv_catedraticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_catedraticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_catedraticos.Location = new System.Drawing.Point(50, 214);
            this.dgv_catedraticos.Name = "dgv_catedraticos";
            this.dgv_catedraticos.Size = new System.Drawing.Size(571, 259);
            this.dgv_catedraticos.TabIndex = 17;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(50, 479);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(58, 28);
            this.btn_actualizar.TabIndex = 21;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // form_MantenimientoCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 516);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_catedraticos);
            this.Controls.Add(this.gpb_DatosAlumno);
            this.Name = "form_MantenimientoCatedratico";
            this.Text = "form_MantenimientoCatedratico";
            this.Load += new System.EventHandler(this.form_MantenimientoCatedratico_Load);
            this.gpb_DatosAlumno.ResumeLayout(false);
            this.gpb_DatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catedraticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_DatosAlumno;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacCto;
        private System.Windows.Forms.TextBox txt_correoCto;
        private System.Windows.Forms.TextBox txt_direccionCto;
        private System.Windows.Forms.TextBox txt_apellido2Cto;
        private System.Windows.Forms.TextBox txt_apellido1Cto;
        private System.Windows.Forms.TextBox txt_nombre2Cto;
        private System.Windows.Forms.TextBox txt_nombre1Cto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.DataGridView dgv_catedraticos;
        private System.Windows.Forms.Button btn_actualizar;
    }
}