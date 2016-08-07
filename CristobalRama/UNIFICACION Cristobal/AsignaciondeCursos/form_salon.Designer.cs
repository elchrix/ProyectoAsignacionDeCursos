namespace AsignaciondeCursos
{
    partial class form_salon
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
            this.Btn_agregarsalon = new System.Windows.Forms.Button();
            this.txt_cantaprox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_edificio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_no_salon = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Btn_elimnar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.dgv_salon = new System.Windows.Forms.DataGridView();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_agregarsalon);
            this.groupBox1.Controls.Add(this.txt_cantaprox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_edificio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_no_salon);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(774, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon";
            // 
            // Btn_agregarsalon
            // 
            this.Btn_agregarsalon.Location = new System.Drawing.Point(326, 148);
            this.Btn_agregarsalon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_agregarsalon.Name = "Btn_agregarsalon";
            this.Btn_agregarsalon.Size = new System.Drawing.Size(115, 34);
            this.Btn_agregarsalon.TabIndex = 37;
            this.Btn_agregarsalon.Text = "Ingresar";
            this.Btn_agregarsalon.UseVisualStyleBackColor = true;
            this.Btn_agregarsalon.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_cantaprox
            // 
            this.txt_cantaprox.Location = new System.Drawing.Point(504, 99);
            this.txt_cantaprox.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantaprox.Name = "txt_cantaprox";
            this.txt_cantaprox.Size = new System.Drawing.Size(95, 22);
            this.txt_cantaprox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Capacidad Aprox.";
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(249, 96);
            this.txt_tamanio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(95, 22);
            this.txt_tamanio.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tamaño:";
            // 
            // cbo_edificio
            // 
            this.cbo_edificio.FormattingEnabled = true;
            this.cbo_edificio.Location = new System.Drawing.Point(427, 54);
            this.cbo_edificio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_edificio.Name = "cbo_edificio";
            this.cbo_edificio.Size = new System.Drawing.Size(83, 24);
            this.cbo_edificio.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 61);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "-";
            // 
            // txt_no_salon
            // 
            this.txt_no_salon.Location = new System.Drawing.Point(315, 56);
            this.txt_no_salon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_salon.Name = "txt_no_salon";
            this.txt_no_salon.Size = new System.Drawing.Size(83, 22);
            this.txt_no_salon.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 35);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "No. Salon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(431, 35);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Edificio";
            // 
            // Btn_elimnar
            // 
            this.Btn_elimnar.Location = new System.Drawing.Point(416, 554);
            this.Btn_elimnar.Name = "Btn_elimnar";
            this.Btn_elimnar.Size = new System.Drawing.Size(118, 47);
            this.Btn_elimnar.TabIndex = 14;
            this.Btn_elimnar.Text = "Eliminar";
            this.Btn_elimnar.UseVisualStyleBackColor = true;
            this.Btn_elimnar.Click += new System.EventHandler(this.Btn_elimnar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(271, 554);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(118, 47);
            this.Btn_modificar.TabIndex = 12;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // dgv_salon
            // 
            this.dgv_salon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_salon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_salon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salon.Location = new System.Drawing.Point(26, 267);
            this.dgv_salon.Name = "dgv_salon";
            this.dgv_salon.RowTemplate.Height = 24;
            this.dgv_salon.Size = new System.Drawing.Size(774, 232);
            this.dgv_salon.TabIndex = 11;
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.BackgroundImage = global::AsignaciondeCursos.Properties.Resources.refresh2;
            this.boton_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_actualizar.Location = new System.Drawing.Point(13, 523);
            this.boton_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(63, 44);
            this.boton_actualizar.TabIndex = 13;
            this.boton_actualizar.UseVisualStyleBackColor = true;
            this.boton_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // form_salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 631);
            this.Controls.Add(this.Btn_elimnar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.dgv_salon);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_salon";
            this.Text = "form_EdificioSalon";
            this.Load += new System.EventHandler(this.form_EdificioSalon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button Btn_elimnar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.DataGridView dgv_salon;
    }
}