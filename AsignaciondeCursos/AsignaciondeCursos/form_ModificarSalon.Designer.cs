namespace AsignaciondeCursos
{
    partial class form_ModificarSalon
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_estatus = new System.Windows.Forms.ComboBox();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.txt_cantaprox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_edificio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_no_salon = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_estatus);
            this.groupBox1.Controls.Add(this.txt_cantaprox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_edificio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_no_salon);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(11, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(580, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estatus:";
            // 
            // cbo_estatus
            // 
            this.cbo_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estatus.FormattingEnabled = true;
            this.cbo_estatus.Items.AddRange(new object[] {
            "Vacio",
            "Ocupado"});
            this.cbo_estatus.Location = new System.Drawing.Point(477, 76);
            this.cbo_estatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_estatus.Name = "cbo_estatus";
            this.cbo_estatus.Size = new System.Drawing.Size(81, 21);
            this.cbo_estatus.TabIndex = 42;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(267, 11);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.Btn_actualizar.TabIndex = 37;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // txt_cantaprox
            // 
            this.txt_cantaprox.Location = new System.Drawing.Point(320, 78);
            this.txt_cantaprox.Name = "txt_cantaprox";
            this.txt_cantaprox.Size = new System.Drawing.Size(72, 20);
            this.txt_cantaprox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Capacidad Aprox.";
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(117, 78);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(72, 20);
            this.txt_tamanio.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tamaño:";
            // 
            // cbo_edificio
            // 
            this.cbo_edificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_edificio.FormattingEnabled = true;
            this.cbo_edificio.Location = new System.Drawing.Point(320, 44);
            this.cbo_edificio.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_edificio.Name = "cbo_edificio";
            this.cbo_edificio.Size = new System.Drawing.Size(63, 21);
            this.cbo_edificio.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "-";
            // 
            // txt_no_salon
            // 
            this.txt_no_salon.Location = new System.Drawing.Point(236, 46);
            this.txt_no_salon.Name = "txt_no_salon";
            this.txt_no_salon.Size = new System.Drawing.Size(63, 20);
            this.txt_no_salon.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(242, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "No. Salon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(323, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Edificio";
            // 
            // form_ModificarSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_actualizar);
            this.Name = "form_ModificarSalon";
            this.Text = "form_ModificarSalon";
            this.Load += new System.EventHandler(this.form_ModificarSalon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbo_estatus;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.TextBox txt_cantaprox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_tamanio;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo_edificio;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txt_no_salon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
    }
}