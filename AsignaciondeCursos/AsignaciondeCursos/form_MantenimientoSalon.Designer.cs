namespace AsignaciondeCursos
{
    partial class form_MantenimientoSalon
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
            this.Btn_elimnar = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.dgv_salon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cantaprox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_edificio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_no_salon = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Btn_agregarsalon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_elimnar
            // 
            this.Btn_elimnar.Location = new System.Drawing.Point(389, 23);
            this.Btn_elimnar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_elimnar.Name = "Btn_elimnar";
            this.Btn_elimnar.Size = new System.Drawing.Size(65, 65);
            this.Btn_elimnar.TabIndex = 19;
            this.Btn_elimnar.Text = "Eliminar";
            this.Btn_elimnar.UseVisualStyleBackColor = true;
            this.Btn_elimnar.Click += new System.EventHandler(this.Btn_elimnar_Click);
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_actualizar.Location = new System.Drawing.Point(471, 23);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(65, 65);
            this.boton_actualizar.TabIndex = 18;
            this.boton_actualizar.UseVisualStyleBackColor = true;
            this.boton_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(309, 23);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.Btn_modificar.TabIndex = 17;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // dgv_salon
            // 
            this.dgv_salon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_salon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_salon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salon.Location = new System.Drawing.Point(103, 253);
            this.dgv_salon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_salon.Name = "dgv_salon";
            this.dgv_salon.RowTemplate.Height = 24;
            this.dgv_salon.Size = new System.Drawing.Size(580, 188);
            this.dgv_salon.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cantaprox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_edificio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_no_salon);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(103, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(580, 120);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon";
            // 
            // txt_cantaprox
            // 
            this.txt_cantaprox.Location = new System.Drawing.Point(378, 75);
            this.txt_cantaprox.Name = "txt_cantaprox";
            this.txt_cantaprox.Size = new System.Drawing.Size(72, 20);
            this.txt_cantaprox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Capacidad Aprox.";
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(187, 73);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(72, 20);
            this.txt_tamanio.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tamaño:";
            // 
            // cbo_edificio
            // 
            this.cbo_edificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_edificio.FormattingEnabled = true;
            this.cbo_edificio.Location = new System.Drawing.Point(320, 39);
            this.cbo_edificio.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_edificio.Name = "cbo_edificio";
            this.cbo_edificio.Size = new System.Drawing.Size(63, 21);
            this.cbo_edificio.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "-";
            // 
            // txt_no_salon
            // 
            this.txt_no_salon.Location = new System.Drawing.Point(236, 41);
            this.txt_no_salon.Name = "txt_no_salon";
            this.txt_no_salon.Size = new System.Drawing.Size(63, 20);
            this.txt_no_salon.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(242, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "No. Salon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(323, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Edificio";
            // 
            // Btn_agregarsalon
            // 
            this.Btn_agregarsalon.Location = new System.Drawing.Point(223, 23);
            this.Btn_agregarsalon.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_agregarsalon.Name = "Btn_agregarsalon";
            this.Btn_agregarsalon.Size = new System.Drawing.Size(65, 65);
            this.Btn_agregarsalon.TabIndex = 37;
            this.Btn_agregarsalon.Text = "Ingresar";
            this.Btn_agregarsalon.UseVisualStyleBackColor = true;
            this.Btn_agregarsalon.Click += new System.EventHandler(this.Btn_agregarsalon_Click);
            // 
            // form_MantenimientoSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 524);
            this.Controls.Add(this.Btn_agregarsalon);
            this.Controls.Add(this.Btn_elimnar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.dgv_salon);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_MantenimientoSalon";
            this.Text = "form_MantenimientoSalon";
            this.Load += new System.EventHandler(this.form_MantenimientoSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_elimnar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.DataGridView dgv_salon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_agregarsalon;
        private System.Windows.Forms.TextBox txt_cantaprox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tamanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_edificio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_no_salon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
    }
}