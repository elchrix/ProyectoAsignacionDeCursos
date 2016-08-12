namespace AsignaciondeCursos
{
    partial class form_CertificacionDeCursos
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
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_muestra = new System.Windows.Forms.DataGridView();
            this.btn_VistaPrevia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificado de cursos aprobados";
            // 
            // txt_carrera
            // 
            this.txt_carrera.Location = new System.Drawing.Point(55, 39);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(100, 20);
            this.txt_carrera.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_carrera, "Ingresa el codigo de carrera del alumno");
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(220, 39);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(100, 20);
            this.txt_anio.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_anio, "Ingresa el año de ingreso del alumno");
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(426, 39);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(100, 20);
            this.txt_uid.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_uid, "Ingresa el numero unico de identificacion del alumno");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UID";
            // 
            // dgv_muestra
            // 
            this.dgv_muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestra.Location = new System.Drawing.Point(33, 280);
            this.dgv_muestra.Name = "dgv_muestra";
            this.dgv_muestra.Size = new System.Drawing.Size(509, 150);
            this.dgv_muestra.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dgv_muestra, "Muestra los datos que se encontrarán impresos en el documento de vista previa");
            // 
            // btn_VistaPrevia
            // 
            this.btn_VistaPrevia.Location = new System.Drawing.Point(232, 201);
            this.btn_VistaPrevia.Name = "btn_VistaPrevia";
            this.btn_VistaPrevia.Size = new System.Drawing.Size(99, 43);
            this.btn_VistaPrevia.TabIndex = 5;
            this.btn_VistaPrevia.Text = "Vista Previa";
            this.toolTip1.SetToolTip(this.btn_VistaPrevia, "Genera la vista previa del certificado de cursos aprobados");
            this.btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.btn_VistaPrevia.Click += new System.EventHandler(this.btn_VistaPrevia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_uid);
            this.groupBox1.Controls.Add(this.txt_carrera);
            this.groupBox1.Controls.Add(this.txt_anio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Alumno";
            // 
            // form_CertificacionDeCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_VistaPrevia);
            this.Controls.Add(this.dgv_muestra);
            this.Controls.Add(this.label1);
            this.Name = "form_CertificacionDeCursos";
            this.Text = "Certificado de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_muestra;
        private System.Windows.Forms.Button btn_VistaPrevia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}