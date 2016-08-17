namespace AsignaciondeCursos
{
    partial class form_ModificarCarrera
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_ciclos = new System.Windows.Forms.ComboBox();
            this.cbo_id__facultad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_carrera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_ciclos);
            this.groupBox1.Controls.Add(this.cbo_id__facultad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_carrera);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_carrera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(581, 129);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrera";
            // 
            // cbo_ciclos
            // 
            this.cbo_ciclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbo_ciclos.Location = new System.Drawing.Point(482, 54);
            this.cbo_ciclos.Name = "cbo_ciclos";
            this.cbo_ciclos.Size = new System.Drawing.Size(58, 21);
            this.cbo_ciclos.TabIndex = 38;
            // 
            // cbo_id__facultad
            // 
            this.cbo_id__facultad.Enabled = false;
            this.cbo_id__facultad.FormattingEnabled = true;
            this.cbo_id__facultad.Location = new System.Drawing.Point(162, 54);
            this.cbo_id__facultad.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_id__facultad.Name = "cbo_id__facultad";
            this.cbo_id__facultad.Size = new System.Drawing.Size(113, 21);
            this.cbo_id__facultad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre de Carrera:";
            // 
            // txt_nombre_carrera
            // 
            this.txt_nombre_carrera.Location = new System.Drawing.Point(280, 53);
            this.txt_nombre_carrera.Name = "txt_nombre_carrera";
            this.txt_nombre_carrera.Size = new System.Drawing.Size(196, 20);
            this.txt_nombre_carrera.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Facultad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ingrese:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(280, 24);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_carrera
            // 
            this.txt_carrera.Location = new System.Drawing.Point(81, 55);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.ReadOnly = true;
            this.txt_carrera.Size = new System.Drawing.Size(76, 20);
            this.txt_carrera.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ciclos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Carrera:";
            // 
            // form_ModificarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificar);
            this.Name = "form_ModificarCarrera";
            this.Text = "form_ModificarCarrera";
            this.Load += new System.EventHandler(this.form_ModificarCarrera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbo_id__facultad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_nombre_carrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbo_ciclos;
    }
}